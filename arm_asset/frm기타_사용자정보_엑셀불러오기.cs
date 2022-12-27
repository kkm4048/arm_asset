using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace arm_asset
{
    public partial class frm기타_사용자정보_엑셀불러오기 : Form
    {
        String sql = "";
        public string rFileName = "";
        public frm기타_사용자정보_엑셀불러오기()
        {
            InitializeComponent();
        }
        public frm기타_사용자정보_엑셀불러오기(string iFileName)
        {
            InitializeComponent();
            rFileName = iFileName;
        }

        private void btn엑셀_불러오기_Click(object sender, EventArgs e)
        {

        }
        private void LoadExcel()
        {

            Cursor.Current = Cursors.WaitCursor;

            try
            {
                // sprList.ActiveSheet.OpenExcel(rfileName, 0);
                spr.OpenExcel(rFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            Cursor.Current = Cursors.Default;

        }

        private void frm기타_부대_엑셀불러오기_Load(object sender, EventArgs e)
        {
            LoadExcel();
            초기화();
         }
     
        private void 초기화()
        {

            헤드();            

        }
        private void 헤드()
        {
            int i= 0;
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "승인상태";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "사용자ID";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "사용자명";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "권한";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "관리부대명";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "신분";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "계급";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "신청소속명";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소속부대명";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "담당분야";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "직책명";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "전화번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "군전화번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "이메일";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "승인일시";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "최근로그인일시";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "";

        }

        private void btn닫기_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn저장_Click(object sender, EventArgs e)
        {
            저장();
        }

        private void 저장()
        {


            int i, cnt=0;
            String 아이디,암호,소속,성명,계급,등급,연락처, 비고,구분;

            for (i = 1; i < spr.ActiveSheet.RowCount; i++)
            {
                lblCnt2.Text = i.ToString();
                Application.DoEvents();

                아이디 = spr.ActiveSheet.Cells[i, 1].Text.Trim();
                암호 = spr.ActiveSheet.Cells[i, 1].Text.Trim() + "!@#";
                소속 = spr.ActiveSheet.Cells[i, 4].Text.Trim();
                성명 = spr.ActiveSheet.Cells[i, 2].Text.Trim();
                계급 = spr.ActiveSheet.Cells[i, 6].Text.Trim();
                등급 = "관리자";
                연락처 = spr.ActiveSheet.Cells[i, 12].Text.Trim();
                비고 = "";
                구분 = "";

                if (아이디.Equals(""))
                {
                    MessageBox.Show("저장완료");
                    return;
                }
                sql = "select * from a101_user  WHERE id  = '" + 아이디  + "'   ";
                DataSet ds = cls_com.Select_Query(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                }
                else
                {
                    cnt++;
                    sql = "";
                    sql = sql + "insert into a101_user  (id,pw,sosok,nm,cla,degree,tel,bigo,gubun) values ('";
                    sql = sql + 아이디 + "','" + 암호 + "','" + 소속 + "','" + 성명 + "','" + 계급 + "','" + 등급 + "','" + 연락처 + "','" + 비고 + "','" + 구분 + "' ) ";

                    cls_com.ExcuteNonQuery(sql);
                    cls_com.로그_자산(cls_com.사용자.성명, "엑셀 사용자 등록", "등록", sql);

                }

                Application.DoEvents();
            }
        }
    
        private void btn조회_Click(object sender, EventArgs e)
        {
            
        }
    }

}

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
    public partial class frm기타_소모품_엑셀불러오기 : Form
    {
        String sql = "";
        public string rFileName = "";
        public frm기타_소모품_엑셀불러오기()
        {
            InitializeComponent();
        }
        public frm기타_소모품_엑셀불러오기(string iFileName)
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

        private void frm기타_소모품_엑셀불러오기_Load(object sender, EventArgs e)
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
            int i = 0;
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "제품분류";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "제품명";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "제조사";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "모델명";

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

            int i, j,cnt=0;
            String 소모품번호 = "";
            String[] b = new String[100];
            
            for (i = 1; i < spr.ActiveSheet.RowCount; i++)
            {
                lblCnt2.Text = i.ToString();
                Application.DoEvents();

                for (j = 0; j < 50; j++)
                {
                    b[j] = spr.ActiveSheet.Cells[i, j].Text.Trim();
                }

                if (b[0].Equals("") && b[1].Equals("") && b[2].Equals("") && b[3].Equals(""))
                {
                    MessageBox.Show(cnt.ToString() + " 건 저장 완료");
                    return;
                }
                sql = "select * from b101_con  WHERE d1 = '" + b[0].Trim() + "' and d2 = '" + b[1].Trim() + "' and d3 = '" + b[2].Trim() + "' and d4 = '" + b[3].Trim() + "' ";
                DataSet ds = cls_com.Select_Query(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    /*
                    소모품번호 = ds.Tables[0].Rows[0]["code"].ToString();
                    val = "";
                    for (j = 1; j < cls_com.g타이틀_수량; j++)
                    {
                        val = val + ",d" + (j).ToString() + " = '" + spr.ActiveSheet.Cells[i, j-1].Text.Replace("'","''") +"' ";
                    }
                    sql = "update b101_con set   + " + val + " where code = '" + 소모품번호 + "' ";
                    cls_com.ExcuteNonQuery(sql);
                    cls_com.로그_소모품(cls_com.사용자.성명, "엑셀 자산 등록", "수정", sql);
                    */
                }
                else
                {
                    cnt++;
                    소모품번호 = cls_com.소모품번호_가져오기();
                    sql = "insert into b101_con  (code,dt,state,d1,d2,d3,d4 ) values ('" + 소모품번호 + "','" + cls_com.GetDate() + "','','" + b[0].Trim() + "','" + b[1].Trim() + "','" + b[2].Trim() + "','" + b[3].Trim() + "' )";
                    cls_com.ExcuteNonQuery(sql);
                    cls_com.로그_소모품(cls_com.사용자.성명, "엑셀 소모품 등록", "등록", sql);

                }

                Application.DoEvents();
            }
        }
    
        private void btn조회_Click(object sender, EventArgs e)
        {
            
        }
    }

}

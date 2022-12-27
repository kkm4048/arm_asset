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
    public partial class frm기타_부대_엑셀불러오기 : Form
    {
        String sql = "";
        public string rFileName = "";
        public frm기타_부대_엑셀불러오기()
        {
            InitializeComponent();
        }
        public frm기타_부대_엑셀불러오기(string iFileName)
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
            spr.ActiveSheet.ColumnHeader.Cells[0, 0].Text = "부대코드";
            spr.ActiveSheet.ColumnHeader.Cells[0, 1].Text = "부대명";
            spr.ActiveSheet.ColumnHeader.Cells[0, 2].Text = "위치";
            spr.ActiveSheet.ColumnHeader.Cells[0, 3].Text = "연락처";
            spr.ActiveSheet.ColumnHeader.Cells[0, 4].Text = "주소";
            spr.ActiveSheet.ColumnHeader.Cells[0, 5].Text = "담당자";
            spr.ActiveSheet.ColumnHeader.Cells[0, 6].Text = "부대 전체 경로";

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
            String[] b = new String[100];
            String[] 부대 = new string[100];
            
            for (i = 1; i < spr.ActiveSheet.RowCount; i++)
            {
                lblCnt2.Text = i.ToString();
                Application.DoEvents();

                for (j = 0; j < 50; j++)
                {
                    b[j] = spr.ActiveSheet.Cells[i, j].Text.Trim();
                }

                if (b[0].Equals("") && b[1].Equals("") )
                {
                    MessageBox.Show(cnt.ToString() + " 건 저장 완료");
                    return;
                }
                for ( j = 0; j < 6;j++ )
                {
                    부대[j] = "";
                }

                부대 = b[3].Split('>');

                if (부대.Length < 6) {
                    int k = 부대.Length;
                    Array.Resize(ref 부대, 6);
                    for (j = k; j < 6; j++)
                    {
                        부대[j] = "";
                    }
                }
                


                sql = "select * from a101_arm  WHERE arm_code  = '" + b[0].Trim() + "'   ";
                DataSet ds = cls_com.Select_Query(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    sql = " update  a101_arm set arm = '" + b[1].Trim() 
                       + "',arm1 = '" + 부대[0].Trim() + "',arm2 = '" + 부대[1].Trim() + "',arm3 = '" + 부대[2].Trim() + "',arm4 = '" + 부대[3].Trim() + "',arm5 = '" + 부대[4].Trim() + "',arm6 = '" + 부대[5].Trim() + "' ";
                    cls_com.ExcuteNonQuery(sql);
                    cls_com.로그_자산(cls_com.사용자.성명, "엑셀 부대 등록", "수정", sql);
                }
                else
                {
                    cnt++;
                    sql = "";
                    sql = sql + "insert into a101_arm  (arm_code,arm,loc,tel,address,usr,arm1,arm2,arm3,arm4,arm5,arm6) values ('";
                    sql = sql + b[0].Trim() + "','" + b[1].Trim() + "','','','','','" ;
                    sql = sql + 부대[0].Trim() + "','" + 부대[1].Trim() + "','" + 부대[2].Trim() + "','" + 부대[3].Trim() + "','" + 부대[4].Trim() + "','" + 부대[5].Trim() + "' ) ";

                    cls_com.ExcuteNonQuery(sql);
                    cls_com.로그_자산(cls_com.사용자.성명, "엑셀 부대 등록", "등록", sql);

                }

                Application.DoEvents();
            }
        }
    
        private void btn조회_Click(object sender, EventArgs e)
        {
            
        }
    }

}

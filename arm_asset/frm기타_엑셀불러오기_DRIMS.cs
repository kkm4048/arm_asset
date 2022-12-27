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
    public partial class frm기타_엑셀불러오기_DRIMS : Form
    {
        String sql = "";
        public string rFileName = "";
        public frm기타_엑셀불러오기_DRIMS()
        {
            InitializeComponent();
        }
        public frm기타_엑셀불러오기_DRIMS(string iFileName)
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

        private void frm기타_엑셀불러오기_DRIMS_Load(object sender, EventArgs e)
        {
            LoadExcel();
            초기화();
            Add소속부대();
        }
        private void Add소속부대()
        {
            cmb소속부대.Items.Clear();
            sql = "select * from a101_arm order by arm_code ";

            DataSet ds = cls_com.Select_Query(sql);
            if (ds == null) return;
            cmb소속부대.Items.Clear();
            cmb소속부대.Items.Add("");
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cmb소속부대.Items.Add(ds.Tables[0].Rows[i]["arm_code"].ToString() + " " + ds.Tables[0].Rows[i]["arm"].ToString());
                }
            }
        }
        private void 초기화()
        {
            int i = 0;
            
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "관리번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "도입년월일";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "자원분류";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "제조사";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "모델명";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "자원상태";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "자원관리부대";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "도입방법";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "설치부대";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "설치부대 전체경로";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "설치장소";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "시리얼";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "관리자";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "사업명";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "장비명";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "회계처리여부";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "사용자관리번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "최종수정일";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "자원관리부대코드";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "비고";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "사용여부";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "예비여부";
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

            int i, j, k;
            String var = "", val = "";
            String 자산번호 = "" ,관리번호 = "";
            String w = "";
            String[] b = new String[100];
            k = 0;
            // if (cmb소속부대.Text.Equals(""))
            // {
            //     MessageBox.Show("기본 소속 부대 선택 하세요");
            //     return;
            // }

            sql = "DELETE from a201_asset_drims ";
            cls_com.ExcuteNonQuery(sql);
            for (i = 1; i < spr.ActiveSheet.RowCount; i++)
            {
                lblCnt2.Text = i.ToString();
                Application.DoEvents();

                for (j = 0; j < 50; j++)
                {
                    b[j] = spr.ActiveSheet.Cells[i, j].Text.Trim();
                    if (b[j].Equals("-"))
                    {
                        b[j] = "";
                    }
                }
                관리번호 = b[0].Trim();

                if (!관리번호.Trim().Equals(""))
                {
                    k = 0;
                }
                else
                {
                    k++;
                    if (k > 10)
                    {
                        MessageBox.Show("저장 완료");
                        Close();
                        return;

                    }
                    continue;
                }

                if (!관리번호.Trim().Equals(""))
                {
                    w = " where d1 = '" + 관리번호 + "' ";
                
                }
                sql = "select * from a201_asset_drims  " + w;
                DataSet ds = cls_com.Select_Query(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {

                    MessageBox.Show(i.ToString() + "  관리번호:" + 관리번호 + " 중복 관리번호 ");
                    
                }
                else
                {
                    자산번호 = "";
                    var = "";
                    val = "";
                    for (j = 1; j <= 22; j++)
                    {
                        var = var + ",d" + (j).ToString();
                        val = val + ",'" + spr.ActiveSheet.Cells[i, j-1].Text.ToString().Trim().Replace("'","''")  + "' ";
                    }
                    sql = "insert into a201_asset_drims (code,dt,state,arm_code " + var + " ) values ('" + 자산번호 + "','" + cls_com.GetDate() + "','','" + cls_com.GetCode(cmb소속부대.Text) + "'"
                        + ",'" + b[0].Replace("'","''") + "' "
                        + ",'" + b[11].Replace("'", "''") + "' "
                        + ",'" + b[1].Replace("'", "''") + "' "
                        + ",'" + b[2].Replace("'", "''") + "' "
                        + ",'" + b[3].Replace("'", "''") + "' "
                        + ",'" + b[4].Replace("'", "''") + "' "
                        + ",'" + b[5].Replace("'", "''") + "' "
                        + ",'" + b[6].Replace("'", "''") + "' "
                        + ",'" + b[7].Replace("'", "''") + "' "
                        + ",'" + b[8].Replace("'", "''") + "' "
                        + ",'" + b[9].Replace("'", "''") + "' "
                        + ",'" + b[10].Replace("'", "''") + "' "
                        + ",'" + b[12].Replace("'", "''") + "' "
                        + ",'" + b[13].Replace("'", "''") + "' "
                        + ",'" + b[14].Replace("'", "''") + "' "
                        + ",'" + b[15].Replace("'", "''") + "' "
                        + ",'" + b[16].Replace("'", "''") + "' "
                        + ",'" + b[17].Replace("'", "''") + "' "
                        + ",'" + b[18].Replace("'", "''") + "' "
                        + ",'" + b[19].Replace("'", "''") + "' "
                        + ",'" + b[20].Replace("'", "''") + "' "
                        + ",'" + b[21].Replace("'", "''") + "' "
                        + " ) "; 
                    cls_com.ExcuteNonQuery(sql);
                }

                Application.DoEvents();
            }
        }
    
        private void btn조회_Click(object sender, EventArgs e)
        {
            
        }
    }

}
 
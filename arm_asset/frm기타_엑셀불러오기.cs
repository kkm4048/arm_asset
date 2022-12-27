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
    public partial class frm기타_엑셀불러오기 : Form
    {
        String sql = "";
        public string rFileName = "";
        public frm기타_엑셀불러오기()
        {
            InitializeComponent();
        }
        public frm기타_엑셀불러오기(string iFileName)
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

        private void frm기타_엑셀불러오기_Load(object sender, EventArgs e)
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
            spr.ActiveSheet.ColumnHeader.Cells[0, 0].Text = "일련번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, 1].Text = "관리번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, 2].Text = "자원관리부대";
            spr.ActiveSheet.ColumnHeader.Cells[0, 3].Text = "자원상태";
            spr.ActiveSheet.ColumnHeader.Cells[0, 4].Text = "자원구분";
            spr.ActiveSheet.ColumnHeader.Cells[0, 5].Text = "자원분류";
            spr.ActiveSheet.ColumnHeader.Cells[0, 6].Text = "제조사";
            spr.ActiveSheet.ColumnHeader.Cells[0, 7].Text = "모델명";
            spr.ActiveSheet.ColumnHeader.Cells[0, 8].Text = "도입년월일";
            spr.ActiveSheet.ColumnHeader.Cells[0, 9].Text = "도입방법";
            spr.ActiveSheet.ColumnHeader.Cells[0, 10].Text = "설치부대";
            spr.ActiveSheet.ColumnHeader.Cells[0, 11].Text = "설치부대전체경로";
            spr.ActiveSheet.ColumnHeader.Cells[0, 12].Text = "설치장소";
            spr.ActiveSheet.ColumnHeader.Cells[0, 13].Text = "시리얼번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, 14].Text = "관리자";
            spr.ActiveSheet.ColumnHeader.Cells[0, 15].Text = "사업명";
            spr.ActiveSheet.ColumnHeader.Cells[0, 16].Text = "장비명";
            spr.ActiveSheet.ColumnHeader.Cells[0, 17].Text = "회계처리여부";
            spr.ActiveSheet.ColumnHeader.Cells[0, 18].Text = "재활용영부";
            spr.ActiveSheet.ColumnHeader.Cells[0, 19].Text = "도입단가";
            spr.ActiveSheet.ColumnHeader.Cells[0, 20].Text = "사용자관리";
            spr.ActiveSheet.ColumnHeader.Cells[0, 21].Text = "최종수정일";
                /*
            spr.ActiveSheet.ColumnHeader.Cells[0, 0].Text = "관리번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, 1].Text = "도입년월일";
            spr.ActiveSheet.ColumnHeader.Cells[0, 2].Text = "자원분류";
            spr.ActiveSheet.ColumnHeader.Cells[0, 3].Text = "제조사";
            spr.ActiveSheet.ColumnHeader.Cells[0, 4].Text = "모델명";
            spr.ActiveSheet.ColumnHeader.Cells[0, 5].Text = "자원상태";
            spr.ActiveSheet.ColumnHeader.Cells[0, 6].Text = "자원관리부대";
            spr.ActiveSheet.ColumnHeader.Cells[0, 7].Text = "도입방법";
            spr.ActiveSheet.ColumnHeader.Cells[0, 8].Text = "설치부대";
            spr.ActiveSheet.ColumnHeader.Cells[0, 9].Text = "설치부대 전체경로";
            spr.ActiveSheet.ColumnHeader.Cells[0, 10].Text = "설치장소";
            spr.ActiveSheet.ColumnHeader.Cells[0, 11].Text = "시리얼번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, 12].Text = "관리자";
            spr.ActiveSheet.ColumnHeader.Cells[0, 13].Text = "사업명";
            spr.ActiveSheet.ColumnHeader.Cells[0, 14].Text = "장비명";
            spr.ActiveSheet.ColumnHeader.Cells[0, 15].Text = "회계처리여부";
            spr.ActiveSheet.ColumnHeader.Cells[0, 16].Text = "사용자관리번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, 17].Text = "최종수정일";
            spr.ActiveSheet.ColumnHeader.Cells[0, 18].Text = "자원관리부대코드";
            spr.ActiveSheet.ColumnHeader.Cells[0, 19].Text = "비고";
            spr.ActiveSheet.ColumnHeader.Cells[0, 20].Text = "사용여부";
            spr.ActiveSheet.ColumnHeader.Cells[0, 21].Text = "예비여부";
            */


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
            if (cmb소속부대.Text.Equals(""))
            {
                MessageBox.Show("기본 소속 부대 선택 하세요");
                return;
            }
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
                관리번호 = b[1].Trim();

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
                sql = "select * from a201_asset  " + w;
                DataSet ds = cls_com.Select_Query(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    자산번호 = ds.Tables[0].Rows[0]["code"].ToString();
                    val = "";
                    val = val + ",d" + (1).ToString() + " = '" + spr.ActiveSheet.Cells[i, 1].Text.Replace("'","''") +"' \n";
                    val = val + ",d" + (2).ToString() + " = '" + spr.ActiveSheet.Cells[i, 13].Text.Replace("'", "''") + "' \n";
                    val = val + ",d" + (3).ToString() + " = '" + spr.ActiveSheet.Cells[i, 8].Text.Replace("'", "''") + "' \n";
                    val = val + ",d" + (4).ToString() + " = '" + spr.ActiveSheet.Cells[i, 5 ].Text.Replace("'", "''") + "' \n";
                    val = val + ",d" + (5).ToString() + " = '" + spr.ActiveSheet.Cells[i, 6].Text.Replace("'", "''") + "' \n";
                    val = val + ",d" + (6).ToString() + " = '" + spr.ActiveSheet.Cells[i, 7].Text.Replace("'", "''") + "' \n";
                    val = val + ",d" + (7).ToString() + " = '" + spr.ActiveSheet.Cells[i, 3].Text.Replace("'", "''") + "' \n";
                    val = val + ",d" + (8).ToString() + " = '" + spr.ActiveSheet.Cells[i, 2].Text.Replace("'", "''") + "' \n";
                    val = val + ",d" + (9).ToString() + " = '" + spr.ActiveSheet.Cells[i, 9].Text.Replace("'", "''") + "' \n";
                    val = val + ",d" + (10).ToString() + " = '" + spr.ActiveSheet.Cells[i, 10].Text.Replace("'", "''") + "' \n";
                    val = val + ",d" + (11).ToString() + " = '" + spr.ActiveSheet.Cells[i, 11].Text.Replace("'", "''") + "' \n";
                    val = val + ",d" + (12).ToString() + " = '" + spr.ActiveSheet.Cells[i, 12].Text.Replace("'", "''") + "' \n";
                    val = val + ",d" + (13).ToString() + " = '" + spr.ActiveSheet.Cells[i, 14].Text.Replace("'", "''") + "' \n";
                    val = val + ",d" + (14).ToString() + " = '" + spr.ActiveSheet.Cells[i, 15].Text.Replace("'", "''") + "' \n";
                    val = val + ",d" + (15).ToString() + " = '" + spr.ActiveSheet.Cells[i, 16].Text.Replace("'", "''") + "' \n";
                    val = val + ",d" + (16).ToString() + " = '" + spr.ActiveSheet.Cells[i, 17].Text.Replace("'", "''") + "' \n";
                    val = val + ",d" + (17).ToString() + " = '" + spr.ActiveSheet.Cells[i, 4].Text.Replace("'", "''") + "' \n";
                    val = val + ",d" + (18).ToString() + " = '" + spr.ActiveSheet.Cells[i, 22].Text.Replace("'", "''") + "' \n";
                    val = val + ",d" + (19).ToString() + " = '" + spr.ActiveSheet.Cells[i, 2].Text.Replace("'", "''") + "' \n";
                    val = val + ",d" + (20).ToString() + " = '" +  "" +  "' \n";
                    val = val + ",d" + (21).ToString() + " = '" + ""  + "' \n";     // 자원관리번호 대신 자원구분 항목으로 대처
                    val = val + ",d" + (22).ToString() + " = '" + "" + "' \n";

                    sql = "update a201_asset set   arm_code = '" + cls_com.GetCode(cmb소속부대.Text) + "'" + val + " where code = '" + 자산번호 + "' ";
                    cls_com.ExcuteNonQuery(sql);
                    cls_com.로그(cls_com.사용자.성명, "엑셀 자산 등록", "수정", sql);
                }
                else
                {
                    자산번호 = cls_com.자산번호_가져오기();
                    var = "";
                    val = "";
                    var = var + ",d" + (1).ToString();  val = val + ",'" + spr.ActiveSheet.Cells[i, 1].Text.ToString().Trim().Replace("'","''")  + "' ";
                    var = var + ",d" + (2).ToString(); val = val + ",'" + spr.ActiveSheet.Cells[i, 13].Text.ToString().Trim().Replace("'", "''") + "' ";
                    var = var + ",d" + (3).ToString(); val = val + ",'" + spr.ActiveSheet.Cells[i, 8].Text.ToString().Trim().Replace("'", "''") + "' ";
                    var = var + ",d" + (4).ToString(); val = val + ",'" + spr.ActiveSheet.Cells[i, 5].Text.ToString().Trim().Replace("'", "''") + "' ";
                    var = var + ",d" + (5).ToString(); val = val + ",'" + spr.ActiveSheet.Cells[i, 6].Text.ToString().Trim().Replace("'", "''") + "' ";
                    var = var + ",d" + (6).ToString(); val = val + ",'" + spr.ActiveSheet.Cells[i, 7].Text.ToString().Trim().Replace("'", "''") + "' ";
                    var = var + ",d" + (7).ToString(); val = val + ",'" + spr.ActiveSheet.Cells[i, 3].Text.ToString().Trim().Replace("'", "''") + "' ";
                    var = var + ",d" + (8).ToString(); val = val + ",'" + spr.ActiveSheet.Cells[i, 2].Text.ToString().Trim().Replace("'", "''") + "' ";
                    var = var + ",d" + (9).ToString(); val = val + ",'" + spr.ActiveSheet.Cells[i, 9].Text.ToString().Trim().Replace("'", "''") + "' ";
                    var = var + ",d" + (10).ToString(); val = val + ",'" + spr.ActiveSheet.Cells[i, 10].Text.ToString().Trim().Replace("'", "''") + "' ";
                    var = var + ",d" + (11).ToString(); val = val + ",'" + spr.ActiveSheet.Cells[i, 11].Text.ToString().Trim().Replace("'", "''") + "' ";
                    var = var + ",d" + (12).ToString(); val = val + ",'" + spr.ActiveSheet.Cells[i, 12].Text.ToString().Trim().Replace("'", "''") + "' ";
                    var = var + ",d" + (13).ToString(); val = val + ",'" + spr.ActiveSheet.Cells[i, 14].Text.ToString().Trim().Replace("'", "''") + "' ";
                    var = var + ",d" + (14).ToString(); val = val + ",'" + spr.ActiveSheet.Cells[i, 15].Text.ToString().Trim().Replace("'", "''") + "' ";
                    var = var + ",d" + (15).ToString(); val = val + ",'" + spr.ActiveSheet.Cells[i, 16].Text.ToString().Trim().Replace("'", "''") + "' ";
                    var = var + ",d" + (16).ToString(); val = val + ",'" + spr.ActiveSheet.Cells[i, 17].Text.ToString().Trim().Replace("'", "''") + "' ";
                    var = var + ",d" + (17).ToString(); val = val + ",'" + spr.ActiveSheet.Cells[i, 4].Text.ToString().Trim().Replace("'", "''") + "' ";
                    var = var + ",d" + (18).ToString(); val = val + ",'" + spr.ActiveSheet.Cells[i, 22].Text.ToString().Trim().Replace("'", "''") + "' ";
                    var = var + ",d" + (19).ToString(); val = val + ",'" + spr.ActiveSheet.Cells[i, 2].Text.ToString().Trim().Replace("'", "''") + "' ";
                    var = var + ",d" + (20).ToString(); val = val + ",'" + "" + "' ";
                    var = var + ",d" + (21).ToString(); val = val + ",'" + "" + "' ";  
                    var = var + ",d" + (22).ToString(); val = val + ",'" + ""+ "' ";
                    sql = "insert into a201_asset (code,dt,state,arm_code " + var + " ) values ('" + 자산번호 + "','" + cls_com.GetDate() + "','','" + cls_com.GetCode(cmb소속부대.Text) + "'" + val + " )";
                    cls_com.ExcuteNonQuery(sql);
                    cls_com.로그(cls_com.사용자.성명, "엑셀 자산 등록", "등록", sql);

                }

                Application.DoEvents();
            }

        }
    
    }

}

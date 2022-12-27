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
    public partial class frm자산조회_운영실태현황 : Form
    {
        String sql = "";
        public String 부대1 = "", 부대2 = "", 부대3  = "", 부대4 = "";
        public frm자산조회_운영실태현황()
        {
            InitializeComponent();
        }
     
        private void frm자산조회_운영실태현황_Load(object sender, EventArgs e)
        {
            초기화();
            조회();
        }

        private void 조회()
        {

            FarPoint.Win.Spread.CellType.TextCellType tc = new FarPoint.Win.Spread.CellType.TextCellType();
            tc.Multiline = true;
            tc.WordWrap = true;

            sql = "";
            sql = sql + "  SELECT \n ";
            sql = sql + "     d0, cnt1, cnt2,  cnt2-cnt1 cnt3 ,concat(format(cnt4,'#,#.##'),' %') cnt4  ,'' bigo \n ";
            sql = sql + " FROM( \n ";
            sql = sql + " SELECT \n ";
            sql = sql + "         '1' tp1, '총계' d0, COUNT(*) cnt1, SUM(cnt) cnt2, ((1.0 * SUM(cnt)) / COUNT(*)) * 100 cnt4 \n ";
            sql = sql + " FROM( \n ";
            sql = sql + "         SELECT a.d1, a.d4 \n ";
            sql = sql + "           , CASE WHEN d1 = '' THEN 0 ELSE 1 END cnt \n ";
            sql = sql + "         FROM a201_asset a \n ";
            sql = sql + "     ) a \n ";
            sql = sql + "     UNION all \n ";
            sql = sql + "     SELECT \n ";
            sql = sql + "         '2' tp1, a.d4, COUNT(*) cnt1, SUM(cnt) cnt2, ((1.0 * SUM(cnt)) / COUNT(*)) * 100 cnt4 \n ";
            sql = sql + "     FROM( \n ";
            sql = sql + "         SELECT a.d1, a.d4 \n ";
            sql = sql + "           , CASE WHEN d1 = '' THEN 0 ELSE 1 END cnt \n ";
            sql = sql + "         FROM a201_asset a \n ";
            sql = sql + "     ) a \n ";
            sql = sql + "     GROUP BY a.d4 \n ";
            sql = sql + " ) a \n ";
            sql = sql + " ORDER BY tp1, d0 \n ";

            DataSet ds = cls_com.Select_Query(sql);
            spr.Sheets[0].RowCount = 0;
            헤더(ds);
            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt.Text = ds.Tables[0].Rows.Count.ToString();
            spr.DataSource = ds;
            if (ds.Tables[0].Rows.Count > 0)
            {

                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).CellType = tc;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                spr.Sheets[0].Cells.Get(0, 1, spr.Sheets[0].RowCount - 1, 3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
                spr.Sheets[0].Cells.Get(0, 4, spr.Sheets[0].RowCount - 1, 4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;

                spr.Sheets[0].Rows.Get(0, spr.ActiveSheet.Rows.Count - 1).Height = 30;
                spr.Sheets[0].Cells.Get(0, 0, 0, 0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
                spr.Sheets[0].Cells.Get(0, 0, 0, spr.Sheets[0].ColumnCount - 1).BackColor = Color.Pink;


            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = (spr.ActiveSheet.RowCount-1).ToString();
        }
        private void 헤더(DataSet ds)
        {
            spr.ActiveSheet.ColumnHeader.Rows[0].Height = 50;
            spr.ActiveSheet.ColumnHeader.Cells[0, 0].Text = "자원구분";
            spr.ActiveSheet.ColumnHeader.Cells[0, 1].Text = "실제 보유 자산\n(A)";
            spr.ActiveSheet.ColumnHeader.Cells[0, 2].Text = "DRIMS등록자산\n(B)";
            spr.ActiveSheet.ColumnHeader.Cells[0, 3].Text = "차이\n(C=B-A)";
            spr.ActiveSheet.ColumnHeader.Cells[0, 4].Text = "보유 대비등록률\n(B/A)";
            spr.ActiveSheet.ColumnHeader.Cells[0, 5].Text = "증감사유";

        }

        private void 초기화()
        {
        
        }
        private void 닫기()
        {
            Close();
        }



        private void btn초기화_Click(object sender, EventArgs e)
        {
            초기화();
        }

        private void btn조회_Click(object sender, EventArgs e)
        {
            조회();
        }

        private void btn닫기_Click(object sender, EventArgs e)
        {
            닫기();
        }

        private void spr_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr.ActiveSheet);
        }

     
   
        private void txt구분1_TextChanged(object sender, EventArgs e)
        {
            조회();
        }

       
        private void txt로그_TextChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void txt구분2_TextChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void dtp1_CloseUp(object sender, EventArgs e)
        {
            조회();
        }

        private void dtp2_CloseUp(object sender, EventArgs e)
        {
            조회();
        }

        private void btn출력_Click(object sender, EventArgs e)
        {
            출력();
        }
        private void 출력()
        {
            string title = "정보자원관리 운영실태 현황";
            string d1;
            this.Cursor = Cursors.WaitCursor;
            d1 = String.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);

            if (spr.Sheets[0].RowCount != 0)
            {
                try
                {
                    FarPoint.Win.Spread.PrintInfo pi = new FarPoint.Win.Spread.PrintInfo();
                    FarPoint.Win.Spread.SmartPrintRulesCollection prules = new FarPoint.Win.Spread.SmartPrintRulesCollection();
                    pi.ShowPrintDialog = true;
                    pi.Margin.Top = 55;
                    pi.Margin.Bottom = 50;
                    //pi.Header = "/n/n" + "/fn""굴림체""/fz""20""/fb1/fu1/c출고내역(" & lblTitle.Caption & ")"   ;
                    pi.Header = "/n/c/fu1/fn\"굴림체\"/fz\"22\"" + title + "/n/fz\"10\" /l" + "/n/fz\"10\" /l" + "" + "/r" + d1 + "/n/r  " + "페이지:  " + "/p / /pc          ";

                    pi.Footer = "";
                    pi.ShowGrid = true;//셀
                    pi.ShowBorder = true;//셀
                    pi.ShowRowHeaders = true;  // RowHeaders 안보이게 한다.
                    pi.ShowColumnHeaders = true;//해드
                    pi.Centering = FarPoint.Win.Spread.Centering.Horizontal;
                    pi.Orientation = FarPoint.Win.Spread.PrintOrientation.Portrait;


                    pi.Preview = true;//미리보기 선언/ 아니면 바로인쇄


                    //  // ... use best fit of columns and rows
                    //  pi.BestFitCols = true;
                    //   pi.BestFitRows = true;

                    //  // ... or check by page size
                    //  pi.SmartPrintPagesTall = 1;
                    //  pi.SmartPrintPagesWide = 1;

                    //  // ... or use the rules defined
                    //  prules.Add(new FarPoint.Win.Spread.BestFitColumnRule(FarPoint.Win.Spread.ResetOption.Current));
                    //  prules.Add(new FarPoint.Win.Spread.LandscapeRule(FarPoint.Win.Spread.ResetOption.Current));
                    //  //prules.Add(new FarPoint.Win.Spread.ScaleRule(FarPoint.Win.Spread.ResetOption.None, FarPoint.Win.Spread.ResetOption.None, 1, 0.6, 0.1));
                    //  //prules.Add(new FarPoint.Win.Spread.ScaleRule(FarPoint.Win.Spread.ResetOption.None, 1, 0.6, 0.1));
                    //  pi.SmartPrintRules = prules;
                    //   pi.UseSmartPrint = true;

                    pi.ColStart = 0;
                    pi.ColEnd = spr.ActiveSheet.ColumnCount;
                    //pi.RowStart = Convert.ToInt32(txtS.Text) - 1;
                    //pi.RowEnd = Convert.ToInt32(txtE.Text) - 1;

                    pi.RowStart = 0;
                    pi.RowEnd = spr.Sheets[0].RowCount - 1;

                    pi.PrintType = FarPoint.Win.Spread.PrintType.CellRange;

                    spr.Sheets[0].PrintInfo = pi;

                    spr.PrintSheet(0);

                }
                catch (Exception)
                {
                    this.Cursor = Cursors.Default;
                    return;
                }
            }
            else
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("인쇄할 데이터가 없습니다.");
                return;
            }


            this.Cursor = Cursors.Default;

        }

        private void btn엑셀저장_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            saveFileDialog.FilterIndex = 1;     // FilterIndex는 1부터 시작 (여기서는 *.txt)
            saveFileDialog.FileName = "운영실태현황_" + cls_com.GetDate();
            saveFileDialog.RestoreDirectory = true;
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    spr.SaveExcel(saveFileDialog.FileName);

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("File Open Error : " + ex.Message);
            }
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.Yellow;
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.White;

        }

        private void spr_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            /*
            txt1.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
            txt2.Text = spr.ActiveSheet.Cells[e.Row, 1].Text;
            txt3.Text = spr.ActiveSheet.Cells[e.Row, 2].Text;
            txt4.Text = spr.ActiveSheet.Cells[e.Row, 3].Text;
            txt5.Text = spr.ActiveSheet.Cells[e.Row, 4].Text;
            txt6.Text = spr.ActiveSheet.Cells[e.Row, 5].Text;
            txtArm1.Text = spr.ActiveSheet.Cells[e.Row, 6].Text;
            txtArm2.Text = spr.ActiveSheet.Cells[e.Row, 7].Text;
            txtArm3.Text = spr.ActiveSheet.Cells[e.Row, 8].Text;
            txtArm4.Text = spr.ActiveSheet.Cells[e.Row, 9].Text;
            */
        }



    }
}

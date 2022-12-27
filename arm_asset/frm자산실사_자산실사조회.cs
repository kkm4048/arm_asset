using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace arm_asset
{
    public partial class frm자산실사_자산실사조회 : Form
    {
        string sql;
        public frm자산실사_자산실사조회()
        {
            InitializeComponent();
        }

        private void frm자산실사_자산실사조회_Load(object sender, EventArgs e)
        {
            초기화();
        }
        private void 초기화()
        {
            dtp1.Text  = cls_com.GetDate();
            dtp2.Text = cls_com.GetDate();

            Add소속부대();
            조회();
        }
        private void Add소속부대()
        {
            cmb소속부대.Items.Clear();
            cmb소속부대.Items.Add("");

            sql = "select * from a101_arm order by arm_code";

            DataSet ds = cls_com.Select_Query(sql);
            cmb소속부대.Items.Clear();
            if (ds == null) return;
            if (ds.Tables[0].Rows.Count > 0)
            {
                cmb소속부대.Items.Add("");
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cmb소속부대.Items.Add(ds.Tables[0].Rows[i]["arm_code"].ToString() + " " + ds.Tables[0].Rows[i]["arm"].ToString());
                }
            }
        }

        private void cmb소속_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt1.Focus();
            txt1.SelectAll();
            조회();
        }
        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.Yellow;
            tb.SelectAll();
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.White;

        }

        private void frm자산실사_자산실사조회_Activated(object sender, EventArgs e)
        {
            txt1.Focus();
        }
        private void 조회()
        {

            String 소속코드 = "", 소속명 = "";
            String[] a;
            a = cmb소속부대.Text.Split(' ');
            if (a.Length >= 2)
            {
                소속코드 = a[0];
                소속명 = a[1];
            }
            sql = "";
            sql = sql + " select a.dt ,a.tm,a.arm_code,b.arm ,a.arm_code_s, c.arm arm2,a.code,a.usr,a.update_yn,a.update_data ,d.d1,d.d2 ,d.d3,d.d4,d.d5,d.d6,d.d12 ";
            sql = sql + " from a301_silsa a ";
            sql = sql + " left join a101_arm b on a.arm_code = b.arm_code ";
            sql = sql + " left join a101_arm c on a.arm_code = c.arm_code ";
            sql = sql + " left join a201_asset d on a.code  = d.code  ";
            sql = sql + " where a.dt >= '" + cls_com.GetDate(dtp1.Value) + "' and a.dt <= '" + cls_com.GetDate(dtp2.Value) + "' ";
            if (!cmb소속부대.Text.Equals(""))
            {
                sql = sql + "   and a.arm_code_s = '" + cls_com.GetCode(cmb소속부대.Text) + "' ";
            }
            sql = sql + " order by a.dt,a.tm ";

            DataSet ds = cls_com.Select_Query(sql);
            헤더(ds);
            spr.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt.Text = ds.Tables[0].Rows.Count.ToString();
            spr.DataSource = ds;
            if (ds.Tables[0].Rows.Count > 0)
            {

                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;

                for (int i = 0; i < spr.ActiveSheet.Rows.Count; i++)
                {
                    if (!spr.ActiveSheet.Cells[i, 2].Text.Equals(spr.ActiveSheet.Cells[i, 4].Text))
                    {
                        spr.ActiveSheet.Cells.Get(i, 4, i, 5).BackColor = Color.Pink;
                    }
                }
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
        }
        private void 헤더(DataSet ds)
        {
            spr.ActiveSheet.ColumnHeader.Cells[0, 0].Text = "일자";
            spr.ActiveSheet.ColumnHeader.Cells[0, 1].Text = "시간";
            spr.ActiveSheet.ColumnHeader.Cells[0, 2].Text = "소속부대코드";
            spr.ActiveSheet.ColumnHeader.Cells[0, 3].Text = "소속부대";
            spr.ActiveSheet.ColumnHeader.Cells[0, 4].Text = "실사_소속부대코드";
            spr.ActiveSheet.ColumnHeader.Cells[0, 5].Text = "실사_소속부대";
            spr.ActiveSheet.ColumnHeader.Cells[0, 6].Text = "자산번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, 7].Text = "사용자";
            spr.ActiveSheet.ColumnHeader.Cells[0, 8].Text = "반영여부";
            spr.ActiveSheet.ColumnHeader.Cells[0, 9].Text = "수정데이타";
            spr.ActiveSheet.ColumnHeader.Cells[0, 10].Text = "관리번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, 11].Text = "시리얼번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, 12].Text = "도입년월일";
            spr.ActiveSheet.ColumnHeader.Cells[0, 13].Text = "자원분류";
            spr.ActiveSheet.ColumnHeader.Cells[0, 14].Text = "제조사";
            spr.ActiveSheet.ColumnHeader.Cells[0, 15].Text = "모델명";
            spr.ActiveSheet.ColumnHeader.Cells[0, 16].Text = "설치장소";
            spr.ActiveSheet.ColumnHeader.Rows[0].Height = 30;

        }


        private void btn조회_Click(object sender, EventArgs e)
        {
            조회();
        }

        private void btn초기화_Click(object sender, EventArgs e)
        {
            초기화();
        }

        private void spr_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr.ActiveSheet);
         }
      

        private void btn출력_Click(object sender, EventArgs e)
        {
            출력();
        }
        private void 출력()
        {
            string title = "자산 불출입 조회";
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
                    pi.Header = "/n/c/fu1/fn\"굴림체\"/fz\"22\"" + title + "/n/fz\"10\" /l" + "/n/fz\"10\" /l" + cmb소속부대.Text + "/r" + d1 + "/n/r  " + "페이지:  " + "/p / /pc          ";

                    pi.Footer = "";
                    pi.ShowGrid = true;//셀
                    pi.ShowBorder = true;//셀
                    pi.ShowRowHeaders = true ;  // RowHeaders 안보이게 한다.
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

        private void btn닫기_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmb상태_SelectedIndexChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtp1_CloseUp(object sender, EventArgs e)
        {
            조회();
        }

        private void dtp2_CloseUp(object sender, EventArgs e)
        {
            조회();
        }

        private void btn부대_Click(object sender, EventArgs e)
        {
            부대();
        }
        private void 부대()
        {
            frm기타_부대조회 frm기타_부대조회 = new frm기타_부대조회();
            frm기타_부대조회.ShowDialog();
            cmb소속부대.Text = frm기타_부대조회.부대코드 + " " + frm기타_부대조회.부대명;
        }

        private void btn엑셀저장_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            saveFileDialog.FilterIndex = 1;     // FilterIndex는 1부터 시작 (여기서는 *.txt)
            saveFileDialog.FileName = "자산실사_" + cls_com.GetDate();
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace assets
{
    public partial class frm자산등록_자산조회 : Form
    {
        String sql = "";
        String r품목명, r취득일자, r바코드;
        private PrintDocument printDoc = new PrintDocument();
        private PrintDocument printDoc2 = new PrintDocument();

        public frm자산등록_자산조회()
        {
            InitializeComponent();
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
            printDoc2.PrintPage += new PrintPageEventHandler(printDoc_PrintPage2);
        }

        private void frm자산등록_자산조회_Load(object sender, EventArgs e)
        {
            Add사업장();
            Add부서();
            Add위치();
            Add자산구분();
            Add품목분류();
            초기화();
            조회();
        }

        private void 조회()
        {

            FarPoint.Win.Spread.CellType.CheckBoxCellType cb = new FarPoint.Win.Spread.CellType.CheckBoxCellType();
            sql = "EXEC s_a201_자산등록_자산조회_조회 '1','" + cls_com.GetCode(cmb사업장.Text) + "','" + cls_com.GetCode(cmb부서.Text) + "' "
                  + ",'" + cls_com.GetCode(cmb위치.Text) + "','" + cls_com.GetCode(cmb자산구분.Text) + "','" + cls_com.GetCode(cmb품목분류.Text) + "' "
                  + ",'','','','" + txt조회.Text + "' ";

            DataSet ds = cls_com.Select_Query(sql);
            spr.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            //lblCnt.Text = ds.Tables[0].Rows.Count.ToString();
            spr.DataSource = ds;
            spr.ActiveSheet.AddColumns(0, 1);
            spr.ActiveSheet.ColumnHeader.Cells[0, 0].Text = spr.ActiveSheet.ColumnHeader.Cells[0, 1].Text;
            spr.ActiveSheet.ColumnHeader.Cells[0, 1].Text = spr.ActiveSheet.ColumnHeader.Cells[0, 2].Text;
            spr.ActiveSheet.ColumnHeader.Cells[0, 0].Text = "선택";
            if (ds.Tables[0].Rows.Count > 0)
            {

                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, 0).CellType = cb;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, 0).Locked = false;
                spr.Sheets[0].Cells.Get(0, 1, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
        //    lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
        }

        private void 조회2()
        {

            FarPoint.Win.Spread.CellType.CheckBoxCellType cb = new FarPoint.Win.Spread.CellType.CheckBoxCellType();
            sql = "EXEC s_a201_자산등록_자산조회_조회 '2','" + cls_com.GetCode(cmb사업장.Text) + "','" + cls_com.GetCode(cmb부서.Text) + "' "
                  + ",'" + cls_com.GetCode(cmb위치.Text) + "','" + cls_com.GetCode(cmb자산구분.Text) + "','" + cls_com.GetCode(cmb품목분류.Text) + "' "
                  + ",'','" + cls_com.GetDate(dtp.Value) + "','" + cls_com.GetDate(dtp2.Value) + "','" + txt조회.Text + "' ";

            DataSet ds = cls_com.Select_Query(sql);
            spr.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            //lblCnt.Text = ds.Tables[0].Rows.Count.ToString();
            spr.DataSource = ds;
            spr.ActiveSheet.AddColumns(0, 1);
            spr.ActiveSheet.ColumnHeader.Cells[0, 0].Text = spr.ActiveSheet.ColumnHeader.Cells[0, 1].Text;
            spr.ActiveSheet.ColumnHeader.Cells[0, 1].Text = spr.ActiveSheet.ColumnHeader.Cells[0, 2].Text;
            spr.ActiveSheet.ColumnHeader.Cells[0, 0].Text = "선택";
            if (ds.Tables[0].Rows.Count > 0)
            {

                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, 0).CellType = cb;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, 0).Locked = false;
                spr.Sheets[0].Cells.Get(0, 1, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            //    lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
        }

        private void 초기화()
        {

            txt조회.Text = "";
            cmb사업장.Text = "";
            cmb위치.Text = "";
            cmb부서.Text = "";
            cmb자산구분.Text = "";
            cmb품목분류.Text = "";
            
      
        }
        private void Add사업장()
        {
            cmb사업장.Items.Clear();
            cmb사업장.Items.Add("");
            sql = "EXEC s_a101_사업장_조회 '1','','' ";

            DataSet ds = cls_com.Select_Query(sql);
            if (ds == null) return;
            if (ds.Tables[0].Rows.Count > 0)
            {
            
                for (int i=0 ; i < ds.Tables[0].Rows.Count ; i ++) {
                    cmb사업장.Items.Add(ds.Tables[0].Rows[i]["사업장코드"].ToString() + " " + ds.Tables[0].Rows[i]["사업장명"].ToString());
                }
            }
        }
        private void Add위치()
        {
            cmb위치.Items.Clear();
            cmb위치.Items.Add("");
            sql = "EXEC s_a101_위치_조회 '3','" + cls_com.GetCode(cmb사업장.Text) + "','" + cls_com.GetCode(cmb부서.Text) + "','','',''";

            DataSet ds = cls_com.Select_Query(sql);
            if (ds == null) return;
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cmb위치.Items.Add(ds.Tables[0].Rows[i]["위치코드"].ToString() + " " + ds.Tables[0].Rows[i]["위치명"].ToString());
                }
            }

        }
        private void Add부서()
        {
            cmb부서.Items.Clear();
            cmb부서.Items.Add("");
            sql = "EXEC s_a101_부서_조회 '1','"  +cls_com.GetCode(cmb사업장.Text) + "','','' ";

            DataSet ds = cls_com.Select_Query(sql);
            if (ds == null) return;
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cmb부서.Items.Add(ds.Tables[0].Rows[i]["부서코드"].ToString() + " " + ds.Tables[0].Rows[i]["부서명"].ToString());
                }
            }
        }

        private void Add자산구분()
        {
            cmb자산구분.Items.Clear();
            cmb자산구분.Items.Add("");
            sql = "EXEC s_a101_자산구분_조회 '1','',''  ";

            DataSet ds = cls_com.Select_Query(sql);
            if (ds == null) return;
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cmb자산구분.Items.Add(ds.Tables[0].Rows[i]["자산구분코드"].ToString() + " " + ds.Tables[0].Rows[i]["자산구분명"].ToString());
                }
            }
        }


        private void Add품목분류()
        {
            cmb품목분류.Items.Clear();
            cmb품목분류.Items.Add("");
            sql = "EXEC s_a101_품목분류_조회 '1','" + cls_com.GetCode(cmb자산구분.Text) + "','','' ";

            DataSet ds = cls_com.Select_Query(sql);
            if (ds == null) return;
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cmb품목분류.Items.Add(ds.Tables[0].Rows[i]["품목분류코드"].ToString() + " " + ds.Tables[0].Rows[i]["품목분류명"].ToString());
                }
            }
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

        private void spr_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            try
            {
                if (e.Row < 0) return;
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void txt조회_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                조회();
            }
        }


        private void cmb자산구분_SelectedIndexChanged(object sender, EventArgs e)
        {
            Add품목분류();
            조회();
            
        }

        private void cmb사업장_SelectedIndexChanged(object sender, EventArgs e)
        {
            Add부서();
            Add위치();
            조회();
        }

        private void cmb부서_SelectedIndexChanged(object sender, EventArgs e)
        {
            Add위치();
            조회();

        }

        private void cmb위치_SelectedIndexChanged(object sender, EventArgs e)
        {
            조회();

        }

        private void cmb품목분류_SelectedIndexChanged(object sender, EventArgs e)
        {
            조회();

        }

        private void frm자산등록_자산조회_Resize(object sender, EventArgs e)
        {
            btn닫기.Left = this.Width - 120;
        }

        private void btn바코드출력_Click(object sender, EventArgs e)
        {
            출력();
        }

        private void 출력()
        {
            int i;
            String print;
            print = cls_com.GetDefaultPrinter();
            cls_com.SetDefaultPrinter(cls_com.g프린터_대);


            PrinterSettings settings = new PrinterSettings();

            settings.Copies = 1; //I put number 2 here




            printDoc.PrinterSettings = settings;

            Application.DoEvents();



              for (i = 0 ; i < spr.ActiveSheet.RowCount ; i ++ )
            {

                if (spr.ActiveSheet.Cells[i, 0].Text.Equals("True"))
                {

                    r품목명 = spr.ActiveSheet.Cells[i, 15].Text;
                    r취득일자 = spr.ActiveSheet.Cells[i, 16].Text;
                    r바코드 = spr.ActiveSheet.Cells[i, 1].Text;
                    printDoc.Print();
                    Application.DoEvents();
                }
            }

            cls_com.SetDefaultPrinter(print);

        }
        void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {

            Fath.bcType bcType = Fath.bcType.QRCode;
            Font ifont, ifont2, ifont3;

            ifont = new Font("HY견고딕", 10, GraphicsUnit.Pixel);
            ifont2 = new Font("HY견고딕", 12, GraphicsUnit.Pixel);
            ifont3 = new Font("HY견고딕", 8, GraphicsUnit.Pixel);


            cls_com.PrintBarcode(e, r바코드, 180, 10, 100, 100, "0", "False", ifont2, bcType);
            cls_com.PrintText(e, r바코드, ifont3, "LEFT", "0", 420, 120, 1, 1);
            cls_com.PrintText(e, r품목명, ifont3, "LEFT", "0", 420, 140, 1, 1);
            cls_com.PrintText(e, r취득일자, ifont3, "LEFT", "0", 420, 160, 1, 1);

        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            조회2();
        }

        private void btn조회_리스트2_Click(object sender, EventArgs e)
        {
            조회2();
        }

        private void spr_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (spr.ActiveSheet.RowCount > 0)
            {
                if (e.Column != 0) return;
                if (e.ColumnHeader)
                {
                    String d;
                    d = spr.ActiveSheet.Cells[0, 0].Text;
                    if (d.Equals("True"))
                    {
                        for (int i = 0; i < spr.ActiveSheet.RowCount; i++)
                        {
                            spr.ActiveSheet.Cells[i, 0].Text = "False";
                        }
                    }
                    else
                    {
                        for (int i = 0; i < spr.ActiveSheet.RowCount; i++)
                        {
                            spr.ActiveSheet.Cells[i, 0].Text = "True";
                        }

                    }

                }
            }
        }

        private void btn바코드출력2_Click(object sender, EventArgs e)
        {
            출력2();
        }
        private void 출력2()
        {
            int i;
            String print;
            print = cls_com.GetDefaultPrinter();
            cls_com.SetDefaultPrinter(cls_com.g프린터_대);


            PrinterSettings settings = new PrinterSettings();

            settings.Copies = 1; //I put number 2 here




            printDoc2.PrinterSettings = settings;

            Application.DoEvents();



            for (i = 0; i < spr.ActiveSheet.RowCount; i++)
            {
                if (spr.ActiveSheet.Cells[i, 0].Text.Equals("True"))
                {
                    r품목명 = spr.ActiveSheet.Cells[i, 15].Text;
                    r취득일자 = spr.ActiveSheet.Cells[i, 16].Text;
                    r바코드 = spr.ActiveSheet.Cells[i, 1].Text;
                    printDoc2.Print();
                    Application.DoEvents();
                }
            }

            cls_com.SetDefaultPrinter(print);

        }
        void printDoc_PrintPage2(object sender, PrintPageEventArgs e)
        {

            Fath.bcType bcType = Fath.bcType.QRCode;
            Font ifont, ifont2, ifont3;

            ifont = new Font("HY견고딕", 10, GraphicsUnit.Pixel);
            ifont2 = new Font("HY견고딕", 12, GraphicsUnit.Pixel);
            ifont3 = new Font("HY견고딕", 12, GraphicsUnit.Pixel);


            cls_com.PrintText(e, r바코드, ifont3, "LEFT", "0", 290, 30, 1, 1);
            cls_com.PrintText(e, r품목명, ifont3, "LEFT", "0", 290, 80, 1, 1);
            cls_com.PrintText(e, r취득일자, ifont3, "LEFT", "0", 290, 125, 1, 1);

            cls_com.PrintBarcode(e, r바코드, 270, 25, 140, 140, "0", "False", ifont2, bcType);
        }

        private void spr_LeaveCell(object sender, FarPoint.Win.Spread.LeaveCellEventArgs e)
        {
            if (e.Row % 2 == 0)
            {
                spr.Sheets[0].Rows[e.Row].BackColor = Color.White;
                spr.Sheets[0].Rows[e.Row].ForeColor = Color.Black;
            }
            else
            {
                spr.Sheets[0].Rows[e.Row].BackColor = Color.WhiteSmoke;
                spr.Sheets[0].Rows[e.Row].ForeColor = Color.Black;
            }

            spr.Sheets[0].Rows[e.NewRow].BackColor = cls_com.색상_선택; ;
            spr.Sheets[0].Rows[e.NewRow].ForeColor = Color.Black;

        }
    }
}

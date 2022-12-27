using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Diagnostics;
using System.IO;

namespace arm_asset
{
    public partial class frm소모품조회_소모품재고조회 : Form
    {
        int rRow = 0,rCol = 0 ;
        String sql = "";
        private PrintDocument printDoc = new PrintDocument();
        private PrintDocument printDoc2 = new PrintDocument();
        int rRow1, rRow2;
        int rRow0; 
        public frm소모품조회_소모품재고조회()
        {
            InitializeComponent();
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);

        }

        private void frm소모품조회_소모품재고조회_Load(object sender, EventArgs e)
        {

            FarPoint.Win.Spread.InputMap im = new FarPoint.Win.Spread.InputMap();
            im = spr.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused);
            im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow);

            
            초기화();
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

        private void 조회()
        {

         
            string var = "";
            string w = "";


            for (int i = 0;i < cls_com.g타이틀2_수량-3; i++)
            {
                var = var + ",c.d" + (i + 1).ToString();
            }


            if ( !cls_com.사용자.등급.Equals("총관리자"))
            {
                w = w + " and a.arm_code  in    ( select arm_code from a101_user a left join a101_user_arm b on a.id = b.id where a.id = '" + cls_com.사용자.아이디 + "' )  \n";
            }

            if (!cmb소속부대.Text.Equals(""))
            {
                w = w + " and a.arm_code  = '" + cls_com.GetCode(cmb소속부대.Text) + "'  \n";
            }

            if (!txt조회.Text.Equals("") )
            {
                w = w + " and  ( a.code" +  " like '%" + txt조회.Text + "%' " + "\n";
                for (int i = 1;i < spr.ActiveSheet.ColumnCount; i++)
                {
                    w = w + " or c.d" + i.ToString() + " like '%" + txt조회.Text + "%' " + "\n";
                }
                w = w + " ) \n";

            }

            if (w.Length > 0)
            {
                w = " where " + w.Substring(4);
            }
            sql = "";
            sql = sql + " select a.code,a.state,a.arm_code,b.arm,a.cnt" + var + "\n" ;
            sql = sql + " from  b201_stock a  "  + " \n ";
            sql = sql + " left join a101_arm b  on a.arm_code = b.arm_code  " + " \n ";
            sql = sql + " left join b101_con c  on a.code = c.code  " + " \n ";
            sql = sql + w ;
            sql = sql + " order by  a.code  " + " \n ";

            DataSet ds = cls_com.Select_Query(sql);
            spr.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            spr.DataSource = ds;
            헤드(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
//                for (int i = 0; i < spr.ActiveSheet.RowCount; i ++)
  //              {
    //            }
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
        }
        private void 헤드(DataSet ds)
        {

            spr.ActiveSheet.ColumnHeader.Cells[0, 0].Text = "소모품번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, 1].Text = "상태";
            spr.ActiveSheet.ColumnHeader.Cells[0, 2].Text = "부대코드";
            spr.ActiveSheet.ColumnHeader.Cells[0, 3].Text = "부대명";
            spr.ActiveSheet.ColumnHeader.Cells[0, 4].Text = "재고수량";

            for (int i = 5; i <=8; i++) { 
                spr.ActiveSheet.ColumnHeader.Cells[0, i].Text = cls_com.g타이틀2[i-2];
            }
        }
        private void 초기화()
        {

            txt조회.Text = "";
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

       




        private void 출력()
        {
            String print;
            print = cls_com.GetDefaultPrinter();
            cls_com.SetDefaultPrinter(cls_com.g프린터);


            PrinterSettings settings = new PrinterSettings();

            settings.Copies = 1; //I put number 2 here



            
            printDoc.PrinterSettings = settings;

                Application.DoEvents();



            FarPoint.Win.Spread.Model.CellRange[] cr;
            cr = spr.ActiveSheet.GetSelections();

            if (cr[0].RowCount < 0)
            {
                rRow1 = 0;
                rRow2 = spr.ActiveSheet.RowCount;
            }
            else
            {
                rRow1 = cr[0].Row;
                rRow2 = cr[0].Row + cr[0].RowCount;
            }



            //      irow = spr.ActiveSheet.ActiveRow.Index;
            //     for (i = irow ; i <= irow  ; i ++ )
            //    {
            //       r자산번호 = spr.ActiveSheet.Cells[i, 0].Text;
            //      r관리번호 = spr.ActiveSheet.Cells[i, 4].Text;
            //     r도입년월일 = spr.ActiveSheet.Cells[i, 5].Text;
            //    r자원분류 = spr.ActiveSheet.Cells[i, 6].Text;
            //   r모델명 = spr.ActiveSheet.Cells[i, 8].Text;
            //   r시리얼번호 = spr.ActiveSheet.Cells[i, 15].Text;
            rRow0 = rRow1;
            printDoc.Print();
          //      Application.DoEvents();
//            }

            cls_com.SetDefaultPrinter(print);

        }
        void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {

            Font ifont, ifont2, ifont3;

            ifont = new Font("HY견고딕", 10, GraphicsUnit.Pixel);
            ifont2 = new Font("HY견고딕", 12, GraphicsUnit.Pixel);
            ifont3 = new Font("HY견고딕", 8, GraphicsUnit.Pixel);

            //          cls_com.PrintBarcode(e, r자산번호, 0, 0, 100, 100, "0", "False", ifont2, bcType);
            //       cls_com.PrintText(e, r자산번호, ifont3, "LEFT", "0" ,150, 0, 1, 1);


            //   cls_com.PrintBarcode(e, r자산번호, 180, 10, 100, 100, "0", "False", ifont2, bcType);
            // cls_com.PrintText(e, r자산번호, ifont3, "LEFT", "0", 420, 120, 1, 1);
            //     cls_com.PrintText(e, r자원분류, ifont3, "LEFT", "0", 420, 140, 1, 1);
            //    cls_com.PrintText(e, r모델명, ifont3, "LEFT", "0", 420, 160, 1, 1);
            //   cls_com.PrintText(e, r도입년월일, ifont3, "LEFT", "0", 420, 180, 1, 1);
            // cls_com.PrintText(e, r관리번호, ifont3, "LEFT", "0", 420, 200, 1, 1);
            //  cls_com.PrintText(e, r시리얼번호, ifont3, "LEFT", "0", 420, 220, 1, 1);



      //      r소모품번호 = spr.ActiveSheet.Cells[rRow0, 0].Text;
   //         r관리번호 = spr.ActiveSheet.Cells[rRow0, 4].Text;
    //        r도입년월일 = spr.ActiveSheet.Cells[rRow0, 5].Text;
     //       r자원분류 = spr.ActiveSheet.Cells[rRow0, 6].Text;
      //      r모델명 = spr.ActiveSheet.Cells[rRow0, 8].Text;
        //    r시리얼번호 = spr.ActiveSheet.Cells[rRow0, 15].Text;

//            cls_com.PrintBarcode(e, r자산번호, 180, 10, 100, 100, "0", "False", ifont2, bcType);
  //          cls_com.PrintText(e, r자산번호, ifont3, "LEFT", "0", 420, 120, 1, 1);
    //        cls_com.PrintText(e, r자원분류, ifont3, "LEFT", "0", 420, 140, 1, 1);
      //      cls_com.PrintText(e, r모델명, ifont3, "LEFT", "0", 420, 160, 1, 1);
        //    cls_com.PrintText(e, r도입년월일, ifont3, "LEFT", "0", 420, 180, 1, 1);
         //   cls_com.PrintText(e, r관리번호, ifont3, "LEFT", "0", 420, 200, 1, 1);
          //  cls_com.PrintText(e, r시리얼번호, ifont3, "LEFT", "0", 420, 220, 1, 1);
            if (rRow0 < (rRow2-1))
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            rRow0++;
        }

        /*
        void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {

            Fath.bcType bcType = Fath.bcType.Code128;
            Font ifont, ifont2,ifont3;

            ifont = new Font("HY견고딕", 10, GraphicsUnit.Pixel);
            ifont2 = new Font("HY견고딕", 12, GraphicsUnit.Pixel);
            ifont3 = new Font("HY견고딕", 11, GraphicsUnit.Pixel);

            cls_com.PrintText(e, "품목명", ifont, "CENTER", "0", 85, 20, 1, 1);
            cls_com.PrintText(e, "취득일자", ifont, "CENTER", "0", 85,60, 1, 1);

            cls_com.PrintText(e, r품목명, ifont3, "LEFT", "0", 160, 20, 1, 1);
            cls_com.PrintText(e, r취득일자, ifont3, "LEFT", "0", 160, 60, 1, 1);
              
             cls_com.PrintBarcode(e, r바코드, 28, 50, 400, 80, "0", "False", ifont2, bcType);
             cls_com.PrintText(e, r바코드, ifont2, "LEFT", "0", 180, 210, 1, 1);
             cls_com.PrintBox(e, 20, 15, 470, 260, 1);   // 큰박스
             cls_com.PrintBox(e, 20, 15, 470, 80, 1);    // 중간박스

             cls_com.PrintBox(e, 20, 15, 470, 40, 1);    // 품목명
             cls_com.PrintBox(e, 20, 15, 130, 80, 1);    // 품목명

        }

         */
        private void btn바코드출력_Click(object sender, EventArgs e)
        {
            출력();
        }

        private void btn엑셀_불러오기_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            openFileDialog.FilterIndex = 1;     // FilterIndex는 1부터 시작 (여기서는 *.txt)
            openFileDialog.RestoreDirectory = true;
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    frm기타_소모품_엑셀불러오기 frm기타_소모품_엑셀불러오기 = new frm기타_소모품_엑셀불러오기(openFileDialog.FileName);
                    frm기타_소모품_엑셀불러오기.ShowDialog();
                    조회();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("File Open Error : " + ex.Message);
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

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

        private void btn일괄삭제_Click(object sender, EventArgs e)
        {
            일괄삭제();
        }
        private void 일괄삭제()
        {
            int i;
            int irow11, irow12;

            FarPoint.Win.Spread.Model.CellRange[] cr;
            cr = spr.ActiveSheet.GetSelections();

            if (cr[0].RowCount < 0)
            {
                irow11 = 0;
                irow12 = spr.ActiveSheet.RowCount;
            }
            else
            {
                irow11 = cr[0].Row;
                irow12 = cr[0].Row + cr[0].RowCount;
            }





            DialogResult dr = MessageBox.Show(cr[0].RowCount.ToString() + " 건  일괄삭제 하시겠습니까?", "일괄삭제", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No) 
            {
                return;
            }
 

            for (i = irow11; i < irow12; i++)
            {
                 일괄삭제2(i);

            }

            조회();
            
        }
        private void 일괄삭제2(int irow )
        {

            String 소모품번호;
            소모품번호 = spr.ActiveSheet.Cells[irow, 0].Text;

            sql = "SELECT top 1 * FROM b301_output where code = '" + 소모품번호 + "'   ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 1)
            {
                MessageBox.Show("이미 입/출고한 소모품이라 삭제 불가");
                return;
            }
            sql = "delete from b101_con where code = '" + 소모품번호 + "' ";
            cls_com.ExcuteNonQuery(sql);
           
        }

        private void txt6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt24_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void spr_EditModeOff(object sender, EventArgs e)
        {
            
        }

       

        private void txt조회_TextChanged(object sender, EventArgs e)
        {
            조회();
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

        private void cmb소속부대_SelectedIndexChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            saveFileDialog.FilterIndex = 1;     // FilterIndex는 1부터 시작 (여기서는 *.txt)
            saveFileDialog.FileName = "소모품재고_" + cls_com.GetDate();
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

        private void 위치(int i,int j)
        {
            rRow = i;
            rCol = j;
            timer1.Enabled = true;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            spr.ActiveSheet.SetActiveCell(rRow,rCol );
        }


    }
}

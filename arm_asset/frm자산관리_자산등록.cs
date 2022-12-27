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
    public partial class frm자산관리_자산등록 : Form
    {
        int rRow = 0,rCol = 0 ;
        String sql = "";
        String r자산번호="", r관리번호="",r도입년월일="", r모델명="", r자원분류="", r시리얼번호="";
        Label[] rlbl  = new Label[30] ;
        TextBox[] rtxt = new TextBox[30];
        int rRow1, rRow2;
        int rRow0;
        private PrintDocument printDoc = new PrintDocument();
        public frm자산관리_자산등록()
        {
            InitializeComponent();
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
        }

        private void frm자산관리_자산등록_Load(object sender, EventArgs e)
        {

            FarPoint.Win.Spread.InputMap im = new FarPoint.Win.Spread.InputMap();
            im = spr.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused);
            im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow);


            배열만들기();
            
            Add소속부대();
            /*
            Add부서();
            Add위치();
            Add자산구분();
            Add품목분류();
            Add처분현황();
            Add상태();
            */
            초기화();
            조회();
            
        }

        private void 배열만들기()
        {
            int i;
            int 간격 = 22;
            i = 0;
        
            for (i= 0;i < cls_com.g타이틀_수량; i++)
            {
                rlbl[i] = new Label();
                rlbl[i].Text = cls_com.g타이틀[i];
                rlbl[i].Visible = true;
                rlbl[i].Left =5;
                rlbl[i].Top = 20 + i * 간격+2;
                rlbl[i].AutoSize = true;
                panRight.Controls.Add(rlbl[i]);

                rtxt[i] = new TextBox();
                rtxt[i].Text = "";
                rtxt[i].Visible = true;
                rtxt[i].Left = 110;
                rtxt[i].Top = 20 + i * 간격;
                rtxt[i].Width = 180;
                rtxt[i].Enter += new EventHandler(txt_Enter);
                rtxt[i].Leave += new EventHandler(txt_Leave);
                panRight.Controls.Add(rtxt[i]);

            }

            pan등록.Top = 20 + i *  간격;

        }

        private void 조회()
        {

         
            string var = "";
            string w = "";


            for (int i = 0;i < cls_com.g타이틀_수량-5; i++)
            {
                var = var + ",a.d" + (i + 1).ToString();
            }

            if (!txt조회_도입년도.Text.Equals(""))
            {
                w = w + " and d3 like '%" + txt조회_도입년도.Text + "%' " + "\n" ;
            }
            if (!txt조회_설치부대.Text.Equals(""))
            {
                w = w + " and b.arm like '%" + txt조회_설치부대.Text + "%'"  + "\n" ;
            }
            if (!txt조회_설치장소.Text.Equals(""))
            {
                w = w + " and d12 like '%" + txt조회_설치장소.Text + "%' " + "\n";
            }
            if (!txt조회_사업명.Text.Equals(""))
            {
                w = w + " and d14 like '%" + txt조회_사업명.Text + "%' " + "\n";
            }


            if (!txt조회.Text.Equals("") )
            {
                w = w + " and  ( a.code" +  " like '%" + txt조회.Text + "%' " + "\n";
                w = w + " or b.arm  like '%" + txt조회.Text + "%' " + "\n";
                for (int i = 1;i < spr.ActiveSheet.ColumnCount; i++)
                {
                    w = w + " or a.d" + i.ToString() + " like '%" + txt조회.Text + "%' " + "\n";
                }
                w = w + " ) \n";

            }

            if (w.Length > 0)
            {
                w = " where " + w.Substring(4);
            }
            sql = "";
            sql = sql + " select a.code,a.dt,a.state,a.arm_code,b.arm " + var + "\n" ;
            sql = sql + " from  a201_asset a  "  + " \n ";
            sql = sql + " left join a101_arm b on a.arm_code = b.arm_code  " + "\n ";
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
                for (int i = 0; i < spr.ActiveSheet.RowCount; i ++)
                {
                    if (spr.ActiveSheet.Cells[i,6].Text.Equals(""))
                    {
                        spr.Sheets[0].Cells.Get(i, 6, i, 6).Locked = false;
                        spr.Sheets[0].Cells.Get(i, 6, i, 6).BackColor = Color.Yellow;
                    }
                }
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
        }
        private void 헤드(DataSet ds)
        {

            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            {

                spr.ActiveSheet.ColumnHeader.Cells[0, i].Text = cls_com.g타이틀[i];
            }
        }

        private void 등록()
        {
            DataSet ds;
            String 자산번호 = "", 소속부대코드 = "";


            소속부대코드 = cls_com.GetCode(cmb소속부대.Text);
            if (소속부대코드.Equals(""))
            {
                MessageBox.Show("소속부대코드를 선택하세요");
                return;
            }

            if (!rtxt[5].Text.Trim().Equals("")) { 
                sql = "SELECT * from a201_asset where d1 = '" + rtxt[5].Text.Trim() + "' ";
                ds = cls_com.Select_Query(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("자산번호 : " + ds.Tables[0].Rows[0]["code"].ToString() + "  이미 등록된 관리번호 입니다. ");
                    return;
                }
            }
            if (!rtxt[16].Text.Trim().Equals(""))
            {
                sql = "SELECT * from a201_asset where d2 = '" + rtxt[6].Text.Trim() + "' ";
                ds = cls_com.Select_Query(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("자산번호 : " + ds.Tables[0].Rows[0]["code"].ToString() + "  이미 등록된 시리얼번호 입니다. ");
                    return;
                }
            }


            for (int i = 0; i < Convert.ToInt16(txt등록수량.Text); i++)
            {
                string var = "", val = "";
                자산번호 = cls_com.자산번호_가져오기();
                var = "code,dt,state,arm_code ";
                val = "'" +  자산번호 +  "','" +  cls_com.GetDate() + "','" + rtxt[2].Text + "','" + cls_com.GetCode(cmb소속부대.Text)  +"' ";
                for (int j = 1; j < cls_com.g타이틀_수량-4; j++)
                {
                    var = var + ",d" + j.ToString();
                    val = val + ",'" + rtxt[j+4].Text.Replace("'","''") + "' ";
                }


                sql = " ";
                sql = sql + "insert into a201_asset  ( ";
                sql = sql + var;
                sql = sql + ") values ( " ;
                sql = sql + val  ;
                sql = sql + ")  ";
                cls_com.ExcuteNonQuery(sql);
                cls_com.로그(cls_com.사용자.성명, "자산 등록", "등록", sql);

            }
            조회();
            초기화();

        }
        private void 수정()
        {
            DataSet ds ;
            string var = "";


            if (!rtxt[5].Text.Trim().Equals(""))
            {
                sql = "SELECT * from a201_asset where code <> '" + rtxt[0].Text + "' and d1 = '" + rtxt[5].Text.Trim() + "' ";
                ds = cls_com.Select_Query(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("자산번호 : " + ds.Tables[0].Rows[0]["code"].ToString() + "  이미 등록된 관리번호가 있습니다.  ");
                    return;
                }
            }
            if (!rtxt[6].Text.Trim().Equals(""))
            {
                sql = "SELECT * from a201_asset where code <> '" + rtxt[0].Text + "' and  d2= '" + rtxt[6].Text.Trim() + "' ";
                ds = cls_com.Select_Query(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("자산번호 : " + ds.Tables[0].Rows[0]["code"].ToString() + "  이미 등록된 시리얼번호가 있습니다. ");
                    return;
                }
            }


            for (int j = 1; j <= cls_com.g타이틀_수량-5; j++)
            {
                var = var + ",d" + j.ToString() + " = '" + rtxt[j+4].Text.Replace("'","''") + "' ";
            }
            var = var.Substring(1);


            sql = " ";
            sql = sql + " update a201_asset set state = '" + rtxt[2].Text + "',";
            sql = sql + var;
            sql = sql + " where code = '" + rtxt[0].Text + "' ";
            cls_com.ExcuteNonQuery(sql);

            cls_com.로그(cls_com.사용자.성명, "자산 등록", "수정", sql);

            조회();
            
            FarPoint.Win.Spread.Model.ISheetSelectionModel sel;
            sel = (FarPoint.Win.Spread.Model.ISheetSelectionModel)spr.ActiveSheet.Models.Selection;
            spr.ActiveSheet.SetActiveCell(rRow, 0);
            sel.SetSelection(rRow, 0, 1, spr.ActiveSheet.ColumnCount);
           
        }
        private void 삭제()
        {

            DialogResult dialogResult = MessageBox.Show("자산번호 : " + rtxt[0].Text + " 삭제 하시겠습니까 ?", "자산 삭제", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }


            sql = " ";
            sql = sql + " delete from a201_asset  ";
            sql = sql + " where code = '" + rtxt[0].Text + "' ";
            cls_com.ExcuteNonQuery(sql);
            cls_com.로그(cls_com.사용자.성명, "자산 등록","삭제" ,sql );
            조회();

        }
        private void 초기화()
        {

            txt조회.Text = "";
            cmb소속부대.Text = " ";
            for (int i = 0;i < cls_com.g타이틀_수량; i++)
            {
                rtxt[i].Text = "";
            }
            rtxt[0].Focus();
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
                for (int i=0 ; i < ds.Tables[0].Rows.Count ; i ++) {
                    cmb소속부대.Items.Add(ds.Tables[0].Rows[i]["arm_code"].ToString() + " " + ds.Tables[0].Rows[i]["arm"].ToString());
                }
            }

            cmb소속부대.Text = cls_com.ConfigLoad(this.Name + "_소속부대");
        }
      
     
        private void Add처분현황()
        {
            /*
            cmb처분현황.Items.Clear();
            cmb처분현황.Items.Add("");
            sql = "EXEC s_a101_처분현황_조회 '1','' ";

            
            DataSet ds = cls_com.Select_Query(sql);
            if (ds == null) return;
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cmb처분현황.Items.Add(ds.Tables[0].Rows[i]["처분현황"].ToString()) ;
                }
            }
            */
        }
        private void Add상태()
        {
            /*
            cmb상태.Items.Clear();
            cmb상태.Items.Add("");
            sql = "EXEC s_a101_상태_조회 '1','' ";


            DataSet ds = cls_com.Select_Query(sql);
            if (ds == null) return;
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cmb상태.Items.Add(ds.Tables[0].Rows[i]["상태"].ToString());
                }
            }
            */
        }
        private void 닫기()
        {
            Close();
        }


        private void btn등록_Click(object sender, EventArgs e)
        {
            등록();
        }

        private void btn수정_Click(object sender, EventArgs e)
        {
            수정();
        }

        private void btn삭제_Click(object sender, EventArgs e)
        {
            삭제();
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

                for (int i = 0; i < cls_com.g타이틀_수량; i++)
                {
                     rtxt[i].Text = spr.ActiveSheet.Cells[e.Row, i].Text;

                }
                rRow = e.Row;
               


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

        private void button1_Click(object sender, EventArgs e)
        {
            조회_등록일();
        }

        private void 조회_등록일()
        {

        
            string var = "";
            string w = "" ,w2 = "" ;
            for (int i = 0;i < cls_com.g타이틀_수량-4; i++)
            {
                var = var + ",a.d" + (i + 1).ToString();
            }

            if (!txt조회.Text.Equals("") )
            {
                for (int i = 1;i < spr.ActiveSheet.ColumnCount; i++)
                {
                    w2 = w2 + " or a.d" + i.ToString() + " like '%" + txt조회.Text + "%' ";
                }

            }

            w = " where dt = '" + cls_com.GetDate(dtp.Value) + "' ";
            if (w2.Length > 0 )
            {
                w = w + " and ( " + w2.Substring(3) + " ) ";
            }
            sql = "";
            sql = sql + " select a.code,a.dt,a.state,a.arm_code,b.arm " + var;
            sql = sql + " from  a201_asset a  ";
            sql = sql + " left join a101_arm b on a.arm_code = b.arm_code  ";
            sql = sql + w ;
            sql = sql + " order by  a.code ";

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
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            조회_등록일();
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

       


      


      

        private void frm자산등록_자산등록_Resize(object sender, EventArgs e)
        {
            
        }

        private void btn바코드출력2_Click(object sender, EventArgs e)
        {
            출력2();
        }

        private void 출력2()
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

            try
            {
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
            } catch 
            {

            }
            
        }
        private void 일괄삭제2(int irow )
        {

            String 자산번호;
            자산번호 = spr.ActiveSheet.Cells[irow, 0].Text;

            sql = "delete from a201_asset where code = '" + 자산번호 + "' ";
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
            
            if (spr.ActiveSheet.ActiveColumn.Index == 6)
            {
                sql = "SELECT code FROM a201_asset where d2 = '" + spr.ActiveSheet.Cells[spr.ActiveSheet.ActiveRowIndex, spr.ActiveSheet.ActiveColumnIndex].Text + "' ";
                DataSet ds = cls_com.Select_Query(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("이미 등록된 시리얼입니다. 자산번호: " + ds.Tables[0].Rows[0][0].ToString());
                    spr.ActiveSheet.Cells[spr.ActiveSheet.ActiveRowIndex, spr.ActiveSheet.ActiveColumnIndex].Text = "";
                    위치(spr.ActiveSheet.ActiveRowIndex, spr.ActiveSheet.ActiveColumnIndex);
                    return;
                }
                sql = "update a201_asset set d2 = '" + spr.ActiveSheet.Cells[spr.ActiveSheet.ActiveRowIndex, spr.ActiveSheet.ActiveColumnIndex].Text + "' where code = '" + spr.ActiveSheet.Cells[spr.ActiveSheet.ActiveRowIndex, 0].Text + "' ";
                cls_com.ExcuteNonQuery(sql);
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            saveFileDialog.FilterIndex = 1;     // FilterIndex는 1부터 시작 (여기서는 *.txt)
            saveFileDialog.FileName = "자산목록_" + cls_com.GetDate();
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

        private void panTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt조회_설치부대_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt조회_설치장소_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt조회_사업명_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn자산다운로드_Click(object sender, EventArgs e)
        {
            string w = "";
            if (!txt조회_도입년도.Text.Equals(""))
            {
                w = w + " and d3 like '%" + txt조회_도입년도.Text + "%' " + "\n";
            }
            if (!txt조회_설치부대.Text.Equals(""))
            {
                w = w + " and b.arm like '%" + txt조회_설치부대.Text + "%'" + "\n";
            }
            if (!txt조회_설치장소.Text.Equals(""))
            {
                w = w + " and d12 like '%" + txt조회_설치장소.Text + "%' " + "\n";
            }
            if (!txt조회_사업명.Text.Equals(""))
            {
                w = w + " and d14 like '%" + txt조회_사업명.Text + "%' " + "\n";
            }


            if (!txt조회.Text.Equals(""))
            {
                w = w + " and  ( a.code" + " like '%" + txt조회.Text + "%' " + "\n";
                w = w + " or b.arm  like '%" + txt조회.Text + "%' " + "\n";
                for (int i = 1; i < spr.ActiveSheet.ColumnCount; i++)
                {
                    w = w + " or a.d" + i.ToString() + " like '%" + txt조회.Text + "%' " + "\n";
                }
                w = w + " ) \n";

            }

            if (w.Length > 0)
            {
                w = " where " + w.Substring(4);
            }

            cls_pda.데이타다운로드(w);
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

                    frm기타_엑셀불러오기 frm기타_엑셀불러오기 = new frm기타_엑셀불러오기(openFileDialog.FileName);
                    frm기타_엑셀불러오기.ShowDialog();
                    조회();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("File Open Error : " + ex.Message);
            }
        }

        private void btn바코드출력_Click(object sender, EventArgs e)
        {
            출력();
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
            for (int i = rRow1; i < rRow2; i++)
            {
                r자산번호 = spr.ActiveSheet.Cells[i, 0].Text;
                r관리번호 = spr.ActiveSheet.Cells[i, 4].Text;
                r도입년월일 = spr.ActiveSheet.Cells[i, 5].Text;
                r자원분류 = spr.ActiveSheet.Cells[i, 6].Text;
                r모델명 = spr.ActiveSheet.Cells[i, 8].Text;
                r시리얼번호 = spr.ActiveSheet.Cells[i, 15].Text;
                rRow0 = i;
                printDoc.Print();
                Application.DoEvents();
            }

                cls_com.SetDefaultPrinter(print);

        }
        void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {

            Fath.bcType bcType = Fath.bcType.QRCode;
            Font ifont, ifont2, ifont3;

            ifont = new Font("HY견고딕", 10, GraphicsUnit.Pixel);
            ifont2 = new Font("HY견고딕", 12, GraphicsUnit.Pixel);
            ifont3 = new Font("HY견고딕", 10, GraphicsUnit.Pixel);

            r자산번호 = spr.ActiveSheet.Cells[rRow0, 0].Text;
            r관리번호 = spr.ActiveSheet.Cells[rRow0, 5].Text;
            r시리얼번호 = spr.ActiveSheet.Cells[rRow0, 6].Text;
            r도입년월일 = spr.ActiveSheet.Cells[rRow0, 7].Text;
            r자원분류 = spr.ActiveSheet.Cells[rRow0, 8].Text;
            r모델명 = spr.ActiveSheet.Cells[rRow0, 10].Text;

            cls_com.PrintBarcode(e, r자산번호, 10, 10, 100, 100, "0", "False", ifont2, bcType);
            cls_com.PrintText(e, "자산번호 : " + r자산번호, ifont3, "LEFT", "0", 130, 30, 1, 1);
            cls_com.PrintText(e, "관리번호 : " + r관리번호, ifont3, "LEFT", "0", 130, 65, 1, 1);
            cls_com.PrintText(e, "시리얼번호 : " + r시리얼번호, ifont3, "LEFT", "0", 10, 120, 1, 1);
            cls_com.PrintText(e, "자원분류 : " + r자원분류, ifont3, "LEFT", "0", 10, 155, 1, 1);
            cls_com.PrintText(e, "모델명 : " + r모델명, ifont3, "LEFT", "0", 10, 190, 1, 1);
            cls_com.PrintText(e, "도입년월일 : " + r도입년월일, ifont3, "LEFT", "0", 10, 225, 1, 1);

        }

        private void cmb소속부대_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            조회();
        }

        private void txt조회_TextChanged(object sender, EventArgs e)
        {
            // 조회();
        }


        private void cmb소속부대_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    Add부서();
            //  cmb부서.Text = "";
            // Add위치();
            cls_com.ConfigSave(this.Name + "_소속부대", cmb소속부대.Text);
            조회();
        }

        private void btn데이타다운로드_Click(object sender, EventArgs e)
        {
            // cls_pda.데이타다운로드("");
        }



        private void txt등록수량_KeyPress(object sender, KeyPressEventArgs e)
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

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
    public partial class frm총관리자_로그조회 : Form
    {
        String sql = "";
        public String 부대1 = "", 부대2 = "", 부대3  = "", 부대4 = "";
        public string r구분 = "";
        public frm총관리자_로그조회()
        {
            InitializeComponent();
        }
        public frm총관리자_로그조회(String 구분)
        {
            InitializeComponent();
            r구분 = 구분;
        }
        public frm총관리자_로그조회(String arm1, String arm2, String arm3, String arm4)
        {
            InitializeComponent();
        }


        private void frm총관리자_로그조회_Load(object sender, EventArgs e)
        {
            초기화();
            Add구분();
            조회();
        }
        private void Add구분()
        {
            cmb구분.Items.Clear();
            cmb구분.Items.Add("자산");
            cmb구분.Items.Add("소모품");
            cmb구분.Text = r구분;
        }
        private void 조회()
        {
            if (cmb구분.Text.Equals("소모품"))
            {
                조회_소모품();
            } else
            {
                조회_자산();
            }
        }
        private void 조회_자산()
        { 
            FarPoint.Win.Spread.CellType.TextCellType tc = new FarPoint.Win.Spread.CellType.TextCellType();
            tc.Multiline = true;
            tc.WordWrap = true;

            string w ="";
            w = w + " and dt  >= '" + cls_com.GetDate(dtp1.Value) + "' and dt <= '" + cls_com.GetDate(dtp2.Value) + "' ";
            if (!txt구분1.Text.Equals("")) { 
               w = w + " and gubun1  = '" + txt구분1.Text + "' ";
            }
            if (!txt구분2.Text.Equals(""))
            {
                w = w + " and gubun2  = '" + txt구분2.Text + "' ";
            }
            if (!txt로그.Text.Equals(""))
            {
                w = w + " and log  like  '%" + txt로그.Text + "%' ";
            }

            if (!w.Equals(""))
            {
                w = " where " + w.Substring(4);
            }
            sql = "";
            sql = sql + " select *  ";
            sql = sql + " from a501_log  ";
            sql = sql + w;
            sql = sql + " order BY dt desc,tm desc";
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

                spr.Sheets[0].Rows.Get(0, spr.ActiveSheet.Rows.Count - 1).Height = 50;

            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
        }

        private void 조회_소모품()
        {
            FarPoint.Win.Spread.CellType.TextCellType tc = new FarPoint.Win.Spread.CellType.TextCellType();
            tc.Multiline = true;
            tc.WordWrap = true;

            string w = "";
            w = w + " and dt  >= '" + cls_com.GetDate(dtp1.Value) + "' and dt <= '" + cls_com.GetDate(dtp2.Value) + "' ";
            if (!txt구분1.Text.Equals(""))
            {
                w = w + " and gubun1  = '" + txt구분1.Text + "' ";
            }
            if (!txt구분2.Text.Equals(""))
            {
                w = w + " and gubun2  = '" + txt구분2.Text + "' ";
            }
            if (!txt로그.Text.Equals(""))
            {
                w = w + " and log  like  '%" + txt로그.Text + "%' ";
            }

            if (!w.Equals(""))
            {
                w = " where " + w.Substring(4);
            }
            sql = "";
            sql = sql + " select *  ";
            sql = sql + " from b501_log  ";
            sql = sql + w;
            sql = sql + " order BY dt desc,tm desc";
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

                spr.Sheets[0].Rows.Get(0, spr.ActiveSheet.Rows.Count - 1).Height = 50;

            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
        }
        private void 헤더(DataSet ds)
        {
            spr.ActiveSheet.ColumnHeader.Cells[0, 0].Text = "사용자";
            spr.ActiveSheet.ColumnHeader.Cells[0, 1].Text = "일자";
            spr.ActiveSheet.ColumnHeader.Cells[0, 2].Text = "시간";
            spr.ActiveSheet.ColumnHeader.Cells[0, 3].Text = "구분1";
            spr.ActiveSheet.ColumnHeader.Cells[0, 4].Text = "구분2";
            spr.ActiveSheet.ColumnHeader.Cells[0, 5].Text = "로그";
            spr.ActiveSheet.ColumnHeader.Cells[0, 6].Text = "비고";

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

        private void cmb구분_SelectedIndexChanged(object sender, EventArgs e)
        {
            조회();
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

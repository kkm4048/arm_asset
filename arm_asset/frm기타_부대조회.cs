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
    public partial class frm기타_부대조회 : Form
    {
        String sql = "";
        public String 부대코드="",부대명="",부대1 = "", 부대2 = "", 부대3  = "", 부대4 = "", 부대5 = "", 부대6 = "";
        public frm기타_부대조회()
        {
            InitializeComponent();
        }
        public frm기타_부대조회(String arm1, String arm2, String arm3, String arm4, String arm5, String arm6)
        {
            InitializeComponent();
        }


        private void frm기타_부대조회_Load(object sender, EventArgs e)
        {
            조회();
            초기화();
        }

        private void 조회()
        {
            sql = "";
            sql = sql + " select arm_code,arm,arm1,arm2,arm3,arm4,arm5,arm6   ";
            sql = sql + " from a101_arm  ";
            if (!txt조회.Text.Equals("")) { 
               sql = sql + " where arm1 like '%" + txt조회.Text + "%' or   arm2 like '%" + txt조회.Text + "%' or   arm3 like '%" + txt조회.Text + "%'  or   arm4 like '%" + txt조회.Text + "%'  or   arm5 like '%" + txt조회.Text + "%'   or   arm6 like '%" + txt조회.Text + "%' ";
            }

            DataSet ds = cls_com.Select_Query(sql);
            spr.Sheets[0].RowCount = 0;
            헤더(ds);
            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt.Text = ds.Tables[0].Rows.Count.ToString();
            spr.DataSource = ds;
            if (ds.Tables[0].Rows.Count > 0)
            {

                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
        }
        private void 헤더(DataSet ds)
        {
            spr.ActiveSheet.ColumnHeader.Cells[0, 0].Text = "부대코드";
            spr.ActiveSheet.ColumnHeader.Cells[0, 1].Text = "부대명";
            spr.ActiveSheet.ColumnHeader.Cells[0, 2].Text = "부대1";
            spr.ActiveSheet.ColumnHeader.Cells[0, 3].Text = "부대2";
            spr.ActiveSheet.ColumnHeader.Cells[0, 4].Text = "부대3";
            spr.ActiveSheet.ColumnHeader.Cells[0, 5].Text = "부대4";
            spr.ActiveSheet.ColumnHeader.Cells[0, 6].Text = "부대5";
            spr.ActiveSheet.ColumnHeader.Cells[0, 7].Text = "부대6";

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

        private void spr_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            부대코드 = spr.ActiveSheet.Cells[e.Row, 0].Text;
            부대명 = spr.ActiveSheet.Cells[e.Row, 1].Text;
            부대1 = spr.ActiveSheet.Cells[e.Row, 2].Text;
            부대2 = spr.ActiveSheet.Cells[e.Row, 3].Text;
            부대3 = spr.ActiveSheet.Cells[e.Row, 4].Text;
            부대4 = spr.ActiveSheet.Cells[e.Row, 5].Text;
            부대5 = spr.ActiveSheet.Cells[e.Row, 6].Text;
            부대6 = spr.ActiveSheet.Cells[e.Row, 7].Text;
            Close();
        }

        private void txt조회_TextChanged(object sender, EventArgs e)
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

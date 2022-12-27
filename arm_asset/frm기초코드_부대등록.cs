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
    public partial class frm기초코드_부대등록 : Form
    {
        String sql = "";
        public frm기초코드_부대등록()
        {
            InitializeComponent();
        }

        private void frm기초코드_부대등록_Load(object sender, EventArgs e)
        {
            조회();
            초기화();
        }

        private void 조회()
        {
            sql = "select arm_code ,arm,loc,tel,address,usr,arm1,arm2,arm3,arm4 ,arm5,arm6 from a101_arm  ";

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
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
        }
        private void 헤더(DataSet ds)
        {
            spr.ActiveSheet.ColumnHeader.Cells[0, 0].Text = "부대코드";
            spr.ActiveSheet.ColumnHeader.Cells[0, 1].Text = "부대명";
            spr.ActiveSheet.ColumnHeader.Cells[0, 2].Text = "위치";
            spr.ActiveSheet.ColumnHeader.Cells[0, 3].Text = "연락처";
            spr.ActiveSheet.ColumnHeader.Cells[0, 4].Text = "주소";
            spr.ActiveSheet.ColumnHeader.Cells[0, 5].Text = "담당자";
            spr.ActiveSheet.ColumnHeader.Cells[0, 6].Text = "부대1";
            spr.ActiveSheet.ColumnHeader.Cells[0, 7].Text = "부대2";
            spr.ActiveSheet.ColumnHeader.Cells[0, 8].Text = "부대3";
            spr.ActiveSheet.ColumnHeader.Cells[0, 9].Text = "부대4";
            spr.ActiveSheet.ColumnHeader.Cells[0,10].Text = "부대5";
            spr.ActiveSheet.ColumnHeader.Cells[0, 11].Text = "부대6";

        }
        private void 등록()
        {
            sql = " ";
            sql = sql + "insert into a101_arm (arm_code,arm,loc,tel,address,usr,arm1,arm2,arm3,arm4,arm5,arm6 ) values  ( ";
            sql = sql + "    '" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            sql = sql + "   ,'" + txt4.Text + "' ";
            sql = sql + "   ,'" + txt5.Text + "' ";
            sql = sql + "   ,'" + txt6.Text + "' ";
            sql = sql + "   ,'" + txtArm1.Text + "' ";
            sql = sql + "   ,'" + txtArm2.Text + "' ";
            sql = sql + "   ,'" + txtArm3.Text + "' ";
            sql = sql + "   ,'" + txtArm4.Text + "' ";
            sql = sql + "   ,'" + txtArm5.Text + "' ";
            sql = sql + "   ,'" + txtArm6.Text + "' ";
            sql = sql + "   ) ";
            cls_com.ExcuteNonQuery(sql);
            cls_com.로그(cls_com.사용자.성명, "부대 등록", "등록", sql);
            조회();
            초기화();
        }
        private void 수정()
        {
            sql = " ";
            sql = sql + "update a101_arm set ";
            sql = sql + "    arm = '" + txt2.Text + "' ";
            sql = sql + "   ,loc = '" + txt3.Text + "' ";
            sql = sql + "   ,tel = '" + txt4.Text + "' ";
            sql = sql + "   ,address = '" + txt5.Text + "' ";
            sql = sql + "   ,usr = '" + txt6.Text + "' ";
            sql = sql + "   ,arm1 = '" + txtArm1.Text + "' ";
            sql = sql + "   ,arm2 = '" + txtArm2.Text + "' ";
            sql = sql + "   ,arm3 = '" + txtArm3.Text + "' ";
            sql = sql + "   ,arm4 = '" + txtArm4.Text + "' ";
            sql = sql + "   ,arm5 = '" + txtArm5.Text + "' ";
            sql = sql + "   ,arm6 = '" + txtArm6.Text + "' ";
            sql = sql + "where arm_code = '" + txt1.Text + "' ";
            cls_com.ExcuteNonQuery(sql);
            cls_com.로그(cls_com.사용자.성명, "부대 등록", "수정", sql);
            조회();

        }
        private void 삭제()
        {

            DialogResult dr = MessageBox.Show("부대 삭제 ? ", "부대삭제", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;
            sql = " ";
            sql = sql + "delete from  a101_arm  ";
            sql = sql + "where arm_code = '" + txt1.Text + "' ";
            cls_com.ExcuteNonQuery(sql);
            cls_com.로그(cls_com.사용자.성명, "부대 등록", "삭제", sql);
            조회();
        }
        private void 초기화()
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txtArm1.Text = "";
            txtArm2.Text = "";
            txtArm3.Text = "";
            txtArm4.Text = "";
            txtArm5.Text = "";
            txtArm6.Text = "";
            txt1.Focus();
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
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.White;

        }

        private void spr_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
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
            txtArm5.Text = spr.ActiveSheet.Cells[e.Row, 10].Text;
            txtArm6.Text = spr.ActiveSheet.Cells[e.Row, 11].Text;
        }

        private void btnArm1_Click(object sender, EventArgs e)
        {
            기타_부대조회();
        }

        private void 기타_부대조회()
        {
            frm기타_부대조회 frm기타_부대조회 = new frm기타_부대조회(txtArm1.Text, txtArm2.Text, txtArm3.Text, txtArm4.Text, txtArm5.Text, txtArm6.Text);
            frm기타_부대조회.ShowDialog();
            txtArm1.Text = frm기타_부대조회.부대1;
            txtArm2.Text = frm기타_부대조회.부대2;
            txtArm3.Text = frm기타_부대조회.부대3;
            txtArm4.Text = frm기타_부대조회.부대4;
            txtArm5.Text = frm기타_부대조회.부대5;
            txtArm6.Text = frm기타_부대조회.부대6;
        }

        private void btnArm2_Click(object sender, EventArgs e)
        {
            기타_부대조회();

        }

        private void btnArm3_Click(object sender, EventArgs e)
        {
            기타_부대조회();

        }

        private void btnArm4_Click(object sender, EventArgs e)
        {
            기타_부대조회();

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

                    frm기타_부대_엑셀불러오기 frm기타_부대_엑셀불러오기 = new frm기타_부대_엑셀불러오기(openFileDialog.FileName);
                    frm기타_부대_엑셀불러오기.ShowDialog();
                    조회();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("File Open Error : " + ex.Message);
            }
        }
    }
}

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
    public partial class frm기초코드_사용자등록 : Form
    {
        String sql = "";
        public frm기초코드_사용자등록()
        {
            InitializeComponent();
        }

        private void frm기초코드_사용자등록_Load(object sender, EventArgs e)
        {
            Add등급();
            Add구분();
            초기화();
            조회();
        }

        private void 조회1()
        {
            // sql = "select id  [아이디] ,pw [암호] ,sosok [소속],nm [성명],sabun [사번],degree [등급] ,tel [연락처] ,bigo [비고] from a101_user  ";
            // sql = "select id  [아이디],pw [가가가2] ,sosok  from a101_user  ";
            sql = "select a.*,(select count(*) from a101_user_arm where id = a.id ) cnt from a101_user a order by  a.nm";

            DataSet ds = cls_com.Select_Query(sql);
            spr.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt.Text = ds.Tables[0].Rows.Count.ToString();
            spr.DataSource = ds;
            헤더();
            if (ds.Tables[0].Rows.Count > 0)
            {

                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;

                for (int i = 0;i < spr.ActiveSheet.RowCount; i++)
                {
                    if (spr.ActiveSheet.Cells[i,9].Text.Equals("0"))
                    {
                        spr.ActiveSheet.Cells[i, 0].BackColor = Color.Pink;
                    } else
                    {
                        spr.ActiveSheet.Cells[i, 0].BackColor = Color.White;
                    }
                }
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
        }


        private void 조회2()
        {
            // sql = "select id  [아이디] ,pw [암호] ,sosok [소속],nm [성명],sabun [사번],degree [등급] ,tel [연락처] ,bigo [비고] from a101_user  ";
            // sql = "select id  [아이디],pw [가가가2] ,sosok  from a101_user  ";
            FarPoint.Win.Spread.CellType.CheckBoxCellType cc = new FarPoint.Win.Spread.CellType.CheckBoxCellType();
            sql = "";
            sql = sql + " select   \n";
            sql = sql + "     case when isnull(b.arm_code,'')='' then '0' else '1' end sel \n";
            sql = sql + "    , a.arm_code, a.arm ,a.arm1,a.arm2,a.arm3,a.arm4,a.arm5,a.arm6 \n";
            sql = sql + " from  a101_arm a  \n";
            sql = sql + " left join (select * from a101_user_arm where id = '" + txt아이디2.Text + "') b  on a.arm_code = b.arm_code  \n ";
            if (!txt조회2.Text.Equals(""))
            {
                sql = sql + " where a.arm like '%" + txt조회2.Text + "%' or  a.arm1 like '%" + txt조회2.Text + "%' or  a.arm2 like '%" + txt조회2.Text 
                    + "%' or  a.arm3 like '%" + txt조회2.Text + "%' or  a.arm4 like '%" + txt조회2.Text + "%' or  a.arm5 like '%" + txt조회2.Text + "%' or  a.arm6 like '%" + txt조회2.Text + "%'    \n";
            }
            sql = sql + " order by a.arm_code   \n ";

            DataSet ds = cls_com.Select_Query(sql);
            spr2.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt2.Text = ds.Tables[0].Rows.Count.ToString();
            spr2.DataSource = ds;
            헤더2();
            if (ds.Tables[0].Rows.Count > 0)
            {

                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).Locked = true;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, 0).CellType = cc;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, 0).Locked = false;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, 0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center ;

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i]["sel"].ToString().Equals("1"))
                    {
                        spr2.ActiveSheet.Cells[i, 0].Value = true;
                    } else
                    {
                        spr2.ActiveSheet.Cells[i, 0].Value = false;
                    }
                }
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr2.Sheets[0]);
            lblCnt2.Text = spr2.ActiveSheet.RowCount.ToString();
        }
        private void 헤더()
        {
            int i = 0;

            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "아이디";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "암호";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소속";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "성명";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "계급";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "등급";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "연락처";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "비고";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "구분";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "선택부대";

        }

        private void 헤더2()
        {
            int i = 0;

            spr2.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "선택";
            spr2.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "부대코드";
            spr2.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "부대명";
            spr2.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "부대1";
            spr2.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "부대2";
            spr2.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "부대3";
            spr2.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "부대4";
            spr2.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "부대5";
            spr2.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "부대6";
        }

        private void 등록()
        {
            sql = " ";
            sql = sql + "insert into  a101_user (id,pw,sosok,nm,cla,degree,tel,bigo,gubun) values (";
            sql = sql + "    '" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            sql = sql + "   ,'" + txt4.Text + "' ";
            sql = sql + "   ,'" + txt5.Text + "' ";
            sql = sql + "   ,'" + cmb등급.Text + "' ";
            sql = sql + "   ,'" + txt6.Text + "' ";
            sql = sql + "   ,'" + txt7.Text + "' ";
            sql = sql + "   ,'" + cmb구분.Text + "' ";
            sql = sql + "  )  ";
            cls_com.ExcuteNonQuery(sql);
            cls_com.로그(cls_com.사용자.성명, "사용자 등록", "등록", sql);
            조회();
            초기화();
        }
        private void 수정()
        {
            sql = " ";
            sql = sql + "update a101_user  set ";
            sql = sql + "    pw = '" + txt2.Text + "' ";
            sql = sql + "   ,sosok = '" + txt3.Text + "' ";
            sql = sql + "   ,nm = '" + txt4.Text + "' ";
            sql = sql + "   ,cla = '" + txt5.Text + "' ";
            sql = sql + "   ,degree = '" + cmb등급.Text + "' ";
            sql = sql + "   ,tel = '" + txt6.Text + "' ";
            sql = sql + "   ,bigo = '" + txt7.Text + "' ";
            sql = sql + "   ,gubun = '" + cmb구분.Text + "' ";
            sql = sql + " where id = '" + txt1.Text + "' ";
            cls_com.ExcuteNonQuery(sql);
            cls_com.로그(cls_com.사용자.성명, "사용자 등록", "수정", sql);
            조회();

        }
        private void 삭제()
        {

            DialogResult dr = MessageBox.Show("이이디 " + txt1.Text + " 성명: " + txt3.Text + " 삭제하시겠습니까 ? ", "삭제", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
            {
                return; 
            }
            sql = " ";
            sql = sql + "delete from a101_user ";
            sql = sql + "where  id = '" + txt1.Text + "' ";
            cls_com.ExcuteNonQuery(sql);
            cls_com.로그(cls_com.사용자.성명, "사용자 등록", "삭제", sql);

            sql = " ";
            sql = sql + "delete from a101_user_arm ";
            sql = sql + "where  id = '" + txt1.Text + "' ";
            cls_com.ExcuteNonQuery(sql);


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
            txt7.Text = "";
            txt1.Focus();
        }
        private void Add등급()
        {
            cmb등급.Items.Clear();
            cmb등급.Items.Add("총관리자");
            cmb등급.Items.Add("관리자");
            cmb등급.Items.Add("자원운영자");
            cmb등급.Text = cmb등급.Items[1].ToString();
        }
        private void Add구분()
        {
            cmb구분.Items.Clear();
            cmb구분.Items.Add("");
            cmb구분.Items.Add("자산");
            cmb구분.Items.Add("소모품");
            cmb구분.Text = cmb구분.Items[0].ToString();
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
        private void 조회()
        {
            조회1();
            조회2();
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
            cmb등급.Text = spr.ActiveSheet.Cells[e.Row, 5].Text;
            txt6.Text = spr.ActiveSheet.Cells[e.Row, 6].Text;
            txt7.Text = spr.ActiveSheet.Cells[e.Row, 7].Text;
            cmb구분.Text = spr.ActiveSheet.Cells[e.Row, 8].Text;

            txt아이디2.Text = txt1.Text;
            txt소속2.Text = txt3.Text;
            txt성명2.Text = txt4.Text;
            조회2();

        }

        private void cmb등급_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (cmb등급.Text.Equals("총관리자"))
            {
                pan부대코드.Visible = false;
                txt8.Text = "";
            }
            else if (cmb등급.Text.Equals("관리자"))
            {
                pan부대코드.Visible = true;
                txt8.Text = "";
            }
            else if (cmb등급.Text.Equals("사용자"))
            {
                pan부대코드.Visible = true;
                txt8.Text = "";
            }
            */
        }

        private void txt조회2_TextChanged(object sender, EventArgs e)
        {
            조회2();
        }

        private void spr2_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr2.ActiveSheet);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txt성명2_TextChanged(object sender, EventArgs e)
        {

        }

        private void spr2_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            
        }

        private void spr2_ButtonClicked(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            String 선택="",부대코드="";
            
            if (txt아이디2.Text.Equals("") ) return;


            선택 = spr2.ActiveSheet.Cells[e.Row, e.Column].Value.ToString();
            부대코드 = spr2.ActiveSheet.Cells[e.Row, 1].Text;

            if (선택.Equals("True"))
            {
                sql = "";
                sql = sql + " delete from a101_user_arm  where id = '" + txt아이디2.Text + "' and arm_code = '" + 부대코드 + "'\n ";
                sql = sql + " insert into a101_user_arm ( id,arm_code) values ( '" + txt아이디2.Text + "','" + 부대코드 + "' ) \n " ;
                cls_com.ExcuteNonQuery(sql);

            } else
            {
                sql = "";
                sql = sql + " delete from a101_user_arm  where id = '" + txt아이디2.Text + "' and arm_code = '" + 부대코드 + "'\n ";
                cls_com.ExcuteNonQuery(sql);

            }
            조회1();

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

                    frm기타_사용자정보_엑셀불러오기 frm기타_사용자정보_엑셀불러오기 = new frm기타_사용자정보_엑셀불러오기(openFileDialog.FileName);
                    frm기타_사용자정보_엑셀불러오기.ShowDialog();
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

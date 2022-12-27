using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace arm_asset
{
    public partial class frm자산관리_DRIMS자산매칭등록 : Form
    {
        String sql = "";
        int r선택수량1 = 0, r선택수량2 = 0; 
        public frm자산관리_DRIMS자산매칭등록()
        {
            InitializeComponent();
        }

        private void frm자산관리_DRIMS자산매칭등록_Load(object sender, EventArgs e)
        {
            dtp.Text= cls_com.GetDate();
            초기화();
            조회();
        }

        private void 검증()
        {

            btn저장.Enabled = false;
            btn저장.BackColor = Color.Pink;
            try
            {
                int i;
                txt메세지.Text = "";
                if (cls_com.Val2(lbl선택수량1.Text) == 0)
                {
                    txt메세지.Text = "자산을 선택하세요";
                    return;
                }
                if (cls_com.Val2(lbl선택수량2.Text) == 0)
                {
                    txt메세지.Text = "저장할 자산을 선택하세요";
                    return;
                }
                if (!lbl선택수량1.Text.Equals(lbl선택수량2.Text))
                {
                    txt메세지.Text = "선택한 자산과 저장할 자산 수량이 같아야 합니다.";
                    return;
                }

                FarPoint.Win.Spread.Model.CellRange[] cr, cr2;
                cr = spr1.ActiveSheet.GetSelections();
                cr2 = spr2.ActiveSheet.GetSelections();


                for (i = 0; i < spr1.ActiveSheet.RowCount; i++)
                {

                    if (spr1.ActiveSheet.Cells[i, 0].Text.Equals("True")) { 
                        if (!spr1.ActiveSheet.Cells[i, 6].Text.Equals(""))
                        {
                            txt메세지.Text = "에러 관리번호가 등록 되어 있습니다. " + (i + 1).ToString();
                            break;
                        }
                    }
                }

                

                for (i = 0 ; i < spr2.ActiveSheet.RowCount ; i++)
                {
                    if (spr2.ActiveSheet.Cells[i, 0].Text.Equals("True"))
                    {
                        sql = "SELECT code from a201_asset where ( d1 = '" + spr2.ActiveSheet.Cells[i, 6].Text + "' )  ";
                        DataSet ds = cls_com.Select_Query(sql);
                        {
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                spr2.ActiveSheet.Cells[i, 1].BackColor = Color.Pink;
                                txt메세지.Text = "등록된 관리번호입니다";

                            }
                            else
                            {
                          //      spr2.ActiveSheet.Cells[i, 0].Text = "";
                                spr2.ActiveSheet.Cells[i, 1].BackColor = Color.White;
                            }
                        }

                    }
                }

                if (txt메세지.Text.Equals("")) { 
                    btn저장.Enabled = true;
                    btn저장.BackColor = Color.GreenYellow;
                }

            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }



        }
        private void 저장()
        {
            try
            {
                int i;
                int irow1 = -1, irow2 = -1;
                txt메세지.Text = "";
                if (cls_com.Val2(lbl선택수량1.Text) == 0)
                {
                    txt메세지.Text = "자산을 선택하세요";
                    return;
                }
                if (cls_com.Val2(lbl선택수량2.Text) == 0)
                {
                    txt메세지.Text = "저장할 자산을 선택하세요";
                    return;
                }
                if (!lbl선택수량1.Text.Equals(lbl선택수량2.Text))
                {
                    txt메세지.Text = "선택한 자산과 저장할 자산 수량이 같아야 합니다.";
                    return;
                }

                
                for (i =0 ; i < spr1.ActiveSheet.RowCount ; i++)
                {
                    if (spr1.ActiveSheet.Cells[i, 0].Text.Equals("True"))
                    {
                        if (!spr1.ActiveSheet.Cells[i, 6].Text.Equals(""))
                        {
                            txt메세지.Text = "에러 관리번호가 등록 되어 있습니다. " + (i + 1).ToString();
                            break;
                        }
                    }
                }

                irow1 = 0;
                irow2 = 0; 

                while (true)
                {
                    irow1 = spr1이동(irow1);
                    irow2 = spr2이동(irow2);
                    if ((irow1 >= spr1.ActiveSheet.RowCount) || ( irow2 >= spr2.ActiveSheet.RowCount ) )
                    {
                        break;
                    }
                    sql = "SELECT code from a201_asset where d1 = '" + spr2.ActiveSheet.Cells[irow2, 6].Text + "' ";
                    DataSet ds = cls_com.Select_Query(sql);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        spr2.ActiveSheet.Cells[i, 0].Text = "등록된 관리번호입니다";
                        spr2.ActiveSheet.Cells[i, 0].BackColor = Color.Pink;
                        txt메세지.Text = "등록된 관리번호입니다";
                    }
                    else
                    {
                        try
                        {
                            cls_com.gCon = new SqlConnection(cls_com.gConn_String);
                            cls_com.gCon.Open();
                            SqlTransaction tran;
                            tran = cls_com.gCon.BeginTransaction();


                            sql = "UPDATE a201_asset SET  d1 = '" + spr2.ActiveSheet.Cells[irow2, 6].Text + "' ,d18 = '" + cls_com.GetDate(dtp.Value) + "' where  code = '" + spr1.ActiveSheet.Cells[irow1, 1].Text + "' ";
                            if (!cls_com.ExcuteNonQueryT(sql, tran).Equals("success"))
                            {
                                tran.Rollback();
                                return;
                            }
                            sql = "UPDATE a201_asset_drims SET  code = '" + spr1.ActiveSheet.Cells[irow1, 1].Text + "' where  d1 = '" + spr2.ActiveSheet.Cells[irow2, 6].Text + "' ";
                            if (!cls_com.ExcuteNonQueryT(sql, tran).Equals("success"))
                            {
                                tran.Rollback();
                                return;

                            }
                            tran.Commit();
                            cls_com.gCon.Close();

                            cls_com.로그(cls_com.사용자.성명, "DRIMS 자산 매칭", "수정", sql);
                        } catch (SqlException ee)
                        {
                            MessageBox.Show(ee.Message);
                        }
                    }
                    irow1++;
                    irow2++;
                }

                MessageBox.Show("저장 완료");
                btn저장.Enabled = false;
                btn저장.BackColor = Color.Pink;
                조회();

            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private int spr1이동(int irow)
        {
            int i = 0;

            for (i = irow; i < spr1.ActiveSheet.RowCount; i++)
            {
                if (spr1.ActiveSheet.Cells[i, 0].Text.Equals("True"))
                {
                    return i;
                }
            }
            return i;
        }
        private int spr2이동(int irow)
        {
            int i = 0;

            for (i = irow; i < spr2.ActiveSheet.RowCount; i++)
            {
                if (spr2.ActiveSheet.Cells[i, 0].Text.Equals("True"))
                {
                    return i;
                }
            }
            return i;
        }


        private void 삭제()
        {
            sql = " ";
            sql = sql + "Delete from a201_asset_drims ";
            cls_com.ExcuteNonQuery(sql);
            조회2();
        }

        private void 초기화()
        {
            txt1.Text = "";
            //          txt2.Text = "";
            txt자원분류.Text = "";
            txt제조사.Text = "";
            txt사업명.Text = "";
            txt자원분류2.Text = "";
            txt제조사2.Text = "";
            txt사업명2.Text = "";

            txt1.Focus();
        }
        private void 닫기()
        {
            Close();
        }


        private void btn검증_Click(object sender, EventArgs e)
        {
            검증();
        }

        private void btn저장_Click(object sender, EventArgs e)
        {
            저장();
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
        private void 조회1()
        {

            string var = "";
            string w = "";
            FarPoint.Win.Spread.CellType.CheckBoxCellType cb = new FarPoint.Win.Spread.CellType.CheckBoxCellType();


            for (int i = 0; i < cls_com.g타이틀_수량 - 5; i++)
            {
                var = var + ",a.d" + (i + 1).ToString() + " \n";
            }
            if (!txt자원분류.Text.Equals("")) { 
                w = w + " and  d4 = '" + txt자원분류.Text + "'  \n ";
            }
            if (!txt제조사.Text.Equals(""))
            {
                w = w + " and  d5 = '" + txt제조사.Text + "'  \n ";
            }
            if (!txt사업명.Text.Equals(""))
            {
                w = w + " and  d14 like '%" + txt사업명.Text + "%'  \n ";
            }

            // 최종수정일
            w = w + " and ( d1 = '' or d18 = '" + cls_com.GetDate(dtp.Value) + "' ) \n ";
            /*
            if (!txt1.Text.Equals(""))
            {
                w = w + " or  a.code" + " like '%" + txt1.Text + "%' ";
                for (int i = 1; i < spr1.ActiveSheet.ColumnCount; i++)
                {
                    w = w + " or a.d" + i.ToString() + " like '%" + txt1.Text + "%' ";
                }

            }
            */
            if (w.Length > 0)
            {
                w = " where " + w.Substring(4);
            }
            sql = "";
            sql = sql + " select '' sel, a.code,a.dt,a.state,a.arm_code,b.arm " + var;
            sql = sql + " from  a201_asset a  \n ";
            sql = sql + " left join a101_arm b on a.arm_code = b.arm_code  \n ";
            sql = sql + w;
            sql = sql + " order by  a.d1 \n";

            DataSet ds = cls_com.Select_Query(sql);
            spr1.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            spr1.DataSource = ds;
            헤드1(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                spr1.Sheets[0].Cells.Get(0, 0, spr1.Sheets[0].RowCount - 1, 0).CellType = cb;
                spr1.Sheets[0].Cells.Get(0, 0, spr1.Sheets[0].RowCount - 1, spr1.Sheets[0].ColumnCount - 1).Locked = true;
                spr1.Sheets[0].Cells.Get(0, 0, spr1.Sheets[0].RowCount - 1, spr1.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr1.Sheets[0].Cells.Get(0, 0, spr1.Sheets[0].RowCount - 1, spr1.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;

                spr1.Sheets[0].Cells.Get(0, 0, spr1.Sheets[0].RowCount - 1, 0 ).Locked = false;
                spr1.Sheets[0].Cells.Get(0, 0, spr1.Sheets[0].RowCount - 1, 0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr1.Sheets[0].Cells.Get(0, 0, spr1.Sheets[0].RowCount - 1, 0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;

                r선택수량1 = 0;
                for (int i = 0; i < spr1.ActiveSheet.RowCount; i++)
                {

                    if (spr1.ActiveSheet.Cells[i, 6].Text.Equals(""))
                    {
                        spr1.ActiveSheet.Cells[i, 0].Value = true;
                        r선택수량1++;
                    }
                    else
                    {
                        spr1.ActiveSheet.Cells[i, 0].Value = false;

                    }
                }
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr1.Sheets[0]);
            lblCnt1.Text = spr1.ActiveSheet.RowCount.ToString();
            lbl선택수량1.Text = r선택수량1.ToString();
        }
        private void 조회2()
        {
            FarPoint.Win.Spread.CellType.CheckBoxCellType cb = new FarPoint.Win.Spread.CellType.CheckBoxCellType();
            string var = "";
            string w = "";


            for (int i = 0; i < cls_com.g타이틀_수량 - 5; i++)
            {
                var = var + ",a.d" + (i + 1).ToString();
            }

            if (!txt자원분류2.Text.Equals(""))
            {
                w = w + " and  a.d4 = '" + txt자원분류2.Text + "'  \n ";
            }
            if (!txt제조사2.Text.Equals(""))
            {
                w = w + " and  a.d5 = '" + txt제조사2.Text + "'  \n ";
            }
            if (!txt사업명2.Text.Equals(""))
            {
                w = w + " and  a.d14 like '%" + txt사업명2.Text + "%'  \n ";
            }

            if (!txt21.Text.Equals(""))
            {
                w = w + " or a.code" + " like '%" + txt1.Text + "%' ";
                for (int i = 1; i < spr2.ActiveSheet.ColumnCount; i++)
                {
                    w = w + " or a.d" + i.ToString() + " like '%" + txt1.Text + "%' ";
                }

            }


            if (w.Length > 0)
            {
                w = " where " + w.Substring(4);
            }
            sql = "";
            sql = sql + " select '' sel,a.code,a.dt,state,a.arm_code,b.arm \n" + var;
            sql = sql + " from  a201_asset_drims a  \n";
            sql = sql + " left join a101_arm b on a.arm_code = b.arm_code  \n";
            sql = sql + w;
            sql = sql + " order by  a.d1 \n";

            DataSet ds = cls_com.Select_Query(sql);
            spr2.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            spr2.DataSource = ds;
            헤드2(ds);
            r선택수량2 = 0;
            if (ds.Tables[0].Rows.Count > 0)
            {
         //       spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).Locked = true;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, 0).CellType = cb;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, 0).Locked = false;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, 0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, 0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
                for (int i = 0; i < spr2.ActiveSheet.RowCount; i++)
                {
                    if (spr2.ActiveSheet.Cells[i, 1].Text.Equals(""))
                    {
                        spr2.ActiveSheet.Cells[i, 0].Value = true;
                        r선택수량2++;
                    }
                }

            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr2.Sheets[0]);
            lblCnt2.Text = spr2.ActiveSheet.RowCount.ToString();
            lbl선택수량2.Text = r선택수량2.ToString();
        }
        private void 헤드1(DataSet ds)
        {

            spr1.ActiveSheet.ColumnHeader.Cells[0, 0].Text = "선택";
            for (int i = 1; i < ds.Tables[0].Columns.Count; i++)
            {

                spr1.ActiveSheet.ColumnHeader.Cells[0, i].Text = cls_com.g타이틀[i-1];
            }
        }
        private void 헤드2(DataSet ds)
        {
            spr2.ActiveSheet.ColumnHeader.Cells[0, 0].Text = "선택";

            for (int i = 1; i < ds.Tables[0].Columns.Count; i++)
            {

                spr2.ActiveSheet.ColumnHeader.Cells[0, i].Text = cls_com.g타이틀[i-1];
            }
        }
        private void btn닫기_Click(object sender, EventArgs e)
        {
            닫기();
        }

        private void spr_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr1.ActiveSheet);
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
            txt1.Text = spr1.ActiveSheet.Cells[e.Row, 0].Text;
            txt2.Text = spr1.ActiveSheet.Cells[e.Row, 1].Text;


            txt21.Text = spr1.ActiveSheet.Cells[e.Row, 0].Text;
            txt22.Text = spr1.ActiveSheet.Cells[e.Row, 1].Text;
            txt23.Text = "" ;
            txt24.Text = "";
            */
            조회2();

        }

        private void btn초기화2_Click(object sender, EventArgs e)
        {
            // 초기화2();
        }



        private void spr2_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr2.ActiveSheet);
        }

        private void spr2_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            /*
            txt21.Text = spr2.ActiveSheet.Cells[e.Row, 0].Text;
            txt22.Text = spr2.ActiveSheet.Cells[e.Row, 1].Text;
            txt23.Text = spr2.ActiveSheet.Cells[e.Row, 2].Text;
            txt24.Text = spr2.ActiveSheet.Cells[e.Row, 3].Text;
            */
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            조회1();
        }

        private void txt21_TextChanged(object sender, EventArgs e)
        {
            조회2();
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

                    frm기타_엑셀불러오기_DRIMS frm기타_엑셀불러오기_DRIMS = new frm기타_엑셀불러오기_DRIMS(openFileDialog.FileName);
                    frm기타_엑셀불러오기_DRIMS.ShowDialog();
                    조회();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("File Open Error : " + ex.Message);
            }
        }

        private void spr1_SelectionChanged(object sender, FarPoint.Win.Spread.SelectionChangedEventArgs e)
        {
            FarPoint.Win.Spread.Model.CellRange[] cr;
            cr = spr1.ActiveSheet.GetSelections();
            if (cr.Length > 0)
            {
                if (cr[0].RowCount < 0)
                {
                    txt선택자산.Text = spr1.ActiveSheet.RowCount.ToString();
                } else { 
                    txt선택자산.Text = cr[0].RowCount.ToString();
                }
            }
            else
            {
                txt선택자산.Text = "";
            }
        }

        private void spr2_SelectionChanged(object sender, FarPoint.Win.Spread.SelectionChangedEventArgs e)
        {
            FarPoint.Win.Spread.Model.CellRange[] cr;
            cr = spr2.ActiveSheet.GetSelections();
            if (cr.Length > 0)
            {
                if (cr[0].RowCount < 0)
                {
                    txt저장자산.Text = spr2.ActiveSheet.RowCount.ToString();
                }
                else
                {
                    txt저장자산.Text = cr[0].RowCount.ToString();
                }
            }
            else
            {
                txt저장자산.Text = "";
            }
        }

        private void spr1_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            bool b;
            if (e.ColumnHeader)
            {
                if (spr1.ActiveSheet.ActiveColumn.Index == 0)
                {

                    if (spr1.ActiveSheet.ActiveRow.Index >= 0)
                    {
                        r선택수량1 = 0;
                        if (spr1.ActiveSheet.Cells[0, 0].Text.Equals("True"))
                        {
                            b = false;
                        }
                        else
                        {
                            b = true;
                        }
                        for (int i = 0; i < spr1.ActiveSheet.RowCount; i++)
                        {
                            spr1.ActiveSheet.Cells[i, 0].Value = b;
                            if (b)
                            {
                                if (!spr1.ActiveSheet.Cells[i, 6].Text.Equals(""))
                                {
                                    spr1.ActiveSheet.Cells[i, 0].Value = false ;
                                } else { 
                                    r선택수량1++;
                                }
                            }
                        }
                        lbl선택수량1.Text = r선택수량1.ToString();
                    }
                }
            }
        }

        private void spr1_ButtonClicked(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            if (e.Column == 0)
            {
                if (spr1.ActiveSheet.Cells[e.Row, e.Column].Text.Equals("True"))
                {
                    r선택수량1++;
                }
                else
                {
                    r선택수량1--;
                }
                lbl선택수량1.Text = r선택수량1.ToString();
            }
        }

        private void spr2_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            bool b;
            if (e.ColumnHeader)
            {
                if (spr2.ActiveSheet.ActiveColumn.Index == 0)
                {

                    if (spr2.ActiveSheet.ActiveRow.Index >= 0)
                    {
                        r선택수량2 = 0;
                        if (spr2.ActiveSheet.Cells[0, 0].Text.Equals("True"))
                        {
                            b = false;
                        }
                        else
                        {
                            b = true;
                        }
                        for (int i = 0; i < spr2.ActiveSheet.RowCount; i++)
                        {
                            spr2.ActiveSheet.Cells[i, 0].Value = b;
                            if (b)
                            {
                                if (!spr2.ActiveSheet.Cells[i, 1].Text.Equals(""))
                                {
                                    spr2.ActiveSheet.Cells[i, 0].Value = false;
                                }
                                else
                                {
                                    r선택수량2++;
                                }
                            }
                        }
                        lbl선택수량2.Text = r선택수량2.ToString();
                    }
                }
            }
        }

        private void spr2_ButtonClicked(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            if (e.Column == 0)
            {
                if (spr2.ActiveSheet.Cells[e.Row, e.Column].Text.Equals("True"))
                {
                    r선택수량2++;
                }
                else
                {
                    r선택수량2--;
                }
                lbl선택수량2.Text = r선택수량2.ToString();
            }
        }

        private void txt자원분류_TextChanged(object sender, EventArgs e)
        {
            txt자원분류2.Text = txt자원분류.Text;
        }

        private void txt제조사_TextChanged(object sender, EventArgs e)
        {
            txt제조사2.Text = txt제조사.Text;
        }

        private void txt사업명_TextChanged(object sender, EventArgs e)
        {
            txt사업명2.Text = txt사업명.Text;
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            조회();            
        }
    }
}

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
using System.Data.SqlClient;

namespace arm_asset
{
    public partial class frm소모품불출수령_소모품수령 : Form
    {
        string sql;
        int r선택수량 = 0;
        public frm소모품불출수령_소모품수령()
        {
            InitializeComponent();
        }

        private void frm소모품불출수령_소모품수령_Load(object sender, EventArgs e)
        {
            초기화();
        }
        private void 초기화()
        {
            dtp.Text  = cls_com.GetDate();
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

        private void frm소모품불출수령_소모품수령_Activated(object sender, EventArgs e)
        {
            txt1.Focus();
        }
        private void 조회()
        {

            FarPoint.Win.Spread.CellType.CheckBoxCellType cc = new FarPoint.Win.Spread.CellType.CheckBoxCellType();
            String 소속코드 = "", 소속명 = "";
            String 일자;
            String[] a;
            string w = "";
            r선택수량 = 0;
            lbl선택수량.Text = r선택수량.ToString();
            a = cmb소속부대.Text.Split(' ');
            if (a.Length >= 2)
            {
                소속코드 = a[0];
                소속명 = a[1];
            }

            일자 = cls_com.GetDate(dtp.Value);

            if (!cls_com.사용자.등급.Equals("총관리자"))
            {
                w = w + " and a.arm_code_s in ( select b.arm_code  from a101_user a left join a101_user_arm b on a.id = b.id  where a.id = '" + cls_com.사용자.아이디 + "' ) \n ";
            } else
            {


            }
            sql = "";
            sql = sql + " select '' sel,a.dt ,a.tm,a.state,a.num1,a.num2,a.arm_code,b.arm ,a.arm_code_s, c.arm arm2,a.usr,a.code,d.d1,d.d2, d.d3,d.d4,a.cnt ,a.d1,a.d2,a.d3,a.d4,a.d5,a.d6 \n";
            sql = sql + " from b301_output a \n";
            sql = sql + " left join a101_arm b on a.arm_code = b.arm_code  \n";
            sql = sql + " left join a101_arm c on a.arm_code_s = c.arm_code \n";
            sql = sql + " left join b101_con d on a.code  = d.code  \n";
            sql = sql + " where  ( (  a.state ='불출대기' and a.chk ='' )  \n";
            sql = sql + "   or  ( a.state ='수령' and a.chk = '1' and a.dt = '" + cls_com.GetDate(dtp.Value) + "' ) )   \n ";
            sql = sql + w;
            sql = sql + " order by a.arm_code_s,a.dt,a.num1,a.num2 \n";

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
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left ;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, 0).Locked = false;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, 0).CellType = cc;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, 0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;

                r선택수량 = 0;
                for (int i = 0; i < spr.ActiveSheet.Rows.Count; i++)
                {
                    if ( spr.ActiveSheet.Cells[i, 3].Text.Equals("불출대기"))
                    {
                        spr.ActiveSheet.Cells.Get(i, 3, i, 3).BackColor = Color.Pink;
                        spr.ActiveSheet.Cells[i, 0].Value = true;
                        r선택수량++;
                    } else
                    {
                        spr.ActiveSheet.Cells.Get(i, 3, i, 3).BackColor = Color.White;
                        spr.ActiveSheet.Cells[i, 0].Value = false;

                    }

                }
                
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
            lbl선택수량.Text = r선택수량.ToString();
        }
        private void 헤더(DataSet ds)
        {
            int i = 0;
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "선택";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "일자";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "시간";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "상태";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "증빙번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소속부대코드";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소속부대";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "수령부대코드";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "수령부대";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "사용자";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소모품번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "제품분류";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "제품명";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "제조사";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "모델명";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "수량";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "사업명";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "예산구분";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "근거";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "비고";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "출납관";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "수령및반납관";
            spr.ActiveSheet.ColumnHeader.Rows[0].Height = 30;

        }
        private void txt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //저장(txt1.Text,chk취소.Checked);
                조회();

            }
        }

        private void 저장(string 증빙번호,string 증빙번호_번호,string 소모품번호,string 상태,bool 취소여부)
        {
            String 소속코드, 수령_소속코드;
            String 일자, 시간;
            String 상태_저장 = "수령";
            String sql1 = "";
            String d1 = "", d2 = "", d3 = "", d4 = "";
            String 수량 = "";
            DataSet ds0,ds;
            sql = "SELECT * FROM b301_output  where code = '" + 소모품번호 + "' and num1 = '" + 증빙번호 + "' and num2  = '" + 증빙번호_번호 + "' and state = '" + 상태 + "' ORDER BY dt desc, tm desc ";
            ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("미등록 번호 입니다.");
                포커스();
                return;
            }

            상태 = ds.Tables[0].Rows[0]["state"].ToString();
            소속코드 = ds.Tables[0].Rows[0]["arm_code"].ToString();
            수령_소속코드 = ds.Tables[0].Rows[0]["arm_code_s"].ToString();
            일자 = cls_com.GetDate(dtp.Value);
            시간 = cls_com.GetTime();
            수량 = ds.Tables[0].Rows[0]["cnt"].ToString();
            d1 = ds.Tables[0].Rows[0]["d1"].ToString();
            d2 = ds.Tables[0].Rows[0]["d2"].ToString();
            d3 = ds.Tables[0].Rows[0]["d3"].ToString();
            d4 = ds.Tables[0].Rows[0]["d4"].ToString();

            if (취소여부)
            {
                if (!상태.Equals("수령"))
                {
                    MessageBox.Show("상태가 수령 이여야 합니다. 상태 :" + 상태 + "   수령 취소 불가");
                    return;
                }

                sql = " ";
                sql = sql + "delete from  b301_output  where code = '" + 소모품번호 + "' and num1 = '" + 증빙번호 + "' and num2  = '" + 증빙번호_번호 + "' and state = '수령'  ";
                cls_com.gCon = new SqlConnection(cls_com.gConn_String);
                cls_com.gCon.Open();
                SqlTransaction tran;
                tran = cls_com.gCon.BeginTransaction();
                if (!cls_com.ExcuteNonQueryT(sql, tran).Equals("success"))
                {
                    tran.Rollback();
                    return;
                }
                cls_com.로그(cls_com.사용자.성명, "소모품 수령", "취소", sql);

                sql1 = " UPDATE b301_output  set chk = '' where code = '" + 소모품번호 + "' and chk = '1' and state = '불출대기' and num1 = '" + 증빙번호 + "' and num2 = '" + 증빙번호_번호 + "' ";
                if (!cls_com.ExcuteNonQueryT(sql1, tran).Equals("success"))
                {
                    tran.Rollback();
                    return;
                }

                sql1 = "update  b201_stock set cnt = cnt - " + 수량 + " where code = '" + 소모품번호 + "' and arm_code = '" + 수령_소속코드 + "' ";
                if (!cls_com.ExcuteNonQueryT(sql1, tran).Equals("success"))
                {
                    tran.Rollback();
                    return;
                }

                tran.Commit();
                cls_com.gCon.Close();

                cls_com.로그(cls_com.사용자.성명, "소모품 수령", "취소", sql);

            }
            else {
                if (!상태.Equals("불출대기"))
                {
                    MessageBox.Show("상태가 불출대기 여야 합니다. 상태 :" + 상태 + "   수령 불가");
                    return;
                }
                sql = " ";
                sql = sql + "insert into b301_output (dt,tm,num1,num2,state,arm_code,arm_code_s,code,usr,chk,cnt,d1,d2,d3,d4) values ( ";
                sql = sql + "    '" + 일자 + "' ";
                sql = sql + "   ,'" + 시간 + "' ";
                sql = sql + "   ,'" + 증빙번호 + "' ";
                sql = sql + "   ,'" + 증빙번호_번호 + "' ";
                sql = sql + "   ,'" + 상태_저장 + "' ";
                sql = sql + "   ,'" + 소속코드 + "' ";
                sql = sql + "   ,'" + 수령_소속코드 + "' ";
                sql = sql + "   ,'" + 소모품번호 + "' ";
                sql = sql + "   ,'" + cls_com.사용자.성명 + "' ";
                sql = sql + "   ,'" + "1" + "' ";
                sql = sql + "   ,'" + 수량 + "' ";
                sql = sql + "   ,'" + d1 + "' ";
                sql = sql + "   ,'" + d2 + "' ";
                sql = sql + "   ,'" + d3 + "' ";
                sql = sql + "   ,'" + d4 + "' ";
                sql = sql + "   ) ";
                cls_com.gCon = new SqlConnection(cls_com.gConn_String);
                cls_com.gCon.Open();
                SqlTransaction tran;
                tran = cls_com.gCon.BeginTransaction();
                if (!cls_com.ExcuteNonQueryT(sql, tran).Equals("success"))
                {
                    tran.Rollback();
                    return;
                }
                cls_com.로그(cls_com.사용자.성명, "소모품 수령", "수령", sql);

                sql1 = " UPDATE b301_output  set chk = '1' where code = '" + 소모품번호 + "' and chk = '' and state = '불출대기' and num1 = '" + 증빙번호 + "' and num2 = '" + 증빙번호_번호 + "' ";
                if (!cls_com.ExcuteNonQueryT(sql1, tran).Equals("success"))
                {
                    tran.Rollback();
                    return;
                }


                ds0 = cls_com.Select_Query("select * from b201_stock where code = '" + 소모품번호 + "' and arm_code = '" + 수령_소속코드 + "' ");
                if (ds0.Tables[0].Rows.Count > 0)
                {
                    sql1 = "update  b201_stock set cnt = cnt + " + 수량 + " where code = '" + 소모품번호 + "' and arm_code = '" + 수령_소속코드 + "' ";
                    if (!cls_com.ExcuteNonQueryT(sql1, tran).Equals("success"))
                    {
                        tran.Rollback();
                        return;
                    }

                }   else
                {
                    sql1 = "insert into  b201_stock (code,dt,state,arm_code,cnt,d1,d2,d3) values ('" + 소모품번호 + "','" + cls_com.GetDate() + "','','" + 수령_소속코드 + "','" + 수량 + "','','','' ) ";
                    if (!cls_com.ExcuteNonQueryT(sql1, tran).Equals("success"))
                    {
                        tran.Rollback();
                        return;
                    }

                }
                tran.Commit();
                cls_com.gCon.Close();

                cls_com.로그(cls_com.사용자.성명, "소모품 수령", "수령", sql);

            }
            txt1.Text = "";
            txt1.Focus();
            txt1.SelectAll();
            chk취소.Checked = false;
            메인조회();
        }
        private void 메인조회()
        {
            frm메인 frm = (frm메인)cls_com.gForm;
            frm.조회_수령대기();
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

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chk취소_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt1.Focus();
        }

        private void btn출력_Click(object sender, EventArgs e)
        {
            출력();
        }
        private void 출력()
        {
            string title = "소모품 수령";
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

        private void dtp_CloseUp(object sender, EventArgs e)
        {
            조회();
        }

        private void btn출력_거래증_Click(object sender, EventArgs e)
        {
            //출력_거래증();
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

        private void btn선택불입_Click(object sender, EventArgs e)
        {
            선택불입();
        }

        private void btn선택불입취소_Click(object sender, EventArgs e)
        {
            선택불입취소();
        }
        private void 선택불입()
        {
            string 소모품번호, 증빙번호, 증빙번호_번호,상태;
            DialogResult dr = MessageBox.Show("선택 수령  " + lbl선택수량.Text + " 건 수령 하시겠습니까?", "선택 수령", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;

            for (int i = 0; i < spr.ActiveSheet.RowCount; i++)
            {
                if (spr.ActiveSheet.Cells[i, 0].Text.Equals("True"))
                {
                    상태 = spr.ActiveSheet.Cells[i, 3].Text;
                    증빙번호 = spr.ActiveSheet.Cells[i, 4].Text;
                    증빙번호_번호 = spr.ActiveSheet.Cells[i, 5].Text;
                    소모품번호 = spr.ActiveSheet.Cells[i, 11].Text;

                    저장(증빙번호,증빙번호_번호,소모품번호, 상태, false);
                }

            }
            조회();
        }
        private void 선택불입취소()
        {

            string 소모품번호, 증빙번호, 증빙번호_번호,상태;

            DialogResult dr = MessageBox.Show("선택 수령 취소  " + lbl선택수량.Text + " 건 수령 취소 하시겠습니까?", "선택 수령 취소", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;

            for (int i = 0; i < spr.ActiveSheet.RowCount; i++)
            {
                if (spr.ActiveSheet.Cells[i, 0].Text.Equals("True"))
                {
                    상태 = spr.ActiveSheet.Cells[i, 3].Text;
                    증빙번호 = spr.ActiveSheet.Cells[i, 4].Text;
                    증빙번호_번호 = spr.ActiveSheet.Cells[i, 5].Text;
                    소모품번호 = spr.ActiveSheet.Cells[i, 11].Text;

                    저장(증빙번호, 증빙번호_번호, 소모품번호, 상태,true);
                }

            }
            조회();
        }
        private void 포커스()
        {
            txt1.Text = "";
            txt1.Focus();
        }

        private void spr_ButtonClicked(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            if (e.Column == 0)
            {
                if (spr.ActiveSheet.Cells[e.Row, e.Column].Text.Equals("True"))
                {
                    r선택수량++;
                }
                else
                {
                    r선택수량--;
                }
                lbl선택수량.Text = r선택수량.ToString();
            }
        }

        private void spr_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            bool b;
            if (e.ColumnHeader)
            {
                if (spr.ActiveSheet.ActiveColumn.Index == 0 )
                {

                    if (spr.ActiveSheet.ActiveRow.Index >= 0)
                    {
                        if (spr.ActiveSheet.Cells[0, 0].Text.Equals("True"))
                        {
                            b = false;
                        } else
                        {
                            b = true;
                        }
                        for (int i = 0; i < spr.ActiveSheet.RowCount; i++)
                        {
                            spr.ActiveSheet.Cells[i, 0].Value = b;
                        }
                    }
               }
            }
        }

        private void btn출력_거래증_Click_1(object sender, EventArgs e)
        {

            string 증빙번호 = "", 부대1 = "", 부대2 = "";
            int i;
           
            if (spr.ActiveSheet.Rows.Count < 0) return;
            i = spr.ActiveSheet.ActiveRow.Index;
            부대1 = spr.ActiveSheet.Cells[i, 6].Text + " " + spr.ActiveSheet.Cells[i, 7].Text;
            부대2 = spr.ActiveSheet.Cells[i, 8].Text + " " + spr.ActiveSheet.Cells[i, 9].Text; ;
            증빙번호 = spr.ActiveSheet.Cells[i, 4].Text;
            frm출력_거래증 frm출력_거래증 = new frm출력_거래증("소모품", cls_com.GetDate(dtp.Value), "수령", 증빙번호, 부대1, 부대2);
            frm출력_거래증.ShowDialog();
        }

        private void spr_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {

        }
    }
}

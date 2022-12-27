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
    public partial class frm소모품불출수령_소모품소모처리 : Form
    {
        bool r초기화 = true;
        string sql;
        TextBox rtb;
         public frm소모품불출수령_소모품소모처리()
        {
            InitializeComponent();
        }

        private void frm소모품불출수령_소모품소모처리_Load(object sender, EventArgs e)
        {
            string d;
            dtp.Text = cls_com.GetDate();
            초기화();
            cls_com.Add소속부대(cmb소속부대);
            d= cls_com.ConfigLoad(this.Name + "_sc_넓이");
            sc.SplitterDistance = cls_com.Val2(d);
            txt출납관.Text = cls_com.출납관_반납관(cls_com.사용자.아이디, "");
            조회();

        }
        private void 초기화()
        {
            txt1.Text = "";
            txt2.Text = "";
            txt수량.Text = "";
            txt근거.Text = "";
            txt비고.Text = "";
        }
        private void cmb소속_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt반납관.Text =  cls_com.출납관_반납관("",cls_com.GetCode(cmb소속부대.Text));
            조회1();
            포커스(txt수량);
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

        private void frm소모품불출수령_소모품소모처리_Activated(object sender, EventArgs e)
        {
            포커스(txt1);
        }
    
        private void 조회0()
        {

            FarPoint.Win.Spread.CellType.CheckBoxCellType cc = new FarPoint.Win.Spread.CellType.CheckBoxCellType();
            string w = "";
            if (!cls_com.사용자.등급.Equals("총관리자"))
            {
                w = w + " and b.arm_code in  ( select arm_code from a101_user a left join a101_user_arm b on a.id = b.id where a.id = '" + cls_com.사용자.아이디 + "' )  \n";
            }


            if (!txt조회.Text.Equals(""))
            {
                w = w + " and (a.d1 like '%" + txt조회.Text + "%'  or a.d2 like '%" + txt조회.Text + "%'  or a.d3 like '%" + txt조회.Text + "%'   or a.d4 like '%" + txt조회.Text + "%'  or b.d1 like '%" + txt조회.Text + "%'  )  \n";
            }

            if (cb재고.Checked)
            {
                w = w + " and not isnull(b.cnt,'') =''and b.cnt > 0   \n";
            }


            if (!w.Equals(""))
            {
                w = " where " + w.Substring(4);
            }

            
            

            sql = "";
            sql = sql + " select a.code,a.d1,a.d2,a.d3,a.d4,b.arm_code,c.arm ,b.d1,b.cnt  \n";
            sql = sql + " from b101_con a  \n";
            sql = sql + " left join b201_stock b on a.code = b.code \n";
            sql = sql + " left join a101_arm c on b.arm_code = c.arm_code  \n";
            sql = sql + w;
            sql = sql + " order by a.d1,a.d2 \n";

            DataSet ds = cls_com.Select_Query(sql);
            헤더0(ds);
            spr0.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt0.Text = ds.Tables[0].Rows.Count.ToString();
            spr0.DataSource = ds;
            if (ds.Tables[0].Rows.Count > 0)
            {

                spr0.Sheets[0].Cells.Get(0, 0, spr0.Sheets[0].RowCount - 1, spr0.Sheets[0].ColumnCount - 1).Locked = true;
                spr0.Sheets[0].Cells.Get(0, 0, spr0.Sheets[0].RowCount - 1, spr0.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr0.Sheets[0].Cells.Get(0, 0, spr0.Sheets[0].RowCount - 1, spr0.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;


            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr0.Sheets[0]);
            lblCnt0.Text = spr0.ActiveSheet.RowCount.ToString();
        }
        private void 헤더0(DataSet ds)
        {
            int i = 0;
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소모품코드";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "제품분류";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "제품명";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "제조사";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "모델명";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소속부대코드";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소속부대";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "사업명";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "수량";
            spr0.ActiveSheet.ColumnHeader.Rows[0].Height = 30;

        }
        private void 조회1()
        {

            String 소속코드 = "", 소속명 = "";
            String 일자;
            String[] a;
            a = cmb소속부대.Text.Split(' ');
            if (a.Length >= 2)
            {
                소속코드 = a[0];
                소속명 = a[1];
            }

            일자 = cls_com.GetDate(dtp.Value);

            sql = "";
            sql = sql + " select a.dt ,a.tm,a.state,a.num1,a.num2,a.arm_code,b.arm,a.arm_code_s,c.arm ,a.code,a.usr,a.chk ,d.d1,d.d2,d.d3,d.d4,a.cnt,a.d1,a.d2,a.d3,a.d4,a.d5,a.d6 ";
            sql = sql + " from b301_output a ";
            sql = sql + " left join a101_arm b on a.arm_code = b.arm_code ";
            sql = sql + " left join a101_arm c on a.arm_code_s = c.arm_code ";
            sql = sql + " left join b101_con d on a.code  = d.code  ";
            sql = sql + " where a.dt = '" + cls_com.GetDate(dtp.Value) + "' ";
            sql = sql + "   and a.arm_code = '" + cls_com.GetCode(txt소속부대.Text) + "'    and a.arm_code_s = '" + cls_com.GetCode(cmb소속부대.Text) + "' ";
            sql = sql + "   and ( a.state = '불출대기'  or a.state = '소모처리' )  ";

            sql = sql + " order by a.dt,a.num1,a.num2 ";

            DataSet ds = cls_com.Select_Query(sql);
            헤더(ds);
            spr.Sheets[0].RowCount = 0;
            txt증빙번호.Text = "" ;
            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt.Text = ds.Tables[0].Rows.Count.ToString();
            spr.DataSource = ds;
            
            if (ds.Tables[0].Rows.Count > 0)
            {
                txt증빙번호.Text = spr.ActiveSheet.Cells[0, 3].Text;
                txt상태.Text = spr.ActiveSheet.Cells[0, 2].Text;

                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left ;
                /*
                for (int i = 0; i < spr.ActiveSheet.Rows.Count; i++)
                {
                    if ( !spr.ActiveSheet.Cells[i, 2].Text.Equals(spr.ActiveSheet.Cells[i, 4].Text))
                    {
                        spr.ActiveSheet.Cells.Get(i, 4, i, 5).BackColor = Color.Pink;
                    }
                }
                */
            } else
            {
                txt상태.Text = "";
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
        }
        private void 헤더(DataSet ds)
        {
            int i = 0; 
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "일자";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "시간";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "상태";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "증빙번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소속부대코드";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소속부대";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "불출부대코드";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "불출부대";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소모품번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "사용자";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "비고";
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

                조회_품목();
            }
        }

        private void 조회_품목()
        {

        }

        private void 저장(string 소모품번호,string 수량,bool 취소여부)
        {
            DataSet ds;
            String 상태="" ;
            String 소속코드="", 입고_소속코드="", 입고_소속명="";
            String 일자, 시간;
            String 상태_저장 = "입고";
            소모품번호 = 소모품번호.ToUpper();
            입고_소속코드 = cls_com.GetCode(cmb소속부대.Text);
            입고_소속명 = cls_com.GetName(cmb소속부대.Text);

            sql = "SELECT * FROM b101_con where code = '" + 소모품번호 + "' ";
            ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("미등록 소모품 번호 입니다.");
                txt수량.Text = "";
                포커스(txt1);
                return;
            }
            소모품번호 = ds.Tables[0].Rows[0]["code"].ToString();
            상태  = ds.Tables[0].Rows[0]["state"].ToString();
            일자 = cls_com.GetDate(dtp.Value);
            시간 = cls_com.GetTime();



            if (취소여부)
            {

                cls_com.gCon = new SqlConnection(cls_com.gConn_String);
                cls_com.gCon.Open();
                SqlTransaction tran;
                tran = cls_com.gCon.BeginTransaction();
                    sql = "";
                    sql = "delete from b301_output where arm_code_s = '" + cls_com.GetCode(cmb소속부대.Text) + "' and  dt = '" + 일자 + "' and code = '" + 소모품번호 + "' and state ='입고' and chk = '' ";
                if (!cls_com.ExcuteNonQueryT(sql, tran).Equals("success"))
                {
                    tran.Rollback();
                    return;
                }
                sql = " UPDATE b201_stock set state = '" + "" + "' where code = '" + 소모품번호 + "' ";
                if (!cls_com.ExcuteNonQueryT(sql, tran).Equals("success"))
                {
                    tran.Rollback();
                    return;
                }
                tran.Commit();
                cls_com.gCon.Close();
                cls_com.로그_소모품(cls_com.사용자.성명, "소모품 입고", "취소", sql);


            }
            else { 
                if (입고_소속코드.Equals("") )
                {
                    MessageBox.Show("입고 할 부대를 선택하세요");
                    포커스(txt수량);
                    return;
                }
                if (소속코드.Equals(입고_소속코드))
                {
                    MessageBox.Show("입고할 부대하고 출고한 부대하고 같습니다.");
                    포커스(txt수량);
                    return;
                }
                if (!상태.Equals(""))
                {
                    MessageBox.Show("상태 : " + 상태 + "   입고 불가");
                    포커스(txt수량);
                    return;
                }
                cls_com.gCon = new SqlConnection(cls_com.gConn_String);
                cls_com.gCon.Open();
                SqlTransaction tran;
                tran = cls_com.gCon.BeginTransaction();
                    sql = "select * from b201_stock where arm_code = '" + 입고_소속코드 + "' and code = '" + 소모품번호 + "' ";
                    ds = cls_com.Select_Query(sql);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        sql = "update b201_stock set cnt = cnt + '" + 수량 + "' where arm_code = '" + 입고_소속코드 + "' and code = '" + 소모품번호 + "' ) ";
                        if (!cls_com.ExcuteNonQueryT(sql, tran).Equals("success"))
                        {
                            tran.Rollback();
                            return;
                        }
                }
                else
                    {
                        sql = "insert into b201_stock (code,dt,state,arm_code,cnt,d1,d2) values ('" + 소모품번호 + "','" + 일자 + "','','" + 입고_소속코드 + "','" + 수량 + "','','') ";
                        if (!cls_com.ExcuteNonQueryT(sql, tran).Equals("success"))
                        {
                            tran.Rollback();
                            return;
                    }
                }
                sql = " ";
                sql = sql + "insert into b301_output (dt,tm,state,arm_code,arm_code_s,code,usr,chk,d1,d2) values ( ";
                sql = sql + "    '" + 일자 + "' ";
                sql = sql + "   ,'" + 시간 + "' ";
                sql = sql + "   ,'" + 상태_저장 + "' ";
                sql = sql + "   ,'" + 소속코드 + "' ";
                sql = sql + "   ,'" + 입고_소속코드 + "' ";
                sql = sql + "   ,'" + 소모품번호 + "' ";
                sql = sql + "   ,'" + cls_com.사용자.성명 + "' ";
                sql = sql + "   ,'" + "" + "' ";
                sql = sql + "   ,'" + txt근거.Text + "' ";
                sql = sql + "   ,'" + txt비고.Text + "' ";
                sql = sql + "   ) ";
                if (!cls_com.ExcuteNonQueryT(sql, tran).Equals("success"))
                {
                    tran.Rollback();
                    return;
                }
                tran.Commit();

                cls_com.gCon.Close();
                cls_com.로그_소모품(cls_com.사용자.성명, "소모품 입고", "입고", sql);
            }
            조회1();
            txt1.Text = "";
            txt1.Focus();
            txt1.SelectAll();
            chk취소.Checked = false;


        }

        private void btn조회_Click(object sender, EventArgs e)
        {

            조회();
        }
        private void 조회()
        {
            조회0();
            조회1();
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
            string title = "소모품 입고";
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

        private void sc_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (r초기화) return;
            cls_com.ConfigSave(this.Name + "_sc_넓이", sc.SplitterDistance.ToString());
        }

        private void txt조회_TextChanged(object sender, EventArgs e)
        {
            조회0();
        }

        private void spr0_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr0.ActiveSheet);
        }

        private void spr0_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row <  0) return;
            txt소속부대.Text = spr0.ActiveSheet.Cells[e.Row, 5].Text + " " + spr0.ActiveSheet.Cells[e.Row, 6].Text ;

            txt1.Text = spr0.ActiveSheet.Cells[e.Row, 0].Text;
            txt2.Text = spr0.ActiveSheet.Cells[e.Row, 2].Text;
            txt사업명.Text = spr0.ActiveSheet.Cells[e.Row, 7].Text;

            조회1();
            포커스(txt수량);

        }

        private void txt수량_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void 포커스(TextBox tb)
        {
            rtb = tb;
            t포커스.Enabled = true;
        }

        private void t포커스_Tick(object sender, EventArgs e)
        {
            t포커스.Enabled = false;
            rtb.Text = "";
            rtb.Focus();
        }

        private void cb재고_CheckedChanged(object sender, EventArgs e)
        {
            조회0();
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

        private void 등록()
        {

            string 증빙번호 = "", 증빙번호_번호 = "";
            string 소속코드 = "",불출코드= "";
            string 구분 = "";
            DataSet ds;
            if (cls_com.GetCode(txt소속부대.Text).Equals(""))
            {

                MessageBox.Show("소속부대를 선택 하세요");
                return;

            }
          
            소속코드 = cls_com.GetCode(txt소속부대.Text);
            불출코드 = cls_com.GetCode(cmb소속부대.Text);
            if (cls_com.Val2(txt수량.Text) <= 0 )
            {
                MessageBox.Show("수량 확인");
                포커스(txt수량);
                return;
            }
            ds = cls_com.Select_Query("select * from b101_con  where code = '" + txt1.Text + "'  ");
            if (ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("미등록 소모품 코드");
                포커스(txt1);
                return;
            }
                
            ds = cls_com.Select_Query("select * from b201_stock  where code = '" + txt1.Text + "' and arm_code = '" + cls_com.GetCode(txt소속부대.Text) + "' and d1 = '" + txt사업명.Text + "' ");
            if (ds.Tables[0].Rows.Count > 0)
            {
                if ( cls_com.Val2(ds.Tables[0].Rows[0]["cnt"].ToString() ) < cls_com.Val2(txt수량.Text) )
                {
                    MessageBox.Show("재고 수량이 부족합니다. 재고수량:" + ds.Tables[0].Rows[0]["cnt"].ToString());
                    return;
                }
                구분 = "소모처리";
                
                증빙번호 = cls_com.증빙번호_소모품_GET(구분,cls_com.GetDate(dtp.Value), 소속코드,불출코드);
                증빙번호_번호 = cls_com.증빙번호_번호_소모품_GET(증빙번호);


                cls_com.gCon = new SqlConnection(cls_com.gConn_String);
                cls_com.gCon.Open();
                SqlTransaction tran;
                tran = cls_com.gCon.BeginTransaction();

                    sql = "UPDATE b201_stock set cnt = cnt - " + cls_com.Val2(txt수량.Text).ToString() + " where  code = '" + txt1.Text + "' and arm_code = '" + cls_com.GetCode(txt소속부대.Text) + "' and d1 = '" + txt사업명.Text + "' ";
                    cls_com.ExcuteNonQueryT(sql,tran);
                    sql = "insert into b301_output(dt,tm,num1,num2,state,arm_code,arm_code_s,code,usr,chk,cnt,d1,d2,d3,d4,d5,d6) values  ('" 
                           +  cls_com.GetDate(dtp.Value) + "','" + cls_com.GetTime() + "','" + 증빙번호 + "','" + 증빙번호_번호 + "','" + 구분 + "','" + 소속코드 +  "','" + 불출코드 + "','" + txt1.Text + "','" 
                           +  cls_com.사용자.성명 + "','','" +  cls_com.Val2(txt수량.Text).ToString() + "','" + txt사업명.Text + "','" + txt예산구분.Text + "','" + txt근거.Text + "','" + txt비고.Text + "','" + txt출납관.Text +"' ,'" + txt반납관.Text + "') " ;
                    cls_com.ExcuteNonQueryT(sql,tran);
                    sql = " update b301_output set d5 = '" + txt출납관.Text + "',d6 ='" + txt반납관.Text + "' where num1 = '" + 증빙번호 + "' ";
                    cls_com.ExcuteNonQueryT(sql, tran);

                cls_com.로그(cls_com.사용자.성명, "소모품 소모처리", 구분, sql);

                tran.Commit();
                cls_com.gCon.Close();

            }
            else
            {
                MessageBox.Show("재고에 없는 소모품입니다.");
            }
            초기화();
            조회();
        }
        private void 수정()
        {
            sql = " ";
            sql = sql + "update b301_output set  ";
            sql = sql + "    d1 = '" + txt근거.Text + "', d2 = '" + txt비고.Text + "'";
            sql = sql + "where num1 = '" + txt증빙번호 .Text + "' and num2 = '" + txt번호.Text + "'  \n ";

            sql = sql + "update b301_output set  ";
            sql = sql + "    d3 = '" + txt출납관.Text + "',d4 = '" + txt반납관.Text + "' ";
            sql = sql + "where num1 = '" + txt증빙번호.Text + "'   \n ";

            cls_com.ExcuteNonQuery(sql);
            cls_com.로그(cls_com.사용자.성명, "소모품 소모처리", "수정", sql);
            조회();

        }
        private void 삭제()
        {

            DataSet ds;
            String 수량 = "0";
            DialogResult dr = MessageBox.Show("제품명:" + txt2.Text + " 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;
            sql = " select  * from b301_output where num1 = '" + txt증빙번호.Text + "' and num2 = '" + txt번호.Text + "' \n ";
            ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                수량 = ds.Tables[0].Rows[0]["cnt"].ToString();
            }



            sql = " ";
            sql = sql + "delete from  b301_output where num1 = '" + txt증빙번호.Text + "' and num2 = '"  +  txt번호.Text + "' \n ";
            sql = sql + "update b301_output set num2 = num2 - 1 where num1 = '" + txt증빙번호.Text + "' and num2 > '" + txt번호.Text + "' \n ";

            
            cls_com.ExcuteNonQuery(sql);

            sql = "SELECT * FROM b201_stock where code = '" + txt1.Text + "' and arm_code = '" + cls_com.GetCode(txt소속부대.Text) + "' and d1 = '" + txt사업명.Text + "'  ";
            ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                sql = "update b201_stock set cnt = cnt + " + 수량 + " where  code = '" + txt1.Text + "' and arm_code = '" + cls_com.GetCode(txt소속부대.Text) + "' and d1 = '" + txt사업명.Text + "' ";
            }
            else
            {
                sql = "insert into  b201_stock  (code,dt,state,arm_code,cnt,d1,d2,d3) values ('" + txt1.Text + "','" + cls_com.GetDate() + "','','" + cls_com.GetCode(txt소속부대.Text) + "','" + 수량 + "','" + txt사업명.Text  +"','','' ) ";
            }
            cls_com.ExcuteNonQuery(sql);

            cls_com.로그(cls_com.사용자.성명, "소모품 소모처리", "삭제", sql);
            조회();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            조회1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            초기화();
        }

        private void spr_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            txt증빙번호.Text = spr.ActiveSheet.Cells[e.Row, 3].Text;
            txt번호.Text = spr.ActiveSheet.Cells[e.Row, 4].Text;
            txt1.Text = spr.ActiveSheet.Cells[e.Row, 9].Text;
            txt2.Text = spr.ActiveSheet.Cells[e.Row, 13].Text;
            txt사업명.Text = spr.ActiveSheet.Cells[e.Row, 17].Text;
            txt예산구분.Text = spr.ActiveSheet.Cells[e.Row, 18].Text;
            txt근거.Text = spr.ActiveSheet.Cells[e.Row, 19].Text;
            txt비고.Text = spr.ActiveSheet.Cells[e.Row, 20].Text;
            txt출납관.Text = spr.ActiveSheet.Cells[e.Row, 21].Text;
            txt반납관.Text = spr.ActiveSheet.Cells[e.Row, 22].Text;


        }

        private void txt근거_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt비고_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt출납관_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void t초기화_Tick(object sender, EventArgs e)
        {
            t초기화.Enabled = false;
            r초기화 = false;
        }

        private void btn출력_거래증_Click(object sender, EventArgs e)
        {

            string 증빙번호 = "", 부대1 = "", 부대2 = "";
            if (spr.ActiveSheet.Rows.Count < 0) return;
            부대1 = txt소속부대.Text;
            부대2 = cmb소속부대.Text;
            증빙번호 = txt증빙번호.Text;
            if (txt상태.Text.Equals("소모처리"))
            {
                frm출력_거래증 frm출력_거래증 = new frm출력_거래증("소모품_소모처리", cls_com.GetDate(dtp.Value), txt상태.Text, 증빙번호, 부대1, 부대2);
                frm출력_거래증.ShowDialog();
            } else
            {
                frm출력_거래증 frm출력_거래증 = new frm출력_거래증("소모품", cls_com.GetDate(dtp.Value), txt상태.Text, 증빙번호, 부대1, 부대2);
                frm출력_거래증.ShowDialog();

            }
        }

        private void txt반납관_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

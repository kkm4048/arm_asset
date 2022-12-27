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
    public partial class frm자산불출_자산불출 : Form
    {
        string sql;
        bool r초기화 = true;
        int r선택수량 = 0;
        public frm자산불출_자산불출()
        {
            InitializeComponent();
        }

        private void frm자산불출_자산불출_Load(object sender, EventArgs e)
        {
            string d;


          
            dtp.Text = cls_com.GetDate();
            Add소속부대();
            초기화();
            txt출납관.Text = cls_com.출납관_반납관(cls_com.사용자.아이디, "");
            txt반납관.Text = "";
            d= cls_com.ConfigLoad(this.Name + "_sc_넓이");
            sc.SplitterDistance = cls_com.Val2(d);
            조회();

        }
        private void 초기화()
        {
            txt1.Text = "";
        }
        private void Add소속부대()
        {
            cmb소속부대.Items.Clear();
            cmb소속부대.Items.Add("" );

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
            txt반납관.Text = cls_com.출납관_반납관("", cls_com.GetCode(cmb소속부대.Text));
            조회1();
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

        private void frm자산불출_자산불출_Activated(object sender, EventArgs e)
        {
            txt1.Focus();
        }
    
        private void 조회0()
        {

            r선택수량 = 0;
            lbl선택수량.Text = r선택수량.ToString();
            FarPoint.Win.Spread.CellType.CheckBoxCellType cc = new FarPoint.Win.Spread.CellType.CheckBoxCellType();
            string w = "";

            if (!cls_com.사용자.등급.Equals("총관리자"))
            {
                w = w + " where a.arm_code in  ( select arm_code from a101_user a left join a101_user_arm b on a.id = b.id where a.id = '" + cls_com.사용자.아이디 + "' )  \n";
            }
            sql = "";
            sql = sql + " select '' sel,a.state,a.code,a.arm_code,b.arm ,a.d1,a.d2 ,a.d3,a.d4,a.d5,a.d6,a.d12,a.d14 \n";
            sql = sql + " from a201_asset a  \n";
            sql = sql + " left join a101_arm b on a.arm_code = b.arm_code  \n";
            sql = sql + w;
            sql = sql + " order by b.arm,a.d3,a.d4,a.d5 \n";

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

                spr0.Sheets[0].Cells.Get(0, 0, spr0.Sheets[0].RowCount - 1, 0).CellType = cc;
                spr0.Sheets[0].Cells.Get(0, 0, spr0.Sheets[0].RowCount - 1, 0).Locked = false ;
                spr0.Sheets[0].Cells.Get(0, 0, spr0.Sheets[0].RowCount - 1, 0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;


            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr0.Sheets[0]);
            lblCnt0.Text = spr0.ActiveSheet.RowCount.ToString();
        }
        private void 헤더0(DataSet ds)
        {
            int i = 0;
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "선택";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "상태";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "자산번호";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소속부대코드";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소속부대";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "관리번호";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "시리얼번호";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "도입년월일";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "자원분류";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "제조사";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "모델명";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "자원상태";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "사업명";
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
            sql = sql + " select a.dt ,a.tm,a.state,a.arm_code,b.arm ,a.arm_code_s, c.arm arm2,a.num1,a.num2,a.code,a.usr,a.chk ,d.d1,d.d2 ,d.d3,d.d4,d.d5,d.d6,d.d12,d.d14";
            sql = sql + " from a301_output a ";
            sql = sql + " left join a101_arm b on a.arm_code = b.arm_code ";
            sql = sql + " left join a101_arm c on a.arm_code_s = c.arm_code ";
            sql = sql + " left join a201_asset d on a.code  = d.code  ";
            sql = sql + " where a.dt = '" + cls_com.GetDate(dtp.Value) + "' ";
            sql = sql + "   and a.arm_code_s = '" + cls_com.GetCode(cmb소속부대.Text) + "' ";
            sql = sql + "   and ( a.state = '불출대기' or a.state = '폐기' )   ";

            sql = sql + " order by a.dt,a.num1,a.num2 ";

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
                /*
                for (int i = 0; i < spr.ActiveSheet.Rows.Count; i++)
                {
                    if ( !spr.ActiveSheet.Cells[i, 2].Text.Equals(spr.ActiveSheet.Cells[i, 4].Text))
                    {
                        spr.ActiveSheet.Cells.Get(i, 4, i, 5).BackColor = Color.Pink;
                    }
                }
                */
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
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소속부대코드";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소속부대";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "불출_소속부대코드";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "불출_소속부대";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "증빙번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "자산번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "사용자";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "비고";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "관리번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "시리얼번호";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "도입년월일";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "자원분류";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "제조사";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "모델명";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "자원상태";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "사업명";
            spr.ActiveSheet.ColumnHeader.Rows[0].Height = 30;

        }
        private void txt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                저장(txt1.Text,chk취소.Checked);
            }
        }

        private void 저장(string 자산번호,bool 취소여부)
        {
            String 상태="",재고여부="" ;
            String 증빙번호 = "", 증빙번호_번호 = "";
            String 소속코드, 소속명,불출_소속코드, 불출_소속명;
            String 일자, 시간;
            String 상태_저장 = "불출대기";
            자산번호 = 자산번호.ToUpper();
            sql = "SELECT a.arm_code,a.code,a.state,b.arm FROM a201_asset a left join a101_arm b on a.arm_code = b.arm_code  where a.code = '" + 자산번호 + "' or d1 = '" + 자산번호 + "' or a.d2 = '" + 자산번호 + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("미등록 번호 입니다.");
                포커스();
                return;
            }
            소속코드 = ds.Tables[0].Rows[0]["arm_code"].ToString();
            소속명 = ds.Tables[0].Rows[0]["arm"].ToString();
            자산번호 = ds.Tables[0].Rows[0]["code"].ToString();
            상태  = ds.Tables[0].Rows[0]["state"].ToString();
            불출_소속코드 = cls_com.GetCode(cmb소속부대.Text);
            불출_소속명 = cls_com.GetName(cmb소속부대.Text);
            일자 = cls_com.GetDate(dtp.Value);
            시간 = cls_com.GetTime();


            재고여부 = cls_com.재고여부(자산번호, cls_com.사용자.아이디);
            if (!재고여부.Equals(""))
            {
                MessageBox.Show(재고여부);
                포커스();
                return;
            }
            if (취소여부)
            {

                cls_com.gCon = new SqlConnection(cls_com.gConn_String);
                cls_com.gCon.Open();
                SqlTransaction tran;
                tran = cls_com.gCon.BeginTransaction();
                sql = "";
                sql = "select * from  a301_output where arm_code_s = '" + cls_com.GetCode(cmb소속부대.Text) + "' and  dt = '" + 일자 + "' and code = '" + 자산번호 + "' and state ='불출대기' and chk = '' ";
                DataSet ds0 = cls_com.Select_Query(sql);
                if (ds0.Tables[0].Rows.Count > 0)
                {
                    sql = "update a301_output set num2 = num2 -1 where num1 = '" + ds0.Tables[0].Rows[0]["num1"].ToString()  + "' and num2 > " +  ds0.Tables[0].Rows[0]["num2"].ToString() + " ";
                    if (!cls_com.ExcuteNonQueryT(sql, tran).Equals("success"))
                    {
                        tran.Rollback();
                        return;
                    }

                }
                sql = "";
                    sql = "delete from a301_output where arm_code_s = '" + cls_com.GetCode(cmb소속부대.Text) + "' and  dt = '" + 일자 + "' and code = '" + 자산번호 + "' and state ='불출대기' and chk = '' ";
                    if (!cls_com.ExcuteNonQueryT(sql, tran).Equals("success"))
                    {
                        tran.Rollback();
                        return;
                    }
                    sql = " UPDATE a201_asset  set state = '" + "" + "' where code = '" + 자산번호 + "' ";
                    if (!cls_com.ExcuteNonQueryT(sql, tran).Equals("success"))
                    {
                        tran.Rollback();
                        return;
                    }
                tran.Commit();
                cls_com.gCon.Close();
                cls_com.로그(cls_com.사용자.성명, "자산 불출", "취소", sql);
                int irow = -1, icol = -1;

                spr0.Search(0, 자산번호, false, false, false, false, 0, 2, ref irow, ref icol);
                if (irow >= 0)
                {
                    spr0.ActiveSheet.Cells[irow, 1].Text = "";
                }

            }
            else { 

                if (불출_소속코드.Equals("") )
                {
                    MessageBox.Show("불출할 부대를 선택하세요");
                    포커스();
                    return;
                }
                if (소속코드.Equals(불출_소속코드))
                {
                    MessageBox.Show("설치된 부대하고 불출할 부대하고 같습니다.");
                    포커스();
                    return;
                }
                if (!상태.Equals(""))
                {
                    MessageBox.Show("상태 : " + 상태 + "   불출 불가");
                    포커스();
                    return;
                }
                증빙번호 = cls_com.증빙번호_자산_GET("불출대기",cls_com.GetDate(dtp.Value),소속코드, 불출_소속코드) ;
                증빙번호_번호 = cls_com.증빙번호_번호_자산_GET(증빙번호);

                sql = " ";
                sql = sql + "insert into a301_output (dt,tm,num1,num2,state,arm_code,arm_code_s,code,usr,chk,d1,d2,d3,d4) values ( ";
                sql = sql + "    '" + 일자 + "' ";
                sql = sql + "   ,'" + 시간 + "' ";
                sql = sql + "   ,'" + 증빙번호 + "' ";
                sql = sql + "   ,'" + 증빙번호_번호 + "' ";
                sql = sql + "   ,'" + 상태_저장 + "' ";
                sql = sql + "   ,'" + 소속코드 + "' ";
                sql = sql + "   ,'" + 불출_소속코드 + "' ";
                sql = sql + "   ,'" + 자산번호 + "' ";
                sql = sql + "   ,'" + cls_com.사용자.성명 + "' ";
                sql = sql + "   ,'" + "" + "' ";
                sql = sql + "   ,'" + "" + "' ";
                sql = sql + "   ,'" + "" + "' ";
                sql = sql + "   ,'" + txt출납관.Text + "' ";
                sql = sql + "   ,'" + txt반납관.Text + "' ";
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
                    sql = " UPDATE a301_output set d3 = '" + txt출납관.Text + "',d4 = '" + txt반납관.Text + "' where num1 = '" + 증빙번호 + "' ";
                    if (!cls_com.ExcuteNonQueryT(sql, tran).Equals("success"))
                    {
                        tran.Rollback();
                        return;
                    }


                    sql = " UPDATE a201_asset set state = '" + "불출대기" + "' where code = '" + 자산번호 + "' ";
                    if (!cls_com.ExcuteNonQueryT(sql, tran).Equals("success"))
                    {
                        tran.Rollback();
                        return;
                    }
                tran.Commit();
                cls_com.gCon.Close();
                cls_com.로그(cls_com.사용자.성명, "자산 불출", "불출대기", sql);
                int irow=-1, icol=-1;

                spr0.Search(0, 자산번호, false, false, false, false, 0, 2,ref irow,ref icol);
                if (irow >= 0 )
                {
                    spr0.ActiveSheet.Cells[irow, 1].Text = "불출대기";
                }

            }
            조회1();
            txt1.Text = "";
            txt1.Focus();
            txt1.SelectAll();
            chk취소.Checked = false;


        }
        private void 폐기(string 자산번호, bool 취소여부)
        {
            String 상태 = "", 재고여부 = "";
            String 증빙번호 = "", 증빙번호_번호 = "";
            String 소속코드, 소속명, 불출_소속코드, 불출_소속명;
            String 일자, 시간;
            String 상태_저장 = "폐기";
            자산번호 = 자산번호.ToUpper();
            sql = "SELECT a.arm_code,a.code,a.state,b.arm FROM a201_asset a left join a101_arm b on a.arm_code = b.arm_code  where a.code = '" + 자산번호 + "' or d1 = '" + 자산번호 + "' or a.d2 = '" + 자산번호 + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("미등록 번호 입니다.");
                포커스();
                return;
            }
            소속코드 = ds.Tables[0].Rows[0]["arm_code"].ToString();
            소속명 = ds.Tables[0].Rows[0]["arm"].ToString();
            자산번호 = ds.Tables[0].Rows[0]["code"].ToString();
            상태 = ds.Tables[0].Rows[0]["state"].ToString();
            불출_소속코드 = cls_com.GetCode(cmb소속부대.Text);
            불출_소속명 = cls_com.GetName(cmb소속부대.Text);
            일자 = cls_com.GetDate(dtp.Value);
            시간 = cls_com.GetTime();


            재고여부 = cls_com.재고여부(자산번호, cls_com.사용자.아이디);
            if (!재고여부.Equals(""))
            {
                MessageBox.Show(재고여부);
                포커스();
                return;
            }
            if (취소여부)
            {

                cls_com.gCon = new SqlConnection(cls_com.gConn_String);
                cls_com.gCon.Open();
                SqlTransaction tran;
                tran = cls_com.gCon.BeginTransaction();
                sql = "";
                sql = "select * from  a301_output where arm_code_s = '" + cls_com.GetCode(cmb소속부대.Text) + "' and  dt = '" + 일자 + "' and code = '" + 자산번호 + "' and state ='폐기' and chk = '' ";
                DataSet ds0 = cls_com.Select_Query(sql);
                if (ds0.Tables[0].Rows.Count > 0)
                {
                    sql = "update a301_output set num2 = num2 -1 where num1 = '" + ds0.Tables[0].Rows[0]["num1"].ToString() + "' and num2 > " + ds0.Tables[0].Rows[0]["num2"].ToString() + " ";
                    if (!cls_com.ExcuteNonQueryT(sql, tran).Equals("success"))
                    {
                        tran.Rollback();
                        return;
                    }

                }
                sql = "";
                sql = "delete from a301_output where arm_code_s = '" + cls_com.GetCode(cmb소속부대.Text) + "' and  dt = '" + 일자 + "' and code = '" + 자산번호 + "' and state ='폐기' and chk = '' ";
                if (!cls_com.ExcuteNonQueryT(sql, tran).Equals("success"))
                {
                    tran.Rollback();
                    return;
                }
                sql = " UPDATE a201_asset  set state = '" + "" + "' where code = '" + 자산번호 + "' ";
                if (!cls_com.ExcuteNonQueryT(sql, tran).Equals("success"))
                {
                    tran.Rollback();
                    return;
                }
                tran.Commit();
                cls_com.gCon.Close();
                cls_com.로그(cls_com.사용자.성명, "자산 폐기", "취소", sql);
                int irow = -1, icol = -1;

                spr0.Search(0, 자산번호, false, false, false, false, 0, 2, ref irow, ref icol);
                if (irow >= 0)
                {
                    spr0.ActiveSheet.Cells[irow, 1].Text = "";
                }

            }
            else
            {

                if (!상태.Equals(""))
                {
                    MessageBox.Show("상태 : " + 상태 + "   폐기 불가");
                    포커스();
                    return;
                }
                증빙번호 = cls_com.증빙번호_자산_GET("불출대기", cls_com.GetDate(dtp.Value), 소속코드, 불출_소속코드);
                증빙번호_번호 = cls_com.증빙번호_번호_자산_GET(증빙번호);

                sql = " ";
                sql = sql + "insert into a301_output (dt,tm,num1,num2,state,arm_code,arm_code_s,code,usr,chk,d1,d2,d3,d4) values ( ";
                sql = sql + "    '" + 일자 + "' ";
                sql = sql + "   ,'" + 시간 + "' ";
                sql = sql + "   ,'" + 증빙번호 + "' ";
                sql = sql + "   ,'" + 증빙번호_번호 + "' ";
                sql = sql + "   ,'" + 상태_저장 + "' ";
                sql = sql + "   ,'" + 소속코드 + "' ";
                sql = sql + "   ,'" + 불출_소속코드 + "' ";
                sql = sql + "   ,'" + 자산번호 + "' ";
                sql = sql + "   ,'" + cls_com.사용자.성명 + "' ";
                sql = sql + "   ,'" + "" + "' ";
                sql = sql + "   ,'" + "" + "' ";
                sql = sql + "   ,'" + "" + "' ";
                sql = sql + "   ,'" + txt출납관.Text + "' ";
                sql = sql + "   ,'" + txt반납관.Text + "' ";
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
                sql = " UPDATE a301_output set d3 = '" + txt출납관.Text + "',d4 = '" + txt반납관.Text + "' where num1 = '" + 증빙번호 + "' ";
                if (!cls_com.ExcuteNonQueryT(sql, tran).Equals("success"))
                {
                    tran.Rollback();
                    return;
                }


                sql = " UPDATE a201_asset set state = '" + "폐기" + "' where code = '" + 자산번호 + "' ";
                if (!cls_com.ExcuteNonQueryT(sql, tran).Equals("success"))
                {
                    tran.Rollback();
                    return;
                }
                tran.Commit();
                cls_com.gCon.Close();
                cls_com.로그(cls_com.사용자.성명, "자산 폐기", "폐기", sql);
                int irow = -1, icol = -1;

                spr0.Search(0, 자산번호, false, false, false, false, 0, 2, ref irow, ref icol);
                if (irow >= 0)
                {
                    spr0.ActiveSheet.Cells[irow, 1].Text = "폐기";
                }

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
            string title = "자산 불출";
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

        private void 포커스()
        {
            txt1.Text = "";
            txt1.Focus();
        }

        private void sc_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (r초기화) return;
            cls_com.ConfigSave(this.Name + "_sc_넓이", sc.SplitterDistance.ToString());
        }

        private void txt조회_TextChanged(object sender, EventArgs e)
        {

        }

        private void spr0_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr0.ActiveSheet);
        }

        private void btn선택불출_Click(object sender, EventArgs e)
        {
            선택불출();
        }

        private void btn선택불출취소_Click(object sender, EventArgs e)
        {
            선택불출취소();
        }

        private void 선택불출()
        {
           if (cmb소속부대.Text.Equals(""))
            {
                MessageBox.Show("소속 부대 선택 하세요");
                return;
            }
            DialogResult dr = MessageBox.Show("선택 불출  " + lbl선택수량.Text + " 건 불출하시겠습니까?", "선택 불출", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;

           for (int i = 0; i < spr0.ActiveSheet.RowCount;i++)
            {
                if (spr0.ActiveSheet.Cells[i,0].Text.Equals("True"))
                {
                    저장(spr0.ActiveSheet.Cells[i, 2].Text,false );
                }

            }
            조회();
        }
        private void 선택불출취소()
        {

            if (cmb소속부대.Text.Equals(""))
            {
                MessageBox.Show("소속 부대 선택 하세요");
                return;
            }

            DialogResult dr = MessageBox.Show("선택 불출 취소  " + lbl선택수량.Text + " 건 불출 취소 하시겠습니까?", "선택 불출 취소", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;

            for (int i = 0; i < spr0.ActiveSheet.RowCount; i++)
            {
                if (spr0.ActiveSheet.Cells[i, 0].Text.Equals("True"))
                {
                    저장(spr0.ActiveSheet.Cells[i, 2].Text,true);
                }

            }
            조회();

        }


        private void spr0_ButtonClicked(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            if (e.Column==0)
            {
                if (spr0.ActiveSheet.Cells[e.Row,e.Column].Text.Equals("True"))
                {
                    r선택수량++;
                } else
                {
                    r선택수량--;
                }
                lbl선택수량.Text = r선택수량.ToString();
            }
        }

        private void lbl선택수량_Click(object sender, EventArgs e)
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
            부대1 = spr.ActiveSheet.Cells[0, 3].Text + " " + spr.ActiveSheet.Cells[0, 4].Text;
            부대2 = spr.ActiveSheet.Cells[0, 5].Text + " " + spr.ActiveSheet.Cells[0, 6].Text; ;
            증빙번호 = spr.ActiveSheet.Cells[0, 7].Text;
            frm출력_거래증 frm출력_거래증 = new frm출력_거래증("자산", cls_com.GetDate(dtp.Value), "불출대기", 증빙번호, 부대1 ,부대2 );
            frm출력_거래증.ShowDialog();

        }

        private void 선택폐기()
        {
            
          
            DialogResult dr = MessageBox.Show("선택 폐기  " + lbl선택수량.Text + " 건 폐기하시겠습니까?", "선택 폐기", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;

            for (int i = 0; i < spr0.ActiveSheet.RowCount; i++)
            {
                if (spr0.ActiveSheet.Cells[i, 0].Text.Equals("True"))
                {
                    폐기(spr0.ActiveSheet.Cells[i, 2].Text, false);
                }

            }
            조회();
        }

        private void btn선택폐기_Click(object sender, EventArgs e)
        {
            선택폐기();
        }

        private void btn선택폐기취소_Click(object sender, EventArgs e)
        {
            선택폐기취소();
        }
        private void 선택폐기취소()
        {



            DialogResult dr = MessageBox.Show("선택 폐기 취소  " + lbl선택수량.Text + " 건 폐기 취소 하시겠습니까?", "선택 폐기 취소", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;

            for (int i = 0; i < spr0.ActiveSheet.RowCount; i++)
            {
                if (spr0.ActiveSheet.Cells[i, 0].Text.Equals("True"))
                {
                    폐기(spr0.ActiveSheet.Cells[i, 2].Text, true);
                }

            }
            조회();

        }

    }
}

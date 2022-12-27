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

namespace arm_asset
{
    public partial class frm출력_거래증 : Form
    {
        string sql;
        string r구분 = "";
        DataSet rds;
        int rGan = 18;
        int rPageAll = 0, rPage = 0;
        public frm출력_거래증()
        {
            InitializeComponent();
        }
        public frm출력_거래증(String 구분,String 일자,String 상태,String 증빙번호,String 부대1,String 부대2)
        {
            DataSet ds;
            sql = "";
            InitializeComponent();
            r구분 = 구분;
            dtp.Text = 일자;
            txt상태.Text = 상태;
            txt증빙번호.Text = 증빙번호;
            txt부대1.Text = 부대1;
            txt부대2.Text = 부대2;

            if (구분.Equals("소모품_입고"))
            {
                sql = "select top 1 * from b301_output where num1 = '" + 증빙번호 + "'  ";
            }
            else if (구분.Equals("소모품_소모처리"))
            {
                sql = "select top 1 * from b301_output where num1 = '" + 증빙번호 + "'  ";
            }
            else if (구분.Equals("소모품"))
            {
                sql = "select top 1 * from b301_output where num1 = '" + 증빙번호 + "'  ";

            }
            else if (구분.Equals("자산"))
            {
                sql = "select top 1 * from a301_output where num1 = '" + 증빙번호 + "' ";

            }
            ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0 )
            {
                dtp.Text = ds.Tables[0].Rows[0]["dt"].ToString();
                txt출납관.Text = ds.Tables[0].Rows[0]["d3"].ToString();
                txt반납관.Text = ds.Tables[0].Rows[0]["d4"].ToString();
            }


        }

        private void frm출력_거래증_Load(object sender, EventArgs e)
        {
            초기화();
            조회();
            조회2();
        }
        private void 초기화()
        {
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

        private void   frm출력_거래증_Activated(object sender, EventArgs e)
        {
            
        }
        private void 조회()
        {

            String 일자;

            일자 = cls_com.GetDate(dtp.Value);
            DataSet ds;
            if (r구분.Equals("소모품_입고"))
            {
                sql = "";
                sql = sql + " select a.dt ,a.tm,a.state,a.num1,a.num2,a.arm_code,b.arm ,a.code,a.cnt,d.d1,d.d2 ,d.d3,d.d4 \n";
                sql = sql + " from b301_output a  \n";
                sql = sql + " left join a101_arm b on a.arm_code = b.arm_code  \n";
                sql = sql + " left join b101_con d on a.code  = d.code   \n";
                sql = sql + " where a.dt = '" + cls_com.GetDate(dtp.Value) + "'  \n";
                sql = sql + "   and a.arm_code = '" + cls_com.GetCode(txt부대1.Text) + "'  \n";
                sql = sql + "   and a.arm_code_s = '" + cls_com.GetCode(txt부대2.Text) + "'  \n";
                sql = sql + "   and a.state = '" + txt상태.Text + "'   \n";
                sql = sql + "   and a.num1 = '" + txt증빙번호.Text + "'   \n";
                sql = sql + " order by a.dt,a.state desc,a.num1,a.num2,a.arm_code_s   \n";
            }
            else if (r구분.Equals("소모품_소모처리"))
            {
                sql = "";
                sql = sql + " select a.dt ,a.tm,a.state,a.num1,a.num2,a.arm_code,b.arm ,a.arm_code_s,c.arm ,a.code ,d.d1,d.d2 ,d.d3,d.d4,a.cnt,a.d1,a.d2,a.d3,a.d4,a.d5,a.d6  \n";
                sql = sql + " from b301_output a  \n";
                sql = sql + " left join a101_arm b on a.arm_code = b.arm_code  \n";
                sql = sql + " left join a101_arm c on a.arm_code_s = c.arm_code  \n";
                sql = sql + " left join b101_con d on a.code  = d.code   \n";
                sql = sql + " where a.dt = '" + cls_com.GetDate(dtp.Value) + "'  \n";
                sql = sql + "   and a.arm_code = '" + cls_com.GetCode(txt부대1.Text) + "'  \n";
                sql = sql + "   and a.arm_code_s = '" + cls_com.GetCode(txt부대2.Text) + "'  \n";
                sql = sql + "   and a.state = '" + txt상태.Text + "'  \n ";
                sql = sql + "   and a.num1 = '" + txt증빙번호.Text + "'   \n";
                sql = sql + " order by a.dt,a.state desc,a.num1,a.num2,a.arm_code_s  \n";

            }
            else if (r구분.Equals("소모품"))
            {
                sql = "";
                sql = sql + " select a.dt ,a.tm,a.state,a.num1,a.num2,a.arm_code,b.arm ,a.arm_code_s,c.arm ,a.code,a.usr,a.cnt ,d.d1,d.d2 ,d.d3,d.d4  \n";
                sql = sql + " from b301_output a  \n";
                sql = sql + " left join a101_arm b on a.arm_code = b.arm_code  \n";
                sql = sql + " left join a101_arm c on a.arm_code_s = c.arm_code  \n";
                sql = sql + " left join b101_con d on a.code  = d.code  \n ";
                sql = sql + " where a.dt = '" + cls_com.GetDate(dtp.Value) + "'  \n";
                sql = sql + "   and a.arm_code = '" + cls_com.GetCode(txt부대1.Text) + "'  \n";
                sql = sql + "   and a.arm_code_s = '" + cls_com.GetCode(txt부대2.Text) + "'  \n";
                sql = sql + "   and a.state = '" + txt상태.Text + "'   \n";
                sql = sql + "   and a.num1 = '" + txt증빙번호.Text + "'   \n";
                sql = sql + " order by a.dt,a.state desc,a.num1,a.num2,a.arm_code_s  \n";
            }
            else if (r구분.Equals("자산"))
            {
                sql = "";
                sql = sql + " select a.dt ,a.tm,a.state,a.num1,a.num2,a.arm_code,b.arm ,a.arm_code_s, c.arm arm2,a.code,a.usr,a.chk ,d.d1,d.d2 ,d.d3,d.d4,d.d5,d.d6,d.d7  \n";
                sql = sql + " from a301_output a  \n";
                sql = sql + " left join a101_arm b on a.arm_code = b.arm_code  \n";
                sql = sql + " left join a101_arm c on a.arm_code_s = c.arm_code  \n";
                sql = sql + " left join a201_asset d on a.code  = d.code  \n ";
                sql = sql + " where a.dt = '" + cls_com.GetDate(dtp.Value) + "'  \n";
                sql = sql + "   and a.arm_code = '" + cls_com.GetCode(txt부대1.Text) + "'  \n";
                sql = sql + "   and a.arm_code_s = '" + cls_com.GetCode(txt부대2.Text) + "'  \n";
                sql = sql + "   and a.state = '" + txt상태.Text + "'  \n ";
                sql = sql + "   and a.num1 = '" + txt증빙번호.Text + "'   \n";
                sql = sql + " order by a.dt,a.state desc,a.num1,a.num2,a.arm_code_s  \n";
            }
            ds = cls_com.Select_Query(sql);
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
            조회2_초기화();
        }
        private void 조회2_초기화()
        {
            int i, j;
            spr2.ActiveSheet.Cells[1, 3].Text = ""; spr2.ActiveSheet.Cells[1, 5].Text = ""; spr2.ActiveSheet.Cells[1, 8].Text = "";
            spr2.ActiveSheet.Cells[2, 3].Text = ""; spr2.ActiveSheet.Cells[2, 5].Text = ""; spr2.ActiveSheet.Cells[2, 8].Text = "";

            for ( i = 0; i < 8; i++)
            {
                for ( j = 0; j < 20;j++)
                {
                    spr2.ActiveSheet.Cells[i + 5, j].Text = "";
                }
            }

            spr2.ActiveSheet.Cells[14, 3].Text = ""; spr2.ActiveSheet.Cells[14, 7].Text = "";
            spr2.ActiveSheet.Cells[15, 3].Text = ""; spr2.ActiveSheet.Cells[15, 7].Text = "";

        }
        private void 조회2()
        {

            String 일자;
            String 근거 = "", 구분 = "";
            int i, j;
            일자 = cls_com.GetDate(dtp.Value);

            if (r구분.Equals("소모품_입고"))
            {
                sql = "";
                sql = sql + " select  a.dt ,a.tm,a.state,a.num1,a.num2,a.arm_code,b.arm ,a.code,a.usr,a.chk ,a.cnt,d.d1,d.d2 ,d.d3 ,d.d4 \n";
                sql = sql + " from b301_output a  \n";
                sql = sql + " left join a101_arm b on a.arm_code = b.arm_code  \n";
                sql = sql + " left join b101_con d on a.code  = d.code   \n";
                sql = sql + " where  a.arm_code = '" + cls_com.GetCode(txt부대1.Text) + "'  \n";
                sql = sql + "   and a.state = '" + txt상태.Text + "'   \n";
                sql = sql + "   and a.num1 = '" + txt증빙번호.Text + "'   \n";
                sql = sql + " order by a.dt,a.state desc,a.num1,a.num2,a.arm_code  \n";
            }
            else if (r구분.Equals("소모품_소모처리"))
            {
                sql = "";
                sql = sql + " select  a.dt ,a.tm,a.state,a.num1,a.num2,a.arm_code,b.arm,a.arm_code_s,c.arm arm2 ,a.code,a.usr,a.chk ,a.cnt,d.d1,d.d2 ,d.d3,d.d4  \n";
                sql = sql + " from b301_output a  \n";
                sql = sql + " left join a101_arm b on a.arm_code = b.arm_code  \n";
                sql = sql + " left join a101_arm c on a.arm_code_s = c.arm_code  \n";
                sql = sql + " left join b101_con d on a.code  = d.code   \n";
                sql = sql + " where  a.arm_code = '" + cls_com.GetCode(txt부대1.Text) + "'  \n";
                sql = sql + "   and a.arm_code_s = '" + cls_com.GetCode(txt부대2.Text) + "'  \n";
                sql = sql + "   and a.state = '" + txt상태.Text + "'   \n";
                sql = sql + "   and a.num1 = '" + txt증빙번호.Text + "'   \n";
                sql = sql + " order by a.dt,a.state desc,a.num1,a.num2,a.arm_code  \n";
            }
            else if (r구분.Equals("소모품"))
            {
                sql = "";
                sql = sql + " select  a.dt ,a.tm,a.state,a.num1,a.num2,a.arm_code,b.arm,a.arm_code_s,c.arm arm2 ,a.code,a.usr ,a.cnt,d.d1,d.d2 ,d.d3,d.d4  \n";
                sql = sql + " from b301_output a  \n";
                sql = sql + " left join a101_arm b on a.arm_code = b.arm_code  \n";
                sql = sql + " left join a101_arm c on a.arm_code_s = c.arm_code  \n";
                sql = sql + " left join b101_con d on a.code  = d.code   \n";
                sql = sql + " where  a.arm_code = '" + cls_com.GetCode(txt부대1.Text) + "'  \n";
                sql = sql + "   and a.arm_code_s = '" + cls_com.GetCode(txt부대2.Text) + "'  \n";
                sql = sql + "   and a.state = '" + txt상태.Text + "'   \n";
                sql = sql + "   and a.num1 = '" + txt증빙번호.Text + "'   \n";
                sql = sql + " order by a.dt,a.state desc,a.num1,a.num2,a.arm_code  \n";
            }
            else if (r구분.Equals("자산"))
            {
                sql = "";
                sql = sql + " select  a.dt ,a.tm,a.state,a.num1,a.num2,a.arm_code,b.arm ,a.arm_code_s, c.arm arm2,a.code,a.usr,a.chk ,d.d1,d.d2 ,d.d3,d.d4,d.d5,d.d6,d.d7  \n";
                sql = sql + " from a301_output a  \n";
                sql = sql + " left join a101_arm b on a.arm_code = b.arm_code  \n";
                sql = sql + " left join a101_arm c on a.arm_code_s = c.arm_code  \n";
                sql = sql + " left join a201_asset d on a.code  = d.code   \n";
                sql = sql + " where  a.arm_code = '" + cls_com.GetCode(txt부대1.Text) + "'  \n";
                sql = sql + "   and a.arm_code_s = '" + cls_com.GetCode(txt부대2.Text) + "'  \n";
                sql = sql + "   and a.state = '" + txt상태.Text + "'   \n";
                sql = sql + "   and a.num1 = '" + txt증빙번호.Text + "'   \n";
                sql = sql + " order by a.dt,a.state desc,a.num1,a.num2,a.arm_code_s  \n";
            }
            DataSet ds = cls_com.Select_Query(sql);
            rds = cls_com.Select_Query(sql);
            rPageAll = (rds.Tables[0].Rows.Count - 1) / 8 + 1;
            rPage = 1;
            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt2.Text = ds.Tables[0].Rows.Count.ToString();

            if (r구분.Equals("소모품_입고"))
            {
                spr2.ActiveSheet.Cells[0, 1].Text = "거래증 (입고)";
                spr2.ActiveSheet.Cells[0 + rGan, 1].Text = "거래증 (입고)";
            }
            else if (r구분.Equals("소모품_소모처리"))
            {
                if (txt상태.Text.Equals("소모처리"))
                {
                    spr2.ActiveSheet.Cells[0, 1].Text = "거래증 (소모처리)";
                    spr2.ActiveSheet.Cells[0+rGan,1].Text = "거래증 (소모처리)";
                }
                else
                {
                    spr2.ActiveSheet.Cells[0, 1].Text = "거래증 (불출)";
                }
            } 
            else if (r구분.Equals("소모품"))
            {
                if (txt상태.Text.Equals("수령"))
                {
                    spr2.ActiveSheet.Cells[0, 1].Text = "거래증 (수령)";
                    spr2.ActiveSheet.Cells[0 + rGan, 1].Text = "거래증 (수령)";
                } else if (txt상태.Text.Equals("입고"))
                { 
                        spr2.ActiveSheet.Cells[0, 1].Text = "거래증 (입고)";
                        spr2.ActiveSheet.Cells[0 + rGan, 1].Text = "거래증 (입고)";
                }
                    else
                {
                    spr2.ActiveSheet.Cells[0, 1].Text = "거래증 (불출)";
                    spr2.ActiveSheet.Cells[0 + rGan, 1].Text = "거래증 (불출)";
                }
            }
            else if (r구분.Equals("자산"))
            {
                if (txt상태.Text.Equals("수령"))
                {
                    spr2.ActiveSheet.Cells[0, 1].Text = "거래증 (수령)";
                    spr2.ActiveSheet.Cells[0 + rGan, 1].Text = "거래증 (수령)";
                }
                else if (txt상태.Text.Equals("불출대기"))
                {
                    spr2.ActiveSheet.Cells[0, 1].Text = "거래증 (불출) ";
                    spr2.ActiveSheet.Cells[0 + rGan, 1].Text = "거래증 (불출)";

                }
                else
                {
                    spr2.ActiveSheet.Cells[0, 1].Text = "거래증 (" + txt상태.Text + ") ";
                    spr2.ActiveSheet.Cells[0 + rGan, 1].Text = "거래증 (" + txt상태.Text  + ")";
                }
            }
            
            if (ds.Tables[0].Rows.Count > 0)
            {
                spr2.ActiveSheet.Cells[1, 3].Text = ds.Tables[0].Rows[0]["arm"].ToString(); spr2.ActiveSheet.Cells[1 + rGan, 3].Text = ds.Tables[0].Rows[0]["arm"].ToString();
                if (!r구분.Equals("소모품_입고")) { 
                    spr2.ActiveSheet.Cells[1, 5].Text = ds.Tables[0].Rows[0]["arm2"].ToString(); spr2.ActiveSheet.Cells[1 + rGan, 5].Text = ds.Tables[0].Rows[0]["arm2"].ToString();
                }
                spr2.ActiveSheet.Cells[1, 8].Text = 근거; spr2.ActiveSheet.Cells[1 + rGan, 8].Text = 근거;
                spr2.ActiveSheet.Cells[2, 8].Text = 구분; spr2.ActiveSheet.Cells[2 + rGan, 8].Text = 구분;

                spr2.ActiveSheet.Cells[2, 3].Text = ds.Tables[0].Rows[0]["num1"].ToString(); spr2.ActiveSheet.Cells[2 + rGan, 3].Text = ds.Tables[0].Rows[0]["num1"].ToString();

                일자 = ds.Tables[0].Rows[0]["dt"].ToString() ;
                spr2.ActiveSheet.Cells[14, 3].Text = cls_com.GetDate2(일자); spr2.ActiveSheet.Cells[14+ rGan, 3].Text = cls_com.GetDate2(일자);
                spr2.ActiveSheet.Cells[14, 7].Text = cls_com.GetDate2(일자); spr2.ActiveSheet.Cells[14+ rGan, 7].Text = cls_com.GetDate2(일자);
                spr2.ActiveSheet.Cells[15, 3].Text = txt출납관.Text + "  (인)"; spr2.ActiveSheet.Cells[15+ rGan, 3].Text = txt출납관.Text + "  (인)";
                spr2.ActiveSheet.Cells[15, 7].Text = txt반납관.Text + "  (인)"; spr2.ActiveSheet.Cells[15+ rGan, 7].Text = txt반납관.Text + "  (인)";



                spr2.ActiveSheet.Cells[16, 1].Text = rPage.ToString() + " / " + rPageAll.ToString() ; spr2.ActiveSheet.Cells[16 + rGan, 7].Text = rPage.ToString() + " / " + rPageAll.ToString();
                if (ds.Tables[0].Rows.Count > 8)
                {
                    j = 8;
                } else
                {
                    j = ds.Tables[0].Rows.Count; 
                }
                for (i = 0; i < j; i++)
                {

                        
                    if (r구분.Equals("소모품_입고"))
                    {
                        spr2.ActiveSheet.Cells[i + 5, 1].Text = ds.Tables[0].Rows[i]["num2"].ToString(); spr2.ActiveSheet.Cells[i + 5 + rGan, 1].Text = ds.Tables[0].Rows[i]["num2"].ToString();
                        spr2.ActiveSheet.Cells[i + 5, 2].Text = ds.Tables[0].Rows[i]["d1"].ToString(); spr2.ActiveSheet.Cells[i + 5 + rGan, 2].Text = ds.Tables[0].Rows[i]["d1"].ToString();
                        //                        spr2.ActiveSheet.Cells[i + 5, 3].Text = ds.Tables[0].Rows[i]["d2"].ToString(); spr2.ActiveSheet.Cells[i + 5 + rGan, 3].Text = ds.Tables[0].Rows[i]["d2"].ToString();
                        spr2.ActiveSheet.Cells[i + 5, 7].Text = ds.Tables[0].Rows[i]["cnt"].ToString(); spr2.ActiveSheet.Cells[i + 5 + rGan, 7].Text = ds.Tables[0].Rows[i]["cnt"].ToString();
                    }
                    else if (r구분.Equals("소모품_소모처리"))
                    {
                        spr2.ActiveSheet.Cells[i + 5, 1].Text = ds.Tables[0].Rows[i]["num2"].ToString(); spr2.ActiveSheet.Cells[i + 5 + rGan, 1].Text = ds.Tables[0].Rows[i]["num2"].ToString();
                        spr2.ActiveSheet.Cells[i + 5, 2].Text = ds.Tables[0].Rows[i]["d1"].ToString(); spr2.ActiveSheet.Cells[i + 5 + rGan, 2].Text = ds.Tables[0].Rows[i]["d1"].ToString();
                        spr2.ActiveSheet.Cells[i + 5, 3].Text = ds.Tables[0].Rows[i]["d2"].ToString(); spr2.ActiveSheet.Cells[i + 5 + rGan, 3].Text = ds.Tables[0].Rows[i]["d2"].ToString();
                        spr2.ActiveSheet.Cells[i + 5, 7].Text = ds.Tables[0].Rows[i]["cnt"].ToString(); spr2.ActiveSheet.Cells[i + 5 + rGan, 7].Text = ds.Tables[0].Rows[i]["cnt"].ToString();
                    }
                    else  if (r구분.Equals("소모품"))
                    {
                        spr2.ActiveSheet.Cells[i + 5, 1].Text = ds.Tables[0].Rows[i]["num2"].ToString(); spr2.ActiveSheet.Cells[i + 5 + rGan, 1].Text = ds.Tables[0].Rows[i]["num2"].ToString();
                        spr2.ActiveSheet.Cells[i + 5, 2].Text = ds.Tables[0].Rows[i]["d1"].ToString(); spr2.ActiveSheet.Cells[i + 5 + rGan, 2].Text = ds.Tables[0].Rows[i]["d1"].ToString();
                        spr2.ActiveSheet.Cells[i + 5, 3].Text = ds.Tables[0].Rows[i]["d2"].ToString(); spr2.ActiveSheet.Cells[i + 5 + rGan, 3].Text = ds.Tables[0].Rows[i]["d2"].ToString();
                        spr2.ActiveSheet.Cells[i + 5, 7].Text = ds.Tables[0].Rows[i]["cnt"].ToString(); spr2.ActiveSheet.Cells[i + 5 + rGan, 7].Text = ds.Tables[0].Rows[i]["cnt"].ToString();
                    }
                    else if (r구분.Equals("자산"))
                    {
                        spr2.ActiveSheet.Cells[i + 5, 1].Text = ds.Tables[0].Rows[i]["num2"].ToString(); spr2.ActiveSheet.Cells[i + 5 + rGan, 1].Text = ds.Tables[0].Rows[i]["num2"].ToString();
                        spr2.ActiveSheet.Cells[i + 5, 2].Text = ds.Tables[0].Rows[i]["d4"].ToString(); spr2.ActiveSheet.Cells[i + 5 + rGan, 2].Text = ds.Tables[0].Rows[i]["d4"].ToString();
                        spr2.ActiveSheet.Cells[i + 5, 3].Text = ds.Tables[0].Rows[i]["d2"].ToString(); spr2.ActiveSheet.Cells[i + 5 + rGan, 3].Text = ds.Tables[0].Rows[i]["d2"].ToString();
                        spr2.ActiveSheet.Cells[i + 5, 7].Text = "1"; spr2.ActiveSheet.Cells[i + 5 + rGan, 7].Text = "1";

                    }
                    
                }
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr2.Sheets[0]);
            spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).BackColor = Color.White ;

            //      spr3.ActiveSheet  = spr2.ActiveSheet.Clone();

            
        }

        private void 헤더(DataSet ds)
        {
            int i = 0;
            if (r구분.Equals("소모품_입고"))
            {
                spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "일자";
                spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "시간";
                spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "상태";
                spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "증빙번호";
                spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "번호";
                spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소속부대코드";
                spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소속부대";
                spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소모품번호";
                spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "수량";
                spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소모품분류";
                spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "제품명";
                spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "제조사";
                spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "모델명";
                spr.ActiveSheet.ColumnHeader.Rows[0].Height = 30;
            } else if (r구분.Equals("소모품"))
             {
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
                    spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "수량";
                    spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소모품분류";
                    spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "제품명";
                    spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "제조사";
                    spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "모델명";
                    spr.ActiveSheet.ColumnHeader.Rows[0].Height = 30;
            }
            else if (r구분.Equals("소모품_소모처리"))
            {
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
                spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소모분류";
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
            else if (r구분.Equals("자산")) {
                spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "일자";
                spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "시간";
                spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "상태";
                spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "증빙번호";
                spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "번호";
                spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소속부대코드";
                spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소속부대";
                spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "불출_소속부대코드";
                spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "불출_소속부대";
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
                spr.ActiveSheet.ColumnHeader.Rows[0].Height = 30;
            }
        }

       

        private void btn조회_Click(object sender, EventArgs e)
        {
            조회();
            조회2();
        }

        private void btn초기화_Click(object sender, EventArgs e)
        {
            초기화();
        }

        private void spr_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr.ActiveSheet);
         }
      

        private void btn출력_Click(object sender, EventArgs e)
        {
            출력();
        }
        private void 출력()
        {
            string title = "자산 불출입 조회";
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
                    pi.Header = "/n/c/fu1/fn\"굴림체\"/fz\"22\"" + title + "/n/fz\"10\" /l" + "/n/fz\"10\" /l" + txt부대2.Text + "/r" + d1 + "/n/r  " + "페이지:  " + "/p / /pc          ";

                    pi.Footer = "";
                    pi.ShowGrid = true;//셀
                    pi.ShowBorder = true;//셀
                    pi.ShowRowHeaders = true ;  // RowHeaders 안보이게 한다.
                    pi.ShowColumnHeaders = true;//해드
                    pi.Centering = FarPoint.Win.Spread.Centering.Horizontal;
                    pi.Orientation = FarPoint.Win.Spread.PrintOrientation.Landscape;


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

        private void cmb상태_SelectedIndexChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtp1_CloseUp(object sender, EventArgs e)
        {
            조회();
        }

        private void dtp2_CloseUp(object sender, EventArgs e)
        {
            조회();
        }

        private void btn조회2_Click(object sender, EventArgs e)
        {
            조회2();
        }

        private void spr_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
        }

        private void spr2_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr2.ActiveSheet);
        }

        private void btn출력_거래증_Click(object sender, EventArgs e)
        {
            출력_거래증(0);

        }

        private void 출력_거래증(int irow )
        {

            string d1;
            int i;
            this.Cursor = Cursors.WaitCursor;
            
            d1 = String.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);

            if (spr.Sheets[0].RowCount != 0)
            {
                try
                {
                  //  출력_데이타(irow);


                    FarPoint.Win.Spread.PrintInfo pi = new FarPoint.Win.Spread.PrintInfo();
                    FarPoint.Win.Spread.SmartPrintRulesCollection prules = new FarPoint.Win.Spread.SmartPrintRulesCollection();
                    pi.ShowPrintDialog = true;
                    pi.Margin.Top = 55;
                    pi.Margin.Bottom = 50;
                    //pi.Header = "/n/n" + "/fn""굴림체""/fz""20""/fb1/fu1/c출고내역(" & lblTitle.Caption & ")"   ;
                    pi.Header = "";

                    pi.Footer = "";
                    pi.ShowGrid = false;//셀
                    pi.ShowBorder = false;//셀
                    pi.ShowRowHeaders = false;  // RowHeaders 안보이게 한다.
                    pi.ShowColumnHeaders = false;//해드
                    pi.Centering = FarPoint.Win.Spread.Centering.Horizontal;
                    pi.Orientation = FarPoint.Win.Spread.PrintOrientation.Portrait;


                    pi.Preview = false;//미리보기 선언/ 아니면 바로인쇄
                    pi.ShowPrintDialog = false;


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

                    pi.PrintType = FarPoint.Win.Spread.PrintType.All;

                    spr2.Sheets[0].PrintInfo = pi;
                    rPage = 1;
                    for (i = 0; i < rds.Tables[0].Rows.Count; i = i + 8)
                    {
                        출력_데이타(i);

                        spr2.PrintSheet(0);
                        Application.DoEvents();
                        rPage++;
                    }
                 

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

        private void txt출납관_TextChanged(object sender, EventArgs e)
        {
            저장_출납관();
            조회2();
        }

        private void txt반납관_TextChanged(object sender, EventArgs e)
        {
            저장_출납관();
            조회2();
        }
        private void 저장_출납관()
        {
            if ( r구분.Equals("소모품_입고"))
            {
                sql = "update b301_output set d3 = '" + txt출납관.Text + "',d4 = '" + txt반납관.Text + "' where num1 = '" + txt증빙번호.Text + "' ";
            } else if (r구분.Equals("자산") ){
                sql = "update a301_output set d3 = '" + txt출납관.Text + "',d4 = '" + txt반납관.Text + "' where num1 = '" + txt증빙번호.Text + "' ";
            }
            cls_com.ExcuteNonQuery(sql);
        }

        private void 출력_데이타(int  j)
        {
            int i = 0;
            int k = 0;

            for (i = 0; i < 8; i++)
            {
                spr2.ActiveSheet.Cells[k + 5, 1].Text = ""; spr2.ActiveSheet.Cells[k + 5 + rGan, 1].Text = "";
                spr2.ActiveSheet.Cells[k + 5, 2].Text = ""; spr2.ActiveSheet.Cells[k + 5 + rGan, 2].Text = "";
                spr2.ActiveSheet.Cells[k + 5, 3].Text = ""; spr2.ActiveSheet.Cells[k + 5 + rGan, 3].Text = "";
                spr2.ActiveSheet.Cells[k + 5, 7].Text = ""; spr2.ActiveSheet.Cells[i + 5 + rGan, 7].Text = "";
                k++;
            }

            k = 0;
            try
            {
                for ( i = 0; i <  8; i++)
                {

                    spr2.ActiveSheet.Cells[k + 5, 1].Text = rds.Tables[0].Rows[j + i]["rownum"].ToString(); spr2.ActiveSheet.Cells[k + 5 + rGan, 1].Text = rds.Tables[0].Rows[j + i]["rownum"].ToString();
                    spr2.ActiveSheet.Cells[k + 5, 2].Text = rds.Tables[0].Rows[j+i]["d3"].ToString(); spr2.ActiveSheet.Cells[k + 5 + rGan, 2].Text = rds.Tables[0].Rows[j+i]["d3"].ToString();
                    spr2.ActiveSheet.Cells[k + 5, 3].Text = rds.Tables[0].Rows[j+i]["d12"].ToString(); spr2.ActiveSheet.Cells[k + 5 + rGan, 3].Text = rds.Tables[0].Rows[j+i]["d12"].ToString();
                    spr2.ActiveSheet.Cells[k + 5, 7].Text = "1"; spr2.ActiveSheet.Cells[k + 5 + rGan, 7].Text = "1";
                    k++;

                }
                spr2.ActiveSheet.Cells[16, 1].Text =  rPage.ToString() + " / " + rPageAll.ToString(); spr2.ActiveSheet.Cells[16 + rGan, 1].Text =  rPage.ToString() + " / " + rPageAll.ToString();

            }
            catch
            {
                spr2.ActiveSheet.Cells[16, 1].Text =  rPage.ToString() + " / " + rPageAll.ToString(); spr2.ActiveSheet.Cells[16 + rGan, 1].Text =  rPage.ToString() + " / " + rPageAll.ToString();

            }
        }

      
    }
}

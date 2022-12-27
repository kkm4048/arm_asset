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
    public partial class frm자산불출_자산불출입조회 : Form
    {
        string sql;
        bool r초기화 = false;
        public frm자산불출_자산불출입조회()
        {
            InitializeComponent();
        }

        private void frm자산불출_자산불출입조회_Load(object sender, EventArgs e)
        {
            string d;
            초기화();
            d = cls_com.ConfigLoad(this.Name + "_sc_넓이");
            splitContainer1.SplitterDistance = cls_com.Val2(d);

            조회0();
            조회();
        }
        private void 초기화()
        {
            dtp1.Text  = cls_com.GetDate();
            dtp2.Text = cls_com.GetDate();

            Add소속부대();
            Add상태();
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
        private void Add상태()
        {
            cmb상태.Items.Clear();
            cmb상태.Items.Add("" );
            cmb상태.Items.Add("불출대기");
            cmb상태.Items.Add("수령대기");
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

        private void frm자산불출_자산불출입조회_Activated(object sender, EventArgs e)
        {
            txt1.Focus();
        }
        private void 조회0()
        {

            String 소속코드 = "", 소속명 = "";
            String 일자;
            String w = "";
            String[] a;
            a = cmb소속부대.Text.Split(' ');
            if (a.Length >= 2)
            {
                소속코드 = a[0];
                소속명 = a[1];
            }

            일자 = cls_com.GetDate(dtp1.Value);

            if (!cls_com.사용자.등급.Equals("총관리자"))
            {
                w = w + " and  ( a.arm_code_s in ( select b.arm_code  from a101_user a left join a101_user_arm b on a.id = b.id  where a.id = '" + cls_com.사용자.아이디 + "' ) \n ";
                w = w + "    or  a.arm_code in ( select b.arm_code  from a101_user a left join a101_user_arm b on a.id = b.id  where a.id = '" + cls_com.사용자.아이디 + "' ) ) \n ";
            }
            else
            {


            }


            sql = "";
            sql = sql + " select a.dt ,a.state,a.num1,a.arm_code,b.arm ,a.arm_code_s, c.arm arm2,count(*) cnt  \n";
            sql = sql + " from a301_output a   \n";
            sql = sql + " left join a101_arm b on a.arm_code = b.arm_code   \n";
            sql = sql + " left join a101_arm c on a.arm_code_s = c.arm_code   \n";
            sql = sql + " where a.dt >= '" + cls_com.GetDate(dtp1.Value) + "' AND a.dt <= '" + cls_com.GetDate(dtp2.Value) + "'   \n";
            if (!cmb소속부대.Text.Equals(""))
            {
                sql = sql + "   and a.arm_code_s = '" + cls_com.GetCode(cmb소속부대.Text) + "'   \n";
            }
            if (!cmb상태.Text.Equals(""))
            {
                sql = sql + "   and a.state = '" + cmb상태.Text + "'   \n ";
            }
            if (!txt조회.Text.Equals(""))
            {
                sql = sql + "   and ( a.num1 like '%" + txt조회.Text + "%'   \n ";
                sql = sql + "      or c.arm like '%" + txt조회.Text + "%'   \n ";
                sql = sql + "   )    \n ";
            }
            sql = sql + w;
            sql = sql + " group by  a.dt ,a.num1,a.state,a.arm_code,b.arm ,a.arm_code_s, c.arm  \n";

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
            lblCnt0.Text = spr.ActiveSheet.RowCount.ToString();
        }
        private void 헤더0(DataSet ds)
        {
            int i = 0;
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "일자";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "상태";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "증빙번호";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소속부대코드";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "소속부대";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "불출_소속부대코드";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "불출_소속부대";
            spr0.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "수량";
            spr0.ActiveSheet.ColumnHeader.Rows[0].Height = 30;

        }

        private void 조회()
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

            일자 = cls_com.GetDate(dtp1.Value);

            sql = "";
            sql = sql + " select a.dt ,a.tm,a.state,a.num1,a.num2,a.arm_code,b.arm ,a.arm_code_s, c.arm arm2,a.code,a.usr,a.chk ,d.d1,d.d2 ,d.d3,d.d4,d.d5,d.d6,d.d12    \n";
            sql = sql + " from a301_output a   \n";
            sql = sql + " left join a101_arm b on a.arm_code = b.arm_code   \n";
            sql = sql + " left join a101_arm c on a.arm_code_s = c.arm_code   \n";
            sql = sql + " left join a201_asset d on a.code  = d.code    \n";
            sql = sql + " where a.dt = '" + cls_com.GetDate(dtp.Value) + "'  ";
            sql = sql + "   and a.arm_code = '" + cls_com.GetCode(txt부대1.Text) + "'   \n";
            sql = sql + "   and a.arm_code_s = '" + cls_com.GetCode(txt부대2.Text) + "'   \n";
            sql = sql + "   and a.state = '" + txt상태.Text + "'    \n";
            sql = sql + "   and a.num1 = '" + txt증빙번호.Text + "'    \n";
            sql = sql + " order by a.dt,a.state desc,a.num1,a.num2,a.arm_code_s   \n";

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
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "설치장소";
            spr.ActiveSheet.ColumnHeader.Rows[0].Height = 30;

        }

       

        private void btn조회_Click(object sender, EventArgs e)
        {
            조회00();
        }
        private void 조회00()
        {
            조회0();
            txt부대1.Text = "";
            txt부대2.Text = "";
            txt상태.Text = "";
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

                    spr0.Sheets[0].PrintInfo = pi;

                    spr0.PrintSheet(0);

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
            조회00();
        }

        private void dtp1_CloseUp(object sender, EventArgs e)
        {
            조회();
        }

        private void dtp2_CloseUp(object sender, EventArgs e)
        {
            조회();
        }

        private void btn출력_거래증_Click(object sender, EventArgs e)
        {

            frm출력_거래증 frm출력_거래증 = new frm출력_거래증("자산",cls_com.GetDate(dtp.Value),txt상태.Text,txt증빙번호.Text,txt부대1.Text,txt부대2.Text);
            frm출력_거래증.ShowDialog();

        }

        private void txt부대2_TextChanged(object sender, EventArgs e)
        {

        }

        private void spr0_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            dtp.Text = spr0.ActiveSheet.Cells[e.Row, 0].Text;
            txt상태.Text = spr0.ActiveSheet.Cells[e.Row, 1].Text;
            txt증빙번호.Text = spr0.ActiveSheet.Cells[e.Row, 2].Text;
            txt부대1.Text = spr0.ActiveSheet.Cells[e.Row, 3].Text + " " + spr0.ActiveSheet.Cells[e.Row, 4].Text ;
            txt부대2.Text = spr0.ActiveSheet.Cells[e.Row, 5].Text + " " + spr0.ActiveSheet.Cells[e.Row, 6].Text; ;
            조회();

        }

        private void spr0_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr0.ActiveSheet);
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

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {
            조회00();

        }

        private void spr_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (r초기화) return;
            cls_com.ConfigSave(this.Name + "_sc_넓이", splitContainer1.SplitterDistance.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            saveFileDialog.FilterIndex = 1;     // FilterIndex는 1부터 시작 (여기서는 *.txt)
            saveFileDialog.FileName = "자산불출수령_" + cls_com.GetDate();
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
    }
}

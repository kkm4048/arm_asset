using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steema.TeeChart;
using Steema.TeeChart.Styles;

namespace arm_asset
{
    public partial class frm자산조회_통계_자원분류별 : Form
    {
        bool r초기화 = true;
        TChart rChart = new TChart();
        string sql = "";
        public frm자산조회_통계_자원분류별()
        {
            InitializeComponent();
        }

        private void btn조회_Click(object sender, EventArgs e)
        {
            조회();
            조회2();
        }
        private void 조회()
        {

            sql = "";
            sql = sql + " select a.d4,count(*) cnt ";
            sql = sql + " from a201_asset  a ";
            sql = sql + " group by a.d4  ";
            sql = sql + " order by a.d4 ";

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
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
        }
        private void 헤더(DataSet ds)
        {
            int i = 0;
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "자원분류";
            spr.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "수량";
            spr.ActiveSheet.ColumnHeader.Rows[0].Height = 30;

        }
        private void frm자산조회_통계_자원분류별_Load(object sender, EventArgs e)
        {
            string d;
            try
            {
                d = cls_com.ConfigLoad(this.Name + "_sc_넓이");
                sc.SplitterDistance = cls_com.Val2("400");

                d = cls_com.ConfigLoad(this.Name + "_sc2_넓이");
                sc2.SplitterDistance = cls_com.Val2("200");
            } catch
            {

            }

            조회();
            조회2();
        }

        private void spr_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            txt자원분류.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
            조회2();
            조회3();
        }
        private void 조회3()
        {

            Steema.TeeChart.Styles.Line   bar1 = new Steema.TeeChart.Styles.Line();
            Steema.TeeChart.Styles.Bar bar2 = new Steema.TeeChart.Styles.Bar();


            bar1.Title = txt자원분류.Text;
            
            

            for (int i = 0; i < spr2.ActiveSheet.RowCount; i++) {
                bar1.Add(cls_com.Val2(spr2.ActiveSheet.Cells[i, 1].Text), spr2.ActiveSheet.Cells[i, 0].Text);
                bar2.Add(cls_com.Val2(spr2.ActiveSheet.Cells[i, 1].Text), spr2.ActiveSheet.Cells[i, 1].Text);
            }
            rChart.Series.Clear();
            for (int i = 0; i < rChart.Series.Count; i ++)
             {
            //    rChart.Series[i].DataSource = null;
             }


            rChart.Text = txt자원분류.Text;
            rChart.Series.Add(bar1);
      //      rChart.Series.Add(bar2);
            rChart.Series[0].Marks.Visible = true;

            rChart.Dock = DockStyle.Fill;

            rChart.Name = txt자원분류.Text;

  //          rChart.Series[0].Visible = false;
            for (int i = 0;  i < spr2.ActiveSheet.Rows.Count; i++) { 
          //      rChart.Series[0].Labels[i] = spr2.ActiveSheet.Cells[i,1].Text ;
            }

         //   foreach series 

            panChat.Controls.Clear();
            panChat.Controls.Add(rChart);

        }

        private void 조회4()
        {


            TChart chart = new Steema.TeeChart.TChart();

            Steema.TeeChart.Themes.BlackIsBackTheme myTheme = new Steema.TeeChart.Themes.BlackIsBackTheme(chart.Chart);
            myTheme.Apply();


            Type tmp = (Type)Steema.TeeChart.Utils.SeriesTypesOf[0];
            Steema.TeeChart.Styles.Series series;

            //Some series can not work without a parent chart due to internal structure.
            if (tmp.Name == "TreeMap")
            {
                series = chart.Series.Add(tmp);
            }
            else if (tmp.Name == "PolarGrid")
            {
                series = new Steema.TeeChart.Styles.PolarGrid(chart.Chart);
            }
            else
            {
                series = chart.Series.Add(tmp);
            }

            series.FillSampleValues();

         //   chart.Aspect.View3D = Needs3D(chart[0]);
            //chart.Panel.Transparent = true;
            if (chart[0] is Steema.TeeChart.Styles.Pie)
            {
                Steema.TeeChart.Styles.Pie pie = (Steema.TeeChart.Styles.Pie)chart[0];
                pie.EdgeStyle = Steema.TeeChart.Drawing.EdgeStyles.Flat;
                pie.BevelPercent = 30;

                chart.Legend.Visible = false;
                chart.Aspect.Elevation = 300;
            }

            
            panChat.Controls.Clear();
            panChat.Controls.Add(chart);

        }
        private void 조회2()
        {

            sql = "";
            sql = sql + " select substring(a.d3,1,4), count(*) cnt ";
            sql = sql + " from a201_asset  a ";
            sql = sql + " where a.d4 = '" + txt자원분류.Text  +"' ";
            sql = sql + " group by substring(a.d3,1,4) ";
            sql = sql + " order by substring(a.d3,1,4)";

            DataSet ds = cls_com.Select_Query(sql);
            헤더2(ds);
            spr2.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt2.Text = ds.Tables[0].Rows.Count.ToString();
            spr2.DataSource = ds;
            if (ds.Tables[0].Rows.Count > 0)
            {

                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).Locked = true;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr2.Sheets[0]);
            lblCnt2.Text = spr2.ActiveSheet.RowCount.ToString();
        }
        private void 헤더2(DataSet ds)
        {
            int i = 0;
            spr2.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "연도";
            spr2.ActiveSheet.ColumnHeader.Cells[0, i++].Text = "수량";
            spr2.ActiveSheet.ColumnHeader.Rows[0].Height = 30;

        }

        private void spr_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr.ActiveSheet);
        }

        private void spr2_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr2.ActiveSheet);
        }

        private void sc_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (r초기화) return;
            cls_com.ConfigSave(this.Name + "_sc_넓이", sc.SplitterDistance.ToString());
        }

        private void sc2_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (r초기화) return;
            cls_com.ConfigSave(this.Name + "_sc2_넓이", sc2.SplitterDistance.ToString());
        }

        private void t초기화_Tick(object sender, EventArgs e)
        {
            t초기화.Enabled = false;
            r초기화 = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            조회4();
        }

        private void spr2_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
        }

        private void spr2_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            string 일자="",일자1, 일자2, 자원분류;
            DateTime dt; 
            자원분류 = txt자원분류.Text;
            일자 = spr2.ActiveSheet.Cells[e.Row, 0].Text;
            일자1 = 일자 + "-01-01" ;
            
            일자2 = (cls_com.Val2(일자) + 1).ToString() + "-01-01" ;
            dt = Convert.ToDateTime(일자2);
            dt = dt.AddDays(-1);
            일자2 = dt.ToString("yyyy-MM-dd");

            cls_com.폼_실행여부_자동종료("frm자산조회_자산조회");
            frm자산조회_자산조회 frm자산조회_자산조회 = new frm자산조회_자산조회(일자1,일자2,자원분류);
            frm자산조회_자산조회.Show();

        }

        private void btn닫기_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

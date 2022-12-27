using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace arm_asset
{
    class cls_pda
    {

        public static string gPath = Environment.CurrentDirectory;
        public static string gPDA_ADB = gPath + "\\adb.exe";
        public static string gPDA_SendFileName = gPath + "\\send.cfg";
        // public static string gPDA_SendFileName =  "d:\\temp\\send.cfg ";
        public static string gPDA_a101_user = "a101_user.txt";
        public static string gPDA_a101_arm = "a101_arm.txt";
        public static string gPDA_a201_asset = "a201_asset.txt";
        public static string gPDA_a301_silsa = "a301_silsa.txt";
        public static string gPDA_PATH = "/storage/emulated/0/";

        public static string gPDA_MAKE = "adb push d:\\temp\\send.cfg  /storage/emulated/0/";
        public static string gPDA_DELETE = "adb shell rm /storage/emulated/0/data.txt";
        public static string gPDA_COPY = "adb pull  /storage/emulated/0/data.txt d:\\temp\\data.txt";

        public static string g메세지 = "";

        public static void 파일저장(string 파일명, DataSet ds ) 
        {
            String d;
            파일삭제(파일명);
            using (StreamWriter sw = File.AppendText(파일명))
            {
                cls_com.g수량 = 0; 
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    d = "";
                    for (int j = 0; j < ds.Tables[0].Columns.Count;j++)
                    {
                        d = d + ds.Tables[0].Rows[i][j].ToString() + "\t";
                     }
                    sw.WriteLine(d);
                    cls_com.g수량++;
                }
            }
        }

        public static void 파일삭제(String d)
        {
            try
            {
                File.Delete(d);
            }
            catch
            {
            }

        }

        private static void 메세지(String d)
        {
            cls_pda.g메세지 = d;
        }

        public static bool PDA_파일삭제(String d)
        {
            Process myProcess = new Process();
            string result = "";
            myProcess.StartInfo.FileName = cls_pda.gPDA_ADB;

            myProcess.StartInfo.UseShellExecute = false;
            //myProcess.StartInfo.CreateNoWindow = true;
            myProcess.StartInfo.RedirectStandardInput = true;
            myProcess.StartInfo.RedirectStandardOutput = true;
            myProcess.StartInfo.Arguments = @" shell rm /storage/emulated/0/" + d ;
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            myProcess.Start();

            //Input parameter
            //StreamWriter sIn = myProcess.StandardInput;
            //sIn.Write("", Environment.NewLine);

            StreamReader sOut = myProcess.StandardOutput;

            result = sOut.ReadToEnd();
            cls_pda.g메세지 = result;
            if (result.IndexOf("error:") >= 0)
            {
                cls_pda.g메세지 = "에러 삭제" ;
                return false;
            }
            else
            {
                cls_pda.g메세지 = "정상 삭제";
                return true;
            }

        }

        public static void 데이타다운로드(string 조건)
        {

            MessageBox.Show(cls_com.GetCode(cls_com.g저장폴더) + " 드라이브에 파일 생성됩니다");
            if (!cls_com.드라이브여부(cls_com.g저장폴더)) {
                MessageBox.Show(cls_com.g저장폴더 +" 드리이브 에러 입니다. 확인 하세요" ) ;
                return;
            }

            if (!PDA_UPLOAD_사용자()) return;
            if (!PDA_UPLOAD_부대()) return;
            if (!PDA_UPLOAD_자산(조건)) return;

            MessageBox.Show(cls_com.g수량.ToString() + " 건  생성완료 " );
        }

        

        public static bool PDA_UPLOAD_사용자()
        {
            string sql = "";
            string r메세지 = "";

            /*
            if (!cls_pda.PDA_파일삭제(cls_com.GetCode(cls_com.g저장폴더) + cls_pda.gPDA_a101_user))
            {
                MessageBox.Show("PDA 연결 확인");
                return false;
            }
            */

            sql = "select id,pw,sosok,nm,cla,degree,tel,bigo,gubun  from a101_user order by id  ";
            DataSet ds = cls_com.Select_Query(sql);
            cls_pda.파일저장(cls_com.GetCode(cls_com.g저장폴더) + cls_pda.gPDA_a101_user, ds);
            /*
            Process myProcess = new Process();
            string result = "";
            myProcess.StartInfo.FileName = cls_pda.gPDA_ADB;


            myProcess.StartInfo.UseShellExecute = false;
            //myProcess.StartInfo.CreateNoWindow = true;
            myProcess.StartInfo.RedirectStandardInput = true;
            myProcess.StartInfo.RedirectStandardOutput = true;
            myProcess.StartInfo.Arguments = @"push " + cls_pda.gPath + "\\" + cls_pda.gPDA_a101_user + " " + "/storage/emulated/0/" + cls_pda.gPDA_a101_user;
            //            myProcess.StartInfo.Arguments = @"pull /storage/emulated/0/" + cls_pda.gPDA_arm_asset_arm + " " + cls_pda.gPath + "\\" + cls_pda.gPDA_arm_asset_arm;
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            myProcess.Start();

            //Input parameter
            //StreamWriter sIn = myProcess.StandardInput;
            //sIn.Write("", Environment.NewLine);

            StreamReader sOut = myProcess.StandardOutput;

            result = sOut.ReadToEnd();
            r메세지 = result;
            if (result.IndexOf("error:") >= 0)
            {
                cls_pda.g메세지 = "에러 부대 복사 " + r메세지 ;
                return false;
            }
            else
            {
                cls_pda.g메세지 = "부대 정상 복사";
                return true;
            }
            */
            return true;
        }

        public static bool PDA_UPLOAD_부대()
        {
            string sql = "";
            string r메세지 = "";
            /*
            if (!cls_pda.PDA_파일삭제(cls_com.GetCode(cls_com.g저장폴더)  + cls_pda.gPDA_a101_arm))
            {
                MessageBox.Show("PDA 연결 확인");
                return false;
            }
            */

            sql = "select  arm_code,arm,loc,tel,address,usr from a101_arm order by arm_code ";
            DataSet ds = cls_com.Select_Query(sql);
            cls_pda.파일저장(cls_com.GetCode(cls_com.g저장폴더)  + cls_pda.gPDA_a101_arm, ds);
            /*
            Process myProcess = new Process();
            string result = "";
            myProcess.StartInfo.FileName = cls_pda.gPDA_ADB;


            myProcess.StartInfo.UseShellExecute = false;
            //myProcess.StartInfo.CreateNoWindow = true;
            myProcess.StartInfo.RedirectStandardInput = true;
            myProcess.StartInfo.RedirectStandardOutput = true;
            myProcess.StartInfo.Arguments = @"push " + cls_pda.gPath + "\\" + cls_pda.gPDA_a101_arm + " " + "/storage/emulated/0/" + cls_pda.gPDA_a101_arm;
            //            myProcess.StartInfo.Arguments = @"pull /storage/emulated/0/" + cls_pda.gPDA_arm_asset_arm + " " + cls_pda.gPath + "\\" + cls_pda.gPDA_arm_asset_arm;
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            myProcess.Start();

            //Input parameter
            //StreamWriter sIn = myProcess.StandardInput;
            //sIn.Write("", Environment.NewLine);

            StreamReader sOut = myProcess.StandardOutput;

            result = sOut.ReadToEnd();
            r메세지 = result;
            if (result.IndexOf("error:") >= 0)
            {
                cls_pda.g메세지 = "에러 부대 복사 " + r메세지;
                return false;
            }
            else
            {
                cls_pda.g메세지 = "부대 정상 복사";
                return true;
            }
            */
            return true;
        }

        public static bool PDA_UPLOAD_자산(string 조건)
        {
            string sql = "";
            string r메세지 = "";
            /*
            if (!cls_pda.PDA_파일삭제(cls_com.gPath  + cls_pda.gPDA_a201_asset))
            {
                MessageBox.Show("PDA 연결 확인");
                return false;
            }
            */
            sql = "";

            sql = sql  + " select a.code,a.dt,a.state,a.arm_code,a.d1,a.d2,a.d3,a.d4,a.d5,a.d6,a.d7,a.d8,a.d9,a.d10,a.d11,a.d12,a.d13,a.d14,a.d15,a.d16,a.d17,a.d18 \n";
            sql = sql  + " from a201_asset  a \n";
            sql = sql + "  left join a101_arm b on a.arm_code = b.arm_code  \n";
            sql = sql  + 조건 ;
            sql = sql + " order by a.code ";
            DataSet ds = cls_com.Select_Query(sql);
            cls_pda.파일저장(cls_com.GetCode(cls_com.g저장폴더) + cls_pda.gPDA_a201_asset, ds);
            /*
            Process myProcess = new Process();
            string result = "";
            myProcess.StartInfo.FileName = cls_pda.gPDA_ADB;


            myProcess.StartInfo.UseShellExecute = false;
            //myProcess.StartInfo.CreateNoWindow = true;
            myProcess.StartInfo.RedirectStandardInput = true;
            myProcess.StartInfo.RedirectStandardOutput = true;
            myProcess.StartInfo.Arguments = @"push " + cls_pda.gPath + "\\" + cls_pda.gPDA_a201_asset + " " + "/storage/emulated/0/" + cls_pda.gPDA_a201_asset;
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            myProcess.Start();

            //Input parameter
            //StreamWriter sIn = myProcess.StandardInput;
            //sIn.Write("", Environment.NewLine);

            StreamReader sOut = myProcess.StandardOutput;

            result = sOut.ReadToEnd();
            r메세지 = result;
            if (result.IndexOf("error:") >= 0)
            {
                cls_pda.g메세지 = "에러 자산 복사 " + r메세지;
                return false;
            }
            else
            {
                cls_pda.g메세지 = "자산 정상 복사";
                return true;
            }
            */
            return true;
        }


        public static void 실사데이타다운로드()
        {
            PDA_DOWNLOAD_실사_저장2();

        }
        

        public static void PDA_DOWNLOAD_실사()
        {
            bool r;
            cls_pda.파일삭제(cls_pda.gPDA_a301_silsa);

            r = PDA_DOWNLOAD_실사_삭제();
            r = PDA_DOWNLOAD_실사_파일생성();
            if (r == false)
            {
                return;
            }

            while (true)
            {
                Thread.Sleep(2000);
                Application.DoEvents();
                r = PDA_DOWNLOAD_실사_복사();
                if (r == false)
                {
                    return;
                }
                else
                {
                    PDA_DOWNLOAD_실사_저장();
                    break;
                }
               

            }


        }

        public static bool PDA_DOWNLOAD_실사_삭제()
        {
            string r메세지 = "";
            Process myProcess = new Process();
            string result = "";
            myProcess.StartInfo.FileName = cls_pda.gPDA_ADB;

            myProcess.StartInfo.UseShellExecute = false;
            //myProcess.StartInfo.CreateNoWindow = true;
            myProcess.StartInfo.RedirectStandardInput = true;
            myProcess.StartInfo.RedirectStandardOutput = true;
            myProcess.StartInfo.Arguments = @" shell rm /storage/emulated/0/" + cls_pda.gPDA_a301_silsa;
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            myProcess.Start();

            //Input parameter
            //StreamWriter sIn = myProcess.StandardInput;
            //sIn.Write("", Environment.NewLine);

            StreamReader sOut = myProcess.StandardOutput;

            result = sOut.ReadToEnd();
            r메세지 = result;
            if (result.IndexOf("error:") >= 0)
            {
                cls_pda.g메세지 = "에러 DOWNLOAD 파일 삭제";
                return false;
            }
            else
            {

                cls_pda.g메세지 = "DONLOAD 파일 정상 삭제";
                return true;
            }

        }
        public static bool PDA_DOWNLOAD_실사_파일생성()
        {
            string r메세지 = "";
            Process myProcess = new Process();
            string result = "";
            myProcess.StartInfo.FileName = cls_pda.gPDA_ADB;


            myProcess.StartInfo.UseShellExecute = false;
            //myProcess.StartInfo.CreateNoWindow = true;
            myProcess.StartInfo.RedirectStandardInput = true;
            myProcess.StartInfo.RedirectStandardOutput = true;
            myProcess.StartInfo.Arguments = @"push " + cls_pda.gPDA_SendFileName + "  /storage/emulated/0/";
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            myProcess.Start();

            //Input parameter
            //StreamWriter sIn = myProcess.StandardInput;
            //sIn.Write("", Environment.NewLine);

            StreamReader sOut = myProcess.StandardOutput;

            result = sOut.ReadToEnd();
            r메세지 = result;
            if (result.IndexOf("error:") >= 0)
            {

                cls_pda.g메세지 = "에러  DOWNLOAD 실사 파일 생성 " + r메세지;
                return false;
            }
            else
            {
                cls_pda.g메세지 = "정상 생성";
                return true;
            }

        }



        public static bool PDA_DOWNLOAD_실사_복사()
        {
            String r메세지;
            Process myProcess = new Process();
            string result = "";
            myProcess.StartInfo.FileName = cls_pda.gPDA_ADB;


            myProcess.StartInfo.UseShellExecute = false;
            //myProcess.StartInfo.CreateNoWindow = true;
            myProcess.StartInfo.RedirectStandardInput = true;
            myProcess.StartInfo.RedirectStandardOutput = true;
            myProcess.StartInfo.Arguments = @"pull /storage/emulated/0/" + cls_pda.gPDA_a301_silsa + " " + cls_pda.gPath + "\\" + cls_pda.gPDA_a301_silsa;
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            myProcess.Start();

            //Input parameter
            //StreamWriter sIn = myProcess.StandardInput;
            //sIn.Write("", Environment.NewLine);

            StreamReader sOut = myProcess.StandardOutput;

            result = sOut.ReadToEnd();
            r메세지 = result;
            if (result.IndexOf("error:") >= 0)
            {
                cls_pda.g메세지 = "에러 PDA DOWNLOAD 실사 복사 에러 " + r메세지;
                return false;
            }
            else
            {
                cls_pda.g메세지 = "PDA DOWNLOAD 실사 정상 복사 ";
                return true;
            }

        }

        public static bool PDA_DOWNLOAD_실사_저장()
        {

            frm기타_실사데이타 frm기타_실사데이타 = new frm기타_실사데이타();

            frm기타_실사데이타.Show();
            frm기타_실사데이타.spr.ActiveSheet.RowCount = 0;
            frm기타_실사데이타.spr.ActiveSheet.ColumnCount = 10;
            frm기타_실사데이타.spr.ActiveSheet.ColumnHeader.Cells[0, 0].Text = "일자";
            frm기타_실사데이타.spr.ActiveSheet.ColumnHeader.Cells[0, 1].Text = "시간";
            frm기타_실사데이타.spr.ActiveSheet.ColumnHeader.Cells[0, 2].Text = "소소부대코드";
            frm기타_실사데이타.spr.ActiveSheet.ColumnHeader.Cells[0, 3].Text = "실사부대코드";
            frm기타_실사데이타.spr.ActiveSheet.ColumnHeader.Cells[0, 4].Text = "자산번호";
            frm기타_실사데이타.spr.ActiveSheet.ColumnHeader.Cells[0, 5].Text = "사용자";


            int i = 0, j = 0, k = 0;
            string sql = "";
            string[] lines = System.IO.File.ReadAllLines(cls_pda.gPath + "\\" + cls_pda.gPDA_a301_silsa);
            using (var sr = new StreamReader(cls_pda.gPath + "\\" + cls_pda.gPDA_a301_silsa))
            {
                for (i = 0; i < lines.Length; i++)
                {

                    String d = sr.ReadLine();
                    if (d.Trim().Length > 0)
                    {
                        frm기타_실사데이타.spr.ActiveSheet.RowCount++;
                        string[] arr;
                        arr = d.Trim().Split('\t');

                        sql = "select * from a301_silsa where dt = '" + arr[0].ToString().Trim() + "' and tm = '" + arr[1].ToString().Trim() + "' and code = '" + arr[4].ToString().Trim() + "' ";
                        DataSet ds = cls_com.Select_Query(sql);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            frm기타_실사데이타.spr.ActiveSheet.Cells[i, 0].Text = arr[0].ToString().Trim();
                            for (j = 1; j < arr.Length; j++)
                            {
                                frm기타_실사데이타.spr.ActiveSheet.Cells[i, j].Text = arr[j].ToString().Trim();
                            }
                            for (k = j; k < 9; k++)
                            {
                                frm기타_실사데이타.spr.ActiveSheet.Cells[i, k].Text = "";
                            }
                            frm기타_실사데이타.spr.Sheets[0].Cells.Get(i, 0, i, frm기타_실사데이타.spr.Sheets[0].ColumnCount - 1).BackColor =  Color.Pink;
                        }
                        else
                        {
                            sql = "";
                            sql = sql + " insert into a301_silsa (dt,tm,arm_code,arm_code_s,code,usr,bigo,update_yn,update_data) values (";
                            sql = sql + "  '" + arr[0].ToString().Trim() + "' ";
                            frm기타_실사데이타.spr.ActiveSheet.Cells[i, 0].Text = arr[0].ToString().Trim();
                            for (j = 1; j < arr.Length; j++)
                            {
                                sql = sql + " ,'" + arr[j].ToString().Trim() + "' ";
                                frm기타_실사데이타.spr.ActiveSheet.Cells[i, j].Text = arr[j].ToString().Trim();
                            }
                            for (k = j; k < 9; k++)
                            {
                                sql = sql + " ,'" + "" + "' ";
                                frm기타_실사데이타.spr.ActiveSheet.Cells[i, k].Text = "";
                            }
                            sql = sql + "  ) ";
                            cls_com.ExcuteNonQuery(sql);
                        }
                    }

                }
                if (frm기타_실사데이타.spr.ActiveSheet.RowCount > 0)
                {
                    frm기타_실사데이타.spr.Sheets[0].Cells.Get(0, 0, frm기타_실사데이타.spr.Sheets[0].RowCount - 1, frm기타_실사데이타.spr.Sheets[0].ColumnCount - 1).Locked = true;
                    frm기타_실사데이타.spr.Sheets[0].Cells.Get(0, 0, frm기타_실사데이타.spr.Sheets[0].RowCount - 1, frm기타_실사데이타.spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                    frm기타_실사데이타.spr.Sheets[0].Cells.Get(0, 0, frm기타_실사데이타.spr.Sheets[0].RowCount - 1, frm기타_실사데이타.spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                }

                frm기타_실사데이타.timer1.Enabled = true;


            }

            return true;
        }

        public static bool PDA_DOWNLOAD_실사_저장2()
        {


            string 파일 = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "실사 파일 열기";
            ofd.Filter = "실사파일 (*.txt) | *.txt";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.No || dr == DialogResult.Cancel)
            {
                return false ;
            }
            파일 = ofd.FileName;


            frm기타_실사데이타 frm기타_실사데이타 = new frm기타_실사데이타();

            frm기타_실사데이타.Show();
            frm기타_실사데이타.spr.ActiveSheet.RowCount = 0;
            frm기타_실사데이타.spr.ActiveSheet.ColumnCount = 10;
            frm기타_실사데이타.spr.ActiveSheet.ColumnHeader.Cells[0, 0].Text = "일자";
            frm기타_실사데이타.spr.ActiveSheet.ColumnHeader.Cells[0, 1].Text = "시간";
            frm기타_실사데이타.spr.ActiveSheet.ColumnHeader.Cells[0, 2].Text = "소소부대코드";
            frm기타_실사데이타.spr.ActiveSheet.ColumnHeader.Cells[0, 3].Text = "실사부대코드";
            frm기타_실사데이타.spr.ActiveSheet.ColumnHeader.Cells[0, 4].Text = "자산번호";
            frm기타_실사데이타.spr.ActiveSheet.ColumnHeader.Cells[0, 5].Text = "사용자";


            int i = 0, j = 0, k = 0;
            string sql = "";
            string[] lines = System.IO.File.ReadAllLines(파일);
            using (var sr = new StreamReader(파일))
            {
                for (i = 0; i < lines.Length; i++)
                {

                    String d = sr.ReadLine();
                    if (d.Trim().Length > 0)
                    {
                        frm기타_실사데이타.spr.ActiveSheet.RowCount++;
                        string[] arr;
                        arr = d.Trim().Split('\t');
                        if ( arr.Length != 6 )
                        {
                            MessageBox.Show("실사파일이 아닙니다.");
                            break;
                        }
                        sql = "select * from a301_silsa where dt = '" + arr[0].ToString().Trim() + "' and tm = '" + arr[1].ToString().Trim() + "' and code = '" + arr[4].ToString().Trim() + "' ";
                        DataSet ds = cls_com.Select_Query(sql);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            frm기타_실사데이타.spr.ActiveSheet.Cells[i, 0].Text = arr[0].ToString().Trim();
                            for (j = 1; j < arr.Length; j++)
                            {
                                frm기타_실사데이타.spr.ActiveSheet.Cells[i, j].Text = arr[j].ToString().Trim();
                            }
                            for (k = j; k < 9; k++)
                            {
                                frm기타_실사데이타.spr.ActiveSheet.Cells[i, k].Text = "";
                            }
                            frm기타_실사데이타.spr.Sheets[0].Cells.Get(i, 0, i, frm기타_실사데이타.spr.Sheets[0].ColumnCount - 1).BackColor = Color.Pink;
                        }
                        else
                        {
                            sql = "";
                            sql = sql + " insert into a301_silsa (dt,tm,arm_code,arm_code_s,code,usr,bigo,update_yn,update_data) values (";
                            sql = sql + "  '" + arr[0].ToString().Trim() + "' ";
                            frm기타_실사데이타.spr.ActiveSheet.Cells[i, 0].Text = arr[0].ToString().Trim();
                            for (j = 1; j < arr.Length; j++)
                            {
                                sql = sql + " ,'" + arr[j].ToString().Trim() + "' ";
                                frm기타_실사데이타.spr.ActiveSheet.Cells[i, j].Text = arr[j].ToString().Trim();
                            }
                            for (k = j; k < 9; k++)
                            {
                                sql = sql + " ,'" + "" + "' ";
                                frm기타_실사데이타.spr.ActiveSheet.Cells[i, k].Text = "";
                            }
                            sql = sql + "  ) ";
                            cls_com.ExcuteNonQuery(sql);
                        }
                    }

                }
                if (frm기타_실사데이타.spr.ActiveSheet.RowCount > 0)
                {
                    frm기타_실사데이타.spr.Sheets[0].Cells.Get(0, 0, frm기타_실사데이타.spr.Sheets[0].RowCount - 1, frm기타_실사데이타.spr.Sheets[0].ColumnCount - 1).Locked = true;
                    frm기타_실사데이타.spr.Sheets[0].Cells.Get(0, 0, frm기타_실사데이타.spr.Sheets[0].RowCount - 1, frm기타_실사데이타.spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                    frm기타_실사데이타.spr.Sheets[0].Cells.Get(0, 0, frm기타_실사데이타.spr.Sheets[0].RowCount - 1, frm기타_실사데이타.spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                }

                frm기타_실사데이타.timer1.Enabled = true;


            }

            return true;
        }
    }
}

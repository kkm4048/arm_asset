using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.IO;

namespace arm_asset
{
    class cls_com
    {
        // public static string gConn_String = "Data Source=49.1.232.110,5000;Initial Catalog=y_raoncorp;User Id=sa2;Password=sql";
        //      public static string gConn_String = "server=localhost;database=arm_asset;port=30000;user=asset;password=cubridsql ; autocommit = 1 ";
        public static string gConn_String = "Data Source=49.1.232.110,5000;Initial Catalog=arm_asset;User Id=arm_asset;Password=sql123!@#";
        //     public static string gConn_String = "server=localhost;port=30000;database=arm_asset;user=asset;password=cubridsql;autocommit=1;charset=UTF8;";
        public static string gIp = "" ;
        public static SqlConnection gCon = null;
        public static SqlCommand gCom = null;
        public static Form gForm;
        public static string gPath = Application.StartupPath;
        public static string g업체명 = "(주)시스트데이타";
        public static string g버젼 = "v1.2";
        public static string g프린터="";
        public static Color 색상_선택 = Color.MediumTurquoise;
        public static string[] g타이틀 = new string[30];
        public static int g타이틀_수량 = 0;
        public static string g저장폴더 = "c:\\";


        public static string[] g타이틀2 = new string[20];
        public static int g타이틀2_수량 = 0;
        public static string gFileName_메뉴얼 = "자산소모품관리_메뉴얼.pdf";

        public static string Speadinifile = Environment.CurrentDirectory + "\\Spread.ini";
        public static string GuyIniFile = Environment.CurrentDirectory + "\\Guy.ini";
        public static string ConfigIniFile = Environment.CurrentDirectory + "\\Config.ini";
        public static int g수량 = 0 ;

        [DllImport("kernel32")]
        public static extern int WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);

        [DllImport("kernel32")]
        public static extern uint GetPrivateProfileInt(string lpAppName, string lpKeyName, int nDefault, string lpFileName);

        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDefaultPrinter(string Name);

        //로그인 사용자 정보
        public struct 사용자
        {
            public static string 사번 = "";
            public static string 아이디 = "";
            public static string 암호 = "";
            public static string 성명 = "";
            public static string 소속 = "";
            public static string 등급 = "";
            public static string 연락처 = "";
            public static string 구분 = "";
            public static string 소속부대코드 = "";
            public static string 소속부대 = "";


        }

        public static string DB_Connect()
        {
            string sResult;

            /*
            try

            {
                SqlConnectionStringBuilder aa = new SqlConnectionStringBuilder("localhost", "30000", "arm_asset", "asset", "cubridsql", "", true);

                SqlConnection bb = new SqlConnection(aa.ConnectionString);

            } catch (CUBRIDException e)
            {

            }
            */
            try
            {
                gCon = new SqlConnection(gConn_String);
                gCon.Open();
                sResult = "CONNECT";
                gCon.Close();
                return sResult;
            }

            catch (SqlException ex) 
            {
                sResult = "DISCONNECT " + ex.Message;

                return sResult;
                //Console.WriteLine(ex.Message);
            }
        }

        public static DataSet Select_Query(string sQuery)
        {
            try
            {

                SqlConnection con = new SqlConnection(gConn_String);

                DataSet ds = new DataSet();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sQuery, con);

                sqlAdapter.Fill(ds);
                con.Close();
                return ds;
            }

            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("[Select_Query]" + ex.Message);
                return null;
            }
        }

        public static string ExcuteNonQuery(string sQuery)
        {
            try
            {

                SqlConnection con = new SqlConnection(gConn_String);
                con.Open();
                SqlCommand com = new SqlCommand(sQuery, con);

                com.ExecuteNonQuery();
                
                con.Close();
                string sResult = "success";
                return sResult;
            }

            catch (SqlException ex)
            {
                MessageBox.Show(sQuery + Keys.Enter + "[ExcuteNonQuery]" + ex.Message);
                return "[ExcuteNonQuery]" + ex.Message;
            }
        }


        public static DataSet Select_QueryT(string sQuery)
        {
            try
            {

                
                DataSet ds = new DataSet();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sQuery, cls_com.gCon);
                
                sqlAdapter.Fill(ds);
                return ds;
            }

            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("[Select_Query]" + ex.Message);
                return null;
            }
        }
        public static string ExcuteNonQueryT(string sQuery,SqlTransaction tran)
        {
            try
            {

                SqlCommand com = new SqlCommand(sQuery, cls_com.gCon);
                com.Transaction = tran;
                
                com.ExecuteNonQuery();

                string sResult = "success";
                return sResult;
            }

            catch (SqlException ex)
            {
                MessageBox.Show(sQuery + Keys.Enter + "[ExcuteNonQuery]" + ex.Message);
                return "[ExcuteNonQuery]" + ex.Message;
            }
        }



        public static void ConfigSave(string iKey, string iData)
        {
            try
            {
                string sSection = "CONFIG";

                WritePrivateProfileString(sSection, iKey, iData, ConfigIniFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
            }
        }


        public static string ConfigLoad(string iKey)
        {


            string sSection = "CONFIG";

            StringBuilder sData = new StringBuilder(512);
            string iData;


            GetPrivateProfileString(sSection, iKey, "", sData, 512, ConfigIniFile);

            iData = sData.ToString();

            return iData;

        }

        public static void SpreadSave(Form iForm, FarPoint.Win.Spread.SheetView iSpread)
        {
            try
            {
                string ikey = iForm.Name + "/" + iSpread.SheetName;
                string sSection = "SPREAD_WIDTH";
                string sData = "";
                for (int i = 0; i < iSpread.ColumnCount; ++i)
                {
                    sData = sData + Convert.ToString(iSpread.ColumnHeader.Cells.Get(0, i).Column.Width) + "|";
                }

                WritePrivateProfileString(sSection, ikey, sData, Speadinifile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
            }
        }


        public static void SpreadLoad(Form iForm, FarPoint.Win.Spread.SheetView iSpread)
        {
            try
            {
                string ikey = iForm.Name + "/" + iSpread.SheetName;
                string sSection = "SPREAD_WIDTH";
                StringBuilder sData = new StringBuilder(512);

                GetPrivateProfileString(sSection, ikey, "", sData, 512, Speadinifile);
                string arr = sData.ToString();
                if (arr.Length != 0)
                {
                    string[] arrSplit = arr.Split('|');
                    for (int i = 0; i < arrSplit.Length - 1; ++i)
                    {
                        if (i == iSpread.ColumnCount) break;
                        iSpread.ColumnHeader.Cells.Get(0, i).Column.Width = Convert.ToInt32(arrSplit[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);



            }
            finally
            {
            }

        }


        public static string Val(string d)
        {
            string d2;

            d2 = d.Replace(",", "");

            if (numericCheck(d2))
            {
            }
            else
            {
                d2 = "0";
            }


            return d2;

        }
        public static int Val2(string d)
        {
            string d2;
            int d3;

            if (String.IsNullOrEmpty(d))
            {
                d = "0";
            }
            d2 = d.Replace(",", "");


            if (numericCheck(d2))
            {
            }
            else
            {
                d2 = "0";
            }
            d3 = (int)Convert.ToDouble(d2);
            return d3;
        }
        //숫자여부 체크
        public static bool numericCheck(string strNumber)
        {
            try
            {
                double iNumber = Convert.ToDouble(strNumber);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public static string GetDateTime()
        {
            //SPEC
            string sql;
            sql = " select convert(varchar(10),getdate(),121) dt , substring(convert(varchar(19),getdate(),121),12,8) tm  ";

            DataSet ds = cls_com.Select_Query(sql);
            if (ds == null) return "";

            return ds.Tables[0].Rows[0][0].ToString() + " " + ds.Tables[0].Rows[0][0].ToString();

        }


        public static string GetDate()
        {
            //SPEC
            return String.Format("{0:yyyy-MM-dd}", DateTime.Now);

        }

        public static string GetDate(String dt)
        {
            //SPEC
            return String.Format("{0:yyyy-MM-dd}", dt);


        }
        public static string GetDate(DateTime dt)
        {
            //SPEC
            return String.Format("{0:yyyy-MM-dd}", dt);


        }

        public static string GetDate2()
        {
            //SPEC
            return String.Format("{0:yyyy-MM-dd}", DateTime.Now);


        }

        public static string GetDate2(String dt)
        {
            //SPEC
            DateTime dt2 = Convert.ToDateTime(dt);
            return String.Format("{0:yyyy년 M월 d일}", dt2);


        }
        public static string GetTime()
        {
            return  String.Format("{0:hh:MM:ss}", DateTime.Now);

        }
        public static string GetTime2()
        {
            //SPEC

            return String.Format("{0:HH:mm:ss}", DateTime.Now);
        }

        public static string GetDefaultPrinter()
        {
            PrinterSettings settings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = printer;
                if (settings.IsDefaultPrinter)
                    return printer;
            }
            return string.Empty;

        }


        // 프린터 텍스트
        public static void PrintText(System.Drawing.Printing.PrintPageEventArgs e, string iData, Font iFont, string iAlign, string iDir, int iX, int iY, int iW, int iH)
        {
            int iWidth;
            if (iData == "") return;

            iX = Convert.ToInt32(iX * 0.3937);
            iY = Convert.ToInt32(iY * 0.3937);

            iWidth = Convert.ToInt32(e.Graphics.MeasureString(iData, iFont).Width);

            if (iDir == "0")
            {

                if (iAlign == "CENTER")
                {
                    iX = iX - (iWidth / 2);

                }
                else if (iAlign == "RIGHT")
                {
                    iX = iX - iWidth;
                }
                else
                {


                }
                // e.Graphics.DrawString(iData, iFont, Brushes.Black, iX, iY);



                Matrix matrix = new Matrix();

                //글자를 270도 회전
                matrix.RotateAt(0, new PointF(iX, iY));
                matrix.Scale(iW, iH);
                Matrix origin = e.Graphics.Transform;
                e.Graphics.Transform = matrix;
                e.Graphics.DrawString(iData, iFont, Brushes.Black, iX, iY);


                e.Graphics.Transform = origin;

            }
            else if (iDir == "90")
            {


                Matrix matrix = new Matrix();

                //글자를 270도 회전
                matrix.RotateAt(90, new PointF(iX, iY));
                matrix.Scale(iW, iH);
                Matrix origin = e.Graphics.Transform;
                e.Graphics.Transform = matrix;
                e.Graphics.DrawString(iData, iFont, Brushes.Black, iX, iY);
                e.Graphics.Transform = origin;



            }
            else if (iDir == "180")
            {


                Matrix matrix = new Matrix();

                //글자를 180도 회전
                matrix.RotateAt(180, new PointF(iX, iY));
                matrix.Scale(iW, iH);
                Matrix origin = e.Graphics.Transform;
                e.Graphics.Transform = matrix;
                e.Graphics.DrawString(iData, iFont, Brushes.Black, iX, iY);
                e.Graphics.Transform = origin;

            }
            else
            {


                Matrix matrix = new Matrix();

                //글자를 270도 회전
                matrix.RotateAt(270, new PointF(iX, iY));
                matrix.Scale(iW, iH);
                Matrix origin = e.Graphics.Transform;
                e.Graphics.Transform = matrix;
                e.Graphics.DrawString(iData, iFont, Brushes.Black, iX, iY);
                e.Graphics.Transform = origin;
            }



        }

        public static void PrintBox(System.Drawing.Printing.PrintPageEventArgs e, int iX, int iY, int iWidth, int iHeight, int iThick)
        {
            Pen blackPen = new Pen(System.Drawing.Color.Black, iThick);

            // ' Create points that define line.
            iX = Convert.ToInt32(iX * 0.3937);
            iY = Convert.ToInt32(iY * 0.3937);
            iWidth = Convert.ToInt32(iWidth * 0.3937);
            iHeight = Convert.ToInt32(iHeight * 0.3937);
            Point point1 = new Point(iX, iY);
            Point point2 = new Point(iWidth, iHeight);

            e.Graphics.ScaleTransform(1, 1);
            e.Graphics.DrawRectangle(blackPen, iX, iY, iWidth, iHeight);
            e.Graphics.ScaleTransform(1, 1);

        }


        public static void PrintBarcode(System.Drawing.Printing.PrintPageEventArgs e, string iData, int iX, int iY, decimal iWidth, decimal iHeight, string iDir, string show, Font font, Fath.bcType bctype)
        {
            //int i;
            if (iData == "") return;
            Font ifont = new Font("굴림체", 18);

            Fath.BarcodeX BarcodeX1 = new Fath.BarcodeX();


            BarcodeX1.Font = ifont;
            if (show.Equals("True"))
            {
                BarcodeX1.ShowText = true;
                BarcodeX1.Font = font;
            }
            else
            {
                BarcodeX1.ShowText = false;
            }

            BarcodeX1.Symbology = (Fath.bcType)bctype;

            BarcodeX1.Orientation = Convert.ToInt32(iDir);

            //     iData = "\xb0\xa1\xb0\xa2\xb0\xa3";
            //   iData = "가나다";
            //byte[] eb = System.Text.Encoding.Unicode.GetBytes(iData);
            System.Text.Encoding utf8 = System.Text.Encoding.UTF8;
            System.Text.Encoding e949 = Encoding.GetEncoding(949);
            byte[] utf8Bytes = e949.GetBytes(iData);

            byte[] eb = System.Text.Encoding.UTF8.GetBytes(iData);
            String bv2 = "";
            bv2 = Convert.ToBase64String(eb).ToString();
            string decodedStringByUTF8 = utf8.GetString(utf8Bytes);


            BarcodeX1.Data = iData;

            //  BarcodeX1.Data = bv;
            //  BarcodeX1.Data = decodedStringByUTF8;




            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //  원본
            //iX = Convert.ToInt32(iX * 0.3937);
            //iY = Convert.ToInt32(iY * 0.3937);

            //BarcodeX1.Width = (int)(iWidth * (decimal)0.003937 * (int)150);
            //BarcodeX1.Height = (int)(iHeight * (decimal)0.003937 * (int)150);

            //System.Drawing.Rectangle rc = new System.Drawing.Rectangle(iX, iY, (int)(iWidth * (decimal)0.003937 * 100), (int)(iHeight * (decimal)0.003937 * 100));
            //e.Graphics.DrawImage(BarcodeX1.Image((int)((float)(iWidth * (decimal)0.003937) * e.Graphics.DpiX), (int)((float)(iHeight * (decimal)0.003937) * e.Graphics.DpiY)), rc);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // BarcodeX1 샘플 소스 수정 (0.3937 -> 0.3779)
            // config값 mm 로 변환

            //iX = Convert.ToInt32(iX * 10 * 0.3779);
            //iY = Convert.ToInt32(iY * 10 * 0.3779);                                  // 1 mm = 3.779 px

            //iX = Convert.ToInt32(iX * 0.3937);
            //iY = Convert.ToInt32(iY * 0.3937);                                     // 1 cm = 0.3937 inch     

            BarcodeX1.Width = (int)(iWidth * (decimal)0.003779 * (int)150);          // 0.003937
            BarcodeX1.Height = (int)(iHeight * (decimal)0.003779 * (int)150);

            System.Drawing.Rectangle rc = new System.Drawing.Rectangle(iX, iY, (int)(iWidth * (decimal)0.003779 * 100), (int)(iHeight * (decimal)0.003779 * 100));
            e.Graphics.DrawImage(BarcodeX1.Image((int)((float)(iWidth * (decimal)0.003779) * e.Graphics.DpiX), (int)((float)(iHeight * (decimal)0.003779) * e.Graphics.DpiY)), rc);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }


        public static string 소속코드(string 소속명)
        {
            String sql = "";
            String 코드 = "";
            sql = "EXEC s_a101_소속_조회 '3','','" + 소속명 + "' ";

            DataSet ds = cls_com.Select_Query(sql);
            if (ds == null)
            {
                return 코드;
            }
            if (ds.Tables[0].Rows.Count > 0)
            {

                코드 = ds.Tables[0].Rows[0]["소속코드"].ToString();
            }
            return 코드;
        }

        public static string Convert_콤마(String d)
        {
            String d2;
            d2 = d.Replace("'", "''");
            return d2;
        }
        public static string GetCode(String d)
        {
            string[] a;
            string d2 = "";
            a = d.Split(' ');
            if (a.Length >= 2)
            {
                d2 = a[0].Trim();
            }
            return d2;
        }
        public static string GetName(String d)
        {
            string[] a;
            string d2 = "";
            a = d.Split(' ');
            if (a.Length >= 2)
            {
                d2 = a[1].Trim();
            }
            return d2;
        }

        public static string 로그_삭제(String 사용자,String 자산번호)
        {

            string sql = "";
            string var = "";
            sql = "";
            sql = sql + " insert into a501_log (usr,dt,tm,gubun1,gubun2,log,bigo) values (";
            sql = sql + " '" + 사용자 + "','" + cls_com.GetDate2() + "','" + cls_com.GetTime2() + "' " ;
            sql = sql + " ,'" + "삭제" + "'  ";
            sql = sql + " ,'" + "자산번호" + "','" + 자산번호 + "' ";
            sql = sql + " ,'' ) ";
            cls_com.ExcuteNonQuery(sql);
    
            sql = "";
            sql = sql + " select * from a201_asset where d1 = '" + 자산번호  +"' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Columns.Count ; i++)
                {
                    var = var + ",'" + ds.Tables[0].Rows[0][i].ToString() + "' ";
                }
            }
            var = var.Replace("'", "''");
            sql = "";
            sql = sql + " insert into a501_log (usr,dt,tm,gubun1,gubun2,log,bigo) values (";
            sql = sql + " '" + 사용자 + "','" + cls_com.GetDate2() + "','" + cls_com.GetTime2() + "' ";
            sql = sql + " ,'" + "삭제" + "'  ";
            sql = sql + " ,'" + "데이타"  + "' ";
            sql = sql + " ,'" + var  + "' ";
            sql = sql + " ,'' ) ";
            cls_com.ExcuteNonQuery(sql);


            return "";
        }

        public static string 로그(String 사용자, String 구분1 ,String 구분2, String 데이타)
        {

            if (구분1.IndexOf("소모품") >= 0 )
            {
                로그_소모품(사용자, 구분1, 구분2, 데이타);
            } else
            {
                로그_자산(사용자, 구분1, 구분2, 데이타);

            }
            return "";
        }
        public static string 로그_자산(String 사용자, String 구분1, String 구분2, String 데이타)
        {
            string sql = "";
            데이타 = 데이타.Replace("'", "''");
            sql = "";
            sql = sql + " insert into a501_log (usr,dt,tm,gubun1,gubun2,log,bigo) values (";
            sql = sql + " '" + 사용자 + "','" + cls_com.GetDate2() + "','" + cls_com.GetTime2() + "' ";
            sql = sql + " ,'" + 구분1 + "'  ";
            sql = sql + " ,'" + 구분2 + "','" + 데이타 + "' ";
            sql = sql + " ,'' ) ";
            cls_com.ExcuteNonQuery(sql);

            return "";
        }
        public static string 로그_소모품(String 사용자, String 구분1, String 구분2, String 데이타)
        {
            string sql = "";
            데이타 = 데이타.Replace("'", "''");
            sql = "";
            sql = sql + " insert into b501_log (usr,dt,tm,gubun1,gubun2,log,bigo) values (";
            sql = sql + " '" + 사용자 + "','" + cls_com.GetDate2() + "','" + cls_com.GetTime2() + "' ";
            sql = sql + " ,'" + 구분1 + "'  ";
            sql = sql + " ,'" + 구분2 + "','" + 데이타 + "' ";
            sql = sql + " ,'' ) ";
            cls_com.ExcuteNonQuery(sql);

            return "";
        }
        public static string 자산번호_가져오기()
        {
            String sql = "";
            String 자산번호 = "";
            sql = "";
            sql = sql + " select max(code) + 1 code  ";
            sql = sql + " from a201_asset ";
            DataSet ds = cls_com.Select_Query(sql);
            자산번호 = ds.Tables[0].Rows[0][0].ToString(); 
            if (자산번호.Equals(""))
            {
                자산번호 = "10000001";
            }
            return 자산번호;
        }


        public static string 소모품번호_가져오기()
        {
            String sql = "";
            String 소모품번호 = "";
            sql = "";
            sql = sql + " select max(code) + 1 code  ";
            sql = sql + " from b101_con ";
            DataSet ds = cls_com.Select_Query(sql);
            소모품번호 = ds.Tables[0].Rows[0][0].ToString();
            if (소모품번호.Equals(""))
            {
                소모품번호 = "100001";
            }
            return 소모품번호;
        }


        public static void 폼_실행(Form form)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == form.Name)
                {
                    frm.Close();
                    break;
                }
            }

            form.Show();
        }
        public static string 거래증_부대코드2담당자(string 부대코드)
        {
            string sql = "";
            string 비고 = "";
            sql = "select top 1 * from a101_user_arm a left join a101_user b on a.id  = b.id where  a.arm_code = '" + 부대코드 + "'  ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                비고 = "계급 : " + ds.Tables[0].Rows[0]["cla"].ToString()  + " 성명 : " + ds.Tables[0].Rows[0]["nm"].ToString() +  "   (인)" ;
            }
            return 비고;
        }
      
        public static string 사용자2관리부대(string 아이디)
        {
            string sql = "";
            string 관리부대 = "";
            sql = "select b.* from a101_user_arm  a  left join a101_arm b on a.arm_code = b.arm_code where a.id = '" + 아이디 + "'  order by b.arm";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    관리부대 = 관리부대 + "," + ds.Tables[0].Rows[i]["arm"].ToString();
                }
                관리부대 = 관리부대.Substring(1);
            }
            return 관리부대;
        }
        public static string 증빙번호_자산_GET(string 구분, string 일자 ,string 부대코드1, string 부대코드2)
        {
            string sql = "";
            string 증빙번호 = "",번호="";

            sql = "select isnull(max(num1) ,'') num1 from a301_output  where DT = '" + 일자  + "' AND state = '" + 구분 + "' AND arm_code = '" + 부대코드1 + "'    AND arm_code_s = '" + 부대코드2 + "'    ";
            DataSet ds, ds2;
            ds     = cls_com.Select_Query(sql);

            if (ds == null) return 증빙번호;
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["num1"].ToString().Equals(""))
                {

                    sql = "select isnull(max(num1) ,'') num1 from a301_output  where substring(DT,1,4) = '" + 일자.Substring(0, 4) + "'  ";
                    ds2 = cls_com.Select_Query(sql);
                    if (ds2.Tables[0].Rows[0]["num1"].ToString().Equals(""))
                    {
                        증빙번호 = 일자.Substring(2, 2) + "-장-0001";
                    }
                    else {
                        증빙번호 = ds2.Tables[0].Rows[0]["num1"].ToString();
                        번호 = cls_com.Right("0000" + (cls_com.Val2(증빙번호.Substring(5, 4)) + 1).ToString(), 4);
                        증빙번호 = 증빙번호.Substring(0, 5) + 번호;
                    }

                } else {
                    증빙번호 = ds.Tables[0].Rows[0]["num1"].ToString();

                }
            }

            return 증빙번호;
        }

        public static string 증빙번호_번호_자산_GET(string 증빙번호)
        {
            string 증빙번호_번호 = "";
            string sql = "";

            sql = "select isnull(max(num2) +1 ,1) num2 from a301_output  where num1  = '" + 증빙번호 + "'  ";

            DataSet ds = cls_com.Select_Query(sql);

            if (ds == null) return 증빙번호_번호;
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["num2"].ToString().Equals(""))
                {
                    증빙번호_번호 = "1";
                }
                else
                {
                    증빙번호_번호 = ds.Tables[0].Rows[0]["num2"].ToString();
                }
            }

            return 증빙번호_번호;
        }
        public static string 증빙번호_소모품_GET(string 구분, string 일자,string 부대코드1, string 부대코드2)
        {
            string sql = "";
            string 증빙번호 = "", 번호 = "";

            sql = "select isnull(max(num1) ,'') num1 from b301_output  where DT = '" + 일자 + "' AND state = '" + 구분 + "' AND arm_code = '" + 부대코드1 + "'    AND arm_code_s = '" + 부대코드2 + "'    ";
            DataSet ds, ds2;
            ds = cls_com.Select_Query(sql);

            if (ds == null) return 증빙번호;
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["num1"].ToString().Equals(""))
                {

                    sql = "select isnull(max(num1) ,'') num1 from b301_output  where substring(DT,1,4) = '" + 일자.Substring(0, 4) + "'  ";
                    ds2 = cls_com.Select_Query(sql);
                    if (ds2.Tables[0].Rows[0]["num1"].ToString().Equals(""))
                    {
                        증빙번호 = 일자.Substring(2, 2) + "-소-0001";
                    }
                    else
                    {
                        증빙번호 = ds2.Tables[0].Rows[0]["num1"].ToString();
                        번호 = cls_com.Right("0000" + (cls_com.Val2(증빙번호.Substring(5, 4)) + 1).ToString(), 4);
                        증빙번호 = 증빙번호.Substring(0, 5) + 번호;
                    }

                }
                else
                {
                    증빙번호 = ds.Tables[0].Rows[0]["num1"].ToString();

                }
            }

            return 증빙번호;
        }

        public static string 증빙번호_번호_소모품_GET(string 증빙번호)
        {
            string 증빙번호_번호 = "";
            string sql = "";

            sql = "select isnull(max(num2) +1 ,1) num2 from b301_output  where num1  = '" + 증빙번호 + "'  ";

            DataSet ds = cls_com.Select_Query(sql);

            if (ds == null) return 증빙번호_번호;
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["num2"].ToString().Equals(""))
                {
                    증빙번호_번호 = "1";
                }
                else
                {
                    증빙번호_번호 = ds.Tables[0].Rows[0]["num2"].ToString();
                }
            }

            return 증빙번호_번호;
        }

        public static string Right(string d,int len)
        {
            string d2 = "";
            d2 = d.Substring(d.Length - len, len);
            return d2;
        }

        public static string 재고여부(string 자산번호,string 아이디)
        {
            string d = "",w="",sql="";
            string 소속코드 = "",소속="",등급;
            DataSet ds,ds2,ds3;
            ds = cls_com.Select_Query("select a.arm_code,b.arm from a201_asset a left join a101_arm b on a.arm_code = b.arm_code  where a.code = '" + 자산번호 + "' ");

            if (ds.Tables[0].Rows.Count <= 0)
            {
                d = "미등록 자산번호입니다.";
                return d ;
            }
            소속코드 = ds.Tables[0].Rows[0]["arm_code"].ToString();
            소속 = ds.Tables[0].Rows[0]["arm"].ToString();

            ds2 = cls_com.Select_Query("select * from a101_user  where id  = '" + 아이디+ "' ");
            if (ds2.Tables[0].Rows.Count <= 0)
            {
                d = "미등록 아이디입니다.";
                return d;
            }
            등급 = ds2.Tables[0].Rows[0]["degree"].ToString();


            if (!등급.Equals("총관리자"))
            {
                w = w + " where a.arm_code in  ( select arm_code from a101_user a left join a101_user_arm b on a.id = b.id where a.id = '" + 아이디 + "' )  \n";
            }
            sql = "";
            sql = sql + " select '' sel,a.state,a.code,a.arm_code,b.arm ,a.d1,a.d2 ,a.d3,a.d4,a.d5,a.d6,a.d12,a.d14 \n";
            sql = sql + " from a201_asset a  \n";
            sql = sql + " left join a101_arm b on a.arm_code = b.arm_code  \n";
            sql = sql + w;
            sql = sql + " order by b.arm,a.d3,a.d4,a.d5 \n";

            ds3 = cls_com.Select_Query(sql);
            if (ds3.Tables[0].Rows.Count <= 0 )
            {
                d = "다름 소속 자산번호 입니다. 소속코드 : " + 소속코드 + " 소속명 : " + 소속; 
            }
            return d;
        }

        public static void Add소속부대(ComboBox cmb소속부대)
        {
            string sql = "";
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

        public static string 출납관_반납관(string 아이디,string 부대코드)
        {
            string d = "";
            string sql = "";
            string d2 = "";
            if (!아이디.Equals(""))
            {
                sql = "select * from a101_user  where id  = '" + 아이디 + "'  ";
            }
            else if (!부대코드.Equals(""))
            {

                sql = "select top 1 id  from a101_user_arm  where arm_code = '" + 부대코드 + "'  ";
                DataSet ds0 = cls_com.Select_Query(sql);
                if (ds0.Tables[0].Rows.Count > 0)
                {
                    d2 = ds0.Tables[0].Rows[0]["id"].ToString();
                    sql = "select * from a101_user  where id  = '" + d2 + "'  ";

                }
                else
                {
                    return "";
                }
            }
            if (sql.Equals("")) return "";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {

                d = "직급:" + ds.Tables[0].Rows[0]["cla"].ToString() + "  " + "성명:" + ds.Tables[0].Rows[0]["nm"].ToString();
                return d;
            } else
            {
                return "";
            }
        }
        public static Form 폼_실행(String 폼명)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == 폼명)
                {

                    frm.TopMost = true;
                    frm.TopMost = false;
                    return frm;

                }
            }
            var form = Activator.CreateInstance(Type.GetType("arm_asset." + 폼명)) as Form;
            form.Show();
            return null;
        }

        public static bool 폼_실행여부_자동종료(String 폼명)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == 폼명)
                {

                    frm.Close();
                    return false;

                }
            }
            return true ;
        }


        public static bool 드라이브여부(string 드라이브)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in allDrives)
            {
                if ( drive.Name.ToUpper().Equals(cls_com.GetCode(드라이브).ToUpper()))
                {
                    return true;
                }

            }
            return false;
        }

    }
}

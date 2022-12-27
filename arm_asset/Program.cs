using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Data;

namespace arm_asset
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNew;
            Mutex dup = new Mutex(true, "arm_asset", out createdNew);

            if (createdNew)
            {



                string[] args = Environment.GetCommandLineArgs();

                cls_com.gIp = cls_com.ConfigLoad("IP");
                cls_com.gConn_String = "Data Source=" + cls_com.gIp + ";Initial Catalog=arm_asset;User Id=arm_asset;Password=sql123!@#";




                if (cls_com.DB_Connect() == "DISCONNECT")
                {
                    MessageBox.Show("데이타 베이스 연결 에러", "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();

                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    //Application.Run(new frmLogin());

                    if (args.Length <= 1)
                    {
                        MessageBox.Show("로그인을 실행하세요");
                        Application.Exit();
                        /*
                        cls_com.사용자.아이디 = "1";
                        cls_com.사용자.성명 = "홍길동";
                        cls_com.사용자.소속 = "관리부대";
                        cls_com.사용자.등급 = "총관리자";
                        cls_com.사용자.구분 = "";
                        LoginChk();

                        //  frm메인 cls_com.frm메인 = new frm메인();
                        Application.Run(new frm메인());
                        dup.ReleaseMutex();
                        */

                    }
                    else
                    {



                        //cls_com.사용자.사번 = "";
                        //cls_com.사용자.아이디 = "1";
                        //cls_com.사용자.성명 = "홍길동";
                        //cls_com.사용자.소속 = "관리부";
                        //cls_com.사용자.등급 = "관리자";



                         cls_com.사용자.아이디 = args[1].ToString();
                    //    cls_com.사용자.아이디 = "1";

                        //    MessageBox.Show("사용자 아이디 " + cls_com.사용자.아이디) ;
                        //        cls_com.사용자.아이디 = "1";

                        if (LoginChk())
                        {


                            //    cls_com.frm메인 = new frm메인();
                            //  cls_com.frm메인.Show();
                            Application.Run(new frm메인());

                            dup.ReleaseMutex();
                        }


                    }

                }
            }
            else
            {
                MessageBox.Show("assets 시스템이 이미 실행중입니다.", "중복실행", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private static bool LoginChk()
        {
            //return true;
            string SQL;
            
            SQL = " select * from a101_user where id =  '" +  cls_com.사용자.아이디 + "'  ";
            DataSet ds = cls_com.Select_Query(SQL);
            if (ds == null) return false;

            if (ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("ID 및 암호 확인 하세요", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            cls_com.사용자.아이디 = ds.Tables[0].Rows[0]["id"].ToString();
            cls_com.사용자.성명 = ds.Tables[0].Rows[0]["nm"].ToString();
            cls_com.사용자.소속 = ds.Tables[0].Rows[0]["sosok"].ToString();
            cls_com.사용자.등급 = ds.Tables[0].Rows[0]["degree"].ToString();
            cls_com.사용자.연락처 = ds.Tables[0].Rows[0]["tel"].ToString();
            cls_com.사용자.구분 = ds.Tables[0].Rows[0]["gubun"].ToString();

            return true;



        }
    }
}

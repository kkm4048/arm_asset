using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace arm_asset
{
    public partial class frm메인 : Form
    {
        public frm메인()
        {
            InitializeComponent();
        }

        private void m기초코드_사용자등록_Click(object sender, EventArgs e)
        {
            FrmShow(new frm기초코드_사용자등록());


        }
        protected void FrmShow(Form frm)
        {
            bool FrmisExist = new bool();
            FrmisExist = false;

            foreach (Form form1 in Application.OpenForms)
            {
                if (form1.GetType() == frm.GetType())
                {

                    form1.Activate();
                    form1.Focus();
                    FrmisExist = true;
                }
            }

            // 폼존재여부에 따라서 생성과 파기
            if (!FrmisExist)
            {

                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
                frm.Activate();
                frm.Focus();
            }
            else
            {
                frm.Dispose();
            }

        }

        private void m자산관리_자산등록_Click(object sender, EventArgs e)
        {
            FrmShow(new frm자산관리_자산등록());
        }

        private void frm메인_Load(object sender, EventArgs e)
        {
            cls_com.gForm = this;
            초기화();
            메뉴();
            조회_수령대기();
        }

        private void 메뉴()
        {
            m기초코드.Visible = false;
            m자산관리.Visible = false;
            m자산조회.Visible = false;
            m자산불출.Visible = false;
            m자산불출_자산폐기매각.Visible = false;
            m자산실사.Visible = false;
            m소모품관리.Visible = false;
            m소모품조회.Visible = false;
            m소모품입고.Visible = false;
            m소모품불출수령.Visible = false;
            m총관리자.Visible = false;
            if (cls_com.사용자.등급.Equals("총관리자"))
            {
                m기초코드.Visible = true;
                m자산관리.Visible = true;
                m자산조회.Visible = true;
                m자산불출.Visible = true;
                m자산불출_자산폐기매각.Visible = true;
                m자산실사.Visible = true;
                m소모품관리.Visible = true;
                m소모품조회.Visible = true;
                m소모품입고.Visible = true;
                m소모품불출수령.Visible = true;
                m총관리자.Visible = true;
            }
            else if (cls_com.사용자.등급.Equals("관리자") || cls_com.사용자.등급.Equals("자원운영자"))
            {
                if (cls_com.사용자.구분.Equals("자산"))
                {
                    m자산조회.Visible = true;
                    m자산불출.Visible = true;
                    m자산실사.Visible = true;
                }
                else if (cls_com.사용자.구분.Equals("소모품"))
                {
                    m소모품조회.Visible = true;
                    m소모품불출수령.Visible = true;
                }
                else
                {
                    m자산조회.Visible = true;
                    m자산불출.Visible = true;
                    m자산실사.Visible = true;
                    m소모품조회.Visible = true;
                    m소모품불출수령.Visible = true;
                }


            }
        }
        private void 초기화()
        {
            string d = "";
            d = cls_com.ConfigLoad("저장폴더");
            if (d.Equals(""))
            {
                d = "c:\\";
                cls_com.ConfigSave("저장폴더",d);
            }
            cls_com.g저장폴더 = d;

            string 관리부대 = "";
            관리부대 = cls_com.사용자2관리부대(cls_com.사용자.아이디);
            
            cls_com.g프린터 = cls_com.ConfigLoad("프린터");
            tsl1.Text = cls_com.사용자.아이디 + " " + cls_com.사용자.성명 + " " + cls_com.사용자.소속 + " " + cls_com.사용자.등급 + " " + cls_com.사용자.구분 + " " + 관리부대;
            배열만들기();
            배열만들기2();

        }
        private void 배열만들기()
        {
            int i;
            i = 0;
            cls_com.g타이틀[i++] = "자산번호";
            cls_com.g타이틀[i++] = "등록일";
            cls_com.g타이틀[i++] = "상태";
            cls_com.g타이틀[i++] = "설치부대코드";
            cls_com.g타이틀[i++] = "설치부대명";
            cls_com.g타이틀[i++] = "관리번호";
            cls_com.g타이틀[i++] = "시리얼번호";
            cls_com.g타이틀[i++] = "도입년월일";
            cls_com.g타이틀[i++] = "자원분류";
            cls_com.g타이틀[i++] = "제조사";
            cls_com.g타이틀[i++] = "모델명";
            cls_com.g타이틀[i++] = "자원상태";
            cls_com.g타이틀[i++] = "자원관리부대";
            cls_com.g타이틀[i++] = "도입방법";
            cls_com.g타이틀[i++] = "설치부대";
            cls_com.g타이틀[i++] = "설치부대전체경로";
            cls_com.g타이틀[i++] = "설치장소";
            cls_com.g타이틀[i++] = "관리자";
            cls_com.g타이틀[i++] = "사업명";
            cls_com.g타이틀[i++] = "장비명";
            cls_com.g타이틀[i++] = "회계처리여부";
            cls_com.g타이틀[i++] = "자원구분";  // 사용관리번호 대신 대처
            cls_com.g타이틀[i++] = "최종수정일";
            cls_com.g타이틀[i++] = "자원관리부대코드";
            cls_com.g타이틀[i++] = "비고";
            cls_com.g타이틀[i++] = "사용여부";
            cls_com.g타이틀[i++] = "예비여부";
            cls_com.g타이틀_수량 = i;
        }
   
        private void 배열만들기2()
        {
            int i;
            i = 0;
            cls_com.g타이틀2[i++] = "소모품번호";
            cls_com.g타이틀2[i++] = "등록일";
            cls_com.g타이틀2[i++] = "상태";
            cls_com.g타이틀2[i++] = "소모품분류";
            cls_com.g타이틀2[i++] = "제품명";
            cls_com.g타이틀2[i++] = "제조사";
            cls_com.g타이틀2[i++] = "모델명";
            cls_com.g타이틀2_수량 = i;
        }
        private void m기초코드_소속등록_Click(object sender, EventArgs e)
        {
            FrmShow(new frm기초코드_부대등록());
        }

        private void m자산실사_자산실사_Click(object sender, EventArgs e)
        {
            FrmShow(new frm자산실사_자산실사());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!cls_pda.g메세지.Equals(""))
            {
                ts메세지.Text = cls_pda.g메세지;
                cls_pda.g메세지 = "";
            }
        }

        private void m파일_설정_Click(object sender, EventArgs e)
        {
            FrmShow(new frm파일_설정());
        }

        private void m자산불출_자산불출_Click(object sender, EventArgs e)
        {
            FrmShow(new frm자산불출_자산불출());
            조회_수령대기();
        }

        private void m자산관리_DRIMS자산매칭등록_Click(object sender, EventArgs e)
        {
            cls_com.폼_실행(new frm자산관리_DRIMS자산매칭등록());
        }

        private void m총관리자_자산로그조회_Click(object sender, EventArgs e)
        {
            cls_com.폼_실행(new frm총관리자_로그조회("자산"));
        }

        private void m자산불출_자산불입_Click(object sender, EventArgs e)
        {
            FrmShow(new frm자산불출_자산불입());
            조회_수령대기();
        }

        private void m자산불출_자산불출입조회_Click(object sender, EventArgs e)
        {
            FrmShow(new frm자산불출_자산불출입조회());
            조회_수령대기();
        }

        private void m자산실사_자산실사조회_Click(object sender, EventArgs e)
        {
            FrmShow(new frm자산실사_자산실사조회());
        }

        private void m자산조회_운영실태현황_Click(object sender, EventArgs e)
        {
            FrmShow(new frm자산조회_운영실태현황());
        }

        private void m소모품관리_소모품등록_Click(object sender, EventArgs e)
        {
            FrmShow(new frm소모품관리_소모품등록());
        }

        private void m파일_종료_Click(object sender, EventArgs e)
        {
            종료();
        }

        private void 종료()
        {
            Close();
        }


        private void frm메인_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("프로그램을 종료 하시겠습니까 ? ", "프로그램 종료", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel =true ;
            }
        }


        private void m자산조회_Click(object sender, EventArgs e)
        {

        }

        private void m소모품조회_소모품재고조회_Click(object sender, EventArgs e)
        {
            frm소모품조회_소모품재고조회 frm소모품조회_소모품재고조회 = new frm소모품조회_소모품재고조회();
            frm소모품조회_소모품재고조회.Show();
        }

        public  void 조회_수령대기()
        {
            string sql = "",w="";
            DataSet ds;
            if (!cls_com.사용자.등급.Equals("총관리자"))
            {
                w = w + " and a.arm_code in  ( select arm_code from a101_user a left join a101_user_arm b on a.id = b.id where a.id = '" + cls_com.사용자.아이디 + "' )  \n";

            }
            w = w + " and a.state = '불출대기'    \n";

            if (!w.Equals(""))
            {
                w = " where " + w.Substring(4);
            }
            sql = "select count(*) cnt from a201_asset a " + w;
            ds = cls_com.Select_Query(sql);
          //  pan수령대기.Visible = false;
            if (!ds.Tables[0].Rows[0]["cnt"].ToString().Equals("0"))
            {
                pan자산수령대기.Visible = true;
                txt자산수령대기.Text = ds.Tables[0].Rows[0]["cnt"].ToString();
            } else
            {
                pan자산수령대기.Visible = false;
                txt자산수령대기.Text = ds.Tables[0].Rows[0]["cnt"].ToString();

            }


            w = "";
            if (!cls_com.사용자.등급.Equals("총관리자"))
            {
                w = w + " and a.arm_code in  ( select arm_code from a101_user a left join a101_user_arm b on a.id = b.id where a.id = '" + cls_com.사용자.아이디 + "' )  \n";

            }
            w = w + " and a.state = '불출대기'  and a.chk = ''   \n";

            if (!w.Equals(""))
            {
                w = " where " + w.Substring(4);
            }
            sql = "select case when sum(cnt) is null then 0 else sum(cnt) end  cnt from b301_output a " + w;
            ds = cls_com.Select_Query(sql);
            //  pan수령대기.Visible = false;
            if (!ds.Tables[0].Rows[0]["cnt"].ToString().Equals("0"))
            {
                pan소모품수령대기.Visible = true;
                txt소모품수령대기.Text = ds.Tables[0].Rows[0]["cnt"].ToString();
            }
            else
            {
                pan소모품수령대기.Visible = false;
                txt소모품수령대기.Text = ds.Tables[0].Rows[0]["cnt"].ToString();

            }

        }

        private void frm메인_Click(object sender, EventArgs e)
        {
            조회_수령대기();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            FrmShow(new frm자산불출_자산불입());
            조회_수령대기();

        }

        private void m소모품입고_소모품입고_Click(object sender, EventArgs e)
        {
            FrmShow(new frm소모품입고_소모품입고());
            조회_수령대기();
        }

        private void m소모품입고_소모품입고조회_Click(object sender, EventArgs e)
        {
            FrmShow(new frm소모품입고_소모품입고조회());
        }

        private void m소모품불출수령_소모품불출수령조회_Click(object sender, EventArgs e)
        {
            FrmShow(new frm소모품불출수령_소모품불출수령조회());

        }

        private void m소모품불출수령_소모품불출_Click(object sender, EventArgs e)
        {
            FrmShow(new frm소모품불출수령_소모품불출());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FrmShow(new frm소모품불출수령_소모품수령());
            조회_수령대기();
        }

        private void m소모품불출수령_소모품수령_Click(object sender, EventArgs e)
        {
            FrmShow(new frm소모품불출수령_소모품수령());
        }

        private void m자산조회_자산조회_Click(object sender, EventArgs e)
        {

            cls_com.폼_실행여부_자동종료("frm자산조회_자산조회");
            frm자산조회_자산조회 frm자산조회_자산조회 = new frm자산조회_자산조회();
            frm자산조회_자산조회.Show();
        } 

        private void m자산조회_통계_자원분류별_Click(object sender, EventArgs e)
        {
            FrmShow(new frm자산조회_통계_자원분류별());
        }

        private void m총관리자_소모품로그조회_Click(object sender, EventArgs e)
        {
            cls_com.폼_실행(new frm총관리자_로그조회("소모품"));
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            FrmShow(new frm자산조회_자산상세조회());
        }

        private void m자산조회_자산로그_Click(object sender, EventArgs e)
        {
            cls_com.폼_실행여부_자동종료("frm자산조회_자산로그");
            frm자산조회_자산로그 frm자산조회_자산로그 = new frm자산조회_자산로그();
            frm자산조회_자산로그.Show();
        }

        private void m자산불출_자산폐기매각_Click(object sender, EventArgs e)
        {
            FrmShow(new frm자산불출_자산폐기매각());
            조회_수령대기();
        }

        private void m소모품불출수령_소모품소모처리_Click(object sender, EventArgs e)
        {
            FrmShow(new frm소모품불출수령_소모품소모처리());
        }

        private void m파일_메뉴얼다운로드_Click(object sender, EventArgs e)
        {
            메뉴얼_다운로드();
        }

        private void 메뉴얼_다운로드()
        {
            MessageBox.Show("메뉴얼 다운로드 합니다 " + cls_com.gPath + "\\" + cls_com.gFileName_메뉴얼 );
            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                conn = new SqlConnection(cls_com.gConn_String);
                cmd = new SqlCommand("select exe from a101_upgrade where filename = '" + cls_com.gFileName_메뉴얼 + "'" , conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                SqlDataReader dr = (SqlDataReader)cmd.ExecuteReader();

                dr.Read();

                byte[] bImage = (byte[])dr.GetValue(0);


                //   result = (byte[])dr.GetValue(0);

                dr.Close();
                conn.Close();
                conn.Dispose();
                cmd.Dispose();

                FileStream fs = new FileStream(cls_com.gPath + "\\" + cls_com.gFileName_메뉴얼, FileMode.OpenOrCreate, FileAccess.ReadWrite);     // 파일을 열고 닫기 위한 FileStream 초기화
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(bImage);
                bw.Close();
                fs.Close();
                MessageBox.Show("메뉴얼 다운로드 완료 " + cls_com.gPath + "\\" + cls_com.gFileName_메뉴얼);

                // ---------------------------------------------
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " - " + e.StackTrace);
                
            }

        }

    }
}

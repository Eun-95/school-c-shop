
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class Join : Form
    {
        public Join()
        {
            InitializeComponent();

        }
        private Boolean idCheckd = false;
        private Boolean pwCheckd = false;
        private Boolean pwLenCheckd = false;
        Login frm1 = new Login();

        private void pwCheck()
        {
            if (txtPw1.Text == txtPw2.Text) // 비밀번호, 재확인 같을때
            {
                pwCheckd = true;
            }
            else
            {
                pwCheckd = false;
            }
        }

        private void pwLenCheck()
        {
            if (txtPw1.Text.Length >= 5) //사용자명 5자리이상 설정
            {
                pwLenCheckd = true;
            }
            else
            {
                pwLenCheckd = false;
            }
        }
        private void button2_Click(object sender, EventArgs e) //닫기
        {
            frm1.Show(); // 로그인 창 보여주기
            Hide();
        }
        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (idCheckd)   // 중복체크
            {
                pwCheck();
                pwLenCheck();

                if (pwCheckd)   // pw 같은지 체크
                {
                    if (pwLenCheckd) // pw 글자 수 체크
                    {
                        var MConn = new MySqlConnection(frm1.strSql);
                        MConn.Open();

                        string sql = "insert into login(userID, userPassword, userName) values('" + txtId.Text + "', '" + txtPw1.Text + "','" + txtName.Text + "')"; // DB 테이블 login에 저장하기
                        var Comm = new MySqlCommand(sql, MConn);
                        int i = Comm.ExecuteNonQuery();
                        MConn.Close(); //MConn 닫기

                        if (i == 1) //  다 입력한 조건이 되면 실행
                        {

                            frm1.Show(); //로그인 폼 보여주기
                            MessageBox.Show("가입이 완료되었습니다", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information); // 가입 완료 메세지 확인 띄우기
                            Hide();
                        }
                    }


                    else
                    {
                        MessageBox.Show("비밀번호를 5자리 이상으로 설정하세요", "확인", MessageBoxButtons.OK, MessageBoxIcon.Warning); //비밀번호 5자리 이상 쓰도록 설정
                        txtPw1.Clear(); //지우기
                        txtPw2.Clear(); //지우기
                        txtPw1.Focus(); //포커스
                    }
                }
                else
                {
                    MessageBox.Show("비밀번호가 일치하지 않습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPw1.Focus();
                }
            }
            else
            {
                MessageBox.Show("사용자명 중복체크를 해주시기 바랍니다", "확인", MessageBoxButtons.OK, MessageBoxIcon.Warning); //중복체크 하도록 설정
            }
        }
        

        private void idCheck_Click(object sender, EventArgs e) //아이디 중복체크
        {
            var MConn = new MySqlConnection(frm1.strSql);
            MConn.Open();

            if (!idCheckd) 
            {
                if (txtId.Text.Length >= 4)
                {

                    string sql = "select userID, userPassword, userName from login where userID= '" + txtId.Text + "'"; //DB 테이블 login에서 가져오기
                    var Comm = new MySqlCommand(sql, MConn);
                    var myRead = Comm.ExecuteReader();
                    if (myRead.HasRows) // 읽어온 DB값
                    {
                        idCheckd = false;
                        label6.ForeColor = Color.Red; // 색상 레드으로 설정
                        label6.Text = "사용자명 중복";
                    }
                    else
                    {
                        idCheckd = true;
                        label6.ForeColor = Color.Blue; // 가능하면 블루으로 나타나도록 설정
                        label6.Text = "사용자명 가능";
                    }
                }

                else
                {
                    MessageBox.Show("사용자명 4자리 이상 입력하세요", "사용자명 입력", MessageBoxButtons.OK, MessageBoxIcon.Warning); // 사용자명 4자리 이상 입력하도록 설정
                    txtId.Focus(); // 포커스
                }

                MConn.Close(); //닫기
            }
        }
    }
}






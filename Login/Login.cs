using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Login
{
    public partial class Login : Form
    {
        public string strSql = "Server=localhost;Database=cshop;Uid=root;Pwd=rkddkwl125!;SslMode=none"; //DB서버
        public Login()
        {
            InitializeComponent();
        }

        private void Login__Click(object sender, EventArgs e) //로그인 버튼
        {
            var MConn = new MySqlConnection(strSql);
            MConn.Open(); //mySql서버 열기

            if (textBox_userid.Text != "" && textBox_password.Text != "") //사용자명, 비밀번호가 null이 아닐때
            {
                string sql = "select userID, userPassword from login where userID= '" + textBox_userid.Text + "'"; //DB에서 저장된 사용자명, 비밀번호 가져오기
                var Comm = new MySqlCommand(sql, MConn);//MySqlCommand를 이용하여 SQL문장을 저장장고 있는 변수와 
                                                       //MySqlConnection를 이용하여 만들었던 객체를 함께 담아서 명령을 실행한다.
        

                var myRead = Comm.ExecuteReader(); //여러 개의 행과 열을 동시에 가져올 때 사용
                if (myRead.HasRows)
                {
                    if (myRead.Read())
                    {
                        if (myRead["userPassword"].ToString() == textBox_password.Text) //불러온 비밀번호 값과 textBox_password.Text이 같을때
                        {
                            MessageBox.Show("로그인 되었습니다", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information); //로그인 완료, ok 메세지버튼 생성
                            Main mainform = new Main(); 
                            mainform.Show(); //main 폼 보여주기
                            Hide(); // 현재 폼 숨기기
                        }
                        else
                            label3.Text = "암호가 일치하지 않습니다";
                    }
                }
                else
                {
                    label3.Text = "일치하는 계정이 없습니다";
                }
                myRead.Close(); //myRead 닫기
                MConn.Close(); // MConn 닫기
            }
            else
            {
                label3.Text = "아이디와 암호를 입력하세요";
            }
        }

        private void LoginClose_Click(object sender, EventArgs e)
        {
            this.Dispose(); //닫기
            Application.ExitThread(); // 종료
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Join frm2 = new Join(); //회원가입 창
            frm2.Show(); // 보여주기
            Hide();    // 현재 폼 숨기기
        }
    }
}
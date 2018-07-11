
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class Reservation : Form
    {

        public Reservation()
        {
            InitializeComponent();

        }

        string strSql = "Server=localhost;Database=cshop;Uid=root;Pwd=rkddkwl125!;SslMode=none"; //DB서버
        Main main = new Main();

        private void button3_Click(object sender, EventArgs e)
        {


            if (comboBox1.SelectedIndex == 0) // 이미지 나타내기
            {
                pictureBox1.ImageLocation = "C:/Users/은택/source/repos/Login/Login/Resources/" + comboBox1.Text + ".gif"; // 경로설정
            }
            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.ImageLocation = "C:/Users/은택/source/repos/Login/Login/Resources/" + comboBox1.Text + ".gif";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox1.ImageLocation = "C:/Users/은택/source/repos/Login/Login/Resources/" + comboBox1.Text + ".gif";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                pictureBox1.ImageLocation = "C:/Users/은택/source/repos/Login/Login/Resources/" + comboBox1.Text + ".gif";
            }
            if (comboBox1.SelectedIndex == 4)
            {
                pictureBox1.ImageLocation = "C:/Users/은택/source/repos/Login/Login/Resources/" + comboBox1.Text + ".gif";
            }
            if (comboBox1.SelectedIndex == 5)
            {
                pictureBox1.ImageLocation = "C:/Users/은택/source/repos/Login/Login/Resources/" + comboBox1.Text + ".gif";
            }
            if (comboBox1.SelectedIndex == 6)
            {
                pictureBox1.ImageLocation = "C:/Users/은택/source/repos/Login/Login/Resources/" + comboBox1.Text + ".gif";
            }
            if (comboBox1.SelectedIndex == 7)
            {
                pictureBox1.ImageLocation = "C:/Users/은택/source/repos/Login/Login/Resources/" + comboBox1.Text + ".gif";
            }
            if (comboBox1.SelectedIndex == 8)
            {
                pictureBox1.ImageLocation = "C:/Users/은택/source/repos/Login/Login/Resources/" + comboBox1.Text + ".gif";
            }
            if (comboBox1.SelectedIndex == 9)
            {
                pictureBox1.ImageLocation = "C:/Users/은택/source/repos/Login/Login/Resources/" + comboBox1.Text + ".gif";
            }
        }

        private void eixt_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) //예약하기버튼
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "") // 항목들이 null이면
            {
                MessageBox.Show("입력안한 항목이 있습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Warning); // 항목 입력하라는 메세지창 띄우기
            }
            else
            {
                var MConn = new MySqlConnection(strSql);
                MConn.Open();
                string sql = "insert into tour(Destination, ReservationName, BirthDate, PhoneNum, Email, ScheduleDate) values('" + comboBox1.Text + "','" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "','" + textBox5.Text + "')";
                //항목들 입력하면 DB 테이블 tour에 저장
                var Comm = new MySqlCommand(sql, MConn);
                int i = Comm.ExecuteNonQuery();
                MConn.Close();
                if (i == 1)
                {
                    MessageBox.Show("접수가 완료되었습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information); //조건 만족하면 접수완료 메세지 창 띄우기
                    main.Show();
                    Hide();
                }
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e) //캘린더 
        {
            if (monthCalendar1.SelectionRange.Start == monthCalendar1.SelectionRange.End)
                textBox5.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"); //캘린더 선택 시작부분
            else
                textBox5.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "~" + monthCalendar1.SelectionRange.End.ToString("yyyy-MM-dd");//시작부터 ~ 마지막 선택까지
        }
    }
}




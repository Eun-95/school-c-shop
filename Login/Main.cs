using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Login
{
    public partial class Main : Form
    {
        

        public Main()
        {
            InitializeComponent();
        }
      
        private void Main_Load(object sender, EventArgs e)
        {
            v_timer.Start(); //타이머 시작
            v_timer.Enabled = true;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent; //백컬러 투명색으로 설정
        }

        private void v_timer_Tick(object sender, EventArgs e)
        {
            Random rand = new Random(); //랜덤
            int A = rand.Next(0, 255);  //색상
            int R = rand.Next(0, 255);  //색상
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            label1.ForeColor = Color.FromArgb(A, R, G, B);//설정한 A,R,G,B으로 색상 나타내기
        }

        private void First_Click(object sender, EventArgs e)
        {
            Reservation re = new Reservation(); //예약폼
            re.Show(); //예약폼 보여주기
            Hide(); // 현재창 숨기기
        }

        private void Second_Click(object sender, EventArgs e)
        {
            Reservation_details re_d = new Reservation_details(); //예약내역폼
            re_d.Show(); // 보여주기
            Hide(); // 현재창 숨기기
        }
        private void html5_Click(object sender, EventArgs e)
        {
            Process.Start("http://kdw0439.dothome.co.kr/Gapyeong.html"); //홈페이지 주소
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Login login = new Login(); //로그인 폼
            login.Show(); //보여주기
            Hide(); //현재창 숨기기
        }
    }
}


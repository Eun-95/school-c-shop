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
    public partial class Reservation_details : Form
    {

        public Reservation_details()
        {
            InitializeComponent();
        }

        private MySqlConnection connection; //접속
        private MySqlDataAdapter mySqlDataAdapter; // 데이터 어댑터는 데이터베이스에 대한 연결을 효율적으로 관리하고 필요할 때 열거 나 닫는 작업을 담당한다.
        string strSql = "Server=localhost;Database=cshop;Uid=root;Pwd=rkddkwl125!;SslMode=none"; //DB서버

        private bool OpenConnection()
        {

            connection.Open(); //connection 열기
            return true;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)dataGridView1.DataSource).GetChanges();  //.AcceptChanges() 선언한 때부터 변화된 내용만 받음

            if (changes != null) //changes가 null이 아니면 실행
            {
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(mySqlDataAdapter);
                mySqlDataAdapter.UpdateCommand = mcb.GetUpdateCommand();
                mySqlDataAdapter.Update(changes); //update은 데이터 세트에서 데이터베이스로 데이터를 쓰는 것이다.
               ((DataTable)dataGridView1.DataSource).AcceptChanges(); //이 부분에서 부터 변화를 감지한다.
            }
        }
        private bool CloseConnection()//접속닫는 부분
        {

            connection.Close(); //connection 닫기
            return true;
        }

        private void Lookup_Click(object sender, EventArgs e)
        {
            
            connection = new MySqlConnection(strSql);

            if (this.OpenConnection() == true) //DB서버가 true이면 실행
            {
                mySqlDataAdapter = new MySqlDataAdapter("select * from tour", connection); //저장되어 있는 DB 가져오기
                DataSet sql = new DataSet(); //DataSet을 가져온다, DataSet는 데이터를 읽거나 수정하기 위해 데이터가로드되는 영역이므로 여러 테이블의 데이터를 저장할 수 있습니다.
                mySqlDataAdapter.Fill(sql); //Fill은 데이터 세트에 데이터를 기록
                dataGridView1.DataSource = sql.Tables[0]; // DataSource 속성을 설정
                this.CloseConnection();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows) // 선택된 행(Row)삭제하는데 foreach 이용해서 여러 개 선택가능
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=cshop;Uid=root;Pwd=rkddkwl125!;SslMode=none"); //DB서버
                connection.Open();
                string All_Delete = dataGridView1.CurrentCell.Value.ToString();//현재 지울 셀을 선택 받아서 All_Delete에 담는다.
                string sql = "delete from tour where idtour=" + "'" + All_Delete + "'";
                int i = dataGridView1.CurrentCell.RowIndex; // 데이터그리드뷰에서 선택된 열
                dataGridView1.Rows.RemoveAt(item.Index); //datagridview에서 제거할 셀
                var Conn = new MySqlCommand(sql, connection);
                Conn.ExecuteNonQuery();
                connection.Close();


            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            Hide();
        }
    }

}
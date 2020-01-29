using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace checkfee2
{
    public partial class Form1 : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\한윤원\Documents\testfee.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'testfeeDataSet.Table2' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.table2TableAdapter.Fill(this.testfeeDataSet.Table2);

            disp_data();

        }

        private void button1_Click(object sender, EventArgs e) // 저장 기능
        {
     
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("insert into Table2 values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + checkBox1.Checked+ "')",con);
            cmd.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("저장이 완료 되었습니다.");
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            checkBox1.CheckState = 0;
            disp_data();

 
        }

        private void button2_Click(object sender, EventArgs e) // 삭제기능
        {
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("delete from Table2 where name='" + textBox1.Text + "'", con);
            cmd.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("삭제가 완료 되었습니다.");
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            checkBox1.CheckState = 0;
            disp_data();

        }

        private void button3_Click(object sender, EventArgs e) // 수정기능 *코드 재수정 해야함
        {
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("update Table2 set name'" +textBox1.Text+"',studentID='" + textBox2.Text + "',depart='" + comboBox1.Text + "',fee='" + checkBox1.CheckState + "' where name='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "')", con);
            cmd.SelectCommand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("수정이 완료 되었습니다.");
            disp_data();


        }

        private void button4_Click(object sender, EventArgs e) //검색기능 *코드 다시 짜기 아예 재구성 해야함
        {
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select * from Table2 where name='" + textBox3.Text + "'", con);
            cmd.SelectCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            disp_data();

        } 

        public void disp_data() // 디스플레이 
        {
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select * from Table2", con);
            cmd.SelectCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e) 
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}



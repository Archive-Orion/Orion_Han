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


namespace CheckFee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\한윤원\source\repos\CheckFee\CheckFee\FeeDB.mdf;Integrated Security=True");
        public int Id;
        private void save_btn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != String.Empty || studentIDTextBox.Text != String.Empty || departComboBox.Text != String.Empty)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO CheckFeeTable VALUES(@name,@studentID,@depart,@fee)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@studentID", studentIDTextBox.Text);
                cmd.Parameters.AddWithValue("@depart", departComboBox.Text);
                cmd.Parameters.AddWithValue("@fee", feeCheckBox.CheckState);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("저장이 완료 되었습니다.");
                reset_data();
                disp_data();
            }

            else MessageBox.Show("이름이나 학번 혹은 학과가 입력되어있지 않습니다.");
        }

        private void updt_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE CheckFeeTable SET name= @name, studentID=@studentID, depart= @depart, fee=@fee WHERE Id= @Id", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", this.Id);
            cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
            cmd.Parameters.AddWithValue("@studentID", studentIDTextBox.Text);
            cmd.Parameters.AddWithValue("@depart", departComboBox.Text);
            cmd.Parameters.AddWithValue("@fee", feeCheckBox.CheckState);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("수정이 완료 되었습니다.");

            reset_data();
            disp_data();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE CheckFeeTable WHERE Id= @Id", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", this.Id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("삭제가 완료 되었습니다.");

            reset_data();
            disp_data();
        }

        private void srchTextBox_TextChanged(object sender, EventArgs e) //학번으로 검색
        {
            SqlCommand cmd = new SqlCommand("SELECT *  FROM CheckFeeTable WHERE studentID LIKE '" + srchTextBox.Text + "%'", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView1.DataSource = dt;
        }


        public void reset_data()
        {
            Id = 0;
            nameTextBox.Clear();
            studentIDTextBox.Clear();
            departComboBox.SelectedIndex = -1;
            feeCheckBox.CheckState = 0;

            nameTextBox.Focus();
        }
        public void disp_data()
        { 
            SqlCommand cmd = new SqlCommand("select * from CheckFeeTable", con);
            DataTable dt = new DataTable();
          
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Id=Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            nameTextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            studentIDTextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            departComboBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            feeCheckBox.Checked = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[4].Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'feeDBDataSet.CheckFeeTable' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.checkFeeTableTableAdapter.Fill(this.feeDBDataSet.CheckFeeTable);
            disp_data();
        }
    }
}

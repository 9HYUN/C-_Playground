using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


            
namespace test
{
    public partial class Form2 : Form
    {
        string Conn = @"Data Source= STEVEN-PARK\SQLEXPRESS;Initial Catalog=99PLAY;Integrated Security=True";
        //string Conn = "Server=.//SQLEXPRESS;Database=TEST;Integrated security=SSPI";
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                string result = textBox1.Text;
                MessageBox.Show(result);
                
                string result2 = textBox1.ToString();
                
            }
            else
            {
                using (SqlConnection conn2 = new SqlConnection())

                //DB 넣기
                using (MySqlConnection conn = new MySqlConnection(Conn))
                {
                    conn.Open();
                    MySqlCommand msc = new MySqlCommand("INSERT INTO ex118_1(name,age) values('" + textBox1.Text + "','" + textBox2.Text + "')", conn);
                    int result = msc.ExecuteNonQuery();

                    if (result == 1)
                    {
                        MessageBox.Show("추가완료");
                        conn.Close();
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
       
            
            SqlConnection con =  new SqlConnection(Conn);
            //MySqlConnection con =  new MySqlConnection(Conn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOTTO", con);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                dataGridView1.MultiSelect = false;// 한행만 선택
                sda.Update(dbdataset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                new Form3().ShowDialog();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
 
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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

namespace test
{
    public partial class Form2 : Form
    {
        string Conn = "Server=localhost;Database=ex118;Uid=root;Pwd=1234;";
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("내용을 입력해주세요!");
            }
            else
            {
                //DB 넣기
                using (MySqlConnection conn = new MySqlConnection(Conn))
                {
                    conn.Open();
                    MySqlCommand msc = new MySqlCommand("INSERT INTO ex118_1(name,age) values('"+ textBox1.Text +"','"+ textBox2.Text +"')", conn);
                    msc.ExecuteNonQuery();

                    if(msc.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("추가완료");
                    }
                }
            }
        }
    }
}

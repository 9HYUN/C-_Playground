using MySql.Data.MySqlClient;
using System.Net.Sockets;

namespace test
{



    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtlogin.Text == "admin" && txtpass.Text == "1234")
            {
                MessageBox.Show("�α����� �����߽��ϴ�.");
                new Form2().ShowDialog();
            }
            else
            {
                MessageBox.Show("�α��� ����");
            }
            
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
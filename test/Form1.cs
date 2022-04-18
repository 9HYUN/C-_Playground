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
                MessageBox.Show("로그인이 성공했습니다.");
            }
            else
            {
                MessageBox.Show("로그인 실패");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
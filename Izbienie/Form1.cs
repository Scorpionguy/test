namespace Izbienie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            progressBar1.Increment(-1);
            if (progressBar1.Value == 1)
            {
                MessageBox.Show("�� �� ����� ����� �������");
                DialogResult result = DialogResult.OK;
                if (result == DialogResult.OK)
                {
                    Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {}

        public void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            button1.Visible = false;
            timer1.Enabled = true;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 10);
            if (a != Convert.ToInt32(textBox1.Text))
            {
                label2.Text = "�� �������";
            }
            else
            {
                label2.Text = "�� �����.";
                timer1.Stop();
                MessageBox.Show("�� ��������. ������� �� ����� ������� �����");
                DialogResult result = DialogResult.OK;
                if (result == DialogResult.OK)
                {
                    Close();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {}
        private void label3_Click(object sender, EventArgs e)
        {}
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "First Name";
            label2.Text = "School Name";
            progressBar1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value >= 0 && progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
            }
            else progressBar1.Value = 0;
            //MessageBox.Show($"Hello {textBox1.Text} {textBox2.Text}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

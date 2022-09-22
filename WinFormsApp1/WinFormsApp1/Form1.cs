namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button3.Click += Button3_Click;
            button4.Click += delegate {
                MessageBox.Show("способ 4");
            };
            button5.Click += (s,e) => MessageBox.Show("способ 5");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("способ 1");
            
        }

        private void Button3_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("способ 3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("способ 2");
        }
    }
}
namespace wfaSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Click += Button1_Click;
            button2.Click += Button1_Click;
            checkBox1.Click += Button1_Click;
            label1.Click += Button1_Click;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            if (sender is Control c)
                c.Text += "+";
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
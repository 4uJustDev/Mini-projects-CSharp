namespace wfaMethodExt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.TextChanged += (s, e) => label1.Text = textBox1.TextExt();
        }
    }
}
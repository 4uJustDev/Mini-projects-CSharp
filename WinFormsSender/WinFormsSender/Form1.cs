namespace WinFormsSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button_Click;
            button2.Click += Button_Click;
            checkBox1.Click += Button_Click;
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
          
            /*if(sender is Button)
            {
                ((Button)sender).Text += "*";

            }
            if (sender is CheckBox)
            {
                ((CheckBox)sender).Text += "!";

            }*/
            if (sender is Control C)
            {
                C.Text += "!";

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
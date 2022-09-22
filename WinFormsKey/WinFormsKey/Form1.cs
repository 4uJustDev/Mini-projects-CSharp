namespace WinFormsKey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Enter");
                /*throw new NotImplementedException();*/
            }
            switch (e.KeyCode){
                case Keys.Left:
                    LabelText.Text = "left";
                    break;
                case Keys.Right:
                    LabelText.Text = "right";
                    break;
                case Keys.Space:
                    LabelText.Text = e.Shift ? "Shift+Space" : "Space";
                    break;
                default:
                    LabelText.Text = $"Другая клавиша {e.KeyCode}";
                    break;
                    
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
namespace WinFormsControlCreate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.MouseDown += Form1_MouseDown;
           

        }

        Random rnd = new Random();

        private void Form1_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //Label la = new Label();
                //var la = new Label();
                Label la = new();
                la.Location = e.Location;
                la.Text = $"X:{e.X}, Y:{e.Y}";
                la.BackColor = Color.Aqua;
                this.Controls.Add(la);
            }
            if (e.Button == MouseButtons.Right)
            {
                for (int i=0; i<5; i++) { 
                    Label la = new();
                    la.AutoSize = true;

                    la.Location = new Point((rnd.Next(this.ClientSize.Width)), (rnd.Next(this.ClientSize.Height)));
                    la.Text = $"X:{e.X}, Y:{e.Y}";
                    la.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    this.Controls.Add(la);
                }
            }
            if (e.Button == MouseButtons.Middle)
            {
                this.Controls.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
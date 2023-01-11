namespace WinFormsCreate
{
    public partial class Form1 : Form
    {
        private Random rmd = new();
        public Form1()
        {
            InitializeComponent();

            this.MouseDown += Form1_MouseDown;
        }

        private void Form1_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //Label la = new Label();
                //var la = new Label();//� ��� �� ��������� �������� ����, ��� ��� ��� ������ ��������� ����� ����� �����
                Label la = new(); //new ��� ������ ������ ��� label
                la.Location = e.Location;
                la.Text = $"({e.X},{e.Y})";
                la.BackColor = Color.LightGreen;
                //��������� ��������� � ������
                la.AutoSize = true;
                this.Controls.Add(la);
            }
            if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < 10; i++) 
                {
                    Label la = new(); //new ��� ������ ������ ��� label
                    la.Location = new Point(
                        rmd.Next(this.ClientSize.Width),
                        rmd.Next(this.ClientSize.Height));
                    la.Text = $"({e.X},{e.Y})";
                    la.BackColor = Color.FromArgb(rmd.Next(256), rmd.Next(256), rmd.Next(256));
                    //��������� ��������� � ������
                    la.AutoSize = true;
                    this.Controls.Add(la);
                }
                if (e.Button == MouseButtons.Middle) {
                    this.Controls.Clear();
                }
            }
        }
    }
}
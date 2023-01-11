namespace wfaFormTransparency
{
    public partial class Fm : Form
    {
        private Point startPoint;

        public Fm()
        {
            InitializeComponent();

            buClose.Click+= (s, e) => Close();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TransparencyKey = this.BackColor;

            this.MouseDown += (s, e) => startPoint = e.Location;
            this.MouseMove += Fm_MouseMove;
        }

        private void Fm_MouseMove(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(
                this.Location.X + e.X - startPoint.X,
                this.Location.Y + e.Y - startPoint.Y
                );
            }
        }
    }
}
namespace wfaImageScroll
{
    public partial class Form1 : Form
    {
        private Bitmap b;
        private Point startPoint;
        private Point curPoint = new Point(0,0);
        public int NumPic { get; private set; } = 0;
        public int ZoomDelta { get; private set; } = 100;

        public Form1()
        {
            InitializeComponent();
            LoadNextImage();

            pxImage.Paint += (s, e) => e.Graphics.DrawImage(b, curPoint);//paint событие перерисовки
            pxImage.MouseDown += (s, e) => startPoint = e.Location;
            pxImage.MouseMove += PxImage_MouseMove;
            pxImage.MouseWheel += PxImage_MouseWheel;
            this.KeyDown += Form1_KeyDown;
            this.Text += " : Form1 - Следующая картинка";
        }

        private void LoadNextImage()
        {
            NumPic = ++NumPic % 2;
            switch (NumPic)
            {
                case 0:
                    b = new Bitmap(Properties.Resources.city);
                    break;
                case 1:
                    b = new Bitmap(Properties.Resources.city2);
                    break;

            }
            pxImage.Invalidate();
            RefreshStatus();
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    LoadNextImage();
                    break;
            }
        }

        private void PxImage_MouseWheel(object? sender, MouseEventArgs e)
        {
            ZoomDelta += e.Delta < 0 ? 2 : -2;
            //TODO
            pxImage.Invalidate();
            RefreshStatus();
        }

        private void PxImage_MouseMove(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                curPoint.X += e.X - startPoint.X;
                curPoint.Y += e.Y - startPoint.Y;
                startPoint = e.Location;
                pxImage.Invalidate();//сообщаем объекту, что нужно обновить данные
            }

            RefreshStatus();
        }

        private void RefreshStatus()
        {
            laStatus.Text = $"NumPic={NumPic}, startPoint = {startPoint}, curPoint={curPoint}, ZoomDelta={ZoomDelta}";
        }
    }
}
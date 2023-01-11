namespace wfaGraphicSinCos
{
    public partial class Fm : Form
    {
        private const int DOT_WIDHT = 2;
        private const int DOT_HEIGTH = 2;

        public Fm()
        {
            InitializeComponent();

            this.BackgroundImageLayout = ImageLayout.None;
            DrawAll();
            this.Resize += (s, e) => DrawAll();
            this.Text += ": (Sin - красный, Cos - зеленый, Tan - синий)";

            //HW:
            // определить значения sin, cos, tan под курсором
            // вертикальная и горизонтальная линия до курсора
        }

        private void DrawAll()
        {
            var b = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            var g = Graphics.FromImage(b);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            var grCountWave = 5; //кол-во волн
            var grShiftY = b.Height / 2; // смещение по Y
            var grHeight = grShiftY * 0.9; // Половина высоты графика
            var grWidthPI = Math.PI / (b.Width - 1); //Ширина отрезка ПИ в радианах

            //рисуем ось X
            g.DrawLine(new Pen(Color.Black), 0, grShiftY, b.Width, grShiftY);

            for (int i = 1; i < grCountWave; i++)
            {
                var xPoint = b.Width / grCountWave * i;
                g.DrawLine(Pens.Black, xPoint, grShiftY - 5, xPoint, grShiftY + 5);
                g.DrawString($"{i}π", new Font("", 10), new SolidBrush(Color.Black), xPoint - 10, grShiftY + 5);
            }
            
            //рисуем ось Y
            g.DrawLine(new Pen(Color.Black), 0, 0, 0, b.Height);
                  
            //рисование графиков
            float x;
            float y;
            for (int i = 0; i < b.Width; i++)
            {
                //рисуем график sin
                x = i;
                y = (float) (grHeight * (-Math.Sin(i * grCountWave * grWidthPI)) + grShiftY);
                g.FillEllipse(new SolidBrush(Color.Red), x - DOT_WIDHT / 2, y - DOT_HEIGTH / 2, DOT_WIDHT, DOT_HEIGTH);

                //рисуем график cos
                x = i;
                y = (float)(grHeight * (-Math.Cos(i * grCountWave * grWidthPI)) + grShiftY);
                g.FillEllipse(new SolidBrush(Color.Green), x - DOT_WIDHT / 2, y - DOT_HEIGTH / 2, DOT_WIDHT, DOT_HEIGTH);

                //рисуем график tan
                x = i;
                y = (float)(grHeight * (-Math.Tan(i * grCountWave * grWidthPI)) + grShiftY);
                if (y > 0 && y < b.Height)
                    g.FillEllipse(new SolidBrush(Color.Blue), x - DOT_WIDHT / 2, y - DOT_HEIGTH / 2, DOT_WIDHT, DOT_HEIGTH);
            }

            this.BackgroundImage = (Bitmap)b.Clone();

        }
    }
}
namespace wfaPaint
{
    public partial class Form1 : Form
    {
        private enum MyDrawMode
        {
            Pencil,
            Line,
            Ellipse,
            Rectangle,
            Triangle
        }


        private Bitmap b;
        private Graphics g;
        private Point startMouseDown;
        private Bitmap bb;
        private Pen myPen;
        private MyDrawMode myDrawMode = MyDrawMode.Pencil;

        public Form1()
        {
            InitializeComponent();

            b = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            g = Graphics.FromImage(b);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            myPen = new Pen(pxColor1.BackColor, 10);
            myPen.StartCap = myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            pxColor1.Click += (s, e) => myPen.Color = pxColor1.BackColor;
            pxColor2.Click += (s, e) => myPen.Color = pxColor2.BackColor;
            pxColor3.Click += (s, e) => myPen.Color = pxColor3.BackColor;
            pxColor4.Click += (s, e) => myPen.Color = pxColor4.BackColor;
            pxColor5.Click += (s, e) => myPen.Color = pxColor5.BackColor;

            trPenWidth.Value = Convert.ToInt32(myPen.Width);
            trPenWidth.ValueChanged += (s, e) => myPen.Width = trPenWidth.Value;

            pxImage.MouseDown += PxImage_MouseDown;
            pxImage.MouseMove += PxImage_MouseMove;
            pxImage.MouseUp += PxImage_MouseUp;
            pxImage.Paint += (s, e) => e.Graphics.DrawImage(b, 0, 0);

            buImageClear.Click += BuImageClear_Click;
            buImageLoadFromFile.Click += BuImageLoadFromFile_Click;
            buImageSaveToFile.Click += BuImageSaveToFile_Click;
            buImageSaveToClipboard.Click += (s, e) => Clipboard.SetImage(b);

            buDrawPencil.Click += (s, e) => myDrawMode = MyDrawMode.Pencil;
            buDrawLine.Click += (s, e) => myDrawMode = MyDrawMode.Line;
            buDrawTriangle.Click += (s, e) => myDrawMode = MyDrawMode.Triangle;
            buDrawEllipse.Click += (s, e) => myDrawMode = MyDrawMode.Ellipse;
            buDrawRectangle.Click += (s, e) => myDrawMode = MyDrawMode.Rectangle;

            //HW
            //добавить больше функционала похожего на Paint
            //добавить больше фигур (треугольник, стрелки, шестиугольник, ...) [методы расширения]
            //добавить кнопки буфера обмена (вставить, вырезать, ...)
            //добавить рисование левой и правой кнопуой мыши
            //помним про заливку фигур
            //добавить кнопку пипетка [b.GetPixel]
            //выделение и перемещение прямоугольной области
            // ...
        }



        private void BuImageSaveToFile_Click(object? sender, EventArgs e)
        {
            SaveFileDialog dialog = new();
            dialog.Filter = "PNG Files(*.PNG)|*.PNG";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                b.Save(dialog.FileName);
            }
        }

        private void BuImageLoadFromFile_Click(object? sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                g.Clear(DefaultBackColor);
                g.DrawImage(Bitmap.FromFile(dialog.FileName), 0, 0);
                pxImage.Invalidate();
            }
        }

        private void BuImageClear_Click(object? sender, EventArgs e)
        {
            g.Clear(DefaultBackColor);
            pxImage.Invalidate();
        }

        private void PxImage_MouseUp(object? sender, MouseEventArgs e)
        {
            //
        }

        private void PxImage_MouseMove(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //g.DrawLine(myPen, startMouseDown, e.Location);
                //startMouseDown = e.Location;
                switch (myDrawMode)
                {
                    case MyDrawMode.Pencil:
                        g.DrawLine(myPen, startMouseDown, e.Location);
                        startMouseDown = e.Location;
                        break;
                    case MyDrawMode.Line:
                        RestoreBitmap();
                        g.DrawLine(myPen, startMouseDown, e.Location);
                        break;
                    case MyDrawMode.Ellipse:
                        RestoreBitmap();
                        if (ckFillMode.Checked)
                        {
                            g.FillEllipse(new SolidBrush(myPen.Color),
                            new Rectangle(startMouseDown.X, startMouseDown.Y,
                                e.X - startMouseDown.X, e.Y - startMouseDown.Y));
                        }
                        else
                        {
                            g.DrawEllipse(myPen,
                                new Rectangle(startMouseDown.X, startMouseDown.Y,
                                    e.X - startMouseDown.X, e.Y - startMouseDown.Y));
                        }
                        break;
                    case MyDrawMode.Rectangle:
                        RestoreBitmap();
                        if (ckFillMode.Checked)
                        {
                            g.FillRectangle(new SolidBrush(myPen.Color),
                            new Rectangle(startMouseDown.X, startMouseDown.Y,
                                e.X - startMouseDown.X, e.Y - startMouseDown.Y));
                        }
                        else
                        {
                            g.DrawRectangle(myPen,
                                new Rectangle(startMouseDown.X, startMouseDown.Y,
                                    e.X - startMouseDown.X, e.Y - startMouseDown.Y));
                        }
                        break;
                    case MyDrawMode.Triangle:
                        RestoreBitmap();
                        if (ckFillMode.Checked)
                        {
                            PointF pointA = new PointF(e.X, e.Y);
                            PointF pointB = new PointF(startMouseDown.X, startMouseDown.Y);
                            PointF pointC = new PointF(e.X / 2, e.Y);
                            PointF[] arrayName = new PointF[3];
                            arrayName.Prepend(pointA);
                            arrayName.Prepend(pointB);
                            arrayName.Prepend(pointC);
                            g.FillPolygon(new SolidBrush(myPen.Color), arrayName);
                        }
                        else
                        {
                            PointF pointA = new PointF(e.X, e.Y);
                            PointF pointB = new PointF(startMouseDown.X, startMouseDown.Y);
                            PointF pointC = new PointF(e.X/2, e.Y);
                            PointF[] arrayName = new PointF[3];
                            arrayName[0] = pointA;
                            arrayName[1] = pointB;
                            arrayName[2] = pointC;
                            g.DrawPolygon(myPen, arrayName);
                        }
                        break;
                    default:
                        break;

                }
                
                pxImage.Invalidate();
            }
        }

        private void RestoreBitmap()
        {
            g.Dispose();
            b.Dispose();
            b = (Bitmap)bb.Clone();
            g = Graphics.FromImage(b);
        }

        private void PxImage_MouseDown(object? sender, MouseEventArgs e)
        {
            startMouseDown = e.Location;
            bb = (Bitmap)b.Clone();
        }

        private void pxImage_Click(object sender, EventArgs e)
        {

        }
    }

} 


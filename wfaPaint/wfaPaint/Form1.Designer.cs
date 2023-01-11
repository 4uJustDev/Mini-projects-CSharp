namespace wfaPaint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckFillMode = new System.Windows.Forms.CheckBox();
            this.buDrawRectangle = new System.Windows.Forms.Button();
            this.buDrawEllipse = new System.Windows.Forms.Button();
            this.buDrawLine = new System.Windows.Forms.Button();
            this.buDrawTriangle = new System.Windows.Forms.Button();
            this.buDrawPencil = new System.Windows.Forms.Button();
            this.buImageSaveToClipboard = new System.Windows.Forms.Button();
            this.buImageSaveToFile = new System.Windows.Forms.Button();
            this.buImageLoadFromFile = new System.Windows.Forms.Button();
            this.buImageClear = new System.Windows.Forms.Button();
            this.trPenWidth = new System.Windows.Forms.TrackBar();
            this.pxColor5 = new System.Windows.Forms.PictureBox();
            this.pxColor4 = new System.Windows.Forms.PictureBox();
            this.pxColor3 = new System.Windows.Forms.PictureBox();
            this.pxColor2 = new System.Windows.Forms.PictureBox();
            this.pxColor1 = new System.Windows.Forms.PictureBox();
            this.pxImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trPenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxColor5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxColor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxColor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxColor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxColor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckFillMode);
            this.panel1.Controls.Add(this.buDrawRectangle);
            this.panel1.Controls.Add(this.buDrawEllipse);
            this.panel1.Controls.Add(this.buDrawLine);
            this.panel1.Controls.Add(this.buDrawTriangle);
            this.panel1.Controls.Add(this.buDrawPencil);
            this.panel1.Controls.Add(this.buImageSaveToClipboard);
            this.panel1.Controls.Add(this.buImageSaveToFile);
            this.panel1.Controls.Add(this.buImageLoadFromFile);
            this.panel1.Controls.Add(this.buImageClear);
            this.panel1.Controls.Add(this.trPenWidth);
            this.panel1.Controls.Add(this.pxColor5);
            this.panel1.Controls.Add(this.pxColor4);
            this.panel1.Controls.Add(this.pxColor3);
            this.panel1.Controls.Add(this.pxColor2);
            this.panel1.Controls.Add(this.pxColor1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 102);
            this.panel1.TabIndex = 0;
            // 
            // ckFillMode
            // 
            this.ckFillMode.AutoSize = true;
            this.ckFillMode.Location = new System.Drawing.Point(3, 57);
            this.ckFillMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckFillMode.Name = "ckFillMode";
            this.ckFillMode.Size = new System.Drawing.Size(64, 19);
            this.ckFillMode.TabIndex = 15;
            this.ckFillMode.Text = "Залить";
            this.ckFillMode.UseVisualStyleBackColor = true;
            // 
            // buDrawRectangle
            // 
            this.buDrawRectangle.Location = new System.Drawing.Point(417, 54);
            this.buDrawRectangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buDrawRectangle.Name = "buDrawRectangle";
            this.buDrawRectangle.Size = new System.Drawing.Size(115, 22);
            this.buDrawRectangle.TabIndex = 14;
            this.buDrawRectangle.Text = "Прямоугольник";
            this.buDrawRectangle.UseVisualStyleBackColor = true;
            // 
            // buDrawEllipse
            // 
            this.buDrawEllipse.Location = new System.Drawing.Point(417, 28);
            this.buDrawEllipse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buDrawEllipse.Name = "buDrawEllipse";
            this.buDrawEllipse.Size = new System.Drawing.Size(115, 22);
            this.buDrawEllipse.TabIndex = 13;
            this.buDrawEllipse.Text = "Эллипс";
            this.buDrawEllipse.UseVisualStyleBackColor = true;
            // 
            // buDrawLine
            // 
            this.buDrawLine.Location = new System.Drawing.Point(207, 2);
            this.buDrawLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buDrawLine.Name = "buDrawLine";
            this.buDrawLine.Size = new System.Drawing.Size(203, 22);
            this.buDrawLine.TabIndex = 12;
            this.buDrawLine.Text = "Линия";
            this.buDrawLine.UseVisualStyleBackColor = true;
            // 
            // buDrawTriangle
            // 
            this.buDrawTriangle.Location = new System.Drawing.Point(416, 2);
            this.buDrawTriangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buDrawTriangle.Name = "buDrawTriangle";
            this.buDrawTriangle.Size = new System.Drawing.Size(116, 22);
            this.buDrawTriangle.TabIndex = 11;
            this.buDrawTriangle.Text = "Треугольник";
            this.buDrawTriangle.UseVisualStyleBackColor = true;
            // 
            // buDrawPencil
            // 
            this.buDrawPencil.Location = new System.Drawing.Point(207, 28);
            this.buDrawPencil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buDrawPencil.Name = "buDrawPencil";
            this.buDrawPencil.Size = new System.Drawing.Size(203, 22);
            this.buDrawPencil.TabIndex = 10;
            this.buDrawPencil.Text = "Карандаш";
            this.buDrawPencil.UseVisualStyleBackColor = true;
            // 
            // buImageSaveToClipboard
            // 
            this.buImageSaveToClipboard.Location = new System.Drawing.Point(827, 51);
            this.buImageSaveToClipboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buImageSaveToClipboard.Name = "buImageSaveToClipboard";
            this.buImageSaveToClipboard.Size = new System.Drawing.Size(203, 22);
            this.buImageSaveToClipboard.TabIndex = 9;
            this.buImageSaveToClipboard.Text = "Сохранить в ClipBoard";
            this.buImageSaveToClipboard.UseVisualStyleBackColor = true;
            // 
            // buImageSaveToFile
            // 
            this.buImageSaveToFile.Location = new System.Drawing.Point(827, 25);
            this.buImageSaveToFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buImageSaveToFile.Name = "buImageSaveToFile";
            this.buImageSaveToFile.Size = new System.Drawing.Size(203, 22);
            this.buImageSaveToFile.TabIndex = 8;
            this.buImageSaveToFile.Text = "Сохранить в файл";
            this.buImageSaveToFile.UseVisualStyleBackColor = true;
            // 
            // buImageLoadFromFile
            // 
            this.buImageLoadFromFile.Location = new System.Drawing.Point(827, 0);
            this.buImageLoadFromFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buImageLoadFromFile.Name = "buImageLoadFromFile";
            this.buImageLoadFromFile.Size = new System.Drawing.Size(203, 22);
            this.buImageLoadFromFile.TabIndex = 7;
            this.buImageLoadFromFile.Text = "Загрузить из файла";
            this.buImageLoadFromFile.UseVisualStyleBackColor = true;
            // 
            // buImageClear
            // 
            this.buImageClear.Location = new System.Drawing.Point(827, 77);
            this.buImageClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buImageClear.Name = "buImageClear";
            this.buImageClear.Size = new System.Drawing.Size(203, 22);
            this.buImageClear.TabIndex = 6;
            this.buImageClear.Text = "Очистить";
            this.buImageClear.UseVisualStyleBackColor = true;
            // 
            // trPenWidth
            // 
            this.trPenWidth.Location = new System.Drawing.Point(0, 5);
            this.trPenWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trPenWidth.Minimum = 1;
            this.trPenWidth.Name = "trPenWidth";
            this.trPenWidth.Size = new System.Drawing.Size(201, 45);
            this.trPenWidth.TabIndex = 5;
            this.trPenWidth.Value = 1;
            // 
            // pxColor5
            // 
            this.pxColor5.BackColor = System.Drawing.Color.Red;
            this.pxColor5.Location = new System.Drawing.Point(635, 2);
            this.pxColor5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pxColor5.Name = "pxColor5";
            this.pxColor5.Size = new System.Drawing.Size(30, 26);
            this.pxColor5.TabIndex = 4;
            this.pxColor5.TabStop = false;
            // 
            // pxColor4
            // 
            this.pxColor4.BackColor = System.Drawing.Color.Yellow;
            this.pxColor4.Location = new System.Drawing.Point(671, 2);
            this.pxColor4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pxColor4.Name = "pxColor4";
            this.pxColor4.Size = new System.Drawing.Size(30, 26);
            this.pxColor4.TabIndex = 3;
            this.pxColor4.TabStop = false;
            // 
            // pxColor3
            // 
            this.pxColor3.BackColor = System.Drawing.Color.Lime;
            this.pxColor3.Location = new System.Drawing.Point(707, 2);
            this.pxColor3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pxColor3.Name = "pxColor3";
            this.pxColor3.Size = new System.Drawing.Size(30, 26);
            this.pxColor3.TabIndex = 2;
            this.pxColor3.TabStop = false;
            // 
            // pxColor2
            // 
            this.pxColor2.BackColor = System.Drawing.Color.Black;
            this.pxColor2.Location = new System.Drawing.Point(599, 2);
            this.pxColor2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pxColor2.Name = "pxColor2";
            this.pxColor2.Size = new System.Drawing.Size(30, 26);
            this.pxColor2.TabIndex = 1;
            this.pxColor2.TabStop = false;
            // 
            // pxColor1
            // 
            this.pxColor1.BackColor = System.Drawing.Color.Blue;
            this.pxColor1.Location = new System.Drawing.Point(563, 2);
            this.pxColor1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pxColor1.Name = "pxColor1";
            this.pxColor1.Size = new System.Drawing.Size(30, 26);
            this.pxColor1.TabIndex = 0;
            this.pxColor1.TabStop = false;
            // 
            // pxImage
            // 
            this.pxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pxImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pxImage.Location = new System.Drawing.Point(0, 103);
            this.pxImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pxImage.Name = "pxImage";
            this.pxImage.Size = new System.Drawing.Size(1030, 390);
            this.pxImage.TabIndex = 1;
            this.pxImage.TabStop = false;
            this.pxImage.Click += new System.EventHandler(this.pxImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 493);
            this.Controls.Add(this.pxImage);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "wfaPaint";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trPenWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxColor5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxColor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxColor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxColor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxColor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pxImage;
        private TrackBar trPenWidth;
        private PictureBox pxColor5;
        private PictureBox pxColor4;
        private PictureBox pxColor3;
        private PictureBox pxColor2;
        private PictureBox pxColor1;
        private Button buImageSaveToClipboard;
        private Button buImageSaveToFile;
        private Button buImageLoadFromFile;
        private Button buImageClear;
        private CheckBox ckFillMode;
        private Button buDrawRectangle;
        private Button buDrawEllipse;
        private Button buDrawLine;
        private Button buDrawTriangle;
        private Button buDrawPencil;
    }
}
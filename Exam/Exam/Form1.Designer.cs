namespace Exam
{
    partial class Form1
    {
        

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelForArray1 = new System.Windows.Forms.Panel();
            this.panelForArray2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.counterText = new System.Windows.Forms.Label();
            this.lvlText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelForArray1
            // 
            this.panelForArray1.Location = new System.Drawing.Point(42, 78);
            this.panelForArray1.Name = "panelForArray1";
            this.panelForArray1.Size = new System.Drawing.Size(370, 334);
            this.panelForArray1.TabIndex = 0;
            // 
            // panelForArray2
            // 
            this.panelForArray2.Location = new System.Drawing.Point(532, 78);
            this.panelForArray2.Name = "panelForArray2";
            this.panelForArray2.Size = new System.Drawing.Size(370, 334);
            this.panelForArray2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(131, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Совпадают ли местоположение фигур справа и слева? ";
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnYes.Location = new System.Drawing.Point(583, 420);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(94, 40);
            this.btnYes.TabIndex = 3;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNo.Location = new System.Drawing.Point(709, 420);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(94, 40);
            this.btnNo.TabIndex = 4;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // counterText
            // 
            this.counterText.AutoSize = true;
            this.counterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.counterText.Location = new System.Drawing.Point(69, 27);
            this.counterText.Name = "counterText";
            this.counterText.Size = new System.Drawing.Size(131, 20);
            this.counterText.TabIndex = 5;
            this.counterText.Text = "Верно/неверно: ";
            this.counterText.Click += new System.EventHandler(this.label2_Click);
            // 
            // lvlText
            // 
            this.lvlText.AutoSize = true;
            this.lvlText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvlText.Location = new System.Drawing.Point(430, 27);
            this.lvlText.Name = "lvlText";
            this.lvlText.Size = new System.Drawing.Size(64, 25);
            this.lvlText.TabIndex = 6;
            this.lvlText.Text = "LvL: ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(815, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "00:00.000";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvlText);
            this.Controls.Add(this.counterText);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelForArray2);
            this.Controls.Add(this.panelForArray1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelForArray1;
        private System.Windows.Forms.Panel panelForArray2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label counterText;
        private System.Windows.Forms.Label lvlText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}


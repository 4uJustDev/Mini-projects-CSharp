namespace wfaFormTransparency
{
    partial class Fm
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
            this.buClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.buClose.Location = new System.Drawing.Point(900, 900);
            this.buClose.Name = "button1";
            this.buClose.Size = new System.Drawing.Size(94, 29);
            this.buClose.TabIndex = 0;
            this.buClose.Text = "Close";
            this.buClose.UseVisualStyleBackColor = true;
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(0, 0);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::wfaFormTransparency.Properties.Resources.cat;
            this.ClientSize = new System.Drawing.Size(2400, 2200);
            this.Controls.Add(this.buClose);
            this.Name = "Fm";
            this.Text = "wfaFormTransparency";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buClose;
    }
}
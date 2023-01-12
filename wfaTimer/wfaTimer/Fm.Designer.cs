namespace wfaTimer
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
            this.buUp = new System.Windows.Forms.Button();
            this.buUpPause = new System.Windows.Forms.Button();
            this.pbUp = new System.Windows.Forms.ProgressBar();
            this.pbUpMs = new System.Windows.Forms.ProgressBar();
            this.laUpStatus = new System.Windows.Forms.Label();
            this.laDownStatus = new System.Windows.Forms.Label();
            this.pbDownMs = new System.Windows.Forms.ProgressBar();
            this.pbDown = new System.Windows.Forms.ProgressBar();
            this.buDownPause = new System.Windows.Forms.Button();
            this.buDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buUp
            // 
            this.buUp.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buUp.Location = new System.Drawing.Point(10, 9);
            this.buUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buUp.Name = "buUp";
            this.buUp.Size = new System.Drawing.Size(160, 52);
            this.buUp.TabIndex = 0;
            this.buUp.Text = "00:00.000";
            this.buUp.UseVisualStyleBackColor = true;
            this.buUp.Click += new System.EventHandler(this.buUp_Click_1);
            // 
            // buUpPause
            // 
            this.buUpPause.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buUpPause.Location = new System.Drawing.Point(192, 9);
            this.buUpPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buUpPause.Name = "buUpPause";
            this.buUpPause.Size = new System.Drawing.Size(74, 52);
            this.buUpPause.TabIndex = 1;
            this.buUpPause.Text = "⏸";
            this.buUpPause.UseVisualStyleBackColor = true;
            // 
            // pbUp
            // 
            this.pbUp.Location = new System.Drawing.Point(284, 9);
            this.pbUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbUp.Name = "pbUp";
            this.pbUp.Size = new System.Drawing.Size(260, 24);
            this.pbUp.TabIndex = 2;
            // 
            // pbUpMs
            // 
            this.pbUpMs.Location = new System.Drawing.Point(284, 40);
            this.pbUpMs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbUpMs.Name = "pbUpMs";
            this.pbUpMs.Size = new System.Drawing.Size(260, 22);
            this.pbUpMs.TabIndex = 3;
            // 
            // laUpStatus
            // 
            this.laUpStatus.AutoSize = true;
            this.laUpStatus.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laUpStatus.Location = new System.Drawing.Point(561, 14);
            this.laUpStatus.Name = "laUpStatus";
            this.laUpStatus.Size = new System.Drawing.Size(102, 46);
            this.laUpStatus.TabIndex = 4;
            this.laUpStatus.Text = "100%";
            // 
            // laDownStatus
            // 
            this.laDownStatus.AutoSize = true;
            this.laDownStatus.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laDownStatus.Location = new System.Drawing.Point(561, 85);
            this.laDownStatus.Name = "laDownStatus";
            this.laDownStatus.Size = new System.Drawing.Size(102, 46);
            this.laDownStatus.TabIndex = 9;
            this.laDownStatus.Text = "100%";
            // 
            // pbDownMs
            // 
            this.pbDownMs.Location = new System.Drawing.Point(284, 110);
            this.pbDownMs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbDownMs.Name = "pbDownMs";
            this.pbDownMs.Size = new System.Drawing.Size(260, 22);
            this.pbDownMs.TabIndex = 8;
            // 
            // pbDown
            // 
            this.pbDown.Location = new System.Drawing.Point(284, 80);
            this.pbDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbDown.Name = "pbDown";
            this.pbDown.Size = new System.Drawing.Size(260, 24);
            this.pbDown.TabIndex = 7;
            // 
            // buDownPause
            // 
            this.buDownPause.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buDownPause.Location = new System.Drawing.Point(192, 80);
            this.buDownPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buDownPause.Name = "buDownPause";
            this.buDownPause.Size = new System.Drawing.Size(74, 52);
            this.buDownPause.TabIndex = 6;
            this.buDownPause.Text = "⏸";
            this.buDownPause.UseVisualStyleBackColor = true;
            // 
            // buDown
            // 
            this.buDown.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buDown.Location = new System.Drawing.Point(10, 80);
            this.buDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buDown.Name = "buDown";
            this.buDown.Size = new System.Drawing.Size(160, 52);
            this.buDown.TabIndex = 5;
            this.buDown.Text = "00:00.000";
            this.buDown.UseVisualStyleBackColor = true;
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 144);
            this.Controls.Add(this.laDownStatus);
            this.Controls.Add(this.pbDownMs);
            this.Controls.Add(this.pbDown);
            this.Controls.Add(this.buDownPause);
            this.Controls.Add(this.buDown);
            this.Controls.Add(this.laUpStatus);
            this.Controls.Add(this.pbUpMs);
            this.Controls.Add(this.pbUp);
            this.Controls.Add(this.buUpPause);
            this.Controls.Add(this.buUp);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Fm";
            this.Text = "Fm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buUp;
        private Button buUpPause;
        private ProgressBar pbUp;
        private ProgressBar pbUpMs;
        private Label laUpStatus;
        private Label laDownStatus;
        private ProgressBar pbDownMs;
        private ProgressBar pbDown;
        private Button buDownPause;
        private Button buDown;
    }
}
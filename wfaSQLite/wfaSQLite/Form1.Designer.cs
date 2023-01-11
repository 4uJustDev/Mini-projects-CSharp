namespace wfaSQLite
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
            this.edSQL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lvLogs = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.buShowLogs = new System.Windows.Forms.Button();
            this.buShowUsers = new System.Windows.Forms.Button();
            this.buShowCities = new System.Windows.Forms.Button();
            this.buExecuteOne = new System.Windows.Forms.Button();
            this.buExecuteSQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // edSQL
            // 
            this.edSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edSQL.Location = new System.Drawing.Point(311, 32);
            this.edSQL.Multiline = true;
            this.edSQL.Name = "edSQL";
            this.edSQL.Size = new System.Drawing.Size(477, 143);
            this.edSQL.TabIndex = 0;
            this.edSQL.Text = "select count(*) from City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SQL:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(311, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(477, 188);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result:";
            // 
            // lvLogs
            // 
            this.lvLogs.Location = new System.Drawing.Point(12, 32);
            this.lvLogs.Name = "lvLogs";
            this.lvLogs.Size = new System.Drawing.Size(278, 406);
            this.lvLogs.TabIndex = 4;
            this.lvLogs.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Logs";
            // 
            // buShowLogs
            // 
            this.buShowLogs.Location = new System.Drawing.Point(311, 181);
            this.buShowLogs.Name = "buShowLogs";
            this.buShowLogs.Size = new System.Drawing.Size(94, 29);
            this.buShowLogs.TabIndex = 6;
            this.buShowLogs.Text = "Logs";
            this.buShowLogs.UseVisualStyleBackColor = true;
            // 
            // buShowUsers
            // 
            this.buShowUsers.Location = new System.Drawing.Point(408, 181);
            this.buShowUsers.Name = "buShowUsers";
            this.buShowUsers.Size = new System.Drawing.Size(94, 29);
            this.buShowUsers.TabIndex = 7;
            this.buShowUsers.Text = "Users";
            this.buShowUsers.UseVisualStyleBackColor = true;
            // 
            // buShowCities
            // 
            this.buShowCities.Location = new System.Drawing.Point(508, 181);
            this.buShowCities.Name = "buShowCities";
            this.buShowCities.Size = new System.Drawing.Size(94, 29);
            this.buShowCities.TabIndex = 8;
            this.buShowCities.Text = "Cities";
            this.buShowCities.UseVisualStyleBackColor = true;
            // 
            // buExecuteOne
            // 
            this.buExecuteOne.Location = new System.Drawing.Point(608, 181);
            this.buExecuteOne.Name = "buExecuteOne";
            this.buExecuteOne.Size = new System.Drawing.Size(94, 29);
            this.buExecuteOne.TabIndex = 9;
            this.buExecuteOne.Text = "Execute 1";
            this.buExecuteOne.UseVisualStyleBackColor = true;
            // 
            // buExecuteSQL
            // 
            this.buExecuteSQL.Location = new System.Drawing.Point(608, 215);
            this.buExecuteSQL.Name = "buExecuteSQL";
            this.buExecuteSQL.Size = new System.Drawing.Size(94, 29);
            this.buExecuteSQL.TabIndex = 10;
            this.buExecuteSQL.Text = "Execute SQL";
            this.buExecuteSQL.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buExecuteSQL);
            this.Controls.Add(this.buExecuteOne);
            this.Controls.Add(this.buShowCities);
            this.Controls.Add(this.buShowUsers);
            this.Controls.Add(this.buShowLogs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvLogs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edSQL);
            this.Name = "Form1";
            this.Text = "wfaSQLite";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox edSQL;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private ListView lvLogs;
        private Label label3;
        private Button buShowLogs;
        private Button buShowUsers;
        private Button buShowCities;
        private Button buExecuteOne;
        private Button buExecuteSQL;
    }
}
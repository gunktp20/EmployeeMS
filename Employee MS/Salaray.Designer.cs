namespace Employee_MS
{
    partial class Salaray
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Eid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.En = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Ep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Wd = new System.Windows.Forms.TextBox();
            this.SS = new System.Windows.Forms.RichTextBox();
            this.FetchBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.CrossBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Employee_MS.Properties.Resources.salary;
            this.pictureBox5.Location = new System.Drawing.Point(22, 31);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(107, 88);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "View";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "EmployeeId";
            // 
            // Eid
            // 
            this.Eid.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Eid.Location = new System.Drawing.Point(276, 175);
            this.Eid.Margin = new System.Windows.Forms.Padding(4);
            this.Eid.Name = "Eid";
            this.Eid.Size = new System.Drawing.Size(189, 22);
            this.Eid.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 257);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 31);
            this.label7.TabIndex = 23;
            this.label7.Text = "Employee Name";
            // 
            // En
            // 
            this.En.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.En.Location = new System.Drawing.Point(276, 265);
            this.En.Margin = new System.Windows.Forms.Padding(4);
            this.En.Name = "En";
            this.En.Size = new System.Drawing.Size(189, 22);
            this.En.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 345);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 31);
            this.label4.TabIndex = 25;
            this.label4.Text = "Employee Position";
            // 
            // Ep
            // 
            this.Ep.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Ep.Location = new System.Drawing.Point(276, 352);
            this.Ep.Margin = new System.Windows.Forms.Padding(4);
            this.Ep.Name = "Ep";
            this.Ep.Size = new System.Drawing.Size(189, 22);
            this.Ep.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 433);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 31);
            this.label3.TabIndex = 27;
            this.label3.Text = "Working Days";
            // 
            // Wd
            // 
            this.Wd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Wd.Location = new System.Drawing.Point(276, 441);
            this.Wd.Margin = new System.Windows.Forms.Padding(4);
            this.Wd.Name = "Wd";
            this.Wd.Size = new System.Drawing.Size(189, 22);
            this.Wd.TabIndex = 28;
            // 
            // SS
            // 
            this.SS.BackColor = System.Drawing.Color.White;
            this.SS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SS.Location = new System.Drawing.Point(569, 113);
            this.SS.Margin = new System.Windows.Forms.Padding(4);
            this.SS.Name = "SS";
            this.SS.Size = new System.Drawing.Size(572, 482);
            this.SS.TabIndex = 29;
            this.SS.Text = "";
            this.SS.TextChanged += new System.EventHandler(this.SS_TextChanged);
            // 
            // FetchBtn
            // 
            this.FetchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FetchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FetchBtn.Location = new System.Drawing.Point(23, 527);
            this.FetchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.FetchBtn.Name = "FetchBtn";
            this.FetchBtn.Size = new System.Drawing.Size(137, 43);
            this.FetchBtn.TabIndex = 31;
            this.FetchBtn.Text = "Fetch Data";
            this.FetchBtn.UseVisualStyleBackColor = true;
            this.FetchBtn.Click += new System.EventHandler(this.FetchBtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.Location = new System.Drawing.Point(221, 527);
            this.viewBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(137, 43);
            this.viewBtn.TabIndex = 32;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.Location = new System.Drawing.Point(424, 527);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(137, 43);
            this.HomeBtn.TabIndex = 33;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click_1);
            // 
            // CrossBtn
            // 
            this.CrossBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CrossBtn.Location = new System.Drawing.Point(1131, 0);
            this.CrossBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CrossBtn.Name = "CrossBtn";
            this.CrossBtn.Size = new System.Drawing.Size(44, 43);
            this.CrossBtn.TabIndex = 37;
            this.CrossBtn.Text = "X";
            this.CrossBtn.UseVisualStyleBackColor = true;
            this.CrossBtn.Click += new System.EventHandler(this.CrossBtn_Click_1);
            // 
            // Salaray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 702);
            this.Controls.Add(this.CrossBtn);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.FetchBtn);
            this.Controls.Add(this.SS);
            this.Controls.Add(this.Wd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.En);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Eid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Salaray";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salaray";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Eid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox En;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Ep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Wd;
        private System.Windows.Forms.RichTextBox SS;
        private System.Windows.Forms.Button FetchBtn;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button CrossBtn;
    }
}
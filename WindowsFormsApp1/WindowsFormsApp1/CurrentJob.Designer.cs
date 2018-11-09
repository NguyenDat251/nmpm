namespace WindowsFormsApp1
{
    partial class CurrentJob
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
            this.pictBLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbCom = new System.Windows.Forms.Label();
            this.lbSalary = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbLang = new System.Windows.Forms.Label();
            this.txtBDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictBLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictBLogo
            // 
            this.pictBLogo.Location = new System.Drawing.Point(12, 54);
            this.pictBLogo.Name = "pictBLogo";
            this.pictBLogo.Size = new System.Drawing.Size(80, 80);
            this.pictBLogo.TabIndex = 0;
            this.pictBLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbLang);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbSalary);
            this.panel1.Controls.Add(this.lbCom);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(116, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 106);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(72, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ứng tuyển";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Trở lại";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtBDescription);
            this.panel2.Location = new System.Drawing.Point(47, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 160);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Công việc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Công ty:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lương:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(64, 10);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "label4";
            // 
            // lbCom
            // 
            this.lbCom.AutoSize = true;
            this.lbCom.Location = new System.Drawing.Point(64, 32);
            this.lbCom.Name = "lbCom";
            this.lbCom.Size = new System.Drawing.Size(35, 13);
            this.lbCom.TabIndex = 4;
            this.lbCom.Text = "label5";
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Location = new System.Drawing.Point(64, 56);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(35, 13);
            this.lbSalary.TabIndex = 5;
            this.lbSalary.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngôn ngữ:";
            //this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbLang
            // 
            this.lbLang.AutoSize = true;
            this.lbLang.Location = new System.Drawing.Point(64, 79);
            this.lbLang.Name = "lbLang";
            this.lbLang.Size = new System.Drawing.Size(35, 13);
            this.lbLang.TabIndex = 7;
            this.lbLang.Text = "label8";
            // 
            // txtBDescription
            // 
            this.txtBDescription.Location = new System.Drawing.Point(0, 43);
            this.txtBDescription.Multiline = true;
            this.txtBDescription.Name = "txtBDescription";
            this.txtBDescription.Size = new System.Drawing.Size(329, 116);
            this.txtBDescription.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "Yêu cầu:";
            // 
            // CurrentJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 393);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictBLogo);
            this.Name = "CurrentJob";
            this.Text = "CurrentJob";
            ((System.ComponentModel.ISupportInitialize)(this.pictBLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbLang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Label lbCom;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBDescription;
    }
}
//namespace WindowsFormsApp1
//{
//    partial class Form1
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.panel6 = new System.Windows.Forms.Panel();
//            this.btnBACK = new System.Windows.Forms.Button();
//            this.btnNEXT = new System.Windows.Forms.Button();
//            this.tc = new System.Windows.Forms.TabControl();
//            this.tcJob = new System.Windows.Forms.TabPage();
//            this.tcEmployee = new System.Windows.Forms.TabPage();
//            this.panel12 = new System.Windows.Forms.Panel();
//            this.btnNxt = new System.Windows.Forms.Button();
//            this.btnPre = new System.Windows.Forms.Button();
//            this.panel7 = new System.Windows.Forms.Panel();
//            this.pnlApply4 = new System.Windows.Forms.Panel();
//            this.lbJob4 = new System.Windows.Forms.Label();
//            this.button7 = new System.Windows.Forms.Button();
//            this.button8 = new System.Windows.Forms.Button();
//            this.lbCandidate4 = new System.Windows.Forms.Label();
//            this.button9 = new System.Windows.Forms.Button();
//            this.pnlApply3 = new System.Windows.Forms.Panel();
//            this.lbJob3 = new System.Windows.Forms.Label();
//            this.button4 = new System.Windows.Forms.Button();
//            this.button5 = new System.Windows.Forms.Button();
//            this.lbCandidate3 = new System.Windows.Forms.Label();
//            this.button6 = new System.Windows.Forms.Button();
//            this.pnlApply2 = new System.Windows.Forms.Panel();
//            this.lbJob2 = new System.Windows.Forms.Label();
//            this.button1 = new System.Windows.Forms.Button();
//            this.button2 = new System.Windows.Forms.Button();
//            this.lbCandidate2 = new System.Windows.Forms.Label();
//            this.button3 = new System.Windows.Forms.Button();
//            this.pnlApply1 = new System.Windows.Forms.Panel();
//            this.lbJob1 = new System.Windows.Forms.Label();
//            this.btn3 = new System.Windows.Forms.Button();
//            this.btn2 = new System.Windows.Forms.Button();
//            this.lbCandidate1 = new System.Windows.Forms.Label();
//            this.btn1 = new System.Windows.Forms.Button();
//            this.lbUngTuyen = new System.Windows.Forms.Label();
//            this.btnAddJob = new System.Windows.Forms.Button();
//            this.tcAdmin = new System.Windows.Forms.TabPage();
//            this.button12 = new System.Windows.Forms.Button();
//            this.button11 = new System.Windows.Forms.Button();
//            this.button10 = new System.Windows.Forms.Button();
//            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
//            this.pictureBox1 = new System.Windows.Forms.PictureBox();
//            this.label1 = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.panel6.SuspendLayout();
//            this.tc.SuspendLayout();
//            this.tcJob.SuspendLayout();
//            this.tcEmployee.SuspendLayout();
//            this.panel12.SuspendLayout();
//            this.panel7.SuspendLayout();
//            this.pnlApply4.SuspendLayout();
//            this.pnlApply3.SuspendLayout();
//            this.pnlApply2.SuspendLayout();
//            this.pnlApply1.SuspendLayout();
//            this.tcAdmin.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // panel6
//            // 
//            this.panel6.Controls.Add(this.btnBACK);
//            this.panel6.Controls.Add(this.btnNEXT);
//            this.panel6.Location = new System.Drawing.Point(355, 474);
//            this.panel6.Name = "panel6";
//            this.panel6.Size = new System.Drawing.Size(146, 40);
//            this.panel6.TabIndex = 3;
//            // 
//            // btnBACK
//            // 
//            this.btnBACK.Location = new System.Drawing.Point(3, 0);
//            this.btnBACK.Name = "btnBACK";
//            this.btnBACK.Size = new System.Drawing.Size(67, 39);
//            this.btnBACK.TabIndex = 1;
//            this.btnBACK.Text = "BACK";
//            this.btnBACK.UseVisualStyleBackColor = true;
//            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
//            // 
//            // btnNEXT
//            // 
//            this.btnNEXT.Location = new System.Drawing.Point(76, 0);
//            this.btnNEXT.Name = "btnNEXT";
//            this.btnNEXT.Size = new System.Drawing.Size(67, 39);
//            this.btnNEXT.TabIndex = 0;
//            this.btnNEXT.Text = "NEXT";
//            this.btnNEXT.UseVisualStyleBackColor = true;
//            this.btnNEXT.Click += new System.EventHandler(this.btnNEXT_Click);
//            // 
//            // tc
//            // 
//            this.tc.Controls.Add(this.tcJob);
//            this.tc.Controls.Add(this.tcEmployee);
//            this.tc.Controls.Add(this.tcAdmin);
//            this.tc.Location = new System.Drawing.Point(3, 1);
//            this.tc.Name = "tc";
//            this.tc.SelectedIndex = 0;
//            this.tc.Size = new System.Drawing.Size(533, 546);
//            this.tc.TabIndex = 4;
//            // 
//            // tcJob
//            // 
//            this.tcJob.BackColor = System.Drawing.Color.Gainsboro;
//            this.tcJob.Controls.Add(this.panel6);
//            this.tcJob.Location = new System.Drawing.Point(4, 22);
//            this.tcJob.Name = "tcJob";
//            this.tcJob.Padding = new System.Windows.Forms.Padding(3);
//            this.tcJob.Size = new System.Drawing.Size(525, 520);
//            this.tcJob.TabIndex = 0;
//            this.tcJob.Text = "Công việc";
//            this.tcJob.Click += new System.EventHandler(this.tabPage1_Click);
//            // 
//            // tcEmployee
//            // 
//            this.tcEmployee.Controls.Add(this.panel12);
//            this.tcEmployee.Controls.Add(this.panel7);
//            this.tcEmployee.Controls.Add(this.lbUngTuyen);
//            this.tcEmployee.Controls.Add(this.btnAddJob);
//            this.tcEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
//            this.tcEmployee.Location = new System.Drawing.Point(4, 22);
//            this.tcEmployee.Name = "tcEmployee";
//            this.tcEmployee.Padding = new System.Windows.Forms.Padding(3);
//            this.tcEmployee.Size = new System.Drawing.Size(525, 520);
//            this.tcEmployee.TabIndex = 1;
//            this.tcEmployee.Text = "Employee";
//            this.tcEmployee.UseVisualStyleBackColor = true;
//            // 
//            // panel12
//            // 
//            this.panel12.Controls.Add(this.btnNxt);
//            this.panel12.Controls.Add(this.btnPre);
//            this.panel12.Location = new System.Drawing.Point(352, 410);
//            this.panel12.Name = "panel12";
//            this.panel12.Size = new System.Drawing.Size(163, 63);
//            this.panel12.TabIndex = 8;
//            // 
//            // btnNxt
//            // 
//            this.btnNxt.Location = new System.Drawing.Point(85, 3);
//            this.btnNxt.Name = "btnNxt";
//            this.btnNxt.Size = new System.Drawing.Size(75, 57);
//            this.btnNxt.TabIndex = 8;
//            this.btnNxt.Text = "Tiếp";
//            this.btnNxt.UseVisualStyleBackColor = true;
//            this.btnNxt.Click += new System.EventHandler(this.btnNxt_Click);
//            // 
//            // btnPre
//            // 
//            this.btnPre.Location = new System.Drawing.Point(3, 3);
//            this.btnPre.Name = "btnPre";
//            this.btnPre.Size = new System.Drawing.Size(75, 57);
//            this.btnPre.TabIndex = 7;
//            this.btnPre.Text = "Lùi";
//            this.btnPre.UseVisualStyleBackColor = true;
//            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
//            // 
//            // panel7
//            // 
//            this.panel7.BackColor = System.Drawing.Color.MistyRose;
//            this.panel7.Controls.Add(this.pnlApply4);
//            this.panel7.Controls.Add(this.pnlApply3);
//            this.panel7.Controls.Add(this.pnlApply2);
//            this.panel7.Controls.Add(this.pnlApply1);
//            this.panel7.Location = new System.Drawing.Point(6, 107);
//            this.panel7.Name = "panel7";
//            this.panel7.Size = new System.Drawing.Size(512, 297);
//            this.panel7.TabIndex = 2;
//            // 
//            // pnlApply4
//            // 
//            this.pnlApply4.BackColor = System.Drawing.Color.Snow;
//            this.pnlApply4.Controls.Add(this.lbJob4);
//            this.pnlApply4.Controls.Add(this.button7);
//            this.pnlApply4.Controls.Add(this.button8);
//            this.pnlApply4.Controls.Add(this.lbCandidate4);
//            this.pnlApply4.Controls.Add(this.button9);
//            this.pnlApply4.Location = new System.Drawing.Point(0, 228);
//            this.pnlApply4.Name = "pnlApply4";
//            this.pnlApply4.Size = new System.Drawing.Size(509, 69);
//            this.pnlApply4.TabIndex = 8;
//            // 
//            // lbJob4
//            // 
//            this.lbJob4.AutoSize = true;
//            this.lbJob4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lbJob4.Location = new System.Drawing.Point(3, 34);
//            this.lbJob4.Name = "lbJob4";
//            this.lbJob4.Size = new System.Drawing.Size(70, 25);
//            this.lbJob4.TabIndex = 5;
//            this.lbJob4.Text = "label7";
//            // 
//            // button7
//            // 
//            this.button7.BackColor = System.Drawing.Color.Red;
//            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
//            this.button7.Location = new System.Drawing.Point(434, 0);
//            this.button7.Name = "button7";
//            this.button7.Size = new System.Drawing.Size(75, 69);
//            this.button7.TabIndex = 4;
//            this.button7.Text = "Loại";
//            this.button7.UseVisualStyleBackColor = false;
//            // 
//            // button8
//            // 
//            this.button8.BackColor = System.Drawing.Color.Chartreuse;
//            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
//            this.button8.Location = new System.Drawing.Point(353, 0);
//            this.button8.Name = "button8";
//            this.button8.Size = new System.Drawing.Size(75, 69);
//            this.button8.TabIndex = 4;
//            this.button8.Text = "Đồng ý";
//            this.button8.UseVisualStyleBackColor = false;
//            // 
//            // lbCandidate4
//            // 
//            this.lbCandidate4.AutoSize = true;
//            this.lbCandidate4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lbCandidate4.Location = new System.Drawing.Point(3, 9);
//            this.lbCandidate4.Name = "lbCandidate4";
//            this.lbCandidate4.Size = new System.Drawing.Size(70, 25);
//            this.lbCandidate4.TabIndex = 0;
//            this.lbCandidate4.Text = "label8";
//            // 
//            // button9
//            // 
//            this.button9.Location = new System.Drawing.Point(272, 0);
//            this.button9.Name = "button9";
//            this.button9.Size = new System.Drawing.Size(75, 69);
//            this.button9.TabIndex = 4;
//            this.button9.Text = "Xem CV";
//            this.button9.UseVisualStyleBackColor = true;
//            // 
//            // pnlApply3
//            // 
//            this.pnlApply3.BackColor = System.Drawing.Color.Snow;
//            this.pnlApply3.Controls.Add(this.lbJob3);
//            this.pnlApply3.Controls.Add(this.button4);
//            this.pnlApply3.Controls.Add(this.button5);
//            this.pnlApply3.Controls.Add(this.lbCandidate3);
//            this.pnlApply3.Controls.Add(this.button6);
//            this.pnlApply3.Location = new System.Drawing.Point(0, 150);
//            this.pnlApply3.Name = "pnlApply3";
//            this.pnlApply3.Size = new System.Drawing.Size(509, 69);
//            this.pnlApply3.TabIndex = 7;
//            // 
//            // lbJob3
//            // 
//            this.lbJob3.AutoSize = true;
//            this.lbJob3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lbJob3.Location = new System.Drawing.Point(3, 34);
//            this.lbJob3.Name = "lbJob3";
//            this.lbJob3.Size = new System.Drawing.Size(70, 25);
//            this.lbJob3.TabIndex = 5;
//            this.lbJob3.Text = "label5";
//            // 
//            // button4
//            // 
//            this.button4.BackColor = System.Drawing.Color.Red;
//            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
//            this.button4.Location = new System.Drawing.Point(434, 0);
//            this.button4.Name = "button4";
//            this.button4.Size = new System.Drawing.Size(75, 69);
//            this.button4.TabIndex = 4;
//            this.button4.Text = "Loại";
//            this.button4.UseVisualStyleBackColor = false;
//            // 
//            // button5
//            // 
//            this.button5.BackColor = System.Drawing.Color.Chartreuse;
//            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
//            this.button5.Location = new System.Drawing.Point(353, 0);
//            this.button5.Name = "button5";
//            this.button5.Size = new System.Drawing.Size(75, 69);
//            this.button5.TabIndex = 4;
//            this.button5.Text = "Đồng ý";
//            this.button5.UseVisualStyleBackColor = false;
//            // 
//            // lbCandidate3
//            // 
//            this.lbCandidate3.AutoSize = true;
//            this.lbCandidate3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lbCandidate3.Location = new System.Drawing.Point(3, 9);
//            this.lbCandidate3.Name = "lbCandidate3";
//            this.lbCandidate3.Size = new System.Drawing.Size(70, 25);
//            this.lbCandidate3.TabIndex = 0;
//            this.lbCandidate3.Text = "label6";
//            // 
//            // button6
//            // 
//            this.button6.Location = new System.Drawing.Point(272, 0);
//            this.button6.Name = "button6";
//            this.button6.Size = new System.Drawing.Size(75, 69);
//            this.button6.TabIndex = 4;
//            this.button6.Text = "Xem CV";
//            this.button6.UseVisualStyleBackColor = true;
//            // 
//            // pnlApply2
//            // 
//            this.pnlApply2.BackColor = System.Drawing.Color.Snow;
//            this.pnlApply2.Controls.Add(this.lbJob2);
//            this.pnlApply2.Controls.Add(this.button1);
//            this.pnlApply2.Controls.Add(this.button2);
//            this.pnlApply2.Controls.Add(this.lbCandidate2);
//            this.pnlApply2.Controls.Add(this.button3);
//            this.pnlApply2.Location = new System.Drawing.Point(0, 75);
//            this.pnlApply2.Name = "pnlApply2";
//            this.pnlApply2.Size = new System.Drawing.Size(509, 69);
//            this.pnlApply2.TabIndex = 6;
//            // 
//            // lbJob2
//            // 
//            this.lbJob2.AutoSize = true;
//            this.lbJob2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lbJob2.Location = new System.Drawing.Point(3, 34);
//            this.lbJob2.Name = "lbJob2";
//            this.lbJob2.Size = new System.Drawing.Size(70, 25);
//            this.lbJob2.TabIndex = 5;
//            this.lbJob2.Text = "label3";
//            // 
//            // button1
//            // 
//            this.button1.BackColor = System.Drawing.Color.Red;
//            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
//            this.button1.Location = new System.Drawing.Point(434, 0);
//            this.button1.Name = "button1";
//            this.button1.Size = new System.Drawing.Size(75, 69);
//            this.button1.TabIndex = 4;
//            this.button1.Text = "Loại";
//            this.button1.UseVisualStyleBackColor = false;
//            // 
//            // button2
//            // 
//            this.button2.BackColor = System.Drawing.Color.Chartreuse;
//            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
//            this.button2.Location = new System.Drawing.Point(353, 0);
//            this.button2.Name = "button2";
//            this.button2.Size = new System.Drawing.Size(75, 69);
//            this.button2.TabIndex = 4;
//            this.button2.Text = "Đồng ý";
//            this.button2.UseVisualStyleBackColor = false;
//            // 
//            // lbCandidate2
//            // 
//            this.lbCandidate2.AutoSize = true;
//            this.lbCandidate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lbCandidate2.Location = new System.Drawing.Point(3, 9);
//            this.lbCandidate2.Name = "lbCandidate2";
//            this.lbCandidate2.Size = new System.Drawing.Size(70, 25);
//            this.lbCandidate2.TabIndex = 0;
//            this.lbCandidate2.Text = "label4";
//            // 
//            // button3
//            // 
//            this.button3.Location = new System.Drawing.Point(272, 0);
//            this.button3.Name = "button3";
//            this.button3.Size = new System.Drawing.Size(75, 69);
//            this.button3.TabIndex = 4;
//            this.button3.Text = "Xem CV";
//            this.button3.UseVisualStyleBackColor = true;
//            // 
//            // pnlApply1
//            // 
//            this.pnlApply1.BackColor = System.Drawing.Color.Snow;
//            this.pnlApply1.Controls.Add(this.lbJob1);
//            this.pnlApply1.Controls.Add(this.btn3);
//            this.pnlApply1.Controls.Add(this.btn2);
//            this.pnlApply1.Controls.Add(this.lbCandidate1);
//            this.pnlApply1.Controls.Add(this.btn1);
//            this.pnlApply1.Location = new System.Drawing.Point(0, 0);
//            this.pnlApply1.Name = "pnlApply1";
//            this.pnlApply1.Size = new System.Drawing.Size(509, 69);
//            this.pnlApply1.TabIndex = 5;
//            // 
//            // lbJob1
//            // 
//            this.lbJob1.AutoSize = true;
//            this.lbJob1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lbJob1.Location = new System.Drawing.Point(3, 34);
//            this.lbJob1.Name = "lbJob1";
//            this.lbJob1.Size = new System.Drawing.Size(70, 25);
//            this.lbJob1.TabIndex = 5;
//            this.lbJob1.Text = "label2";
//            // 
//            // btn3
//            // 
//            this.btn3.BackColor = System.Drawing.Color.Red;
//            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
//            this.btn3.Location = new System.Drawing.Point(434, 0);
//            this.btn3.Name = "btn3";
//            this.btn3.Size = new System.Drawing.Size(75, 69);
//            this.btn3.TabIndex = 4;
//            this.btn3.Text = "Loại";
//            this.btn3.UseVisualStyleBackColor = false;
//            // 
//            // btn2
//            // 
//            this.btn2.BackColor = System.Drawing.Color.Chartreuse;
//            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
//            this.btn2.Location = new System.Drawing.Point(353, 0);
//            this.btn2.Name = "btn2";
//            this.btn2.Size = new System.Drawing.Size(75, 69);
//            this.btn2.TabIndex = 4;
//            this.btn2.Text = "Đồng ý";
//            this.btn2.UseVisualStyleBackColor = false;
//            // 
//            // lbCandidate1
//            // 
//            this.lbCandidate1.AutoSize = true;
//            this.lbCandidate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lbCandidate1.Location = new System.Drawing.Point(3, 9);
//            this.lbCandidate1.Name = "lbCandidate1";
//            this.lbCandidate1.Size = new System.Drawing.Size(70, 25);
//            this.lbCandidate1.TabIndex = 0;
//            this.lbCandidate1.Text = "label1";
//            // 
//            // btn1
//            // 
//            this.btn1.Location = new System.Drawing.Point(272, 0);
//            this.btn1.Name = "btn1";
//            this.btn1.Size = new System.Drawing.Size(75, 69);
//            this.btn1.TabIndex = 4;
//            this.btn1.Text = "Xem CV";
//            this.btn1.UseVisualStyleBackColor = true;
//            // 
//            // lbUngTuyen
//            // 
//            this.lbUngTuyen.AutoSize = true;
//            this.lbUngTuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lbUngTuyen.Location = new System.Drawing.Point(149, 79);
//            this.lbUngTuyen.Name = "lbUngTuyen";
//            this.lbUngTuyen.Size = new System.Drawing.Size(221, 25);
//            this.lbUngTuyen.TabIndex = 1;
//            this.lbUngTuyen.Text = "Danh sách ứng viên";
//            // 
//            // btnAddJob
//            // 
//            this.btnAddJob.BackColor = System.Drawing.Color.Red;
//            this.btnAddJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnAddJob.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
//            this.btnAddJob.Location = new System.Drawing.Point(6, 6);
//            this.btnAddJob.Name = "btnAddJob";
//            this.btnAddJob.Size = new System.Drawing.Size(512, 61);
//            this.btnAddJob.TabIndex = 0;
//            this.btnAddJob.Text = "Đăng việc";
//            this.btnAddJob.UseVisualStyleBackColor = false;
//            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
//            // 
//            // tcAdmin
//            // 
//            this.tcAdmin.Controls.Add(this.button12);
//            this.tcAdmin.Controls.Add(this.button11);
//            this.tcAdmin.Controls.Add(this.button10);
//            this.tcAdmin.Location = new System.Drawing.Point(4, 22);
//            this.tcAdmin.Name = "tcAdmin";
//            this.tcAdmin.Padding = new System.Windows.Forms.Padding(3);
//            this.tcAdmin.Size = new System.Drawing.Size(525, 520);
//            this.tcAdmin.TabIndex = 2;
//            this.tcAdmin.Text = "Admin";
//            this.tcAdmin.UseVisualStyleBackColor = true;
//            this.tcAdmin.Click += new System.EventHandler(this.tcAdmin_Click);
//            // 
//            // button12
//            // 
//            this.button12.Location = new System.Drawing.Point(211, 6);
//            this.button12.Name = "button12";
//            this.button12.Size = new System.Drawing.Size(98, 24);
//            this.button12.TabIndex = 2;
//            this.button12.Text = "button12";
//            this.button12.UseVisualStyleBackColor = true;
//            this.button12.Click += new System.EventHandler(this.button12_Click);
//            // 
//            // button11
//            // 
//            this.button11.Location = new System.Drawing.Point(107, 6);
//            this.button11.Name = "button11";
//            this.button11.Size = new System.Drawing.Size(98, 24);
//            this.button11.TabIndex = 1;
//            this.button11.Text = "button11";
//            this.button11.UseVisualStyleBackColor = true;
//            this.button11.Click += new System.EventHandler(this.button11_Click);
//            // 
//            // button10
//            // 
//            this.button10.Location = new System.Drawing.Point(3, 6);
//            this.button10.Name = "button10";
//            this.button10.Size = new System.Drawing.Size(98, 24);
//            this.button10.TabIndex = 0;
//            this.button10.Text = "button10";
//            this.button10.UseVisualStyleBackColor = true;
//            this.button10.Click += new System.EventHandler(this.button10_Click);
//            // 
//            // linkLabel1
//            // 
//            this.linkLabel1.AutoSize = true;
//            this.linkLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.linkLabel1.LinkColor = System.Drawing.Color.OrangeRed;
//            this.linkLabel1.Location = new System.Drawing.Point(80, 11);
//            this.linkLabel1.Name = "linkLabel1";
//            this.linkLabel1.Size = new System.Drawing.Size(105, 22);
//            this.linkLabel1.TabIndex = 4;
//            this.linkLabel1.TabStop = true;
//            this.linkLabel1.Text = "linkLabel1";
//            // 
//            // pictureBox1
//            // 
//            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
//            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
//            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
//            this.pictureBox1.Name = "pictureBox1";
//            this.pictureBox1.Size = new System.Drawing.Size(76, 80);
//            this.pictureBox1.TabIndex = 0;
//            this.pictureBox1.TabStop = false;
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label1.Location = new System.Drawing.Point(79, 58);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(45, 19);
//            this.label1.TabIndex = 3;
//            this.label1.Text = "label3";
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
//            this.label2.Location = new System.Drawing.Point(79, 33);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(45, 19);
//            this.label2.TabIndex = 2;
//            this.label2.Text = "label2";
//            // 
//            // Form1
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.Color.WhiteSmoke;
//            this.ClientSize = new System.Drawing.Size(537, 544);
//            this.Controls.Add(this.tc);
//            this.Name = "Form1";
//            this.Text = "ITViec";
//            this.Load += new System.EventHandler(this.Form1_Load);
//            this.panel6.ResumeLayout(false);
//            this.tc.ResumeLayout(false);
//            this.tcJob.ResumeLayout(false);
//            this.tcEmployee.ResumeLayout(false);
//            this.tcEmployee.PerformLayout();
//            this.panel12.ResumeLayout(false);
//            this.panel7.ResumeLayout(false);
//            this.pnlApply4.ResumeLayout(false);
//            this.pnlApply4.PerformLayout();
//            this.pnlApply3.ResumeLayout(false);
//            this.pnlApply3.PerformLayout();
//            this.pnlApply2.ResumeLayout(false);
//            this.pnlApply2.PerformLayout();
//            this.pnlApply1.ResumeLayout(false);
//            this.pnlApply1.PerformLayout();
//            this.tcAdmin.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
//            this.ResumeLayout(false);

//        }

//        #endregion
//        private System.Windows.Forms.Panel panel6;
//        private System.Windows.Forms.Button btnBACK;
//        private System.Windows.Forms.Button btnNEXT;
//        private System.Windows.Forms.TabControl tc;
//        private System.Windows.Forms.TabPage tcJob;
//        private System.Windows.Forms.TabPage tcEmployee;
//        private System.Windows.Forms.TabPage tcAdmin;
//        private System.Windows.Forms.Label lbUngTuyen;
//        private System.Windows.Forms.Button btnAddJob;
//        private System.Windows.Forms.Panel panel12;
//        private System.Windows.Forms.Button btnNxt;
//        private System.Windows.Forms.Button btnPre;
//        private System.Windows.Forms.Button btn2;
//        private System.Windows.Forms.Panel panel7;
//        private System.Windows.Forms.Button btn3;
//        private System.Windows.Forms.Panel pnlApply1;
//        private System.Windows.Forms.Label lbCandidate1;
//        private System.Windows.Forms.Button btn1;
//        private System.Windows.Forms.Panel pnlApply4;
//        private System.Windows.Forms.Label lbJob4;
//        private System.Windows.Forms.Button button7;
//        private System.Windows.Forms.Button button8;
//        private System.Windows.Forms.Label lbCandidate4;
//        private System.Windows.Forms.Button button9;
//        private System.Windows.Forms.Panel pnlApply3;
//        private System.Windows.Forms.Label lbJob3;
//        private System.Windows.Forms.Button button4;
//        private System.Windows.Forms.Button button5;
//        private System.Windows.Forms.Label lbCandidate3;
//        private System.Windows.Forms.Button button6;
//        private System.Windows.Forms.Panel pnlApply2;
//        private System.Windows.Forms.Label lbJob2;
//        private System.Windows.Forms.Button button1;
//        private System.Windows.Forms.Button button2;
//        private System.Windows.Forms.Label lbCandidate2;
//        private System.Windows.Forms.Button button3;
//        private System.Windows.Forms.Label lbJob1;
//        private System.Windows.Forms.Button button10;
//        private System.Windows.Forms.Button button12;
//        private System.Windows.Forms.Button button11;
//        private System.Windows.Forms.LinkLabel linkLabel1;
//        private System.Windows.Forms.PictureBox pictureBox1;
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.Label label2;
//    }
//}


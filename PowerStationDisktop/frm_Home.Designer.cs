﻿
namespace PowerStationDisktop
{
    partial class frm_Home
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("بيانات الشركة");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("بيانات العدادات ");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("بيانات المناطق ");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("تسعيرة الكهرباء ");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("السماح بالتحصيل");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("عرض جميع الصلاحيات الحالية");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("التقاريــر", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("إنشاء نسخة احتياطية");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("إستعادة نسخة احتياطية");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("نسخة احتياطية", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("ادارة النظام ", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode7,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("بيانات العملاء ");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("كشف حساب");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("تقارير المتأخرات للعملاء ");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("التقاريــر", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("ادارة العملاء ", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("بيانات الموظفين ");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("ادارة الموظفين ", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("بيانات الموردين  ");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("سندات الصرف ");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("سندات القبض ");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("صرف الراتب");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("اضافة القراءات ");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("ارسال رسائل عبر الـ WhatsApp");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("ارسال رسائل SMS");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("ادارة حركة النظام ", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            this.tv_Screens = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_ChangeUser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Collapse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_EmployeeName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.CurrentDate = new System.Windows.Forms.Label();
            this.btn_Information = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tv_Screens
            // 
            this.tv_Screens.BackColor = System.Drawing.SystemColors.Control;
            this.tv_Screens.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Bold);
            this.tv_Screens.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tv_Screens.ImageIndex = 0;
            this.tv_Screens.ImageList = this.imageList1;
            this.tv_Screens.Location = new System.Drawing.Point(12, 129);
            this.tv_Screens.Margin = new System.Windows.Forms.Padding(4);
            this.tv_Screens.Name = "tv_Screens";
            treeNode1.ImageKey = "office-building.png";
            treeNode1.Name = "PowerStationData";
            treeNode1.SelectedImageKey = "office-building.png";
            treeNode1.Text = "بيانات الشركة";
            treeNode2.ImageKey = "electric-meter.png";
            treeNode2.Name = "ElectronicMetersData";
            treeNode2.SelectedImageKey = "electric-meter.png";
            treeNode2.Text = "بيانات العدادات ";
            treeNode3.ImageKey = "map.png";
            treeNode3.Name = "AreasData";
            treeNode3.SelectedImageKey = "map.png";
            treeNode3.Text = "بيانات المناطق ";
            treeNode4.ImageKey = "inflation.png";
            treeNode4.Name = "Prices";
            treeNode4.SelectedImageKey = "inflation.png";
            treeNode4.Text = "تسعيرة الكهرباء ";
            treeNode5.ImageKey = "permissions.png";
            treeNode5.Name = "AllowReadings";
            treeNode5.SelectedImageKey = "permissions.png";
            treeNode5.Text = "السماح بالتحصيل";
            treeNode6.Name = "ShowAllPermissions";
            treeNode6.Text = "عرض جميع الصلاحيات الحالية";
            treeNode7.Name = "Node4";
            treeNode7.Text = "التقاريــر";
            treeNode8.ImageKey = "cloud-upload.png";
            treeNode8.Name = "CreateBackup";
            treeNode8.SelectedImageKey = "cloud-upload.png";
            treeNode8.Text = "إنشاء نسخة احتياطية";
            treeNode9.ImageKey = "restore.png";
            treeNode9.Name = "RestoreBackup";
            treeNode9.SelectedImageKey = "restore.png";
            treeNode9.Text = "إستعادة نسخة احتياطية";
            treeNode10.ImageKey = "backup.png";
            treeNode10.Name = "Node2";
            treeNode10.SelectedImageKey = "backup.png";
            treeNode10.Text = "نسخة احتياطية";
            treeNode11.ForeColor = System.Drawing.Color.Black;
            treeNode11.ImageKey = "content-management-system.png";
            treeNode11.Name = "Node0";
            treeNode11.SelectedImageKey = "content-management-system.png";
            treeNode11.Text = "ادارة النظام ";
            treeNode12.ImageKey = "ancestors.png";
            treeNode12.Name = "CustomerData";
            treeNode12.SelectedImageKey = "ancestors.png";
            treeNode12.Text = "بيانات العملاء ";
            treeNode13.Name = "AccountStatementForCustomer";
            treeNode13.Text = "كشف حساب";
            treeNode14.Name = "CustomerTotalDues";
            treeNode14.Text = "تقارير المتأخرات للعملاء ";
            treeNode15.Name = "Node10";
            treeNode15.Text = "التقاريــر";
            treeNode16.ForeColor = System.Drawing.Color.Black;
            treeNode16.ImageKey = "ancestors.png";
            treeNode16.Name = "Node8";
            treeNode16.SelectedImageKey = "ancestors.png";
            treeNode16.Text = "ادارة العملاء ";
            treeNode17.ImageKey = "ancestors.png";
            treeNode17.Name = "EmployeeData";
            treeNode17.SelectedImageKey = "ancestors.png";
            treeNode17.Text = "بيانات الموظفين ";
            treeNode18.ForeColor = System.Drawing.Color.Black;
            treeNode18.ImageKey = "ancestors.png";
            treeNode18.Name = "Node16";
            treeNode18.SelectedImageKey = "ancestors.png";
            treeNode18.Text = "ادارة الموظفين ";
            treeNode19.ImageKey = "ancestors.png";
            treeNode19.Name = "SupplierData";
            treeNode19.SelectedImageKey = "ancestors.png";
            treeNode19.Text = "بيانات الموردين  ";
            treeNode20.ImageKey = "cashless-payment.png";
            treeNode20.Name = "PaymentVoucher";
            treeNode20.SelectedImageKey = "cashless-payment.png";
            treeNode20.Text = "سندات الصرف ";
            treeNode21.ImageKey = "payment-method.png";
            treeNode21.Name = "CustomerMovement";
            treeNode21.SelectedImageKey = "payment-method.png";
            treeNode21.Text = "سندات القبض ";
            treeNode22.ImageKey = "salary.png";
            treeNode22.Name = "SalaryPayment";
            treeNode22.SelectedImageKey = "salary.png";
            treeNode22.Text = "صرف الراتب";
            treeNode23.ImageKey = "electric-meter.png";
            treeNode23.Name = "Readings";
            treeNode23.SelectedImageKey = "electric-meter.png";
            treeNode23.Text = "اضافة القراءات ";
            treeNode24.Name = "SendMassagesInWhatsapp";
            treeNode24.Text = "ارسال رسائل عبر الـ WhatsApp";
            treeNode25.ImageKey = "sms.png";
            treeNode25.Name = "SendSMSMassages";
            treeNode25.SelectedImageKey = "sms.png";
            treeNode25.Text = "ارسال رسائل SMS";
            treeNode26.ForeColor = System.Drawing.Color.Black;
            treeNode26.ImageKey = "control-system.png";
            treeNode26.Name = "Node23";
            treeNode26.SelectedImageKey = "control-system.png";
            treeNode26.Text = "ادارة حركة النظام ";
            this.tv_Screens.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode16,
            treeNode18,
            treeNode26});
            this.tv_Screens.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tv_Screens.RightToLeftLayout = true;
            this.tv_Screens.SelectedImageIndex = 0;
            this.tv_Screens.Size = new System.Drawing.Size(314, 856);
            this.tv_Screens.TabIndex = 1;
            this.tv_Screens.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_Screens_NodeMouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "content-management-system.png");
            this.imageList1.Images.SetKeyName(1, "office-building.png");
            this.imageList1.Images.SetKeyName(2, "electric-meter.png");
            this.imageList1.Images.SetKeyName(3, "map.png");
            this.imageList1.Images.SetKeyName(4, "inflation.png");
            this.imageList1.Images.SetKeyName(5, "permissions.png");
            this.imageList1.Images.SetKeyName(6, "backup.png");
            this.imageList1.Images.SetKeyName(7, "cloud-upload.png");
            this.imageList1.Images.SetKeyName(8, "restore.png");
            this.imageList1.Images.SetKeyName(9, "ancestors.png");
            this.imageList1.Images.SetKeyName(10, "payment-method.png");
            this.imageList1.Images.SetKeyName(11, "salary.png");
            this.imageList1.Images.SetKeyName(12, "cashless-payment.png");
            this.imageList1.Images.SetKeyName(13, "control-system.png");
            this.imageList1.Images.SetKeyName(14, "sms.png");
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(13, 75);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(313, 46);
            this.textBox2.TabIndex = 4;
            // 
            // btn_ChangeUser
            // 
            this.btn_ChangeUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ChangeUser.FlatAppearance.BorderSize = 0;
            this.btn_ChangeUser.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangeUser.Image = ((System.Drawing.Image)(resources.GetObject("btn_ChangeUser.Image")));
            this.btn_ChangeUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChangeUser.Location = new System.Drawing.Point(13, 22);
            this.btn_ChangeUser.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ChangeUser.Name = "btn_ChangeUser";
            this.btn_ChangeUser.Size = new System.Drawing.Size(313, 45);
            this.btn_ChangeUser.TabIndex = 9;
            this.btn_ChangeUser.Text = "تبديل المستخدم";
            this.btn_ChangeUser.UseVisualStyleBackColor = true;
            this.btn_ChangeUser.Click += new System.EventHandler(this.btn_ChangeUser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Collapse);
            this.groupBox1.Controls.Add(this.tv_Screens);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.btn_ChangeUser);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 998);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btn_Collapse
            // 
            this.btn_Collapse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Collapse.BackgroundImage")));
            this.btn_Collapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Collapse.FlatAppearance.BorderSize = 0;
            this.btn_Collapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Collapse.Location = new System.Drawing.Point(27, 144);
            this.btn_Collapse.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Collapse.Name = "btn_Collapse";
            this.btn_Collapse.Size = new System.Drawing.Size(32, 34);
            this.btn_Collapse.TabIndex = 13;
            this.btn_Collapse.UseVisualStyleBackColor = true;
            this.btn_Collapse.Click += new System.EventHandler(this.btn_Collapse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(346, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1565, 86);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(678, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "النصر";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(346, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1576, 822);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.SlateBlue;
            this.label3.Location = new System.Drawing.Point(352, 948);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "المستخدم :";
            // 
            // lbl_EmployeeName
            // 
            this.lbl_EmployeeName.AutoSize = true;
            this.lbl_EmployeeName.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmployeeName.ForeColor = System.Drawing.Color.Black;
            this.lbl_EmployeeName.Location = new System.Drawing.Point(481, 945);
            this.lbl_EmployeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_EmployeeName.Name = "lbl_EmployeeName";
            this.lbl_EmployeeName.Size = new System.Drawing.Size(0, 32);
            this.lbl_EmployeeName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(1188, 947);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "الوقت :";
            // 
            // CurrentTime
            // 
            this.CurrentTime.AutoSize = true;
            this.CurrentTime.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F);
            this.CurrentTime.ForeColor = System.Drawing.Color.Black;
            this.CurrentTime.Location = new System.Drawing.Point(1272, 948);
            this.CurrentTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(82, 28);
            this.CurrentTime.TabIndex = 17;
            this.CurrentTime.Text = "23:20:15";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.SlateBlue;
            this.label4.Location = new System.Drawing.Point(828, 948);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "التاريخ :";
            // 
            // CurrentDate
            // 
            this.CurrentDate.AutoSize = true;
            this.CurrentDate.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F);
            this.CurrentDate.ForeColor = System.Drawing.Color.Black;
            this.CurrentDate.Location = new System.Drawing.Point(924, 948);
            this.CurrentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(66, 28);
            this.CurrentDate.TabIndex = 19;
            this.CurrentDate.Text = "Wewe";
            // 
            // btn_Information
            // 
            this.btn_Information.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Information.BackgroundImage")));
            this.btn_Information.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Information.FlatAppearance.BorderSize = 0;
            this.btn_Information.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Information.Location = new System.Drawing.Point(1870, 948);
            this.btn_Information.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Information.Name = "btn_Information";
            this.btn_Information.Size = new System.Drawing.Size(32, 41);
            this.btn_Information.TabIndex = 21;
            this.btn_Information.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 998);
            this.Controls.Add(this.btn_Information);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CurrentDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrentTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_EmployeeName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الرئيسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv_Screens;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_ChangeUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_EmployeeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CurrentTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CurrentDate;
        private System.Windows.Forms.Button btn_Collapse;
        private System.Windows.Forms.Button btn_Information;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

namespace PowerStationDisktop.PresentationLayer.Employees
{
    partial class frm_Permissions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Permissions));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_AddSelectedPermission = new System.Windows.Forms.Button();
            this.chk_SetAsPermanentArea = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.num_NumberOfAllowedDaysForTakingReading = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_EmployeeID = new System.Windows.Forms.TextBox();
            this.cmb_AreaName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_EmployeeName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_NumberOfAllowedDaysForTakingReading)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AddSelectedPermission);
            this.groupBox1.Controls.Add(this.chk_SetAsPermanentArea);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.num_NumberOfAllowedDaysForTakingReading);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_EmployeeID);
            this.groupBox1.Controls.Add(this.cmb_AreaName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_EmployeeName);
            this.groupBox1.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 297);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "إضافة منطقة جديدة للمحصل";
            // 
            // btn_AddSelectedPermission
            // 
            this.btn_AddSelectedPermission.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddSelectedPermission.Location = new System.Drawing.Point(351, 233);
            this.btn_AddSelectedPermission.Name = "btn_AddSelectedPermission";
            this.btn_AddSelectedPermission.Size = new System.Drawing.Size(249, 41);
            this.btn_AddSelectedPermission.TabIndex = 11;
            this.btn_AddSelectedPermission.Text = "إضافة الصلاحية المحددة";
            this.btn_AddSelectedPermission.UseVisualStyleBackColor = true;
            this.btn_AddSelectedPermission.Click += new System.EventHandler(this.btn_AddSelectedPermission_Click);
            // 
            // chk_SetAsPermanentArea
            // 
            this.chk_SetAsPermanentArea.AutoSize = true;
            this.chk_SetAsPermanentArea.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F);
            this.chk_SetAsPermanentArea.Location = new System.Drawing.Point(205, 129);
            this.chk_SetAsPermanentArea.Name = "chk_SetAsPermanentArea";
            this.chk_SetAsPermanentArea.Size = new System.Drawing.Size(212, 42);
            this.chk_SetAsPermanentArea.TabIndex = 11;
            this.chk_SetAsPermanentArea.Text = "ضبط كمنطقة دائمة";
            this.chk_SetAsPermanentArea.UseVisualStyleBackColor = true;
            this.chk_SetAsPermanentArea.CheckedChanged += new System.EventHandler(this.chk_SetAsPermanentArea_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "أيام";
            // 
            // num_NumberOfAllowedDaysForTakingReading
            // 
            this.num_NumberOfAllowedDaysForTakingReading.Font = new System.Drawing.Font("Tahoma", 12F);
            this.num_NumberOfAllowedDaysForTakingReading.Location = new System.Drawing.Point(600, 124);
            this.num_NumberOfAllowedDaysForTakingReading.Name = "num_NumberOfAllowedDaysForTakingReading";
            this.num_NumberOfAllowedDaysForTakingReading.Size = new System.Drawing.Size(82, 32);
            this.num_NumberOfAllowedDaysForTakingReading.TabIndex = 9;
            this.num_NumberOfAllowedDaysForTakingReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(703, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "السماح بالتحصيل لمدة";
            // 
            // txt_EmployeeID
            // 
            this.txt_EmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EmployeeID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_EmployeeID.Enabled = false;
            this.txt_EmployeeID.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txt_EmployeeID.Location = new System.Drawing.Point(18, 27);
            this.txt_EmployeeID.Name = "txt_EmployeeID";
            this.txt_EmployeeID.Size = new System.Drawing.Size(41, 24);
            this.txt_EmployeeID.TabIndex = 6;
            this.txt_EmployeeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmb_AreaName
            // 
            this.cmb_AreaName.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_AreaName.FormattingEnabled = true;
            this.cmb_AreaName.Location = new System.Drawing.Point(96, 58);
            this.cmb_AreaName.Name = "cmb_AreaName";
            this.cmb_AreaName.Size = new System.Drawing.Size(223, 36);
            this.cmb_AreaName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F);
            this.label2.Location = new System.Drawing.Point(327, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "اختر المنطقة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F);
            this.label1.Location = new System.Drawing.Point(784, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "اسم الموظف";
            // 
            // txt_EmployeeName
            // 
            this.txt_EmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EmployeeName.Enabled = false;
            this.txt_EmployeeName.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmployeeName.Location = new System.Drawing.Point(502, 59);
            this.txt_EmployeeName.Name = "txt_EmployeeName";
            this.txt_EmployeeName.Size = new System.Drawing.Size(271, 36);
            this.txt_EmployeeName.TabIndex = 2;
            this.txt_EmployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_Permissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 321);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Permissions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الصلاحيات";
            this.Load += new System.EventHandler(this.frm_Permissions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_NumberOfAllowedDaysForTakingReading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txt_EmployeeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_AreaName;
        public System.Windows.Forms.TextBox txt_EmployeeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_NumberOfAllowedDaysForTakingReading;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_AddSelectedPermission;
        private System.Windows.Forms.CheckBox chk_SetAsPermanentArea;
    }
}
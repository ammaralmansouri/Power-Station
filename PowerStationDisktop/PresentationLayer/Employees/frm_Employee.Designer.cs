
namespace PowerStationDisktop.PresentationLayer.Emloyees
{
    partial class frm_Employee
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
            this.txt_EmployeeID = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cmb_EmployeeState = new System.Windows.Forms.ComboBox();
            this.cmb_EmployeeType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_EmployeePassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_New = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_Employees = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.الصلاحياتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.txt_EmployeeSalary = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_EmployeeName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_EmployeePhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rad_All = new System.Windows.Forms.RadioButton();
            this.rad_InsideEmployee = new System.Windows.Forms.RadioButton();
            this.rad_outEmployee = new System.Windows.Forms.RadioButton();
            this.rad_Active = new System.Windows.Forms.RadioButton();
            this.rad_NoneActive = new System.Windows.Forms.RadioButton();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employees)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_EmployeeID
            // 
            this.txt_EmployeeID.Location = new System.Drawing.Point(347, 17);
            this.txt_EmployeeID.Name = "txt_EmployeeID";
            this.txt_EmployeeID.Size = new System.Drawing.Size(57, 26);
            this.txt_EmployeeID.TabIndex = 15;
            this.txt_EmployeeID.Visible = false;
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(450, 24);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(91, 41);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cmb_EmployeeState
            // 
            this.cmb_EmployeeState.FormattingEnabled = true;
            this.cmb_EmployeeState.Items.AddRange(new object[] {
            "فعال",
            "غير فعال"});
            this.cmb_EmployeeState.Location = new System.Drawing.Point(14, 152);
            this.cmb_EmployeeState.Name = "cmb_EmployeeState";
            this.cmb_EmployeeState.Size = new System.Drawing.Size(159, 28);
            this.cmb_EmployeeState.TabIndex = 6;
            // 
            // cmb_EmployeeType
            // 
            this.cmb_EmployeeType.FormattingEnabled = true;
            this.cmb_EmployeeType.Items.AddRange(new object[] {
            "موظف",
            "محصل"});
            this.cmb_EmployeeType.Location = new System.Drawing.Point(14, 47);
            this.cmb_EmployeeType.Name = "cmb_EmployeeType";
            this.cmb_EmployeeType.Size = new System.Drawing.Size(159, 28);
            this.cmb_EmployeeType.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(185, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "نوع الموظف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "رقم الهاتف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(556, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "الإسم";
            // 
            // txt_EmployeePassword
            // 
            this.txt_EmployeePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EmployeePassword.Enabled = false;
            this.txt_EmployeePassword.Location = new System.Drawing.Point(14, 104);
            this.txt_EmployeePassword.Name = "txt_EmployeePassword";
            this.txt_EmployeePassword.PasswordChar = '*';
            this.txt_EmployeePassword.Size = new System.Drawing.Size(159, 26);
            this.txt_EmployeePassword.TabIndex = 4;
            this.txt_EmployeePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "حالة الموظف";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(548, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "الراتب";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(122, 24);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(91, 41);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Enabled = false;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(288, 24);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(91, 41);
            this.btn_Edit.TabIndex = 8;
            this.btn_Edit.Text = "تعديل";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Delete);
            this.groupBox4.Controls.Add(this.btn_Edit);
            this.groupBox4.Controls.Add(this.btn_Save);
            this.groupBox4.Controls.Add(this.btn_New);
            this.groupBox4.Location = new System.Drawing.Point(12, 606);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(817, 86);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // btn_New
            // 
            this.btn_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Location = new System.Drawing.Point(623, 23);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(91, 42);
            this.btn_New.TabIndex = 10;
            this.btn_New.Text = "جديد";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_Employees);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(817, 334);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "الموظفين";
            // 
            // dgv_Employees
            // 
            this.dgv_Employees.AllowUserToAddRows = false;
            this.dgv_Employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employees.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_Employees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Employees.Location = new System.Drawing.Point(3, 22);
            this.dgv_Employees.Name = "dgv_Employees";
            this.dgv_Employees.RowHeadersVisible = false;
            this.dgv_Employees.RowHeadersWidth = 51;
            this.dgv_Employees.RowTemplate.Height = 24;
            this.dgv_Employees.Size = new System.Drawing.Size(811, 309);
            this.dgv_Employees.TabIndex = 30;
            this.dgv_Employees.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Employees_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الصلاحياتToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 28);
            // 
            // الصلاحياتToolStripMenuItem
            // 
            this.الصلاحياتToolStripMenuItem.Name = "الصلاحياتToolStripMenuItem";
            this.الصلاحياتToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.الصلاحياتToolStripMenuItem.Text = "الصلاحيات";
            // 
            // txt_Search
            // 
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(6, 63);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(178, 30);
            this.txt_Search.TabIndex = 24;
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_EmployeeSalary
            // 
            this.txt_EmployeeSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EmployeeSalary.Enabled = false;
            this.txt_EmployeeSalary.Location = new System.Drawing.Point(291, 149);
            this.txt_EmployeeSalary.Name = "txt_EmployeeSalary";
            this.txt_EmployeeSalary.Size = new System.Drawing.Size(227, 26);
            this.txt_EmployeeSalary.TabIndex = 5;
            this.txt_EmployeeSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_EmployeeSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_EmployeeSalary_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Search);
            this.groupBox2.Controls.Add(this.txt_Search);
            this.groupBox2.Location = new System.Drawing.Point(639, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 200);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(36, 123);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(108, 39);
            this.btn_Search.TabIndex = 25;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "كلمة المرور";
            // 
            // txt_EmployeeName
            // 
            this.txt_EmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EmployeeName.Enabled = false;
            this.txt_EmployeeName.Location = new System.Drawing.Point(291, 49);
            this.txt_EmployeeName.Name = "txt_EmployeeName";
            this.txt_EmployeeName.Size = new System.Drawing.Size(227, 26);
            this.txt_EmployeeName.TabIndex = 1;
            this.txt_EmployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_EmployeePhone);
            this.groupBox1.Controls.Add(this.txt_EmployeeID);
            this.groupBox1.Controls.Add(this.cmb_EmployeeState);
            this.groupBox1.Controls.Add(this.cmb_EmployeeType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_EmployeePassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_EmployeeSalary);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_EmployeeName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 200);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الموظف";
            // 
            // txt_EmployeePhone
            // 
            this.txt_EmployeePhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EmployeePhone.Enabled = false;
            this.txt_EmployeePhone.Location = new System.Drawing.Point(291, 103);
            this.txt_EmployeePhone.MaxLength = 9;
            this.txt_EmployeePhone.Name = "txt_EmployeePhone";
            this.txt_EmployeePhone.Size = new System.Drawing.Size(227, 26);
            this.txt_EmployeePhone.TabIndex = 16;
            this.txt_EmployeePhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_EmployeePhone.TextChanged += new System.EventHandler(this.txt_EmployeePhone_TextChanged);
            this.txt_EmployeePhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_EmployeePhone_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 564);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "عرض حسب: ";
            // 
            // rad_All
            // 
            this.rad_All.AutoSize = true;
            this.rad_All.Checked = true;
            this.rad_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_All.Location = new System.Drawing.Point(152, 569);
            this.rad_All.Name = "rad_All";
            this.rad_All.Size = new System.Drawing.Size(54, 24);
            this.rad_All.TabIndex = 9;
            this.rad_All.TabStop = true;
            this.rad_All.Text = "الكل";
            this.rad_All.UseVisualStyleBackColor = true;
            this.rad_All.CheckedChanged += new System.EventHandler(this.rad_All_CheckedChanged);
            // 
            // rad_InsideEmployee
            // 
            this.rad_InsideEmployee.AutoSize = true;
            this.rad_InsideEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_InsideEmployee.Location = new System.Drawing.Point(229, 569);
            this.rad_InsideEmployee.Name = "rad_InsideEmployee";
            this.rad_InsideEmployee.Size = new System.Drawing.Size(79, 24);
            this.rad_InsideEmployee.TabIndex = 10;
            this.rad_InsideEmployee.Text = "الموظفين";
            this.rad_InsideEmployee.UseVisualStyleBackColor = true;
            this.rad_InsideEmployee.CheckedChanged += new System.EventHandler(this.rad_InsideEmployee_CheckedChanged);
            // 
            // rad_outEmployee
            // 
            this.rad_outEmployee.AutoSize = true;
            this.rad_outEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_outEmployee.Location = new System.Drawing.Point(334, 569);
            this.rad_outEmployee.Name = "rad_outEmployee";
            this.rad_outEmployee.Size = new System.Drawing.Size(85, 24);
            this.rad_outEmployee.TabIndex = 11;
            this.rad_outEmployee.Text = "المحصلين";
            this.rad_outEmployee.UseVisualStyleBackColor = true;
            this.rad_outEmployee.CheckedChanged += new System.EventHandler(this.rad_outEmployee_CheckedChanged);
            // 
            // rad_Active
            // 
            this.rad_Active.AutoSize = true;
            this.rad_Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Active.Location = new System.Drawing.Point(450, 569);
            this.rad_Active.Name = "rad_Active";
            this.rad_Active.Size = new System.Drawing.Size(55, 24);
            this.rad_Active.TabIndex = 12;
            this.rad_Active.Text = "فعال";
            this.rad_Active.UseVisualStyleBackColor = true;
            this.rad_Active.CheckedChanged += new System.EventHandler(this.rad_Active_CheckedChanged);
            // 
            // rad_NoneActive
            // 
            this.rad_NoneActive.AutoSize = true;
            this.rad_NoneActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_NoneActive.Location = new System.Drawing.Point(520, 569);
            this.rad_NoneActive.Name = "rad_NoneActive";
            this.rad_NoneActive.Size = new System.Drawing.Size(81, 24);
            this.rad_NoneActive.TabIndex = 13;
            this.rad_NoneActive.Text = "غير فعال";
            this.rad_NoneActive.UseVisualStyleBackColor = true;
            this.rad_NoneActive.CheckedChanged += new System.EventHandler(this.rad_NoneActive_CheckedChanged);
            // 
            // frm_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 704);
            this.Controls.Add(this.rad_NoneActive);
            this.Controls.Add(this.rad_Active);
            this.Controls.Add(this.rad_outEmployee);
            this.Controls.Add(this.rad_InsideEmployee);
            this.Controls.Add(this.rad_All);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Employee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الموظفين";
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employees)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_EmployeeID;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cmb_EmployeeState;
        private System.Windows.Forms.ComboBox cmb_EmployeeType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_EmployeePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_Employees;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.TextBox txt_EmployeeSalary;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_EmployeeName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem الصلاحياتToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rad_All;
        private System.Windows.Forms.RadioButton rad_InsideEmployee;
        private System.Windows.Forms.RadioButton rad_outEmployee;
        private System.Windows.Forms.RadioButton rad_Active;
        private System.Windows.Forms.RadioButton rad_NoneActive;
        private System.Windows.Forms.TextBox txt_EmployeePhone;
    }
}
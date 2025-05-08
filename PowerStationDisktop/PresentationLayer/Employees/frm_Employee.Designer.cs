
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Employee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.dgv_Employees = new System.Windows.Forms.DataGridView();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.الصلاحياتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_EmployeeSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_EmployeeName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ShowPassword = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txt_EmployeePhone = new System.Windows.Forms.TextBox();
            this.rad_All = new System.Windows.Forms.RadioButton();
            this.rad_InsideEmployee = new System.Windows.Forms.RadioButton();
            this.rad_outEmployee = new System.Windows.Forms.RadioButton();
            this.rad_Active = new System.Windows.Forms.RadioButton();
            this.rad_NoneActive = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employees)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_EmployeeID
            // 
            this.txt_EmployeeID.Location = new System.Drawing.Point(31, 33);
            this.txt_EmployeeID.Name = "txt_EmployeeID";
            this.txt_EmployeeID.Size = new System.Drawing.Size(22, 39);
            this.txt_EmployeeID.TabIndex = 15;
            this.txt_EmployeeID.Visible = false;
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.Location = new System.Drawing.Point(456, 25);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(91, 67);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cmb_EmployeeState
            // 
            this.cmb_EmployeeState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_EmployeeState.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_EmployeeState.FormattingEnabled = true;
            this.cmb_EmployeeState.Items.AddRange(new object[] {
            "فعال",
            "غير فعال"});
            this.cmb_EmployeeState.Location = new System.Drawing.Point(77, 142);
            this.cmb_EmployeeState.Name = "cmb_EmployeeState";
            this.cmb_EmployeeState.Size = new System.Drawing.Size(194, 36);
            this.cmb_EmployeeState.TabIndex = 6;
            // 
            // cmb_EmployeeType
            // 
            this.cmb_EmployeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_EmployeeType.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_EmployeeType.FormattingEnabled = true;
            this.cmb_EmployeeType.Items.AddRange(new object[] {
            "موظف",
            "محصل"});
            this.cmb_EmployeeType.Location = new System.Drawing.Point(77, 44);
            this.cmb_EmployeeType.Name = "cmb_EmployeeType";
            this.cmb_EmployeeType.Size = new System.Drawing.Size(194, 36);
            this.cmb_EmployeeType.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(289, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "نوع الموظف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(679, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "رقم الهاتف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(718, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "الإسم";
            // 
            // txt_EmployeePassword
            // 
            this.txt_EmployeePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EmployeePassword.Enabled = false;
            this.txt_EmployeePassword.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmployeePassword.Location = new System.Drawing.Point(77, 94);
            this.txt_EmployeePassword.MaxLength = 20;
            this.txt_EmployeePassword.Name = "txt_EmployeePassword";
            this.txt_EmployeePassword.PasswordChar = '*';
            this.txt_EmployeePassword.Size = new System.Drawing.Size(193, 36);
            this.txt_EmployeePassword.TabIndex = 4;
            this.txt_EmployeePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "حالة الموظف";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(719, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "الراتب";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.Location = new System.Drawing.Point(110, 17);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(91, 77);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Enabled = false;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.Image")));
            this.btn_Edit.Location = new System.Drawing.Point(275, 20);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(91, 77);
            this.btn_Edit.TabIndex = 8;
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.btn_Delete);
            this.groupBox4.Controls.Add(this.btn_Edit);
            this.groupBox4.Controls.Add(this.btn_Save);
            this.groupBox4.Controls.Add(this.btn_New);
            this.groupBox4.Location = new System.Drawing.Point(11, 726);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(808, 107);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // btn_New
            // 
            this.btn_New.FlatAppearance.BorderSize = 0;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.Image")));
            this.btn_New.Location = new System.Drawing.Point(640, 15);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(91, 86);
            this.btn_New.TabIndex = 10;
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Search);
            this.groupBox3.Controls.Add(this.dgv_Employees);
            this.groupBox3.Controls.Add(this.txt_Search);
            this.groupBox3.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(811, 401);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "الموظفين";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.Location = new System.Drawing.Point(5, 36);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(50, 39);
            this.btn_Search.TabIndex = 25;
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // dgv_Employees
            // 
            this.dgv_Employees.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.5F);
            this.dgv_Employees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Employees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Employees.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Employees.Location = new System.Drawing.Point(7, 78);
            this.dgv_Employees.MultiSelect = false;
            this.dgv_Employees.Name = "dgv_Employees";
            this.dgv_Employees.ReadOnly = true;
            this.dgv_Employees.RowHeadersVisible = false;
            this.dgv_Employees.RowHeadersWidth = 51;
            this.dgv_Employees.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Employees.RowTemplate.Height = 40;
            this.dgv_Employees.RowTemplate.ReadOnly = true;
            this.dgv_Employees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Employees.Size = new System.Drawing.Size(795, 317);
            this.dgv_Employees.TabIndex = 30;
            this.dgv_Employees.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Employees_CellDoubleClick);
            this.dgv_Employees.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Employees_CellMouseDown);
            this.dgv_Employees.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_Employees_KeyDown);
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.ForeColor = System.Drawing.Color.Gray;
            this.txt_Search.Location = new System.Drawing.Point(56, 37);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(746, 39);
            this.txt_Search.TabIndex = 24;
            this.txt_Search.Text = "ابحث هنا ..";
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            this.txt_Search.Enter += new System.EventHandler(this.txt_Search_Enter);
            this.txt_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown);
            this.txt_Search.Leave += new System.EventHandler(this.txt_Search_Leave);
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
            this.الصلاحياتToolStripMenuItem.Click += new System.EventHandler(this.الصلاحياتToolStripMenuItem_Click);
            // 
            // txt_EmployeeSalary
            // 
            this.txt_EmployeeSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EmployeeSalary.Enabled = false;
            this.txt_EmployeeSalary.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmployeeSalary.Location = new System.Drawing.Point(431, 143);
            this.txt_EmployeeSalary.MaxLength = 15;
            this.txt_EmployeeSalary.Name = "txt_EmployeeSalary";
            this.txt_EmployeeSalary.Size = new System.Drawing.Size(227, 36);
            this.txt_EmployeeSalary.TabIndex = 5;
            this.txt_EmployeeSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_EmployeeSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_EmployeeSalary_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(295, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "كلمة المرور";
            // 
            // txt_EmployeeName
            // 
            this.txt_EmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EmployeeName.Enabled = false;
            this.txt_EmployeeName.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmployeeName.Location = new System.Drawing.Point(431, 45);
            this.txt_EmployeeName.Name = "txt_EmployeeName";
            this.txt_EmployeeName.Size = new System.Drawing.Size(227, 36);
            this.txt_EmployeeName.TabIndex = 1;
            this.txt_EmployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btn_ShowPassword);
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
            this.groupBox1.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 200);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الموظف";
            // 
            // btn_ShowPassword
            // 
            this.btn_ShowPassword.ImageList = this.imageList1;
            this.btn_ShowPassword.Location = new System.Drawing.Point(25, 94);
            this.btn_ShowPassword.Name = "btn_ShowPassword";
            this.btn_ShowPassword.Size = new System.Drawing.Size(46, 36);
            this.btn_ShowPassword.TabIndex = 17;
            this.btn_ShowPassword.UseVisualStyleBackColor = true;
            this.btn_ShowPassword.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "eye.png");
            this.imageList1.Images.SetKeyName(1, "hidden.png");
            // 
            // txt_EmployeePhone
            // 
            this.txt_EmployeePhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EmployeePhone.Enabled = false;
            this.txt_EmployeePhone.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmployeePhone.Location = new System.Drawing.Point(431, 94);
            this.txt_EmployeePhone.MaxLength = 9;
            this.txt_EmployeePhone.Name = "txt_EmployeePhone";
            this.txt_EmployeePhone.Size = new System.Drawing.Size(227, 36);
            this.txt_EmployeePhone.TabIndex = 16;
            this.txt_EmployeePhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_EmployeePhone.TextChanged += new System.EventHandler(this.txt_EmployeePhone_TextChanged);
            this.txt_EmployeePhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_EmployeePhone_KeyPress);
            // 
            // rad_All
            // 
            this.rad_All.AutoSize = true;
            this.rad_All.Checked = true;
            this.rad_All.Font = new System.Drawing.Font("Droid Arabic Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_All.Location = new System.Drawing.Point(656, 38);
            this.rad_All.Name = "rad_All";
            this.rad_All.Size = new System.Drawing.Size(69, 36);
            this.rad_All.TabIndex = 9;
            this.rad_All.TabStop = true;
            this.rad_All.Text = "الكل";
            this.rad_All.UseVisualStyleBackColor = true;
            this.rad_All.CheckedChanged += new System.EventHandler(this.rad_All_CheckedChanged);
            // 
            // rad_InsideEmployee
            // 
            this.rad_InsideEmployee.AutoSize = true;
            this.rad_InsideEmployee.Font = new System.Drawing.Font("Droid Arabic Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_InsideEmployee.Location = new System.Drawing.Point(511, 38);
            this.rad_InsideEmployee.Name = "rad_InsideEmployee";
            this.rad_InsideEmployee.Size = new System.Drawing.Size(107, 36);
            this.rad_InsideEmployee.TabIndex = 10;
            this.rad_InsideEmployee.Text = "الموظفين";
            this.rad_InsideEmployee.UseVisualStyleBackColor = true;
            this.rad_InsideEmployee.CheckedChanged += new System.EventHandler(this.rad_InsideEmployee_CheckedChanged);
            // 
            // rad_outEmployee
            // 
            this.rad_outEmployee.AutoSize = true;
            this.rad_outEmployee.Font = new System.Drawing.Font("Droid Arabic Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_outEmployee.Location = new System.Drawing.Point(368, 38);
            this.rad_outEmployee.Name = "rad_outEmployee";
            this.rad_outEmployee.Size = new System.Drawing.Size(105, 36);
            this.rad_outEmployee.TabIndex = 11;
            this.rad_outEmployee.Text = "المحصلين";
            this.rad_outEmployee.UseVisualStyleBackColor = true;
            this.rad_outEmployee.CheckedChanged += new System.EventHandler(this.rad_outEmployee_CheckedChanged);
            // 
            // rad_Active
            // 
            this.rad_Active.AutoSize = true;
            this.rad_Active.Font = new System.Drawing.Font("Droid Arabic Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Active.Location = new System.Drawing.Point(257, 38);
            this.rad_Active.Name = "rad_Active";
            this.rad_Active.Size = new System.Drawing.Size(73, 36);
            this.rad_Active.TabIndex = 12;
            this.rad_Active.Text = "فعال";
            this.rad_Active.UseVisualStyleBackColor = true;
            this.rad_Active.CheckedChanged += new System.EventHandler(this.rad_Active_CheckedChanged);
            // 
            // rad_NoneActive
            // 
            this.rad_NoneActive.AutoSize = true;
            this.rad_NoneActive.Font = new System.Drawing.Font("Droid Arabic Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_NoneActive.Location = new System.Drawing.Point(102, 38);
            this.rad_NoneActive.Name = "rad_NoneActive";
            this.rad_NoneActive.Size = new System.Drawing.Size(101, 36);
            this.rad_NoneActive.TabIndex = 13;
            this.rad_NoneActive.Text = "غير فعال";
            this.rad_NoneActive.UseVisualStyleBackColor = true;
            this.rad_NoneActive.CheckedChanged += new System.EventHandler(this.rad_NoneActive_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad_All);
            this.groupBox2.Controls.Add(this.rad_NoneActive);
            this.groupBox2.Controls.Add(this.rad_InsideEmployee);
            this.groupBox2.Controls.Add(this.rad_Active);
            this.groupBox2.Controls.Add(this.rad_outEmployee);
            this.groupBox2.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F);
            this.groupBox2.Location = new System.Drawing.Point(11, 625);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(811, 95);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "فرز بحسب";
            // 
            // frm_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 845);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Employee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الموظفين";
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employees)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_EmployeeName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem الصلاحياتToolStripMenuItem;
        private System.Windows.Forms.RadioButton rad_All;
        private System.Windows.Forms.RadioButton rad_InsideEmployee;
        private System.Windows.Forms.RadioButton rad_outEmployee;
        private System.Windows.Forms.RadioButton rad_Active;
        private System.Windows.Forms.RadioButton rad_NoneActive;
        private System.Windows.Forms.TextBox txt_EmployeePhone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ShowPassword;
        private System.Windows.Forms.ImageList imageList1;
    }
}
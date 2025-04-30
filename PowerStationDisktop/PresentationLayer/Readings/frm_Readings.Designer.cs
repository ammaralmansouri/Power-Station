
namespace PowerStationDisktop.PresentationLayer.Readings
{
    partial class frm_Readings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Readings));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_DeleteReadingImage = new System.Windows.Forms.Button();
            this.btn_AddReadingImage = new System.Windows.Forms.Button();
            this.pb_ReadingPhoto = new System.Windows.Forms.PictureBox();
            this.txt_PriceID = new System.Windows.Forms.TextBox();
            this.txt_EmployeeID = new System.Windows.Forms.TextBox();
            this.txt_AreaID = new System.Windows.Forms.TextBox();
            this.txt_AreaName = new System.Windows.Forms.TextBox();
            this.txt_TotalDuesInThisReading = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_DateOfCurrentReading = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_PreviousReading = new System.Windows.Forms.TextBox();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CurrentReading = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ElectricityMeterID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Readings = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ReadingPhoto)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Readings)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_DeleteReadingImage);
            this.groupBox1.Controls.Add(this.btn_AddReadingImage);
            this.groupBox1.Controls.Add(this.pb_ReadingPhoto);
            this.groupBox1.Controls.Add(this.txt_PriceID);
            this.groupBox1.Controls.Add(this.txt_EmployeeID);
            this.groupBox1.Controls.Add(this.txt_AreaID);
            this.groupBox1.Controls.Add(this.txt_AreaName);
            this.groupBox1.Controls.Add(this.txt_TotalDuesInThisReading);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtp_DateOfCurrentReading);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_PreviousReading);
            this.groupBox1.Controls.Add(this.txt_CustomerName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Price);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_CurrentReading);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_ElectricityMeterID);
            this.groupBox1.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 245);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قراءة جديدة";
            // 
            // btn_DeleteReadingImage
            // 
            this.btn_DeleteReadingImage.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteReadingImage.Location = new System.Drawing.Point(6, 188);
            this.btn_DeleteReadingImage.Name = "btn_DeleteReadingImage";
            this.btn_DeleteReadingImage.Size = new System.Drawing.Size(140, 38);
            this.btn_DeleteReadingImage.TabIndex = 68;
            this.btn_DeleteReadingImage.Text = "حذف صورة القراءة";
            this.btn_DeleteReadingImage.UseVisualStyleBackColor = true;
            this.btn_DeleteReadingImage.Click += new System.EventHandler(this.btn_DeleteReadingImage_Click);
            // 
            // btn_AddReadingImage
            // 
            this.btn_AddReadingImage.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddReadingImage.Location = new System.Drawing.Point(152, 188);
            this.btn_AddReadingImage.Name = "btn_AddReadingImage";
            this.btn_AddReadingImage.Size = new System.Drawing.Size(152, 38);
            this.btn_AddReadingImage.TabIndex = 67;
            this.btn_AddReadingImage.Text = "اضافة صورة القراءة";
            this.btn_AddReadingImage.UseVisualStyleBackColor = true;
            this.btn_AddReadingImage.Click += new System.EventHandler(this.btn_AddReadingImage_Click);
            // 
            // pb_ReadingPhoto
            // 
            this.pb_ReadingPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_ReadingPhoto.Location = new System.Drawing.Point(54, 25);
            this.pb_ReadingPhoto.Name = "pb_ReadingPhoto";
            this.pb_ReadingPhoto.Size = new System.Drawing.Size(166, 148);
            this.pb_ReadingPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ReadingPhoto.TabIndex = 66;
            this.pb_ReadingPhoto.TabStop = false;
            // 
            // txt_PriceID
            // 
            this.txt_PriceID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PriceID.Enabled = false;
            this.txt_PriceID.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PriceID.Location = new System.Drawing.Point(382, 13);
            this.txt_PriceID.Name = "txt_PriceID";
            this.txt_PriceID.Size = new System.Drawing.Size(12, 36);
            this.txt_PriceID.TabIndex = 22;
            this.txt_PriceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_PriceID.Visible = false;
            // 
            // txt_EmployeeID
            // 
            this.txt_EmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EmployeeID.Enabled = false;
            this.txt_EmployeeID.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmployeeID.Location = new System.Drawing.Point(433, 13);
            this.txt_EmployeeID.Name = "txt_EmployeeID";
            this.txt_EmployeeID.Size = new System.Drawing.Size(21, 36);
            this.txt_EmployeeID.TabIndex = 21;
            this.txt_EmployeeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_EmployeeID.Visible = false;
            // 
            // txt_AreaID
            // 
            this.txt_AreaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_AreaID.Enabled = false;
            this.txt_AreaID.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AreaID.Location = new System.Drawing.Point(332, 13);
            this.txt_AreaID.Name = "txt_AreaID";
            this.txt_AreaID.Size = new System.Drawing.Size(12, 36);
            this.txt_AreaID.TabIndex = 20;
            this.txt_AreaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_AreaID.Visible = false;
            // 
            // txt_AreaName
            // 
            this.txt_AreaName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_AreaName.Enabled = false;
            this.txt_AreaName.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AreaName.Location = new System.Drawing.Point(674, 143);
            this.txt_AreaName.Name = "txt_AreaName";
            this.txt_AreaName.Size = new System.Drawing.Size(210, 36);
            this.txt_AreaName.TabIndex = 19;
            this.txt_AreaName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_TotalDuesInThisReading
            // 
            this.txt_TotalDuesInThisReading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TotalDuesInThisReading.Enabled = false;
            this.txt_TotalDuesInThisReading.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalDuesInThisReading.Location = new System.Drawing.Point(674, 188);
            this.txt_TotalDuesInThisReading.Name = "txt_TotalDuesInThisReading";
            this.txt_TotalDuesInThisReading.Size = new System.Drawing.Size(212, 36);
            this.txt_TotalDuesInThisReading.TabIndex = 18;
            this.txt_TotalDuesInThisReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(910, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 28);
            this.label9.TabIndex = 10;
            this.label9.Text = "المتأخرات";
            // 
            // dtp_DateOfCurrentReading
            // 
            this.dtp_DateOfCurrentReading.Enabled = false;
            this.dtp_DateOfCurrentReading.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DateOfCurrentReading.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateOfCurrentReading.Location = new System.Drawing.Point(280, 53);
            this.dtp_DateOfCurrentReading.Name = "dtp_DateOfCurrentReading";
            this.dtp_DateOfCurrentReading.Size = new System.Drawing.Size(212, 36);
            this.dtp_DateOfCurrentReading.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(498, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 28);
            this.label8.TabIndex = 10;
            this.label8.Text = "تاريخ القراءة";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(894, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "اسم العميل";
            // 
            // txt_PreviousReading
            // 
            this.txt_PreviousReading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PreviousReading.Enabled = false;
            this.txt_PreviousReading.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PreviousReading.Location = new System.Drawing.Point(332, 99);
            this.txt_PreviousReading.MaxLength = 9;
            this.txt_PreviousReading.Name = "txt_PreviousReading";
            this.txt_PreviousReading.Size = new System.Drawing.Size(193, 36);
            this.txt_PreviousReading.TabIndex = 3;
            this.txt_PreviousReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CustomerName.Enabled = false;
            this.txt_CustomerName.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustomerName.Location = new System.Drawing.Point(595, 51);
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.Size = new System.Drawing.Size(291, 36);
            this.txt_CustomerName.TabIndex = 15;
            this.txt_CustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(530, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "القراءة السابقة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(901, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "رقم العداد";
            // 
            // txt_Price
            // 
            this.txt_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Price.Enabled = false;
            this.txt_Price.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.Location = new System.Drawing.Point(332, 191);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(191, 36);
            this.txt_Price.TabIndex = 4;
            this.txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(910, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "المنطقة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(538, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "القراءة الحالية";
            // 
            // txt_CurrentReading
            // 
            this.txt_CurrentReading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CurrentReading.Enabled = false;
            this.txt_CurrentReading.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CurrentReading.Location = new System.Drawing.Point(332, 145);
            this.txt_CurrentReading.MaxLength = 10;
            this.txt_CurrentReading.Name = "txt_CurrentReading";
            this.txt_CurrentReading.Size = new System.Drawing.Size(193, 36);
            this.txt_CurrentReading.TabIndex = 5;
            this.txt_CurrentReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_CurrentReading.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CurrentReading_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(560, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "سعر الكيلو";
            // 
            // txt_ElectricityMeterID
            // 
            this.txt_ElectricityMeterID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ElectricityMeterID.Enabled = false;
            this.txt_ElectricityMeterID.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ElectricityMeterID.Location = new System.Drawing.Point(674, 98);
            this.txt_ElectricityMeterID.Name = "txt_ElectricityMeterID";
            this.txt_ElectricityMeterID.Size = new System.Drawing.Size(210, 36);
            this.txt_ElectricityMeterID.TabIndex = 1;
            this.txt_ElectricityMeterID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ElectricityMeterID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ElectricityMeterID_KeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Delete);
            this.groupBox4.Controls.Add(this.btn_Edit);
            this.groupBox4.Controls.Add(this.btn_Save);
            this.groupBox4.Controls.Add(this.btn_New);
            this.groupBox4.Location = new System.Drawing.Point(11, 667);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(994, 107);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.Location = new System.Drawing.Point(152, 20);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(91, 80);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Enabled = false;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.Image")));
            this.btn_Edit.Location = new System.Drawing.Point(321, 21);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(91, 80);
            this.btn_Edit.TabIndex = 8;
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.Location = new System.Drawing.Point(483, 12);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(91, 89);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_New
            // 
            this.btn_New.FlatAppearance.BorderSize = 0;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.Image")));
            this.btn_New.Location = new System.Drawing.Point(674, 20);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(91, 81);
            this.btn_New.TabIndex = 10;
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Readings);
            this.groupBox2.Font = new System.Drawing.Font("Droid Arabic Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(998, 398);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جميع القراءات السابقة للعداد المحدد";
            // 
            // dgv_Readings
            // 
            this.dgv_Readings.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.5F);
            this.dgv_Readings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Readings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Arabic Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Readings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Readings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Droid Arabic Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Readings.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Readings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Readings.Location = new System.Drawing.Point(3, 36);
            this.dgv_Readings.Name = "dgv_Readings";
            this.dgv_Readings.ReadOnly = true;
            this.dgv_Readings.RowHeadersVisible = false;
            this.dgv_Readings.RowHeadersWidth = 51;
            this.dgv_Readings.RowTemplate.Height = 40;
            this.dgv_Readings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Readings.Size = new System.Drawing.Size(992, 359);
            this.dgv_Readings.TabIndex = 31;
            this.dgv_Readings.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Readings_CellDoubleClick);
            // 
            // frm_Readings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 784);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Readings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "القراءات";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ReadingPhoto)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Readings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_PreviousReading;
        private System.Windows.Forms.TextBox txt_CustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CurrentReading;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ElectricityMeterID;
        private System.Windows.Forms.TextBox txt_TotalDuesInThisReading;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_DateOfCurrentReading;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_AreaName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.TextBox txt_AreaID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Readings;
        private System.Windows.Forms.TextBox txt_PriceID;
        private System.Windows.Forms.TextBox txt_EmployeeID;
        private System.Windows.Forms.Button btn_DeleteReadingImage;
        private System.Windows.Forms.Button btn_AddReadingImage;
        private System.Windows.Forms.PictureBox pb_ReadingPhoto;
    }
}
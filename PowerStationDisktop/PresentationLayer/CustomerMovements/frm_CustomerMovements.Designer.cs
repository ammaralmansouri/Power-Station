﻿
namespace PowerStationDisktop.PresentationLayer.CustomerMovements
{
    partial class frm_CustomerMovements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CustomerMovements));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ElectricityMeterID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rich_CustomerMovementNote = new System.Windows.Forms.RichTextBox();
            this.txt_CustomerMovementID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_CustomerMovementType = new System.Windows.Forms.ComboBox();
            this.txt_EmployeeID = new System.Windows.Forms.TextBox();
            this.txt_CustomerID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_CustomerMovementDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_CustomerMovementPaiedAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TotalDuesAfterPaying = new System.Windows.Forms.TextBox();
            this.txt_ElectricityMeterIDOrPhoneNumber = new System.Windows.Forms.TextBox();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ElectricityMeterID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rich_CustomerMovementNote);
            this.groupBox1.Controls.Add(this.txt_CustomerMovementID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_CustomerName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmb_CustomerMovementType);
            this.groupBox1.Controls.Add(this.txt_EmployeeID);
            this.groupBox1.Controls.Add(this.txt_CustomerID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtp_CustomerMovementDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_CustomerMovementPaiedAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_TotalDuesAfterPaying);
            this.groupBox1.Controls.Add(this.txt_ElectricityMeterIDOrPhoneNumber);
            this.groupBox1.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 352);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "سند قبض جديد";
            // 
            // txt_ElectricityMeterID
            // 
            this.txt_ElectricityMeterID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ElectricityMeterID.Enabled = false;
            this.txt_ElectricityMeterID.Location = new System.Drawing.Point(113, 24);
            this.txt_ElectricityMeterID.Name = "txt_ElectricityMeterID";
            this.txt_ElectricityMeterID.Size = new System.Drawing.Size(167, 39);
            this.txt_ElectricityMeterID.TabIndex = 27;
            this.txt_ElectricityMeterID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ElectricityMeterID.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(855, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "رقم السند";
            // 
            // rich_CustomerMovementNote
            // 
            this.rich_CustomerMovementNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rich_CustomerMovementNote.Enabled = false;
            this.rich_CustomerMovementNote.Font = new System.Drawing.Font("Droid Arabic Kufi", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich_CustomerMovementNote.Location = new System.Drawing.Point(21, 260);
            this.rich_CustomerMovementNote.Name = "rich_CustomerMovementNote";
            this.rich_CustomerMovementNote.Size = new System.Drawing.Size(730, 79);
            this.rich_CustomerMovementNote.TabIndex = 24;
            this.rich_CustomerMovementNote.Text = "";
            // 
            // txt_CustomerMovementID
            // 
            this.txt_CustomerMovementID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CustomerMovementID.Enabled = false;
            this.txt_CustomerMovementID.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustomerMovementID.Location = new System.Drawing.Point(697, 47);
            this.txt_CustomerMovementID.Name = "txt_CustomerMovementID";
            this.txt_CustomerMovementID.Size = new System.Drawing.Size(138, 36);
            this.txt_CustomerMovementID.TabIndex = 26;
            this.txt_CustomerMovementID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(878, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "البيان";
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CustomerName.Enabled = false;
            this.txt_CustomerName.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustomerName.Location = new System.Drawing.Point(21, 104);
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.Size = new System.Drawing.Size(325, 36);
            this.txt_CustomerName.TabIndex = 15;
            this.txt_CustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(353, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "اسم العميل";
            // 
            // cmb_CustomerMovementType
            // 
            this.cmb_CustomerMovementType.Enabled = false;
            this.cmb_CustomerMovementType.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CustomerMovementType.FormattingEnabled = true;
            this.cmb_CustomerMovementType.Items.AddRange(new object[] {
            "كاش",
            "دفع الكتروني"});
            this.cmb_CustomerMovementType.Location = new System.Drawing.Point(21, 211);
            this.cmb_CustomerMovementType.Name = "cmb_CustomerMovementType";
            this.cmb_CustomerMovementType.Size = new System.Drawing.Size(325, 36);
            this.cmb_CustomerMovementType.TabIndex = 25;
            this.cmb_CustomerMovementType.Text = "كاش";
            // 
            // txt_EmployeeID
            // 
            this.txt_EmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EmployeeID.Enabled = false;
            this.txt_EmployeeID.Location = new System.Drawing.Point(21, 25);
            this.txt_EmployeeID.Name = "txt_EmployeeID";
            this.txt_EmployeeID.Size = new System.Drawing.Size(35, 39);
            this.txt_EmployeeID.TabIndex = 22;
            this.txt_EmployeeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_EmployeeID.Visible = false;
            // 
            // txt_CustomerID
            // 
            this.txt_CustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CustomerID.Enabled = false;
            this.txt_CustomerID.Location = new System.Drawing.Point(62, 24);
            this.txt_CustomerID.Name = "txt_CustomerID";
            this.txt_CustomerID.Size = new System.Drawing.Size(35, 39);
            this.txt_CustomerID.TabIndex = 21;
            this.txt_CustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_CustomerID.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(368, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 28);
            this.label9.TabIndex = 10;
            this.label9.Text = "نوع الدفع";
            // 
            // dtp_CustomerMovementDate
            // 
            this.dtp_CustomerMovementDate.Enabled = false;
            this.dtp_CustomerMovementDate.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_CustomerMovementDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_CustomerMovementDate.Location = new System.Drawing.Point(477, 211);
            this.dtp_CustomerMovementDate.Name = "dtp_CustomerMovementDate";
            this.dtp_CustomerMovementDate.Size = new System.Drawing.Size(274, 36);
            this.dtp_CustomerMovementDate.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(847, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 28);
            this.label8.TabIndex = 10;
            this.label8.Text = "تاريخ السند";
            // 
            // txt_CustomerMovementPaiedAmount
            // 
            this.txt_CustomerMovementPaiedAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CustomerMovementPaiedAmount.Enabled = false;
            this.txt_CustomerMovementPaiedAmount.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustomerMovementPaiedAmount.Location = new System.Drawing.Point(21, 157);
            this.txt_CustomerMovementPaiedAmount.MaxLength = 9;
            this.txt_CustomerMovementPaiedAmount.Name = "txt_CustomerMovementPaiedAmount";
            this.txt_CustomerMovementPaiedAmount.Size = new System.Drawing.Size(325, 36);
            this.txt_CustomerMovementPaiedAmount.TabIndex = 3;
            this.txt_CustomerMovementPaiedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_CustomerMovementPaiedAmount.TextChanged += new System.EventHandler(this.txt_CustomerMovementPaiedAmount_TextChanged);
            this.txt_CustomerMovementPaiedAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CustomerMovementPaiedAmount_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "مبلغ السند";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(754, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "رقم العداد/ رقم الهاتف";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(863, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "المتأخرات";
            // 
            // txt_TotalDuesAfterPaying
            // 
            this.txt_TotalDuesAfterPaying.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TotalDuesAfterPaying.Enabled = false;
            this.txt_TotalDuesAfterPaying.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalDuesAfterPaying.Location = new System.Drawing.Point(477, 157);
            this.txt_TotalDuesAfterPaying.Name = "txt_TotalDuesAfterPaying";
            this.txt_TotalDuesAfterPaying.Size = new System.Drawing.Size(274, 36);
            this.txt_TotalDuesAfterPaying.TabIndex = 5;
            this.txt_TotalDuesAfterPaying.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ElectricityMeterIDOrPhoneNumber
            // 
            this.txt_ElectricityMeterIDOrPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ElectricityMeterIDOrPhoneNumber.Enabled = false;
            this.txt_ElectricityMeterIDOrPhoneNumber.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ElectricityMeterIDOrPhoneNumber.Location = new System.Drawing.Point(477, 101);
            this.txt_ElectricityMeterIDOrPhoneNumber.Name = "txt_ElectricityMeterIDOrPhoneNumber";
            this.txt_ElectricityMeterIDOrPhoneNumber.Size = new System.Drawing.Size(274, 36);
            this.txt_ElectricityMeterIDOrPhoneNumber.TabIndex = 1;
            this.txt_ElectricityMeterIDOrPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ElectricityMeterIDOrPhoneNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ElectricityMeterIDOrPhoneNumber_KeyDown);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Enabled = false;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(613, 396);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(129, 41);
            this.btn_Edit.TabIndex = 12;
            this.btn_Edit.Text = "حفظ وطباعة";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.Location = new System.Drawing.Point(405, 380);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(91, 69);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_New
            // 
            this.btn_New.FlatAppearance.BorderSize = 0;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.Image")));
            this.btn_New.Location = new System.Drawing.Point(185, 378);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(91, 73);
            this.btn_New.TabIndex = 13;
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frm_CustomerMovements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 463);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CustomerMovements";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حركة العملاء ( سندات القبض )";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_EmployeeID;
        private System.Windows.Forms.TextBox txt_CustomerID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_CustomerMovementDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_CustomerMovementPaiedAmount;
        private System.Windows.Forms.TextBox txt_CustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TotalDuesAfterPaying;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ElectricityMeterIDOrPhoneNumber;
        private System.Windows.Forms.RichTextBox rich_CustomerMovementNote;
        private System.Windows.Forms.ComboBox cmb_CustomerMovementType;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CustomerMovementID;
        private System.Windows.Forms.TextBox txt_ElectricityMeterID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
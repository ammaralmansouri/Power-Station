
namespace PowerStationDisktop.PresentationLayer.PaymentVoucher
{
    partial class frm_SalaryPayment
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
            this.txt_EmployeeTotalCredit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rich_PaymentVoucherNote = new System.Windows.Forms.RichTextBox();
            this.txt_PaymentVoucherID = new System.Windows.Forms.TextBox();
            this.btn_New = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_EmployeeSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_EmplyeePhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_PaymentVoucherEmployeeNameWhoTake = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_EmployeeIDWhoGive = new System.Windows.Forms.TextBox();
            this.txt_EmployeeIDWhoTake = new System.Windows.Forms.TextBox();
            this.dtp_PaymentVoucherDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_PaymentVoucherAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_EmployeeTotalCredit
            // 
            this.txt_EmployeeTotalCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EmployeeTotalCredit.Enabled = false;
            this.txt_EmployeeTotalCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmployeeTotalCredit.Location = new System.Drawing.Point(7, 88);
            this.txt_EmployeeTotalCredit.Name = "txt_EmployeeTotalCredit";
            this.txt_EmployeeTotalCredit.Size = new System.Drawing.Size(157, 26);
            this.txt_EmployeeTotalCredit.TabIndex = 32;
            this.txt_EmployeeTotalCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(170, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "اجمالي السلف السابقة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(648, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "رقم السند";
            // 
            // rich_PaymentVoucherNote
            // 
            this.rich_PaymentVoucherNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rich_PaymentVoucherNote.Enabled = false;
            this.rich_PaymentVoucherNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich_PaymentVoucherNote.Location = new System.Drawing.Point(10, 134);
            this.rich_PaymentVoucherNote.Name = "rich_PaymentVoucherNote";
            this.rich_PaymentVoucherNote.Size = new System.Drawing.Size(236, 62);
            this.rich_PaymentVoucherNote.TabIndex = 24;
            this.rich_PaymentVoucherNote.Text = "";
            // 
            // txt_PaymentVoucherID
            // 
            this.txt_PaymentVoucherID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PaymentVoucherID.Enabled = false;
            this.txt_PaymentVoucherID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PaymentVoucherID.Location = new System.Drawing.Point(510, 34);
            this.txt_PaymentVoucherID.Name = "txt_PaymentVoucherID";
            this.txt_PaymentVoucherID.Size = new System.Drawing.Size(121, 26);
            this.txt_PaymentVoucherID.TabIndex = 26;
            this.txt_PaymentVoucherID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_New
            // 
            this.btn_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Location = new System.Drawing.Point(239, 289);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(80, 42);
            this.btn_New.TabIndex = 21;
            this.btn_New.Text = "جديد";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_EmployeeSalary);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_EmployeeTotalCredit);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rich_PaymentVoucherNote);
            this.groupBox1.Controls.Add(this.txt_PaymentVoucherID);
            this.groupBox1.Controls.Add(this.txt_EmplyeePhoneNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_PaymentVoucherEmployeeNameWhoTake);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_EmployeeIDWhoGive);
            this.groupBox1.Controls.Add(this.txt_EmployeeIDWhoTake);
            this.groupBox1.Controls.Add(this.dtp_PaymentVoucherDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_PaymentVoucherAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 218);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "سند صرف جديد ( راتب )";
            // 
            // txt_EmployeeSalary
            // 
            this.txt_EmployeeSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EmployeeSalary.Enabled = false;
            this.txt_EmployeeSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmployeeSalary.Location = new System.Drawing.Point(322, 88);
            this.txt_EmployeeSalary.Name = "txt_EmployeeSalary";
            this.txt_EmployeeSalary.Size = new System.Drawing.Size(157, 26);
            this.txt_EmployeeSalary.TabIndex = 34;
            this.txt_EmployeeSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(494, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "الراتب المستحق";
            // 
            // txt_EmplyeePhoneNumber
            // 
            this.txt_EmplyeePhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EmplyeePhoneNumber.Enabled = false;
            this.txt_EmplyeePhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmplyeePhoneNumber.Location = new System.Drawing.Point(235, 34);
            this.txt_EmplyeePhoneNumber.Name = "txt_EmplyeePhoneNumber";
            this.txt_EmplyeePhoneNumber.Size = new System.Drawing.Size(157, 26);
            this.txt_EmplyeePhoneNumber.TabIndex = 1;
            this.txt_EmplyeePhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_EmplyeePhoneNumber.TextChanged += new System.EventHandler(this.txt_EmplyeePhoneNumber_TextChanged);
            this.txt_EmplyeePhoneNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_EmplyeePhoneNumber_KeyDown);
            this.txt_EmplyeePhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_EmplyeePhoneNumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = " رقم الهاتف";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(250, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "البيان";
            // 
            // txt_PaymentVoucherEmployeeNameWhoTake
            // 
            this.txt_PaymentVoucherEmployeeNameWhoTake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PaymentVoucherEmployeeNameWhoTake.Enabled = false;
            this.txt_PaymentVoucherEmployeeNameWhoTake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PaymentVoucherEmployeeNameWhoTake.Location = new System.Drawing.Point(619, 91);
            this.txt_PaymentVoucherEmployeeNameWhoTake.Name = "txt_PaymentVoucherEmployeeNameWhoTake";
            this.txt_PaymentVoucherEmployeeNameWhoTake.Size = new System.Drawing.Size(166, 26);
            this.txt_PaymentVoucherEmployeeNameWhoTake.TabIndex = 15;
            this.txt_PaymentVoucherEmployeeNameWhoTake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(795, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "اسم الموظف";
            // 
            // txt_EmployeeIDWhoGive
            // 
            this.txt_EmployeeIDWhoGive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EmployeeIDWhoGive.Enabled = false;
            this.txt_EmployeeIDWhoGive.Location = new System.Drawing.Point(18, 34);
            this.txt_EmployeeIDWhoGive.Name = "txt_EmployeeIDWhoGive";
            this.txt_EmployeeIDWhoGive.Size = new System.Drawing.Size(31, 26);
            this.txt_EmployeeIDWhoGive.TabIndex = 22;
            this.txt_EmployeeIDWhoGive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_EmployeeIDWhoTake
            // 
            this.txt_EmployeeIDWhoTake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EmployeeIDWhoTake.Enabled = false;
            this.txt_EmployeeIDWhoTake.Location = new System.Drawing.Point(54, 33);
            this.txt_EmployeeIDWhoTake.Name = "txt_EmployeeIDWhoTake";
            this.txt_EmployeeIDWhoTake.Size = new System.Drawing.Size(31, 26);
            this.txt_EmployeeIDWhoTake.TabIndex = 21;
            this.txt_EmployeeIDWhoTake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtp_PaymentVoucherDate
            // 
            this.dtp_PaymentVoucherDate.Enabled = false;
            this.dtp_PaymentVoucherDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_PaymentVoucherDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_PaymentVoucherDate.Location = new System.Drawing.Point(322, 150);
            this.dtp_PaymentVoucherDate.Name = "dtp_PaymentVoucherDate";
            this.dtp_PaymentVoucherDate.Size = new System.Drawing.Size(157, 28);
            this.dtp_PaymentVoucherDate.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(523, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "تاريخ السند";
            // 
            // txt_PaymentVoucherAmount
            // 
            this.txt_PaymentVoucherAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PaymentVoucherAmount.Enabled = false;
            this.txt_PaymentVoucherAmount.Location = new System.Drawing.Point(619, 150);
            this.txt_PaymentVoucherAmount.MaxLength = 9;
            this.txt_PaymentVoucherAmount.Name = "txt_PaymentVoucherAmount";
            this.txt_PaymentVoucherAmount.Size = new System.Drawing.Size(166, 26);
            this.txt_PaymentVoucherAmount.TabIndex = 3;
            this.txt_PaymentVoucherAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(788, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "المبلغ المستحق";
            // 
            // btn_Edit
            // 
            this.btn_Edit.Enabled = false;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(596, 290);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(113, 41);
            this.btn_Edit.TabIndex = 20;
            this.btn_Edit.Text = "حفظ وطباعة";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(413, 290);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(80, 41);
            this.btn_Save.TabIndex = 19;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_SalaryPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 363);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Save);
            this.Name = "frm_SalaryPayment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "دفع الرواتب";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_EmployeeTotalCredit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rich_PaymentVoucherNote;
        private System.Windows.Forms.TextBox txt_PaymentVoucherID;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_EmployeeSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_EmplyeePhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_PaymentVoucherEmployeeNameWhoTake;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_EmployeeIDWhoGive;
        private System.Windows.Forms.TextBox txt_EmployeeIDWhoTake;
        private System.Windows.Forms.DateTimePicker dtp_PaymentVoucherDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_PaymentVoucherAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Save;
    }
}
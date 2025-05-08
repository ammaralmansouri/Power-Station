
namespace PowerStationDisktop.PresentationLayer.Login
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_EmployeePhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_EmployeePassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Font = new System.Drawing.Font("Droid Arabic Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(314, 153);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(116, 44);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "خروج";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Droid Arabic Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login.Location = new System.Drawing.Point(177, 153);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(118, 44);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "دخول";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "كلمة المرور";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "رقم الهاتف";
            // 
            // txt_EmployeePhoneNumber
            // 
            this.txt_EmployeePhoneNumber.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmployeePhoneNumber.Location = new System.Drawing.Point(177, 49);
            this.txt_EmployeePhoneNumber.Name = "txt_EmployeePhoneNumber";
            this.txt_EmployeePhoneNumber.Size = new System.Drawing.Size(280, 36);
            this.txt_EmployeePhoneNumber.TabIndex = 1;
            this.txt_EmployeePhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_EmployeePhoneNumber.TextChanged += new System.EventHandler(this.txt_EmployeePhoneNumber_TextChanged);
            this.txt_EmployeePhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_EmployeePhoneNumber_KeyPress);
            // 
            // txt_EmployeePassword
            // 
            this.txt_EmployeePassword.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmployeePassword.Location = new System.Drawing.Point(177, 95);
            this.txt_EmployeePassword.MaxLength = 20;
            this.txt_EmployeePassword.Name = "txt_EmployeePassword";
            this.txt_EmployeePassword.PasswordChar = '*';
            this.txt_EmployeePassword.Size = new System.Drawing.Size(280, 36);
            this.txt_EmployeePassword.TabIndex = 2;
            this.txt_EmployeePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_EmployeePassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_EmployeePassword_KeyDown);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 231);
            this.Controls.Add(this.txt_EmployeePassword);
            this.Controls.Add(this.txt_EmployeePhoneNumber);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";

            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_EmployeePhoneNumber;
        private System.Windows.Forms.TextBox txt_EmployeePassword;
    }
}
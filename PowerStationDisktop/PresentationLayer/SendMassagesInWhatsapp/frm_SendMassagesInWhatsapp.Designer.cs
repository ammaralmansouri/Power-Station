﻿
namespace PowerStationDisktop.PresentationLayer.SendMassagesInWhatsapp
{
    partial class frm_SendMassagesInWhatsapp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SendMassagesInWhatsapp));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chk_SendForAll = new System.Windows.Forms.CheckBox();
            this.cmb_AreaName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rich_MessageText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F);
            this.tabControl1.Location = new System.Drawing.Point(14, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(470, 500);
            this.tabControl1.TabIndex = 20;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txt_PhoneNumber);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(462, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ارسال لرقم محدد";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PhoneNumber.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PhoneNumber.Location = new System.Drawing.Point(61, 185);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(235, 36);
            this.txt_PhoneNumber.TabIndex = 12;
            this.txt_PhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_PhoneNumber.TextChanged += new System.EventHandler(this.txt_PhoneNumber_TextChanged);
            this.txt_PhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PhoneNumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = " رقم الهاتف";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.chk_SendForAll);
            this.tabPage2.Controls.Add(this.cmb_AreaName);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(462, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ارسال لأكثر من مستلم";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chk_SendForAll
            // 
            this.chk_SendForAll.AutoSize = true;
            this.chk_SendForAll.Location = new System.Drawing.Point(46, 219);
            this.chk_SendForAll.Name = "chk_SendForAll";
            this.chk_SendForAll.Size = new System.Drawing.Size(311, 32);
            this.chk_SendForAll.TabIndex = 2;
            this.chk_SendForAll.Text = "ارسال الرسالة لكل العملاء في كل المناطق";
            this.chk_SendForAll.UseVisualStyleBackColor = true;
            this.chk_SendForAll.CheckedChanged += new System.EventHandler(this.chk_SendForAll_CheckedChanged);
            // 
            // cmb_AreaName
            // 
            this.cmb_AreaName.FormattingEnabled = true;
            this.cmb_AreaName.Location = new System.Drawing.Point(73, 171);
            this.cmb_AreaName.Name = "cmb_AreaName";
            this.cmb_AreaName.Size = new System.Drawing.Size(214, 36);
            this.cmb_AreaName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "اسم المنطقة";
            // 
            // rich_MessageText
            // 
            this.rich_MessageText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rich_MessageText.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F);
            this.rich_MessageText.Location = new System.Drawing.Point(490, 42);
            this.rich_MessageText.Name = "rich_MessageText";
            this.rich_MessageText.Size = new System.Drawing.Size(550, 403);
            this.rich_MessageText.TabIndex = 21;
            this.rich_MessageText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "نص الرسالة";
            // 
            // btn_Send
            // 
            this.btn_Send.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.Location = new System.Drawing.Point(752, 470);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(91, 42);
            this.btn_Send.TabIndex = 23;
            this.btn_Send.Text = "ارسال";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // frm_SendMassagesInWhatsapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 536);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rich_MessageText);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_SendMassagesInWhatsapp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ارسال الرسائل عبر الواتساب";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rich_MessageText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_SendForAll;
        private System.Windows.Forms.ComboBox cmb_AreaName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Send;
    }
}

namespace PowerStationDisktop.PresentationLayer.Employees
{
    partial class frm_StartAndEndOfCollection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_StartAndEndOfCollection));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_StartDateOfCollection = new System.Windows.Forms.DateTimePicker();
            this.dtp_EndDateOfCollection = new System.Windows.Forms.DateTimePicker();
            this.btn_EnableCollectionForAllEmployee = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "تاريخ نهاية التحصيل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(707, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "تاريخ بداية التحصيل";
            // 
            // dtp_StartDateOfCollection
            // 
            this.dtp_StartDateOfCollection.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_StartDateOfCollection.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_StartDateOfCollection.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_StartDateOfCollection.Location = new System.Drawing.Point(504, 92);
            this.dtp_StartDateOfCollection.Name = "dtp_StartDateOfCollection";
            this.dtp_StartDateOfCollection.Size = new System.Drawing.Size(192, 36);
            this.dtp_StartDateOfCollection.TabIndex = 18;
            // 
            // dtp_EndDateOfCollection
            // 
            this.dtp_EndDateOfCollection.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_EndDateOfCollection.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_EndDateOfCollection.Location = new System.Drawing.Point(83, 92);
            this.dtp_EndDateOfCollection.Name = "dtp_EndDateOfCollection";
            this.dtp_EndDateOfCollection.Size = new System.Drawing.Size(202, 36);
            this.dtp_EndDateOfCollection.TabIndex = 19;
            // 
            // btn_EnableCollectionForAllEmployee
            // 
            this.btn_EnableCollectionForAllEmployee.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F);
            this.btn_EnableCollectionForAllEmployee.Location = new System.Drawing.Point(252, 154);
            this.btn_EnableCollectionForAllEmployee.Name = "btn_EnableCollectionForAllEmployee";
            this.btn_EnableCollectionForAllEmployee.Size = new System.Drawing.Size(351, 41);
            this.btn_EnableCollectionForAllEmployee.TabIndex = 20;
            this.btn_EnableCollectionForAllEmployee.Text = "السماح بالتحصيل لجميع المحصلين";
            this.btn_EnableCollectionForAllEmployee.UseVisualStyleBackColor = true;
            this.btn_EnableCollectionForAllEmployee.Click += new System.EventHandler(this.btn_EnableCollectionForAllEmployee_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_EnableCollectionForAllEmployee);
            this.groupBox1.Controls.Add(this.dtp_StartDateOfCollection);
            this.groupBox1.Controls.Add(this.dtp_EndDateOfCollection);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 210);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "قم بتحديد بداية ونهاية تاريخ التحصيل";
            // 
            // frm_StartAndEndOfCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 231);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_StartAndEndOfCollection";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحديد تاريخ التحصيل";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_StartDateOfCollection;
        private System.Windows.Forms.DateTimePicker dtp_EndDateOfCollection;
        private System.Windows.Forms.Button btn_EnableCollectionForAllEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}

namespace PowerStationDisktop.PresentationLayer.Permissions
{
    partial class frm_CurrentPermisions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CurrentPermisions));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_CurrentPermissions = new System.Windows.Forms.DataGridView();
            this.dtp_StartOfCollectionDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_EndOfCollectionDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_EmployeeName = new System.Windows.Forms.TextBox();
            this.txt_PermissionID = new System.Windows.Forms.TextBox();
            this.txt_AreaName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CurrentPermissions)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_CurrentPermissions);
            this.groupBox1.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الصلاحيات المتاحة حاليا للمحصلين";
            // 
            // dgv_CurrentPermissions
            // 
            this.dgv_CurrentPermissions.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.5F);
            this.dgv_CurrentPermissions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_CurrentPermissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CurrentPermissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_CurrentPermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CurrentPermissions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_CurrentPermissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CurrentPermissions.Location = new System.Drawing.Point(3, 35);
            this.dgv_CurrentPermissions.Name = "dgv_CurrentPermissions";
            this.dgv_CurrentPermissions.ReadOnly = true;
            this.dgv_CurrentPermissions.RowHeadersVisible = false;
            this.dgv_CurrentPermissions.RowHeadersWidth = 51;
            this.dgv_CurrentPermissions.RowTemplate.Height = 40;
            this.dgv_CurrentPermissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CurrentPermissions.Size = new System.Drawing.Size(770, 330);
            this.dgv_CurrentPermissions.TabIndex = 0;
            this.dgv_CurrentPermissions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CurrentPermissions_CellDoubleClick);
            // 
            // dtp_StartOfCollectionDate
            // 
            this.dtp_StartOfCollectionDate.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_StartOfCollectionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_StartOfCollectionDate.Location = new System.Drawing.Point(210, 94);
            this.dtp_StartOfCollectionDate.Name = "dtp_StartOfCollectionDate";
            this.dtp_StartOfCollectionDate.Size = new System.Drawing.Size(156, 36);
            this.dtp_StartOfCollectionDate.TabIndex = 1;
            // 
            // dtp_EndOfCollectionDate
            // 
            this.dtp_EndOfCollectionDate.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_EndOfCollectionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_EndOfCollectionDate.Location = new System.Drawing.Point(511, 94);
            this.dtp_EndOfCollectionDate.Name = "dtp_EndOfCollectionDate";
            this.dtp_EndOfCollectionDate.Size = new System.Drawing.Size(175, 36);
            this.dtp_EndOfCollectionDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "بداية التحصيل";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "نهاية التحصيل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "الإسم";
            // 
            // txt_EmployeeName
            // 
            this.txt_EmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EmployeeName.Enabled = false;
            this.txt_EmployeeName.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmployeeName.Location = new System.Drawing.Point(148, 37);
            this.txt_EmployeeName.Name = "txt_EmployeeName";
            this.txt_EmployeeName.Size = new System.Drawing.Size(218, 36);
            this.txt_EmployeeName.TabIndex = 15;
            this.txt_EmployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_PermissionID
            // 
            this.txt_PermissionID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PermissionID.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PermissionID.Location = new System.Drawing.Point(736, 37);
            this.txt_PermissionID.Name = "txt_PermissionID";
            this.txt_PermissionID.Size = new System.Drawing.Size(28, 36);
            this.txt_PermissionID.TabIndex = 16;
            // 
            // txt_AreaName
            // 
            this.txt_AreaName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_AreaName.Enabled = false;
            this.txt_AreaName.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AreaName.Location = new System.Drawing.Point(468, 37);
            this.txt_AreaName.Name = "txt_AreaName";
            this.txt_AreaName.Size = new System.Drawing.Size(218, 36);
            this.txt_AreaName.TabIndex = 18;
            this.txt_AreaName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "المنطقة";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Location = new System.Drawing.Point(15, 531);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 98);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.Location = new System.Drawing.Point(258, 15);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(86, 77);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.Location = new System.Drawing.Point(431, 15);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(87, 77);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_CurrentPermisions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 641);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_AreaName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_PermissionID);
            this.Controls.Add(this.txt_EmployeeName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_EndOfCollectionDate);
            this.Controls.Add(this.dtp_StartOfCollectionDate);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CurrentPermisions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جميع الصلاحيات الحالية";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CurrentPermissions)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_CurrentPermissions;
        private System.Windows.Forms.DateTimePicker dtp_StartOfCollectionDate;
        private System.Windows.Forms.DateTimePicker dtp_EndOfCollectionDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_EmployeeName;
        private System.Windows.Forms.TextBox txt_PermissionID;
        private System.Windows.Forms.TextBox txt_AreaName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
    }
}
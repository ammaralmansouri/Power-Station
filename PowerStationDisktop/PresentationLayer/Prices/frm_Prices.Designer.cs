
namespace PowerStationDisktop.PresentationLayer.Prices
{
    partial class frm_Prices
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PriceOfKilo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Prices = new System.Windows.Forms.DataGridView();
            this.btn_Save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Prices)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "سعر الكيلو";
            // 
            // txt_PriceOfKilo
            // 
            this.txt_PriceOfKilo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PriceOfKilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PriceOfKilo.Location = new System.Drawing.Point(157, 32);
            this.txt_PriceOfKilo.Name = "txt_PriceOfKilo";
            this.txt_PriceOfKilo.Size = new System.Drawing.Size(192, 30);
            this.txt_PriceOfKilo.TabIndex = 12;
            this.txt_PriceOfKilo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_PriceOfKilo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PriceOfKilo_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Prices);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 261);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "سجل الأسعار";
            // 
            // dgv_Prices
            // 
            this.dgv_Prices.AllowUserToAddRows = false;
            this.dgv_Prices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Prices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Prices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Prices.Location = new System.Drawing.Point(3, 22);
            this.dgv_Prices.Name = "dgv_Prices";
            this.dgv_Prices.RowHeadersVisible = false;
            this.dgv_Prices.RowHeadersWidth = 51;
            this.dgv_Prices.RowTemplate.Height = 24;
            this.dgv_Prices.Size = new System.Drawing.Size(411, 236);
            this.dgv_Prices.TabIndex = 31;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(167, 363);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(91, 41);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Prices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 427);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_PriceOfKilo);
            this.Name = "frm_Prices";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الأسعار";

            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Prices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PriceOfKilo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Prices;
        private System.Windows.Forms.Button btn_Save;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerStationDisktop.BusinessLayer.Settings;

namespace PowerStationDisktop.PresentationLayer.Prices
{
    public partial class frm_Prices : Form
    {

        BusinessLayer.Pices.ClsPrices price = new BusinessLayer.Pices.ClsPrices();

        public frm_Prices()
        {
            InitializeComponent();
            GetAllPrices();

            // This is for font size in DataGridView ..
            dgv_Prices.DefaultCellStyle.Font = ClsAppFontSize.GetDefaultCellStyleFont(dgv_Prices.DefaultCellStyle.Font);
            dgv_Prices.AlternatingRowsDefaultCellStyle.Font = ClsAppFontSize.GetAlternatingRowsDefaultCellStyleFont(dgv_Prices.AlternatingRowsDefaultCellStyle.Font);
            dgv_Prices.ColumnHeadersDefaultCellStyle.Font = ClsAppFontSize.GetColumnHeaderDefaultCellStyleFont(dgv_Prices.ColumnHeadersDefaultCellStyle.Font);

            // To set the max length from my settings ..
            txt_PriceOfKilo.MaxLength = ClsFieldsRange.PriceMaxLength;
        }

        void GetAllPrices()
        {
            dgv_Prices.DataSource = price.GetAllPrices();

            dgv_Prices.Columns[0].HeaderText = "الرقم";
            dgv_Prices.Columns[1].HeaderText = "السعر";
            dgv_Prices.Columns[2].HeaderText = "تم التعديل من قِبل";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txt_PriceOfKilo.Text))
                {
                    string input = txt_PriceOfKilo.Text.Trim();

                    // التحقق من أن الإدخال يحتوي على نقطة واحدة كحد أقصى
                    int dotCount = input.Count(c => c == '.');
                    if (dotCount > 1)
                    {
                        MessageBox.Show("لا يمكن إدخال أكثر من فاصلة عشرية ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // التحقق من أن القيمة رقمية وصحيحة
                    if (double.TryParse(input, out double priceValue))
                    {
                        price.AddNewPrice(priceValue, Convert.ToInt32(Program.EmployeeID));
                        MessageBox.Show("تم إضافة السعر بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txt_PriceOfKilo.Text = string.Empty;
                        GetAllPrices();

                        txt_PriceOfKilo.Enabled = false;
                        btn_Save.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("الرجاء إدخال رقم صالح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("تأكد من تعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ: {ex.Message}\n\nالمصدر: {ex.Source}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txt_PriceOfKilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 46    ) // => this for dot( . )..
            {
                e.Handled = true;
            }



        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            txt_PriceOfKilo.Text = string.Empty;
            txt_PriceOfKilo.Enabled = true;

            btn_Save.Enabled = true;

            txt_PriceOfKilo.Focus();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerStationDisktop.PresentationLayer.Prices
{
    public partial class frm_Prices : Form
    {

        BusinessLayer.Pices.ClsPrices price = new BusinessLayer.Pices.ClsPrices();

        public frm_Prices()
        {
            InitializeComponent();
            GetAllPrices();
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
            if(txt_PriceOfKilo.Text != String.Empty)
            {
                price.AddNewPrice(Convert.ToDouble(txt_PriceOfKilo.Text),1);
                txt_PriceOfKilo.Text = string.Empty;
                GetAllPrices();
            }
            else
                MessageBox.Show("تأكد من تعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txt_PriceOfKilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }



        }
    }
}

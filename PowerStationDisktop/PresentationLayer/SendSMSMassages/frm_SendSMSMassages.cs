using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Text.Json;

namespace PowerStationDisktop.PresentationLayer.SendSMSMassages
{
    public partial class frm_SendSMSMassages : Form
    {

        BusinessLayer.Areas.ClsAreas areas = new BusinessLayer.Areas.ClsAreas();
        BusinessLayer.SendMassagesInWhatsapp.ClsSendMassagesInWhatsapp sendMassagesInWhatsapp = new BusinessLayer.SendMassagesInWhatsapp.ClsSendMassagesInWhatsapp();
        private Regex regex = new Regex(@"^7[80137]\d{7}$");

        public frm_SendSMSMassages()
        {
            InitializeComponent();
            GetAllAreas();
        }

        void GetAllAreas()
        {
            cmb_AreaName.DataSource = areas.GetAllAreas();

            cmb_AreaName.DisplayMember = "AreaName";
            cmb_AreaName.ValueMember = "AreaID";
        }

        private void chk_SendForAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_SendForAll.Checked)
            {
                cmb_AreaName.Enabled = false;
            }
            else
            {
                cmb_AreaName.Enabled = true;
            }
        }

        private void txt_PhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string input = txt_PhoneNumber.Text;
            if (!regex.IsMatch(input))
            {
                //MessageBox.Show("لطفا ادخل رقم هاتف صحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txt_PhoneNumber.BackColor = Color.Red;

                //txt_CustomerPhone.Clear();
            }
            else
            {
                txt_PhoneNumber.BackColor = Color.White;
            }
        }

        private void txt_PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Prevent entering more than 9 characters
            if (txt_PhoneNumber.Text.Length >= 9 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MessageFormate = "\n\n عزيزي العميل: (اسم العميل) \n" +
                                     "فاتورة الكهرباء الخاصة بك بتاريخ ( تاريخ القراءة ) كانت كالتالي: \n\n" +
                                     "القراءة السابقة: (القراءة السابقة)\n" +
                                     "القراءة الحالية: (القراءة الحالية)\n" +
                                     "اجمالي الاستهلاك: (اجمالي الاستهلاك)\n" +
                                     "سعر الكيلو: (سعر الكيلو)\n" +
                                     "المتأخرات: (المتأخرات)\n" +
                                     "اجمالي الفاتورة: (اجمالي الفاتورة)\n\n" +
                                     "للدفع من خلال الموقع .. ادخل الرابط التالي: (رابط الدفع)\n";


            if (tabControl1.SelectedTab == tabPage2) // التحقق من أن التبويب النشط هو tabPage2
            {
                rich_MessageText.Text = MessageFormate;
                rich_MessageText.Enabled = false;
            }
            else if (tabControl1.SelectedTab == tabPage1)
            {
                rich_MessageText.Text = string.Empty;
                rich_MessageText.Enabled = true;
            }
        }
    }
}

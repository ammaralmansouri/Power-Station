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

namespace PowerStationDisktop.PresentationLayer.PaymentVoucher
{

   
    public partial class frm_PaymentVoucher : Form
    {
        BusinessLayer.PaymentVouchers.ClsPaymentVouchers paymentVouchers = new BusinessLayer.PaymentVouchers.ClsPaymentVouchers();
        private Regex regex = new Regex(@"^7[80137]\d{7}$");

        public frm_PaymentVoucher()
        {
            InitializeComponent();
            AutocompeleteForEmployeePhoneNumber();
        }

        void AutocompeleteForEmployeePhoneNumber()
        {
            AutoCompleteStringCollection ob = new AutoCompleteStringCollection();

            DataTable DataTable1 = new DataTable();

            DataTable1 = paymentVouchers.SearchForEmployee(txt_EmplyeePhoneNumber.Text);

            for (int i = 0; i < DataTable1.Rows.Count; i++)
            {
                
                ob.Add(DataTable1.Rows[i][2].ToString());
            }

            this.txt_EmplyeePhoneNumber.AutoCompleteCustomSource = ob;
            this.txt_EmplyeePhoneNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.txt_EmplyeePhoneNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        void EnableAndDisEnableTextBoxesAndButtons(bool value)
        {
            txt_EmplyeePhoneNumber.Enabled = value;
            txt_PaymentVoucherAmount.Enabled = value;


            dtp_PaymentVoucherDate.Enabled = value;
            rich_PaymentVoucherNote.Enabled = value;

            btn_Save.Enabled = value;

            btn_New.Enabled = !value;

        }


        void EmptyTextBoxes()
        {
            foreach (var c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
            }
        }
        private void btn_New_Click(object sender, EventArgs e)
        {
            EnableAndDisEnableTextBoxesAndButtons(true);
            EmptyTextBoxes();

            DataTable DataTable1 = new DataTable();

            DataTable1 = paymentVouchers.GeneratePaymentVoucherID();

            txt_PaymentVoucherID.Text = DataTable1.Rows[0][0].ToString();
        }

        private void txt_PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //// Allow only digits and backspace
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}

            //// Prevent entering more than 9 characters
            //if (txt_EmplyeePhoneNumber.Text.Length >= 9 && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void txt_PhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string input = txt_EmplyeePhoneNumber.Text;
            if (!regex.IsMatch(input))
            {
                //MessageBox.Show("لطفا ادخل رقم هاتف صحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txt_EmplyeePhoneNumber.BackColor = Color.Red;

                //txt_CustomerPhone.Clear();
            }
            else
            {
                txt_EmplyeePhoneNumber.BackColor = Color.White;
            }
        }

        private void txt_PhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnableAndDisEnableTextBoxesAndButtons(true);
                btn_Save.Enabled = false;
                btn_Edit.Enabled = true;

                DataTable DataTable1 = new DataTable();

                DataTable1 = paymentVouchers.SearchForEmployee(txt_EmplyeePhoneNumber.Text);

                txt_PaymentVoucherEmployeeWhoTake.Text = DataTable1.Rows[0][0].ToString();
                txt_EmployeeWhoTakeName.Text = DataTable1.Rows[0][1].ToString();
                btn_New.Enabled = true;
            }
        }
    }
}

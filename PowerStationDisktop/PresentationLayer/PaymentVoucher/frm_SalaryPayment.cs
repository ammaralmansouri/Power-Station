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
    public partial class frm_SalaryPayment : Form
    {
        BusinessLayer.PaymentVouchers.ClsPaymentVouchers paymentVouchers = new BusinessLayer.PaymentVouchers.ClsPaymentVouchers();
        BusinessLayer.Employees.ClsEmployees employee = new BusinessLayer.Employees.ClsEmployees();

        private Regex regex = new Regex(@"^7[80137]\d{7}$");

        public frm_SalaryPayment()
        {
            InitializeComponent();
        }

        void EnableAndDisEnableTextBoxesAndButtons(bool value)
        {
            txt_EmplyeePhoneNumber.Enabled = value;



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

        void GeneratePaymentVoucherID()
        {
            DataTable DataTable1 = new DataTable();

            DataTable1 = paymentVouchers.GeneratePaymentVoucherID();

            txt_PaymentVoucherID.Text = DataTable1.Rows[0][0].ToString();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            EnableAndDisEnableTextBoxesAndButtons(true);
            EmptyTextBoxes();

            GeneratePaymentVoucherID();

            btn_Save.Enabled = true;
        }

        private void txt_EmplyeePhoneNumber_TextChanged(object sender, EventArgs e)
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

        private void txt_EmplyeePhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Prevent entering more than 9 characters
            if (txt_EmplyeePhoneNumber.Text.Length >= 9 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        bool CheckIfTextBoxesIsNull()
        {
            foreach (var c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    if (((TextBox)c).Text == string.Empty)
                    {
                        MessageBox.Show("تأكد من تعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                }

                if (c is RichTextBox)
                {
                    if (((RichTextBox)c).Text == string.Empty)
                    {
                        MessageBox.Show("قم بكتاية بيان لهذه العملية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                }
            }
            return true;

        }



        private void txt_EmplyeePhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnableAndDisEnableTextBoxesAndButtons(true);

                btn_Save.Enabled = false;
                btn_Edit.Enabled = true;

                DataTable DataTable1 = new DataTable();

                
                DataTable1 = employee.SearchForEmployee(txt_EmplyeePhoneNumber.Text);


                if (DataTable1.Rows.Count > 0)
                {
                    txt_EmployeeIDWhoTake.Text = DataTable1.Rows[0][0].ToString();
                    txt_EmployeeTotalCredit.Text = DataTable1.Rows[0][5].ToString(); // To show Previose Credit .. لعرض السُلف السابقة
                    txt_EmployeeSalary.Text = DataTable1.Rows[0][3].ToString();

                    txt_PaymentVoucherEmployeeNameWhoTake.Text = DataTable1.Rows[0][1].ToString();


                    txt_EmployeeIDWhoGive.Text = "1";

                    txt_PaymentVoucherAmount.Text = (Convert.ToDouble(DataTable1.Rows[0][3].ToString()) - Convert.ToDouble(DataTable1.Rows[0][5].ToString())).ToString();



                    btn_New.Enabled = true;
                    btn_New.Enabled = false;
                    btn_Save.Enabled = true;



                }
                else
                {
                    MessageBox.Show("لا يوجد عميل يمتلك هذا الرقم .. تأكد من الرقم المدخل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    EmptyTextBoxes();
                    GeneratePaymentVoucherID();

                }
                





            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckIfTextBoxesIsNull())
                {

                    if (dtp_PaymentVoucherDate.Value.Date == DateTime.Now.Date)
                    {

                        double EmployeeTotalCredit = Convert.ToDouble(txt_EmployeeTotalCredit.Text) + Convert.ToDouble(txt_PaymentVoucherAmount.Text);
                        employee.UpdateEmployeeTotalCredit(Convert.ToInt32(txt_EmployeeIDWhoTake.Text), EmployeeTotalCredit);

                        paymentVouchers.AddNewPaymentVoucherForEmployee(Convert.ToInt32(txt_PaymentVoucherID.Text), rich_PaymentVoucherNote.Text, dtp_PaymentVoucherDate.Value, Convert.ToDouble(txt_PaymentVoucherAmount.Text), Convert.ToInt32(txt_EmployeeIDWhoTake.Text), Convert.ToInt32(txt_EmployeeIDWhoGive.Text));

                        employee.UpdateEmployeeTotalCredit(Convert.ToInt32(txt_EmployeeIDWhoTake.Text), 0);

                        MessageBox.Show("تم حفظ سند الصرف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        EmptyTextBoxes();
                        rich_PaymentVoucherNote.Text = string.Empty;

                        EnableAndDisEnableTextBoxesAndButtons(false);


                        btn_New.Enabled = true;
                        btn_Save.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("التاريخ المدخل لا يساوي تاريخ اليوم..!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("تأكد من: " + ex, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}

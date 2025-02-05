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

namespace PowerStationDisktop.PresentationLayer.Suppliers
{
    public partial class frm_Suppliers : Form
    {
        BusinessLayer.Suppliers.ClsSuppliers supplier = new BusinessLayer.Suppliers.ClsSuppliers();
        private Regex regex = new Regex(@"^7[80137]\d{7}$");
        public frm_Suppliers()
        {
            InitializeComponent();
            GetAllSuppliers();
        }
        void GetAllSuppliers()
        {
            dgv_Suppliers.DataSource = supplier.GetAllSuppliers();

            dgv_Suppliers.Columns[0].Visible = false;
            dgv_Suppliers.Columns[1].HeaderText = "الاسم";
            dgv_Suppliers.Columns[2].HeaderText = "رقم الهاتف";
            dgv_Suppliers.Columns[3].HeaderText = "الوصف";
            dgv_Suppliers.Columns[4].Visible = false;
        }
        bool CheckIfPhoneNumberTrueOrNot()
        {

            string phoneNumber = txt_SupplierPhone.Text;
            if (!regex.IsMatch(phoneNumber))
            {
                MessageBox.Show("تأكد من أن رقم الهاتف المدخل صحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            else
            {
                return true;
            }
        }

        private void txt_SupplierPhone_TextChanged(object sender, EventArgs e)
        {
            string input = txt_SupplierPhone.Text;
            if (!regex.IsMatch(input))
            {
                //MessageBox.Show("لطفا ادخل رقم هاتف صحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txt_SupplierPhone.BackColor = Color.Red;

                //txt_CustomerPhone.Clear();
            }
            else
            {
                txt_SupplierPhone.BackColor = Color.White;
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
                        MessageBox.Show("تأكد من تعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                }
            }
            return true;

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

        void EnableAndDisEnableTextBoxesAndButtons(bool value)
        {
            txt_SupplierName.Enabled = value;
            txt_SupplierPhone.Enabled = value;
            rich_SupplierDiscription.Enabled = value;
            

            btn_Save.Enabled = value;

            btn_New.Enabled = !value;

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            EmptyTextBoxes();
            rich_SupplierDiscription.Text = String.Empty;

            EnableAndDisEnableTextBoxesAndButtons(true);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckIfTextBoxesIsNull())
                {
                    if (CheckIfPhoneNumberTrueOrNot())
                    {
                        int PoweStationID = 1;

                        supplier.AddNewSupplier(txt_SupplierName.Text , txt_SupplierPhone.Text , rich_SupplierDiscription.Text, PoweStationID);
                        MessageBox.Show("تم اضافة المورد بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        EmptyTextBoxes();

                        EnableAndDisEnableTextBoxesAndButtons(false);

                       GetAllSuppliers();

                        rich_SupplierDiscription.Text = string.Empty;


                        btn_Edit.Enabled = false;
                        btn_Delete.Enabled = false;

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("تأكد من: " + ex, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txt_SupplierPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Prevent entering more than 9 characters
            if (txt_SupplierPhone.Text.Length >= 9 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

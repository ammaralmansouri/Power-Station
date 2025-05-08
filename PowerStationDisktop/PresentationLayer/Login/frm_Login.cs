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


namespace PowerStationDisktop.PresentationLayer.Login
{
    public partial class frm_Login : Form
    {

        BusinessLayer.Employees.ClsEmployees employees = new BusinessLayer.Employees.ClsEmployees();
        private Regex regex = new Regex(@"^7[80137]\d{7}$");


        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool CheckIfPhoneNumberTrueOrNot()
        {
            string phoneNumber = txt_EmployeePhoneNumber.Text;
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

        bool CheckIfTextBoxesIsNull()
        {
            foreach (var c in Controls)
            {
                if (c is TextBox)
                {
                    if (((TextBox)c).Text == string.Empty)
                    {
                        MessageBox.Show("تأكد من تعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                }
            }
            return true;

        }

        void LogIn()
        {
            DataTable DataTable1 = new DataTable();

            DataTable1 = employees.GetEmployeeInformationForLogIn(txt_EmployeePhoneNumber.Text, txt_EmployeePassword.Text); //we reach LoginTest function and send the parameters..

            if (DataTable1.Rows.Count > 0)
            {
                DataTable DataTable2 = new DataTable();


                DataTable2 = employees.CheckIfEmployeeisActive(txt_EmployeePhoneNumber.Text, txt_EmployeePassword.Text); //we reach LoginTest function and send the parameters..

                if (DataTable2.Rows[0][0].ToString() == "1")
                {
                    Program.EmployeeID = DataTable1.Rows[0][0].ToString();  // give the ID of the user to the varible which we had declare inside Program.cs ..
                    Program.EmployeeName = DataTable1.Rows[0][1].ToString();// give the name of the user to the varible which we had declare inside Program.cs ..
                    Program.EmployeeType = DataTable1.Rows[0][6].ToString(); // give the Type of the user to the varible which we had declare inside Program.cs ..
                    Program.EmployeePermission = DataTable1.Rows[0][7].ToString(); // give Permissions name of the user to the varible which we had declare inside Program.cs ..
                    Program.EmployeeState = DataTable1.Rows[0][8].ToString(); // give the State of the user to the varible which we had declare inside Program.cs ..


                    this.Hide();
                    frm_Home home = new frm_Home();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("لقد تم ايقاف هذا الحساب ..!!");

                }
            }
            else
            {
                MessageBox.Show("كلمة المرور أو اسم المستخدم غير صحيح");
            }

        }


        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(CheckIfTextBoxesIsNull())
            {
                if (CheckIfPhoneNumberTrueOrNot())
                {
                    LogIn();
                }

            }
        }

        private void txt_EmployeePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CheckIfTextBoxesIsNull())
                {
                    if (CheckIfPhoneNumberTrueOrNot())
                    {
                        LogIn();
                    }

                }
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            txt_EmployeePhoneNumber.Focus();
        }

        private void txt_EmployeePhoneNumber_TextChanged(object sender, EventArgs e)
        {

            if (txt_EmployeePhoneNumber.Text != String.Empty)
            {
                string input = txt_EmployeePhoneNumber.Text;
                if (!regex.IsMatch(input))
                {
                    //MessageBox.Show("لطفا ادخل رقم هاتف صحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txt_EmployeePhoneNumber.BackColor = Color.Red;
                    txt_EmployeePhoneNumber.ForeColor = Color.Black;


                    //txt_CustomerPhone.Clear();
                }
                else
                {
                    txt_EmployeePhoneNumber.BackColor = Color.White;
                    txt_EmployeePhoneNumber.ForeColor = Color.Black;

                }
            }
            else
            {
                txt_EmployeePhoneNumber.BackColor = Color.White;
                txt_EmployeePhoneNumber.ForeColor = Color.Black;
            }
        }

        private void txt_EmployeePhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Prevent entering more than 9 characters
            if (txt_EmployeePhoneNumber.Text.Length >= 9 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

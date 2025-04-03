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

namespace PowerStationDisktop.PresentationLayer.Emloyees
{
    public partial class frm_Employee : Form
    {
        BusinessLayer.Employees.ClsEmployees employee = new BusinessLayer.Employees.ClsEmployees();
        BusinessLayer.PowerStation.ClsPowerStation powerStation = new BusinessLayer.PowerStation.ClsPowerStation();
        BusinessLayer.Normalization.ClsNormalize normalize = new BusinessLayer.Normalization.ClsNormalize();

        private Regex regex = new Regex(@"^7[80137]\d{7}$");

        private string placeholderText = "ابحث هنا ..";


        DataTable DataTable1 = new DataTable();
        public frm_Employee()
        {
            InitializeComponent();
            GetAllEmployees();
           // AutocompeleteSearchText();
        }

        void AutocompeleteSearchText()
        {
            AutoCompleteStringCollection ob = new AutoCompleteStringCollection();

            DataTable DataTable1 = new DataTable();

            DataTable1 = employee.SearchForEmployee(txt_Search.Text);

            for (int i = 0; i < DataTable1.Rows.Count; i++)
            {
                ob.Add(DataTable1.Rows[i][1].ToString());
                ob.Add(DataTable1.Rows[i][2].ToString());
            }

            this.txt_Search.AutoCompleteCustomSource = ob;
            this.txt_Search.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.txt_Search.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }


        void DataGrideViewFormate()
        {
            dgv_Employees.Columns[0].Visible = false;
            dgv_Employees.Columns[1].HeaderText = "الاسم";
            dgv_Employees.Columns[2].HeaderText = "رقم الهاتف";
            dgv_Employees.Columns[3].HeaderText = "الراتب";
            dgv_Employees.Columns[4].Visible = false;
            dgv_Employees.Columns[5].HeaderText = "السُلف السابقة";
            dgv_Employees.Columns[6].HeaderText = "النوع";
            dgv_Employees.Columns[7].Visible = false;
            dgv_Employees.Columns[8].HeaderText = "الحالة";
            dgv_Employees.Columns[9].Visible = false;
        }
        void GetAllEmployees()
        {
            dgv_Employees.DataSource = employee.GetAllEmployees();

            DataGrideViewFormate();
        }

        void GetEmployeesWhoWorksinside()
        {
            dgv_Employees.DataSource = employee.GetEmployeesWhoWorksinside();

            DataGrideViewFormate();

        }

        void GetEmployeesWhoWorksOut()
        {
            dgv_Employees.DataSource = employee.GetEmployeesWhoWorksOut();

            DataGrideViewFormate();

        }

        void GetActiveEmployees()
        {
            dgv_Employees.DataSource = employee.GetActiveEmployees();

            DataGrideViewFormate();

        }

        void GetInActiveEmployees()
        {
            dgv_Employees.DataSource = employee.GetInActiveEmployees();

            DataGrideViewFormate();

        }

        void EnableAndDisEnableTextBoxesAndButtons(bool value)
        {
            txt_EmployeeName.Enabled = value;
            txt_EmployeePassword.Enabled = value;
            txt_EmployeePhone.Enabled = value;
            txt_EmployeeSalary.Enabled = value;

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

            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;

            txt_EmployeePassword.Text = "123456"; // give defult value to the password ..
            txt_EmployeeSalary.Text = "0";


            DataTable DataTable1 = new DataTable();

            DataTable1 = employee.GenerateEmployeeID();

            txt_EmployeeID.Text = DataTable1.Rows[0][0].ToString();

            txt_EmployeePhone.BackColor = Color.White;

            cmb_EmployeeState.SelectedIndex = 0;
            cmb_EmployeeType.SelectedIndex = 1;

            txt_EmployeeName.Focus();
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

                if (c is ComboBox)
                {
                    if (((ComboBox)c).Text == string.Empty)
                    {
                        MessageBox.Show("تأكد من تعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                }
            }
            return true;

        }

        bool CheckIfPhoneNumberTrueOrNot()
        {

            string phoneNumber = txt_EmployeePhone.Text;
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
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckIfTextBoxesIsNull())
                {
                    if (CheckIfPhoneNumberTrueOrNot())
                    {
                        DialogResult result = MessageBox.Show("هل أنت متأكد من البيانات المُدخلة..؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            DataTable DataTable1 = powerStation.GetAllPowerStation();
                            int PoweStationID = Convert.ToInt32(DataTable1.Rows[0][0].ToString());

                            int EmployeePermission = 0;
                            int EmployeeType = 1;
                            int EmployeeState = 0;

                            if (cmb_EmployeeType.Text == "موظف")
                            {
                                EmployeeType = 1;
                            }
                            else if (cmb_EmployeeType.Text == "محصل")
                            {
                                EmployeeType = 2;
                            }


                            if (cmb_EmployeeState.Text == "فعال")
                            {
                                EmployeeState = 1;
                            }
                            else if (cmb_EmployeeType.Text == "غير فعال")
                            {
                                EmployeeState = 0;
                            }

                            employee.AddNewEmployee(txt_EmployeeName.Text, txt_EmployeePhone.Text, Convert.ToDouble(txt_EmployeeSalary.Text), txt_EmployeePassword.Text, EmployeeType, EmployeePermission, EmployeeState, PoweStationID);
                            normalize.ChangeLettersToStandardLettersToMakeItEasyWhenSearchForEmployee();
                            MessageBox.Show("تم اضافة الموظف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            EmptyTextBoxes();

                            EnableAndDisEnableTextBoxesAndButtons(false);

                            GetAllEmployees();

                            txt_EmployeePhone.Text = string.Empty;


                            btn_Edit.Enabled = false;
                            btn_Delete.Enabled = false;
                        }
                            

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex.Message}\n\nSource: {ex.Source}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_Employees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EnableAndDisEnableTextBoxesAndButtons(true);
            btn_Save.Enabled = false;
            btn_Edit.Enabled = true;
            btn_Delete.Enabled = true;

            DataTable DataTable1 = new DataTable();

            DataTable1 = employee.GetEmployeeInformation(Convert.ToInt32(dgv_Employees.CurrentRow.Cells[0].Value.ToString()));

            txt_EmployeeID.Text = DataTable1.Rows[0][0].ToString();
            txt_EmployeeName.Text = DataTable1.Rows[0][1].ToString();
            txt_EmployeePhone.Text = DataTable1.Rows[0][2].ToString();
            txt_EmployeeSalary.Text = DataTable1.Rows[0][3].ToString();
            txt_EmployeePassword.Text = DataTable1.Rows[0][4].ToString();

            if (DataTable1.Rows[0][6].ToString() == "1")
            {
                cmb_EmployeeType.Text = "موظف";
            }
            if (DataTable1.Rows[0][6].ToString() == "2")
            {
                cmb_EmployeeType.Text = "محصل";
            }


            if (DataTable1.Rows[0][8].ToString() == "0")
            {
                cmb_EmployeeState.Text = "غير فعال";
            }
            if (DataTable1.Rows[0][8].ToString() == "1")
            {
                cmb_EmployeeState.Text = "فعال";
            }

            
            btn_New.Enabled = true;

            txt_Search.Text = placeholderText;
            txt_Search.ForeColor = Color.Gray;
        }

        private void rad_All_CheckedChanged(object sender, EventArgs e)
        {
            if(rad_All.Checked == true)
            {
                GetAllEmployees();
            }
        }

        private void rad_InsideEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if(rad_InsideEmployee.Checked == true)
            {
                GetEmployeesWhoWorksinside();
            }
        }

        private void rad_outEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if(rad_outEmployee.Checked == true)
            {
                GetEmployeesWhoWorksOut();
            }
        }

        private void rad_Active_CheckedChanged(object sender, EventArgs e)
        {
            GetActiveEmployees();
        }

        private void rad_NoneActive_CheckedChanged(object sender, EventArgs e)
        {
            GetInActiveEmployees();
        }

        private void txt_EmployeePhone_TextChanged(object sender, EventArgs e)
        {
            string input = txt_EmployeePhone.Text;
            if (!regex.IsMatch(input))
            {
                //MessageBox.Show("لطفا ادخل رقم هاتف صحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txt_EmployeePhone.BackColor = Color.Red;

                //txt_CustomerPhone.Clear();
            }
            else
            {
                txt_EmployeePhone.BackColor = Color.White;
            }
        }

        private void txt_EmployeePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Prevent entering more than 9 characters
            if (txt_EmployeePhone.Text.Length >= 9 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckIfTextBoxesIsNull())
                {
                    if (CheckIfPhoneNumberTrueOrNot())
                    {
                        DialogResult result = MessageBox.Show("هل أنت متأكد من التعديلات..؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            int PoweStationID = 1;
                            int EmployeePermission = 0;
                            int EmployeeType = 1;
                            int EmployeeState = 0;

                            if (cmb_EmployeeType.Text == "موظف")
                            {
                                EmployeeType = 1;
                            }
                            else if (cmb_EmployeeType.Text == "محصل")
                            {
                                EmployeeType = 2;
                            }


                            if (cmb_EmployeeState.Text == "فعال")
                            {
                                EmployeeState = 1;
                            }
                            else if (cmb_EmployeeType.Text == "غير فعال")
                            {
                                EmployeeState = 0;
                            }

                            employee.UpdateEmployee(Convert.ToInt32(txt_EmployeeID.Text), txt_EmployeeName.Text, txt_EmployeePhone.Text, Convert.ToDouble(txt_EmployeeSalary.Text), txt_EmployeePassword.Text, EmployeeType, EmployeePermission, EmployeeState, PoweStationID);
                            normalize.ChangeLettersToStandardLettersToMakeItEasyWhenSearchForEmployee();
                            MessageBox.Show("تم تعديل الموظف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            EmptyTextBoxes();

                            EnableAndDisEnableTextBoxesAndButtons(false);

                            GetAllEmployees();

                            txt_EmployeePhone.Text = string.Empty;


                            btn_Edit.Enabled = false;
                            btn_Delete.Enabled = false;
                        }
                            

                    }
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("تأكد من: " + ex, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"An Error Occurred: {ex.Message}\n\nSource: {ex.Source}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(". هل تريد بالتأكيد حذف هذه المنطقة؟ هذه العملية لا يمكن التراجع عنها", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result == DialogResult.Yes)
                {
                    employee.DeleteEmployee(Convert.ToInt32(txt_EmployeeID.Text));
                    MessageBox.Show("تمت علمية الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    EmptyTextBoxes();
                    EnableAndDisEnableTextBoxesAndButtons(false);
                    GetAllEmployees();

                    txt_EmployeePhone.Text = string.Empty;
                    btn_Delete.Enabled = false;
                    btn_Edit.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("تأكد من: " + ex, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"An Error Occurred: {ex.Message}\n\nSource: {ex.Source}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void txt_EmployeeSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)  // e.KeyChar == 8    => this for backspace button..
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                

                DataTable DataTable1 = new DataTable();

                DataTable1 = employee.SearchForEmployee(txt_Search.Text);

                if(DataTable1.Rows.Count > 0)
                {
                    EnableAndDisEnableTextBoxesAndButtons(true);
                    btn_Save.Enabled = false;
                    btn_Edit.Enabled = true;

                    btn_Delete.Enabled = true;
                    txt_EmployeeID.Text = DataTable1.Rows[0][0].ToString();
                    txt_EmployeeName.Text = DataTable1.Rows[0][1].ToString();
                    txt_EmployeePhone.Text = DataTable1.Rows[0][2].ToString();
                    txt_EmployeeSalary.Text = DataTable1.Rows[0][3].ToString();
                    txt_EmployeePassword.Text = DataTable1.Rows[0][4].ToString();


                    if (DataTable1.Rows[0][6].ToString() == "1")
                    {
                        cmb_EmployeeType.Text = "موظف";
                    }
                    if (DataTable1.Rows[0][6].ToString() == "2")
                    {
                        cmb_EmployeeType.Text = "محصل";
                    }


                    if (DataTable1.Rows[0][8].ToString() == "0")
                    {
                        cmb_EmployeeState.Text = "غير فعال";
                    }
                    if (DataTable1.Rows[0][8].ToString() == "1")
                    {
                        cmb_EmployeeState.Text = "فعال";
                    }

                    txt_Search.Text = string.Empty;
                    btn_New.Enabled = true;
                }
                else
                {
                    MessageBox.Show("البيانات المدخلة غير صحيحة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

            if (txt_Search.Text == placeholderText || string.IsNullOrWhiteSpace(txt_Search.Text))
            {
                // لا تنفذ البحث عند وجود العنصر النائب
                //return;

                GetAllEmployees();
            }


            dgv_Employees.DataSource = employee.SearchForEmployee(txt_Search.Text);

            DataGrideViewFormate();

        }

        private void الصلاحياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees.frm_Permissions permissions = new Employees.frm_Permissions();

            permissions.txt_EmployeeID.Text = DataTable1.Rows[0][0].ToString();
            permissions.txt_EmployeeName.Text = DataTable1.Rows[0][1].ToString();

            permissions.Show();

        }

        private void dgv_Employees_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // تحقق من أن النقر بالزر الأيمن
            {
                if (e.RowIndex >= 0) // تحقق من أن النقر تم على صف وليس على رأس العمود
                {
                    dgv_Employees.ClearSelection(); // إزالة أي تحديد سابق
                    dgv_Employees.Rows[e.RowIndex].Selected = true; // تحديد الصف الذي تم النقر عليه
                // dgv_Employees.CurrentCell = dgv_Employees.Rows[e.RowIndex].Cells[e.ColumnIndex]; // تحديد الخلية الحالية

                    DataTable1 = employee.GetEmployeeInformation(Convert.ToInt32(dgv_Employees.Rows[e.RowIndex].Cells[0].Value.ToString()));

                    // عرض الـ ContextMenuStrip عند موقع الماوس
                    contextMenuStrip1.Show(Cursor.Position);

                }
            }
        }

        private void dgv_Employees_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                EnableAndDisEnableTextBoxesAndButtons(true);
                btn_Save.Enabled = false;
                btn_Edit.Enabled = true;
                btn_Delete.Enabled = true;

                DataTable DataTable1 = new DataTable();

                DataTable1 = employee.GetEmployeeInformation(Convert.ToInt32(dgv_Employees.CurrentRow.Cells[0].Value.ToString()));

                txt_EmployeeID.Text = DataTable1.Rows[0][0].ToString();
                txt_EmployeeName.Text = DataTable1.Rows[0][1].ToString();
                txt_EmployeePhone.Text = DataTable1.Rows[0][2].ToString();
                txt_EmployeeSalary.Text = DataTable1.Rows[0][3].ToString();
                txt_EmployeePassword.Text = DataTable1.Rows[0][4].ToString();

                if (DataTable1.Rows[0][6].ToString() == "1")
                {
                    cmb_EmployeeType.Text = "موظف";
                }
                if (DataTable1.Rows[0][6].ToString() == "2")
                {
                    cmb_EmployeeType.Text = "محصل";
                }


                if (DataTable1.Rows[0][8].ToString() == "0")
                {
                    cmb_EmployeeState.Text = "غير فعال";
                }
                if (DataTable1.Rows[0][8].ToString() == "1")
                {
                    cmb_EmployeeState.Text = "فعال";
                }

                
                btn_New.Enabled = true;

                txt_Search.Text = placeholderText;
                txt_Search.ForeColor = Color.Gray;
            }
        }


        private void txt_Search_Enter(object sender, EventArgs e)
        {
            if (txt_Search.Text == placeholderText)
            {
                txt_Search.Text = "";
                txt_Search.ForeColor = Color.Black;
                GetAllEmployees();
            }
        }
        
        private void txt_Search_Leave(object sender, EventArgs e)
        {

            if (txt_Search.Text == "")
            {
                txt_Search.Text = placeholderText;
                txt_Search.ForeColor = Color.Gray;
                GetAllEmployees();
            }
        }

       
    }
}

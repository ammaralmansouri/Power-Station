﻿using System;
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
        BusinessLayer.Suppliers.ClsSuppliers supplier = new BusinessLayer.Suppliers.ClsSuppliers();
        BusinessLayer.Employees.ClsEmployees employee = new BusinessLayer.Employees.ClsEmployees();
        BusinessLayer.Reports.ClsReports reports = new BusinessLayer.Reports.ClsReports();

        int PaymentVoucherID;

        private Regex regex = new Regex(@"^7[80137]\d{7}$");

        public frm_PaymentVoucher()
        {
            InitializeComponent();
            //AutocompeleteForEmployeePhoneNumber();
        }

        // I could not make an Autocompelete becouse the data come from two diffrents table ( Employees , Suppliers ) .. and Autocomplete function run in InitializeComponent so I could not specify whcich table to complete from ..

        //void AutocompeleteForEmployeePhoneNumber()
        //{
        //    AutoCompleteStringCollection ob = new AutoCompleteStringCollection();

        //    DataTable DataTable1 = new DataTable();

        //    if(rad_Employee.Checked)
        //    {
        //        DataTable1 = paymentVouchers.SearchForEmployee(txt_EmplyeePhoneNumber.Text);

        //        for (int i = 0; i < DataTable1.Rows.Count; i++)
        //        {

        //            ob.Add(DataTable1.Rows[i][2].ToString());
        //        }
        //    }

        //    if(rad_Supplier.Checked)
        //    {
        //        DataTable1 = supplier.SearchForSupplierByPhoneNumber(txt_EmplyeePhoneNumber.Text);

        //        for (int i = 0; i < DataTable1.Rows.Count; i++)
        //        {

        //            ob.Add(DataTable1.Rows[i][2].ToString());
        //        }
        //    }

        //    this.txt_EmplyeePhoneNumber.AutoCompleteCustomSource = ob;
        //    this.txt_EmplyeePhoneNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //    this.txt_EmplyeePhoneNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //}

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

        private void txt_PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_PhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (txt_EmplyeePhoneNumber.Text != String.Empty)
            {
                string input = txt_EmplyeePhoneNumber.Text;
                if (!regex.IsMatch(input))
                {
                    //MessageBox.Show("لطفا ادخل رقم هاتف صحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txt_EmplyeePhoneNumber.BackColor = Color.Red;
                    txt_EmplyeePhoneNumber.ForeColor = Color.Black;


                    //txt_CustomerPhone.Clear();
                }
                else
                {
                    txt_EmplyeePhoneNumber.BackColor = Color.White;
                    txt_EmplyeePhoneNumber.ForeColor = Color.Black;

                }
            }
            else
            {
                txt_EmplyeePhoneNumber.BackColor = Color.White;
                txt_EmplyeePhoneNumber.ForeColor = Color.Black;
            }


        }

        private void txt_PhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnableAndDisEnableTextBoxesAndButtons(true);

                btn_Save.Enabled = false;
                

                DataTable DataTable1 = new DataTable();

                // You will find two condistions .. one for employee another for supplier ..
                // 
                if(rad_Employee.Checked)
                {
                    DataTable1 = employee.SearchForEmployee(txt_EmplyeePhoneNumber.Text);


                    if (DataTable1.Rows.Count > 0)
                    {
                        txt_EmployeeIDWhoTake.Text = DataTable1.Rows[0][0].ToString();
                        txt_EmployeeTotalCredit.Text = DataTable1.Rows[0][5].ToString(); // To show Previose Credit .. لعرض السُلف السابقة
                        txt_PaymentVoucherEmployeeOrSupplierNameWhoTake.Text = DataTable1.Rows[0][1].ToString();


                        txt_EmployeeIDWhoGive.Text = Program.EmployeeID;
                        txt_SupplierIDWhoTake.Text = "0"; // this is just to avoid showing error ( filed is empty ) .. but value in data base will be null ..
                        
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

                if (rad_Supplier.Checked)
                {
                    DataTable1 = supplier.SearchForSupplierByPhoneNumber(txt_EmplyeePhoneNumber.Text);


                    if (DataTable1.Rows.Count > 0)
                    {
                        txt_SupplierIDWhoTake.Text = DataTable1.Rows[0][0].ToString();
                        txt_EmployeeTotalCredit.Text = "0"; // this is just to avoid showing error ( filed is empty ) ..

                        txt_PaymentVoucherEmployeeOrSupplierNameWhoTake.Text = DataTable1.Rows[0][1].ToString();

                        txt_EmployeeIDWhoGive.Text = "1";
                        txt_EmployeeIDWhoTake.Text = "0"; // this is just to avoid showing error ( filed is empty ) .. but value in data base will be null ..

                        btn_New.Enabled = true;
                        btn_New.Enabled = false;
                        btn_Save.Enabled = true;



                    }
                    else
                    {
                        MessageBox.Show("لا يوجد مورد يمتلك هذا الرقم .. تأكد من الرقم المدخل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        EmptyTextBoxes();
                        GeneratePaymentVoucherID();
                    }
                }
            }
        }

        private void txt_PaymentVoucherAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8 || e.KeyChar == 46)  // e.KeyChar == 8    => this for backspace button.. ,  e.KeyChar == 46    => this for dot ( . ) ..
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void rad_Employee_CheckedChanged(object sender, EventArgs e)
        {
            if(rad_Employee.Checked)
            {
                label7.Text = "اسم الموظف";
                EmptyTextBoxes();
                GeneratePaymentVoucherID();

                txt_EmplyeePhoneNumber.Focus();

                // to show crites if it is an employee ..
                txt_EmployeeTotalCredit.Visible = true;
                label6.Visible = true;

            }
        }

        private void rad_Supplier_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_Supplier.Checked)
            {
                label7.Text = "اسم المورد";
                EmptyTextBoxes();
                GeneratePaymentVoucherID();

                txt_EmplyeePhoneNumber.Focus();

                // there is no crites to show becouse it is a supplier .. so we hide the filed ..

                txt_EmployeeTotalCredit.Visible = false;
                label6.Visible = false;
            }
        }


        // تعريف نافذة التحميل كمتحول عام داخل الفورم
        private PresentationLayer.Extensions.frm_Loading loadingForm;

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string input = txt_PaymentVoucherAmount.Text.Trim();

            // التحقق من أن الإدخال يحتوي على نقطة واحدة كحد أقصى
            int dotCount = input.Count(c => c == '.');
            if (dotCount > 1)
            {
                MessageBox.Show("لا يمكن إدخال أكثر من فاصلة عشرية ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (CheckIfTextBoxesIsNull())
                {

                    if(dtp_PaymentVoucherDate.Value.Date <= DateTime.Now.Date)
                    {
                        DialogResult result = MessageBox.Show("هل أنت متأكد من البيانات المُدخلة..؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            if (rad_Employee.Checked)
                            {
                                // PaymentVoucherID => for report ..
                                PaymentVoucherID = Convert.ToInt32(txt_PaymentVoucherID.Text);

                                double EmployeeTotalCredit = Convert.ToDouble(txt_EmployeeTotalCredit.Text) + Convert.ToDouble(txt_PaymentVoucherAmount.Text);
                                employee.UpdateEmployeeTotalCredit(Convert.ToInt32(txt_EmployeeIDWhoTake.Text), EmployeeTotalCredit);

                                paymentVouchers.AddNewPaymentVoucherForEmployee(Convert.ToInt32(txt_PaymentVoucherID.Text), rich_PaymentVoucherNote.Text, dtp_PaymentVoucherDate.Value, Convert.ToDouble(txt_PaymentVoucherAmount.Text), Convert.ToInt32(txt_EmployeeIDWhoTake.Text), Convert.ToInt32(txt_EmployeeIDWhoGive.Text));

                            }
                            if (rad_Supplier.Checked)
                            {
                                paymentVouchers.AddNewPaymentVoucherForSupplier(Convert.ToInt32(txt_PaymentVoucherID.Text), rich_PaymentVoucherNote.Text, dtp_PaymentVoucherDate.Value, Convert.ToDouble(txt_PaymentVoucherAmount.Text), Convert.ToInt32(txt_EmployeeIDWhoGive.Text), Convert.ToInt32(txt_SupplierIDWhoTake.Text));

                            }


                            MessageBox.Show("تم حفظ سند الصرف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // إنشاء نافذة تحميل وإظهارها
                            loadingForm = new Extensions.frm_Loading();
                            loadingForm.Show();

                            // تشغيل المهمة في الخلفية لتحميل التقرير
                            backgroundWorker1.RunWorkerAsync();


                            EmptyTextBoxes();

                            EnableAndDisEnableTextBoxesAndButtons(false);
                            rich_PaymentVoucherNote.Text = string.Empty;



                            btn_New.Enabled = true;
                            btn_Save.Enabled = false;
                        }


                           
                    }
                    else
                    {
                        MessageBox.Show("التاريخ المدخل أكبر من تاريخ اليوم..!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("تأكد من: " + ex, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"An Error Occurred: {ex.Message}\n\nSource: {ex.Source}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            if (rad_Employee.Checked)
            {
                // جلب التقرير من قاعدة البيانات
                DataTable DataTable1 = reports.ReportForPaymentVoucherForEmployee(PaymentVoucherID);
                DataSet DataSet1 = new DataSet();
                DataSet1.Tables.Add(DataTable1);

                // تجهيز التقرير
                PresentationLayer.Reports.PaymentVoucher.PaymentVoucherForEmployee paymentVoucherForEmployee =
                    new Reports.PaymentVoucher.PaymentVoucherForEmployee();
                paymentVoucherForEmployee.SetDataSource(DataTable1);

                // تمرير التقرير كـ نتيجة
                e.Result = paymentVoucherForEmployee;
            }


                
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (rad_Employee.Checked)
            {
                // إغلاق نافذة التحميل
                loadingForm.Close();

                if (e.Error == null)
                {
                    // استخراج التقرير
                    var paymentVoucherForEmployee = (PresentationLayer.Reports.PaymentVoucher.PaymentVoucherForEmployee)e.Result;

                    // عرض التقرير
                    PresentationLayer.Reports.frm_ReportViewer reportViewer = new Reports.frm_ReportViewer();
                    reportViewer.CRV.ReportSource = paymentVoucherForEmployee;
                    reportViewer.CRV.RefreshReport();
                    reportViewer.Show();
                }
                else
                {
                    MessageBox.Show("حدث خطأ أثناء تحميل التقرير: " + e.Error.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
               
        }
    }
}

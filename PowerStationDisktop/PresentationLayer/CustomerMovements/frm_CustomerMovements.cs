using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerStationDisktop.PresentationLayer.CustomerMovements
{
    public partial class frm_CustomerMovements : Form
    {

        BusinessLayer.CustomerMovement.ClsCustomerMovement customerMovement = new BusinessLayer.CustomerMovement.ClsCustomerMovement();
        BusinessLayer.Customers.ClsCustomers customer = new BusinessLayer.Customers.ClsCustomers();
        BusinessLayer.Readings.ClsReadings reading = new BusinessLayer.Readings.ClsReadings();
        BusinessLayer.Reports.ClsReports reports = new BusinessLayer.Reports.ClsReports();
        BusinessLayer.PowerStation.ClsPowerStation powerStation = new BusinessLayer.PowerStation.ClsPowerStation();

        int CustomerMovementID;
        public frm_CustomerMovements()
        {
            InitializeComponent();
            AutocompeleteSearchText();
        }

        void AutocompeleteSearchText()
        {
            AutoCompleteStringCollection ob = new AutoCompleteStringCollection();

            DataTable DataTable1 = new DataTable();

            DataTable1 = customer.SearchForCustomer(txt_ElectricityMeterIDOrPhoneNumber.Text);

            for (int i = 0; i < DataTable1.Rows.Count; i++)
            {
                ob.Add(DataTable1.Rows[i][5].ToString());
                ob.Add(DataTable1.Rows[i][2].ToString());
            }

            this.txt_ElectricityMeterIDOrPhoneNumber.AutoCompleteCustomSource = ob;
            this.txt_ElectricityMeterIDOrPhoneNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.txt_ElectricityMeterIDOrPhoneNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        void EnableAndDisEnableTextBoxesAndButtons(bool value)
        {
            txt_ElectricityMeterIDOrPhoneNumber.Enabled = value;
            txt_CustomerMovementPaiedAmount.Enabled = value;


            dtp_CustomerMovementDate.Enabled = value;
            rich_CustomerMovementNote.Enabled = value;

            cmb_CustomerMovementType.Enabled = value;

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
            txt_CustomerMovementPaiedAmount.Enabled = false;

            DataTable DataTable1 = new DataTable();

            DataTable1 = customerMovement.GenerateCustomerMovementID();

            txt_CustomerMovementID.Text = DataTable1.Rows[0][0].ToString();

            rich_CustomerMovementNote.Text = "سند قبض .. سداد فاتورة";


        }

        private void txt_ElectricityMeterIDOrPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
               

                DataTable DataTable1 = new DataTable();

                DataTable1 = customer.SearchForCustomer(txt_ElectricityMeterIDOrPhoneNumber.Text);

                if (DataTable1.Rows.Count > 0)
                {
                    txt_CustomerMovementPaiedAmount.Enabled = true;

                    txt_CustomerID.Text = DataTable1.Rows[0][0].ToString();
                    txt_CustomerName.Text = DataTable1.Rows[0][1].ToString();
                    txt_ElectricityMeterID.Text = DataTable1.Rows[0][5].ToString();

                    txt_EmployeeID.Text = "1";

                    DataTable1.Clear();

                    DataTable1 = reading.GetCustomerTotalDues(Convert.ToDouble(txt_ElectricityMeterID.Text));
                    txt_TotalDuesAfterPaying.Text = DataTable1.Rows[0][0].ToString();



                }
                else
                {
                    MessageBox.Show("رقم العداد الذي ادخلته غير صحيح أو أنه غير مرتبط بعميل ..!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                    txt_ElectricityMeterIDOrPhoneNumber.Text = string.Empty;
                    EmptyTextBoxes();
                    
                }
            }
                


        }

        private void txt_CustomerMovementPaiedAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8 || e.KeyChar == 46)  // e.KeyChar == 8    => this for backspace button.. ,  e.KeyChar == 46    => this for dot ( . ) ..
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_CustomerMovementPaiedAmount_TextChanged(object sender, EventArgs e)
        {
            String TotalDuesBeforePaying;
            DataTable DataTable1 = new DataTable();

            if(txt_CustomerMovementPaiedAmount.Text != string.Empty)
            {
                DataTable1 = reading.GetCustomerTotalDues(Convert.ToDouble(txt_ElectricityMeterIDOrPhoneNumber.Text));
                TotalDuesBeforePaying = DataTable1.Rows[0][0].ToString();

                if (txt_CustomerMovementPaiedAmount.Text != string.Empty)
                {
                    double TotalDues = Convert.ToDouble(TotalDuesBeforePaying) - Convert.ToDouble(txt_CustomerMovementPaiedAmount.Text);

                    txt_TotalDuesAfterPaying.Text = TotalDues.ToString();
                }
                else
                {
                    txt_TotalDuesAfterPaying.Text = DataTable1.Rows[0][0].ToString();

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
            }
            return true;

        }

        // تعريف نافذة التحميل كمتحول عام داخل الفورم
        private PresentationLayer.Extensions.frm_Loading loadingForm;


        private void btn_Save_Click(object sender, EventArgs e)
        {
                if (CheckIfTextBoxesIsNull())
            {
                if(cmb_CustomerMovementType.SelectedIndex != -1)
                {
                    if (dtp_CustomerMovementDate.Value.Date == DateTime.Now.Date)
                    {

                        DialogResult result = MessageBox.Show("هل أنت متأكد من البيانات المُدخلة..؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            double TotalDuesAfterPaying = (Convert.ToDouble(txt_TotalDuesAfterPaying.Text));
                            customerMovement.UpdateCustomerTotalDuesWhenPaying(Convert.ToDouble(txt_ElectricityMeterID.Text), TotalDuesAfterPaying);

                            int CustomerMovementType = 0;

                            if (cmb_CustomerMovementType.Text == "كاش")
                            {
                                CustomerMovementType = 1;
                            }
                            else if (cmb_CustomerMovementType.Text == "دفع الكتروني")
                            {
                                CustomerMovementType = 2;

                            }

                            CustomerMovementID = Convert.ToInt32(txt_CustomerMovementID.Text);

                            customerMovement.AddNewCustomerMovement(Convert.ToInt32(txt_CustomerMovementID.Text), dtp_CustomerMovementDate.Value, Convert.ToDouble(txt_CustomerMovementPaiedAmount.Text), TotalDuesAfterPaying, rich_CustomerMovementNote.Text, CustomerMovementType, Convert.ToInt32(txt_CustomerID.Text), Convert.ToInt32(txt_EmployeeID.Text));
                            MessageBox.Show("تم حفظ سند القبض بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);



                            EmptyTextBoxes();

                            EnableAndDisEnableTextBoxesAndButtons(false);


                            // إنشاء نافذة تحميل وإظهارها
                            loadingForm = new Extensions.frm_Loading();
                            loadingForm.Show();

                            // تشغيل المهمة في الخلفية لتحميل التقرير
                            backgroundWorker1.RunWorkerAsync();

                            //DataTable DataTable1 = reports.ReportForCustomerMovementWhenPaying(CustomerMovementID);


                            //DataSet DataSet1 = new DataSet();

                            //DataSet1.Tables.Add(DataTable1);

                            //PresentationLayer.Reports.CustomerMonements.CustomerMovementWhenPaying customerMovementWhenPaying = new Reports.CustomerMonements.CustomerMovementWhenPaying();
                            //customerMovementWhenPaying.SetDataSource(DataTable1);

                            //PresentationLayer.Reports.frm_ReportViewer reportViewer = new Reports.frm_ReportViewer();

                            //reportViewer.CRV.ReportSource = customerMovementWhenPaying;
                            //reportViewer.CRV.RefreshReport();
                            //reportViewer.Show();
                        }



                    }
                    else
                    {
                        MessageBox.Show(" لا يمكن أن يكون التاريخ المدخل أكبر أو أصغر من التاريخ الحالي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("اختر نوع الدفع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            // جلب التقرير من قاعدة البيانات
            DataTable DataTable1 = reports.ReportForCustomerMovementWhenPaying(CustomerMovementID);
            DataSet DataSet1 = new DataSet();
            DataSet1.Tables.Add(DataTable1);

            // تجهيز التقرير
            PresentationLayer.Reports.CustomerMonements.CustomerMovementWhenPaying customerMovementWhenPaying =
                new Reports.CustomerMonements.CustomerMovementWhenPaying();
            customerMovementWhenPaying.SetDataSource(DataTable1);

            // تمرير التقرير كـ نتيجة
            e.Result = customerMovementWhenPaying;



        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // إغلاق نافذة التحميل
            loadingForm.Close();

            if (e.Error == null)
            {
                // استخراج التقرير
                var customerMovementWhenPaying = (PresentationLayer.Reports.CustomerMonements.CustomerMovementWhenPaying)e.Result;

                // عرض التقرير
                PresentationLayer.Reports.frm_ReportViewer reportViewer = new Reports.frm_ReportViewer();
                reportViewer.CRV.ReportSource = customerMovementWhenPaying;
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

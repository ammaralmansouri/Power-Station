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

namespace PowerStationDisktop.PresentationLayer
{
    public partial class frm_AccountStatementForCustomer : Form
    {
        BusinessLayer.Customers.ClsCustomers customers = new BusinessLayer.Customers.ClsCustomers();
        BusinessLayer.Reports.ClsReports reports = new BusinessLayer.Reports.ClsReports();
        
        private Regex regex = new Regex(@"^7[80137]\d{7}$");
        private String placeholderText = "اضغط F5 للبحث";

        public frm_AccountStatementForCustomer()
        {
            InitializeComponent();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            EmptyTextBoxes();

            dgv_AccountStatementForCustomer.DataSource = null;
            dgv_AccountStatementForCustomer.Rows.Clear();
            dgv_AccountStatementForCustomer.Refresh();

            txt_CustomerPhone.Enabled = true;
            txt_CustomerPhone.Focus();

            btn_Show.Enabled = false;
            btn_print.Enabled = false;
        }

        private void txt_CustomerPhone_TextChanged(object sender, EventArgs e)
        {
            string input = txt_CustomerPhone.Text;
            if(txt_CustomerPhone.Text != String.Empty)
            {
                if (!regex.IsMatch(input))
                {
                    //MessageBox.Show("لطفا ادخل رقم هاتف صحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txt_CustomerPhone.BackColor = Color.Red;
                    txt_CustomerPhone.ForeColor = Color.Black;


                    //txt_CustomerPhone.Clear();
                }
                else
                {
                    txt_CustomerPhone.BackColor = Color.White;
                    txt_CustomerPhone.ForeColor = Color.Black;

                }
            }
            else
            {
                txt_CustomerPhone.BackColor = Color.White;
                txt_CustomerPhone.ForeColor = Color.Black;
            }
            
        }

        private void txt_CustomerPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Prevent entering more than 9 characters
            if (txt_CustomerPhone.Text.Length >= 9 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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

        void GetAccountStatementForThisCustomer()
        {
            DataTable DataTable1 = reports.ReportForAccountStatementForCustomer(Convert.ToDouble(txt_ElectronicMeterID.Text), dtp_StartDate.Value, dtp_EndDate.Value, Convert.ToInt32(txt_CustomerID.Text));

            if(DataTable1.Rows.Count > 0)
            {
                dgv_AccountStatementForCustomer.DataSource = DataTable1;

                dgv_AccountStatementForCustomer.Columns[0].HeaderText = "رقم السند";
                dgv_AccountStatementForCustomer.Columns[1].HeaderText = "التاريخ";
                dgv_AccountStatementForCustomer.Columns[2].Visible = false;
                dgv_AccountStatementForCustomer.Columns[3].HeaderText = "القراءة السابقة";
                dgv_AccountStatementForCustomer.Columns[4].HeaderText = "القراءة الحالية";
                dgv_AccountStatementForCustomer.Columns[5].HeaderText = "الاستهلاك";
                dgv_AccountStatementForCustomer.Columns[6].Visible = false;
                dgv_AccountStatementForCustomer.Columns[7].HeaderText = "الملبغ";
                dgv_AccountStatementForCustomer.Columns[8].HeaderText = "الرصيد";
                dgv_AccountStatementForCustomer.Columns[9].Visible = false;

            }
            else
            {
                MessageBox.Show("لا توجد اية بيانات خاصة بهذا العميل في هذا التاريخ ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                dgv_AccountStatementForCustomer.DataSource = null;
                dgv_AccountStatementForCustomer.Rows.Clear();
                dgv_AccountStatementForCustomer.Refresh();
            }

        }

        private void txt_CustomerPhone_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F9) // إذا تم الضغط على F9
            {
                //e.SuppressKeyPress = true; // لمنع الصوت الافتراضي لـ F5
                Extensions.frm_SearchForCustomer searchForCustomer = new Extensions.frm_SearchForCustomer();

                searchForCustomer.ShowDialog();

                

                if (searchForCustomer.isClick)
                {
                    txt_CustomerID.Text = searchForCustomer.dgv_Result.CurrentRow.Cells[0].Value.ToString();
                    txt_CustomerName.Text = searchForCustomer.dgv_Result.CurrentRow.Cells[1].Value.ToString(); 
                    txt_CustomerPhone.Text = searchForCustomer.dgv_Result.CurrentRow.Cells[2].Value.ToString(); 
                    txt_ElectronicMeterID.Text = searchForCustomer.dgv_Result.CurrentRow.Cells[5].Value.ToString(); 

                    btn_Show.Enabled = true;
                    btn_print.Enabled = true;

                }

            }
            //if (e.KeyCode == Keys.Enter)
            //{
            //    DataTable DataTable1 = new DataTable();

            //    DataTable1 = customers.SearchForCustomer(txt_CustomerPhone.Text);


            //    if (DataTable1.Rows.Count > 0)
            //    {

            //        txt_CustomerID.Text = DataTable1.Rows[0][0].ToString();
            //        txt_CustomerName.Text = DataTable1.Rows[0][1].ToString();
            //        txt_ElectronicMeterID.Text = DataTable1.Rows[0][5].ToString(); 


            //        btn_New.Enabled = true;
            //        btn_Show.Enabled = true;
            //    }
            //    else
            //    {
            //        MessageBox.Show("لا يوجد عميل يمتلك هذا الرقم .. تأكد من الرقم المدخل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //        EmptyTextBoxes();

            //    }
            //}
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            if (dtp_StartDate.Value.Date > dtp_EndDate.Value.Date)
            {
                MessageBox.Show("لا يمكن أن يكون تاريخ البداية أكبر من تاريخ النهاية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {

                    GetAccountStatementForThisCustomer();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("تأكد من: " + ex, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        // تعريف نافذة التحميل كمتحول عام داخل الفورم
        private PresentationLayer.Extensions.frm_Loading loadingForm;

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (dtp_StartDate.Value.Date > dtp_EndDate.Value.Date)
            {
                MessageBox.Show("لا يمكن أن يكون تاريخ البداية أكبر من تاريخ النهاية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                DataTable DataTable1 = reports.ReportForAccountStatementForCustomer(Convert.ToDouble(txt_ElectronicMeterID.Text), dtp_StartDate.Value, dtp_EndDate.Value, Convert.ToInt32(txt_CustomerID.Text));

                if (DataTable1.Rows.Count > 0)
                {
                    // إنشاء نافذة تحميل وإظهارها
                    loadingForm = new Extensions.frm_Loading();
                    loadingForm.Show();

                    // تشغيل المهمة في الخلفية لتحميل التقرير
                    backgroundWorker1.RunWorkerAsync();


                }
                else
                {
                    MessageBox.Show("لا توجد اية بيانات خاصة بهذا العميل في هذا التاريخ ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    dgv_AccountStatementForCustomer.DataSource = null;
                    dgv_AccountStatementForCustomer.Rows.Clear();
                    dgv_AccountStatementForCustomer.Refresh();
                }
            }
              
        }

        private void txt_CustomerPhone_Enter(object sender, EventArgs e)
        {
            if (txt_CustomerPhone.Text == placeholderText)
            {
                txt_CustomerPhone.Text = "";
                txt_CustomerPhone.ForeColor = Color.Black;
            }
        }

        private void txt_CustomerPhone_Leave(object sender, EventArgs e)
        {
            if (txt_CustomerPhone.Text == "")
            {
                txt_CustomerPhone.Text = placeholderText;
                txt_CustomerPhone.ForeColor = Color.Gray;
                txt_CustomerPhone.BackColor = Color.White;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DataTable DataTable1 = reports.ReportForAccountStatementForCustomer(Convert.ToDouble(txt_ElectronicMeterID.Text), dtp_StartDate.Value, dtp_EndDate.Value, Convert.ToInt32(txt_CustomerID.Text));

            DataSet DataSet1 = new DataSet();

            DataSet1.Tables.Add(DataTable1);

            PresentationLayer.Reports.AccountStatement.AccountStatementForCustomer accountStatementForCustomer = new Reports.AccountStatement.AccountStatementForCustomer();
            accountStatementForCustomer.SetDataSource(DataTable1);

            e.Result = accountStatementForCustomer;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // إغلاق نافذة التحميل
            loadingForm.Close();

            if (e.Error == null)
            {
                // استخراج التقرير
                var accountStatementForCustomer = (PresentationLayer.Reports.AccountStatement.AccountStatementForCustomer)e.Result;

                // عرض التقرير
                PresentationLayer.Reports.frm_ReportViewer reportViewer = new Reports.frm_ReportViewer();
                reportViewer.CRV.ReportSource = accountStatementForCustomer;
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

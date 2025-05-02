using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerStationDisktop
{
    public partial class frm_Home : Form
    {
        BusinessLayer.Backups.ClsBackups backups = new BusinessLayer.Backups.ClsBackups();
        BusinessLayer.PowerStation.ClsPowerStation PowerStation = new BusinessLayer.PowerStation.ClsPowerStation();

        public frm_Home()
        {
            InitializeComponent();
            timer1.Start();
            CurrentDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            toolTip1.SetToolTip(btn_Information, "تم التصميم بواسطة طلاب جامعة الملكة أروى");
            toolTip1.SetToolTip(btn_Lock, "قفل الشاشة");

            GetPowerStationINformation();

        }

        void GetPowerStationINformation()
        {
            DataTable DataTable1 = PowerStation.GetAllPowerStation();

            label1.Text = DataTable1.Rows[0][1].ToString();
        }


        private void CreateBackup()
        {
            try
            {
                DialogResult result = MessageBox.Show("هل أنت متأكد من أنك تريد انشاء نسخة احتياطية..؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    SaveFileDialog SFD = new SaveFileDialog();

                    SFD.Filter = "Backup file(*.Bak)|*.bak";

                    if (SFD.ShowDialog() == DialogResult.OK)
                    {
                        string BackupPath = SFD.FileName + "-" + DateTime.Now.ToShortDateString().Replace('/', '-') + "-" + DateTime.Now.ToShortTimeString().Replace(':', '-') + ".bak"; // the backup name will add to it the date and time and we replace the (/) with (-).... ( .bak  ) is the extention of the file..


                        backups.CreateBackup(BackupPath);

                        MessageBox.Show("تم انشاء نسخة احتياطبة بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show("تأكد من :" + ex, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show($"An Error Occurred: {ex.Message}\n\nSource: {ex.Source}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ResotreBackup()
        {
            try
            {
                OpenFileDialog OFD = new OpenFileDialog();

                OFD.Filter = "Restore File(*.bak)|*.bak";

                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    DialogResult result = MessageBox.Show("هل أنت متأكد من أنك تريد استرجاع النسخة الاحتياطية المحددة..؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        backups.RestoreBackup(OFD.FileName);
                        MessageBox.Show("تم استرجاع النسخة الإحتياطبة بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("تأكد من :" + ex, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"An Error Occurred: {ex.Message}\n\nSource: {ex.Source}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ExecuteNodeAction(TreeNode node)
        {
            switch (node.Name)
            {
                case "EmployeeData":
                    PresentationLayer.Emloyees.frm_Employee employee = new PresentationLayer.Emloyees.frm_Employee();
                    employee.Show();
                    break;
                case "CustomerData":
                    PresentationLayer.frm_Customers customer = new PresentationLayer.frm_Customers();
                    customer.Show();
                    break;
                case "ElectronicMetersData":
                    PresentationLayer.ElectronicMeters.frm_ElectronicMeters electronicMeters = new PresentationLayer.ElectronicMeters.frm_ElectronicMeters();
                    electronicMeters.Show();
                    break;
                case "AreasData":
                    PresentationLayer.Areas.frm_Areas area = new PresentationLayer.Areas.frm_Areas();
                    area.Show();
                    break;
                case "SupplierData":
                    PresentationLayer.Suppliers.frm_Suppliers supplier = new PresentationLayer.Suppliers.frm_Suppliers();
                    supplier.Show();
                    break;
                case "Prices":
                    PresentationLayer.Prices.frm_Prices price = new PresentationLayer.Prices.frm_Prices();
                    price.Show();
                    break;
                case "Readings":
                    PresentationLayer.Readings.frm_Readings reading = new PresentationLayer.Readings.frm_Readings();
                    reading.Show();
                    break;
                case "CustomerMovement":
                    PresentationLayer.CustomerMovements.frm_CustomerMovements customerMovement = new PresentationLayer.CustomerMovements.frm_CustomerMovements();
                    customerMovement.Show();
                    break;
                case "PaymentVoucher":
                    PresentationLayer.PaymentVoucher.frm_PaymentVoucher paymentVoucher = new PresentationLayer.PaymentVoucher.frm_PaymentVoucher();
                    paymentVoucher.Show();
                    break;
                case "PowerStationData":
                    PresentationLayer.PowerStation.frm_PowerStation powerStation = new PresentationLayer.PowerStation.frm_PowerStation();
                    powerStation.Show();
                    break;
                case "AccountStatementForCustomer":
                    PresentationLayer.frm_AccountStatementForCustomer accountStatementForCustomer = new PresentationLayer.frm_AccountStatementForCustomer();
                    accountStatementForCustomer.Show();
                    break;
                case "SalaryPayment":
                    PresentationLayer.PaymentVoucher.frm_SalaryPayment salaryPayment = new PresentationLayer.PaymentVoucher.frm_SalaryPayment();
                    salaryPayment.Show();
                    break;

                case "AllowReadings":
                    PresentationLayer.Employees.frm_StartAndEndOfCollection startAndEndOfCollection = new PresentationLayer.Employees.frm_StartAndEndOfCollection();
                    startAndEndOfCollection.Show();
                    break;

                case "ShowAllPermissions":
                    BusinessLayer.Permissions.ClsPermissions permissions = new BusinessLayer.Permissions.ClsPermissions();

                    DataTable DataTable1 = permissions.GetAllPermissions();

                    if (DataTable1.Rows.Count > 0)
                    {
                        PresentationLayer.Permissions.frm_CurrentPermisions currentPermisions = new PresentationLayer.Permissions.frm_CurrentPermisions();
                        currentPermisions.Show();
                    }
                    else
                    {
                        MessageBox.Show("لا توجد اي صلاحيات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    break;
                case "CreateBackup":
                    CreateBackup();
                    break;
                case "RestoreBackup":
                    ResotreBackup();
                    break;
                default:
                    break;
            }



        }

        private void tv_Screens_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node != null)
            {
                ExecuteNodeAction(e.Node);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_Collapse_Click(object sender, EventArgs e)
        {
            tv_Screens.CollapseAll();
        }
    }
}

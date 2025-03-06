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

            DataTable DataTable1 = new DataTable();

            DataTable1 = customerMovement.GenerateCustomerMovementID();

            txt_CustomerMovementID.Text = DataTable1.Rows[0][0].ToString();

            rich_CustomerMovementNote.Text = "سداد فاتورة";


        }

        private void txt_ElectricityMeterIDOrPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                DataTable DataTable1 = new DataTable();

                DataTable1 = customer.SearchForCustomer(txt_ElectricityMeterIDOrPhoneNumber.Text);

                if (DataTable1.Rows.Count > 0)
                {
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

            DataTable1 = reading.GetCustomerTotalDues(Convert.ToDouble(txt_ElectricityMeterIDOrPhoneNumber.Text));
            TotalDuesBeforePaying = DataTable1.Rows[0][0].ToString();

            if(txt_CustomerMovementPaiedAmount.Text != string.Empty)
            {
                double TotalDues = Convert.ToDouble(TotalDuesBeforePaying) - Convert.ToDouble(txt_CustomerMovementPaiedAmount.Text);

                txt_TotalDuesAfterPaying.Text = TotalDues.ToString();
            }
            else
            {
                txt_TotalDuesAfterPaying.Text = DataTable1.Rows[0][0].ToString();

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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckIfTextBoxesIsNull())
            {
                if(cmb_CustomerMovementType.SelectedIndex != -1)
                {
                    if (dtp_CustomerMovementDate.Value.Date == DateTime.Now.Date)
                    {
                        double TotalDuesAfterPaying = (Convert.ToDouble(txt_TotalDuesAfterPaying.Text)) ;
                        customerMovement.UpdateCustomerTotalDuesWhenPaying(Convert.ToDouble(txt_ElectricityMeterID.Text), TotalDuesAfterPaying);

                        int CustomerMovementType=0;

                        if(cmb_CustomerMovementType.Text == "كاش")
                        {
                            CustomerMovementType = 1;
                        }
                        else if (cmb_CustomerMovementType.Text == "دفع الكتروني")
                        {
                            CustomerMovementType = 2;

                        }


                        customerMovement.AddNewCustomerMovement(Convert.ToInt32(txt_CustomerMovementID.Text) , dtp_CustomerMovementDate.Value , Convert.ToDouble(txt_CustomerMovementPaiedAmount.Text) , TotalDuesAfterPaying , rich_CustomerMovementNote.Text , CustomerMovementType,Convert.ToInt32(txt_CustomerID.Text) , Convert.ToInt32(txt_EmployeeID.Text));
                        MessageBox.Show("تم اضافة سند القبض بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        EmptyTextBoxes();

                        EnableAndDisEnableTextBoxesAndButtons(false);


                        btn_Edit.Enabled = false;


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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerStationDisktop.PresentationLayer.Readings
{
    public partial class frm_Readings : Form
    {
        BusinessLayer.Readings.ClsReadings reading = new BusinessLayer.Readings.ClsReadings();
        BusinessLayer.Customers.ClsCustomers customer = new BusinessLayer.Customers.ClsCustomers();
        BusinessLayer.ElectronicMeters.ClsElectronicMeter electronicMeter = new BusinessLayer.ElectronicMeters.ClsElectronicMeter();

        public frm_Readings()   
        {
            InitializeComponent();
            AutocompeleteSearchText();
        }

        void AutocompeleteSearchText()
        {
            AutoCompleteStringCollection ob = new AutoCompleteStringCollection();

            DataTable DataTable1 = new DataTable();

            DataTable1 = reading.GetElectronicMeterswhichHaveBeenChoosen();

            for (int i = 0; i < DataTable1.Rows.Count; i++)
            {
                ob.Add(DataTable1.Rows[i][0].ToString());
                //ob.Add(DataTable1.Rows[i][2].ToString());
            }

            this.txt_ElectricityMeterID.AutoCompleteCustomSource = ob;
            this.txt_ElectricityMeterID.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.txt_ElectricityMeterID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        void EnableAndDisEnableTextBoxesAndButtons(bool value)
        {
            txt_CurrentReading.Enabled = value;
            dtp_DateOfCurrentReading.Enabled = value;

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

        void ClearDataGridView()
        {
            dgv_Readings.DataSource = null;
            dgv_Readings.Rows.Clear();
            dgv_Readings.Columns.Clear();
        }

        void GetAllReadingsForSpecificElectronicMeter()
        {
            dgv_Readings.DataSource = reading.GetAllReadingsForSpecificElectronicMeter(Convert.ToDouble(txt_ElectricityMeterID.Text));

            dgv_Readings.Columns[0].Visible = false;
            dgv_Readings.Columns[1].HeaderText = "القراءة السابقة";
            dgv_Readings.Columns[2].HeaderText = "القراءة الحالية";
            dgv_Readings.Columns[3].HeaderText = "تاريخ آخر قراءة";
            dgv_Readings.Columns[4].Visible = false;
            dgv_Readings.Columns[5].Visible = false;
            dgv_Readings.Columns[6].Visible = false;
            dgv_Readings.Columns[7].Visible = false;
            dgv_Readings.Columns[8].Visible = false;
            dgv_Readings.Columns[9].HeaderText = "المحصل";
            dgv_Readings.Columns[10].HeaderText = "سعر الكيلو";
        }

        private void txt_ElectricityMeterID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable DataTable1 = new DataTable();

                DataTable1 = electronicMeter.GetElectronicMeterInformationWhichConnectedToCustomer(Convert.ToDouble(txt_ElectricityMeterID.Text));

                if(DataTable1.Rows.Count > 0)
                {
                    EnableAndDisEnableTextBoxesAndButtons(true);
                    btn_New.Enabled = true;
                    btn_Save.Enabled = true;
                    btn_Edit.Enabled = false;
                    btn_Delete.Enabled = false;


                    DataTable1.Clear();
                    DataTable1 = reading.GetPreviousReading(Convert.ToDouble(txt_ElectricityMeterID.Text));

                    if (DataTable1.Rows.Count > 0)
                    {
                        txt_CurrentReading.Text = string.Empty;

                        txt_PreviousReading.Text = DataTable1.Rows[0][0].ToString();

                        DataTable1.Clear();

                        DataTable1 = customer.SearchForCustomer(txt_ElectricityMeterID.Text);
                        txt_CustomerName.Text = DataTable1.Rows[0][1].ToString();
                        txt_AreaID.Text = DataTable1.Rows[0][6].ToString();

                        DataTable1.Clear();

                        DataTable1 = reading.SearchForArea(Convert.ToInt32(txt_AreaID.Text));
                        txt_AreaName.Text = DataTable1.Rows[0][0].ToString();



                        DataTable1.Clear();

                        DataTable1 = reading.GetCustomerTotalDues(Convert.ToDouble(txt_ElectricityMeterID.Text));
                        txt_TotalDuesInThisReading.Text = DataTable1.Rows[0][0].ToString();

                        DataTable1.Clear();

                        DataTable1 = reading.GetLastPrice();
                        txt_PriceID.Text = DataTable1.Rows[0][0].ToString();
                        txt_Price.Text = DataTable1.Rows[0][1].ToString();

                        txt_EmployeeID.Text = "1";


                        GetAllReadingsForSpecificElectronicMeter();

                        btn_New.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("لاتوجد قراءات مضافة لهذا العداد..!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        txt_PreviousReading.Text = "0";
                        txt_CurrentReading.Text = string.Empty;


                        DataTable1.Clear();

                        DataTable1 = customer.SearchForCustomer(txt_ElectricityMeterID.Text);
                        txt_CustomerName.Text = DataTable1.Rows[0][1].ToString();
                        txt_AreaID.Text = DataTable1.Rows[0][6].ToString();

                        DataTable1.Clear();

                        DataTable1 = reading.SearchForArea(Convert.ToInt32(txt_AreaID.Text));
                        txt_AreaName.Text = DataTable1.Rows[0][0].ToString();



                        txt_TotalDuesInThisReading.Text = "0";

                        DataTable1.Clear();

                        DataTable1 = reading.GetLastPrice();
                        txt_PriceID.Text = DataTable1.Rows[0][0].ToString();
                        txt_Price.Text = DataTable1.Rows[0][1].ToString();

                        txt_EmployeeID.Text = "1";


                        ClearDataGridView();

                    }
                }
                else
                {
                    MessageBox.Show("رقم العداد الذي ادخلته غير صحيح أو أنه غير مرتبط بعميل ..!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDataGridView();
                    EmptyTextBoxes();
                }





            }
        }

        private void dgv_Readings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EnableAndDisEnableTextBoxesAndButtons(true);
            btn_Save.Enabled = false;
            btn_Edit.Enabled = true;
            btn_Delete.Enabled = true;



            txt_PreviousReading.Text = dgv_Readings.CurrentRow.Cells[1].Value.ToString();
            txt_CurrentReading.Text = dgv_Readings.CurrentRow.Cells[2].Value.ToString();
            dtp_DateOfCurrentReading.Text = dgv_Readings.CurrentRow.Cells[3].Value.ToString();
            txt_TotalDuesInThisReading.Text = dgv_Readings.CurrentRow.Cells[4].Value.ToString();
            txt_Price.Text = dgv_Readings.CurrentRow.Cells[10].Value.ToString();
            txt_PriceID.Text = dgv_Readings.CurrentRow.Cells[6].Value.ToString();
            txt_EmployeeID.Text = dgv_Readings.CurrentRow.Cells[7].Value.ToString();
            txt_AreaID.Text = dgv_Readings.CurrentRow.Cells[8].Value.ToString();




            btn_New.Enabled = true;
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            EmptyTextBoxes();
            EnableAndDisEnableTextBoxesAndButtons(true);
            txt_ElectricityMeterID.Enabled = true;

            ClearDataGridView();

            txt_ElectricityMeterID.Focus();
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

        bool ComparePreviousReadingAndCurrentReading(string PreviousReading , string CurrentReading)
        {
            if (Convert.ToDouble(CurrentReading) > Convert.ToDouble(PreviousReading))
                return true;
            else
                return false;
        }

        bool CheckIfThisReadingHasBeenAddedBeforeOrNot(DateTime DateOfNewReading)
        {
            DataTable DataTable1 = reading.GetLastReadingForSpecificElectronicMeter(Convert.ToDouble(txt_ElectricityMeterID.Text));
            if(DataTable1.Rows.Count > 0)
            {
                DateTime lastReadingDate;

                // Try to convert the object to DateTime safely
                DateTime.TryParse(DataTable1.Rows[0][3].ToString(), out lastReadingDate);
                if (lastReadingDate.Date == DateOfNewReading)
                {
                    return true;

                }
                else
                    return false;
                //else if(lastReadingDate < DateOfNewReading)
                //{
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}

            }
            else // if there were no data .. I enter reading for the first time ..
            {
                return false;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckIfTextBoxesIsNull())
                {
                    if(dtp_DateOfCurrentReading.Value.Date == DateTime.Now.Date)
                    {
                        if (!CheckIfThisReadingHasBeenAddedBeforeOrNot(dtp_DateOfCurrentReading.Value.Date))
                        {
                            if (ComparePreviousReadingAndCurrentReading(txt_PreviousReading.Text, txt_CurrentReading.Text))
                            {

                                double TotalBlanceForThisReading = (Convert.ToDouble(txt_CurrentReading.Text) - Convert.ToDouble(txt_PreviousReading.Text)) * Convert.ToDouble(txt_Price.Text);
                                customer.UpdateCustomerTotalDues(Convert.ToDouble(txt_ElectricityMeterID.Text), TotalBlanceForThisReading);

                                reading.AddNewReading(Convert.ToDouble(txt_PreviousReading.Text), Convert.ToDouble(txt_CurrentReading.Text), dtp_DateOfCurrentReading.Value, Convert.ToDouble(txt_TotalDuesInThisReading.Text), Convert.ToDouble(txt_ElectricityMeterID.Text), Convert.ToInt32(txt_PriceID.Text), Convert.ToInt32(txt_EmployeeID.Text), Convert.ToInt32(txt_AreaID.Text));
                                MessageBox.Show("تم اضافة القراءة بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                EmptyTextBoxes();

                                EnableAndDisEnableTextBoxesAndButtons(false);

                                ClearDataGridView();


                                btn_Edit.Enabled = false;
                                btn_Delete.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("لا يمكن أن تكون القراءة الجديدة أصغر أو تساوي القراءة السابقة..!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                        }
                        else
                        {
                            MessageBox.Show("هناك قراءة سابقة بنفس التاريخ المختار", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(" لا يمكن أن يكون التاريخ المدخل أكبر أو أصغر من التاريخ الحالي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("تأكد من: " + ex, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txt_CurrentReading_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8 || e.KeyChar == 46)  // e.KeyChar == 8    => this for backspace button.. ,  e.KeyChar == 46    => this for dot ( . ) ..
                e.Handled = false;
            else
                e.Handled = true;
        }

    }
}

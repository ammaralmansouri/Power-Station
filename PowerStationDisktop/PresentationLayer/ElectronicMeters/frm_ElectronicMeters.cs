using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerStationDisktop.PresentationLayer.ElectronicMeters
{
    public partial class frm_ElectronicMeters : Form
    {
        BusinessLayer.ElectronicMeters.ClsElectronicMeter electronicMeter = new BusinessLayer.ElectronicMeters.ClsElectronicMeter();
        BusinessLayer.Customers.ClsCustomers customer = new BusinessLayer.Customers.ClsCustomers();
        public frm_ElectronicMeters()
        {
            InitializeComponent();
            GetAllElectronicMeter();
        }


        void GetAllElectronicMeter()
        {
            //cmb_ElectronicMeterType.DataSource = electronicMeter.GetAllELectronicMeters();

            dgv_ElectronicMeters.DataSource = electronicMeter.GetAllELectronicMeters();

            dgv_ElectronicMeters.Columns[0].HeaderText = "رقم العداد";
            dgv_ElectronicMeters.Columns[1].Visible = false;    // this is refer to ElectronicMeter Type
            dgv_ElectronicMeters.Columns[2].Visible = false;    // this is to show the BARMA I made it in the query..
            dgv_ElectronicMeters.Columns[3].HeaderText = "نوع العداد";

        }

        void EmptyTextBoxes()
        {
            txt_ElectronicMeterID.Text = string.Empty;
            cmb_ElectronicMeterType.Text = string.Empty;
            txt_ElectronicMeterIDForUpdating.Text = string.Empty;
        }

        bool CheckIfFiledsEmptyOrNot()
        {
            if(txt_ElectronicMeterID.Text != string.Empty)
            { 
                if (cmb_ElectronicMeterType.Text != string.Empty)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                    
            }
            else
            {
                return false;
            } 
        }

        void EnableAndDisEnableTextBoxesAndButtons(bool value)
        {
            txt_ElectronicMeterID.Enabled = value;
            cmb_ElectronicMeterType.Enabled = value;

            btn_Save.Enabled = value;

            
            btn_New.Enabled = !value;
            btn_Delete.Enabled = !value;
        }

        

        private void txt_ElectronicMeterID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)  // e.KeyChar == 8    => this for backspace button..
            //    e.Handled = false;
            //else
            //    e.Handled = true;
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            EnableAndDisEnableTextBoxesAndButtons(true);
            EmptyTextBoxes();


        }

        bool IsElectronicMeterExist(DataTable DataTable1)
        {
            for (int i = 0; i < DataTable1.Rows.Count; i++)
            {
                if (DataTable1.Rows[i][0].ToString() == txt_ElectronicMeterID.Text)
                {
                    return true;
                }

            }
            return false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            try
            {

                DataTable DataTable1 = new DataTable();

                DataTable1 = electronicMeter.GetAllELectronicMeters();

                if(!IsElectronicMeterExist(DataTable1))
                {
                    int ElectronicMeterType;

                    if (CheckIfFiledsEmptyOrNot())
                    {
                        DialogResult result = MessageBox.Show("هل أنت متأكد من البيانات المُدخلة..؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            if (cmb_ElectronicMeterType.Text == "الكتروني")
                            {
                                ElectronicMeterType = 1;
                            }
                            else
                            {
                                ElectronicMeterType = 2;
                            }

                            electronicMeter.AddNewElectronicMeter(Convert.ToDouble(txt_ElectronicMeterID.Text), ElectronicMeterType, DateTime.Now);
                            MessageBox.Show("تمت اضافة العداد بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetAllElectronicMeter();

                            EnableAndDisEnableTextBoxesAndButtons(false);
                            EmptyTextBoxes();


                            btn_Delete.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("تأكد من تعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("هذا العداد موجود بالفعل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show("تأكد من :"+ex, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show($"An Error Occurred: {ex.Message}\n\nSource: {ex.Source}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void dgv_ElectronicMeters_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable DataTable1 = electronicMeter.GetElectronicMeterInformation(Convert.ToDouble(dgv_ElectronicMeters.CurrentRow.Cells[0].Value));

            txt_ElectronicMeterID.Text = DataTable1.Rows[0][0].ToString();
            cmb_ElectronicMeterType.Text = DataTable1.Rows[0][3].ToString();

            txt_ElectronicMeterIDForUpdating.Text = DataTable1.Rows[0][0].ToString();

            EnableAndDisEnableTextBoxesAndButtons(true);

            btn_Save.Enabled = false;
            
            btn_New.Enabled = true;
            btn_Delete.Enabled = true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("هل أنت متأكد من عملية الحذف..؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    if (CheckIfFiledsEmptyOrNot())
                    {
                        DataTable DataTable2 = new DataTable();
                        DataTable2 = customer.GetCustomerInformation(Convert.ToDouble(txt_ElectronicMeterID.Text));

                        if (DataTable2.Rows.Count > 0)
                        {
                            MessageBox.Show("لايمكن حذف هذا العداد لأنه خاص بعميل معين..!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            DataTable2 = electronicMeter.GetElectronicMeterInformation(Convert.ToDouble(txt_ElectronicMeterID.Text));

                            if (DataTable2.Rows.Count > 0)
                            {
                                electronicMeter.DeleteElectronicMeter(Convert.ToDouble(txt_ElectronicMeterID.Text));
                                MessageBox.Show("تمت علمية الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                EmptyTextBoxes();
                                EnableAndDisEnableTextBoxesAndButtons(false);
                                GetAllElectronicMeter();


                                btn_Delete.Enabled = false;
                                
                            }
                            else
                            {
                                MessageBox.Show("هذا العداد غير موجود .. تأكد من رقم العداد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("تأكد من تعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("تأكد من: " + ex, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"An Error Occurred: {ex.Message}\n\nSource: {ex.Source}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}

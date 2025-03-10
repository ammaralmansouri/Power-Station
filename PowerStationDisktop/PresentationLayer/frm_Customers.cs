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

namespace PowerStationDisktop.PresentationLayer
{
    public partial class frm_Customers : Form
    {
        BusinessLayer.Customers.ClsCustomers customer = new BusinessLayer.Customers.ClsCustomers();
        private Regex regex = new Regex(@"^7[80137]\d{7}$");
        public frm_Customers()
        {
            InitializeComponent();

            //this.txt_CustomerPhone.TextChanged += txt_CustomerPhone_TextChanged;
            //this.txt_CustomerPhone.KeyPress += txt_CustomerPhone_KeyPress_1;

            GetAllAreas();
            GetElectronicMeterswhichHaveNotBeenChoosen();
            GetAllCustomers();
            AutocompeleteSearchText();
        }


        void AutocompeleteSearchText()
        {
            AutoCompleteStringCollection ob = new AutoCompleteStringCollection();

            DataTable DataTable1 = new DataTable();

            DataTable1 = customer.SearchForCustomer(txt_Search.Text);

            for (int i = 0; i < DataTable1.Rows.Count; i++)
            {
                ob.Add(DataTable1.Rows[i][5].ToString());
                ob.Add(DataTable1.Rows[i][2].ToString());
            }

            this.txt_Search.AutoCompleteCustomSource = ob;
            this.txt_Search.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.txt_Search.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }



        void GetAllAreas()
        {
            cmb_AreaID.DataSource = customer.GetAllAreas();

            cmb_AreaID.ValueMember = "AreaID";
            cmb_AreaID.DisplayMember = "AreaName";
        }

        void GetElectronicMeterswhichHaveNotBeenChoosen()
        {
            cmb_ElectronicMeters.DataSource = customer.GetElectronicMeterswhichHaveNotBeenChoosen();

            cmb_ElectronicMeters.ValueMember = "ElectronicMeterID";
            cmb_ElectronicMeters.DisplayMember = "ElectronicMeterID";
        }


        void GetAllCustomers()
        {

            dgv_Customers.DataSource = customer.GetAllCustomers(); ;

            dgv_Customers.Columns[0].Visible = false;
            dgv_Customers.Columns[1].HeaderText = "الاسم";
            dgv_Customers.Columns[2].HeaderText = "رقم الهاتف";
            dgv_Customers.Columns[3].Visible = false;
            dgv_Customers.Columns[4].HeaderText = "عليه";
            dgv_Customers.Columns[5].HeaderText = "رقم العداد";
            dgv_Customers.Columns[6].HeaderText = "المنطقة";

        }

        void EnableAndDisEnableTextBoxesAndButtons(bool value)
        {
            txt_CustomerName.Enabled = value;
            txt_CustomerPassword.Enabled = value;
            txt_CustomerPhone.Enabled = value;
            txt_CustomerTotalDues.Enabled = value;

            btn_Save.Enabled = value;

            btn_New.Enabled = !value;
            
        }
        private void btn_New_Click(object sender, EventArgs e)
        {
            EnableAndDisEnableTextBoxesAndButtons(true);
            GetElectronicMeterswhichHaveNotBeenChoosen();
            EmptyTextBoxes();


            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;

            txt_CustomerPassword.Text = "123456"; // give defult value to the password ..
            
            txt_CustomerTotalDues.Text = "0";

            DataTable DataTable1 = new DataTable();

            DataTable1 = customer.GenerateCustomerID();

            txt_CustomerID.Text = DataTable1.Rows[0][0].ToString();
            txt_CustomerPhone.BackColor = Color.White;
                
        }


        private void txt_CustomerTotalDues_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)  // e.KeyChar == 8    => this for backspace button..
                e.Handled = false;
            else
                e.Handled = true;

        }

        bool CheckIfTextBoxesIsNull()
        {
            foreach(var c in groupBox1.Controls)
            {
                if(c is TextBox)
                {
                    if(((TextBox)c).Text== string.Empty)
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
            string phoneNumber = txt_CustomerPhone.Text;
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

        void DisEnableTextBoxesAndSaveButtonAndEnableNewButton()
        {
            txt_CustomerName.Enabled = false;
            txt_CustomerPassword.Enabled = false;
            txt_CustomerPhone.Enabled = false;
            txt_CustomerTotalDues.Enabled = true;

            btn_Save.Enabled = true;

            btn_New.Enabled = false;
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

                        customer.AddNewCustomer(txt_CustomerName.Text,txt_CustomerPhone.Text, txt_CustomerPassword.Text, Convert.ToDouble(txt_CustomerTotalDues.Text), Convert.ToDouble(cmb_ElectronicMeters.SelectedValue), Convert.ToInt32(cmb_AreaID.SelectedValue), PoweStationID);
                        MessageBox.Show("تم اضافة العميل بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        EmptyTextBoxes();

                        EnableAndDisEnableTextBoxesAndButtons(false);

                        GetElectronicMeterswhichHaveNotBeenChoosen();

                        GetAllCustomers();

                        txt_CustomerPhone.Text = string.Empty;


                        btn_Edit.Enabled = false;
                        btn_Delete.Enabled = false;

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("تأكد من: "+ex, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode ==Keys.Enter)
            {
                EnableAndDisEnableTextBoxesAndButtons(true);
                btn_Save.Enabled = false;
                btn_Edit.Enabled = true;
                btn_Delete.Enabled = true;

                DataTable DataTable1 = new DataTable();

                DataTable1 = customer.SearchForCustomer(txt_Search.Text);

                txt_CustomerID.Text = DataTable1.Rows[0][0].ToString();
                txt_CustomerName.Text = DataTable1.Rows[0][1].ToString();
                txt_CustomerPhone.Text = DataTable1.Rows[0][2].ToString();
                txt_CustomerPassword.Text = DataTable1.Rows[0][3].ToString();
                txt_CustomerTotalDues.Text = DataTable1.Rows[0][4].ToString();
                cmb_ElectronicMeters.Text = DataTable1.Rows[0][5].ToString();
                cmb_AreaID.Text = DataTable1.Rows[0][6].ToString();

                txt_Search.Text = string.Empty;
                btn_New.Enabled = true;
            }
        }

        private void dgv_Customers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EnableAndDisEnableTextBoxesAndButtons(true);
            btn_Save.Enabled = false;
            btn_Edit.Enabled = true;
            btn_Delete.Enabled = true;

            DataTable DataTable1 = new DataTable();

            DataTable1 = customer.SearchForCustomer(dgv_Customers.CurrentRow.Cells[5].Value.ToString());

            txt_CustomerID.Text = DataTable1.Rows[0][0].ToString();
            txt_CustomerName.Text = DataTable1.Rows[0][1].ToString();
            txt_CustomerPhone.Text = DataTable1.Rows[0][2].ToString();
            txt_CustomerPassword.Text = DataTable1.Rows[0][3].ToString();
            txt_CustomerTotalDues.Text = DataTable1.Rows[0][4].ToString();
            cmb_ElectronicMeters.Text = DataTable1.Rows[0][5].ToString();
            cmb_AreaID.Text = DataTable1.Rows[0][6].ToString();

            
            btn_New.Enabled = true;

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult result = MessageBox.Show("هل أنت متأكد من عملية الحذف..؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    customer.DeleteCustomer(Convert.ToInt32(txt_CustomerID.Text));
                    MessageBox.Show("تمت علمية الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    EmptyTextBoxes();
                    EnableAndDisEnableTextBoxesAndButtons(false);
                    GetAllCustomers();

                    txt_CustomerPhone.Text = string.Empty;
                    btn_Delete.Enabled = false;
                    btn_Edit.Enabled = false;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("تأكد من: " + ex, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                        int PoweStationID = 1;

                        customer.UpdateCustomer( Convert.ToInt32(txt_CustomerID.Text), txt_CustomerName.Text, txt_CustomerPhone.Text, txt_CustomerPassword.Text, Convert.ToDouble(txt_CustomerTotalDues.Text), Convert.ToDouble(cmb_ElectronicMeters.SelectedValue), Convert.ToInt32(cmb_AreaID.SelectedValue), PoweStationID);
                        MessageBox.Show("تم تعديل العميل بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        EmptyTextBoxes();

                        EnableAndDisEnableTextBoxesAndButtons(false);

                        GetElectronicMeterswhichHaveNotBeenChoosen();

                        GetAllCustomers();

                        txt_CustomerPhone.Text = string.Empty;


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

        private void txt_CustomerPhone_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txt_CustomerPhone_TextChanged(object sender, EventArgs e)
        {


            string input = txt_CustomerPhone.Text;
            if (!regex.IsMatch(input))
            {
                //MessageBox.Show("لطفا ادخل رقم هاتف صحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txt_CustomerPhone.BackColor = Color.Red;
               
                //txt_CustomerPhone.Clear();
            }
            else
            {
                txt_CustomerPhone.BackColor = Color.White;
            }
        }
    }
}

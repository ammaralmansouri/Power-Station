using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using PowerStationDisktop.BusinessLayer.Settings;

namespace PowerStationDisktop.PresentationLayer.Areas
{
    public partial class frm_Areas : Form
    {
        BusinessLayer.Areas.ClsAreas area = new BusinessLayer.Areas.ClsAreas();
        BusinessLayer.Customers.ClsCustomers customer = new BusinessLayer.Customers.ClsCustomers();
        BusinessLayer.Normalization.ClsNormalize normalize = new BusinessLayer.Normalization.ClsNormalize();

        

        public frm_Areas()
        {
            InitializeComponent();
            GetAllAreas();


            // this => using PowerStationDisktop.BusinessLayer.Colors; .. is for below ..
            //dgv_Areas.DefaultCellStyle.BackColor = ClsAppColors.DefaultCellStyle;
            //dgv_Areas.AlternatingRowsDefaultCellStyle.BackColor = ClsAppColors.AlternatingRowsDefaultCellStyle;

            //dgv_Areas.DefaultCellStyle.Font.Size = ClsAppFontSize.DefaultCellStyle; 
        }

        void GetAllAreas()
        {

            DataTable DataTable1 = area.GetAllAreas();

            if (DataTable1.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد بيانات متاحة.", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_Areas.DataSource = null;
                return;
            }

            // Above Condition to make sure if there are date or not ..

            dgv_Areas.DataSource = DataTable1;

            dgv_Areas.Columns[0].Visible = false;
            dgv_Areas.Columns[1].HeaderText = "اسم المنطقة";
        }

        private void dgv_Areas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txt_AreaID.Text = dgv_Areas.CurrentRow.Cells[0].Value.ToString();
            txt_AreaName.Text = dgv_Areas.CurrentRow.Cells[1].Value.ToString();

            btn_Delete.Enabled = true;
            btn_Edit.Enabled = true;

            btn_Save.Enabled = false;

            txt_AreaName.Enabled = true;

            txt_AreaName.Focus();

        }
        void ClearTextBoxes()
        {
            txt_AreaID.Text = string.Empty;
            txt_AreaName.Text = string.Empty;

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            txt_AreaName.Enabled = true;
            txt_AreaName.Text = string.Empty;
            txt_AreaName.Focus();

            btn_Save.Enabled = true;
            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(txt_AreaName.Text != string.Empty)
            {
                try
                {
                    DataTable DataTable1 = area.CheckIfThisAreaHasBeenAddedOrNot(txt_AreaName.Text);
                    if (DataTable1.Rows.Count > 0)
                    {
                        MessageBox.Show(".لا يمكن إضافة نفس المنطقة مرتين", "المنطقة مسجلة مسبقًا🚨", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("هل أنت متأكد من البيانات المُدخلة..؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            area.AddNewArea(txt_AreaName.Text);
                            normalize.ChangeLettersToStandardLettersToMakeItEasyWhenSearchForArea();
                            MessageBox.Show(". تمت إضافة المنطقة بنجاح ✅", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetAllAreas();

                            ClearTextBoxes();
                            txt_AreaName.Enabled = false;
                            btn_Save.Enabled = false;

                        }


                    }
                }
                catch(Exception ex)
                {
                    //MessageBox.Show("تأكد من: " + ex, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show($"An Error Occurred: {ex.Message}\n\nSource: {ex.Source}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show(".لا يمكن ترك هذا الحقل فارغًا", " يرجى إدخال اسم المنطقة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_AreaName.Text != string.Empty)
                {
                    DataTable DataTable1 = customer.GetCustomerInformationByHisAreaID(Convert.ToInt32(txt_AreaID.Text));

                    if (DataTable1.Rows.Count > 0)
                    {
                        MessageBox.Show(". يوجد عملاء مرتبطون بهذه المنطقة، احذفهم أولًا ", "لا يمكن الحذف❌", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        DialogResult result = MessageBox.Show(". هل تريد بالتأكيد حذف هذه المنطقة؟ هذه العملية لا يمكن التراجع عنها", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            area.DeleteArea(Convert.ToInt32(txt_AreaID.Text));
                            MessageBox.Show("تم حذف المنطقة بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            GetAllAreas();
                            ClearTextBoxes();

                            btn_Delete.Enabled = false;
                            btn_Save.Enabled = false;
                            btn_Edit.Enabled = false;
                            btn_New.Enabled = true;

                            txt_AreaName.Enabled = false;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("هناك حقل فارغ..!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                

            }
            catch (Exception ex)
            {

                //MessageBox.Show("تأكد من: " + ex, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"An Error Occurred: {ex.Message}\n\nSource: {ex.Source}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_AreaName.Text != string.Empty)
                {
                    DialogResult result = MessageBox.Show("هل أنت متأكد من التعديلات..؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        area.UpdateArea(Convert.ToInt32(txt_AreaID.Text), txt_AreaName.Text);
                        normalize.ChangeLettersToStandardLettersToMakeItEasyWhenSearchForArea();

                        MessageBox.Show(".تم تحديث بيانات المنطقة بنجاح", "تم التعديل بنجاح ✏️ ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        GetAllAreas();
                        ClearTextBoxes();

                        btn_Delete.Enabled = false;
                        btn_Save.Enabled = false;
                        btn_Edit.Enabled = false;
                        btn_New.Enabled = true;


                        txt_AreaName.Enabled = false;
                    }

                        
                }
                else
                {
                    MessageBox.Show("تأكد من إدخال جميع البيانات المطلوبة", "يرجى ملء جميع الحقول⚠️", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                
            }
            catch(Exception ex)
            {
                //MessageBox.Show("تأكد من: " + ex, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"An Error Occurred: {ex.Message}\n\nSource: {ex.Source}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txt_AreaName_Enter(object sender, EventArgs e)
        {
            //when we are in this filed the language will change to arabic automaticlly..
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-ye"));
        }

        private void txt_AreaName_TextChanged(object sender, EventArgs e)
        {
            if (txt_AreaName.Text == string.Empty)
            {
                GetAllAreas();

            }
            else
            {
                dgv_Areas.DataSource = area.SearchForAreaByName(txt_AreaName.Text);

                dgv_Areas.Columns[0].Visible = false;
                dgv_Areas.Columns[1].HeaderText = "اسم المنطقة";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerStationDisktop.PresentationLayer.Areas
{
    public partial class frm_Areas : Form
    {
        BusinessLayer.Areas.ClsAreas area = new BusinessLayer.Areas.ClsAreas();
        BusinessLayer.Customers.ClsCustomers customer = new BusinessLayer.Customers.ClsCustomers();
        public frm_Areas()
        {
            InitializeComponent();
            GetAllAreas();
        }

        void GetAllAreas()
        {
            dgv_Areas.DataSource = area.GetAllAreas();

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
                        MessageBox.Show("هذه المنطقة موجودة بالفعل..!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        area.AddNewArea(txt_AreaName.Text);
                        MessageBox.Show("تم اضافة المنطقة بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetAllAreas();

                        ClearTextBoxes();
                        txt_AreaName.Enabled = false;
                        btn_Save.Enabled = false;


                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("تأكد من: " + ex, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ادخل اسم المنطقة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("لا يمكن حذف هذه المنطقة لأن هناك عملاء في هذه المنطقة..!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("هل أنت متأكد من عملية الحذف..؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            area.DeleteArea(Convert.ToInt32(txt_AreaID.Text));
                            MessageBox.Show("تم حذف المنطقة بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            GetAllAreas();
                            ClearTextBoxes();

                            btn_Delete.Enabled = false;
                            btn_Save.Enabled = false;
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
                
                MessageBox.Show("تأكد من: " + ex, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_AreaName.Text != string.Empty)
                {
                    area.UpdateArea(Convert.ToInt32(txt_AreaID.Text), txt_AreaName.Text);

                    MessageBox.Show("تم تعديل المنطقة بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetAllAreas();
                    ClearTextBoxes();

                    btn_Delete.Enabled = false;
                    btn_Save.Enabled = false;
                    btn_New.Enabled = true;


                    txt_AreaName.Enabled = false;
                }
                else
                {
                    MessageBox.Show("هناك حقل فارغ..!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                
            }
            catch(Exception ex)
            {
                MessageBox.Show("تأكد من: " + ex, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}

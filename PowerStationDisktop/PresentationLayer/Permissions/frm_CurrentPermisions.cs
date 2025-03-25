using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerStationDisktop.PresentationLayer.Permissions
{
    public partial class frm_CurrentPermisions : Form
    {
        BusinessLayer.Permissions.ClsPermissions permissions = new BusinessLayer.Permissions.ClsPermissions();
        public frm_CurrentPermisions()
        {
            InitializeComponent();
            GetAllPermissions();
        }

        void GetAllPermissions()
        {
            dgv_CurrentPermissions.DataSource = permissions.GetAllPermissions();

            dgv_CurrentPermissions.Columns[0].Visible = false;
            dgv_CurrentPermissions.Columns[1].HeaderText = "تاريح انتهاء الصلاحية";
            dgv_CurrentPermissions.Columns[2].HeaderText = "تاريخ بداية التحصيل";
            dgv_CurrentPermissions.Columns[3].HeaderText = "تاريخ نهاية التحصيل";
            dgv_CurrentPermissions.Columns[4].HeaderText = "المحصل";
            dgv_CurrentPermissions.Columns[5].HeaderText = "المنطقة";

        }

        private void dgv_CurrentPermissions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Save.Enabled = true;
            btn_Delete.Enabled = true;

            DataTable DataTable1 = new DataTable();

            DataTable1 = permissions.SearchForPermission(Convert.ToInt32(dgv_CurrentPermissions.CurrentRow.Cells[0].Value.ToString()));

            txt_PermissionID.Text = DataTable1.Rows[0][0].ToString();
            txt_EmployeeName.Text = DataTable1.Rows[0][4].ToString();
            txt_AreaName.Text = DataTable1.Rows[0][5].ToString();

            dtp_StartOfCollectionDate.Text = DataTable1.Rows[0][2].ToString();
            dtp_EndOfCollectionDate.Text = DataTable1.Rows[0][3].ToString();
        }

        void EmptyTextBoxes()
        {
            foreach (var c in groupBox3.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
            }
        }


        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("هل أنت متأكد من عملية الحذف..؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    permissions.DeletePermission(Convert.ToInt32(txt_PermissionID.Text));
                    MessageBox.Show("تمت علمية الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    EmptyTextBoxes();
                    
                    GetAllPermissions();

                    btn_Save.Enabled = false;
                    btn_Delete.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("تأكد من: " + ex, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (dtp_StartOfCollectionDate.Value.Date > dtp_EndOfCollectionDate.Value.Date)
            {
                MessageBox.Show("لا يمكن أن يكون تاريخ البداية أكبر من تاريخ النهاية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (dtp_StartOfCollectionDate.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("لا يمكن أن يكون تاريخ البداية اصغر من تاريخ اليوم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            { 

                try
                {

                    DialogResult result = MessageBox.Show("هل أنت متأكد من هذه التعديلات..؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        permissions.UpdateStartAndEndDateOfCollectionForSpecificEmployee(dtp_StartOfCollectionDate.Value, dtp_EndOfCollectionDate.Value ,Convert.ToInt32(txt_PermissionID.Text));
                        permissions.SetExpiredDateLikeEndOfCollectionDateForSpecificEmployee(dtp_EndOfCollectionDate.Value , Convert.ToInt32(txt_PermissionID.Text));
                        MessageBox.Show("تم حفظ التعديلات بنجاح    ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetAllPermissions();
                        EmptyTextBoxes();
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("تأكد من: " + ex, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
    }
}

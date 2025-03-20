using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerStationDisktop.PresentationLayer.Employees
{
    public partial class frm_Permissions : Form
    {
        BusinessLayer.Areas.ClsAreas area = new BusinessLayer.Areas.ClsAreas();
        BusinessLayer.Permissions.ClsPermissions permissions = new BusinessLayer.Permissions.ClsPermissions();
        
        public frm_Permissions()
        {
            InitializeComponent();
            
        }
        private void frm_Permissions_Load(object sender, EventArgs e)
        {
            GetAllAreasWhichEmployeeDoseNotHasAPermissionOnIt();
        }

        void GetAllAreasWhichEmployeeDoseNotHasAPermissionOnIt()
        {
            cmb_AreaName.DataSource = area.GetAllAreasWhichEmployeeDoseNotHasAPermissionOnIt(Convert.ToInt32(txt_EmployeeID.Text));

            cmb_AreaName.ValueMember = "AreaID";
            cmb_AreaName.DisplayMember = "AreaName";

        }

        private void btn_AddSelectedPermission_Click(object sender, EventArgs e)
        {
            
            if(chk_SetAsPermanentArea.Checked)
            {
                    // Here the ExpireDate will set to NULL becouse the permission is going to be a permanently ..
                     

                DataTable DataTable1 = permissions.GetDetailsOfLastPermission();

                if (DataTable1.Rows.Count > 0)
                {

                    // The ExpireDate will set to NULL but there are start and end of collection date ..
                    permissions.AddNewPermissionWithStartAndEndCollectionDateWithNullExpireDate(Convert.ToDateTime(DataTable1.Rows[0][2].ToString()), Convert.ToDateTime(DataTable1.Rows[0][3].ToString()), Convert.ToInt32(txt_EmployeeID.Text), Convert.ToInt32(cmb_AreaName.SelectedValue));

                    MessageBox.Show("تم إضافة الصلاحيات بنحاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    // The ExpireDate will set to NULL and start, end of collection will set to Null too ..

                    permissions.AddNewPermissionWithNullExpireDate( Convert.ToInt32(txt_EmployeeID.Text), Convert.ToInt32(cmb_AreaName.SelectedValue));

                    MessageBox.Show("تم إضافة الصلاحيات بنحاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }

            }
            else
            {

                if (num_NumberOfAllowedDaysForTakingReading.Value > 0)
                {
                    // Here the ExpireDate will not be set to NULL becouse the permission is going to be a temporary ..

                    DataTable DataTable1 = permissions.GetDetailsOfLastPermission();

                    if (DataTable1.Rows.Count > 0)
                    {
                        // The ExpireDate will not set to NULL and there are start and end of collection date ..

                        permissions.AddNewPermissionWithStartAndEndCollectionDate(Convert.ToDateTime(DataTable1.Rows[0][3].ToString()), Convert.ToDateTime(DataTable1.Rows[0][2].ToString()), Convert.ToDateTime(DataTable1.Rows[0][3].ToString()), Convert.ToInt32(txt_EmployeeID.Text), Convert.ToInt32(cmb_AreaName.SelectedValue));

                        MessageBox.Show("تم إضافة الصلاحيات بنحاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        // The ExpireDate will not set to NULL and start, end of collection will set to Null too ..

                        DateTime today = DateTime.Now; // تاريخ اليوم
                        DateTime newDate = today.AddDays(Convert.ToDouble(num_NumberOfAllowedDaysForTakingReading.Value)); // إضافة الأيام المحددة

                        permissions.AddNewPermisson(newDate, Convert.ToInt32(txt_EmployeeID.Text), Convert.ToInt32(cmb_AreaName.SelectedValue));

                        MessageBox.Show("تم إضافة الصلاحيات بنحاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("يجب أن تكون عدد الأيام أكبر من صفر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                
            }
        }

        private void chk_SetAsPermanentArea_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_SetAsPermanentArea.Checked)
            {
                num_NumberOfAllowedDaysForTakingReading.Enabled = false;

            }
            else
            {
                num_NumberOfAllowedDaysForTakingReading.Enabled = true;

            }

        }
    }
}

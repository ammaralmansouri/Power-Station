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
                    DialogResult result = MessageBox.Show("هل أنت متأكد من البيانات المُدخلة..؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // The ExpireDate will set to NULL but there are start and end of collection date ..
                        permissions.AddNewPermissionWithStartAndEndCollectionDateWithNullExpireDate(Convert.ToDateTime(DataTable1.Rows[0][2].ToString()), Convert.ToDateTime(DataTable1.Rows[0][3].ToString()), Convert.ToInt32(txt_EmployeeID.Text), Convert.ToInt32(cmb_AreaName.SelectedValue));

                        MessageBox.Show("تم إضافة الصلاحيات بنحاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }

                        
                }
                else
                {
                    DialogResult result = MessageBox.Show("هل أنت متأكد من البيانات المُدخلة..؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // The ExpireDate will set to NULL and start, end of collection will set to Null too ..

                        permissions.AddNewPermissionWithNullExpireDate(Convert.ToInt32(txt_EmployeeID.Text), Convert.ToInt32(cmb_AreaName.SelectedValue));

                        MessageBox.Show("تم إضافة الصلاحيات بنحاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                        
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


                        // this condition to make sure if there is  StartDateOfCollection in Last Permission or it is null ..
                        if (DataTable1.Rows[0][2].ToString() == string.Empty)
                        {
                            DialogResult result = MessageBox.Show("هل أنت متأكد من البيانات المُدخلة..؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (result == DialogResult.Yes)
                            {
                                // here the StartDateOfCollection and EndDateOfCollection are null ..
                                DateTime today = DateTime.Now; // تاريخ اليوم
                                DateTime newDate = today.AddDays(Convert.ToDouble(num_NumberOfAllowedDaysForTakingReading.Value)); // إضافة الأيام المحددة

                                permissions.AddNewPermisson(newDate, Convert.ToInt32(txt_EmployeeID.Text), Convert.ToInt32(cmb_AreaName.SelectedValue));

                                MessageBox.Show("تم إضافة الصلاحيات بنحاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Close();
                            }
                                
                        }
                        else if(Convert.ToDateTime(DataTable1.Rows[0][3].ToString()) < DateTime.Now.Date)
                        {
                            DialogResult result = MessageBox.Show("هل أنت متأكد من البيانات المُدخلة..؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (result == DialogResult.Yes)
                            {
                                // here the StartDateOfCollection and EndDateOfCollection are not null ..
                                // here the StartDateOfCollection and EndDateOfCollection are like last Permission .. but expireDate is like what admin has put..
                                // يعني هذا لما عاد التحصيل مابدا فاخلي بداية ونهاية التحصيل مثل اخر واحد عشان مانسمح له يحصل
                                // لكن تاريخ مصادرة الصلاحية عيكون مثل ماحدد الادمن بالايام
                                // عشان ماتنحذف الصلاحية
                                // ولما الادمن يسمح للكل بالتحصيل عيتعدل تاريخ انتهاء الصلاحية حسب ماعيحددة الادمن

                                DateTime today = DateTime.Now; // تاريخ اليوم
                                DateTime newDate = today.AddDays(Convert.ToDouble(num_NumberOfAllowedDaysForTakingReading.Value)); // إضافة الأيام المحددة

                                permissions.AddNewPermissionWithStartAndEndCollectionDate(newDate, Convert.ToDateTime(DataTable1.Rows[0][2].ToString()), Convert.ToDateTime(DataTable1.Rows[0][3].ToString()), Convert.ToInt32(txt_EmployeeID.Text), Convert.ToInt32(cmb_AreaName.SelectedValue));


                                MessageBox.Show("تم إضافة الصلاحيات بنحاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Close();
                            }
                                
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("هل أنت متأكد من البيانات المُدخلة..؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (result == DialogResult.Yes)
                            {
                                // here the StartDateOfCollection and EndDateOfCollection are like last Permission ..
                                // this one when I add permission to some one after he declare StartDateOfCollection and EndDateOfCollection
                                // يعني قد سمحت للكل يحصل وبعدين ذكرت انه باقي واحد .. فأضيفه وبيشل نفس تاريخ البداية والنهاية حق اللي قبله

                                permissions.AddNewPermissionWithStartAndEndCollectionDate(Convert.ToDateTime(DataTable1.Rows[0][3].ToString()), Convert.ToDateTime(DataTable1.Rows[0][2].ToString()), Convert.ToDateTime(DataTable1.Rows[0][3].ToString()), Convert.ToInt32(txt_EmployeeID.Text), Convert.ToInt32(cmb_AreaName.SelectedValue));

                                MessageBox.Show("تم إضافة الصلاحيات بنحاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Close();
                            }                       
                        }                
                    }
                    else
                    {

                        DialogResult result = MessageBox.Show("هل أنت متأكد من البيانات المُدخلة..؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            // The ExpireDate will not set to NULL and start, end of collection will set to Null too ..

                            DateTime today = DateTime.Now; // تاريخ اليوم
                            DateTime newDate = today.AddDays(Convert.ToDouble(num_NumberOfAllowedDaysForTakingReading.Value)); // إضافة الأيام المحددة

                            permissions.AddNewPermisson(newDate, Convert.ToInt32(txt_EmployeeID.Text), Convert.ToInt32(cmb_AreaName.SelectedValue));

                            MessageBox.Show("تم إضافة الصلاحيات بنحاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                        }
                            
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

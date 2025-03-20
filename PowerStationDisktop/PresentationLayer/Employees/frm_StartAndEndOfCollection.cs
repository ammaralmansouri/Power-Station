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
    public partial class frm_StartAndEndOfCollection : Form
    {
        BusinessLayer.Permissions.ClsPermissions permissions = new BusinessLayer.Permissions.ClsPermissions();
        public frm_StartAndEndOfCollection()
        {
            InitializeComponent();
        }

        private void btn_EnableCollectionForAllEmployee_Click(object sender, EventArgs e)
        {

            if(dtp_StartDateOfCollection.Value.Date > dtp_EndDateOfCollection.Value.Date)
            {
                MessageBox.Show("لا يمكن أن يكون تاريخ البداية أكبر من تاريخ النهاية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if(dtp_StartDateOfCollection.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("لا يمكن أن يكون تاريخ البداية اصغر من تاريخ اليوم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    
                    DialogResult result = MessageBox.Show("هل أنت متأكد من السماح بالتحصيل..؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        permissions.UpdateStartAndEndDateOfCollectionForAllEmployees(dtp_StartDateOfCollection.Value, dtp_EndDateOfCollection.Value);
                        permissions.SetExpiredDateLikeEndOfCollectionDateForAllEmployee(dtp_EndDateOfCollection.Value);
                        MessageBox.Show("تم السماح لجميع المحصلين بالتحصيل في التاريخ المحدد", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();


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

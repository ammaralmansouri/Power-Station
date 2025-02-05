using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerStationDisktop
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PresentationLayer.frm_Customers customer = new PresentationLayer.frm_Customers();
            customer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PresentationLayer.ElectronicMeters.frm_ElectronicMeters electronicMeters = new PresentationLayer.ElectronicMeters.frm_ElectronicMeters();
            electronicMeters.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PresentationLayer.Emloyees.frm_Employee employee = new PresentationLayer.Emloyees.frm_Employee();
            employee.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PresentationLayer.Areas.frm_Areas area = new PresentationLayer.Areas.frm_Areas();
            area.Show();
        }
<<<<<<< HEAD

        private void button5_Click(object sender, EventArgs e)
        {
            PresentationLayer.Suppliers.frm_Suppliers supplier = new PresentationLayer.Suppliers.frm_Suppliers();
            supplier.Show();
        }
=======
>>>>>>> a9f0c3d75cecd7e2f3d60ffc8abae6136086c924
    }
}

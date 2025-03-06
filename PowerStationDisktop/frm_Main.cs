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

        private void button5_Click(object sender, EventArgs e)
        {
            PresentationLayer.Suppliers.frm_Suppliers supplier = new PresentationLayer.Suppliers.frm_Suppliers();
            supplier.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PresentationLayer.Prices.frm_Prices price = new PresentationLayer.Prices.frm_Prices();
            price.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PresentationLayer.Readings.frm_Readings reading = new PresentationLayer.Readings.frm_Readings();
            reading.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PresentationLayer.CustomerMovements.frm_CustomerMovements customerMovement = new PresentationLayer.CustomerMovements.frm_CustomerMovements();
            customerMovement.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PresentationLayer.PaymentVoucher.frm_PaymentVoucher paymentVoucher = new PresentationLayer.PaymentVoucher.frm_PaymentVoucher();
            paymentVoucher.Show();
        }
    }
}

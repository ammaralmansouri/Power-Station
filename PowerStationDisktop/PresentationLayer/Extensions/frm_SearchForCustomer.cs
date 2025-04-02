using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerStationDisktop.PresentationLayer.Extensions
{
    public partial class frm_SearchForCustomer : Form
    {
        BusinessLayer.Customers.ClsCustomers customer = new BusinessLayer.Customers.ClsCustomers();

        public bool isClick = false;


        private string placeholderText = "ابحث هنا ..";
        public frm_SearchForCustomer()
        {
            InitializeComponent();

        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

            if (txt_Search.Text == placeholderText || string.IsNullOrWhiteSpace(txt_Search.Text))
            {
                // لا تنفذ البحث عند وجود العنصر النائب
                //return;

                dgv_Result.DataSource = null;
                dgv_Result.Rows.Clear();
                dgv_Result.Refresh();

            }


            dgv_Result.DataSource = customer.SearchForCustomer(txt_Search.Text);

            dgv_Result.Columns[0].Visible = false;
            dgv_Result.Columns[1].HeaderText = "الاسم";
            dgv_Result.Columns[2].HeaderText = "رقم الهاتف";
            dgv_Result.Columns[3].Visible = false;
            dgv_Result.Columns[4].Visible = false;
            dgv_Result.Columns[5].HeaderText = "رقم العداد";
            dgv_Result.Columns[6].Visible = false;
            dgv_Result.Columns[7].Visible = false;
            dgv_Result.Columns[8].HeaderText = "المنطقة";
        }

        private void txt_Search_Leave(object sender, EventArgs e)
        {
            //if (txt_Search.Text == "")
            //{
            //    txt_Search.Text = placeholderText;
            //    txt_Search.ForeColor = Color.Gray;
            //}
        }

        private void txt_Search_Enter(object sender, EventArgs e)
        {
            if (txt_Search.Text == placeholderText)
            {
                txt_Search.Text = "";
                txt_Search.ForeColor = Color.Black;

                //dgv_Result.DataSource = null;
                //dgv_Result.Rows.Clear();
                //dgv_Result.Refresh();

                dgv_Result.DataSource = customer.SearchForCustomer(txt_Search.Text);

            }
        }

        private void dgv_Customers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            isClick = true;
            this.Close();

        }

        private void frm_SearchForCustomer_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => txt_Search.Focus())); // to make sure it will be focused ..
        }
    }
}

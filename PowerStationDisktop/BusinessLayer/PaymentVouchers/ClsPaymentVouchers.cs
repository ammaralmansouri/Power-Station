using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace PowerStationDisktop.BusinessLayer.PaymentVouchers
{
    class ClsPaymentVouchers
    {

        public DataTable GeneratePaymentVoucherID()
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Generate_PaymentVoucher_ID", null);
            con.CloseConnection();

            return DataTable1;
        }

        public void AddNewPaymentVoucherForEmployee(int PaymentVoucherID, string PaymentVoucherNote, DateTime PaymentVoucherDate, double PaymentVoucherAmount, int EmployeeIDWhoTake, int EmployeeIDWhoGive)
        {

            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[6];

            para[0] = new SqlParameter("@PaymentVoucherID", SqlDbType.Int);
            para[0].Value = PaymentVoucherID;

            para[1] = new SqlParameter("@PaymentVoucherNote", SqlDbType.NVarChar, 200);
            para[1].Value = PaymentVoucherNote;

            para[2] = new SqlParameter("@PaymentVoucherDate", SqlDbType.Date);
            para[2].Value = PaymentVoucherDate;

            para[3] = new SqlParameter("@PaymentVoucherAmount", SqlDbType.Money);
            para[3].Value = PaymentVoucherAmount;

            para[4] = new SqlParameter("@EmployeeIDWhoTake", SqlDbType.Int);
            para[4].Value = EmployeeIDWhoTake;

            para[5] = new SqlParameter("@EmployeeIDWhoGive", SqlDbType.Int);
            para[5].Value = EmployeeIDWhoGive;

            con.ExecuteCommands("Add_New_Payment_Voucher_For_Employee", para);
            con.CloseConnection();

        }


        public void AddNewPaymentVoucherForSupplier(int PaymentVoucherID, string PaymentVoucherNote, DateTime PaymentVoucherDate, double PaymentVoucherAmount, int EmployeeIDWhoGive , int SupplierID)
        {

            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[6];

            para[0] = new SqlParameter("@PaymentVoucherID", SqlDbType.Int);
            para[0].Value = PaymentVoucherID;

            para[1] = new SqlParameter("@PaymentVoucherNote", SqlDbType.NVarChar, 200);
            para[1].Value = PaymentVoucherNote;

            para[2] = new SqlParameter("@PaymentVoucherDate", SqlDbType.Date);
            para[2].Value = PaymentVoucherDate;

            para[3] = new SqlParameter("@PaymentVoucherAmount", SqlDbType.Money);
            para[3].Value = PaymentVoucherAmount;

            para[4] = new SqlParameter("@EmployeeIDWhoGive", SqlDbType.Int);
            para[4].Value = EmployeeIDWhoGive;

            para[5] = new SqlParameter("@SupplierID", SqlDbType.Int);
            para[5].Value = SupplierID;


            con.ExecuteCommands("Add_New_Payment_Voucher_For_Supplier", para);
            con.CloseConnection();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PowerStationDisktop.BusinessLayer.Reports
{
    class ClsReports
    {
        public DataTable ReportForCustomerMovementWhenPaying(int CustomerMovementID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = new DataTable();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@CustomerMovementID", SqlDbType.Int);
            para[0].Value = CustomerMovementID;

            DataTable1 = con.SelectData("Report_For_CustomerMovement_When_Paying",para);
            con.CloseConnection();

            return DataTable1;
        }

        public DataTable ReportForPaymentVoucherForEmployee(int PaymentVoucherID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = new DataTable();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@PaymentVoucherID", SqlDbType.Int);
            para[0].Value = PaymentVoucherID;

            DataTable1 = con.SelectData("Report_For_Payment_Voucher_For_Employee", para);
            con.CloseConnection();

            return DataTable1;
        }

        public DataTable ReportForAccountStatementForCustomer(double ElectronicMeterID , DateTime StartDate , DateTime EndDate, int CustomerID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = new DataTable();

            SqlParameter[] para = new SqlParameter[4];

            para[0] = new SqlParameter("@ElectronicMeterID", SqlDbType.Float);
            para[0].Value = ElectronicMeterID;

            para[1] = new SqlParameter("@StartDate", SqlDbType.Date);
            para[1].Value = StartDate;

            para[2] = new SqlParameter("@EndDate", SqlDbType.Date);
            para[2].Value = EndDate;

            para[3] = new SqlParameter("@CustomerID", SqlDbType.Int);
            para[3].Value = CustomerID;

            DataTable1 = con.SelectData("Report_For_Account_Statement_For_Customer", para);
            con.CloseConnection();

            return DataTable1;
        }

        public DataTable ReportForCustomersTotalDues()
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = new DataTable();

            

            DataTable1 = con.SelectData("Report_For_Customers_Total_Dues");
            con.CloseConnection();

            return DataTable1;
        }
    }
}

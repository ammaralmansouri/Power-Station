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
    }
}

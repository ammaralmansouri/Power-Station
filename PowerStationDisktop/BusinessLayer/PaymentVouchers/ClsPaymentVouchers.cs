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

        public DataTable SearchForEmployee(string EmployeePhoneNumber)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@EmployeePhoneNumber", SqlDbType.NVarChar, 9);
            para[0].Value = EmployeePhoneNumber;

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Search_For_Employee", para);
            con.CloseConnection();

            return DataTable1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PowerStationDisktop.BusinessLayer.Suppliers
{
    class ClsSuppliers
    {
        public DataTable GetAllSuppliers()
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Get_All_Suppliers");
            con.CloseConnection();

            return DataTable1;  
        }

        public void AddNewSupplier(string SupplierName, string SupplierPhoneNumber, string SupplierDiscription , int PowerStationID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[4];

            para[0] = new SqlParameter("@SupplierName", SqlDbType.NVarChar, 100);
            para[0].Value = SupplierName;

            para[1] = new SqlParameter("@SupplierPhoneNumber", SqlDbType.NVarChar, 20);
            para[1].Value = SupplierPhoneNumber;

            para[2] = new SqlParameter("@SupplierDiscription", SqlDbType.NVarChar, 200);
            para[2].Value = @SupplierDiscription;

            para[3] = new SqlParameter("@PowerStationID", SqlDbType.Int);
            para[3].Value = PowerStationID;

            con.ExecuteCommands("Add_New_Supplier", para);
            con.CloseConnection();
        }
    }
}

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

        public DataTable GetSupplierInformation(int SupplierID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@SupplierID", SqlDbType.Int);
            para[0].Value = SupplierID;

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Get_Supplier_Information" , para);
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

        public void UpdateSupplier(int SupplierID , string SupplierName, string SupplierPhoneNumber, string SupplierDiscription, int PowerStationID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[5];

            para[0] = new SqlParameter("@SupplierID", SqlDbType.Int );
            para[0].Value = SupplierID;

            para[1] = new SqlParameter("@SupplierName", SqlDbType.NVarChar, 100);
            para[1].Value = SupplierName;

            para[2] = new SqlParameter("@SupplierPhoneNumber", SqlDbType.NVarChar, 20);
            para[2].Value = SupplierPhoneNumber;

            para[3] = new SqlParameter("@SupplierDiscription", SqlDbType.NVarChar, 200);
            para[3].Value = @SupplierDiscription;

            para[4] = new SqlParameter("@PowerStationID", SqlDbType.Int);
            para[4].Value = PowerStationID;

            con.ExecuteCommands("Update_Supplier", para);
            con.CloseConnection();
        }

        public void DeleteSupplier(int SupplierID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@SupplierID", SqlDbType.Int);
            para[0].Value = SupplierID;

            con.ExecuteCommands("Delete_Supplier", para);
            con.CloseConnection();
        }
    }
}

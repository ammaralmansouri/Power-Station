using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PowerStationDisktop.BusinessLayer.Customers
{
    class ClsCustomers
    {
        

        public DataTable GetElectronicMeterswhichHaveNotBeenChoosen()
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Get_ElectronicMeters_which_Have_Not_Been_Choosen", null);
            con.CloseConnection();

            return DataTable1;
        }

        public DataTable GetAllCustomers()
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Get_All_Customers", null);
            con.CloseConnection();

            return DataTable1;
        }

        public void AddNewCustomer(string CustomerName , string CustomerPhoneNumber ,string CustomerPassword , double CustomerTotalDues , double ElectronicMeterID  , int AreaID , int PowerStationID)
        {

            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[7];

            para[0] = new SqlParameter("@CustomerName", SqlDbType.NVarChar, 100);
            para[0].Value = CustomerName;

            para[1] = new SqlParameter("@CustomerPhoneNumber", SqlDbType.NVarChar, 20);
            para[1].Value = CustomerPhoneNumber;

            para[2] = new SqlParameter("@CustomerPassword", SqlDbType.NVarChar, 50);
            para[2].Value = CustomerPassword;

            para[3] = new SqlParameter("@CustomerTotalDues", SqlDbType.Money);
            para[3].Value = CustomerTotalDues;

            para[4] = new SqlParameter("@ElectronicMeterID", SqlDbType.Float);
            para[4].Value = ElectronicMeterID;

            para[5] = new SqlParameter("@AreaID", SqlDbType.Int);
            para[5].Value = AreaID;

            para[6] = new SqlParameter("@PowerStationID", SqlDbType.Int);
            para[6].Value = PowerStationID;

            con.ExecuteCommands("Add_New_Customer", para);
            con.CloseConnection();

        }

        public DataTable SearchForCustomer(string ElectronicMeterIDOrCustomerPhoneNumber)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@ElectronicMeterIDOrCustomerPhoneNumber", SqlDbType.NVarChar, 100);
            para[0].Value = ElectronicMeterIDOrCustomerPhoneNumber;

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Search_For_Customer", para);
            con.CloseConnection();

            return DataTable1;
        }


        public DataTable GetCustomerInformation(double ElectronicMeterID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@ElectronicMeterID", SqlDbType.Float);
            para[0].Value = ElectronicMeterID;

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Get_Customer_Information", para);
            con.CloseConnection();

            return DataTable1;
        }

        public void DeleteCustomer(int CsutomerID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@CsutomerID", SqlDbType.Int);
            para[0].Value = CsutomerID;

            con.ExecuteCommands("Delete_Customer", para);
            con.CloseConnection();
        }  

        public DataTable GenerateCustomerID()
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Generate_Customer_ID", null);
            con.CloseConnection();

            return DataTable1;
        }


        public void UpdateCustomer( int CustomerID , string CustomerName, string CustomerPhoneNumber, string CustomerPassword, double CustomerTotalDues, double ElectronicMeterID, int AreaID, int PowerStationID)
        {

            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[8];

            para[0] = new SqlParameter("@CustomerID", SqlDbType.NVarChar, 100);
            para[0].Value = CustomerID;

            para[1] = new SqlParameter("@CustomerName", SqlDbType.NVarChar, 100);
            para[1].Value = CustomerName;

            para[2] = new SqlParameter("@CustomerPhoneNumber", SqlDbType.NVarChar, 20);
            para[2].Value = CustomerPhoneNumber;

            para[3] = new SqlParameter("@CustomerPassword", SqlDbType.NVarChar, 50);
            para[3].Value = CustomerPassword;

            para[4] = new SqlParameter("@CustomerTotalDues", SqlDbType.Money);
            para[4].Value = CustomerTotalDues;

            para[5] = new SqlParameter("@ElectronicMeterID", SqlDbType.Float);
            para[5].Value = ElectronicMeterID;

            para[6] = new SqlParameter("@AreaID", SqlDbType.Int);
            para[6].Value = AreaID;

            para[7] = new SqlParameter("@PowerStationID", SqlDbType.Int);
            para[7].Value = PowerStationID;

            con.ExecuteCommands("Update_Customer", para);
            con.CloseConnection();

        }


        public DataTable GetCustomerInformationByHisAreaID(int AreaID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();
            DataTable DataTable1 = new DataTable();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@AreaID", SqlDbType.Int);
            para[0].Value = AreaID;

            DataTable1 = con.SelectData("Get_Customer_Information_By_His_AreaID", para);
            con.CloseConnection();

            return DataTable1;

        }

        public void UpdateCustomerTotalDues(double ElectronicMeterID, double TotalDues)
        {

            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@ElectronicMeterID", SqlDbType.Float);
            para[0].Value = ElectronicMeterID;

            para[1] = new SqlParameter("@TotalDues", SqlDbType.Money);
            para[1].Value = TotalDues;

            con.ExecuteCommands("Update_Customer_TotalDues", para);
            con.CloseConnection();

        }



    }
}

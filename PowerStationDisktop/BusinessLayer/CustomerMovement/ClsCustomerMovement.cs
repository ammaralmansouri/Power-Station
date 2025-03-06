using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PowerStationDisktop.BusinessLayer.CustomerMovement
{
    class ClsCustomerMovement
    {

        public DataTable GenerateCustomerMovementID()
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Generate_CustomerMovement_ID", null);
            con.CloseConnection();

            return DataTable1;
        }

        public void AddNewCustomerMovement(int CustomerMovementID , DateTime CustomerMovementDate , double CustomerMovementOaiedAmount , double TotalDuesAfterPaying, string CustomerMovementNote , int CustomerMovementType , int CustomerID , int EmployeeID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[8];

            para[0] = new SqlParameter("@CustomerMovementID", SqlDbType.Int);
            para[0].Value = CustomerMovementID;

            para[1] = new SqlParameter("@CustomerMovementDate", SqlDbType.Date);
            para[1].Value = CustomerMovementDate;

            para[2] = new SqlParameter("@CustomerMovementOaiedAmount", SqlDbType.Money);
            para[2].Value = CustomerMovementOaiedAmount;

            para[3] = new SqlParameter("@TotalDuesAfterPaying", SqlDbType.Money);
            para[3].Value = TotalDuesAfterPaying;

            para[4] = new SqlParameter("@CustomerMovementNote", SqlDbType.NVarChar, 200);
            para[4].Value = CustomerMovementNote;

            para[5] = new SqlParameter("@CustomerMovementType", SqlDbType.Int);
            para[5].Value = CustomerMovementType;

            para[6] = new SqlParameter("@CustomerID ", SqlDbType.Int);
            para[6].Value = CustomerID;

            para[7] = new SqlParameter("@EmployeeID", SqlDbType.Int);
            para[7].Value = EmployeeID;



            con.ExecuteCommands("Add_New_CustomerMovement", para);
            con.CloseConnection();
        }

        public void UpdateCustomerTotalDuesWhenPaying(double ElectronicMeterID, double TotalDuesAfterPaying)
        {

            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@ElectronicMeterID", SqlDbType.Float);
            para[0].Value = ElectronicMeterID;

            para[1] = new SqlParameter("@TotalDuesAfterPaying", SqlDbType.Money);
            para[1].Value = TotalDuesAfterPaying;

            con.ExecuteCommands("Update_Customer_TotalDues_When_Paying", para);
            con.CloseConnection();

        }
    }
}

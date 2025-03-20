using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PowerStationDisktop.BusinessLayer.Permissions
{
    class ClsPermissions
    {
        public void DeleteExpiredPermissions()
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            con.ExecuteCommands("Delete_Expired_Permissions");
            con.CloseConnection();
        }

        public void AddNewPermisson(DateTime ExpireDate, int EmployeeID, int AreaID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[3];

            para[0] = new SqlParameter("@ExpireDate", SqlDbType.Date);
            para[0].Value = ExpireDate;

            para[1] = new SqlParameter("@EmployeeID", SqlDbType.Int);
            para[1].Value = EmployeeID;

            para[2] = new SqlParameter("@AreaID", SqlDbType.Int);
            para[2].Value = AreaID;

            con.ExecuteCommands("Add_New_Permission" , para);
            con.CloseConnection();
        }

        public void UpdateStartAndEndDateOfCollectionForAllEmployees(DateTime StartOfCollectionDate, DateTime EndOfCollectionDate)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@StartOfCollectionDate", SqlDbType.Date);
            para[0].Value = StartOfCollectionDate;

            para[1] = new SqlParameter("@EndOfCollectionDate", SqlDbType.Date);
            para[1].Value = EndOfCollectionDate;

            con.ExecuteCommands("Update_Start_And_End_Date_Of_Collection_For_All_Employees", para);
            con.CloseConnection();
        }

        public void SetExpiredDateLikeEndOfCollectionDateForAllEmployee(DateTime EndOfCollectionDate)
        { 

            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@EndOfCollectionDate", SqlDbType.Date);
            para[0].Value = EndOfCollectionDate;

            con.ExecuteCommands("Set_ExpiredDate_Like_EndOfCollectionDate_For_All_Employee", para);
            con.CloseConnection();
        }

        public DataTable GetDetailsOfLastPermission()
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Get_Details_Of_Last_Permission");
            con.CloseConnection();

            return DataTable1;
        }

        public void AddNewPermissionWithStartAndEndCollectionDate(DateTime ExpireDate, DateTime StartOfCollectionDate, DateTime EndOfCollectionDate, int EmployeeID, int AreaID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[5];

            para[0] = new SqlParameter("@ExpireDate", SqlDbType.Date);
            para[0].Value = ExpireDate;

            para[1] = new SqlParameter("@StartOfCollectionDate", SqlDbType.Date);
            para[1].Value = StartOfCollectionDate;

            para[2] = new SqlParameter("@EndOfCollectionDate", SqlDbType.Date);
            para[2].Value = EndOfCollectionDate;

            para[3] = new SqlParameter("@EmployeeID", SqlDbType.Int);
            para[3].Value = EmployeeID;

            para[4] = new SqlParameter("@AreaID", SqlDbType.Int);
            para[4].Value = AreaID;

            con.ExecuteCommands("Add_New_Permission_With_Start_And_End_Collection_Date", para);
            con.CloseConnection();
        }


        public void AddNewPermissionWithStartAndEndCollectionDateWithNullExpireDate( DateTime StartOfCollectionDate, DateTime EndOfCollectionDate, int EmployeeID, int AreaID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[4];

            para[0] = new SqlParameter("@StartOfCollectionDate", SqlDbType.Date);
            para[0].Value = StartOfCollectionDate;
                 
            para[1] = new SqlParameter("@EndOfCollectionDate", SqlDbType.Date);
            para[1].Value = EndOfCollectionDate;
                 
            para[2] = new SqlParameter("@EmployeeID", SqlDbType.Int);
            para[2].Value = EmployeeID;

            para[3] = new SqlParameter("@AreaID", SqlDbType.Int);
            para[3].Value = AreaID;

            con.ExecuteCommands("Add_New_Permission_With_Start_And_End_Collection_Date_With_Null_Expire_Date", para);
            con.CloseConnection();
        }

        public void AddNewPermissionWithNullExpireDate( int EmployeeID, int AreaID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@EmployeeID", SqlDbType.Int);
            para[0].Value = EmployeeID;

            para[1] = new SqlParameter("@AreaID", SqlDbType.Int);
            para[1].Value = AreaID;

            con.ExecuteCommands("Add_New_Permission_With_Null_Expire_Date", para);
            con.CloseConnection();
        }

        public DataTable GetAllPermissions()
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Get_All_Permissions");
            con.CloseConnection();

            return DataTable1;
        }

        public DataTable SearchForPermission(int PermissionID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = new DataTable();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@PermissionID", SqlDbType.Int);
            para[0].Value = PermissionID;

            DataTable1 = con.SelectData("Search_For_Permission" , para);
            con.CloseConnection();

            return DataTable1;
        }

        public void DeletePermission(int PermissionID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();
            

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@PermissionID", SqlDbType.Int);
            para[0].Value = PermissionID;

            con.ExecuteCommands("Delete_Permission", para);
            con.CloseConnection();
        }

        public void UpdateStartAndEndDateOfCollectionForSpecificEmployee(DateTime StartOfCollectionDate, DateTime EndOfCollectionDate , int PermissionID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[3];

            para[0] = new SqlParameter("@StartOfCollectionDate", SqlDbType.Date);
            para[0].Value = StartOfCollectionDate;

            para[1] = new SqlParameter("@EndOfCollectionDate", SqlDbType.Date);
            para[1].Value = EndOfCollectionDate;

            para[2] = new SqlParameter("@PermissionID", SqlDbType.Int);
            para[2].Value = PermissionID;

            con.ExecuteCommands("Update_Start_And_End_Date_Of_Collection_For_Specific_Employee", para);
            con.CloseConnection();
        }

        public void SetExpiredDateLikeEndOfCollectionDateForSpecificEmployee(DateTime EndOfCollectionDate , int PermissionID)
        {

            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@EndOfCollectionDate", SqlDbType.Date);
            para[0].Value = EndOfCollectionDate;

            para[1] = new SqlParameter("@PermissionID", SqlDbType.Int);
            para[1].Value = PermissionID;

            con.ExecuteCommands("Set_ExpiredDate_Like_EndOfCollectionDate_For_Specific_Employee", para);
            con.CloseConnection();
        }
    }
}

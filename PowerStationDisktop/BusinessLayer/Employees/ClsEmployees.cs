using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PowerStationDisktop.BusinessLayer.Employees
{
    class ClsEmployees
    {

        public DataTable GetAllEmployees()
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = con.SelectData("Get_All_Employees");
            con.CloseConnection();

            return DataTable1;
        }

        public DataTable GenerateEmployeeID()
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Generate_Employee_ID", null);
            con.CloseConnection();

            return DataTable1;
        }


        public void AddNewEmployee(string EmployeeName, string EmployeePhoneNumber, double EmployeeSalary,  string EmployeePassword, int EmployeeType , int EmployeePermission, int EmployeeState , int PowerStationID)
        {

            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[8];

            para[0] = new SqlParameter("@EmployeeName", SqlDbType.NVarChar, 100);
            para[0].Value = EmployeeName;

            para[1] = new SqlParameter("@EmployeePhoneNumber", SqlDbType.NVarChar, 20);
            para[1].Value = EmployeePhoneNumber;

            para[2] = new SqlParameter("@EmployeeSalary", SqlDbType.Money);
            para[2].Value = EmployeeSalary;

            para[3] = new SqlParameter("@EmployeePassword", SqlDbType.NVarChar , 20);
            para[3].Value = EmployeePassword;

            para[4] = new SqlParameter("@EmployeeType", SqlDbType.Int);
            para[4].Value = EmployeeType;

            para[5] = new SqlParameter("@EmployeePermission", SqlDbType.Int);
            para[5].Value = EmployeePermission;

            para[6] = new SqlParameter("@EmployeeState", SqlDbType.Int);
            para[6].Value = EmployeeState;

            para[7] = new SqlParameter("@PowerStationID", SqlDbType.Int);
            para[7].Value = PowerStationID;

            con.ExecuteCommands("Add_New_Employee", para);
            con.CloseConnection();

        }


        public DataTable GetEmployeeInformation(int EmployeeID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@EmployeeID", SqlDbType.Int);
            para[0].Value = EmployeeID;

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Get_Employee_Information", para);
            con.CloseConnection();

            return DataTable1;
        }

        public DataTable GetEmployeesWhoWorksinside()
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = con.SelectData("Get_Employees_Who_Works_inside");
            con.CloseConnection();

            return DataTable1;
        }

        public DataTable GetEmployeesWhoWorksOut()
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = con.SelectData("Get_Employees_Who_Works_out");
            con.CloseConnection();

            return DataTable1;
        }

        public DataTable GetActiveEmployees()
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = con.SelectData("Get_Active_Employees");
            con.CloseConnection();

            return DataTable1;
        }

        public DataTable GetInActiveEmployees()
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = con.SelectData("Get_InActive_Employees");
            con.CloseConnection();

            return DataTable1;
        }


        public void UpdateEmployee(int EmployeeID , string EmployeeName, string EmployeePhoneNumber, double EmployeeSalary, string EmployeePassword, int EmployeeType, int EmployeePermission, int EmployeeState, int PowerStationID)
        {

            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[9];

            para[0] = new SqlParameter("@EmployeeID", SqlDbType.NVarChar, 100);
            para[0].Value = EmployeeID;

            para[1] = new SqlParameter("@EmployeeName", SqlDbType.NVarChar, 100);
            para[1].Value = EmployeeName;

            para[2] = new SqlParameter("@EmployeePhoneNumber", SqlDbType.NVarChar, 20);
            para[2].Value = EmployeePhoneNumber;

            para[3] = new SqlParameter("@EmployeeSalary", SqlDbType.Money);
            para[3].Value = EmployeeSalary;

            para[4] = new SqlParameter("@EmployeePassword", SqlDbType.NVarChar, 20);
            para[4].Value = EmployeePassword;

            para[5] = new SqlParameter("@EmployeeType", SqlDbType.Int);
            para[5].Value = EmployeeType;

            para[6] = new SqlParameter("@EmployeePermission", SqlDbType.Int);
            para[6].Value = EmployeePermission;

            para[7] = new SqlParameter("@EmployeeState", SqlDbType.Int);
            para[7].Value = EmployeeState;

            para[8] = new SqlParameter("@PowerStationID", SqlDbType.Int);
            para[8].Value = PowerStationID;

            con.ExecuteCommands("Update_Employee", para);
            con.CloseConnection();

        }
        public void DeleteEmployee(int EmployeeID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@EmployeeID", SqlDbType.Int);
            para[0].Value = EmployeeID;


            con.ExecuteCommands("Delete_Employee", para);
            con.CloseConnection();
        }

        public void UpdateEmployeeTotalCredit(int EmployeeID, double EmployeeTotalCredit)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@EmployeeID", SqlDbType.Int);
            para[0].Value = EmployeeID;

            para[1] = new SqlParameter("@EmployeeTotalCredit", SqlDbType.Money);
            para[1].Value = EmployeeTotalCredit;


            con.ExecuteCommands("Update_Employee_Total_Credit", para);
            con.CloseConnection();
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

        public DataTable GetEmployeeInformationForLogIn(string EmployeePhoneNumber , string EmployeePassword)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@EmployeePhoneNumber", SqlDbType.NVarChar, 20);
            para[0].Value = EmployeePhoneNumber;

            para[1] = new SqlParameter("@EmployeePassword", SqlDbType.NVarChar, 20);
            para[1].Value = EmployeePassword;

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Get_Employee_Information_For_Log_In", para);
            con.CloseConnection();


            return DataTable1;
        }

        public DataTable CheckIfEmployeeisActive(string EmployeePhoneNumber, string EmployeePassword)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@EmployeePhoneNumber", SqlDbType.NVarChar, 20);
            para[0].Value = EmployeePhoneNumber;

            para[1] = new SqlParameter("@EmployeePassword", SqlDbType.NVarChar, 20);
            para[1].Value = EmployeePassword;

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Check_If_Employee_is_Active", para);
            con.CloseConnection();


            return DataTable1;
        }
    }
}

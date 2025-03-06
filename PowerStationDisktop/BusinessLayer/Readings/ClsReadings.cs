using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PowerStationDisktop.BusinessLayer.Readings
{
    class ClsReadings
    {
        public DataTable GetElectronicMeterswhichHaveBeenChoosen()
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Get_ElectronicMeters_which_Have_Been_Choosen");
            con.CloseConnection();

            return DataTable1;
        }

        public DataTable GetPreviousReading(double ElectronicMeterID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@ElectronicMeterID", SqlDbType.Decimal);
            para[0].Value = ElectronicMeterID;

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Get_Previous_Reading",para);
            con.CloseConnection();

            return DataTable1;
        }

        public DataTable GetCustomerTotalDues(double ElectronicMeterID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@ElectronicMeterID", SqlDbType.Decimal);
            para[0].Value = ElectronicMeterID;

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Get_Customer_Total_Dues", para);
            con.CloseConnection();

            return DataTable1;
        }


        public DataTable GetLastPrice()
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Get_Last_Price");
            con.CloseConnection();

            return DataTable1;
        }

        public DataTable SearchForArea(int AreaID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@AreaID", SqlDbType.Int);
            para[0].Value = AreaID;

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Search_For_Area", para);
            con.CloseConnection();

            return DataTable1;
        }

        public DataTable GetAllReadingsForSpecificElectronicMeter(double ElectronicMeterID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@ElectronicMeterID", SqlDbType.Float);
            para[0].Value = ElectronicMeterID;

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Get_All_Readings_For_Specific_Electronic_Meter", para);
            con.CloseConnection();

            return DataTable1;
        }

        public void AddNewReading(double PreviousReading ,double CurrentReading ,DateTime DateOfCurrentReading ,double TotalDuesInThisReading ,double ElectronicMeterID ,int PriceID ,int EmployeeID ,int AreaID )
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[8];

            para[0] = new SqlParameter("@PreviousReading", SqlDbType.Float);
            para[0].Value = PreviousReading;

            para[1] = new SqlParameter("@CurrentReading", SqlDbType.Float);
            para[1].Value = CurrentReading;

            para[2] = new SqlParameter("@DateOfCurrentReading", SqlDbType.Date);
            para[2].Value = DateOfCurrentReading;

            para[3] = new SqlParameter("@TotalDuesInThisReading", SqlDbType.Money);
            para[3].Value = TotalDuesInThisReading;

            para[4] = new SqlParameter("@ElectronicMeterID", SqlDbType.Float);
            para[4].Value = ElectronicMeterID;

            para[5] = new SqlParameter("@PriceID", SqlDbType.Int);
            para[5].Value = PriceID;

            para[6] = new SqlParameter("@EmployeeID", SqlDbType.Int);
            para[6].Value = EmployeeID;

            para[7] = new SqlParameter("@AreaID", SqlDbType.Int);
            para[7].Value = AreaID;

            con.ExecuteCommands("Add_New_Reading", para);
            con.CloseConnection();
        }

        public DataTable GetLastReadingForSpecificElectronicMeter(double ElectronicMeterID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@ElectronicMeterID", SqlDbType.Float);
            para[0].Value = ElectronicMeterID;

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Get_Last_Reading_For_Specific_Electronic_Meter", para);
            con.CloseConnection();

            return DataTable1;
        }
    }
}








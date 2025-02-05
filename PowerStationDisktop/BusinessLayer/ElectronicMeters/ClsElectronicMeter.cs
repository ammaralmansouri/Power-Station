using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PowerStationDisktop.BusinessLayer.ElectronicMeters
{
    class ClsElectronicMeter
    {

        public DataTable GetAllELectronicMeters()
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = new DataTable();
            DataTable1 = con.SelectData("Get_All_ElectronicMeters", null);
            con.CloseConnection();

            return DataTable1;
        }

        public void AddNewElectronicMeter(double ElectronicMeterID  , int ElectronicMeterType , DateTime ElectronicMeterDateOfAdding)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[3];

            para[0] = new SqlParameter("@ElectronicMeterID", SqlDbType.Decimal);
            para[0].Value = ElectronicMeterID;

            para[1] = new SqlParameter("@ElectronicMeterType", SqlDbType.Int);
            para[1].Value = ElectronicMeterType;

            para[2] = new SqlParameter("@ElectronicMeterDateOfAdding", SqlDbType.Date);
            para[2].Value = ElectronicMeterDateOfAdding;

            con.ExecuteCommands("Add_New_ElectronicMeter", para);
            con.CloseConnection();
        }

        public DataTable GetElectronicMeterInformation(double ElectronicMeterID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@ElectronicMeterID", SqlDbType.Decimal);
            para[0].Value = ElectronicMeterID;

            DataTable DataTable1 = new DataTable();
            DataTable1 = con.SelectData("Get_ElectronicMeter_Information", para);
            con.CloseConnection();

            return DataTable1;
        }


        public void DeleteElectronicMeter(double ElectronicMeterID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@ElectronicMeterID", SqlDbType.Decimal);
            para[0].Value = ElectronicMeterID;

            con.ExecuteCommands("Delete_ElectronicMeter", para);
            con.CloseConnection();
        }


       
        
    }
}

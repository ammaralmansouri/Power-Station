using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PowerStationDisktop.BusinessLayer.PowerStation
{
    class ClsPowerStation
    {
        public void AddPowerStation(string PowerStationArabicName,string PowerStationEnglishName , string PowerStationArabicAddress , string PowerStationEnglishAddress , string PowerStationPhoneNumber , string PowerStationEmail ,string PowerStationWebsite ,byte[] PowerStationLogo)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[8];

            para[0] = new SqlParameter("@PowerStationArabicName", SqlDbType.NVarChar , 100);
            para[0].Value = PowerStationArabicName;

            para[1] = new SqlParameter("@PowerStationEnglishName", SqlDbType.NVarChar, 100);
            para[1].Value = PowerStationEnglishName;

            para[2] = new SqlParameter("@PowerStationArabicAddress", SqlDbType.NVarChar , 100);
            para[2].Value = PowerStationArabicAddress;

            para[3] = new SqlParameter("@PowerStationEnglishAddress", SqlDbType.NVarChar , 100);
            para[3].Value = PowerStationEnglishAddress;

            para[4] = new SqlParameter("@PowerStationPhoneNumber", SqlDbType.NVarChar , 15);
            para[4].Value = PowerStationPhoneNumber;

            para[5] = new SqlParameter("@PowerStationEmail", SqlDbType.NVarChar , 100);
            para[5].Value = PowerStationEmail;

            para[6] = new SqlParameter("@PowerStationWebsite", SqlDbType.NVarChar , 100);
            para[6].Value = PowerStationWebsite;

            para[7] = new SqlParameter("@PowerStationLogo", SqlDbType.Image);
            para[7].Value = PowerStationLogo;


            con.ExecuteCommands("Add_PowerStation", para);
            con.CloseConnection();
        }


        public void UpdatePowerStation(int PowerStationID ,string PowerStationArabicName, string PowerStationEnglishName, string PowerStationArabicAddress, string PowerStationEnglishAddress, string PowerStationPhoneNumber, string PowerStationEmail, string PowerStationWebsite, byte[] PowerStationLogo)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[9];

            para[0] = new SqlParameter("@PowerStationID", SqlDbType.Int);
            para[0].Value = PowerStationID;

            para[1] = new SqlParameter("@PowerStationArabicName", SqlDbType.NVarChar, 100);
            para[1].Value = PowerStationArabicName;

            para[2] = new SqlParameter("@PowerStationEnglishName", SqlDbType.NVarChar, 100);
            para[2].Value = PowerStationEnglishName;

            para[3] = new SqlParameter("@PowerStationArabicAddress", SqlDbType.NVarChar, 100);
            para[3].Value = PowerStationArabicAddress;

            para[4] = new SqlParameter("@PowerStationEnglishAddress", SqlDbType.NVarChar, 100);
            para[4].Value = PowerStationEnglishAddress;

            para[5] = new SqlParameter("@PowerStationPhoneNumber", SqlDbType.NVarChar, 15);
            para[5].Value = PowerStationPhoneNumber;

            para[6] = new SqlParameter("@PowerStationEmail", SqlDbType.NVarChar, 100);
            para[6].Value = PowerStationEmail;

            para[7] = new SqlParameter("@PowerStationWebsite", SqlDbType.NVarChar, 100);
            para[7].Value = PowerStationWebsite;

            para[8] = new SqlParameter("@PowerStationLogo", SqlDbType.Image);
            para[8].Value = PowerStationLogo;


            con.ExecuteCommands("Update_PowerStation", para);
            con.CloseConnection();
        }

        public DataTable GetAllPowerStation()
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Get_All_PowerStations", null);
            con.CloseConnection();

            return DataTable1;
        }
    }
}

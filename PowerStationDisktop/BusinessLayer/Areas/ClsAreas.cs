using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PowerStationDisktop.BusinessLayer.Areas
{
    class ClsAreas
    {
        public DataTable GetAllAreas()
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Get_All_Areas");
            con.CloseConnection();

            return DataTable1;
        }

        public DataTable CheckIfThisAreaHasBeenAddedOrNot(String AreaName)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = new DataTable();

            SqlParameter[] Para = new SqlParameter[1];

            Para[0] = new SqlParameter("@AreaName", SqlDbType.NVarChar, 50);
            Para[0].Value = AreaName;

            DataTable1 = con.SelectData("Check_If_This_Area_Has_Been_Added_Or_Not",Para);
            con.CloseConnection();

            return DataTable1;
        }

        public void AddNewArea(string AreaName)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@AreaName", SqlDbType.NVarChar , 50);
            para[0].Value = AreaName;

            con.ExecuteCommands("Add_New_Area", para);
            con.CloseConnection();
        }

        public void DeleteArea(int AreaID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@AreaID", SqlDbType.Int);
            para[0].Value = AreaID;

            con.ExecuteCommands("Delete_Area", para);
            con.CloseConnection();
        }

        public void UpdateArea(int AreaID , string AreaName)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@AreaID", SqlDbType.Int);
            para[0].Value = AreaID;

            para[1] = new SqlParameter("@AreaName", SqlDbType.NVarChar, 50);
            para[1].Value = AreaName;

            con.ExecuteCommands("Update_Area", para);
            con.CloseConnection();
        }
    }
}

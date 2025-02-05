using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PowerStationDisktop.DataAccessLayer
{
    class ClsConnection
    {
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();


        //Constrcuor to intailize connection..

        public ClsConnection()
        {
            //تذكر..عند اسم السيرفر ممكن نكتب اسم السيرفر حقنا..لكن في جهاز العميل بيكون اسم السيرفر مختلف لذلك نكتب
            //.\SQLEXPRESS
            //عندي ما اشتغلش هذا الأمر ..فكتبت عند اسم السيرفر \. 
            //وممكن تكتفي بال . لحالها

            conn = new SqlConnection(@"server=.\;Database=PowerStationDB;Integrated Security=True");
        }


        //Function to open connection..

        public void OpenConnection()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }


        //Function to close connection after doing the thing we want..
        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        //Function to insert, update, delete from Database ( PROCEDURES we have Create in the Database ( Stored Procedures ) )..

        public void ExecuteCommands(string StoredProcedureName, SqlParameter[] Para = null)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = StoredProcedureName;
            cmd.Connection = conn;


            if (Para != null)
            {
                cmd.Parameters.AddRange(Para);
            }

            cmd.ExecuteNonQuery();
        }

        //Function to read (select) data from Database using ( Stored Procedures )..

        public DataTable SelectData(string StoredProcedureName, SqlParameter[] Para = null)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = StoredProcedureName;
            cmd.Connection = conn;

            if (Para != null)
            {
                cmd.Parameters.AddRange(Para);
            }

            SqlDataAdapter SqlDataAdapter1 = new SqlDataAdapter(cmd);
            DataTable DataTable1 = new DataTable();
            DataTable1.Clear();
            SqlDataAdapter1.Fill(DataTable1);

            return DataTable1;
        }
    }
}

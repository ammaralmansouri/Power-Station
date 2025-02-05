using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PowerStationDisktop.BusinessLayer.Pices
{
    class ClsPrices
    {
        public DataTable GetAllPrices()
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Get_All_Prices");
            con.CloseConnection();

            return DataTable1;
        }

        public void AddNewPrice(double PriceOfKilo , int EmployeeUpdatedID)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@PriceOfKilo", SqlDbType.Decimal);
            para[0].Value = PriceOfKilo;

            para[1] = new SqlParameter("@EmployeeUpdatedID", SqlDbType.Int);
            para[1].Value = EmployeeUpdatedID;

            con.ExecuteCommands("Add_New_Price", para);
            con.CloseConnection();
        }
    }

        
}

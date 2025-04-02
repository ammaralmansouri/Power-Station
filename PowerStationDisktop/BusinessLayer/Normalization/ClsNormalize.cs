using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerStationDisktop.BusinessLayer.Normalization
{
    class ClsNormalize
    {

        public void ChangeLettersToStandardLettersToMakeItEasyWhenSearchForEmployee()
        {

            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();


            con.ExecuteCommands("Change_Letters_To_Standard_Letters_To_Make_It_Easy_When_Search_For_Employee");
            con.CloseConnection();
        }

        public void ChangeLettersToStandardLettersToMakeItEasyWhenSearchForCustomer()
        {

            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();


            con.ExecuteCommands("Change_Letters_To_Standard_Letters_To_Make_It_Easy_When_Search_For_Customer");
            con.CloseConnection();
        }

        public void ChangeLettersToStandardLettersToMakeItEasyWhenSearchForArea()
        {

            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();


            con.ExecuteCommands("Change_Letters_To_Standard_Letters_To_Make_It_Easy_When_Search_For_Area");
            con.CloseConnection();
        }
    }
}

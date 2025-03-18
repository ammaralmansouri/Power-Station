using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace PowerStationDisktop.BusinessLayer.SendMassagesInWhatsapp
{
    class ClsSendMassagesInWhatsapp
    {

        public DataTable GetAllCustomerInformationForSendingMessagesInWhatsapp()
        {

            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            DataTable DataTable1 = new DataTable();

            DataTable1 = con.SelectData("Get_All_Customer_Information_For_Sending_Messages_In_Whatsapp", null);
            con.CloseConnection();

            return DataTable1;
        }
    }
}

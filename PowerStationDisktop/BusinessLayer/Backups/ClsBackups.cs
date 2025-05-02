using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PowerStationDisktop.BusinessLayer.Backups
{
    class ClsBackups
    {
        public void CreateBackup(String BackupPath)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@BackupPath", SqlDbType.NVarChar, 255);
            para[0].Value = BackupPath;

            con.ExecuteCommands("Cerate_Backup", para);
            con.CloseConnection();
        }

        public void RestoreBackup(String BackupPath)
        {
            DataAccessLayer.ClsConnection con = new DataAccessLayer.ClsConnection();
            con.OpenConnection();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@BackupPath", SqlDbType.NVarChar, 255);
            para[0].Value = BackupPath;

            con.ExecuteCommands("Restore_Backup", para);
            con.CloseConnection();
        }
    }
}

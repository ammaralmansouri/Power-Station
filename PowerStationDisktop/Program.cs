using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerStationDisktop
{
    static class Program
    {

        public static string EmployeeID;
        public static string EmployeeName;
        public static string EmployeeType;
        public static string EmployeePermission;
        public static string EmployeeState;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // This is to delete  Expired Permissions when the system start ..
            // I have a Schedule in Sql Server Agint for this .. but I also run the prcedure here to make sure ..
            BusinessLayer.Permissions.ClsPermissions permissionss = new BusinessLayer.Permissions.ClsPermissions();
            permissionss.DeleteExpiredPermissions();


            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware(); // السطرين هؤلاء واخر سطرين عشان الدقة .. لاتنسى


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PresentationLayer.Login.frm_Login());
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern bool SetProcessDPIAware();

    }
}

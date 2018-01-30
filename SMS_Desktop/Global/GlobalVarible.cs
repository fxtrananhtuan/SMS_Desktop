using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SMS_Desktop
{
    public class GlobalVarible
    {
        public static string _Account = "";
        public static bool _CheckSignUp = false;
        public static Login _login = new Login();
        public static Main _Main = new Main();
        public static Customer _customers = new Customer();
        public static SignUp _signup = new SignUp();


        ///////////////////////////////////////////////////Customer Form variable ////////////////////////////////////////////
        public static DataTable customerdata = new DataTable();
    }
}

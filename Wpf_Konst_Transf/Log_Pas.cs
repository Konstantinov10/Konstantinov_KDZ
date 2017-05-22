using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Konst_Transf
{
    [Serializable]
   public class Log_Pas
    {
        private string _login;

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

       
        public Log_Pas( string login, string password)
        {
            _login = login;
            _password = password;

        }

    

    }
}

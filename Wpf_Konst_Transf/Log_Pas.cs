using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Konst_Transf
{
    [Serializable]
    class Log_Pas
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
        public Log_Pas(string login, string password)
        {
            _login = login;
            _password = password;

        }
        public static List<Log_Pas> listLP;
       public static BinaryFormatter formatter = new BinaryFormatter();

        public static void LoadData()
        {
           

            using (FileStream fs = new FileStream(@"C: /Users/Иван/Desktop/Wpf_Konst_Transf / base.dat", FileMode.OpenOrCreate))
            {
                try
                {
                    listLP = (List<Log_Pas>)formatter.Deserialize(fs);
                }
                catch
                {
                    listLP = new List<Log_Pas>();
                }
            }
        }

        public static void SaveData()
        {
            using (FileStream fs = new FileStream(@"C: /Users/Иван/Desktop/Wpf_Konst_Transf / base.dat", FileMode.Open))
            {
                formatter.Serialize(fs, listLP);
            }
        }
    }
}  
   
       
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Konst_Transf
{
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

       public static List<Log_Pas>  lppl ;
        public Log_Pas( string login, string password)
        {
            _login = login;
            _password = password;

        }

        public static void loadLPPFrom()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Иван\Desktop\Wpf_Konst_Transf\LPP.txt", Encoding.UTF8);

            lppl = new List<Log_Pas>();
            foreach (string line in lines)
            {
                Char delimiter = ' ';
                String[] substrings = line.Split(delimiter);
                Log_Pas Acc = new Log_Pas(substrings[0], substrings[1]);

                lppl.Add(Acc);
            }


        }


        public string Log_PasasLine()
        {
            string line = null;

            line += _login;
            line += " " + _password;
            return line;
        }

        public static string[] getLPAsLines()
        {
            string[] lines = new string[lppl.Count];
            int id = 0;
            foreach (Log_Pas acc in lppl)
            {
                lines[id++] = acc.Log_PasasLine();
            }
            return lines;
        }

        public static void writeLPToFile()
        {
            System.IO.File.WriteAllLines(@"C:\Users\Иван\Desktop\Wpf_Konst_Transf\LPP.txt", Log_Pas.getLPAsLines(), Encoding.UTF8);
        }



        public static void appendLPPlayerToFile(Log_Pas LP)
        {
            System.IO.File.AppendAllText(@"C:\Users\Иван\Desktop\Wpf_Konst_Transf\LPP.txt", LP.Log_PasasLine() + "\n", Encoding.UTF8);
        }
        

    }
}

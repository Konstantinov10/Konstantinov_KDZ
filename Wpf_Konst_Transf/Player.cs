using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Konst_Transf
{
    public class Player
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _surname;

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        private string _wleg;

        public string Wleg
        {
            get { return _wleg; }
            set { _wleg = value; }
        }
        private string _country;

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private int _rating;

        public int Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }
        private string _team;

        public string Team
        {
            get { return _team; }
            set { _team = value; }
        }

        public static List<Player> players;

        public Player(string name, string surname, string country, int age, string wleg, int rating, string team)
        {
            _name = name;
            _surname = surname;
            _country = country;
            _age = age;
            _wleg = wleg;
            _rating = rating;
            _team = team;
        }
        public static void loadPlayersFrom()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\ikons\Documents\Visual Studio 2015\Projects\Wpf_Konst_Transf\Player.txt", Encoding.UTF8);

            players = new List<Player>();
            foreach (string line in lines)
            {
                Char delimiter = ' ';
                String[] substrings = line.Split(delimiter);
                Player npl = new Player(substrings[0], substrings[1], substrings[2], Convert.ToInt32(substrings[3]), substrings[4], Convert.ToInt32(substrings[5]), substrings[6]);
                players.Add(npl);
            }
        }

        public string asLine()
        {
            string line = null;
            line += _name;
            line += " " + _surname;
            line += " " + _country;
            line += " " + _age;
            line += " " + _wleg;
            line += " " + _rating;
            line += " " + _team;
            return line;
        }

        public static string[] getAsLines()
        {
            string[] lines = new string[players.Count];
            int id = 0;
            foreach (Player player in players)
            {
                lines[id++] = player.asLine();
            }
            return lines;
        }

        public static void writePlayersToFile()
        {
            System.IO.File.WriteAllLines(@"C:\Users\ikons\Documents\Visual Studio 2015\Projects\Wpf_Konst_Transf\Player.txt", Player.getAsLines(), Encoding.UTF8);
        }

        public static void appendPlayerToFile(Player plr)
        {
            System.IO.File.AppendAllText(@"C:\Users\ikons\Documents\Visual Studio 2015\Projects\Wpf_Konst_Transf\PLayer.txt", plr.asLine() + "\n", Encoding.UTF8);
        }

    }

    }


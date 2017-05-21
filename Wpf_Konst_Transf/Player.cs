using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Konst_Transf
{
    [Serializable]
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

        public string PlayerasLine()
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
      

            
        }

    }


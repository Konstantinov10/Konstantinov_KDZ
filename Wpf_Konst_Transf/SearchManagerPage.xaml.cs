using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Konst_Transf
{
    /// <summary>
    /// Логика взаимодействия для SearchManagerPage.xaml
    /// </summary>
    public partial class SearchManagerPage : Page
    {
        List<Player> _players;
        private void LoadData()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("../../player.dat", FileMode.OpenOrCreate))
            {
                try
                {
                    _players = (List<Player>)formatter.Deserialize(fs);
                }
                catch
                {
                    _players = new List<Player>();
                }
            }   }
        public SearchManagerPage()
        {
            InitializeComponent();
        }

         private void RefreshdataGridPlr()
        {
            dataGridPlayers.ItemsSource = null;
            dataGridPlayers.ItemsSource = _players;
        }


        private void buttonLink_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridPlayers.SelectedIndex != -1)
            {

                MessageBox.Show("Offer is successfull!");
            }
        }



        private void buttonAddAll_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
            dataGridPlayers.ItemsSource = _players;
        }



        private void buttonDel_Click(object sender, RoutedEventArgs e)
        {
           if(dataGridPlayers.SelectedIndex != -1)
            {
                _players.RemoveAt(dataGridPlayers.SelectedIndex);
                RefreshdataGridPlr();
            }
        }



       


        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
           
            dataGridPlayers.ItemsSource = null;
        }

        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {

            if (TextBoxSname.Text != "" && TextBoxSsurname.Text == "" && TextBoxScountry.Text == "" && TextBoxS1age.Text == "" && ComboBoxSwleg.Text == "" && TextBoxSteam.Text == "" && textBoxRat.Text == "")
            {
                List<Player> plrs = new List<Player>();
                LoadData();
                foreach (var plr in _players)
                {
                    if (plr.Name == (TextBoxSname.Text))
                    {
                        plrs.Add(plr);
                        dataGridPlayers.ItemsSource = plrs;

                    }
                }

            }


            if (TextBoxSname.Text == "" && TextBoxSsurname.Text != "" && TextBoxScountry.Text == "" && TextBoxS1age.Text == "" && ComboBoxSwleg.Text == "" && TextBoxSteam.Text == "" && textBoxRat.Text == "")
            {
                List<Player> plrs = new List<Player>();
                LoadData();
                foreach (var plr in _players)
                {
                    if (plr.Surname == (TextBoxSsurname.Text))
                    {
                        plrs.Add(plr);
                        dataGridPlayers.ItemsSource = plrs;
                    }
                }

            }



            if (TextBoxSname.Text == "" && TextBoxSsurname.Text == "" && TextBoxScountry.Text != "" && TextBoxS1age.Text == "" && ComboBoxSwleg.Text == "" && TextBoxSteam.Text == "" && textBoxRat.Text == "")
            {
                List<Player> plrs = new List<Player>();
                LoadData();
                foreach (var plr in _players)
                {
                    if (plr.Country == (TextBoxScountry.Text))
                    {
                        plrs.Add(plr);
                        dataGridPlayers.ItemsSource = plrs;
                    }
                }

            }



            if (TextBoxSname.Text == "" && TextBoxSsurname.Text == "" && TextBoxScountry.Text == "" && TextBoxS1age.Text != "" && ComboBoxSwleg.Text == "" && TextBoxSteam.Text == "" && textBoxRat.Text == "")
            {
                List<Player> plrs = new List<Player>();
                LoadData();
                foreach (var plr in _players)
                {
                    if (plr.Age == Convert.ToInt32(TextBoxS1age.Text))
                    {
                        plrs.Add(plr);
                        dataGridPlayers.ItemsSource = plrs;
                    }
                }

            }

            if (TextBoxSname.Text == "" && TextBoxSsurname.Text == "" && TextBoxScountry.Text == "" && TextBoxS1age.Text == "" && ComboBoxSwleg.Text != "" && TextBoxSteam.Text == "" && textBoxRat.Text == "")
            {
                List<Player> plrs = new List<Player>();
                LoadData();
                foreach (var plr in _players)
                {
                    if (plr.Wleg == (ComboBoxSwleg.Text))
                    {
                        plrs.Add(plr);
                        dataGridPlayers.ItemsSource = plrs;
                    }
                }

            }


            if (TextBoxSname.Text == "" && TextBoxSsurname.Text == "" && TextBoxScountry.Text == "" && TextBoxS1age.Text == "" && ComboBoxSwleg.Text == "" && TextBoxSteam.Text != "" && textBoxRat.Text == "")
            {
                List<Player> plrs = new List<Player>();
                LoadData();
                foreach (var plr in _players)
                {
                    if (plr.Team == (TextBoxSteam.Text))
                    {
                        plrs.Add(plr);
                        dataGridPlayers.ItemsSource = plrs;
                    }
                }

            }

            if (TextBoxSname.Text == "" && TextBoxSsurname.Text == "" && TextBoxScountry.Text == "" && TextBoxS1age.Text == "" && ComboBoxSwleg.Text == "" && TextBoxSteam.Text == "" && textBoxRat.Text != "")
            {
                List<Player> plrs = new List<Player>();
                LoadData();
                foreach (var plr in _players)
                {
                    if (plr.Rating == Convert.ToInt32(textBoxRat.Text))
                    {
                        plrs.Add(plr);
                        dataGridPlayers.ItemsSource = plrs;
                    }
                }

            }

        }
    }
}

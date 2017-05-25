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
    /// Логика взаимодействия для PlayerChangePage.xaml
    /// </summary>
    public partial class PlayerChangePage : Page
    {
        public PlayerChangePage()
        {
            InitializeComponent();
            LoadData();
        }


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
            }
        }

        private void SaveData()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("../../player.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, _players);
            }

        }
        List<Player> _players;
        List<Player> playr = new List<Player>();
        private void buttonSaveChange_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridPlayers.ItemsSource == null )
            {
                MessageBox.Show("Please, write your name for search!");
            }


            SaveData();

        }





        private void ButtonShow_Click(object sender, RoutedEventArgs e)
        {
            if ( textBoxPlrChange.Text=="" )
            {
                MessageBox.Show("Please, write your name for search!");
            }
            foreach (var p in _players)
            {
                if (textBoxPlrChange.Text == p.Name)
                {
                    List<Player> players = new List<Player>();
                    players.Add(p);
                    dataGridPlayers.ItemsSource = players;

                    return;
                }
            }
        }
    }
}

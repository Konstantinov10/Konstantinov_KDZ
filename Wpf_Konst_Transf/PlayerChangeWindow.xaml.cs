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
using System.Windows.Shapes;

namespace Wpf_Konst_Transf
{
    /// <summary>
    /// Логика взаимодействия для PlayerChangeWindow.xaml
    /// </summary>
    public partial class PlayerChangeWindow : Window
    {
        public PlayerChangeWindow()
        {
            InitializeComponent();
        }

        List<Player> _players = new List<Player>();

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

        private void buttonSaveChange_Click(object sender, RoutedEventArgs e)
        {
            SaveData();
            DialogResult = true;
        }

        private void textBoxPlrChange_TextChanged(object sender, TextChangedEventArgs e)
        {
            LoadData();
            for (int i = 0; i < _players.Count; i++)
            {
                if (textBoxPlrChange.Text == _players[i].Name)
                {
                    List<Player> players = new List<Player>();
                    players.Add(_players[i]);
                    dataGridPlayers.ItemsSource = players;
                    textBoxPlrChange.Text = "";
                    return;
                }

            }
           
        }
    }
}

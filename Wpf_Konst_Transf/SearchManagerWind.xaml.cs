using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Логика взаимодействия для SearchManagerWind.xaml
    /// </summary>
    public partial class SearchManagerWind : Window
    {
        List<Player> _players = new List<Player>();
        public SearchManagerWind()
        {
            InitializeComponent();
            // Добавляем одного преподавателя по умолчанию
            _players.Add(new Player("Ivan Ivanov", "Russia", 18, "Left", 34, "dicks"));
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            listBoxPlayers.ItemsSource = null;
            listBoxPlayers.ItemsSource = _players;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

}

   
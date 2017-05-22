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
    /// Логика взаимодействия для RegPlayerPage.xaml
    /// </summary>
    public partial class RegPlayerPage : Page
    {
        public RegPlayerPage()
        {
            InitializeComponent();
        }

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

        private void buttonRegP_Click(object sender, RoutedEventArgs e)
        {
            int rating, age;
            if (!int.TryParse(textBoxRating.Text, out rating))
            {
                MessageBox.Show("Некорректное значение рейтинга");
                textBoxRating.Focus();
                return;
            }
            if (rating < 20 || rating > 99)
            {
                MessageBox.Show("Рейтинг должен быть от 20 до 99 включительно");
                textBoxRating.Focus();
                return;
            }
            if (!int.TryParse(textBoxAge.Text, out age))
            {
                MessageBox.Show("Некорректное значение возраста");
                textBoxRating.Focus();
                return;
            }
            if (age < 16 || age > 50)
            {
                MessageBox.Show("возраст должен быть от 16 до 50 включительно");
                textBoxRating.Focus();
                return;
            }
            Player plr = new Player(textBoxName.Text,
                   TextBoxSname.Text,
                  textBoxCountry.Text,
                  int.Parse(textBoxAge.Text),
                  comboBoxWleg.Text,
                   int.Parse(textBoxRating.Text),
                   textBoxTeam.Text);
            _players.Add(plr);
            SaveData();
            MessageBox.Show("Registration passed successfully!");

            
           

        }

        private void buttonPlrChange_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.PlayerChangePage);
        }
    }
}

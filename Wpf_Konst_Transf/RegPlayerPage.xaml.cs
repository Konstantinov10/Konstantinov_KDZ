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

        private void RefreshWindow()
        {
            textBoxName.Text = "";
            TextBoxSname.Text = "";
            textBoxCountry.Text = "";
            textBoxAge.Text = "";
            comboBoxWleg.Text = "";
            textBoxTeam.Text = "";
            textBoxRating.Text = "";
        }

        private void buttonRegP_Click(object sender, RoutedEventArgs e)
            
        {
            LoadData();
            if (textBoxName.Text == "" || TextBoxSname.Text == "" || textBoxCountry.Text == "" || textBoxAge.Text == "" || comboBoxWleg.Text == "" || textBoxTeam.Text == "" || textBoxRating.Text == "")
            {
                MessageBox.Show("Please, write all parameters for registration!");
            }
            int rating;
            if (textBoxRating.Text != "")

            {

                if (!int.TryParse(textBoxRating.Text, out rating))
                {
                    MessageBox.Show("Incorrect rating!");
                    textBoxRating.Focus();
                    return;
                }


                if (rating < 20 || rating > 99)
                {
                    MessageBox.Show("Rating must be from 20 to 99!");
                    textBoxRating.Focus();
                    return;
                }
            }
            int age;
            if (textBoxAge.Text != "")
            {
                if (!int.TryParse(textBoxAge.Text, out age))
                {
                    MessageBox.Show("Incorrect age!");
                    textBoxRating.Focus();
                    return;
                }
                if (age < 16 || age > 50)
                {
                    MessageBox.Show("Age must be from 16 to 50!");
                    textBoxRating.Focus();
                    return;
                }
            }
            if(textBoxName.Text!="" && TextBoxSname.Text!="" && textBoxCountry.Text != "" && textBoxAge.Text != "" && comboBoxWleg.Text != "" && textBoxTeam.Text != "" && textBoxRating.Text != "") { 
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
                RefreshWindow();
            }
           

        }

        private void buttonPlrChange_Click(object sender, RoutedEventArgs e)
        {
            RefreshWindow();
            NavigationService.Navigate(Pages.PlayerChangePage);
        }
    }
}

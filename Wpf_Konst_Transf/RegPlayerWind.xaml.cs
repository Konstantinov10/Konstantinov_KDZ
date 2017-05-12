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
    /// Логика взаимодействия для RegPlayerWind.xaml
    /// </summary>
    public partial class RegPlayerWind : Window
    {
        public RegPlayerWind()
        {
            InitializeComponent();
           

            Player.writePlayersToFile();

        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
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
            Player npl = new Player(textBoxname.Text, TextBoxsname.Text, TextBoxcountry.Text, Convert.ToInt32(textBoxAge.Text), comboBoxWleg.Text, Convert.ToInt32(textBoxRating.Text), textBoxTeam.Text);
            Player.players.Add(npl);
            Player.appendPlayerToFile(npl);
          
            // Close current window
            DialogResult = true;
          
        }

        private void comboBoxWleg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBoxsname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

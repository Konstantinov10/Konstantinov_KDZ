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
        }
        Player _newPlayer;

        public Player NewPLayer
        {
            get
            {
                return _newPlayer;
            }
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
            _newPlayer = new Player(textBoxFio.Text,comboBoxCountry.Text,age,comboBoxWleg.Text,rating,textBoxTeam.Text);
            // Close current window
            DialogResult = true;
        }
    }
}

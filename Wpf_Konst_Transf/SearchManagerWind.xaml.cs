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
      
        

        public SearchManagerWind()
        {
           
            InitializeComponent();
            Player.loadPlayersFrom();
           
            foreach (string line in Player.getAsLines())
            {
                    listBoxPlayers.Items.Add(line);
                
            }
        }

        private void RefreshListBox()
        {
            listBoxPlayers.ItemsSource = null;
            listBoxPlayers.ItemsSource = Player.players;
        }

      
        


        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }
       
      

        private void TextBoxSname_TextChanged(object sender, TextChangedEventArgs e)
        {
            listBoxPlayers.Items.Clear();

            Player.loadPlayersFrom();
            foreach (string line in Player.getAsLines())
            {
               
                String[] word = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (word[0] == TextBoxSname.Text )
                {
                   
                    listBoxPlayers.Items.Add(line);
                }
                else if (string.IsNullOrWhiteSpace(TextBoxSname.Text))
                {
                    listBoxPlayers.Items.Add(line);
                }
                

          }
            
        }

        private void TextBoxSsurname_TextChanged(object sender, TextChangedEventArgs e)
        {
            listBoxPlayers.Items.Clear();

            Player.loadPlayersFrom();
            foreach (string line in Player.getAsLines())
            {

                String[] word = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (word[1] == TextBoxSsurname.Text)
                {

                    listBoxPlayers.Items.Add(line);
                }
                else if (string.IsNullOrWhiteSpace(TextBoxSsurname.Text)& string.IsNullOrWhiteSpace(TextBoxSname.Text))
                {
                    listBoxPlayers.Items.Add(line);
                }


            }
        }

        private void TextBoxScountry_TextChanged(object sender, TextChangedEventArgs e)
        {
            listBoxPlayers.Items.Clear();

            Player.loadPlayersFrom();
            foreach (string line in Player.getAsLines())
            {

                String[] word = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (word[2] == TextBoxScountry.Text)
                {

                    listBoxPlayers.Items.Add(line);
                }
                else if (string.IsNullOrWhiteSpace(TextBoxScountry.Text) & string.IsNullOrWhiteSpace(TextBoxSname.Text) & string.IsNullOrWhiteSpace(TextBoxSsurname.Text))
                {
                    listBoxPlayers.Items.Add(line);
                }


            }
        }

        private void TextBoxS1age_TextChanged(object sender, TextChangedEventArgs e)
        {

            listBoxPlayers.Items.Clear();

            Player.loadPlayersFrom();
            foreach (string line in Player.getAsLines())
            {

                String[] word = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (word[3] == TextBoxS1age.Text)
                {

                    listBoxPlayers.Items.Add(line);
                }
                else if (string.IsNullOrWhiteSpace(TextBoxScountry.Text) & string.IsNullOrWhiteSpace(TextBoxSname.Text) & string.IsNullOrWhiteSpace(TextBoxSsurname.Text)& string.IsNullOrWhiteSpace(TextBoxS1age.Text))
                {
                    listBoxPlayers.Items.Add(line);
                }


            }


        }

        private void ComboBoxSwleg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listBoxPlayers.Items.Clear();

            Player.loadPlayersFrom();
            foreach (string line in Player.getAsLines())
            {

                String[] word = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (word[4] != ComboBoxSwleg.Text  )
                {

                    listBoxPlayers.Items.Add(line);
                }
                else if (string.IsNullOrWhiteSpace(TextBoxScountry.Text) & string.IsNullOrWhiteSpace(TextBoxSname.Text) & string.IsNullOrWhiteSpace(TextBoxSsurname.Text) & string.IsNullOrWhiteSpace(TextBoxS1age.Text) & string.IsNullOrWhiteSpace(ComboBoxSwleg.Text))
                {
                    listBoxPlayers.Items.Add(line);
                }


            }
        }

        private void textBoxValR_TextChanged(object sender, TextChangedEventArgs e)
        {
            listBoxPlayers.Items.Clear();

            Player.loadPlayersFrom();
            foreach (string line in Player.getAsLines())
            {

                String[] word = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (word[5] == textBoxRat.Text)
                {

                    listBoxPlayers.Items.Add(line);
                }
                else if (string.IsNullOrWhiteSpace(TextBoxScountry.Text) & string.IsNullOrWhiteSpace(TextBoxSname.Text) & string.IsNullOrWhiteSpace(TextBoxSsurname.Text) & string.IsNullOrWhiteSpace(TextBoxS1age.Text) & string.IsNullOrWhiteSpace(textBoxRat.Text))
                {
                    listBoxPlayers.Items.Add(line);
                }


            }
        }

        private void TextBoxSteam_TextChanged(object sender, TextChangedEventArgs e)
        {
            listBoxPlayers.Items.Clear();

            Player.loadPlayersFrom();
            foreach (string line in Player.getAsLines())
            {

                String[] word = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (word[6] == TextBoxSteam.Text)
                {

                    listBoxPlayers.Items.Add(line);
                }
                else if (string.IsNullOrWhiteSpace(TextBoxScountry.Text) & string.IsNullOrWhiteSpace(TextBoxSname.Text) & string.IsNullOrWhiteSpace(TextBoxSsurname.Text) & string.IsNullOrWhiteSpace(TextBoxS1age.Text) & string.IsNullOrWhiteSpace(textBoxRat.Text) & string.IsNullOrWhiteSpace(TextBoxSteam.Text))
                {
                    listBoxPlayers.Items.Add(line);
                }
            }
            }
        }
    }



   
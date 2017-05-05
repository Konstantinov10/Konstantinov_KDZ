﻿using System;
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

       


private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }
    }

}

   
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
    /// Логика взаимодействия для StartNavWindow.xaml
    /// </summary>
    public partial class StartNavWindow : Window
    {
        public StartNavWindow()
        {
            InitializeComponent();
            frameMain.Navigate(new MainPage());
        }
    }
}

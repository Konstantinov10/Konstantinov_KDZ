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
    /// Логика взаимодействия для StartPlayerWind.xaml
    /// </summary>
    public partial class StartPlayerWind : Window
    {
        public StartPlayerWind()
        {
            InitializeComponent();
            textBoxPLog.GotFocus += TextBoxPLog_GotFocus;
            textBoxPLog.LostFocus += TextBoxPLog_LostFocus;
            textBoxPpassw.GotFocus += TextBoxPpassw_GotFocus;
            textBoxPpassw.LostFocus+=TextBoxPpassw_LostFocus;
        }
        bool _loginEntered = false;
        bool _loginEntered2 = false;
        private void TextBoxPLog_GotFocus(object sender, EventArgs e)
        {
            if (!_loginEntered)
            {
                textBoxPLog.Text = "";
                textBoxPLog.Foreground = new SolidColorBrush(Colors.Black);
            }
        }
        private void TextBoxPLog_LostFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxPLog.Text))
                _loginEntered = true;
            else
            {
                textBoxPLog.Text = "Login";
                _loginEntered = false;
                textBoxPLog.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void textBoxPLog_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxPpassw_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!_loginEntered2)
            {
                textBoxPpassw.Text = "";
                textBoxPpassw.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void TextBoxPpassw_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxPpassw.Text))
                _loginEntered2 = true;
            else
            {
                textBoxPpassw.Text = "Password";
                _loginEntered2 = false;
                textBoxPLog.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void textBoxPpassw_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBoxPLog_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new RegPlayerWind();
            window.ShowDialog();
        }
    } 
}

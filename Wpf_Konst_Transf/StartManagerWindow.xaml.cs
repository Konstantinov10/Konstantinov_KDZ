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
    /// Логика взаимодействия для StartManagerWindow.xaml
    /// </summary>
    public partial class StartManagerWindow : Window
    {
        public StartManagerWindow()
        {
            InitializeComponent();
            textBoxMLog.GotFocus += TextBoxMLog_GotFocus;
            textBoxMLog.LostFocus += TextBoxMLog_LostFocus;
            textBoxMpassw.GotFocus += TextBoxMpassw_GotFocus;
            textBoxMpassw.LostFocus += TextBoxMpassw_LostFocus;
        }
        bool _loginEntered = false;
        bool _loginEntered2 = false;
        private void TextBoxMLog_GotFocus(object sender, EventArgs e)
        {
            if (!_loginEntered)
            {
                textBoxMLog.Text = "";
                textBoxMLog.Foreground = new SolidColorBrush(Colors.Black);
            }
        }
            private void TextBoxMLog_LostFocus(object sender, EventArgs e)
            {
                if (!string.IsNullOrWhiteSpace(textBoxMLog.Text))
                    _loginEntered = true;
                else
                {
                    textBoxMLog.Text = "Login";
                    _loginEntered = false;
                    textBoxMLog.Foreground = new SolidColorBrush(Colors.Gray);
                }
            }
            private void textBoxMLog_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void TextBoxMpassw_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!_loginEntered2)
            {
                textBoxMpassw.Text = "";
                textBoxMpassw.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void TextBoxMpassw_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxMpassw.Text))
                _loginEntered2 = true;
            else
            {
                textBoxMpassw.Text = "Password";
                _loginEntered2 = false;
                textBoxMLog.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void buttonMstart_Click(object sender, RoutedEventArgs e)
        {
            var window = new SearchManagerWind();
            window.ShowDialog();
        }
    }
}

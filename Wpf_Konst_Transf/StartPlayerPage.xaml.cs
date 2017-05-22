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
    /// Логика взаимодействия для StartPlayerPage.xaml
    /// </summary>
    public partial class StartPlayerPage : Page
    {
        public StartPlayerPage()
        {
            InitializeComponent();
            textBoxPLog.GotFocus += TextBoxPLog_GotFocus;
            textBoxPLog.LostFocus += TextBoxPLog_LostFocus;
            textBoxPpassw.GotFocus += TextBoxPpassw_GotFocus;
            textBoxPpassw.LostFocus += TextBoxPpassw_LostFocus;
        }
        List<Log_Pas> log_pas = new List<Log_Pas>();



        private void SaveData2()
        {
            BinaryFormatter formatter1 = new BinaryFormatter();
            using (FileStream fs1 = new FileStream("../../log_pas_player.dat", FileMode.OpenOrCreate))
            {
                formatter1.Serialize(fs1, log_pas);
            }
        }

        private void LoadData2()
        {

            BinaryFormatter formatter1 = new BinaryFormatter();
            using (FileStream fs1 = new FileStream("../../log_pas_player.dat", FileMode.OpenOrCreate))
            {
                try
                {
                    log_pas = (List<Log_Pas>)formatter1.Deserialize(fs1);
                }
                catch
                {
                    log_pas = new List<Log_Pas>();
                }
            }
        }
        private void RefreshWindow()
        {
            textBoxPLog.Text = "";
            textBoxPpassw.Text = "";
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






        private void buttonReg_Click(object sender, RoutedEventArgs e)
        {
            LoadData2();

            if (textBoxPLog.Text == "Login" || textBoxPpassw.Text == "Password")
            {
                MessageBox.Show("For registration please write your Login and Password!");
                return;
            }
            else
            {
                if (textBoxPLog.Text != "" && textBoxPpassw.Text != "")
                {

                    foreach (Log_Pas lp in log_pas)
                    {
                        if (textBoxPLog.Text != lp.Login && textBoxPpassw.Text != lp.Password)
                        {

                            Log_Pas pl = new Log_Pas(textBoxPLog.Text, textBoxPpassw.Text);
                            log_pas.Add(pl);
                            RefreshWindow();
                            MessageBox.Show("Registration passed successfully!");
                            SaveData2();
                            return;

                        }

                    }
                }
                else
                {
                    if (textBoxPLog.Text != "" && textBoxPpassw.Text != "")
                    {
                        foreach (Log_Pas lp in log_pas)
                        {
                            if (textBoxPLog.Text == lp.Login)
                            {
                                RefreshWindow();
                                MessageBox.Show("This Login is busy!");
                                return;
                            }
                        }
                    }
                }
            }
        }

        private void buttonPstart_Click(object sender, RoutedEventArgs e)
        {


            LoadData2();
            List<Log_Pas> l = new List<Log_Pas>();

            if (textBoxPLog.Text != "" && textBoxPpassw.Text != "")
            {

                foreach (Log_Pas lp in log_pas)
                {

                    if (textBoxPLog.Text == lp.Login && textBoxPpassw.Text == lp.Password)
                    {
                        NavigationService.Navigate(Pages.RegPLayerPage);
                        l.Add(lp);
                        return;

                    }

                }
            }
            else if (textBoxPLog.Text == "" || textBoxPpassw.Text == "")
            {
                MessageBox.Show("If you've registrated, please,write your Login and Password for Log In!");
                RefreshWindow();
                return;
            }
            else if (l.Count == 0)
            {
                MessageBox.Show("If you've registrated, please,write your Login and Password for Log In!");
                RefreshWindow();
                return;
            }


        }
    }

}

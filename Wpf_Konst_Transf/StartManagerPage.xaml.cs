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
    /// Логика взаимодействия для StartManagerPage.xaml
    /// </summary>
    public partial class StartManagerPage : Page
    {
        public StartManagerPage()
        {
            InitializeComponent();

            InitializeComponent();
            textBoxMLog.GotFocus += TextBoxMLog_GotFocus;
            textBoxMLog.LostFocus += TextBoxMLog_LostFocus;
            textBoxMpassw.GotFocus += TextBoxMpassw_GotFocus;
            textBoxMpassw.LostFocus += TextBoxMpassw_LostFocus;
        }

        List<Log_Pas> log_pas = new List<Log_Pas>();



        private void SaveData1()
        {
            BinaryFormatter formatter1 = new BinaryFormatter();
            using (FileStream fs1 = new FileStream("../../log_pas_manager.dat", FileMode.OpenOrCreate))
            {
                formatter1.Serialize(fs1, log_pas);
            }
        }

        private void LoadData1()
        {
            BinaryFormatter formatter1 = new BinaryFormatter();
            using (FileStream fs1 = new FileStream("../../log_pas_manager.dat", FileMode.OpenOrCreate))
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
            textBoxMLog.Text = "Login";
            textBoxMpassw.Text = "Password";
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

            LoadData1();
            List<Log_Pas> l = new List<Log_Pas>();

            if (textBoxMLog.Text != "" && textBoxMpassw.Text != "")
            {

                foreach (Log_Pas lp in log_pas)
                {
                    if (textBoxMLog.Text == "Login" && textBoxMpassw.Text == "Password")
                    {
                        MessageBox.Show("If you've registrated, please,write your Login and Password for Log In!");
                        RefreshWindow();
                        return;
                    }
                    if (textBoxMLog.Text == lp.Login && textBoxMpassw.Text == lp.Password)
                    {
                        RefreshWindow();
                        NavigationService.Navigate(Pages.SearchManagerPage);
                        l.Add(lp);
                        return;

                    }

                }
            }
        }
          


        

        private void buttonRegMgr_Click(object sender, RoutedEventArgs e)
        {
            LoadData1();

            if ((textBoxMLog.Text == "Login" || textBoxMpassw.Text == "Password")|| (textBoxMLog.Text == "" || textBoxMpassw.Text == ""))
            {
                MessageBox.Show("For registration please write your Login and Password!");
                return;
            }
            
                if (textBoxMLog.Text != "" && textBoxMpassw.Text != "")
                {

                foreach (Log_Pas lp in log_pas)
                {

                    if (textBoxMLog.Text == lp.Login)
                    {

                        MessageBox.Show("This Login is busy!");
                        return;
                    }

                }
                                Log_Pas manager = new Log_Pas(textBoxMLog.Text, textBoxMpassw.Text);
                                log_pas.Add(manager);
                                RefreshWindow();
                                MessageBox.Show("Registration passed successfully!");
                                SaveData1();
                                return;

                            }

                        }
                     }
              
                    }
                
            
        
    



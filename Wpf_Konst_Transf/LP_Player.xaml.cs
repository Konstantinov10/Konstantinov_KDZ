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
    /// Логика взаимодействия для LP_Player.xaml
    /// </summary>
    public partial class LP_Player : Window
    {
        public LP_Player()
        {
            InitializeComponent();

            Log_Pas.loadLPPFrom();
            Log_Pas.writeLPToFile();
        }

        private void buttonRegAcc_Click(object sender, RoutedEventArgs e)
        {
            
            Log_Pas Acc = new Log_Pas(textBoxRegLog.Text, textBoxRegPas.Text);
            Log_Pas.lppl.Add(Acc);
            Log_Pas.appendLPPlayerToFile(Acc);

            DialogResult = true;
           
        }
    }
}

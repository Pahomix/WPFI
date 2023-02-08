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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticalWorkI
{
    public partial class MainWindow : Window
    {
        public int i = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BHL_Click(object sender, RoutedEventArgs e)
        {
            BHL.Content = "x";
        }

        private void BHR_Click(object sender, RoutedEventArgs e)
        {
            BHR.Content = "x";
        }

        private void BML_Click(object sender, RoutedEventArgs e)
        {
            BML.Content = "x";
        }

        private void BMC_Click(object sender, RoutedEventArgs e)
        {
            BMC.Content = "x";
        }

        private void BMR_Click(object sender, RoutedEventArgs e)
        {
            BMR.Content = "x";
        }

        private void BDL_Click(object sender, RoutedEventArgs e)
        {
            BDL.Content = "x";
        }

        private void BDM_Click(object sender, RoutedEventArgs e)
        {
            BDM.Content = "x";
        }

        private void BDR_Click(object sender, RoutedEventArgs e)
        {
            BDR.Content = "x";
        }

        private void BHC_Click(object sender, RoutedEventArgs e)
        {
            BHC.Content = "x"; 
        }
    }
}

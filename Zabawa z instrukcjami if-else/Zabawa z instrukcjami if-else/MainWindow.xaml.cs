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

namespace Zabawa_z_instrukcjami_if_else
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void changeText_Click(object sender, RoutedEventArgs e)
        {

            if (enableCheckbox.IsChecked == true)
            {
                if (labelToChange.Text == "Z prawej")
                {
                    labelToChange.Text = "Z lewej";
                    labelToChange.HorizontalAlignment = HorizontalAlignment.Left;
                }
                else
                {
                    labelToChange.Text = "Z prawej";
                    labelToChange.HorizontalAlignment = HorizontalAlignment.Right;
                }
            }
            else
            {
                labelToChange.Text = "Mozliwość zmiany tekstu została wyłączona ";
                labelToChange.HorizontalAlignment = HorizontalAlignment.Center;
            }
        }
    }
}

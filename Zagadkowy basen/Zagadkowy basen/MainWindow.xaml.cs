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

namespace Zagadkowy_basen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int x = 0;
            string poem = "";

            while (x < 1)
            {
                poem = poem + "a";
                if ( x < 1 )
                {
                    poem = poem + "noise";
                }
                x = x + 2;
                if (x > 0)
                {
                    poem = poem + "annoys";
                    x = x - 1;
                }
                if ( x == 1)
                {
                    poem = poem + "an";
                }
                if (x < 4)
                {
                    poem = poem + " oyster";
                }

            }
            output.Text = poem;
        }
    }
}

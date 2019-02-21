using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appka1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Drzwi Drzwi;
        
        
        

        private void WyswietlButton_Click(object sender, EventArgs e)
        {
            int index = (int)numerDrzwiNumeric.Value;
            

            //numerDrzwiNumeric.Text = wyswietl()(ToString);

            // string wynik = (Drzwi.wyswietl());

            //wyswietlDrzwiLabel.Text = Drzwi.wyswietl()

            //foreach (Drzwi indeks in door)
            //{
            //    wyswietlDrzwiLabel.Text = door.ToString();
            //}
        }

        private void wyswietlDrzwiLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

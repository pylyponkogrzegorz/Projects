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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        public Drzwi Drzwi = null;

        private void DodajButton_Click(object sender, EventArgs e)
        {
            //int index = 0;

            string kolor = kolorTextBox.Text;
            string material = materialTextBox.Text;
            string typ = typTextBox.Text;

            //door1.dodaj(kolor, material, typ);
            Drzwi = new Drzwi(kolor, material, typ);
            //Drzwi.door.Add(new Drzwi(kolor, material, typ));

            //index++;

            DialogResult = DialogResult.OK;
            //Close();
        }
    }
}

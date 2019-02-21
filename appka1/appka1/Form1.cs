using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace appka1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Form2 secondForm;
        //Form3 thirdForm;
        
        public List<Drzwi> door = new List<Drzwi>();

        //string ktoreDrzwi =  

        public void wyswietl()
        {
            foreach (var door in door)
            {
                string wyswietl = Convert.ToString(door.wyswietl());
            }
        }

        private void DodajDrzwiButton_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            using (var dodawanie = new Form2())
            {
                var wynikDodawania = dodawanie.ShowDialog();

                if (wynikDodawania == DialogResult.OK)
                {
                    door.Add(dodawanie.Drzwi);
                }
            }
            this.Visible = true;
            //Array.cop

            //Drzwi[] tablica = new Drzwi[10];

            //tablica[tablica.Length] = 

            //if (secondForm == null)
            //{
            //    secondForm = new Form2();
            //}
            //secondForm.Show();
        }

        private void WyswietlDrzwiButton_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            
            using (var wyswietlanie = new Form3())
            {
                var wynikWyswietlania = wyswietlanie.ShowDialog();

                if (wynikWyswietlania == DialogResult.OK)
                {
                    foreach (Drzwi Drzwi in door)
                    {
                        //WyswietlDrzwiLabel.Text = Drzwi;
                    }
                    //door.ForEach(Form3.wyswietlDrzwiLabel.Drzwi);
                    //return door.ForEach();
                    //int i = 0;
                    //foreach (Drzwi index in door)
                    //{
                    //    string wysw = door.ForEach(i);
                    //}
                    
                }
            }
            this.Visible = true;
        }


        //if (thirdForm == null)
        //{
        //    thirdForm = new Form3();
        //}
        //thirdForm.Show();


        private void ZamknijButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


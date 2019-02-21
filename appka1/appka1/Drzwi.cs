using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appka1
{
    public class Drzwi : Form1
    {
        public string kolor, material, typ;

        public Drzwi (string kolor, string material, string typ)
        {
            this.kolor = kolor;
            this.material = material;
            this.typ = typ;
        }

        public void dodaj(string nkolor, string nmaterial, string ntyp)
        {
            kolor = nkolor;
            material = nmaterial;
            typ = ntyp;
        }

        public void wyswietl()
        {
            //string wyswietlenie = "Kolor: " + kolor + "\nMateriał: " + material + "\nTyp: " + typ;
            string wyswietlenie = "Kolor: " + kolor + "\nMateriał: " + material + "\nTyp: " + typ; 
        }

    }
}

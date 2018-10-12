using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(liczba1.Text);
            double y = Convert.ToDouble(liczba2.Text);

            double wynikDzialania = x + y;

            wynik.Text = wynikDzialania.ToString();
        }

        private void odejmij_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(liczba1.Text);
            double y = Convert.ToDouble(liczba2.Text);

            double wynikDzialania = x - y;

            wynik.Text = wynikDzialania.ToString();
        }

        private void pomnoz_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(liczba1.Text);
            double y = Convert.ToDouble(liczba2.Text);

            double wynikDzialania = x * y;

            wynik.Text = wynikDzialania.ToString();
        }

        private void podziel_Click(object sender, EventArgs e)
        {

            double x = Convert.ToDouble(liczba1.Text);
            double y = Convert.ToDouble(liczba2.Text);

            if (y == 0) {
                wynik.Text = "Nie mozna dzielic przez zero";}
            else { 
             double wynikDzialania = x / y;

            wynik.Text = wynikDzialania.ToString();
            }
        }

        private void wyczysc_Click(object sender, EventArgs e)
        {
            liczba1.Text = "";
            liczba2.Text = "";
            wynik.Text = "";
        }
    }
}

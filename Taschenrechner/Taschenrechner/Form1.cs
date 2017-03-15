using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Taschenrechner : Form
    {
        public Taschenrechner()
        {
            InitializeComponent();  
        }

        int variable1;
        int variable2;
        int ergebnis;



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Ergebnislabel.Text = Ergebnislabel.Text + "8";
        }

        private void Ergebnislabel_Click(object sender, EventArgs e)
        {

        }

        private void zahl1Button_Click(object sender, EventArgs e)
        {
            Ergebnislabel.Text = Ergebnislabel.Text + "1";
        }

        private void zahl2Button_Click(object sender, EventArgs e)
        {
            Ergebnislabel.Text = Ergebnislabel.Text + "2";
        }

        private void zahl3Button_Click(object sender, EventArgs e)
        {
            Ergebnislabel.Text = Ergebnislabel.Text + "3";
        }

        private void zahl4Button_Click(object sender, EventArgs e)
        {
            Ergebnislabel.Text = Ergebnislabel.Text + "4";
        }

        private void zahl5Button_Click(object sender, EventArgs e)
        {
            Ergebnislabel.Text = Ergebnislabel.Text + "5";
        }

        private void zahl6Button_Click(object sender, EventArgs e)
        {
            Ergebnislabel.Text = Ergebnislabel.Text + "6";
        }

        private void zahl7Button_Click(object sender, EventArgs e)
        {
            Ergebnislabel.Text = Ergebnislabel.Text + "7";
        }

        private void zahl9Button_Click(object sender, EventArgs e)
        {
            Ergebnislabel.Text = Ergebnislabel.Text + "9";
        }

        private void zahl0Button_Click(object sender, EventArgs e)
        {

            //if (Ergebnislabel.Text = "0")
            //{
            //    MessageBox.Show("Fehler bei der Eingabe");

            //}

            Ergebnislabel.Text = Ergebnislabel.Text + "0";
        }

        private void löschenButton_Click(object sender, EventArgs e)
        {
            string Leerfeld = " ";
            Ergebnislabel.Text = Leerfeld;
        }

        private void zahlAddierenButton_Click(object sender, EventArgs e)
        {
            variable1 = Convert.ToInt32(Ergebnislabel.Text);
            Ergebnislabel.Text = "";
            //Rechnen rechnenAdd = new Rechnen();
            //rechnenAdd.Addieren(1,1);
           
        }

        private void zahlSubtrahierenButton_Click(object sender, EventArgs e)
        {
            //Rechnen RechnenSub = new Rechnen();
            //RechnenSub.Subtrahieren();
        }

        private void zahlMultiplizierenButton_Click(object sender, EventArgs e)
        {
            //Rechnen RechnenMul = new Rechnen();
            //RechnenMul.Multiplizieren();
        }

        private void zahlDividierenButton_Click(object sender, EventArgs e)
        {
            //Rechnen RechnenDiv = new Rechnen();
            //RechnenDiv.Dividieren();
        }

        private void ergebnisButton_Click(object sender, EventArgs e)
        {
            variable2 = Convert.ToInt32(Ergebnislabel.Text);
            Addieren(); // Bool abfrage ja/nein
            Ergebnislabel.Text = "";
            Ergebnislabel.Text = Convert.ToString(ergebnis);
            //Rechnen RechnenErg = new Rechnen();

            //int result = RechnenErg.Ergebnisübergabe(1,2);

            //string resultS = Convert.ToString(result);

            //Ergebnislabel.Text = resultS;  
        }

        public void Addieren()
        {

            ergebnis = variable1 + variable2;
        }

        public void Subtrahieren()
        {
            ergebnis = variable1 - variable2;
        }

        public void Multiplizieren()
        {
            ergebnis = variable1 * variable2;
        }

        public void Dividieren()
        {
            ergebnis = variable1 / variable2;
        }

        public int Ergebnisübergabe()
        {
            
            return ergebnis;
        }


    }
}

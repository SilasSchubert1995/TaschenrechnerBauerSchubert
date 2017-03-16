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
        double zahl1;
        double zahl2;
        double ergebnis;
        bool rechnenAdd = false;
        bool rechnenSub = false;
        bool rechnenMul = false;
        bool rechnenDiv = false;

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
            
        }

        private void zahlAddierenButton_Click(object sender, EventArgs e)
        {
            zahl1 = Convert.ToDouble(Ergebnislabel.Text);
            Ergebnislabel.Text = "";
            rechnenAdd = true;

        }

        private void zahlSubtrahierenButton_Click(object sender, EventArgs e)
        {
            zahl1 = Convert.ToDouble(Ergebnislabel.Text);
            Ergebnislabel.Text = "";
            rechnenSub = true;
        }

        private void zahlMultiplizierenButton_Click(object sender, EventArgs e)
        {
            zahl1 = Convert.ToDouble(Ergebnislabel.Text);
            Ergebnislabel.Text = "";
            rechnenMul = true;
        }

        private void zahlDividierenButton_Click(object sender, EventArgs e)
        {
            zahl1 = Convert.ToDouble(Ergebnislabel.Text);
            Ergebnislabel.Text = "";
            rechnenDiv = true;
        }

        private void ergebnisButton_Click(object sender, EventArgs e)
        {
            zahl2 = Convert.ToDouble(Ergebnislabel.Text);
            if (rechnenAdd == true)
            {
                Addieren();
            }
            if (rechnenSub == true)
            {
                Subtrahieren();
            }
            if (rechnenMul == true)
            {
                Multiplizieren();
            }
            if (rechnenDiv == true)
            {
                Dividieren();
            }
            Ergebnislabel.Text = "";
            Ergebnislabel.Text = Convert.ToString(ergebnis);
        }

        public void Addieren()
        {

            ergebnis = zahl1 + zahl2;
        }

        public void Subtrahieren()
        {
            ergebnis = zahl1 - zahl2;
        }

        public void Multiplizieren()
        {
            ergebnis = zahl1 * zahl2;
        }

        public void Dividieren()
        {
            ergebnis = zahl1 / zahl2;
        }

        public double Ergebnisübergabe()
        {
            
            return ergebnis;
        }

        private void kommaButton_Click(object sender, EventArgs e)
        {
            Ergebnislabel.Text = Ergebnislabel.Text + ",";
        }
    }
}

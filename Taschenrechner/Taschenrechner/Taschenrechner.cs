using System;
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
        string entfernenZahl;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)              // Zahleingabe per Button
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
            Ergebnislabel.Text = Ergebnislabel.Text + "0";
        }

        private void löschenButton_Click(object sender, EventArgs e)        // Löschbutton (eine Zahl)
        {
            entfernenZahl = Ergebnislabel.Text;
            Ergebnislabel.Text = entfernenZahl.Remove(entfernenZahl.Length - 1, 1);
        }

        private void zahlAddierenButton_Click(object sender, EventArgs e)   // Addierbutton
        {
            zahl1 = Convert.ToDouble(Ergebnislabel.Text);
            Ergebnislabel.Text = "";
            rechnenAdd = true;
        }

        private void zahlSubtrahierenButton_Click(object sender, EventArgs e)   // Subtrahierbutton
        {
            zahl1 = Convert.ToDouble(Ergebnislabel.Text);
            Ergebnislabel.Text = "";
            rechnenSub = true;
        }

        private void zahlMultiplizierenButton_Click(object sender, EventArgs e)     // Multiplizierbutton
        {
            zahl1 = Convert.ToDouble(Ergebnislabel.Text);
            Ergebnislabel.Text = "";
            rechnenMul = true;
        }

        private void zahlDividierenButton_Click(object sender, EventArgs e)     // Dividierbutton
        {
            zahl1 = Convert.ToDouble(Ergebnislabel.Text);
            Ergebnislabel.Text = "";
            rechnenDiv = true;
        }

        private void ergebnisButton_Click(object sender, EventArgs e)           // Ergbenisbutton, Ausgabe im Ergebnislabel
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

        public void Addieren()              // Methode zum Addieren
        {
            ergebnis = zahl1 + zahl2;
        }

        public void Subtrahieren()              // Methode zum Subtrahieren
        {
            ergebnis = zahl1 - zahl2;
        }

        public void Multiplizieren()              // Methode zum Multiplizieren
        {
            ergebnis = zahl1 * zahl2;
        }

        public void Dividieren()              // Methode zum Dividieren
        {
            ergebnis = zahl1 / zahl2;
        }

        public double Ergebnisübergabe()        // Ergebnisübergabe
        {
            return ergebnis;
        }

        private void kommaButton_Click(object sender, EventArgs e)  // Button für das Komma
        {
            Ergebnislabel.Text = Ergebnislabel.Text + ",";
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_u.Ferienhäuser_Verwaltung
{
    public partial class Buchung : Form
    {
        


        public Buchung(string N, string B, string Str, string Sta, int Nä, string Pr)
        {
            InitializeComponent();
           
            lblName.Text = "Name: " + N;
            lblBundesland.Text = "Bundesland: " + B;
            lblStadt.Text = "Stadt: " + Sta;
            lblStraße.Text = "Straße: " + Str;
            lblAnzahlderNächte.Text = "Anzahl der Nächte: " + Nä.ToString();
            lblPreis.Text = "Preis: " + Pr;
        }

        private void BtnWeiterSuchen_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Visible = false; 
        }

        private void Buchung_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

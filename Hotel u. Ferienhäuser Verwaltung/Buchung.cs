using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;



namespace Hotel_u.Ferienhäuser_Verwaltung
{
    public partial class Buchung : Form
    {

        private Bitmap memoryimg;

        

        public Buchung(string N, string B, string Str, string Sta, int Nä, string Pr,string Kunde)
        {
            InitializeComponent();

            lblName.Text = "Name: " + N;
            lblBundesland.Text = "Bundesland: " + B;
            lblStadt.Text = "Stadt: " + Sta;
            lblStraße.Text = "Straße: " + Str;
            lblAnzahlderNächte.Text = "Anzahl der Nächte: " + Nä.ToString();
            lblPreis.Text = "Preis: " + Pr;
            lblKunde.Text = "Sehr geehrter " + Kunde;
        }
        private void BtnWeiterSuchen_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1("test");
            f1.Show();
            this.Visible = false; 
        }

        private void Buchung_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.PBuchungsVorlage.Width / 2), this.PBuchungsVorlage.Location.Y);
        }
        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            PBuchungsVorlage = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private void BtnPDF_Click(object sender, EventArgs e)
        {
            Print(this.PBuchungsVorlage);
            
        }

        private void PBuchungsVorlage_Paint(object sender, PaintEventArgs e)
        {

        }






    }
}

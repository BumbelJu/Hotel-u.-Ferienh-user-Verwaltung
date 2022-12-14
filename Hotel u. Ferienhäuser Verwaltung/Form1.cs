using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; 

namespace Hotel_u.Ferienhäuser_Verwaltung
{
    public partial class Form1 : Form
    {
        // Datenbankverbindung
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;


        //String Variablen 
        string Kunde;

        //Double Variablen 
        double PreisproNacht;



        //Int Variablen 
        int Nächte;
        int index;
        int KundenID; 

        public Form1(string K, int ID)
        {
            InitializeComponent();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;" + "Data Source = Hotel Verwaltung.mdb";
            cmd.Connection = con;
            cmd.CommandText = "Select * From HotelsundFerienwohnungen";
            Daten();
            Nächte = 1;
            Kunde = K;
            KundenID = ID; 
            PBewertung.Visible = false;
            PBuchen.Visible = false; 
        }
       
        // Datenbankverbindung herstellen
        public void Daten()
        {
            try
            {
                con.Open();
                Dateneinlesen();
                con.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Einzelne Daten ins Data Grid View hinzufügen
        public void Dateneinlesen()
        {
            DgvDaten.Rows.Clear();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DgvDaten.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), reader.GetBoolean(4), reader.GetBoolean(5), reader.GetBoolean(6),
                    reader.GetString(7), reader.GetString(8), reader.GetString(9));
            }
            reader.Close();
        }
        public void Bewertung()
        {
            try
            {
                cmd.CommandText = "Select * From Bewertung where HFHNr = " + (index +1);
                con.Open();
                Bewertungeinlesen();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        public void Bewertungeinlesen()
        {
            DgvBewertung.Rows.Clear();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DgvBewertung.Rows.Add(reader.GetInt32(1), reader.GetInt32(2));
            }
            reader.Close();
        }



        // Filter Möglichkeiten
        private void RbHotelsFiltern_CheckedChanged(object sender, EventArgs e)
        {
            cmd.CommandText = "Select * From HotelsundFerienwohnungen where Art = 'Hotel'";
            Daten();
        }

        private void RbFerienwohnungenFiltern_CheckedChanged(object sender, EventArgs e)
        {
            cmd.CommandText = "Select * From HotelsundFerienwohnungen where Art = 'Ferienwohnung'";
            Daten();
        }

        private void RbAlleAnzeigen_CheckedChanged(object sender, EventArgs e)
        {
            cmd.CommandText = "Select * From HotelsundFerienwohnungen";
            Daten();
        }

        private void CmbBundesländer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd.CommandText = "Select * From HotelsundFerienwohnungen where Bundesland = '" + CmbBundesländer.SelectedItem.ToString() + "'";
            Daten();
        }

        

        private void NudAnzahlNächte_ValueChanged(object sender, EventArgs e)
        {
            Nächte = int.Parse(NudAnzahlNächte.Value.ToString());
            LblPreis.Text = (PreisproNacht * Nächte).ToString() + "€";
        }

        private void DgvDaten_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PBuchen.Visible = true; 
            index = e.RowIndex;
            LblBuchenName.Text = "Namen: " + DgvDaten.Rows[index].Cells[2].Value.ToString();
            // Bewerten
            LblBewertenName.Text = "Namen: " + DgvDaten.Rows[index].Cells[2].Value.ToString();
            // Buchen
            LblBuchenBundesland.Text = "Bundesland: " + DgvDaten.Rows[index].Cells[7].Value.ToString();
            LblBuchenStadt.Text = "Stadt: " + DgvDaten.Rows[index].Cells[8].Value.ToString();
            LblBuchenStraße.Text = "Straße: " + DgvDaten.Rows[index].Cells[9].Value.ToString();

            PreisproNacht = double.Parse(DgvDaten.Rows[index].Cells[3].Value.ToString());

            LblPreis.Text = (PreisproNacht * Nächte).ToString() + "€";

            // Bewerten
            cmd.CommandText = "Select * From Bewertung where HFHNr = " + (index +1);
            Bewertung();

           
        }

        private void BtnBuchungabbrechen_Click(object sender, EventArgs e)
        {
            LblBuchenName.Text = "Namen: ";
            LblBuchenBundesland.Text = "Bundesland: ";
            LblBuchenStadt.Text = "Stadt: ";
            LblBuchenStraße.Text = "Straße: ";
            LblPreis.Text = "0.00€";
            NudAnzahlNächte.Value = 1; 
        }

        private void BtnBuchen_Click(object sender, EventArgs e)
        {
            Buchung bg = new Buchung(DgvDaten.Rows[index].Cells[2].Value.ToString(), DgvDaten.Rows[index].Cells[7].Value.ToString(), 
                DgvDaten.Rows[index].Cells[9].Value.ToString(), DgvDaten.Rows[index].Cells[8].Value.ToString(),
                Nächte,LblPreis.Text,Kunde);
            bg.Show();
            this.Visible = false; 
        }

        private void BtnAbmelden_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Möchten Sie sich Abmelden?", "FRAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                LOGIN Lg = new LOGIN();
                Lg.Show();
                this.Visible = false;
            }
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnHotelBewerten_Click(object sender, EventArgs e)
        {
            if (PBewertung.Visible == false)
            {
                PBewertung.Visible = true;
            }
            else
            {
                PBewertung.Visible = false;
            }
        }

        private void BtnBewerten_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "Insert Into Bewertung(HFHNr, Punkte) Values(" + (index +1) + ", " + NuBewertung.Value + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            Bewertung();
        }
    }
}

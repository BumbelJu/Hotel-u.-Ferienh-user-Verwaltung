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
    public partial class LOGIN : Form
    {
        string NameLogin;
        int Passwort;

        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader; 


        public LOGIN()
        {
            InitializeComponent();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;" + "Data Source = Hotel Verwaltung.mdb";
            cmd.Connection = con;
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            NameLogin = Convert.ToString(TxtName.Text);
        }

        private void TxtPasswort_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Passwort = Convert.ToInt32(TxtPasswort.Text);
            }
            catch (Exception)
            {
                TxtPasswort.Clear();
            }
        }

        private void BtnAnmelden_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "Select * from Kunden";
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (NameLogin == reader.GetString(1) && Passwort == reader.GetInt32(2))
                {
                    Form1 buchen = new Form1();
                    buchen.Show();
                    this.Visible = false;
                    MessageBox.Show("Login Erfolgreich", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                }
                

            }
            reader.Close();
            con.Close(); 
        }

        private void BtnRegistrieren_Click(object sender, EventArgs e)
        {
            Registrieren Rg = new Registrieren();
            Rg.Show();
            this.Visible = false; 
        }

        private void LOGIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

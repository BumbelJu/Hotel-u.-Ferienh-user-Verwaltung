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
    public partial class Registrieren : Form
    {
        string NameLogin;
        int Passwort;

        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;



        public Registrieren()
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
            Passwort = Convert.ToInt32(TxtPasswort.Text); 
        }

        private void BtnRegistrieren_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Möchten Sie sich mit diesen Daten Registrieren","FRAGE",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd.CommandText = "Insert Into Kunden(NameLogin,Passwort) Values('" + NameLogin + "', " + Passwort + ")";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }

        private void BtnZurück_Click(object sender, EventArgs e)
        {
            LOGIN Lg = new LOGIN();
            Lg.Show();
            this.Visible = false; 
        }

        private void Registrieren_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

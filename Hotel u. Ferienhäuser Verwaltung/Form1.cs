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
        string Bundesland; 

        //Double Variablen 


        //Int Variablen 

        
        public Form1()
        {
            InitializeComponent();
        }

        public void Dateneinlesen()
        {

        }
        

        private void TxtBundeslandFiltern_TextChanged(object sender, EventArgs e)
        {
            Bundesland = Convert.ToString(TxtBundeslandFiltern.Text);
        }
    }
}

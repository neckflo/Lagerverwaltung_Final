using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Drawing;




namespace LagerVerwaltung
{
    public partial class Form1 : Form 
    {
        OleDbConnection con;
        anzeigen anz;
        hinzufuegen hin;
        

        public Form1()
        {
            InitializeComponent();

            //startet Klasse Browserfix -> GoogleMaps
            if (!WBEmulator.IsBrowserEmulationSet())
            {
                WBEmulator.SetBrowserEmulationVersion();
            }


        }


        private void button_verbinden_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(Properties.Settings.Default.DBCon);           // Verbindung zur Datenbank herstellen
            try
            {
                con.Open();

                label_meldung.Text = "Verbindung erfolgreich!";
                label_meldung.ForeColor = System.Drawing.Color.Green;
            }
            catch (OleDbException)
            {
                label_meldung.Text = "Verbindung fehlgeschlagen!";
                label_meldung.ForeColor = System.Drawing.Color.Red;
            }
            button4.Enabled = true;     // Button anzeigen
            button_hinzufugen.Enabled = true;
            button_trennen.Enabled = true;



        }

        private void button4_Click(object sender, EventArgs e) // button anzeigen
        {
             
             anz = new anzeigen();                                                      // öffnet Fenster anzeigen
             anz.ShowDialog();
            
        }

        private void button_hinzufugen_Click(object sender, EventArgs e)
        {
            hin = new hinzufuegen(con);                                                 // öffnet Fenster hinzufügen
            hin.ShowDialog();

        }

        private void button_trennen_Click(object sender, EventArgs e)
        {
            con.Close();                                                                // Verbindung trennen
            button4.Enabled = false;
            button_hinzufugen.Enabled = false;
            button_trennen.Enabled = false;

            label_meldung.Text = "";

        }

        
    }
}

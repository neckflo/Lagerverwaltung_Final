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

namespace LagerVerwaltung
{
    public partial class hinzufuegen : Form
    {
        
        OleDbConnection con = null;
        Produkt aProdukt = new Produkt();
        Produkt newProdukt = null;

        public hinzufuegen()
        {
            InitializeComponent();
        }
        public OleDbConnection Con
        {
            get
            {
                return con;
            }

            set
            {
                con = value;
            }
        }
        public hinzufuegen(OleDbConnection connection): this()
        {
            this.con = connection;
            OleDbCommand cmd = con.CreateCommand();
            try                                                                             // Autowert für neuen Artikel wird ausgelesen/angezeigt       
            {
                //Autowert

                cmd.CommandText = "Select Count(*) from lager";
                Int32 auto = (Int32)cmd.ExecuteScalar();

                auto++;
                aProdukt.Nummer = auto;
                textBox_nummer.Text = auto.ToString();
            }
            catch (Exception)
            {


            }

        }

        private void button1_Click(object sender, EventArgs e)                      // zurück Button
        {
            this.Close();
        }
        internal Produkt NewProdukt                                                 // Wird benötigt um auf Getter/Setter der Klasse Produkt zuzugreifen
        {
            get
            {
                return newProdukt;
            }


        }

        private void button_hinzufuegenartikel_Click(object sender, EventArgs e)    // Artikel wird erstellt
        {          
            Produkt aProdukt = new Produkt();
            aProdukt.Name = textBox_name.Text;
            aProdukt.Bezeichnung = textBox_bezeichnung.Text;
            aProdukt.Bestand = Convert.ToInt32(textBox_bestand.Text);
            aProdukt.Lagerort = Convert.ToInt32(textBox_lagerort.Text);
            aProdukt.Preis = Convert.ToInt32(textBox_preis.Text);
            insertDB(aProdukt);
            newProdukt = aProdukt;
        }
        private void insertDB(Produkt aProdukt)                                     // Artikel wird in DB eingefügt
        {
            OleDbCommand cmd = con.CreateCommand();

            
            try
            {
                                                                                     //Autowert wird hochgezählt
                cmd.CommandText = "Select Count(*) from lager";
                Int32 auto = (Int32)cmd.ExecuteScalar();
                auto++;
                aProdukt.Nummer = auto;
                textBox_nummer.Text = auto.ToString();

            }
            catch (Exception)
            {

  
            }
            //Parameter werden festgelegt
            cmd.Parameters.Add("NR", OleDbType.Integer);
            cmd.Parameters.Add("NAM", OleDbType.WChar);
            cmd.Parameters.Add("BEZ", OleDbType.WChar);
            cmd.Parameters.Add("BES", OleDbType.Integer);
            cmd.Parameters.Add("LO", OleDbType.Integer);
            cmd.Parameters.Add("PR", OleDbType.Integer);
            
            //Values werden zugewiesen
            cmd.Parameters["NR"].Value = aProdukt.Nummer;
            cmd.Parameters["NAM"].Value = aProdukt.Name;
            cmd.Parameters["BEZ"].Value = aProdukt.Bezeichnung;
            cmd.Parameters["BES"].Value = aProdukt.Bestand;
            cmd.Parameters["LO"].Value = aProdukt.Lagerort;
            cmd.Parameters["PR"].Value = aProdukt.Preis;

            // SQL Befehl 
            cmd.CommandText = "Insert into lager (artikelnummer,artikelname,beschreibung,bestand,lagerort,preis) Values (NR,NAM,BEZ,BES,LO,PR)";

            //Ausführen
            try
            {                 
                cmd.ExecuteNonQuery();                                                                  // Führt SQL Befehl aus
                MessageBox.Show("Artikelnummer "+aProdukt.Nummer+" wurde erfolgreich hinzugefügt!");
                textBox_name.Clear();
                textBox_nummer.Clear();
                textBox_bezeichnung.Clear();
                textBox_bestand.Clear();
                textBox_lagerort.Clear();
                textBox_preis.Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Einfügen nicht erfolgreich");
            }
                    
        }


        // Validating wird für die Eingabeprüfung benutzt (bei Integer nur Zahlen etc)
        private void textBox_nummer_Validating(object sender, CancelEventArgs e)                    
        {
            int i = 0;

            try
            {
                i = Convert.ToInt32(textBox_nummer.Text);
            }
            catch
            {
                MessageBox.Show("Vorsicht nur Integer erlaubt!");
                e.Cancel = true;
            }
        }
        private void textBox_bestand_Validating(object sender, CancelEventArgs e)
        {
            int i = 0;

            try
            {
                i = Convert.ToInt32(textBox_bestand.Text);
            }
            catch
            {
                MessageBox.Show("Vorsicht nur Integer erlaubt!");
                e.Cancel = true;
            }
        }

        private void textBox_lagerort_Validating(object sender, CancelEventArgs e)                  // Lagerorte 1-5
        {
            int i = 0;

            try
            {
                i = Convert.ToInt32(textBox_lagerort.Text);
                
                if (i <=0 || i >5)
                {
                    MessageBox.Show("Nur Werte von 1-5.");
                    e.Cancel = true;
                }
                
            }
            catch
            {
                MessageBox.Show("Vorsicht nur Integer erlaubt!");
                e.Cancel = true;
            }
        }


        private void textBox_preis_Validating(object sender, CancelEventArgs e)
        {
            int i = 0;

            try
            {
                i = Convert.ToInt32(textBox_preis.Text);
            }
            catch
            {
                MessageBox.Show("Vorsicht nur Integer erlaubt!");
                e.Cancel = true;
            }
        }
        private void textBox_preis_Validating_1(object sender, CancelEventArgs e)
        {
            int i = 0;

            try
            {
                i = Convert.ToInt32(textBox_preis.Text);
            }
            catch
            {
                MessageBox.Show("Vorsicht nur Integer erlaubt!");
                e.Cancel = true;
            }
        }

        private void textBox_preis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

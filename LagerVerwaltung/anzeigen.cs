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
using System.Drawing.Printing;
using System.Collections;



namespace LagerVerwaltung
{
    public partial class anzeigen : Form
    {
        DataSet dsLager;                                                        // Cache 
        OleDbConnection con;
        OleDbDataAdapter adpLager = null;                                       // Wird benötigt für SQL Befehle
        lagerauswahl lageraus;                                                  // Wird benötigt für GoogleMaps

        //Drucken
        private PrintDocument printDoc;
        private int drucker;
       
        private PrintPreviewDialog printPreview;
        private PrintDocument printDocument1 = new PrintDocument();

 



        public anzeigen()
        {
            InitializeComponent();
            druckerLaden();                                                                         // sucht nach verfügbaren Druckern
            con = new OleDbConnection(Properties.Settings.Default.DBCon);
            adpLager = new OleDbDataAdapter("select * from lager", con);                            // Wird für GridView benötigt
            dsLager = new DataSet();                                                                // Erstellen des DataSets
            datenAnzeigen();                                                                        // Füllt das GridView
            comboBox1.Items.Add("1. Würzburg");
            comboBox1.Items.Add("2. Hamburg");
            comboBox1.Items.Add("3. Stuttgart");
            comboBox1.Items.Add("4. München");
            comboBox1.Items.Add("5. Berlin");
            comboBox1.Items.Add("Gesamt");
        }

        private void verbinden()
        {
            try
            {
                con = new OleDbConnection(Properties.Settings.Default.DBCon);
            }
            catch (Exception)
            {
            }
        }

        public void datenAnzeigen()                                                                     // Füllt das GridView
        {

            try
            {
                adpLager.Fill(dsLager, "Lager");
                dataGridViewLager.DataSource = dsLager;                                                 // Datenquelle
                dataGridViewLager.DataMember = "Lager";                                                 // Tabellenname
            }
            catch (Exception)
            {
                MessageBox.Show("Daten konnten nicht geladen werden!");
            }

        }
        private void button_zuruck_lagerverwaltung_Click(object sender, EventArgs e)
        {
            serialisieren();                                                                            // Lokal speichern
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)                                          // In Datendank speichern
        {
            OleDbCommandBuilder b = new OleDbCommandBuilder(adpLager);
            adpLager.UpdateCommand = b.GetUpdateCommand();

            adpLager.InsertCommand = b.GetInsertCommand();

            adpLager.DeleteCommand = b.GetDeleteCommand();

            adpLager.Update(dsLager, "Lager");

            MessageBox.Show("Die Daten wurden erfolgreich in die Datenbank geschrieben");
        }

        private void button1_Click(object sender, EventArgs e)                                          // öffnet Fenster Maps
        {

            lageraus = new lagerauswahl();
            lageraus.ShowDialog();


        }

        //Verschiedene Lagerorte anzeigen per SQL Befehl, danach in GridView laden durch Methode datenAnzeigen()
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int lager = comboBox1.SelectedIndex;

            dataGridViewLager.Columns.Clear();
            dsLager = new DataSet();
            if (lager == 0)
            {
                adpLager = new OleDbDataAdapter("select * from lager where lagerort = 1", con);
                datenAnzeigen();
            }
            if (lager == 1)
            {
                adpLager = new OleDbDataAdapter("select * from lager where lagerort = 2", con);
                datenAnzeigen();
            }
            if (lager == 2)
            {
                adpLager = new OleDbDataAdapter("select * from lager where lagerort = 3", con);
                datenAnzeigen();
            }
            if (lager == 3)
            {
                adpLager = new OleDbDataAdapter("select * from lager where lagerort = 4", con);
                datenAnzeigen();
            }
            if (lager == 4)
            {
                adpLager = new OleDbDataAdapter("select * from lager where lagerort = 5", con);
                datenAnzeigen();
            }
            if (lager == 5)
            {
                adpLager = new OleDbDataAdapter("select * from lager", con);
                datenAnzeigen();
            }

            
        }
        private void serialisieren()
        {
            dsLager.WriteXmlSchema("produktliste.xsd");                                                         // Struktur wird gespeichert
            dsLager.WriteXml("produktliste.xml", XmlWriteMode.DiffGram);                                        // Inhalt wird gespeichert
            MessageBox.Show("Die Daten wurden erfolgreich Serialisiert");
        }
        private void button_serialisieren_Click(object sender, EventArgs e)
        {
            serialisieren();
        }

        private void deserialisieren()
        {
            dataGridViewLager.DataSource = null;
            dataGridViewLager.Rows.Clear();
            dataGridViewLager.Columns.Clear();

            dsLager = new DataSet();
            dsLager.ReadXmlSchema("produktliste.xsd");
            dsLager.ReadXml("produktliste.xml", XmlReadMode.DiffGram);
            dataGridViewLager.DataSource = dsLager;
            dataGridViewLager.DataMember = "Lager";
            MessageBox.Show("Die Daten wurden erfolgreich Deserialisiert");

        }
        private void button_deserialisieren_Click(object sender, EventArgs e)
        {
            deserialisieren();
            
        }

        ////////////////////////////////////////////////////////////////////////////////////////

        //Drucker werden im System gesucht
        //Drucker werden in die Kombobox geladen
        private void druckerLaden()
        {
            List<string> printers = new List<string>();
            foreach (string p in PrinterSettings.InstalledPrinters)
            {
                printers.Add(p);                                                                            
                comboBox_drucker.Items.Add(p);                                                                    
            }
        }


        //Die zu druckende Seite wird erstellt (GridviewLager)
        private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridViewLager.Width, this.dataGridViewLager.Height);
            dataGridViewLager.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridViewLager.Width, this.dataGridViewLager.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    
        //Dialog mit Druckvorschau + Druckfunktion
        private void button_druckvorschau_Click(object sender, EventArgs e)
        {
            printDoc = new PrintDocument();
            printPreview = new PrintPreviewDialog();

            printDoc.PrinterSettings.PrinterName = PrinterSettings.InstalledPrinters[drucker]; // Drucker ist ein Integer

            // Druckseite erzeugen
            printDoc.PrintPage += new PrintPageEventHandler(PrintPage);


            // Druckvorschau
            printPreview.Document = printDoc;
            printPreview.Show();
        }

        //Drucker auswählen
        private void comboBox_drucker_SelectedIndexChanged(object sender, EventArgs e)
        {
            drucker = comboBox_drucker.SelectedIndex;
        }
    }







}
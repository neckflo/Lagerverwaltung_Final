using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LagerVerwaltung
{
    public partial class lagerauswahl : Form
    {

        
        public lagerauswahl()                                           //Kombobox füllen
        {
            InitializeComponent();
            comboBox1.Items.Add("Würzburg");
            comboBox1.Items.Add("Hamburg");
            comboBox1.Items.Add("Stuttgart");
            comboBox1.Items.Add("München");
            comboBox1.Items.Add("Berlin");
        }

        private void button1_Click(object sender, EventArgs e)          //Methode Karte ausführen bei Klick auf Anzeigen
        {
            karteanzeigen();
        }
        private void karteanzeigen()                                    //Übergebe den Ort an Attribute, Stringbuilder setzt den wert an die URL an.
        {
            try
            {
                string ort = comboBox1.SelectedItem.ToString();
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("https://maps.google.com/maps?q=");

                if (ort != string.Empty)
                {
                    queryaddress.Append(ort);
                }


                webBrowser1.Navigate(queryaddress.ToString());      //Navigiere zu QUeryadresse
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
          

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Methode Karte ausführen bei aúswahl
        {
            karteanzeigen();

        }

        private void button2_Click(object sender, EventArgs e) //Fennster schließen
        {
            this.Close();
        }

       
    }
    
}

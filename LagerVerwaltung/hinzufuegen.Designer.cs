namespace LagerVerwaltung
{
    partial class hinzufuegen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_nummer = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_bezeichnung = new System.Windows.Forms.TextBox();
            this.textBox_bestand = new System.Windows.Forms.TextBox();
            this.textBox_lagerort = new System.Windows.Forms.TextBox();
            this.button_hinzufuegenartikel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_preis = new System.Windows.Forms.TextBox();
            this.label_preis = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zurück";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artikelnummer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bezeichnung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bestand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lagerort";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Datensatz hinzufügen";
            // 
            // textBox_nummer
            // 
            this.textBox_nummer.Enabled = false;
            this.textBox_nummer.Location = new System.Drawing.Point(158, 65);
            this.textBox_nummer.Name = "textBox_nummer";
            this.textBox_nummer.Size = new System.Drawing.Size(100, 20);
            this.textBox_nummer.TabIndex = 7;
            this.textBox_nummer.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_nummer_Validating);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(158, 94);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 8;
            // 
            // textBox_bezeichnung
            // 
            this.textBox_bezeichnung.Location = new System.Drawing.Point(158, 123);
            this.textBox_bezeichnung.Name = "textBox_bezeichnung";
            this.textBox_bezeichnung.Size = new System.Drawing.Size(100, 20);
            this.textBox_bezeichnung.TabIndex = 9;
            // 
            // textBox_bestand
            // 
            this.textBox_bestand.Location = new System.Drawing.Point(158, 151);
            this.textBox_bestand.Name = "textBox_bestand";
            this.textBox_bestand.Size = new System.Drawing.Size(100, 20);
            this.textBox_bestand.TabIndex = 10;
            this.textBox_bestand.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_bestand_Validating);
            // 
            // textBox_lagerort
            // 
            this.textBox_lagerort.Location = new System.Drawing.Point(158, 180);
            this.textBox_lagerort.Name = "textBox_lagerort";
            this.textBox_lagerort.Size = new System.Drawing.Size(100, 20);
            this.textBox_lagerort.TabIndex = 11;
            this.textBox_lagerort.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_lagerort_Validating);
            // 
            // button_hinzufuegenartikel
            // 
            this.button_hinzufuegenartikel.Location = new System.Drawing.Point(37, 241);
            this.button_hinzufuegenartikel.Name = "button_hinzufuegenartikel";
            this.button_hinzufuegenartikel.Size = new System.Drawing.Size(245, 23);
            this.button_hinzufuegenartikel.TabIndex = 12;
            this.button_hinzufuegenartikel.Text = "Artikel hinzufügen";
            this.button_hinzufuegenartikel.UseVisualStyleBackColor = true;
            this.button_hinzufuegenartikel.Click += new System.EventHandler(this.button_hinzufuegenartikel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_preis);
            this.groupBox1.Controls.Add(this.label_preis);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(37, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 202);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "-------";
            // 
            // textBox_preis
            // 
            this.textBox_preis.Location = new System.Drawing.Point(121, 177);
            this.textBox_preis.Name = "textBox_preis";
            this.textBox_preis.Size = new System.Drawing.Size(100, 20);
            this.textBox_preis.TabIndex = 8;
            this.textBox_preis.TextChanged += new System.EventHandler(this.textBox_preis_TextChanged);
            this.textBox_preis.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_preis_Validating_1);
            // 
            // label_preis
            // 
            this.label_preis.AutoSize = true;
            this.label_preis.Location = new System.Drawing.Point(13, 177);
            this.label_preis.Name = "label_preis";
            this.label_preis.Size = new System.Drawing.Size(30, 13);
            this.label_preis.TabIndex = 7;
            this.label_preis.Text = "Preis";
            // 
            // hinzufuegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 376);
            this.Controls.Add(this.button_hinzufuegenartikel);
            this.Controls.Add(this.textBox_lagerort);
            this.Controls.Add(this.textBox_bestand);
            this.Controls.Add(this.textBox_bezeichnung);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_nummer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "hinzufuegen";
            this.Text = "hinzufuegen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_nummer;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_bezeichnung;
        private System.Windows.Forms.TextBox textBox_bestand;
        private System.Windows.Forms.TextBox textBox_lagerort;
        private System.Windows.Forms.Button button_hinzufuegenartikel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_preis;
        private System.Windows.Forms.Label label_preis;
    }
}
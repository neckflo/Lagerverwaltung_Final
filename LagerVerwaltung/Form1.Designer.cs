namespace LagerVerwaltung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_verbinden = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button_hinzufugen = new System.Windows.Forms.Button();
            this.label_meldung = new System.Windows.Forms.Label();
            this.button_trennen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lagerverwaltung = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_verbinden
            // 
            this.button_verbinden.Location = new System.Drawing.Point(12, 17);
            this.button_verbinden.Name = "button_verbinden";
            this.button_verbinden.Size = new System.Drawing.Size(75, 23);
            this.button_verbinden.TabIndex = 2;
            this.button_verbinden.Text = "Verbinden";
            this.button_verbinden.UseVisualStyleBackColor = true;
            this.button_verbinden.Click += new System.EventHandler(this.button_verbinden_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(408, 109);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Anzeigen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_hinzufugen
            // 
            this.button_hinzufugen.Enabled = false;
            this.button_hinzufugen.Location = new System.Drawing.Point(408, 140);
            this.button_hinzufugen.Name = "button_hinzufugen";
            this.button_hinzufugen.Size = new System.Drawing.Size(75, 23);
            this.button_hinzufugen.TabIndex = 4;
            this.button_hinzufugen.Text = "Hinzufügen";
            this.button_hinzufugen.UseVisualStyleBackColor = true;
            this.button_hinzufugen.Click += new System.EventHandler(this.button_hinzufugen_Click);
            // 
            // label_meldung
            // 
            this.label_meldung.AutoSize = true;
            this.label_meldung.Location = new System.Drawing.Point(135, 64);
            this.label_meldung.Name = "label_meldung";
            this.label_meldung.Size = new System.Drawing.Size(0, 13);
            this.label_meldung.TabIndex = 8;
            // 
            // button_trennen
            // 
            this.button_trennen.Enabled = false;
            this.button_trennen.Location = new System.Drawing.Point(108, 17);
            this.button_trennen.Name = "button_trennen";
            this.button_trennen.Size = new System.Drawing.Size(75, 23);
            this.button_trennen.TabIndex = 9;
            this.button_trennen.Text = "Trennen";
            this.button_trennen.UseVisualStyleBackColor = true;
            this.button_trennen.Click += new System.EventHandler(this.button_trennen_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Verbindung";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_trennen);
            this.panel1.Controls.Add(this.button_verbinden);
            this.panel1.Location = new System.Drawing.Point(12, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 119);
            this.panel1.TabIndex = 10;
            // 
            // Lagerverwaltung
            // 
            this.Lagerverwaltung.AutoSize = true;
            this.Lagerverwaltung.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lagerverwaltung.Location = new System.Drawing.Point(115, 9);
            this.Lagerverwaltung.Name = "Lagerverwaltung";
            this.Lagerverwaltung.Size = new System.Drawing.Size(171, 25);
            this.Lagerverwaltung.TabIndex = 11;
            this.Lagerverwaltung.Text = "Lagerverwaltung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Artikel";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(380, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 86);
            this.panel2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 336);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_hinzufugen);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lagerverwaltung);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_meldung);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_verbinden;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_hinzufugen;
        private System.Windows.Forms.Label label_meldung;
        private System.Windows.Forms.Button button_trennen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lagerverwaltung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}


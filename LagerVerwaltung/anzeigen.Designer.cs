namespace LagerVerwaltung
{
    partial class anzeigen
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
            this.button_zuruck_lagerverwaltung = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_serialisieren = new System.Windows.Forms.Button();
            this.button_deserialisieren = new System.Windows.Forms.Button();
            this.comboBox_drucker = new System.Windows.Forms.ComboBox();
            this.button_druckvorschau = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewLager = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLager)).BeginInit();
            this.SuspendLayout();
            // 
            // button_zuruck_lagerverwaltung
            // 
            this.button_zuruck_lagerverwaltung.Location = new System.Drawing.Point(617, 365);
            this.button_zuruck_lagerverwaltung.Name = "button_zuruck_lagerverwaltung";
            this.button_zuruck_lagerverwaltung.Size = new System.Drawing.Size(75, 23);
            this.button_zuruck_lagerverwaltung.TabIndex = 1;
            this.button_zuruck_lagerverwaltung.Text = "Zurück";
            this.button_zuruck_lagerverwaltung.UseVisualStyleBackColor = true;
            this.button_zuruck_lagerverwaltung.Click += new System.EventHandler(this.button_zuruck_lagerverwaltung_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Daten in Datenbank Sichern";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lagerverwaltung";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Karte zeigen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_serialisieren
            // 
            this.button_serialisieren.Location = new System.Drawing.Point(228, 365);
            this.button_serialisieren.Name = "button_serialisieren";
            this.button_serialisieren.Size = new System.Drawing.Size(137, 23);
            this.button_serialisieren.TabIndex = 7;
            this.button_serialisieren.Text = "Serialisieren";
            this.button_serialisieren.UseVisualStyleBackColor = true;
            this.button_serialisieren.Click += new System.EventHandler(this.button_serialisieren_Click);
            // 
            // button_deserialisieren
            // 
            this.button_deserialisieren.Location = new System.Drawing.Point(371, 365);
            this.button_deserialisieren.Name = "button_deserialisieren";
            this.button_deserialisieren.Size = new System.Drawing.Size(107, 23);
            this.button_deserialisieren.TabIndex = 8;
            this.button_deserialisieren.Text = "Deserialisieren";
            this.button_deserialisieren.UseVisualStyleBackColor = true;
            this.button_deserialisieren.Click += new System.EventHandler(this.button_deserialisieren_Click);
            // 
            // comboBox_drucker
            // 
            this.comboBox_drucker.FormattingEnabled = true;
            this.comboBox_drucker.Location = new System.Drawing.Point(244, 36);
            this.comboBox_drucker.Name = "comboBox_drucker";
            this.comboBox_drucker.Size = new System.Drawing.Size(121, 21);
            this.comboBox_drucker.TabIndex = 9;
            this.comboBox_drucker.SelectedIndexChanged += new System.EventHandler(this.comboBox_drucker_SelectedIndexChanged);
            // 
            // button_druckvorschau
            // 
            this.button_druckvorschau.Location = new System.Drawing.Point(371, 36);
            this.button_druckvorschau.Name = "button_druckvorschau";
            this.button_druckvorschau.Size = new System.Drawing.Size(89, 23);
            this.button_druckvorschau.TabIndex = 11;
            this.button_druckvorschau.Text = "Drucken";
            this.button_druckvorschau.UseVisualStyleBackColor = true;
            this.button_druckvorschau.Click += new System.EventHandler(this.button_druckvorschau_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Drucker";
            // 
            // dataGridViewLager
            // 
            this.dataGridViewLager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLager.Location = new System.Drawing.Point(18, 63);
            this.dataGridViewLager.Name = "dataGridViewLager";
            this.dataGridViewLager.Size = new System.Drawing.Size(660, 279);
            this.dataGridViewLager.TabIndex = 14;
            // 
            // anzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 400);
            this.Controls.Add(this.dataGridViewLager);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_druckvorschau);
            this.Controls.Add(this.comboBox_drucker);
            this.Controls.Add(this.button_deserialisieren);
            this.Controls.Add(this.button_serialisieren);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_zuruck_lagerverwaltung);
            this.Name = "anzeigen";
            this.Text = "anzeigen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_zuruck_lagerverwaltung;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_serialisieren;
        private System.Windows.Forms.Button button_deserialisieren;
        private System.Windows.Forms.ComboBox comboBox_drucker;
        private System.Windows.Forms.Button button_druckvorschau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewLager;
    }
}
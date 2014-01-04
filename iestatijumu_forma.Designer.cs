namespace puzlicis
{
    partial class iestatijumu_forma
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
            this.apstiprinat = new System.Windows.Forms.Button();
            this.atiestatit = new System.Windows.Forms.Button();
            this.cilne_citi = new System.Windows.Forms.TabPage();
            this.cilne_noformejums = new System.Windows.Forms.TabPage();
            this.fonts = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.piecpadsmit_krasa = new System.Windows.Forms.Panel();
            this.iezimeta_krasa = new System.Windows.Forms.Panel();
            this.iezimeta_krasa_txt = new System.Windows.Forms.Label();
            this.aktiva_krasa_txt = new System.Windows.Forms.Label();
            this.aktiva_krasa = new System.Windows.Forms.Panel();
            this.indeksu_krasa = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rezga_krasa_txt = new System.Windows.Forms.Label();
            this.rezga_krasa = new System.Windows.Forms.Panel();
            this.cilnes = new System.Windows.Forms.TabControl();
            this.jauna_spele = new System.Windows.Forms.CheckBox();
            this.rezultati = new System.Windows.Forms.CheckBox();
            this.saglabat = new System.Windows.Forms.CheckBox();
            this.cilne_citi.SuspendLayout();
            this.cilne_noformejums.SuspendLayout();
            this.cilnes.SuspendLayout();
            this.SuspendLayout();
            // 
            // apstiprinat
            // 
            this.apstiprinat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.apstiprinat.Location = new System.Drawing.Point(12, 254);
            this.apstiprinat.Name = "apstiprinat";
            this.apstiprinat.Size = new System.Drawing.Size(220, 23);
            this.apstiprinat.TabIndex = 1;
            this.apstiprinat.Text = "&Apstiprināt izmaiņas un aizvērt";
            this.apstiprinat.UseVisualStyleBackColor = true;
            this.apstiprinat.Click += new System.EventHandler(this.apstiprinat_Click);
            // 
            // atiestatit
            // 
            this.atiestatit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.atiestatit.Location = new System.Drawing.Point(12, 283);
            this.atiestatit.Name = "atiestatit";
            this.atiestatit.Size = new System.Drawing.Size(220, 23);
            this.atiestatit.TabIndex = 2;
            this.atiestatit.Text = "A&tiestatīt iestatījumus";
            this.atiestatit.UseVisualStyleBackColor = true;
            this.atiestatit.Click += new System.EventHandler(this.atiestatit_Click);
            // 
            // cilne_citi
            // 
            this.cilne_citi.Controls.Add(this.saglabat);
            this.cilne_citi.Controls.Add(this.rezultati);
            this.cilne_citi.Controls.Add(this.jauna_spele);
            this.cilne_citi.Location = new System.Drawing.Point(4, 25);
            this.cilne_citi.Name = "cilne_citi";
            this.cilne_citi.Padding = new System.Windows.Forms.Padding(3);
            this.cilne_citi.Size = new System.Drawing.Size(236, 219);
            this.cilne_citi.TabIndex = 1;
            this.cilne_citi.Text = "Citi";
            this.cilne_citi.UseVisualStyleBackColor = true;
            // 
            // cilne_noformejums
            // 
            this.cilne_noformejums.Controls.Add(this.fonts);
            this.cilne_noformejums.Controls.Add(this.label2);
            this.cilne_noformejums.Controls.Add(this.piecpadsmit_krasa);
            this.cilne_noformejums.Controls.Add(this.iezimeta_krasa);
            this.cilne_noformejums.Controls.Add(this.iezimeta_krasa_txt);
            this.cilne_noformejums.Controls.Add(this.aktiva_krasa_txt);
            this.cilne_noformejums.Controls.Add(this.aktiva_krasa);
            this.cilne_noformejums.Controls.Add(this.indeksu_krasa);
            this.cilne_noformejums.Controls.Add(this.label1);
            this.cilne_noformejums.Controls.Add(this.rezga_krasa_txt);
            this.cilne_noformejums.Controls.Add(this.rezga_krasa);
            this.cilne_noformejums.Location = new System.Drawing.Point(4, 25);
            this.cilne_noformejums.Name = "cilne_noformejums";
            this.cilne_noformejums.Padding = new System.Windows.Forms.Padding(3);
            this.cilne_noformejums.Size = new System.Drawing.Size(236, 219);
            this.cilne_noformejums.TabIndex = 0;
            this.cilne_noformejums.Text = "Noformējums";
            this.cilne_noformejums.UseVisualStyleBackColor = true;
            // 
            // fonts
            // 
            this.fonts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fonts.Location = new System.Drawing.Point(6, 6);
            this.fonts.Name = "fonts";
            this.fonts.Size = new System.Drawing.Size(224, 30);
            this.fonts.TabIndex = 1;
            this.fonts.Text = "&Mainīt indeksu fontu";
            this.fonts.UseVisualStyleBackColor = true;
            this.fonts.Click += new System.EventHandler(this.fonts_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "\"15\" lauciņa krāsa:";
            // 
            // piecpadsmit_krasa
            // 
            this.piecpadsmit_krasa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.piecpadsmit_krasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.piecpadsmit_krasa.Location = new System.Drawing.Point(140, 186);
            this.piecpadsmit_krasa.Name = "piecpadsmit_krasa";
            this.piecpadsmit_krasa.Size = new System.Drawing.Size(90, 30);
            this.piecpadsmit_krasa.TabIndex = 6;
            this.piecpadsmit_krasa.Click += new System.EventHandler(this.piecpadsmit_krasa_Click);
            // 
            // iezimeta_krasa
            // 
            this.iezimeta_krasa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iezimeta_krasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iezimeta_krasa.Location = new System.Drawing.Point(140, 114);
            this.iezimeta_krasa.Name = "iezimeta_krasa";
            this.iezimeta_krasa.Size = new System.Drawing.Size(90, 30);
            this.iezimeta_krasa.TabIndex = 4;
            this.iezimeta_krasa.Click += new System.EventHandler(this.iezimeta_krasa_Click);
            // 
            // iezimeta_krasa_txt
            // 
            this.iezimeta_krasa_txt.AutoSize = true;
            this.iezimeta_krasa_txt.Location = new System.Drawing.Point(5, 123);
            this.iezimeta_krasa_txt.Name = "iezimeta_krasa_txt";
            this.iezimeta_krasa_txt.Size = new System.Drawing.Size(116, 13);
            this.iezimeta_krasa_txt.TabIndex = 4;
            this.iezimeta_krasa_txt.Text = "Iezīmētā lauciņa krāsa:";
            // 
            // aktiva_krasa_txt
            // 
            this.aktiva_krasa_txt.AutoSize = true;
            this.aktiva_krasa_txt.Location = new System.Drawing.Point(5, 87);
            this.aktiva_krasa_txt.Name = "aktiva_krasa_txt";
            this.aktiva_krasa_txt.Size = new System.Drawing.Size(107, 13);
            this.aktiva_krasa_txt.TabIndex = 3;
            this.aktiva_krasa_txt.Text = "Aktīvā lauciņa krāsa:";
            // 
            // aktiva_krasa
            // 
            this.aktiva_krasa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aktiva_krasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aktiva_krasa.Location = new System.Drawing.Point(140, 78);
            this.aktiva_krasa.Name = "aktiva_krasa";
            this.aktiva_krasa.Size = new System.Drawing.Size(90, 30);
            this.aktiva_krasa.TabIndex = 3;
            this.aktiva_krasa.Click += new System.EventHandler(this.aktiva_krasa_Click);
            // 
            // indeksu_krasa
            // 
            this.indeksu_krasa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.indeksu_krasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.indeksu_krasa.Location = new System.Drawing.Point(140, 150);
            this.indeksu_krasa.Name = "indeksu_krasa";
            this.indeksu_krasa.Size = new System.Drawing.Size(90, 30);
            this.indeksu_krasa.TabIndex = 5;
            this.indeksu_krasa.Click += new System.EventHandler(this.indeksu_krasa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Indeksu krāsa:";
            // 
            // rezga_krasa_txt
            // 
            this.rezga_krasa_txt.AutoSize = true;
            this.rezga_krasa_txt.Location = new System.Drawing.Point(8, 51);
            this.rezga_krasa_txt.Name = "rezga_krasa_txt";
            this.rezga_krasa_txt.Size = new System.Drawing.Size(100, 13);
            this.rezga_krasa_txt.TabIndex = 2;
            this.rezga_krasa_txt.Text = "Spēles režģa krāsa:";
            // 
            // rezga_krasa
            // 
            this.rezga_krasa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rezga_krasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rezga_krasa.Location = new System.Drawing.Point(140, 42);
            this.rezga_krasa.Name = "rezga_krasa";
            this.rezga_krasa.Size = new System.Drawing.Size(90, 30);
            this.rezga_krasa.TabIndex = 2;
            this.rezga_krasa.Click += new System.EventHandler(this.rezga_krasa_Click);
            // 
            // cilnes
            // 
            this.cilnes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cilnes.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.cilnes.Controls.Add(this.cilne_noformejums);
            this.cilnes.Controls.Add(this.cilne_citi);
            this.cilnes.Location = new System.Drawing.Point(0, 0);
            this.cilnes.Name = "cilnes";
            this.cilnes.SelectedIndex = 0;
            this.cilnes.Size = new System.Drawing.Size(244, 248);
            this.cilnes.TabIndex = 0;
            // 
            // jauna_spele
            // 
            this.jauna_spele.AutoSize = true;
            this.jauna_spele.Checked = true;
            this.jauna_spele.CheckState = System.Windows.Forms.CheckState.Checked;
            this.jauna_spele.Location = new System.Drawing.Point(6, 6);
            this.jauna_spele.Name = "jauna_spele";
            this.jauna_spele.Size = new System.Drawing.Size(148, 17);
            this.jauna_spele.TabIndex = 0;
            this.jauna_spele.Text = "Jaunas spēles paziņojums";
            this.jauna_spele.UseVisualStyleBackColor = true;
            // 
            // rezultati
            // 
            this.rezultati.AutoSize = true;
            this.rezultati.Checked = true;
            this.rezultati.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rezultati.Location = new System.Drawing.Point(6, 52);
            this.rezultati.Name = "rezultati";
            this.rezultati.Size = new System.Drawing.Size(126, 17);
            this.rezultati.TabIndex = 1;
            this.rezultati.Text = "Rezultātu paziņojums";
            this.rezultati.UseVisualStyleBackColor = true;
            // 
            // saglabat
            // 
            this.saglabat.AutoSize = true;
            this.saglabat.Checked = true;
            this.saglabat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saglabat.Location = new System.Drawing.Point(6, 29);
            this.saglabat.Name = "saglabat";
            this.saglabat.Size = new System.Drawing.Size(162, 17);
            this.saglabat.TabIndex = 2;
            this.saglabat.Text = "Saglabāt nepabeigtās spēles";
            this.saglabat.UseVisualStyleBackColor = true;
            // 
            // iestatijumu_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 318);
            this.Controls.Add(this.atiestatit);
            this.Controls.Add(this.apstiprinat);
            this.Controls.Add(this.cilnes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "iestatijumu_forma";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Iestatījumi...";
            this.cilne_citi.ResumeLayout(false);
            this.cilne_citi.PerformLayout();
            this.cilne_noformejums.ResumeLayout(false);
            this.cilne_noformejums.PerformLayout();
            this.cilnes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button apstiprinat;
        private System.Windows.Forms.Button atiestatit;
        private System.Windows.Forms.TabPage cilne_citi;
        private System.Windows.Forms.TabPage cilne_noformejums;
        private System.Windows.Forms.Button fonts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel piecpadsmit_krasa;
        private System.Windows.Forms.Panel iezimeta_krasa;
        private System.Windows.Forms.Label iezimeta_krasa_txt;
        private System.Windows.Forms.Label aktiva_krasa_txt;
        private System.Windows.Forms.Panel aktiva_krasa;
        private System.Windows.Forms.Panel indeksu_krasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rezga_krasa_txt;
        private System.Windows.Forms.Panel rezga_krasa;
        private System.Windows.Forms.TabControl cilnes;
        private System.Windows.Forms.CheckBox jauna_spele;
        private System.Windows.Forms.CheckBox rezultati;
        private System.Windows.Forms.CheckBox saglabat;
    }
}
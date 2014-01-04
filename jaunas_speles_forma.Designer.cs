namespace puzlicis
{
    partial class jaunas_speles_forma
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
            this.sakt_speli = new System.Windows.Forms.Button();
            this.rindas = new System.Windows.Forms.NumericUpDown();
            this.kolonnas = new System.Windows.Forms.NumericUpDown();
            this.rindas_txt = new System.Windows.Forms.Label();
            this.kolonnas_txt = new System.Windows.Forms.Label();
            this.puzles_krasas_txt = new System.Windows.Forms.GroupBox();
            this.krasas_pelektonu = new System.Windows.Forms.RadioButton();
            this.krasas_originalas = new System.Windows.Forms.RadioButton();
            this.puzles_veids_txt = new System.Windows.Forms.GroupBox();
            this.veids_piecpadsmit = new System.Windows.Forms.RadioButton();
            this.veids_parasta = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.rindas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolonnas)).BeginInit();
            this.puzles_krasas_txt.SuspendLayout();
            this.puzles_veids_txt.SuspendLayout();
            this.SuspendLayout();
            // 
            // sakt_speli
            // 
            this.sakt_speli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sakt_speli.Location = new System.Drawing.Point(12, 178);
            this.sakt_speli.Name = "sakt_speli";
            this.sakt_speli.Size = new System.Drawing.Size(205, 23);
            this.sakt_speli.TabIndex = 5;
            this.sakt_speli.Text = "Sākt spēli";
            this.sakt_speli.UseVisualStyleBackColor = true;
            this.sakt_speli.Click += new System.EventHandler(this.sakt_speli_Click);
            // 
            // rindas
            // 
            this.rindas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rindas.Location = new System.Drawing.Point(167, 12);
            this.rindas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.rindas.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rindas.Name = "rindas";
            this.rindas.Size = new System.Drawing.Size(50, 20);
            this.rindas.TabIndex = 1;
            this.rindas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rindas.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // kolonnas
            // 
            this.kolonnas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kolonnas.Location = new System.Drawing.Point(167, 38);
            this.kolonnas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.kolonnas.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.kolonnas.Name = "kolonnas";
            this.kolonnas.Size = new System.Drawing.Size(50, 20);
            this.kolonnas.TabIndex = 2;
            this.kolonnas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kolonnas.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // rindas_txt
            // 
            this.rindas_txt.AutoSize = true;
            this.rindas_txt.Location = new System.Drawing.Point(9, 14);
            this.rindas_txt.Name = "rindas_txt";
            this.rindas_txt.Size = new System.Drawing.Size(68, 13);
            this.rindas_txt.TabIndex = 1;
            this.rindas_txt.Text = "Rindu skaits:";
            // 
            // kolonnas_txt
            // 
            this.kolonnas_txt.AutoSize = true;
            this.kolonnas_txt.Location = new System.Drawing.Point(9, 40);
            this.kolonnas_txt.Name = "kolonnas_txt";
            this.kolonnas_txt.Size = new System.Drawing.Size(79, 13);
            this.kolonnas_txt.TabIndex = 2;
            this.kolonnas_txt.Text = "Kolonnu skaits:";
            // 
            // puzles_krasas_txt
            // 
            this.puzles_krasas_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.puzles_krasas_txt.Controls.Add(this.krasas_pelektonu);
            this.puzles_krasas_txt.Controls.Add(this.krasas_originalas);
            this.puzles_krasas_txt.Location = new System.Drawing.Point(12, 122);
            this.puzles_krasas_txt.Name = "puzles_krasas_txt";
            this.puzles_krasas_txt.Size = new System.Drawing.Size(205, 50);
            this.puzles_krasas_txt.TabIndex = 4;
            this.puzles_krasas_txt.TabStop = false;
            this.puzles_krasas_txt.Text = "Puzles krāsas:";
            // 
            // krasas_pelektonu
            // 
            this.krasas_pelektonu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.krasas_pelektonu.AutoSize = true;
            this.krasas_pelektonu.Location = new System.Drawing.Point(126, 19);
            this.krasas_pelektonu.Name = "krasas_pelektonu";
            this.krasas_pelektonu.Size = new System.Drawing.Size(73, 17);
            this.krasas_pelektonu.TabIndex = 1;
            this.krasas_pelektonu.TabStop = true;
            this.krasas_pelektonu.Text = "Pelēktoņu";
            this.krasas_pelektonu.UseVisualStyleBackColor = true;
            // 
            // krasas_originalas
            // 
            this.krasas_originalas.AutoSize = true;
            this.krasas_originalas.Checked = true;
            this.krasas_originalas.Location = new System.Drawing.Point(6, 19);
            this.krasas_originalas.Name = "krasas_originalas";
            this.krasas_originalas.Size = new System.Drawing.Size(71, 17);
            this.krasas_originalas.TabIndex = 0;
            this.krasas_originalas.TabStop = true;
            this.krasas_originalas.Text = "Oriģinālās";
            this.krasas_originalas.UseVisualStyleBackColor = true;
            // 
            // puzles_veids_txt
            // 
            this.puzles_veids_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.puzles_veids_txt.Controls.Add(this.veids_piecpadsmit);
            this.puzles_veids_txt.Controls.Add(this.veids_parasta);
            this.puzles_veids_txt.Location = new System.Drawing.Point(12, 64);
            this.puzles_veids_txt.Name = "puzles_veids_txt";
            this.puzles_veids_txt.Size = new System.Drawing.Size(205, 50);
            this.puzles_veids_txt.TabIndex = 3;
            this.puzles_veids_txt.TabStop = false;
            this.puzles_veids_txt.Text = "Puzles veids:";
            // 
            // veids_piecpadsmit
            // 
            this.veids_piecpadsmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.veids_piecpadsmit.AutoSize = true;
            this.veids_piecpadsmit.Location = new System.Drawing.Point(117, 19);
            this.veids_piecpadsmit.Name = "veids_piecpadsmit";
            this.veids_piecpadsmit.Size = new System.Drawing.Size(82, 17);
            this.veids_piecpadsmit.TabIndex = 1;
            this.veids_piecpadsmit.TabStop = true;
            this.veids_piecpadsmit.Text = "Piecpadsmit";
            this.veids_piecpadsmit.UseVisualStyleBackColor = true;
            // 
            // veids_parasta
            // 
            this.veids_parasta.AutoSize = true;
            this.veids_parasta.Checked = true;
            this.veids_parasta.Location = new System.Drawing.Point(6, 19);
            this.veids_parasta.Name = "veids_parasta";
            this.veids_parasta.Size = new System.Drawing.Size(61, 17);
            this.veids_parasta.TabIndex = 0;
            this.veids_parasta.TabStop = true;
            this.veids_parasta.Text = "Parastā";
            this.veids_parasta.UseVisualStyleBackColor = true;
            // 
            // jaunas_speles_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 213);
            this.Controls.Add(this.puzles_veids_txt);
            this.Controls.Add(this.puzles_krasas_txt);
            this.Controls.Add(this.kolonnas_txt);
            this.Controls.Add(this.rindas_txt);
            this.Controls.Add(this.kolonnas);
            this.Controls.Add(this.rindas);
            this.Controls.Add(this.sakt_speli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "jaunas_speles_forma";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jauna spēle...";
            ((System.ComponentModel.ISupportInitialize)(this.rindas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolonnas)).EndInit();
            this.puzles_krasas_txt.ResumeLayout(false);
            this.puzles_krasas_txt.PerformLayout();
            this.puzles_veids_txt.ResumeLayout(false);
            this.puzles_veids_txt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sakt_speli;
        private System.Windows.Forms.NumericUpDown rindas;
        private System.Windows.Forms.NumericUpDown kolonnas;
        private System.Windows.Forms.Label rindas_txt;
        private System.Windows.Forms.Label kolonnas_txt;
        private System.Windows.Forms.GroupBox puzles_krasas_txt;
        private System.Windows.Forms.RadioButton krasas_pelektonu;
        private System.Windows.Forms.RadioButton krasas_originalas;
        private System.Windows.Forms.GroupBox puzles_veids_txt;
        private System.Windows.Forms.RadioButton veids_piecpadsmit;
        private System.Windows.Forms.RadioButton veids_parasta;
    }
}
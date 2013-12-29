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
            this.speles_veids_txt = new System.Windows.Forms.GroupBox();
            this.spele_parasta = new System.Windows.Forms.RadioButton();
            this.spele_pelektonu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.rindas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolonnas)).BeginInit();
            this.speles_veids_txt.SuspendLayout();
            this.SuspendLayout();
            // 
            // sakt_speli
            // 
            this.sakt_speli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sakt_speli.Location = new System.Drawing.Point(12, 171);
            this.sakt_speli.Name = "sakt_speli";
            this.sakt_speli.Size = new System.Drawing.Size(169, 23);
            this.sakt_speli.TabIndex = 0;
            this.sakt_speli.Text = "Sākt spēli";
            this.sakt_speli.UseVisualStyleBackColor = true;
            this.sakt_speli.Click += new System.EventHandler(this.sakt_speli_Click);
            // 
            // rindas
            // 
            this.rindas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rindas.Location = new System.Drawing.Point(131, 12);
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
            this.kolonnas.Location = new System.Drawing.Point(131, 38);
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
            this.rindas_txt.TabIndex = 3;
            this.rindas_txt.Text = "Rindu skaits:";
            // 
            // kolonnas_txt
            // 
            this.kolonnas_txt.AutoSize = true;
            this.kolonnas_txt.Location = new System.Drawing.Point(9, 40);
            this.kolonnas_txt.Name = "kolonnas_txt";
            this.kolonnas_txt.Size = new System.Drawing.Size(79, 13);
            this.kolonnas_txt.TabIndex = 4;
            this.kolonnas_txt.Text = "Kolonnu skaits:";
            // 
            // speles_veids_txt
            // 
            this.speles_veids_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speles_veids_txt.Controls.Add(this.spele_pelektonu);
            this.speles_veids_txt.Controls.Add(this.spele_parasta);
            this.speles_veids_txt.Location = new System.Drawing.Point(12, 64);
            this.speles_veids_txt.Name = "speles_veids_txt";
            this.speles_veids_txt.Size = new System.Drawing.Size(169, 101);
            this.speles_veids_txt.TabIndex = 5;
            this.speles_veids_txt.TabStop = false;
            this.speles_veids_txt.Text = "Spēles veids:";
            // 
            // spele_parasta
            // 
            this.spele_parasta.AutoSize = true;
            this.spele_parasta.Checked = true;
            this.spele_parasta.Location = new System.Drawing.Point(7, 20);
            this.spele_parasta.Name = "spele_parasta";
            this.spele_parasta.Size = new System.Drawing.Size(61, 17);
            this.spele_parasta.TabIndex = 0;
            this.spele_parasta.TabStop = true;
            this.spele_parasta.Text = "Parastā";
            this.spele_parasta.UseVisualStyleBackColor = true;
            // 
            // spele_pelektonu
            // 
            this.spele_pelektonu.AutoSize = true;
            this.spele_pelektonu.Location = new System.Drawing.Point(7, 44);
            this.spele_pelektonu.Name = "spele_pelektonu";
            this.spele_pelektonu.Size = new System.Drawing.Size(73, 17);
            this.spele_pelektonu.TabIndex = 1;
            this.spele_pelektonu.TabStop = true;
            this.spele_pelektonu.Text = "Pelēktoņu";
            this.spele_pelektonu.UseVisualStyleBackColor = true;
            // 
            // jaunas_speles_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 206);
            this.Controls.Add(this.speles_veids_txt);
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
            this.speles_veids_txt.ResumeLayout(false);
            this.speles_veids_txt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sakt_speli;
        private System.Windows.Forms.NumericUpDown rindas;
        private System.Windows.Forms.NumericUpDown kolonnas;
        private System.Windows.Forms.Label rindas_txt;
        private System.Windows.Forms.Label kolonnas_txt;
        private System.Windows.Forms.GroupBox speles_veids_txt;
        private System.Windows.Forms.RadioButton spele_pelektonu;
        private System.Windows.Forms.RadioButton spele_parasta;
    }
}
namespace puzlicis
{
    partial class rezultatu_forma
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
            this.components = new System.ComponentModel.Container();
            this.grafiks = new ZedGraph.ZedGraphControl();
            this.visas = new System.Windows.Forms.CheckBox();
            this.veids = new System.Windows.Forms.GroupBox();
            this.piecpadsmit = new System.Windows.Forms.RadioButton();
            this.parastas = new System.Windows.Forms.RadioButton();
            this.rezultati_txt = new System.Windows.Forms.Label();
            this.krasa = new System.Windows.Forms.GroupBox();
            this.pelektonu = new System.Windows.Forms.RadioButton();
            this.originalas = new System.Windows.Forms.RadioButton();
            this.veids.SuspendLayout();
            this.krasa.SuspendLayout();
            this.SuspendLayout();
            // 
            // grafiks
            // 
            this.grafiks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grafiks.IsEnableHPan = false;
            this.grafiks.IsEnableVPan = false;
            this.grafiks.IsShowCopyMessage = false;
            this.grafiks.IsShowPointValues = true;
            this.grafiks.Location = new System.Drawing.Point(0, 59);
            this.grafiks.Name = "grafiks";
            this.grafiks.ScrollGrace = 0D;
            this.grafiks.ScrollMaxX = 0D;
            this.grafiks.ScrollMaxY = 0D;
            this.grafiks.ScrollMaxY2 = 0D;
            this.grafiks.ScrollMinX = 0D;
            this.grafiks.ScrollMinY = 0D;
            this.grafiks.ScrollMinY2 = 0D;
            this.grafiks.Size = new System.Drawing.Size(594, 369);
            this.grafiks.TabIndex = 0;
            // 
            // visas
            // 
            this.visas.AutoSize = true;
            this.visas.Checked = true;
            this.visas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.visas.Location = new System.Drawing.Point(12, 36);
            this.visas.Name = "visas";
            this.visas.Size = new System.Drawing.Size(84, 17);
            this.visas.TabIndex = 0;
            this.visas.Text = "Visas spēles";
            this.visas.UseVisualStyleBackColor = true;
            this.visas.CheckedChanged += new System.EventHandler(this.visas_CheckedChanged);
            // 
            // veids
            // 
            this.veids.Controls.Add(this.piecpadsmit);
            this.veids.Controls.Add(this.parastas);
            this.veids.Enabled = false;
            this.veids.Location = new System.Drawing.Point(121, 12);
            this.veids.Name = "veids";
            this.veids.Size = new System.Drawing.Size(225, 41);
            this.veids.TabIndex = 1;
            this.veids.TabStop = false;
            this.veids.Text = "Veids:";
            // 
            // piecpadsmit
            // 
            this.piecpadsmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.piecpadsmit.AutoSize = true;
            this.piecpadsmit.Location = new System.Drawing.Point(137, 18);
            this.piecpadsmit.Name = "piecpadsmit";
            this.piecpadsmit.Size = new System.Drawing.Size(82, 17);
            this.piecpadsmit.TabIndex = 1;
            this.piecpadsmit.TabStop = true;
            this.piecpadsmit.Text = "Pie&cpadsmit";
            this.piecpadsmit.UseVisualStyleBackColor = true;
            this.piecpadsmit.CheckedChanged += new System.EventHandler(this.piecpadsmit_CheckedChanged);
            // 
            // parastas
            // 
            this.parastas.AutoSize = true;
            this.parastas.Checked = true;
            this.parastas.Location = new System.Drawing.Point(6, 18);
            this.parastas.Name = "parastas";
            this.parastas.Size = new System.Drawing.Size(66, 17);
            this.parastas.TabIndex = 0;
            this.parastas.TabStop = true;
            this.parastas.Text = "&Parastās";
            this.parastas.UseVisualStyleBackColor = true;
            this.parastas.CheckedChanged += new System.EventHandler(this.parastas_CheckedChanged);
            // 
            // rezultati_txt
            // 
            this.rezultati_txt.AutoSize = true;
            this.rezultati_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.rezultati_txt.Location = new System.Drawing.Point(9, 12);
            this.rezultati_txt.Name = "rezultati_txt";
            this.rezultati_txt.Size = new System.Drawing.Size(106, 13);
            this.rezultati_txt.TabIndex = 0;
            this.rezultati_txt.Text = "Atlasīt rezultātus:";
            // 
            // krasa
            // 
            this.krasa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.krasa.Controls.Add(this.pelektonu);
            this.krasa.Controls.Add(this.originalas);
            this.krasa.Enabled = false;
            this.krasa.Location = new System.Drawing.Point(357, 12);
            this.krasa.Name = "krasa";
            this.krasa.Size = new System.Drawing.Size(225, 41);
            this.krasa.TabIndex = 2;
            this.krasa.TabStop = false;
            this.krasa.Text = "Krāsa:";
            // 
            // pelektonu
            // 
            this.pelektonu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pelektonu.AutoSize = true;
            this.pelektonu.Location = new System.Drawing.Point(136, 18);
            this.pelektonu.Name = "pelektonu";
            this.pelektonu.Size = new System.Drawing.Size(73, 17);
            this.pelektonu.TabIndex = 1;
            this.pelektonu.TabStop = true;
            this.pelektonu.Text = "Pe&lēktoņu";
            this.pelektonu.UseVisualStyleBackColor = true;
            this.pelektonu.CheckedChanged += new System.EventHandler(this.pelektonu_CheckedChanged);
            // 
            // originalas
            // 
            this.originalas.AutoSize = true;
            this.originalas.Checked = true;
            this.originalas.Location = new System.Drawing.Point(6, 18);
            this.originalas.Name = "originalas";
            this.originalas.Size = new System.Drawing.Size(71, 17);
            this.originalas.TabIndex = 0;
            this.originalas.TabStop = true;
            this.originalas.Text = "&Oriģinālās";
            this.originalas.UseVisualStyleBackColor = true;
            this.originalas.CheckedChanged += new System.EventHandler(this.originalas_CheckedChanged);
            // 
            // rezultatu_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 428);
            this.Controls.Add(this.krasa);
            this.Controls.Add(this.rezultati_txt);
            this.Controls.Add(this.veids);
            this.Controls.Add(this.visas);
            this.Controls.Add(this.grafiks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "rezultatu_forma";
            this.ShowInTaskbar = false;
            this.Text = "Rezultāti";
            this.veids.ResumeLayout(false);
            this.veids.PerformLayout();
            this.krasa.ResumeLayout(false);
            this.krasa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl grafiks;
        private System.Windows.Forms.CheckBox visas;
        private System.Windows.Forms.GroupBox veids;
        private System.Windows.Forms.Label rezultati_txt;
        private System.Windows.Forms.GroupBox krasa;
        private System.Windows.Forms.RadioButton parastas;
        private System.Windows.Forms.RadioButton piecpadsmit;
        private System.Windows.Forms.RadioButton originalas;
        private System.Windows.Forms.RadioButton pelektonu;
    }
}
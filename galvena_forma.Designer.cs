namespace puzlicis
{
    partial class galvena_forma
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
            this.statusa_josla = new System.Windows.Forms.StatusStrip();
            this.izvelne = new System.Windows.Forms.MenuStrip();
            this.spēleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jaunaSpēleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rīkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attēlaPriekšskatījumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palīdzībaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taimeris = new System.Windows.Forms.Timer(this.components);
            this.panelis_spele = new System.Windows.Forms.Panel();
            this.prieksskatijums = new System.Windows.Forms.Panel();
            this.radit_rezgi = new System.Windows.Forms.CheckBox();
            this.izvelne.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusa_josla
            // 
            this.statusa_josla.Location = new System.Drawing.Point(0, 390);
            this.statusa_josla.Name = "statusa_josla";
            this.statusa_josla.Size = new System.Drawing.Size(734, 22);
            this.statusa_josla.TabIndex = 0;
            this.statusa_josla.Text = "Statusa josla";
            // 
            // izvelne
            // 
            this.izvelne.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spēleToolStripMenuItem,
            this.rīkiToolStripMenuItem,
            this.palīdzībaToolStripMenuItem});
            this.izvelne.Location = new System.Drawing.Point(0, 0);
            this.izvelne.Name = "izvelne";
            this.izvelne.Size = new System.Drawing.Size(734, 24);
            this.izvelne.TabIndex = 1;
            this.izvelne.Text = "Izvēlne";
            // 
            // spēleToolStripMenuItem
            // 
            this.spēleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jaunaSpēleToolStripMenuItem,
            this.izietToolStripMenuItem});
            this.spēleToolStripMenuItem.Name = "spēleToolStripMenuItem";
            this.spēleToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.spēleToolStripMenuItem.Text = "&Spēle";
            // 
            // jaunaSpēleToolStripMenuItem
            // 
            this.jaunaSpēleToolStripMenuItem.Name = "jaunaSpēleToolStripMenuItem";
            this.jaunaSpēleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.jaunaSpēleToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.jaunaSpēleToolStripMenuItem.Text = "&Jauna spēle...";
            this.jaunaSpēleToolStripMenuItem.Click += new System.EventHandler(this.jaunaSpēleToolStripMenuItem_Click);
            // 
            // izietToolStripMenuItem
            // 
            this.izietToolStripMenuItem.Name = "izietToolStripMenuItem";
            this.izietToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.izietToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.izietToolStripMenuItem.Text = "&Iziet";
            this.izietToolStripMenuItem.Click += new System.EventHandler(this.izietToolStripMenuItem_Click);
            // 
            // rīkiToolStripMenuItem
            // 
            this.rīkiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attēlaPriekšskatījumsToolStripMenuItem});
            this.rīkiToolStripMenuItem.Name = "rīkiToolStripMenuItem";
            this.rīkiToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.rīkiToolStripMenuItem.Text = "&Rīki";
            // 
            // attēlaPriekšskatījumsToolStripMenuItem
            // 
            this.attēlaPriekšskatījumsToolStripMenuItem.Enabled = false;
            this.attēlaPriekšskatījumsToolStripMenuItem.Name = "attēlaPriekšskatījumsToolStripMenuItem";
            this.attēlaPriekšskatījumsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.attēlaPriekšskatījumsToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.attēlaPriekšskatījumsToolStripMenuItem.Text = "A&ttēla priekšskatījums";
            this.attēlaPriekšskatījumsToolStripMenuItem.Click += new System.EventHandler(this.attēlaPriekšskatījumsToolStripMenuItem_Click);
            // 
            // palīdzībaToolStripMenuItem
            // 
            this.palīdzībaToolStripMenuItem.Name = "palīdzībaToolStripMenuItem";
            this.palīdzībaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.palīdzībaToolStripMenuItem.Text = "&Palīdzība";
            // 
            // taimeris
            // 
            this.taimeris.Interval = 1000;
            // 
            // panelis_spele
            // 
            this.panelis_spele.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelis_spele.Location = new System.Drawing.Point(12, 27);
            this.panelis_spele.Name = "panelis_spele";
            this.panelis_spele.Size = new System.Drawing.Size(480, 360);
            this.panelis_spele.TabIndex = 5;
            this.panelis_spele.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelis_spele_MouseClick);
            this.panelis_spele.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelis_spele_MouseMove);
            // 
            // prieksskatijums
            // 
            this.prieksskatijums.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prieksskatijums.Location = new System.Drawing.Point(522, 27);
            this.prieksskatijums.Name = "prieksskatijums";
            this.prieksskatijums.Size = new System.Drawing.Size(200, 150);
            this.prieksskatijums.TabIndex = 6;
            this.prieksskatijums.Click += new System.EventHandler(this.prieksskatijums_Click);
            // 
            // radit_rezgi
            // 
            this.radit_rezgi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radit_rezgi.AutoSize = true;
            this.radit_rezgi.Checked = true;
            this.radit_rezgi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radit_rezgi.Location = new System.Drawing.Point(522, 183);
            this.radit_rezgi.Name = "radit_rezgi";
            this.radit_rezgi.Size = new System.Drawing.Size(110, 17);
            this.radit_rezgi.TabIndex = 7;
            this.radit_rezgi.Text = "Rādīt režģa līnijas";
            this.radit_rezgi.UseVisualStyleBackColor = true;
            this.radit_rezgi.Visible = false;
            this.radit_rezgi.CheckedChanged += new System.EventHandler(this.radit_rezgi_CheckedChanged);
            // 
            // galvena_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 412);
            this.Controls.Add(this.radit_rezgi);
            this.Controls.Add(this.prieksskatijums);
            this.Controls.Add(this.panelis_spele);
            this.Controls.Add(this.statusa_josla);
            this.Controls.Add(this.izvelne);
            this.MainMenuStrip = this.izvelne;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "galvena_forma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzlicis";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.galvena_forma_Paint);
            this.izvelne.ResumeLayout(false);
            this.izvelne.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusa_josla;
        private System.Windows.Forms.MenuStrip izvelne;
        private System.Windows.Forms.Timer taimeris;
        private System.Windows.Forms.Panel panelis_spele;
        private System.Windows.Forms.Panel prieksskatijums;
        private System.Windows.Forms.CheckBox radit_rezgi;
        private System.Windows.Forms.ToolStripMenuItem spēleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rīkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palīdzībaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jaunaSpēleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izietToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attēlaPriekšskatījumsToolStripMenuItem;
    }
}
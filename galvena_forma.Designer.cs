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
            this.statuss_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.gajieni_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.laiks_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.izvelne = new System.Windows.Forms.MenuStrip();
            this.spēleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jaunaSpēleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attēlaPriekšskatījumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rīkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iestatījumiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palīdzībaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taimeris = new System.Windows.Forms.Timer(this.components);
            this.panelis_spele = new System.Windows.Forms.Panel();
            this.prieksskatijums = new System.Windows.Forms.Panel();
            this.radit_rezgi = new System.Windows.Forms.CheckBox();
            this.radit_indeksus = new System.Windows.Forms.CheckBox();
            this.ieprieksejais = new System.Windows.Forms.Button();
            this.nakamais = new System.Windows.Forms.Button();
            this.pārlādētPuzlesAttēluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusa_josla.SuspendLayout();
            this.izvelne.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusa_josla
            // 
            this.statusa_josla.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuss_txt,
            this.gajieni_txt,
            this.laiks_txt});
            this.statusa_josla.Location = new System.Drawing.Point(0, 390);
            this.statusa_josla.Name = "statusa_josla";
            this.statusa_josla.Size = new System.Drawing.Size(734, 22);
            this.statusa_josla.TabIndex = 0;
            this.statusa_josla.Text = "Statusa josla";
            // 
            // statuss_txt
            // 
            this.statuss_txt.Name = "statuss_txt";
            this.statuss_txt.Size = new System.Drawing.Size(223, 17);
            this.statuss_txt.Text = "Lai sāktu jaunu spēli: Spēle -> Jauna spēle...";
            // 
            // gajieni_txt
            // 
            this.gajieni_txt.Name = "gajieni_txt";
            this.gajieni_txt.Size = new System.Drawing.Size(52, 17);
            this.gajieni_txt.Text = "Gājieni: 0";
            this.gajieni_txt.Visible = false;
            // 
            // laiks_txt
            // 
            this.laiks_txt.Name = "laiks_txt";
            this.laiks_txt.Size = new System.Drawing.Size(59, 17);
            this.laiks_txt.Text = "Laiks: 0:00";
            this.laiks_txt.Visible = false;
            // 
            // izvelne
            // 
            this.izvelne.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spēleToolStripMenuItem,
            this.skatsToolStripMenuItem,
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
            this.spēleToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.spēleToolStripMenuItem.Text = "&Spēle";
            // 
            // jaunaSpēleToolStripMenuItem
            // 
            this.jaunaSpēleToolStripMenuItem.Name = "jaunaSpēleToolStripMenuItem";
            this.jaunaSpēleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.jaunaSpēleToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.jaunaSpēleToolStripMenuItem.Text = "&Jauna spēle...";
            this.jaunaSpēleToolStripMenuItem.Click += new System.EventHandler(this.jaunaSpēleToolStripMenuItem_Click);
            // 
            // izietToolStripMenuItem
            // 
            this.izietToolStripMenuItem.Name = "izietToolStripMenuItem";
            this.izietToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.izietToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.izietToolStripMenuItem.Text = "&Iziet";
            this.izietToolStripMenuItem.Click += new System.EventHandler(this.izietToolStripMenuItem_Click);
            // 
            // skatsToolStripMenuItem
            // 
            this.skatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attēlaPriekšskatījumsToolStripMenuItem,
            this.pārlādētPuzlesAttēluToolStripMenuItem});
            this.skatsToolStripMenuItem.Name = "skatsToolStripMenuItem";
            this.skatsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.skatsToolStripMenuItem.Text = "S&kats";
            // 
            // attēlaPriekšskatījumsToolStripMenuItem
            // 
            this.attēlaPriekšskatījumsToolStripMenuItem.Enabled = false;
            this.attēlaPriekšskatījumsToolStripMenuItem.Name = "attēlaPriekšskatījumsToolStripMenuItem";
            this.attēlaPriekšskatījumsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.attēlaPriekšskatījumsToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.attēlaPriekšskatījumsToolStripMenuItem.Text = "A&ttēla priekšskatījums";
            this.attēlaPriekšskatījumsToolStripMenuItem.Click += new System.EventHandler(this.attēlaPriekšskatījumsToolStripMenuItem_Click);
            // 
            // rīkiToolStripMenuItem
            // 
            this.rīkiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iestatījumiToolStripMenuItem});
            this.rīkiToolStripMenuItem.Name = "rīkiToolStripMenuItem";
            this.rīkiToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.rīkiToolStripMenuItem.Text = "&Rīki";
            // 
            // iestatījumiToolStripMenuItem
            // 
            this.iestatījumiToolStripMenuItem.Name = "iestatījumiToolStripMenuItem";
            this.iestatījumiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.iestatījumiToolStripMenuItem.Text = "&Iestatījumi...";
            // 
            // palīdzībaToolStripMenuItem
            // 
            this.palīdzībaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parToolStripMenuItem});
            this.palīdzībaToolStripMenuItem.Name = "palīdzībaToolStripMenuItem";
            this.palīdzībaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.palīdzībaToolStripMenuItem.Text = "&Palīdzība";
            // 
            // parToolStripMenuItem
            // 
            this.parToolStripMenuItem.Name = "parToolStripMenuItem";
            this.parToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.parToolStripMenuItem.Text = "P&ar...";
            this.parToolStripMenuItem.Click += new System.EventHandler(this.parToolStripMenuItem_Click);
            // 
            // taimeris
            // 
            this.taimeris.Interval = 1000;
            this.taimeris.Tick += new System.EventHandler(this.taimeris_Tick);
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
            this.panelis_spele.Paint += new System.Windows.Forms.PaintEventHandler(this.panelis_spele_Paint);
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
            this.radit_rezgi.Size = new System.Drawing.Size(186, 17);
            this.radit_rezgi.TabIndex = 7;
            this.radit_rezgi.Text = "Rādīt spēles laukuma režģa līnijas";
            this.radit_rezgi.UseVisualStyleBackColor = true;
            this.radit_rezgi.Visible = false;
            this.radit_rezgi.CheckedChanged += new System.EventHandler(this.radit_rezgi_CheckedChanged);
            // 
            // radit_indeksus
            // 
            this.radit_indeksus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radit_indeksus.AutoSize = true;
            this.radit_indeksus.Location = new System.Drawing.Point(522, 206);
            this.radit_indeksus.Name = "radit_indeksus";
            this.radit_indeksus.Size = new System.Drawing.Size(173, 17);
            this.radit_indeksus.TabIndex = 8;
            this.radit_indeksus.Text = "Rādīt puzles gabaliņu indeksus";
            this.radit_indeksus.UseVisualStyleBackColor = true;
            this.radit_indeksus.Visible = false;
            this.radit_indeksus.CheckedChanged += new System.EventHandler(this.radit_indeksus_CheckedChanged);
            // 
            // ieprieksejais
            // 
            this.ieprieksejais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ieprieksejais.Location = new System.Drawing.Point(522, 362);
            this.ieprieksejais.Name = "ieprieksejais";
            this.ieprieksejais.Size = new System.Drawing.Size(90, 25);
            this.ieprieksejais.TabIndex = 9;
            this.ieprieksejais.Text = "<<";
            this.ieprieksejais.UseVisualStyleBackColor = true;
            this.ieprieksejais.Visible = false;
            this.ieprieksejais.Click += new System.EventHandler(this.ieprieksejais_Click);
            // 
            // nakamais
            // 
            this.nakamais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nakamais.Location = new System.Drawing.Point(632, 362);
            this.nakamais.Name = "nakamais";
            this.nakamais.Size = new System.Drawing.Size(90, 25);
            this.nakamais.TabIndex = 10;
            this.nakamais.Text = ">>";
            this.nakamais.UseVisualStyleBackColor = true;
            this.nakamais.Visible = false;
            this.nakamais.Click += new System.EventHandler(this.nakamais_Click);
            // 
            // pārlādētPuzlesAttēluToolStripMenuItem
            // 
            this.pārlādētPuzlesAttēluToolStripMenuItem.Enabled = false;
            this.pārlādētPuzlesAttēluToolStripMenuItem.Name = "pārlādētPuzlesAttēluToolStripMenuItem";
            this.pārlādētPuzlesAttēluToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.pārlādētPuzlesAttēluToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.pārlādētPuzlesAttēluToolStripMenuItem.Text = "Pār&lādēt puzles attēlu";
            this.pārlādētPuzlesAttēluToolStripMenuItem.Click += new System.EventHandler(this.pārlādētPuzlesAttēluToolStripMenuItem_Click);
            // 
            // galvena_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 412);
            this.Controls.Add(this.nakamais);
            this.Controls.Add(this.ieprieksejais);
            this.Controls.Add(this.radit_indeksus);
            this.Controls.Add(this.radit_rezgi);
            this.Controls.Add(this.prieksskatijums);
            this.Controls.Add(this.panelis_spele);
            this.Controls.Add(this.statusa_josla);
            this.Controls.Add(this.izvelne);
            this.MainMenuStrip = this.izvelne;
            this.MinimumSize = new System.Drawing.Size(600, 360);
            this.Name = "galvena_forma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzlicis";
            this.SizeChanged += new System.EventHandler(this.galvena_forma_SizeChanged);
            this.statusa_josla.ResumeLayout(false);
            this.statusa_josla.PerformLayout();
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
        private System.Windows.Forms.CheckBox radit_indeksus;
        private System.Windows.Forms.Button ieprieksejais;
        private System.Windows.Forms.Button nakamais;
        private System.Windows.Forms.ToolStripStatusLabel statuss_txt;
        private System.Windows.Forms.ToolStripStatusLabel gajieni_txt;
        private System.Windows.Forms.ToolStripStatusLabel laiks_txt;
        private System.Windows.Forms.ToolStripMenuItem skatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attēlaPriekšskatījumsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iestatījumiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pārlādētPuzlesAttēluToolStripMenuItem;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(galvena_forma));
            this.statusa_josla = new System.Windows.Forms.StatusStrip();
            this.statuss_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.gajieni_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.laiks_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.indekss_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.attels_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.izvelne = new System.Windows.Forms.MenuStrip();
            this.spēleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jaunaSpēleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atvērtSpēliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saglabātSpēliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atdalitajs1 = new System.Windows.Forms.ToolStripSeparator();
            this.izietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attēlaPriekšskatījumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atdalitajs2 = new System.Windows.Forms.ToolStripSeparator();
            this.pārlādētPuzlesAttēluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pielāgotFormasIzmēruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sākotnējaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pēcAugstumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pēcPlatumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rīkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezultātiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atdalitajs3 = new System.Windows.Forms.ToolStripSeparator();
            this.iestatījumiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palīdzībaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apskatītPalīdzībuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resursiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmantotieAttēliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apskatītProgrammasPirmkoduToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sūtītAtsauksmiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atdalitajs4 = new System.Windows.Forms.ToolStripSeparator();
            this.parToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taimeris = new System.Windows.Forms.Timer(this.components);
            this.panelis_spele = new System.Windows.Forms.Panel();
            this.prieksskatijums = new System.Windows.Forms.Panel();
            this.radit_rezgi = new System.Windows.Forms.CheckBox();
            this.radit_indeksus = new System.Windows.Forms.CheckBox();
            this.ieprieksejais = new System.Windows.Forms.Button();
            this.nakamais = new System.Windows.Forms.Button();
            this.radit_prieksskatijuma_rezgi = new System.Windows.Forms.CheckBox();
            this.statusa_josla.SuspendLayout();
            this.izvelne.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusa_josla
            // 
            this.statusa_josla.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuss_txt,
            this.gajieni_txt,
            this.laiks_txt,
            this.indekss_txt,
            this.attels_txt});
            this.statusa_josla.Location = new System.Drawing.Point(0, 392);
            this.statusa_josla.Name = "statusa_josla";
            this.statusa_josla.Size = new System.Drawing.Size(727, 22);
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
            // indekss_txt
            // 
            this.indekss_txt.Name = "indekss_txt";
            this.indekss_txt.Size = new System.Drawing.Size(99, 17);
            this.indekss_txt.Text = "Gabaliņa indekss: 0";
            this.indekss_txt.Visible = false;
            // 
            // attels_txt
            // 
            this.attels_txt.Name = "attels_txt";
            this.attels_txt.Size = new System.Drawing.Size(35, 17);
            this.attels_txt.Text = "Attēls";
            this.attels_txt.Visible = false;
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
            this.izvelne.Size = new System.Drawing.Size(727, 24);
            this.izvelne.TabIndex = 0;
            this.izvelne.Text = "Izvēlne";
            // 
            // spēleToolStripMenuItem
            // 
            this.spēleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jaunaSpēleToolStripMenuItem,
            this.atvērtSpēliToolStripMenuItem,
            this.saglabātSpēliToolStripMenuItem,
            this.atdalitajs1,
            this.izietToolStripMenuItem});
            this.spēleToolStripMenuItem.Name = "spēleToolStripMenuItem";
            this.spēleToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.spēleToolStripMenuItem.Text = "&Spēle";
            // 
            // jaunaSpēleToolStripMenuItem
            // 
            this.jaunaSpēleToolStripMenuItem.Name = "jaunaSpēleToolStripMenuItem";
            this.jaunaSpēleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.jaunaSpēleToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.jaunaSpēleToolStripMenuItem.Text = "&Jauna spēle...";
            this.jaunaSpēleToolStripMenuItem.Click += new System.EventHandler(this.jaunaSpēleToolStripMenuItem_Click);
            // 
            // atvērtSpēliToolStripMenuItem
            // 
            this.atvērtSpēliToolStripMenuItem.Name = "atvērtSpēliToolStripMenuItem";
            this.atvērtSpēliToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.atvērtSpēliToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.atvērtSpēliToolStripMenuItem.Text = "&Atvērt spēli...";
            this.atvērtSpēliToolStripMenuItem.Click += new System.EventHandler(this.atvērtSpēliToolStripMenuItem_Click);
            // 
            // saglabātSpēliToolStripMenuItem
            // 
            this.saglabātSpēliToolStripMenuItem.Enabled = false;
            this.saglabātSpēliToolStripMenuItem.Name = "saglabātSpēliToolStripMenuItem";
            this.saglabātSpēliToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saglabātSpēliToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.saglabātSpēliToolStripMenuItem.Text = "Sagla&bāt spēli...";
            this.saglabātSpēliToolStripMenuItem.Click += new System.EventHandler(this.saglabātSpēliToolStripMenuItem_Click);
            // 
            // atdalitajs1
            // 
            this.atdalitajs1.Name = "atdalitajs1";
            this.atdalitajs1.Size = new System.Drawing.Size(187, 6);
            // 
            // izietToolStripMenuItem
            // 
            this.izietToolStripMenuItem.Name = "izietToolStripMenuItem";
            this.izietToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.izietToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.izietToolStripMenuItem.Text = "&Iziet";
            this.izietToolStripMenuItem.Click += new System.EventHandler(this.izietToolStripMenuItem_Click);
            // 
            // skatsToolStripMenuItem
            // 
            this.skatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attēlaPriekšskatījumsToolStripMenuItem,
            this.atdalitajs2,
            this.pārlādētPuzlesAttēluToolStripMenuItem,
            this.pielāgotFormasIzmēruToolStripMenuItem});
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
            // atdalitajs2
            // 
            this.atdalitajs2.Name = "atdalitajs2";
            this.atdalitajs2.Size = new System.Drawing.Size(214, 6);
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
            // pielāgotFormasIzmēruToolStripMenuItem
            // 
            this.pielāgotFormasIzmēruToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sākotnējaisToolStripMenuItem,
            this.pēcAugstumaToolStripMenuItem,
            this.pēcPlatumaToolStripMenuItem});
            this.pielāgotFormasIzmēruToolStripMenuItem.Name = "pielāgotFormasIzmēruToolStripMenuItem";
            this.pielāgotFormasIzmēruToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.pielāgotFormasIzmēruToolStripMenuItem.Text = "Pielāgot &formas izmēru";
            // 
            // sākotnējaisToolStripMenuItem
            // 
            this.sākotnējaisToolStripMenuItem.Name = "sākotnējaisToolStripMenuItem";
            this.sākotnējaisToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.sākotnējaisToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.sākotnējaisToolStripMenuItem.Text = "Sākotnē&jais";
            this.sākotnējaisToolStripMenuItem.Click += new System.EventHandler(this.sākotnējaisToolStripMenuItem_Click);
            // 
            // pēcAugstumaToolStripMenuItem
            // 
            this.pēcAugstumaToolStripMenuItem.Name = "pēcAugstumaToolStripMenuItem";
            this.pēcAugstumaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pēcAugstumaToolStripMenuItem.Text = "Pēc &augstuma";
            this.pēcAugstumaToolStripMenuItem.Click += new System.EventHandler(this.pēcAugstumaToolStripMenuItem_Click);
            // 
            // pēcPlatumaToolStripMenuItem
            // 
            this.pēcPlatumaToolStripMenuItem.Name = "pēcPlatumaToolStripMenuItem";
            this.pēcPlatumaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pēcPlatumaToolStripMenuItem.Text = "Pēc &platuma";
            this.pēcPlatumaToolStripMenuItem.Click += new System.EventHandler(this.pēcPlatumaToolStripMenuItem_Click);
            // 
            // rīkiToolStripMenuItem
            // 
            this.rīkiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezultātiToolStripMenuItem,
            this.atdalitajs3,
            this.iestatījumiToolStripMenuItem});
            this.rīkiToolStripMenuItem.Name = "rīkiToolStripMenuItem";
            this.rīkiToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.rīkiToolStripMenuItem.Text = "&Rīki";
            // 
            // rezultātiToolStripMenuItem
            // 
            this.rezultātiToolStripMenuItem.Name = "rezultātiToolStripMenuItem";
            this.rezultātiToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.rezultātiToolStripMenuItem.Text = "R&ezultāti";
            this.rezultātiToolStripMenuItem.Click += new System.EventHandler(this.rezultātiToolStripMenuItem_Click);
            // 
            // atdalitajs3
            // 
            this.atdalitajs3.Name = "atdalitajs3";
            this.atdalitajs3.Size = new System.Drawing.Size(133, 6);
            // 
            // iestatījumiToolStripMenuItem
            // 
            this.iestatījumiToolStripMenuItem.Name = "iestatījumiToolStripMenuItem";
            this.iestatījumiToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.iestatījumiToolStripMenuItem.Text = "&Iestatījumi...";
            this.iestatījumiToolStripMenuItem.Click += new System.EventHandler(this.iestatījumiToolStripMenuItem_Click);
            // 
            // palīdzībaToolStripMenuItem
            // 
            this.palīdzībaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apskatītPalīdzībuToolStripMenuItem,
            this.resursiToolStripMenuItem,
            this.atdalitajs4,
            this.parToolStripMenuItem});
            this.palīdzībaToolStripMenuItem.Name = "palīdzībaToolStripMenuItem";
            this.palīdzībaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.palīdzībaToolStripMenuItem.Text = "&Palīdzība";
            // 
            // apskatītPalīdzībuToolStripMenuItem
            // 
            this.apskatītPalīdzībuToolStripMenuItem.Name = "apskatītPalīdzībuToolStripMenuItem";
            this.apskatītPalīdzībuToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.apskatītPalīdzībuToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.apskatītPalīdzībuToolStripMenuItem.Text = "S&katīt palīdzību";
            this.apskatītPalīdzībuToolStripMenuItem.Click += new System.EventHandler(this.apskatītPalīdzībuToolStripMenuItem_Click);
            // 
            // resursiToolStripMenuItem
            // 
            this.resursiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izmantotieAttēliToolStripMenuItem,
            this.apskatītProgrammasPirmkoduToolStripMenuItem,
            this.sūtītAtsauksmiToolStripMenuItem});
            this.resursiToolStripMenuItem.Name = "resursiToolStripMenuItem";
            this.resursiToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.resursiToolStripMenuItem.Text = "&Resursi";
            // 
            // izmantotieAttēliToolStripMenuItem
            // 
            this.izmantotieAttēliToolStripMenuItem.Name = "izmantotieAttēliToolStripMenuItem";
            this.izmantotieAttēliToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.izmantotieAttēliToolStripMenuItem.Text = "I&zmantotie attēli";
            this.izmantotieAttēliToolStripMenuItem.Click += new System.EventHandler(this.izmantotieAttēliToolStripMenuItem_Click);
            // 
            // apskatītProgrammasPirmkoduToolStripMenuItem
            // 
            this.apskatītProgrammasPirmkoduToolStripMenuItem.Name = "apskatītProgrammasPirmkoduToolStripMenuItem";
            this.apskatītProgrammasPirmkoduToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.apskatītProgrammasPirmkoduToolStripMenuItem.Text = "Programmas pir&mkods";
            this.apskatītProgrammasPirmkoduToolStripMenuItem.Click += new System.EventHandler(this.apskatītProgrammasPirmkoduToolStripMenuItem_Click);
            // 
            // sūtītAtsauksmiToolStripMenuItem
            // 
            this.sūtītAtsauksmiToolStripMenuItem.Name = "sūtītAtsauksmiToolStripMenuItem";
            this.sūtītAtsauksmiToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.sūtītAtsauksmiToolStripMenuItem.Text = "&Sūtīt atsauksmi";
            this.sūtītAtsauksmiToolStripMenuItem.Click += new System.EventHandler(this.sūtītAtsauksmiToolStripMenuItem_Click);
            // 
            // atdalitajs4
            // 
            this.atdalitajs4.Name = "atdalitajs4";
            this.atdalitajs4.Size = new System.Drawing.Size(161, 6);
            // 
            // parToolStripMenuItem
            // 
            this.parToolStripMenuItem.Name = "parToolStripMenuItem";
            this.parToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
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
            this.panelis_spele.TabIndex = 0;
            this.panelis_spele.Paint += new System.Windows.Forms.PaintEventHandler(this.panelis_spele_Paint);
            this.panelis_spele.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelis_spele_MouseClick);
            this.panelis_spele.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelis_spele_MouseMove);
            // 
            // prieksskatijums
            // 
            this.prieksskatijums.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prieksskatijums.Location = new System.Drawing.Point(515, 27);
            this.prieksskatijums.Name = "prieksskatijums";
            this.prieksskatijums.Size = new System.Drawing.Size(200, 150);
            this.prieksskatijums.TabIndex = 0;
            this.prieksskatijums.Click += new System.EventHandler(this.prieksskatijums_Click);
            this.prieksskatijums.Paint += new System.Windows.Forms.PaintEventHandler(this.prieksskatijums_Paint);
            // 
            // radit_rezgi
            // 
            this.radit_rezgi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radit_rezgi.AutoSize = true;
            this.radit_rezgi.Checked = true;
            this.radit_rezgi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radit_rezgi.Location = new System.Drawing.Point(515, 183);
            this.radit_rezgi.Name = "radit_rezgi";
            this.radit_rezgi.Size = new System.Drawing.Size(186, 17);
            this.radit_rezgi.TabIndex = 1;
            this.radit_rezgi.Text = "Rādīt režģa līnijas spēles &laukumā";
            this.radit_rezgi.UseVisualStyleBackColor = true;
            this.radit_rezgi.Visible = false;
            this.radit_rezgi.CheckedChanged += new System.EventHandler(this.radit_rezgi_CheckedChanged);
            // 
            // radit_indeksus
            // 
            this.radit_indeksus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radit_indeksus.AutoSize = true;
            this.radit_indeksus.Location = new System.Drawing.Point(515, 229);
            this.radit_indeksus.Name = "radit_indeksus";
            this.radit_indeksus.Size = new System.Drawing.Size(173, 17);
            this.radit_indeksus.TabIndex = 3;
            this.radit_indeksus.Text = "Rādīt puzles &gabaliņu indeksus";
            this.radit_indeksus.UseVisualStyleBackColor = true;
            this.radit_indeksus.Visible = false;
            this.radit_indeksus.CheckedChanged += new System.EventHandler(this.radit_indeksus_CheckedChanged);
            // 
            // ieprieksejais
            // 
            this.ieprieksejais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ieprieksejais.Location = new System.Drawing.Point(515, 362);
            this.ieprieksejais.Name = "ieprieksejais";
            this.ieprieksejais.Size = new System.Drawing.Size(95, 25);
            this.ieprieksejais.TabIndex = 4;
            this.ieprieksejais.Text = "<< &Iepriekšējais";
            this.ieprieksejais.UseVisualStyleBackColor = true;
            this.ieprieksejais.Visible = false;
            this.ieprieksejais.Click += new System.EventHandler(this.ieprieksejais_Click);
            // 
            // nakamais
            // 
            this.nakamais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nakamais.Location = new System.Drawing.Point(620, 362);
            this.nakamais.Name = "nakamais";
            this.nakamais.Size = new System.Drawing.Size(95, 25);
            this.nakamais.TabIndex = 5;
            this.nakamais.Text = "&Nākamais >>";
            this.nakamais.UseVisualStyleBackColor = true;
            this.nakamais.Visible = false;
            this.nakamais.Click += new System.EventHandler(this.nakamais_Click);
            // 
            // radit_prieksskatijuma_rezgi
            // 
            this.radit_prieksskatijuma_rezgi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radit_prieksskatijuma_rezgi.AutoSize = true;
            this.radit_prieksskatijuma_rezgi.Location = new System.Drawing.Point(515, 206);
            this.radit_prieksskatijuma_rezgi.Name = "radit_prieksskatijuma_rezgi";
            this.radit_prieksskatijuma_rezgi.Size = new System.Drawing.Size(186, 17);
            this.radit_prieksskatijuma_rezgi.TabIndex = 2;
            this.radit_prieksskatijuma_rezgi.Text = "Rādīt režģa līnijas priekšska&tījumā";
            this.radit_prieksskatijuma_rezgi.UseVisualStyleBackColor = true;
            this.radit_prieksskatijuma_rezgi.Visible = false;
            this.radit_prieksskatijuma_rezgi.CheckedChanged += new System.EventHandler(this.radit_prieksskatijuma_rezgi_CheckedChanged);
            // 
            // galvena_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 414);
            this.Controls.Add(this.radit_prieksskatijuma_rezgi);
            this.Controls.Add(this.nakamais);
            this.Controls.Add(this.ieprieksejais);
            this.Controls.Add(this.radit_indeksus);
            this.Controls.Add(this.radit_rezgi);
            this.Controls.Add(this.prieksskatijums);
            this.Controls.Add(this.panelis_spele);
            this.Controls.Add(this.statusa_josla);
            this.Controls.Add(this.izvelne);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.izvelne;
            this.MinimumSize = new System.Drawing.Size(600, 360);
            this.Name = "galvena_forma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzlicis";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.galvena_forma_FormClosed);
            this.SizeChanged += new System.EventHandler(this.galvena_forma_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.galvena_forma_KeyDown);
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
        private System.Windows.Forms.ToolStripStatusLabel indekss_txt;
        private System.Windows.Forms.ToolStripStatusLabel attels_txt;
        private System.Windows.Forms.CheckBox radit_prieksskatijuma_rezgi;
        private System.Windows.Forms.ToolStripMenuItem pielāgotFormasIzmēruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sākotnējaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pēcPlatumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pēcAugstumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator atdalitajs1;
        private System.Windows.Forms.ToolStripSeparator atdalitajs2;
        private System.Windows.Forms.ToolStripSeparator atdalitajs4;
        private System.Windows.Forms.ToolStripMenuItem apskatītPalīdzībuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resursiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apskatītProgrammasPirmkoduToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmantotieAttēliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sūtītAtsauksmiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atvērtSpēliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saglabātSpēliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezultātiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator atdalitajs3;
    }
}
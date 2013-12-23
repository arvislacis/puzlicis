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
            this.taimeris = new System.Windows.Forms.Timer(this.components);
            this.panelis_spele = new System.Windows.Forms.Panel();
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
            this.izvelne.Location = new System.Drawing.Point(0, 0);
            this.izvelne.Name = "izvelne";
            this.izvelne.Size = new System.Drawing.Size(734, 24);
            this.izvelne.TabIndex = 1;
            this.izvelne.Text = "Izvēlne";
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
            // 
            // galvena_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 412);
            this.Controls.Add(this.panelis_spele);
            this.Controls.Add(this.statusa_josla);
            this.Controls.Add(this.izvelne);
            this.MainMenuStrip = this.izvelne;
            this.Name = "galvena_forma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzlicis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusa_josla;
        private System.Windows.Forms.MenuStrip izvelne;
        private System.Windows.Forms.Timer taimeris;
        private System.Windows.Forms.Panel panelis_spele;
    }
}


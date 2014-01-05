using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace puzlicis
{
    public partial class iestatijumu_forma : Form
    {
        /// <summary>
        /// Nomaina komponentes krāsu atkarībā no lietotāja izvēles.
        /// </summary>
        /// <param name="cilne">Cilnes identifikators, nosaukums.</param>
        /// <param name="komponente">Komponentes identifikators, nosaukums.</param>
        public void krasas_izvele(string cilne, string komponente)
        {
            ColorDialog kd = new ColorDialog();

            if (kd.ShowDialog() == DialogResult.OK)
            {
                this.Controls["cilnes"].Controls[cilne].Controls[komponente].BackColor = kd.Color;
            }
        }

        public iestatijumu_forma()
        {
            InitializeComponent();

            rezga_krasa.BackColor = Properties.Settings.Default.rezga_krasa;
            aktiva_krasa.BackColor = Properties.Settings.Default.aktiva_krasa;
            iezimeta_krasa.BackColor = Properties.Settings.Default.iezimeta_krasa;
            indeksu_krasa.BackColor = Properties.Settings.Default.indeksu_krasa;
            piecpadsmit_krasa.BackColor = Properties.Settings.Default.piecpadsmit_krasa;
            fonts.Font = Properties.Settings.Default.fonts;
            jauna_spele.Checked = Properties.Settings.Default.jauna_spele;
            saglabat.Checked = Properties.Settings.Default.saglabat;
            rezultati.Checked = Properties.Settings.Default.rezultati;
        }

        private void rezga_krasa_Click(object sender, EventArgs e)
        {
            krasas_izvele("cilne_krasas", "rezga_krasa");
        }

        private void aktiva_krasa_Click(object sender, EventArgs e)
        {
            krasas_izvele("cilne_krasas", "aktiva_krasa");
        }

        private void iezimeta_krasa_Click(object sender, EventArgs e)
        {
            krasas_izvele("cilne_krasas", "iezimeta_krasa");
        }

        private void indeksu_krasa_Click(object sender, EventArgs e)
        {
            krasas_izvele("cilne_krasas", "indeksu_krasa");
        }

        private void piecpadsmit_krasa_Click(object sender, EventArgs e)
        {
            krasas_izvele("cilne_krasas", "piecpadsmit_krasa");
        }

        private void fonts_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                fonts.Font = fd.Font;
            }
        }

        private void apstiprinat_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.rezga_krasa = galvena_forma.rezga_krasa = rezga_krasa.BackColor;
            Properties.Settings.Default.aktiva_krasa = galvena_forma.aktiva_krasa = aktiva_krasa.BackColor;
            Properties.Settings.Default.iezimeta_krasa = galvena_forma.iezimeta_krasa = iezimeta_krasa.BackColor;
            Properties.Settings.Default.indeksu_krasa = galvena_forma.indeksu_krasa = indeksu_krasa.BackColor;
            Properties.Settings.Default.piecpadsmit_krasa = galvena_forma.piecpadsmit_krasa = piecpadsmit_krasa.BackColor;
            Properties.Settings.Default.fonts = galvena_forma.fonts = fonts.Font;
            Properties.Settings.Default.jauna_spele = galvena_forma.p_jauna_spele = jauna_spele.Checked;
            Properties.Settings.Default.saglabat = galvena_forma.p_saglabat = saglabat.Checked;
            Properties.Settings.Default.rezultati = galvena_forma.p_rezultati = rezultati.Checked;

            Properties.Settings.Default.Save();
            this.Close();
        }

        private void atiestatit_Click(object sender, EventArgs e)
        {
            rezga_krasa.BackColor = Color.Red;
            aktiva_krasa.BackColor = Color.White;
            iezimeta_krasa.BackColor = Color.Green;
            indeksu_krasa.BackColor = Color.Red;
            piecpadsmit_krasa.BackColor = SystemColors.Control;
            fonts.Font = new Font(DefaultFont, FontStyle.Regular);
            jauna_spele.Checked = saglabat.Checked = rezultati.Checked = true;
        }
    }
}

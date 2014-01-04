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

            rezga_krasa.BackColor = galvena_forma.rezga_krasa;
            aktiva_krasa.BackColor = galvena_forma.aktiva_krasa;
            iezimeta_krasa.BackColor = galvena_forma.iezimeta_krasa;
            indeksu_krasa.BackColor = galvena_forma.indeksu_krasa;
            piecpadsmit_krasa.BackColor = galvena_forma.piecpadsmit_krasa;
            fonts.Font = galvena_forma.fonts;
            jauna_spele.Checked = galvena_forma.p_jauna_spele;
            saglabat.Checked = galvena_forma.p_saglabat;
            rezultati.Checked = galvena_forma.p_rezultati;
        }

        private void rezga_krasa_Click(object sender, EventArgs e)
        {
            krasas_izvele("cilne_noformejums", "rezga_krasa");
        }

        private void aktiva_krasa_Click(object sender, EventArgs e)
        {
            krasas_izvele("cilne_noformejums", "aktiva_krasa");
        }

        private void iezimeta_krasa_Click(object sender, EventArgs e)
        {
            krasas_izvele("cilne_noformejums", "iezimeta_krasa");
        }

        private void indeksu_krasa_Click(object sender, EventArgs e)
        {
            krasas_izvele("cilne_noformejums", "indeksu_krasa");
        }

        private void piecpadsmit_krasa_Click(object sender, EventArgs e)
        {
            krasas_izvele("cilne_noformejums", "piecpadsmit_krasa");
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
            galvena_forma.rezga_krasa = rezga_krasa.BackColor;
            galvena_forma.aktiva_krasa = aktiva_krasa.BackColor;
            galvena_forma.iezimeta_krasa = iezimeta_krasa.BackColor;
            galvena_forma.indeksu_krasa = indeksu_krasa.BackColor;
            galvena_forma.piecpadsmit_krasa = piecpadsmit_krasa.BackColor;
            galvena_forma.fonts = fonts.Font;
            galvena_forma.p_jauna_spele = jauna_spele.Checked;
            galvena_forma.p_saglabat = saglabat.Checked;
            galvena_forma.p_rezultati = rezultati.Checked;

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

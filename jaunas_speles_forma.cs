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
    public partial class jaunas_speles_forma : Form
    {
        public jaunas_speles_forma()
        {
            InitializeComponent();

            rindas.Value = (decimal)galvena_forma.rindu_sk;
            kolonnas.Value = (decimal)galvena_forma.kolonnu_sk;

            if (galvena_forma.parasta_spele)
            {
                veids_parasta.Checked = true;
            }
            else
            {
                veids_piecpadsmit.Checked = true;
            }

            if (galvena_forma.originala_spele)
            {
                krasas_originalas.Checked = true;
            }
            else
            {
                krasas_pelektonu.Checked = true;
            }
        }

        // TODO Brīdinājuma parādīšana, ja lietotājs izvēlas laukuma izmēru, kas lielāks par 10x10.
        private void sakt_speli_Click(object sender, EventArgs e)
        {
            galvena_forma.rindu_sk = (int)rindas.Value;
            galvena_forma.kolonnu_sk = (int)kolonnas.Value;
            galvena_forma.kopa = galvena_forma.rindu_sk * galvena_forma.kolonnu_sk;

            if (veids_parasta.Checked)
            {
                galvena_forma.parasta_spele = true;
            }
            else
            {
                galvena_forma.parasta_spele = false;
            }

            if (krasas_originalas.Checked)
            {
                galvena_forma.originala_spele = true;
            }
            else
            {
                galvena_forma.originala_spele = false;
            }

            galvena_forma.jauna_spele = true;

            this.Close();
        }
    }
}

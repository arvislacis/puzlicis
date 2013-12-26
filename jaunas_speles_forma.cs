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
        }

        private void sakt_speli_Click(object sender, EventArgs e)
        {
            galvena_forma.rindu_sk = (int)rindas.Value;
            galvena_forma.kolonnu_sk = (int)kolonnas.Value;
            galvena_forma.jauna_spele = true;

            this.Close();
        }
    }
}

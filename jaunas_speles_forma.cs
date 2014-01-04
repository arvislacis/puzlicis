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
        public void atvert_attelus()
        {
            OpenFileDialog ad = new OpenFileDialog();
            ad.Title = "Attēlu izvēle...";
            ad.Filter = "Visi atbalstītie attēlu formāti|*.bmp;*.gif;*.jpeg;*.jpg;*.png|Bitmap attēli (*.bmp)|*.bmp|GIF attēli (*.gif)|*.gif|JPEG attēli (*.jpg, *.jpeg)|*.jpg;*.jpeg|PNG attēli|*.png";
            ad.AddExtension = ad.CheckPathExists = ad.CheckFileExists = true;

            if (ad.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < ad.FileNames.Length; i++)
                {
                    galvena_forma.s_atteli.Add(ad.FileNames[0]);
                }
            }
            else
            {
                no_sistemas.Checked = false;
            }
        }

        public void jauna_spele()
        {
            galvena_forma.rindu_sk = (int)rindas.Value;
            galvena_forma.kolonnu_sk = (int)kolonnas.Value;
            galvena_forma.kopa = galvena_forma.rindu_sk * galvena_forma.kolonnu_sk;
            galvena_forma.parasta_spele = veids_parasta.Checked;
            galvena_forma.originala_spele = krasas_originalas.Checked;

            if ((no_sistemas.Checked) && (galvena_forma.s_atteli.Count > 0))
            {
                galvena_forma.sistemas_atteli = true;
            }
            else
            {
                galvena_forma.sistemas_atteli = false;
            }

            galvena_forma.jauna_spele = true;

            this.Close();
        }

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

            if (galvena_forma.sistemas_atteli) {
                no_sistemas.Checked = true;
            }
        }

        private void no_sistemas_CheckedChanged(object sender, EventArgs e)
        {
            izveleties_attelus.Visible = no_sistemas.Checked;
        }

        private void izveleties_attelus_Click(object sender, EventArgs e)
        {
            atvert_attelus();
        }

        private void sakt_speli_Click(object sender, EventArgs e)
        {
            if (rindas.Value * kolonnas.Value > 100)
            {
                if (MessageBox.Show("Izvēlētā izmēra (" + rindas.Value.ToString() + "x" + kolonnas.Value.ToString() + ") puzles salikšana var būt apgrūtināta.\nVai tiešām vēlaties likt šādu puzli?", "Liels puzles izmērs", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    jauna_spele();
                }
            }
            else
            {
                jauna_spele();
            }
        }
    }
}
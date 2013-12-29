﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace puzlicis
{
    public partial class galvena_forma : Form
    {
        public System.Reflection.Assembly projekts = System.Reflection.Assembly.GetExecutingAssembly();
        public Bitmap attels;
        public bool ir_salikta = false;
        public Image attela_resurss;
        public int attelu_sk = 25, attela_id, platums, augstums, m, n, m_v, n_v, gajieni, laiks;
        public int[] iezime;
        public string minutes, sekundes;
        public static bool jauna_spele = false, parasta_spele = true;
        public static Color aktiva_krasa = Color.White, iezimeta_krasa = Color.Green, rezga_krasa = Color.Red;
        public static int rindu_sk = 5, kolonnu_sk = 5;

        public ColorMatrix aktiva_m = new ColorMatrix(
            new float[][] {
                new float[] {1, 0, 0, 0, 0},
                new float[] {0, 1, 0, 0, 0},
                new float[] {0, 0, 1, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {.2f, .2f, .2f, 0, 1}
            });
        public ColorMatrix iezimes_m = new ColorMatrix(
            new float[][] {
                new float[] {1, 1, 0, 0, 0},
                new float[] {0, 1, 0, 0, 0},
                new float[] {0, 1, 1, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {0, 0, 0, 0, 1}
            });
        public ColorMatrix nokluseta_m;
        public ColorMatrix pelektonu_m = new ColorMatrix(
            new float[][] {
                new float[] {.3f, .3f, .3f, 0, 0},
                new float[] {.59f, .59f, .59f, 0, 0},
                new float[] {.11f, .11f, .11f, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {0, 0, 0, 0, 1}
            });
        public ColorMatrix vienibas_m = new ColorMatrix(
            new float[][] {
                new float[] {1, 0, 0, 0, 0},
                new float[] {0, 1, 0, 0, 0},
                new float[] {0, 0, 1, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {0, 0, 0, 0, 1}
            });

        public gabalins[,] laukums;
        public gabalins tmp;
        public class gabalins
        {
            public int indekss, m, n;
            public ColorMatrix matrica;
        }

        public void generet_laukumu()
        {
            laukums = new gabalins[rindu_sk, kolonnu_sk];

            for (int i = 0; i < rindu_sk; i++)
            {
                for (int j = 0; j < kolonnu_sk; j++)
                {
                    laukums[i, j] = new gabalins() { m = i, n = j, matrica = nokluseta_m };
                }
            }

            int skaititajs = 1;

            for (int i = 0; i < kolonnu_sk; i++)
            {
                for (int j = 0; j < rindu_sk; j++)
                {
                    laukums[j, i].indekss = skaititajs;
                    skaititajs++;
                }
            }

            Random r = new Random();
            int[] no, uz;

            for (int i = 0; i < rindu_sk * kolonnu_sk * 2; i++)
            {
                no = new int[2] { r.Next(0, rindu_sk), r.Next(0, kolonnu_sk) };
                uz = new int[2] { r.Next(0, rindu_sk), r.Next(0, kolonnu_sk) };

                samainit_gabalinus(no[0], no[1], uz[0], uz[1]);
            }

            attela_id = r.Next(1, attelu_sk);
            mainit_attelu(attela_id);
        }

        public void laukuma_dati()
        {
            attels = new Bitmap(attela_resurss, panelis_spele.Width, panelis_spele.Height);
            platums = panelis_spele.Width / rindu_sk;
            augstums = panelis_spele.Height / kolonnu_sk;

            zimet_laukumu();
        }

        public void mainit_attelu(int id)
        {
            attela_resurss = Image.FromStream(projekts.GetManifestResourceStream("puzlicis.atteli.attels_" + attela_id.ToString() + ".jpg"));
            prieksskatijums.BackgroundImage = new Bitmap(attela_resurss, prieksskatijums.Width, prieksskatijums.Height);
            laukuma_dati();
        }

        public void noteikt_indeksus(int x, int y)
        {
            if (m_v != m)
            {
                m_v = m;
            }

            if (n_v != n)
            {
                n_v = n;
            }

            for (int i = 0; i < rindu_sk; i++)
            {
                if (((i - 1) * platums < x) && (x < (i + 1) * platums))
                {
                    m = i;
                    break;
                }
            }

            for (int i = 0; i < kolonnu_sk; i++)
            {
                if (((i - 1) * augstums < y) && (y < (i + 1) * augstums))
                {
                    n = i;
                    break;
                }
            }
        }

        // TODO Atgriežoties atpakaļ spēles laukumā, kad tāpat aizvērta jaunas spēles forma, jāatgriež funkcionalitāte
        public void sakt_jaunu_speli()
        {
            jauna_spele = false;

            // TODO Brīdinājums situācijā, kad notiek jau jauna spēle
            jaunas_speles_forma forma = new jaunas_speles_forma();
            forma.ShowDialog();

            if (jauna_spele)
            {
                gajieni = 0;
                laiks = 0;
                iezime = null;
                ir_salikta = false;

                if (parasta_spele)
                {
                    nokluseta_m = vienibas_m;
                }
                else
                {
                    nokluseta_m = pelektonu_m;
                }

                // TODO Atsevišķi izdalīt šo rindiņu, lai tā tiktu izpildīta tikai pirmajā reizē, kad tiek sākta spēle
                taimeris.Enabled = attēlaPriekšskatījumsToolStripMenuItem.Enabled = radit_rezgi.Visible = radit_indeksus.Visible = ieprieksejais.Visible = nakamais.Visible = gajieni_txt.Visible = laiks_txt.Visible = true;
                statuss_txt.Text = "Notiek spēle...";
                generet_laukumu();
            }
        }

        public void samainit_gabalinus(int no_i, int no_j, int uz_i, int uz_j)
        {
            tmp = laukums[no_i, no_j];
            laukums[no_i, no_j] = laukums[uz_i, uz_j];
            laukums[uz_i, uz_j] = tmp;
        }

        public void vai_ir_salikta()
        {
            bool izpildas = true;
            int iepr_indekss = 0;

            for (int i = 0; i < kolonnu_sk; i++)
            {
                for (int j = 0; j < rindu_sk; j++)
                {
                    if ((izpildas) && (laukums[j, i].indekss > iepr_indekss))
                    {
                        iepr_indekss = laukums[j, i].indekss;
                    }
                    else
                    {
                        izpildas = false;
                    }
                }
            }

            if (izpildas)
            {
                taimeris.Enabled = false;
                ir_salikta = true;
                statuss_txt.Text = "Puzle ir salikta!";

                if (MessageBox.Show("Puzle ir veiksmīgi salikta.\n\nIzmantotie gājieni: " + gajieni.ToString() + ".\nPatērētais laiks: " + minutes + ":" + sekundes + ".\n\nVai vēlaties likt jaunu puzli?", "Puzle salikta", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    sakt_jaunu_speli();
                }
            }
        }

        // TODO Atrisināt problēmu ar aktīvās krāsas pārklāšanos visā režģa laukumā
        public void zimet_gabalinu(int i, int j)
        {
            Graphics g = panelis_spele.CreateGraphics();
            Rectangle kur_zimet = new Rectangle(i * platums, j * augstums, platums, augstums);
            ImageAttributes efekti = new ImageAttributes();
            efekti.SetColorMatrix(laukums[i, j].matrica);

            g.DrawImage(attels, kur_zimet, laukums[i, j].m * platums, laukums[i, j].n * augstums, platums, augstums, GraphicsUnit.Pixel, efekti);

            if (iezime != null)
            {
                g.DrawRectangle(new Pen(iezimeta_krasa, 2.0f), iezime[0] * platums, iezime[1] * augstums, platums, augstums);
            }

            if (radit_rezgi.Checked)
            {
                g.DrawRectangle(new Pen(rezga_krasa, 2.0f), i * platums, j * augstums, platums, augstums);
            }

            if (radit_indeksus.Checked)
            {
                g.DrawString(laukums[i, j].indekss.ToString(), new Font(FontFamily.GenericSansSerif, 26), Brushes.White, i * platums, j * augstums);
            }

            g.DrawRectangle(new Pen(aktiva_krasa, 2.0f), m * platums, n * augstums, platums, augstums);
        }

        public void zimet_laukumu()
        {
            Graphics g = panelis_spele.CreateGraphics();

            for (int i = 0; i < rindu_sk; i++)
            {
                for (int j = 0; j < kolonnu_sk; j++)
                {
                    Rectangle kur_zimet = new Rectangle(i * platums, j * augstums, platums, augstums);
                    ImageAttributes efekti = new ImageAttributes();
                    efekti.SetColorMatrix(laukums[i, j].matrica);

                    zimet_gabalinu(i, j);
                }
            }
        }

        public galvena_forma()
        {
            InitializeComponent();
        }

        // TODO Novērst minimizēšanas un pārzīmēšanās kļūdas
        private void galvena_forma_SizeChanged(object sender, EventArgs e)
        {
            if (jauna_spele)
            {
                laukuma_dati();
            }
        }

        private void taimeris_Tick(object sender, EventArgs e)
        {
            laiks++;
            minutes = (laiks / 60).ToString();

            if (laiks % 60 < 10)
            {
                sekundes = "0" + (laiks % 60).ToString();
            }
            else
            {
                sekundes = (laiks % 60).ToString();
            }

            laiks_txt.Text = "Laiks: " + minutes + ":" + sekundes;
        }

        private void panelis_spele_MouseMove(object sender, MouseEventArgs e)
        {
            if (jauna_spele)
            {
                noteikt_indeksus(e.X, e.Y);

                if (laukums[m, n].matrica != aktiva_m)
                {
                    if (laukums[m_v, n_v].matrica != iezimes_m)
                    {
                        if (laukums[m, n].matrica != iezimes_m)
                        {
                            laukums[m, n].matrica = aktiva_m;
                            zimet_gabalinu(m, n);
                        }

                        laukums[m_v, n_v].matrica = nokluseta_m;
                        zimet_gabalinu(m_v, n_v);
                    }
                    else if (laukums[m, n].matrica != iezimes_m)
                    {
                        laukums[m, n].matrica = aktiva_m;
                        zimet_gabalinu(m, n);
                    }
                }
            }
        }

        private void panelis_spele_MouseClick(object sender, MouseEventArgs e)
        {
            if ((jauna_spele) && (!ir_salikta))
            {
                noteikt_indeksus(e.X, e.Y);

                if (iezime == null)
                {
                    iezime = new int[2] { m, n };
                    laukums[m, n].matrica = iezimes_m;
                    zimet_gabalinu(m, n);
                }
                else
                {
                    samainit_gabalinus(iezime[0], iezime[1], m, n);

                    laukums[m, n].matrica = aktiva_m;
                    zimet_gabalinu(m, n);
                    laukums[iezime[0], iezime[1]].matrica = nokluseta_m;
                    zimet_gabalinu(iezime[0], iezime[1]);

                    iezime = null;
                    gajieni++;
                    gajieni_txt.Text = "Gājieni: " + gajieni.ToString();
                    vai_ir_salikta();
                }
            }
        }

        private void prieksskatijums_Click(object sender, EventArgs e)
        {
            if (jauna_spele)
            {
                prieksskatijuma_forma forma = new prieksskatijuma_forma();
                forma.BackgroundImage = new Bitmap(attela_resurss, forma.Width, forma.Height);
                forma.ShowDialog();
            }
        }

        private void radit_rezgi_CheckedChanged(object sender, EventArgs e)
        {
            zimet_laukumu();
        }

        private void radit_indeksus_CheckedChanged(object sender, EventArgs e)
        {
            zimet_laukumu();
        }

        private void ieprieksejais_Click(object sender, EventArgs e)
        {
            if (attela_id == 1)
            {
                attela_id = attelu_sk;
            }
            else
            {
                attela_id--;
            }

            mainit_attelu(attela_id);
        }

        private void nakamais_Click(object sender, EventArgs e)
        {
            if (attela_id == 25)
            {
                attela_id = 1;
            }
            else
            {
                attela_id++;
            }

            mainit_attelu(attela_id);
        }

        private void jaunaSpēleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sakt_jaunu_speli();
        }

        private void izietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO Papildus kods, kas saglabā pašreizējo spēles stāvokli
            Application.Exit();
        }

        // TODO Rīku sadaļā pievienot vienumus puzles laukuma normalizēšanai - sākuma stāvoklī un 4:3 proporcijā
        private void attēlaPriekšskatījumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prieksskatijums_Click(sender, e);
        }
    }
}
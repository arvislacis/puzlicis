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
        public bool ir_salikta = false, notiek_spele = false;
        public Image attela_resurss;
        public int attelu_sk = 25, attela_id, platums, augstums, m, n, m_v, n_v, gajieni, laiks;
        public int[] iezime, pedejais;
        public string minutes, sekundes;
        public static bool jauna_spele = false, parasta_spele = true, originala_spele = true, prieksskatijuma_rezgis = false;
        public static Color aktiva_krasa = Color.White, iezimeta_krasa = Color.Green, indeksu_krasa = Color.Red, piecpadsmit_krasa = SystemColors.Control, rezga_krasa = Color.Red;
        public static int rindu_sk = 5, kolonnu_sk = 5, kopa = 25;

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
            public Color krasa;
            public ColorMatrix matrica;
        }

        public void gajienu_skaititajs()
        {
            gajieni++;
            gajieni_txt.Text = "Gājieni: " + gajieni.ToString();
            vai_ir_salikta();
        }

        public void generet_laukumu()
        {
            laukums = new gabalins[rindu_sk, kolonnu_sk];

            for (int i = 0; i < rindu_sk; i++)
            {
                for (int j = 0; j < kolonnu_sk; j++)
                {
                    laukums[i, j] = new gabalins() { m = i, n = j, krasa = rezga_krasa, matrica = nokluseta_m };
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

            if (parasta_spele)
            {
                for (int i = 0; i < rindu_sk * kolonnu_sk * 2; i++)
                {
                    no = new int[2] { r.Next(0, rindu_sk), r.Next(0, kolonnu_sk) };
                    uz = new int[2] { r.Next(0, rindu_sk), r.Next(0, kolonnu_sk) };

                    samainit_gabalinus(no[0], no[1], uz[0], uz[1]);
                }
            }
            else
            {
                int skaits = 0, i, j, v_i, v_j, virziens;
                bool beigt = false;

                i = rindu_sk - 1;
                j = kolonnu_sk - 1;

                v_i = i;
                v_j = j;

                while (!(skaits > kopa * 40) && (!beigt))
                {
                    virziens = r.Next(1, 5);

                    switch (virziens)
                    {
                        case 1: i = i - 1; break;
                        case 2: j = j + 1; break;
                        case 3: i = i + 1; break;
                        case 4: j = j - 1; break;
                        default: break;
                    }

                    if ((0 <= i) && (i < rindu_sk) && (0 <= j) && (j < kolonnu_sk))
                    {
                        samainit_gabalinus(v_i, v_j, i, j);

                        v_i = i;
                        v_j = j;
                        skaits++;
                    }
                    else
                    {
                        i = v_i;
                        j = v_j;
                    }

                    if ((skaits > kopa * 20) && (i == rindu_sk - 1) && (j == kolonnu_sk - 1))
                    {
                        beigt = true;
                    }
                }

                pedejais = new int[2] { rindu_sk - 1, kolonnu_sk - 1 };
            }

            if (vai_ir_pec_kartas())
            {
                generet_laukumu();
            }
            else
            {
                attela_id = r.Next(1, attelu_sk);
                mainit_attelu(attela_id);
            }
        }

        public void laukuma_dati()
        {
            attels = new Bitmap(attela_resurss, panelis_spele.Width, panelis_spele.Height);
            platums = panelis_spele.Width / rindu_sk;
            augstums = panelis_spele.Height / kolonnu_sk;

            zimet_laukumu();
        }

        public void laukumi_piecpadsmit(ColorMatrix matrica, Color krasa)
        {
            if (pedejais[0] > 0)
            {
                matricas(pedejais[0] - 1, pedejais[1], matrica, krasa);
            }

            if (pedejais[0] < rindu_sk - 1)
            {
                matricas(pedejais[0] + 1, pedejais[1], matrica, krasa);
            }

            if (pedejais[1] > 0)
            {
                matricas(pedejais[0], pedejais[1] - 1, matrica, krasa);
            }

            if (pedejais[1] < kolonnu_sk - 1)
            {
                matricas(pedejais[0], pedejais[1] + 1, matrica, krasa);
            }

            matricas(pedejais[0], pedejais[1], matrica, krasa);
        }

        public void mainit_attelu(int id)
        {
            attela_resurss = Image.FromStream(projekts.GetManifestResourceStream("puzlicis.atteli.attels_" + attela_id.ToString() + ".jpg"));
            prieksskatijums.BackgroundImage = new Bitmap(attela_resurss, prieksskatijums.Width, prieksskatijums.Height);
            attels_txt.Text = id.ToString() + ". attēls";
            laukuma_dati();
        }

        public void matricas(int i, int j, ColorMatrix matrica, Color krasa)
        {
            laukums[i, j].matrica = matrica;
            laukums[i, j].krasa = krasa;
            zimet_gabalinu(i, j);
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

        public void sakt_jaunu_speli()
        {
            jauna_spele = false;

            // TODO Brīdinājums situācijā, kad notiek jau jauna spēle
            jaunas_speles_forma forma = new jaunas_speles_forma();
            forma.ShowDialog();

            if (jauna_spele)
            {
                if (originala_spele)
                {
                    nokluseta_m = vienibas_m;
                }
                else
                {
                    nokluseta_m = pelektonu_m;
                }

                if (!notiek_spele)
                {
                     radit_rezgi.Visible = radit_prieksskatijuma_rezgi.Visible = radit_indeksus.Visible = ieprieksejais.Visible = nakamais.Visible = gajieni_txt.Visible = laiks_txt.Visible = attels_txt.Visible = attēlaPriekšskatījumsToolStripMenuItem.Enabled = pārlādētPuzlesAttēluToolStripMenuItem.Enabled = true;
                }

                generet_laukumu();

                gajieni = laiks = 0;
                iezime = null;
                ir_salikta = false;
                notiek_spele = taimeris.Enabled = true;
                statuss_txt.Text = "Notiek spēle...";
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
            if (vai_ir_pec_kartas())
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

        public bool vai_ir_pec_kartas()
        {
            int iepr_indekss = 0;

            for (int i = 0; i < kolonnu_sk; i++)
            {
                for (int j = 0; j < rindu_sk; j++)
                {
                    if (laukums[j, i].indekss > iepr_indekss)
                    {
                        iepr_indekss = laukums[j, i].indekss;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public void zimet_gabalinu(int i, int j)
        {
            Graphics g = panelis_spele.CreateGraphics();
            Rectangle kur_zimet = new Rectangle(i * platums, j * augstums, platums, augstums);
            ImageAttributes efekti = new ImageAttributes();
            efekti.SetColorMatrix(laukums[i, j].matrica);

            if ((parasta_spele == false) && (laukums[i, j].indekss == kopa))
            {
                g.FillRectangle(new SolidBrush(piecpadsmit_krasa), kur_zimet);
            }
            else
            {
                g.DrawImage(attels, kur_zimet, laukums[i, j].m * platums, laukums[i, j].n * augstums, platums, augstums, GraphicsUnit.Pixel, efekti);
            }

            if (radit_rezgi.Checked)
            {
                g.DrawRectangle(new Pen(laukums[i, j].krasa, 2.0f), i * platums, j * augstums, platums, augstums);

                if (iezime != null)
                {
                    g.DrawRectangle(new Pen(laukums[iezime[0], iezime[1]].krasa, 2.0f), iezime[0] * platums, iezime[1] * augstums, platums, augstums);
                }
            }

            if (radit_indeksus.Checked)
            {
                g.DrawString(laukums[i, j].indekss.ToString(), new Font(FontFamily.GenericSansSerif, augstums / 3), new SolidBrush(indeksu_krasa), i * platums, j * augstums);
            }
        }

        public void zimet_laukumu()
        {
            for (int i = 0; i < rindu_sk; i++)
            {
                for (int j = 0; j < kolonnu_sk; j++)
                {
                    zimet_gabalinu(i, j);
                }
            }

            if (!parasta_spele)
            {
                laukumi_piecpadsmit(aktiva_m, aktiva_krasa);
            }
        }

        // TODO Tikt galā ar priekšskatījuma režģa attēlošanu
        public void zimet_prieksskatijuma_rezgi()
        {
            Graphics g = prieksskatijums.CreateGraphics();

            if (radit_prieksskatijuma_rezgi.Checked)
            {
                for (int i = 0; i < rindu_sk; i++)
                {
                    for (int j = 0; j < kolonnu_sk; j++)
                    {
                        g.DrawRectangle(new Pen(rezga_krasa, 1.0f), i * prieksskatijums.Width / rindu_sk, j * prieksskatijums.Height / kolonnu_sk, prieksskatijums.Width / rindu_sk, prieksskatijums.Height / kolonnu_sk);
                    }
                }
            }
            else
            {

            }
        }

        public galvena_forma()
        {
            InitializeComponent();
        }

        private void galvena_forma_KeyDown(object sender, KeyEventArgs e)
        {
            if ((notiek_spele) && (!ir_salikta) && (!parasta_spele))
            {
                int i = pedejais[0], j = pedejais[1];

                if ((e.KeyCode == Keys.A) && (pedejais[0] > 0))
                {
                    i = i - 1;
                }

                if ((e.KeyCode == Keys.D) && (pedejais[0] < rindu_sk - 1))
                {
                    i = i + 1;
                }

                if ((e.KeyCode == Keys.W) && (pedejais[1] > 0))
                {
                    j = j - 1;
                }

                if ((e.KeyCode == Keys.S) && (pedejais[1] < kolonnu_sk - 1))
                {
                    j = j + 1;
                }

                if ((pedejais[0] != i) || (pedejais[1] != j))
                {
                    laukumi_piecpadsmit(nokluseta_m, rezga_krasa);
                    samainit_gabalinus(i, j, pedejais[0], pedejais[1]);
                    pedejais = new int[2] { i, j };
                    laukumi_piecpadsmit(aktiva_m, aktiva_krasa);
                    gajienu_skaititajs();
                }
            }
        }

        private void galvena_forma_SizeChanged(object sender, EventArgs e)
        {
            if ((notiek_spele) && (WindowState != FormWindowState.Minimized))
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

        private void panelis_spele_Paint(object sender, PaintEventArgs e)
        {
            if (notiek_spele)
            {
                laukuma_dati();
            }
        }

        private void panelis_spele_MouseMove(object sender, MouseEventArgs e)
        {
            if (notiek_spele)
            {
                noteikt_indeksus(e.X, e.Y);

                if (parasta_spele)
                {
                    if (laukums[m, n].matrica != aktiva_m)
                    {
                        if (laukums[m_v, n_v].matrica != iezimes_m)
                        {
                            matricas(m_v, n_v, nokluseta_m, rezga_krasa);

                            if (laukums[m, n].matrica != iezimes_m)
                            {
                                matricas(m, n, aktiva_m, aktiva_krasa);
                            }
                        }
                        else if (laukums[m, n].matrica != iezimes_m)
                        {
                            matricas(m, n, aktiva_m, aktiva_krasa);
                        }
                    }
                }

                if (radit_indeksus.Checked)
                {
                    indekss_txt.Text = "Gabaliņa indekss: " + laukums[m, n].indekss.ToString();
                }
            }
        }

        private void panelis_spele_MouseClick(object sender, MouseEventArgs e)
        {
            if ((notiek_spele) && (!ir_salikta))
            {
                noteikt_indeksus(e.X, e.Y);

                if (parasta_spele)
                {
                    if (iezime == null)
                    {
                        iezime = new int[2] { m, n };
                        matricas(m, n, iezimes_m, iezimeta_krasa);
                    }
                    else
                    {
                        samainit_gabalinus(iezime[0], iezime[1], m, n);

                        matricas(m, n, aktiva_m, aktiva_krasa);
                        matricas(iezime[0], iezime[1], nokluseta_m, rezga_krasa);

                        iezime = null;
                        gajienu_skaititajs();
                    }
                }
                else
                {
                    if ((laukums[m, n].matrica == aktiva_m) && (laukums[m, n].indekss != kopa))
                    {
                        laukumi_piecpadsmit(nokluseta_m, rezga_krasa);
                        samainit_gabalinus(m, n, pedejais[0], pedejais[1]);
                        pedejais = new int[2] { m, n };
                        laukumi_piecpadsmit(aktiva_m, aktiva_krasa);

                        gajienu_skaititajs();
                    }
                }
            }
        }

        private void prieksskatijums_Click(object sender, EventArgs e)
        {
            if (notiek_spele)
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

        // TODO Tikt galā ar priekšskatījuma režģa attēlošanu
        private void radit_prieksskatijuma_rezgi_CheckedChanged(object sender, EventArgs e)
        {
            prieksskatijuma_rezgis = radit_prieksskatijuma_rezgi.Checked;
            zimet_prieksskatijuma_rezgi();
        }

        private void radit_indeksus_CheckedChanged(object sender, EventArgs e)
        {
            if (radit_indeksus.Checked)
            {
                indekss_txt.Visible = true;
            }
            else
            {
                indekss_txt.Visible = false;
            }

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

        // TODO Skata sadaļā pievienot vienumus puzles laukuma normalizēšanai - sākuma stāvoklī un 4:3 proporcijā
        // TODO Iespējams nodrošināt to, lai vienu priekšskatījuma logu var lietot kopā ar galveno formu
        private void attēlaPriekšskatījumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prieksskatijums_Click(sender, e);
        }

        private void pārlādētPuzlesAttēluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelis_spele.Refresh();
        }

        private void parToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Puzlicis " + Application.ProductVersion + "\nVienkārša attēlu puzļu likšanas programma.\n\nLatvijas Lauksaimniecības universitāte\nInformācijas tehnoloģiju fakultāte\n2. kurss Programmēšana\n\n© 2013-2014 Arvis Lācis", "Par Puzlici", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
using System;
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
        public Image attela_resurss;
        public int attelu_sk = 25, attela_id, platums, augstums, m, n, m_v, n_v;
        public int[] iezime;
        public static bool jauna_spele = false;
        public static Color rezga_krasa = Color.Red, aktiva_krasa = Color.White, iezimeta_krasa = Color.Green;
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

        public void laukuma_dati()
        {
            attels = new Bitmap(attela_resurss, panelis_spele.Width, panelis_spele.Height);
            platums = panelis_spele.Width / rindu_sk;
            augstums = panelis_spele.Height / kolonnu_sk;
        }

        public void generet_laukumu()
        {
            laukums = new gabalins[rindu_sk, kolonnu_sk];

            for (int i = 0; i < rindu_sk; i++)
            {
                for (int j = 0; j < kolonnu_sk; j++)
                {
                    laukums[i, j] = new gabalins() { m = i, n = j, matrica = vienibas_m };
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
            
            attela_id = r.Next(1, attelu_sk);
            attela_resurss = Image.FromStream(projekts.GetManifestResourceStream("puzlicis.atteli.attels_" + attela_id.ToString() + ".jpg"));

            for (int i = 0; i < rindu_sk * kolonnu_sk * 2; i++)
            {
                no = new int[2] { r.Next(0, rindu_sk), r.Next(0, kolonnu_sk) };
                uz = new int[2] { r.Next(0, rindu_sk), r.Next(0, kolonnu_sk) };

                samainit_gabalinus(no[0], no[1], uz[0], uz[1]);
            }
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

                    // TODO Atdalīt zīmēšanas funkciju (līniju) jaunā zīmēšanas funkcijā, lai tai varētu piekļūt ārēji
                    g.DrawImage(attels, kur_zimet, laukums[i, j].m * platums, laukums[i, j].n * augstums, platums, augstums, GraphicsUnit.Pixel, efekti);
                    
                    if (radit_rezgi.Checked)
                    {
                        g.DrawRectangle(new Pen(rezga_krasa, 2.0f), i * platums, j * augstums, platums, augstums);
                    }

                    if (radit_indeksus.Checked)
                    {
                        g.DrawString(laukums[i, j].indekss.ToString(), new Font(FontFamily.GenericSansSerif, 26), Brushes.White, i * platums, j * augstums);
                    }
                }
            }

            g.DrawRectangle(new Pen(aktiva_krasa, 2.0f), m * platums, n * augstums, platums, augstums);

            if (iezime != null)
            {
                g.DrawRectangle(new Pen(iezimeta_krasa, 2.0f), iezime[0] * platums, iezime[1] * augstums, platums, augstums);
            }
        }

        public void samainit_gabalinus(int no_i, int no_j, int uz_i, int uz_j)
        {
            tmp = laukums[no_i, no_j];
            laukums[no_i, no_j] = laukums[uz_i, uz_j];
            laukums[uz_i, uz_j] = tmp;
        }

        public void noteikt_indeksus(int x, int y)
        {
            m_v = m;
            n_v = n;

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

        public galvena_forma()
        {
            InitializeComponent();
        }

        // TODO Samazināt formas pārzīmēšanu skaitu (taimeris un skaitītājs)
        private void galvena_forma_Paint(object sender, PaintEventArgs e)
        {
            if (jauna_spele)
            {
                laukuma_dati();
                zimet_laukumu();
            }
        }

        // TODO Optimizēt kodu tā, lai tiktu pārzīmēti tikai tās attēla daļas, kas tiek mainītas
        private void panelis_spele_MouseMove(object sender, MouseEventArgs e)
        {
            if (jauna_spele)
            {
                noteikt_indeksus(e.X, e.Y);

                if (laukums[m, n].matrica == iezimes_m)
                {
                    zimet_laukumu();
                }

                if (laukums[m, n].matrica == vienibas_m)
                {
                    if (laukums[m_v, n_v].matrica != iezimes_m)
                    {
                        laukums[m_v, n_v].matrica = vienibas_m;
                    }

                    laukums[m, n].matrica = aktiva_m;
                    zimet_laukumu();
                }
            }
        }

        private void panelis_spele_MouseClick(object sender, MouseEventArgs e)
        {
            if (jauna_spele)
            {
                noteikt_indeksus(e.X, e.Y);

                if (iezime == null)
                {
                    iezime = new int[2] { m, n };
                    laukums[m, n].matrica = iezimes_m;
                }
                else
                {
                    samainit_gabalinus(iezime[0], iezime[1], m, n);
                    laukums[iezime[0], iezime[1]].matrica = laukums[m, n].matrica = vienibas_m;
                    iezime = null;
                }

                zimet_laukumu();
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

        private void jaunaSpēleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jauna_spele = false;

            // TODO Brīdinājums situācijā, kad notiek jau jauna spēle
            jaunas_speles_forma forma = new jaunas_speles_forma();
            forma.ShowDialog();

            if (jauna_spele)
            {
                iezime = null;
                attēlaPriekšskatījumsToolStripMenuItem.Enabled = radit_rezgi.Visible = radit_indeksus.Visible = true;
                generet_laukumu();
                laukuma_dati();
                zimet_laukumu();
                prieksskatijums.BackgroundImage = new Bitmap(attela_resurss, prieksskatijums.Width, prieksskatijums.Height);
            }
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
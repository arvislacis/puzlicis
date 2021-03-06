﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public int attelu_sk, attela_id, platums, augstums, m, n, m_v, n_v, gajieni, laiks;
        public int[] iezime, pedejais;
        public string minutes, sekundes;
        public static bool jauna_spele = false, parasta_spele = true, originala_spele = true, sistemas_atteli = false, prieksskatijuma_rezgis = false, p_jauna_spele = Properties.Settings.Default.jauna_spele, p_saglabat = Properties.Settings.Default.saglabat, p_rezultati = Properties.Settings.Default.rezultati;
        public static Color aktiva_krasa = Properties.Settings.Default.aktiva_krasa, iezimeta_krasa = Properties.Settings.Default.iezimeta_krasa, indeksu_krasa = Properties.Settings.Default.indeksu_krasa, piecpadsmit_krasa = Properties.Settings.Default.piecpadsmit_krasa, rezga_krasa = Properties.Settings.Default.rezga_krasa;
        public static Font fonts = Properties.Settings.Default.fonts;
        public static int rindu_sk = 5, kolonnu_sk = 5, kopa;
        public static List<string> s_atteli = new List<string>();

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
        /// <summary>
        /// Puzles gabaliņš.
        /// </summary>
        public class gabalins
        {
            public int indekss, m, n;
            public Color krasa;
            public ColorMatrix matrica;
        }

        /// <summary>
        /// Atver teksta datni noklusētajā teksta redaktorā. Tiek izmantots "atteli.txt" un "palidziba.txt" datņu atvēršanai.
        /// </summary>
        /// <param name="nosaukums">Teksta datnes nosaukums ar paplašinājumu, kuru nepieciešams atvērt.</param>
        public void atvert_teksta_datni(string nosaukums)
        {
            if (!File.Exists(nosaukums))
            {
                Stream dati = projekts.GetManifestResourceStream("puzlicis.teksts." + nosaukums);
                FileStream datne = new FileStream(nosaukums, FileMode.Create, FileAccess.Write);

                for (int i = 0; i < dati.Length; i++)
                {
                    datne.WriteByte((byte)dati.ReadByte());
                }

                datne.Close();
            }

            Process.Start(nosaukums);
        }

        /// <summary>
        /// Skaita gājienus un izvada statusa joslā gājienu skaitu.
        /// </summary>
        public void gajienu_skaititajs()
        {
            gajieni++;
            gajieni_txt.Text = "Gājieni: " + gajieni.ToString();
            vai_ir_salikta();
        }

        /// <summary>
        /// Ģenerē puzles galveno laukumu, atkarībā no puzles veida un izmēra.
        /// </summary>
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
                if (sistemas_atteli)
                {
                    attelu_sk = s_atteli.Count;
                }
                else
                {
                    attelu_sk = 25;
                }

                attela_id = r.Next(0, attelu_sk);
                mainit_attelu(attela_id);
            }
        }

        /// <summary>
        /// Iegūst informāciju par spēles laukumu (paneli), kas nepieciešama, lai uzzīmētu puzli. Funkcija pamatā tiek izsaukta tad, kad notiek formas izmēra maiņa.
        /// </summary>
        public void laukuma_dati()
        {
            attels = new Bitmap(attela_resurss, panelis_spele.Width, panelis_spele.Height);
            platums = panelis_spele.Width / rindu_sk;
            augstums = panelis_spele.Height / kolonnu_sk;

            zimet_laukumu();
        }

        /// <summary>
        /// Iezīmē aktīvos (iespējamos) puzles gabaliņus ap "Piecpadsmito" puzles gabaliņu.
        /// </summary>
        /// <param name="matrica">Matrica, kas tiks izmantota gabaliņu iezīmēšanai.</param>
        /// <param name="krasa">Krāsa, kas tiks izmantota aktīvā gabaliņa režģim.</param>
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
        
        /// <summary>
        /// Maina puzles un priekšskatījuma attēlu.
        /// </summary>
        /// <param name="id">Attēla identifikators - no programmas resursiem vai lietotāja izvēlēto attēlu saraksta.</param>
        public void mainit_attelu(int id)
        {
            if (sistemas_atteli)
            {
                attela_resurss = Image.FromFile(s_atteli[id]);
                attels_txt.Text = s_atteli[id];
            }
            else
            {
                attela_resurss = Image.FromStream(projekts.GetManifestResourceStream("puzlicis.atteli.attels_" + attela_id.ToString() + ".jpg"));
                attels_txt.Text = (id + 1).ToString() + ". attēls";
            }

            prieksskatijums.BackgroundImage = new Bitmap(attela_resurss, prieksskatijums.Width, prieksskatijums.Height);
            laukuma_dati();
        }

        /// <summary>
        /// Maina formas izmēru.
        /// </summary>
        /// <param name="platums">Jaunais formas platums.</param>
        /// <param name="augstums">Jaunais formas augstums.</param>
        public void mainit_formas_izmeru(int platums, int augstums)
        {
            this.WindowState = FormWindowState.Normal;
            this.Width = platums;
            this.Height = augstums;
        }

        /// <summary>
        /// Iestata puzles gabaliņam norādīto matricu un režģa krāsu.
        /// </summary>
        /// <param name="i">Gabaliņa rindas indekss.</param>
        /// <param name="j">Gabaliņa kolonnas indekss.</param>
        /// <param name="matrica">Krāsu matrica.</param>
        /// <param name="krasa">Režģa krāsa.</param>
        public void matricas(int i, int j, ColorMatrix matrica, Color krasa)
        {
            laukums[i, j].matrica = matrica;
            laukums[i, j].krasa = krasa;
            zimet_gabalinu(i, j);
        }

        /// <summary>
        /// Nosaka peles kursoram atbilstošo puzles gabaliņu.
        /// </summary>
        /// <param name="x">Peles kursora x koordināta.</param>
        /// <param name="y">Peles kursora y koordināta.</param>
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

        /// <summary>
        /// Parāda jaunas spēles formu. Notīra iepriekšējās spēles datus.
        /// </summary>
        public void sakt_jaunu_speli()
        {
            jauna_spele = false;

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
                    radit_rezgi.Visible = radit_prieksskatijuma_rezgi.Visible = radit_indeksus.Visible = ieprieksejais.Visible = nakamais.Visible = gajieni_txt.Visible = laiks_txt.Visible = attels_txt.Visible = saglabātSpēliToolStripMenuItem.Enabled = attēlaPriekšskatījumsToolStripMenuItem.Enabled = pārlādētPuzlesAttēluToolStripMenuItem.Enabled = true;
                }

                generet_laukumu();

                gajieni = laiks = 0;
                iezime = null;
                ir_salikta = false;
                notiek_spele = taimeris.Enabled = true;
                statuss_txt.Text = "Notiek spēle...";
            }
        }

        /// <summary>
        /// Samaina vietām divus puzles gabaliņus.
        /// </summary>
        /// <param name="no_i">Pirmā gabaliņa rindu indekss.</param>
        /// <param name="no_j">Pirmā gabaliņa kolonnu indekss</param>
        /// <param name="uz_i">Otrā gabaliņa rindu indekss.</param>
        /// <param name="uz_j">Otrā gabaliņa kolonnu indekss.</param>
        public void samainit_gabalinus(int no_i, int no_j, int uz_i, int uz_j)
        {
            tmp = laukums[no_i, no_j];
            laukums[no_i, no_j] = laukums[uz_i, uz_j];
            laukums[uz_i, uz_j] = tmp;
        }

        /// <summary>
        /// Atver iepriekš saglabātu spēli.
        /// </summary>
        /// <param name="nosaukums">Atveramās spēles datnes nosaukums ar paplašinājumu.</param>
        public void spele_atvert(string nosaukums)
        {
            StreamReader lasitajs = new StreamReader(nosaukums);
            string[] dati = lasitajs.ReadLine().Split('|');

            if (dati[0].StartsWith("ER"))
            {
                attelu_sk = 25;
                attela_id = int.Parse(dati[0].Remove(0, 2));
            }
            else
            {
                sistemas_atteli = true;
                attelu_sk = 1;
                s_atteli.Add(dati[0]);
            }

            rindu_sk = int.Parse(dati[1]);
            kolonnu_sk = int.Parse(dati[2]);
            kopa = rindu_sk * kolonnu_sk;
            parasta_spele = bool.Parse(dati[3]);
            originala_spele = bool.Parse(dati[4]);
            gajieni = int.Parse(dati[5]);
            laiks = int.Parse(dati[6]);

            if (originala_spele)
            {
                nokluseta_m = vienibas_m;
            }
            else
            {
                nokluseta_m = pelektonu_m;
            }

            laukums = new gabalins[rindu_sk, kolonnu_sk];

            for (int i = 0; i < rindu_sk; i++)
            {
                for (int j = 0; j < kolonnu_sk; j++)
                {
                    dati = lasitajs.ReadLine().Split('|');
                    laukums[i, j] = new gabalins() { m = int.Parse(dati[0]), n = int.Parse(dati[1]), indekss = int.Parse(dati[2]), krasa = rezga_krasa, matrica = nokluseta_m };

                    if ((int.Parse(dati[2]) == kopa) && (!parasta_spele))
                    {
                        pedejais = new int[2] { i, j };
                    }
                }
            }

            lasitajs.Close();

            ir_salikta = false;
            notiek_spele = taimeris.Enabled = radit_rezgi.Visible = radit_prieksskatijuma_rezgi.Visible = radit_indeksus.Visible = ieprieksejais.Visible = nakamais.Visible = gajieni_txt.Visible = laiks_txt.Visible = attels_txt.Visible = saglabātSpēliToolStripMenuItem.Visible = attēlaPriekšskatījumsToolStripMenuItem.Enabled = pārlādētPuzlesAttēluToolStripMenuItem.Enabled = true;
            gajieni_txt.Text = "Gājieni: " + gajieni.ToString();
            laiks_txt.Text = "Laiks: " + laiks.ToString();
            statuss_txt.Text = "Notiek spēle...";

            mainit_attelu(attela_id);
        }

        /// <summary>
        /// Saglabā pašreizējo spēles stāvokli.
        /// </summary>
        /// <param name="nosaukums">Saglabājamās teksta datnes nosaukums ar paplašinājumu.</param>
        public void spele_saglabat(string nosaukums)
        {
            StreamWriter rakstitajs = new StreamWriter(nosaukums);

            if (sistemas_atteli)
            {
                rakstitajs.Write(s_atteli[attela_id]);
            }
            else
            {
                rakstitajs.Write("ER" + attela_id);
            }

            rakstitajs.WriteLine("|{0}|{1}|{2}|{3}|{4}|{5}", rindu_sk, kolonnu_sk, parasta_spele, originala_spele, gajieni, laiks);

            for (int i = 0; i < rindu_sk; i++)
            {
                for (int j = 0; j < kolonnu_sk; j++)
                {
                    rakstitajs.WriteLine("{0}|{1}|{2}", laukums[i, j].m, laukums[i, j].n, laukums[i, j].indekss);
                }
            }

            rakstitajs.Close();
        }

        /// <summary>
        /// Pārbauda vai puzle ir salikta.
        /// </summary>
        public void vai_ir_salikta()
        {
            if (vai_ir_pec_kartas())
            {
                taimeris.Enabled = false;
                ir_salikta = true;
                statuss_txt.Text = "Puzle ir salikta!";

                StreamWriter rakstitajs = new StreamWriter("rezultati.txt", true);
                DateTime datums = DateTime.Now;
                string formats = "yyyy.MM.dd.|hh:mm";

                rakstitajs.Write("{0}|{1}|{2}|{3}|{4}|{5}|{6}|", datums.ToString(formats), parasta_spele, originala_spele, rindu_sk, kolonnu_sk, laiks, gajieni);

                if (sistemas_atteli)
                {
                    rakstitajs.WriteLine("{0}", s_atteli[attela_id]);
                }
                else
                {
                    rakstitajs.WriteLine("{0}. attēls", attela_id + 1);
                }

                rakstitajs.Close();

                if (p_rezultati)
                {
                    if (MessageBox.Show("Puzle ir veiksmīgi salikta.\n\nIzmantotie gājieni: " + gajieni.ToString() + ".\nPatērētais laiks: " + minutes + ":" + sekundes + ".\n\nVai vēlaties likt jaunu puzli?", "Puzle salikta", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        sakt_jaunu_speli();
                    }
                }
                else
                {
                    sakt_jaunu_speli();
                }
            }
        }

        /// <summary>
        /// Pārbauda vai puzles gabaliņu indeksi ir pēc kārtas (pieaugošā secībā).
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Zīmē puzles gabaliņu.
        /// </summary>
        /// <param name="i">Gabaliņa rindas indekss.</param>
        /// <param name="j">Gabaliņa kolonnu indekss.</param>
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
                g.DrawString(laukums[i, j].indekss.ToString(), new Font(fonts.FontFamily, augstums / 3, fonts.Style), new SolidBrush(indeksu_krasa), i * platums, j * augstums);
            }
        }

        /// <summary>
        /// Zīmē visu puzles laukumu un visus puzles gabaliņus.
        /// </summary>
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

        /// <summary>
        /// Zīmē režģi priekšskatījuma panelī.
        /// </summary>
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
                prieksskatijums.BackgroundImage = new Bitmap(attela_resurss, prieksskatijums.Width, prieksskatijums.Height);
            }
        }

        public galvena_forma()
        {
            InitializeComponent();

            if (File.Exists("iepriekseja_spele.txt")) {
                spele_atvert("iepriekseja_spele.txt");
            }
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

        private void galvena_forma_FormClosed(object sender, FormClosedEventArgs e)
        {
            izietToolStripMenuItem_Click(sender, e);
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

        private void prieksskatijums_Paint(object sender, PaintEventArgs e)
        {
            if (radit_prieksskatijuma_rezgi.Checked)
            {
                zimet_prieksskatijuma_rezgi();
            }
        }

        private void radit_rezgi_CheckedChanged(object sender, EventArgs e)
        {
            zimet_laukumu();
        }

        private void radit_prieksskatijuma_rezgi_CheckedChanged(object sender, EventArgs e)
        {
            prieksskatijuma_rezgis = radit_prieksskatijuma_rezgi.Checked;
            zimet_prieksskatijuma_rezgi();
        }

        private void radit_indeksus_CheckedChanged(object sender, EventArgs e)
        {
            indekss_txt.Visible = radit_indeksus.Checked;
            zimet_laukumu();
        }

        private void ieprieksejais_Click(object sender, EventArgs e)
        {
            if (attela_id == 0)
            {
                attela_id = attelu_sk - 1;
            }
            else
            {
                attela_id--;
            }

            mainit_attelu(attela_id);
        }

        private void nakamais_Click(object sender, EventArgs e)
        {
            if (attela_id == attelu_sk - 1)
            {
                attela_id = 0;
            }
            else
            {
                attela_id++;
            }

            mainit_attelu(attela_id);
        }

        private void jaunaSpēleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((notiek_spele) && (!ir_salikta))
            {
                if (p_jauna_spele)
                {
                    if (MessageBox.Show("Vai tiešām vēlaties sākt jaunu spēli?", "Notiek spēle", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        sakt_jaunu_speli();
                    }
                }
                else
                {
                    sakt_jaunu_speli();
                }
            }
            else
            {
                sakt_jaunu_speli();
            }
        }

        private void atvērtSpēliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ad = new OpenFileDialog();
            ad.Title = "Atvērt spēli...";
            ad.Filter = "Teksta datne (*.txt)|*.txt";
            ad.AddExtension = ad.CheckPathExists = ad.CheckFileExists = true;

            if (ad.ShowDialog() == DialogResult.OK)
            {
                spele_atvert(ad.FileName);
            }
        }

        private void saglabātSpēliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Title = "Saglabāt spēli...";
            sd.Filter = "Teksta datne (*.txt)|*.txt";
            sd.AddExtension = sd.CheckPathExists = true;

            if (sd.ShowDialog() == DialogResult.OK)
            {
                spele_saglabat(sd.FileName);
            }
        }

        private void izietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.Delete("atteli.txt");
            File.Delete("palidziba.txt");
            File.Delete("iepriekseja_spele.txt");

            if ((notiek_spele) && (!ir_salikta) && (p_saglabat))
            {
                spele_saglabat("iepriekseja_spele.txt");
            }

            Application.Exit();
        }

        private void attēlaPriekšskatījumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prieksskatijums_Click(sender, e);
        }

        private void pārlādētPuzlesAttēluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelis_spele.Refresh();
        }

        private void sākotnējaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainit_formas_izmeru(735, 441);
        }

        private void pēcAugstumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainit_formas_izmeru(this.Height * 5 / 3, this.Height);
        }

        private void pēcPlatumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainit_formas_izmeru(this.Width, this.Width * 3 / 5);
        }

        private void rezultātiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists("rezultati.txt"))
            {
                MessageBox.Show("Spēļu rezultāti pašlaik nav pieejami, jo nav salikta neviena puzle vai arī nav pieejama \"rezultati.txt\" datne.", "Rezultāti nav pieejami.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                rezultatu_forma forma = new rezultatu_forma();
                forma.ShowDialog();
            }
        }

        private void iestatījumiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color rezga_v = rezga_krasa;

            iestatijumu_forma forma = new iestatijumu_forma();
            forma.ShowDialog();

            if (notiek_spele)
            {
                for (int i = 0; i < rindu_sk; i++)
                {
                    for (int j = 0; j < kolonnu_sk; j++)
                    {
                        if (laukums[i, j].krasa == rezga_v)
                        {
                            laukums[i, j].krasa = rezga_krasa;
                        }
                    }
                }

                laukuma_dati();
            }
        }

        private void apskatītPalīdzībuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            atvert_teksta_datni("palidziba.txt");
        }

        private void apskatītProgrammasPirmkoduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/arvislacis/puzlicis");
        }

        private void izmantotieAttēliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            atvert_teksta_datni("atteli.txt");
        }

        private void sūtītAtsauksmiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:arvis.lacis@inbox.lv?subject=Puzlicis");
        }

        private void parToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Puzlicis " + Application.ProductVersion.ToString() + "\nVienkārša attēlu puzļu likšanas programma.\n\nLatvijas Lauksaimniecības universitāte\nInformācijas tehnoloģiju fakultāte\n2. kurss Programmēšana\n\n© 2013-2014 Arvis Lācis", "Par Puzlici", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
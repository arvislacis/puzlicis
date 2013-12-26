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
        public bool notiek_spele = false;
        public Color rezga_krasa;
        public ImageAttributes efekti;
        public int attelu_sk = 25, attela_id, platums, augstums;
        public static bool jauna_spele = false;
        public static int rindu_sk, kolonnu_sk;

        public gabalins[,] laukums;
        public class gabalins
        {
            public int indekss, m, n;
        }

        public void laukuma_dati()
        {
            attels = new Bitmap(Image.FromStream(projekts.GetManifestResourceStream("puzlicis.atteli.attels_" + attela_id.ToString() + ".jpg")), panelis_spele.Width, panelis_spele.Height);
            prieksskatijums.BackgroundImage = new Bitmap(attels, prieksskatijums.Width, prieksskatijums.Height);
            platums = panelis_spele.Width / rindu_sk;
            augstums = panelis_spele.Height / kolonnu_sk;
            rezga_krasa = Color.Red;
            efekti = new ImageAttributes();
            efekti.SetGamma(1.0f);
            // TODO Melnbaltā spēles režīma atbalsts
            //efekti.SetColorMatrix(new ColorMatrix(
            //    new float[][]{
            //        new float[] {.3f, .3f, .3f, 0, 0},
            //        new float[] {.59f, .59f, .59f, 0, 0},
            //        new float[] {.11f, .11f, .11f, 0, 0},
            //        new float[] {0, 0, 0, 1, 0},
            //        new float[] {0, 0, 0, 0, 1}
            //    }));
        }

        public void generet_laukumu()
        {
            int skaititajs = 1;
            laukums = new gabalins[rindu_sk, kolonnu_sk];

            for (int i = 0; i < rindu_sk; i++)
            {
                for (int j = 0; j < kolonnu_sk; j++)
                {
                    laukums[i, j] = new gabalins()
                    {
                        // TODO Atrasta veidu kā samainīt indeksa pozīciju (rindas x kolonnas)
                        indekss = skaititajs,
                        m = i,
                        n = j
                    };

                    skaititajs++;
                }
            }

            Random r = new Random();
            gabalins tmp = new gabalins();
            int[] r1, r2;
            
            attela_id = r.Next(1, attelu_sk);

            for (int i = 0; i < rindu_sk * kolonnu_sk * 2; i++)
            {
                r1 = new int[2] {r.Next(0, rindu_sk), r.Next(0, kolonnu_sk)};
                r2 = new int[2] {r.Next(0, rindu_sk), r.Next(0, kolonnu_sk)};

                tmp = laukums[r1[0], r1[1]];
                laukums[r1[0], r1[1]] = laukums[r2[0], r2[1]];
                laukums[r2[0], r2[1]] = tmp;
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

                    g.DrawImage(attels, kur_zimet, laukums[i, j].m * platums, laukums[i, j].n * augstums, platums, augstums, GraphicsUnit.Pixel, efekti);
                    // TODO Atbalstīt ciparu rādīšanu uz puzles gabaliņiem (lai atvieglotu tās salikšanu)
                    // g.DrawString(laukums[i, j].indekss.ToString(), new Font(FontFamily.GenericSansSerif, 26), Brushes.White, i * platums, j * augstums);
                    
                    if (radit_rezgi.Checked)
                    {
                        g.DrawRectangle(new Pen(rezga_krasa, 2.0f), i * platums, j * augstums, platums, augstums);
                    }
                }
            }
        }

        public galvena_forma()
        {
            InitializeComponent();
        }

        private void galvena_forma_SizeChanged(object sender, EventArgs e)
        {
            // TODO Jāizlabo kļūda, kas rodas programmu minimizējot
            if (notiek_spele)
            {
                laukuma_dati();
                zimet_laukumu();
            }
        }

        private void prieksskatijums_Click(object sender, EventArgs e)
        {
            if (notiek_spele)
            {
                prieksskatijuma_forma forma = new prieksskatijuma_forma();
                forma.BackgroundImage = new Bitmap(Image.FromStream(projekts.GetManifestResourceStream("puzlicis.atteli.attels_" + attela_id.ToString() + ".jpg")), forma.Width, forma.Height);
                forma.ShowDialog();
            }
        }

        private void radit_rezgi_CheckedChanged(object sender, EventArgs e)
        {
            zimet_laukumu();
        }

        private void jaunaSpēleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jaunas_speles_forma forma = new jaunas_speles_forma();
            forma.ShowDialog();
            
            if (jauna_spele)
            {
                notiek_spele = attēlaPriekšskatījumsToolStripMenuItem.Enabled = radit_rezgi.Visible = true;

                generet_laukumu();
                laukuma_dati();
                zimet_laukumu();
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

        private void galvena_forma_Resize(object sender, EventArgs e)
        {
            // TODO Jāizlabo kļūda, kas rodas programmu minimizējot
            if (notiek_spele)
            {
                laukuma_dati();
                zimet_laukumu();
            }
        }
    }
}
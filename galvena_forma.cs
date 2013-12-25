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
        public bool notiek_spele = false;
        public Color rezga_krasa;
        public ImageAttributes efekti;
        public int platums, augstums, rindu_sk, kolonnu_sk, kopa_sk;

        public gabalins[,] laukums;
        public class gabalins
        {
            public int indekss, m, n;
        }

        public void laukuma_dati()
        {
            attels = new Bitmap(Image.FromStream(projekts.GetManifestResourceStream("puzlicis.atteli.attels_01.jpg")), panelis_spele.Width, panelis_spele.Height);
            prieksskatijums.BackgroundImage = new Bitmap(attels, prieksskatijums.Width, prieksskatijums.Height);
            rindu_sk = 4;
            kolonnu_sk = 4;
            kopa_sk = rindu_sk * kolonnu_sk;
            platums = panelis_spele.Width / rindu_sk;
            augstums = panelis_spele.Height / kolonnu_sk;
            rezga_krasa = Color.Red;
            efekti = new ImageAttributes();
            efekti.SetGamma(1.0f);
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

            for (int i = 0; i < kopa_sk * 2; i++)
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
                    //g.DrawString(laukums[i, j].indekss.ToString(), new Font(FontFamily.GenericSansSerif, 26), Brushes.White, i * platums, j * augstums);
                    
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
            // Jāizlabo kļūda, kas rodas programmu minimizējot
            if (notiek_spele)
            {
                laukuma_dati();
                zimet_laukumu();
            }
        }

        private void radit_rezgi_CheckedChanged(object sender, EventArgs e)
        {
            zimet_laukumu();
        }

        private void jaunaSpēleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Jāizlabo kļūda, kas rodas sākot jaunu spēli ar Ctrl+N taustiņu (saistīta ar radit_rezgi.Visible) jeb formas pārzīmēšanos
            radit_rezgi.Visible = true;
            notiek_spele = true;

            laukuma_dati();
            generet_laukumu();
            zimet_laukumu();
        }

        private void izietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Papildus kods, kas saglabā pašreizējo spēles stāvokli
            Application.Exit();
        }
    }
}
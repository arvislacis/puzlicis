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
    public partial class galvena_forma : Form
    {
        public gabalins[,] gabalini;
        
        public class gabalins
        {
            public int indekss;
            public RectangleF no;
        }

        public void generet_laukumu()
        {
            Bitmap attels = new Bitmap(Image.FromFile("attels_01.jpg"), panelis_spele.Width, panelis_spele.Height);
            Graphics g = panelis_spele.CreateGraphics();
            Color krasa = Color.Red;

            int rindu_sk = 4;
            int kolonnu_sk = 4;
            int kopa_sk = rindu_sk * kolonnu_sk;

            float platums = panelis_spele.Width / rindu_sk;
            float augstums = panelis_spele.Height / kolonnu_sk;

            int skaititajs = 1;
            gabalini = new gabalins[rindu_sk, kolonnu_sk];

            for (int i = 0; i < rindu_sk; i++)
            {
                for (int j = 0; j < kolonnu_sk; j++)
                {
                    gabalini[i, j] = new gabalins()
                    {
                        indekss = skaititajs,
                        no = new RectangleF(i * platums, j * augstums, platums, augstums)
                    };

                    skaititajs++;
                }
            }

            Random r = new Random();
            gabalins tmp = new gabalins();
            int[] r1, r2;

            for (int i = 0; i < kopa_sk * 2; i++)
            {
                r1 = new int[2] {r.Next(0, rindu_sk),r.Next(0, kolonnu_sk)};
                r2 = new int[2] {r.Next(0, rindu_sk),r.Next(0, kolonnu_sk)};

                tmp = gabalini[r1[0], r1[1]];
                gabalini[r1[0], r1[1]] = gabalini[r2[0], r2[1]];
                gabalini[r2[0], r2[1]] = tmp;
            }

            for (int i = 0; i < rindu_sk; i++)
            {
                for (int j = 0; j < kolonnu_sk; j++)
                {
                    g.DrawImage(attels, new RectangleF(i * platums, j * augstums, platums, augstums), gabalini[i, j].no, GraphicsUnit.Pixel);
                    //g.DrawString(gabalini[i, j].indekss.ToString(), new Font(FontFamily.GenericSansSerif, 26), Brushes.White, i * platums, j * augstums);
                    g.DrawRectangle(new Pen(krasa, 2.0f), i * platums, j * augstums, platums, augstums);
                }
            }
        }

        public galvena_forma()
        {
            InitializeComponent();
        }

        private void panelis_spele_MouseClick(object sender, MouseEventArgs e)
        {
            generet_laukumu();
        }
    }
}

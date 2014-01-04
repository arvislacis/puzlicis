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
    public partial class prieksskatijuma_forma : Form
    {
        public prieksskatijuma_forma()
        {
            InitializeComponent();
        }

        private void prieksskatijuma_forma_Paint(object sender, PaintEventArgs e)
        {
            if (galvena_forma.prieksskatijuma_rezgis)
            {
                Graphics g = this.CreateGraphics();

                for (int i = 0; i < galvena_forma.rindu_sk; i++)
                {
                    for (int j = 0; j < galvena_forma.kolonnu_sk; j++)
                    {
                        g.DrawRectangle(new Pen(galvena_forma.rezga_krasa, 2.0f), i * this.Width / galvena_forma.rindu_sk, j * this.Height / galvena_forma.kolonnu_sk, this.Width / galvena_forma.rindu_sk, this.Height / galvena_forma.kolonnu_sk);
                    }
                }
            }
        }

        private void prieksskatijuma_forma_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Control == true) && (e.KeyCode == Keys.P))
            {
                prieksskatijuma_forma_Click(sender, e);
            }
        }

        private void prieksskatijuma_forma_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
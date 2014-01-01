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

        // TODO Nodrošināt aizvēršanu ar Ctrl+P komandu (tāpat kā tiek atvērts)
        private void prieksskatijuma_forma_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace puzlicis
{
    public partial class rezultatu_forma : Form
    {
        public GraphPane g;
        public LineItem visi_l, parasta_org_l, parasta_plk_l, piecpadsmit_org_l, piecpadsmit_plk_l;
        public PointPairList visi_p = new PointPairList();
        public PointPairList parasta_org_p = new PointPairList();
        public PointPairList parasta_plk_p = new PointPairList();
        public PointPairList piecpadsmit_org_p = new PointPairList();
        public PointPairList piecpadsmit_plk_p = new PointPairList();

        public void zimet_grafiku()
        {
            g = grafiks.GraphPane;
            g.Border.IsVisible = g.Chart.Border.IsVisible = g.Legend.Border.IsVisible = g.Title.IsVisible = false;
            g.Chart.Fill = g.Fill = g.Legend.Fill = new Fill(SystemColors.Control);

            g.XAxis.Title.Text = "Laiks (s)";
            g.XAxis.Scale.MinorStepAuto = g.XAxis.Scale.MajorStepAuto = g.XAxis.Scale.MinAuto = g.XAxis.Scale.MaxAuto = g.XAxis.CrossAuto = true;

            g.YAxis.Title.Text = "Gājieni";
            g.YAxis.Scale.MinorStepAuto = g.YAxis.Scale.MajorStepAuto = g.YAxis.Scale.MinAuto = g.YAxis.Scale.MaxAuto = g.YAxis.CrossAuto = true;

            StreamReader lasitajs = new StreamReader("rezultati.txt");

            while (!lasitajs.EndOfStream)
            {
                string[] dati = lasitajs.ReadLine().Split('|');
                string info = "Laiks: " + dati[6] + " s\nGājieni: " + dati[7] + "\nDatums: " + dati[0] + " " + dati[1] + "\nIzmērs: " + dati[4] + "x" + dati[5] + "\nAttēls: " + dati[8];

                visi_p.Add(double.Parse(dati[6]), double.Parse(dati[7]), info);

                if ((bool.Parse(dati[2])) && (bool.Parse(dati[3])))
                {
                    parasta_org_p.Add(double.Parse(dati[6]), double.Parse(dati[7]), info);
                }
                else if ((bool.Parse(dati[2])) && (!bool.Parse(dati[3])))
                {
                    parasta_plk_p.Add(double.Parse(dati[6]), double.Parse(dati[7]), info);
                }

                if ((!bool.Parse(dati[2])) && (bool.Parse(dati[3])))
                {
                    piecpadsmit_plk_p.Add(double.Parse(dati[6]), double.Parse(dati[7]), info);
                }
                else if ((!bool.Parse(dati[2])) && (!bool.Parse(dati[3])))
                {
                    piecpadsmit_org_p.Add(double.Parse(dati[6]), double.Parse(dati[7]), info);
                }
            }

            lasitajs.Close();

            visi_p.Sort(SortType.XValues);
            parasta_org_p.Sort(SortType.XValues);
            parasta_plk_p.Sort(SortType.XValues);
            piecpadsmit_org_p.Sort(SortType.XValues);
            piecpadsmit_plk_p.Sort(SortType.XValues);
            
            visi_l = g.AddCurve("Visas spēles", visi_p, Color.Red, SymbolType.Star);
            parasta_org_l = g.AddCurve("Parastā oriģinālā", parasta_org_p, Color.Green, SymbolType.Star);
            parasta_plk_l = g.AddCurve("Parastā pelēktoņu", parasta_plk_p, Color.Gray, SymbolType.Star);
            piecpadsmit_org_l = g.AddCurve("Piecpadsmitoriģinālā", piecpadsmit_org_p, Color.Blue, SymbolType.Star);
            piecpadsmit_plk_l = g.AddCurve("Piecpadsmit pelēktoņu", piecpadsmit_plk_p, Color.Orange, SymbolType.Star);

            parasta_org_l.IsVisible = parasta_plk_l.IsVisible = piecpadsmit_org_l.IsVisible = piecpadsmit_plk_l.IsVisible = false;
            g.AxisChange();
        }

        public rezultatu_forma()
        {
            InitializeComponent();
            zimet_grafiku();
        }

        public void zimet_linijas()
        {
            parasta_org_l.IsVisible = parasta_plk_l.IsVisible = piecpadsmit_org_l.IsVisible = piecpadsmit_plk_l.IsVisible = false;

            if ((parastas.Checked) && (originalas.Checked))
            {
                parasta_org_l.IsVisible = true;
            }
            else if ((parastas.Checked) && (!originalas.Checked))
            {
                parasta_plk_l.IsVisible = true;
            }

            if ((!parastas.Checked) && (originalas.Checked))
            {
                piecpadsmit_org_l.IsVisible = true;
            }
            else if ((!parastas.Checked) && (!originalas.Checked))
            {
                piecpadsmit_plk_l.IsVisible = true;
            }
        }

        private void visas_CheckedChanged(object sender, EventArgs e)
        {
            visi_l.IsVisible = visas.Checked;
            veids.Enabled = krasa.Enabled = !visas.Checked;

            if (!visas.Checked)
            {
                zimet_linijas();
            }

            grafiks.Refresh();
        }

        private void parastas_CheckedChanged(object sender, EventArgs e)
        {
            zimet_linijas();
            grafiks.Refresh();
        }

        private void piecpadsmit_CheckedChanged(object sender, EventArgs e)
        {
            zimet_linijas();
            grafiks.Refresh();
        }

        private void originalas_CheckedChanged(object sender, EventArgs e)
        {
            zimet_linijas();
            grafiks.Refresh();
        }

        private void pelektonu_CheckedChanged(object sender, EventArgs e)
        {
            zimet_linijas();
            grafiks.Refresh();
        }
    }
}

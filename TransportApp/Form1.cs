using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCombobox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            int distance = Int32.Parse(txt_dist.Text);
            if ((string)cb_type.SelectedItem == "Routière")
            {
                Cargaison cargaison = new CargaisonRoutiere(distance);
                listCargaison.Items.Add(cargaison.ToString());
            }
            else
            {
                Cargaison cargaison = new CargaisonAerienne(distance);
                listCargaison.Items.Add(cargaison.ToString());
            }
        }
        private void LoadCombobox()
        {
            cb_type.Items.Add("Routière");
            cb_type.Items.Add("Aeriènne");
        }

        private void btn_add_cargaison_Click(object sender, EventArgs e)
        {
            object o = listCargaison.SelectedItems;
            if (o != null)
            {
                Cargaison c = (Cargaison)o;
                int num = Int32.Parse(txt_num.Text);
                double poids = Double.Parse(txt_poids.Text);
                double volume = Double.Parse(txt_volume.Text);
                Marchandise m = new Marchandise(num, poids, volume);
                c.add(m);
                datagrid.Rows.Add(m.Numero, m.Poids, m.Volume);
            }
        }

        private void listCargaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            object o = listCargaison.SelectedItems;
            if (o != null)
            {
                datagrid.Rows.Clear();
                Cargaison c = (Cargaison)o;
                if (c != null)
                {
                    List<Marchandise> mdises = c.GetMarchandises();
                    foreach (Marchandise m in mdises)
                    {
                        datagrid.Rows.Add(m.Numero, m.Poids, m.Volume);
                    }
                }
                lbl_cout.Text = c.cout().ToString();
            }
        }
    }
    }


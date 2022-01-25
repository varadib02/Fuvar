using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using myclass_Fuvar;

namespace FuvarGUI
{
    public partial class FuvarGUI : Form
    {
        List<taxi> olvas = new List<taxi>();
        public FuvarGUI()
        {
            InitializeComponent();
            ControlBox = false;
        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            
            beo(ref olvas);
            /*
            foreach (var i in olvas)
            {
                lB_fuvar.Items.Add(i.azon);
            }*/
            lB_fuvar.DataSource = olvas;
            lB_fuvar.DisplayMember = "azon";
        }
        private void beo(ref List<taxi> t)
        {
            foreach (var sor in File.ReadAllLines("fuvar.csv").Skip(1)) t.Add(new taxi(sor));
        }

        private void lB_fuvar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selected_item(olvas);
            txtb_azon.Text=((taxi)lB_fuvar.SelectedItem).azon.ToString();
            txtb_ind.Text = ((taxi)lB_fuvar.SelectedItem).indulás.ToString();
            txtb_ido.Text = ((taxi)lB_fuvar.SelectedItem).idotartam.ToString();
            txtb_tav.Text = ((taxi)lB_fuvar.SelectedItem).tav.ToString();
            txtb_vdij.Text = ((taxi)lB_fuvar.SelectedItem).viteldij.ToString();
            txtb_borravalo.Text = ((taxi)lB_fuvar.SelectedItem).borravalo.ToString();
            txtb_fmod.Text = ((taxi)lB_fuvar.SelectedItem).fizetesmod.ToString();
        }
        /*
        private void selected_item(List<taxi> t)
        {
            
            foreach (var taxi in t)
            {
                if (lB_fuvar.SelectedItem.ToString() == taxi.azon.ToString())
                {
                    txtb_azon.Text = taxi.azon.ToString();
                    txtb_ind.Text = taxi.indulás.ToString();
                    txtb_ido.Text = taxi.idotartam.ToString();
                    txtb_tav.Text = taxi.tav.ToString();
                    txtb_vdij.Text = taxi.viteldij.ToString();
                    txtb_borravalo.Text = taxi.borravalo.ToString();
                    txtb_fmod.Text = taxi.fizetesmod.ToString();
                }

            }
        }
        */
        private void btn_close_Click(object sender, EventArgs e) 
        {
            btn_close_confirm.Visible = true;
        }

        private void btn_close_confirm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            /*
            orderup(ref olvas);
            lB_fuvar.Items.Clear();
            foreach (var i in olvas)
            {
                lB_fuvar.Items.Add(i.azon);
            }
            */
            //List<taxi>f=olvas.OrderBy(x=>x.azon).ToList();
            olvas=olvas.OrderBy(x => x.azon).ToList();
            lB_fuvar.DataSource = olvas;
            //lB_fuvar.DataSource = f;
            //lB_fuvar.DisplayMember="azon";
        }
        /*
        private void orderup(ref List<taxi>t) 
        {
         //növekvő   
            for (int a = 0; a < t.Count - 2; a++)
            {
                for (int b = 0; b < t.Count - 2; b++)
                {
                    if (t[a].azon<t[b].azon)
                    {
                        taxi csere = t[a];
                        t[a] = t[b];
                        t[b] = csere;
                    }
                    
                }
            }

        }
        */

    }
}

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
using Fuvar;

namespace FuvarGUI
{
    public partial class FuvarGUI : Form
    {
        public FuvarGUI()
        {
            InitializeComponent();
            ControlBox = false;
        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            List<taxi> t = new List<taxi>();
            beo(ref t);
            foreach (var i in t)
            {
                lB_fuvar.Items.Add(i.azon);
            }
        }
        private void beo(ref List<taxi> t)
        {
            foreach (var sor in File.ReadAllLines("fuvar.csv").Skip(1)) t.Add(new taxi(sor));
        }

        private void lB_fuvar_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<taxi> t = new List<taxi>();
            beo(ref t);
            selected_item(t);


        }
        private void selected_item(List<taxi> t)
        {
            foreach (var taxi in t)
            {
                string azon_s = lB_fuvar.SelectedItem.ToString();
                string tazon = taxi.azon.ToString();
                if (tazon == azon_s)
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lB_fuvar.Items.Clear();
        }

        private void btn_close_Click(object sender, EventArgs e) 
        {
            btn_close_confirm.Visible=true;
                
        }

        private void btn_close_confirm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuvar
{
    class taxi
    {
        public int azon { get; set; }
        public DateTime indulás { get; set; }
        public int idotartam { get; set; }
        public double tav { get; set; }
        public double viteldij { get; set; }
        public double borravalo { get; set; }
        public string fizetesmod { get; set; }
        public taxi(string sor)
        {
            string[] db = sor.Split(';');
            azon = int.Parse(db[0]);
            indulás = DateTime.Parse(db[1]);
            idotartam = int.Parse(db[2]);
            tav = double.Parse(db[3]);
            viteldij = double.Parse(db[4]);
            borravalo = double.Parse(db[5]);
            fizetesmod = db[6];
            
        }
    }
}

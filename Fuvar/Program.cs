using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fuvar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<taxi> taxik = new List<taxi>();
            foreach (var sor in File.ReadAllLines("fuvar.csv").Skip(1)) taxik.Add(new taxi(sor));
        }
    }
}

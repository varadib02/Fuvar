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
            
            Console.WriteLine($"3.feladat: {taxik.Count} fuvar");
            
            Console.WriteLine($"4.feladat: {taxik.Where(x => x.azon == 6185).Count()} fuvar alatt: {taxik.Where(x=>x.azon==6185).Sum(x=>x.viteldij)}$");
            

            Console.WriteLine($"5.feladat: ");
            Console.WriteLine($"\tbankkártya {taxik.Where(x=>x.fizetesmod=="bankkártya").Count()} fuvar");
            Console.WriteLine($"\tkészpénz {taxik.Where(x=>x.fizetesmod== "készpénz").Count()} fuvar");
            Console.WriteLine($"\tvitatott {taxik.Where(x=>x.fizetesmod== "vitatott").Count()} fuvar");
            Console.WriteLine($"\tingyenes {taxik.Where(x=>x.fizetesmod=="ingyenes").Count()} fuvar");
            Console.WriteLine($"\tismeretlen {taxik.Where(x=>x.fizetesmod=="ismeretlen").Count()} fuvar");

            Console.WriteLine("6.feladat: {0:0.00}km", taxik.Sum(x => x.tav * 1.6));
            
            Console.WriteLine($"7.feladat: Leghosszabb fuvar:");
            taxi t=taxik.OrderBy(x => x.idotartam).Last();
            Console.WriteLine($"\tFuvar hossza: {t.idotartam} másodperc");
            Console.WriteLine($"\tTaxi azonosító: {t.azon}");
            Console.WriteLine($"\tMegtett távolság: {t.tav} km");
            Console.WriteLine($"\tViteldij: {t.viteldij}$");

            Console.WriteLine($"8.feladat: hibak.txt");

            StreamWriter sw = File.CreateText("hibak.txt");
            sw.WriteLine("taxi_id;indulas;idotartam;tavolsag;viteldij;borravalo;fizetes_modja");
            taxik
                .Where(x=>x.idotartam>0 && x.viteldij>0 && x.tav==0)
                .OrderBy(x => x.indulás)
                .ToList()
                .ForEach(x=>sw.WriteLine($"{x.azon};{x.indulás};{x.idotartam};{x.tav};{x.viteldij};{x.borravalo};{x.fizetesmod}"));

        }
    }
}

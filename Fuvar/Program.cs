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
            
            Console.WriteLine($"4.feladat: {taxik.Where(x => x.azon == 6185).Count()} fuvar alatt: {taxik.Where(x=>x.azon==6185).Sum(x=>x.viteldij+x.borravalo)}$");
            
            Console.WriteLine($"5.feladat: ");
            Console.WriteLine($"bankkártya {taxik.Where(x=>x.fizetesmod=="bankkártya").Count()} fuvar");
            Console.WriteLine($"készpénz {taxik.Where(x=>x.fizetesmod== "készpénz").Count()} fuvar");
            Console.WriteLine($"vitatott {taxik.Where(x=>x.fizetesmod== "vitatott").Count()} fuvar");
            Console.WriteLine($"ingyenes {taxik.Where(x=>x.fizetesmod=="ingyenes").Count()} fuvar");
            Console.WriteLine($"ismeretlen {taxik.Where(x=>x.fizetesmod=="ismeretlen").Count()} fuvar");
        }
    }
}

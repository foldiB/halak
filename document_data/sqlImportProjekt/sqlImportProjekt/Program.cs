using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlImportProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fajlnev = "landscapesnames.txt", fajlfaj = "species.txt", halimportFajl = "halimport.sql";
            Halak k = new Halak(fajlnev, fajlfaj, halimportFajl);

            Console.WriteLine("{0}", k.eee(fajlnev, fajlfaj));
            //Console.WriteLine("forrás -> {0}",);
            Console.ReadLine();


        }
    }
}

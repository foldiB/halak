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
            string fajlnev = "nev.txt", fajlfaj = "faj.txt", halimportFajl = "halimport.sql";
            Halak k = new Halak(fajlnev, fajlfaj, halimportFajl);

            //Console.WriteLine("forrás -> {0}",);
            Console.ReadLine();


        }
    }
}

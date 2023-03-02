using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace sqlImportProjekt
{
    internal class Halak
    {
        List<Specie> species = new List<Specie>();
        List<Landscapename> landscapenames = new List<Landscapename>();
       

        private string fajlnev;
        private string fajlfaj;
        private string halimportFajl;

        public Halak(string fajlnev, string fajlfaj, string halimportFajl)
        {
            this.fajlnev = fajlnev;
            this.fajlfaj = fajlfaj;
            this.halimportFajl = halimportFajl;
            BeolvasLandscapename();
            Beolvasspecies();
            ImportGenerátor();
        }

        internal int eee(string fajlnev, string fajlfaj)
        {
            return landscapenames.Count();
        }

        private void BeolvasLandscapename()
        {
            string[] sorok = File.ReadAllLines(fajlnev);
            foreach (var sor in sorok.Skip(1))
            {
                string[] oszlopok = sor.Split('\t');
                int fishid =int.Parse(oszlopok[0]);
                string landscapename =$"'{oszlopok[1]}'";
                landscapenames.Add(new Landscapename(fishid, landscapename));
            }
        }
        
        private void Beolvasspecies()
        {
            string[] sorok = File.ReadAllLines(fajlfaj);
            foreach (var sor in sorok.Skip(1))
            {
                string[] oszlopok = sor.Split('\t');
                int id = int.Parse(oszlopok[0]);
                string fishname = $"'{oszlopok[1]}'";
                int note = int.Parse(oszlopok[2]);
                string frequency = $"'{oszlopok[3]}'";
                int occurrence = int.Parse(oszlopok[4]);
                int protecteds = int.Parse(oszlopok[5]);
                species.Add(new Specie(id, fishname, note, frequency, occurrence, protecteds));
    }
        }

        private void ImportGenerátor()
        {
            delteGenerátor();
     
            jelentkezésGenerátor();
            vizsgaGenerátor();
            selectGenerátor();
        }




        private void selectGenerátor()
        {
            List<string> fsorok = new List<string>();
            fsorok.Add("");
            fsorok.Add("SELECT * FROM species;");
            fsorok.Add("SELECT * FROM landscapenames;");
            
            File.AppendAllLines(halimportFajl, fsorok);
        }

        private void jelentkezésGenerátor()
        {
            List<string> fsorok = new List<string>();

            string szoveg = Environment.NewLine + "# jelentkezések" + Environment.NewLine;
            szoveg += "INSERT INTO species (id, fishname, note, frequency, occurrence, protected) VALUES" + Environment.NewLine;

            foreach (var jelenkezes in species)
            {
                string sor = $"({jelenkezes.id},{jelenkezes.fishname },{jelenkezes.note},{jelenkezes.frequency},{jelenkezes.occurrence},{jelenkezes.protecteds})";
                fsorok.Add(sor);
            }

            szoveg += String.Join("," + Environment.NewLine, fsorok);
            szoveg += ";";

            File.AppendAllText(halimportFajl, szoveg);
        }
       

   private void vizsgaGenerátor()
        {
            List<string> fsorok = new List<string>();

            string szoveg = Environment.NewLine + "# vizsgák" + Environment.NewLine;
            szoveg += "INSERT INTO landscapenames (landscapename, specifiesid) VALUES" + Environment.NewLine;

            foreach (var vizsga in landscapenames)
            {
                string sor = $"({vizsga.landscapename}, {vizsga.fishid})";
                fsorok.Add(sor);
            }

            szoveg += String.Join("," + Environment.NewLine, fsorok);
            szoveg += ";";

            File.AppendAllText(halimportFajl, szoveg);
        }

       

        private void delteGenerátor()
        {
            List<string> fsorok = new List<string>();
            fsorok.Add("DELETE FROM species;");
            fsorok.Add("DELETE FROM landscapenames;");
         
            File.WriteAllLines(halimportFajl, fsorok);
        }  
    }
}
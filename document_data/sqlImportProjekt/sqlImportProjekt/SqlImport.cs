using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace sqlImportProjekt
{
    internal class Halak
    {
       

        private string fajlnev;
        private string fajlfaj;
        private string halimportFajl;

        public Halak(string fajlnev, string fajlfaj, string halimportFajl)
        {
            this.fajlnev = fajlnev;
            this.fajlfaj = fajlfaj;
            this.halimportFajl = halimportFajl;
            BeolvasNev();
            BeolvasFaj();
            //ImportGenerátor();
        }

        private void BeolvasFaj()
        {
            throw new NotImplementedException();
        }

        private void BeolvasNev()
        {
            throw new NotImplementedException();
        }

        private void ImportGenerátor()
        {
            delteGenerátor();
            hallgatóGenerátor();
            vizsgaGenerátor();
            jelentkezésGenerátor();
            selectGenerátor();
        }

        private void selectGenerátor()
        {
            //List<string> fsorok = new List<string>();
            //fsorok.Add("");
            //fsorok.Add("SELECT * FROM hallgato;");
            //fsorok.Add("SELECT * FROM jelentkezes;");
            //fsorok.Add("SELECT * FROM vizsga;");
            //File.AppendAllLines(fajlKollokviumImport, fsorok);
        }

        private void jelentkezésGenerátor()
        {
            //List<string> fsorok = new List<string>();

            //string szoveg = Environment.NewLine + "# jelentkezések" + Environment.NewLine;
            //szoveg += "INSERT INTO jelentkezes (hallgatoid, vizsgaid, jeldatum, ledatum, igazolt, jegy) VALUES" + Environment.NewLine;

            //foreach (var jelenkezes in jelentkezesek)
            //{
            //    string sor = $"({jelenkezes.hallgatoid},{jelenkezes.vizsgaid},{jelenkezes.jeldatum},{jelenkezes.ledatum},{jelenkezes.igazolt},{jelenkezes.jegy})";
            //    fsorok.Add(sor);
            //}

            //szoveg += String.Join("," + Environment.NewLine, fsorok);
            //szoveg += ";";

            //File.AppendAllText(fajlKollokviumImport, szoveg);
        }

        private void vizsgaGenerátor()
        {
            //List<string> fsorok = new List<string>();

            //string szoveg = Environment.NewLine + "# vizsgák" + Environment.NewLine;
            //szoveg += "INSERT INTO vizsga (id, datum, targy) VALUES" + Environment.NewLine;

            //foreach (var vizsga in vizsgak)
            //{
            //    string sor = $"({vizsga.id}, {vizsga.datum}, {vizsga.targy})";
            //    fsorok.Add(sor);
            //}

            //szoveg += String.Join("," + Environment.NewLine, fsorok);
            //szoveg += ";";

            //File.AppendAllText(fajlKollokviumImport, szoveg);
        }

        private void hallgatóGenerátor()
        {
            //List<string> fsorok = new List<string>();

            //string szoveg = Environment.NewLine + "# hallgatók" + Environment.NewLine;
            //szoveg += "INSERT INTO hallgato (id, nev) VALUES" + Environment.NewLine;

            //foreach (var hallgató in hallgatok)
            //{
            //    string sor = $"({hallgató.id}, {hallgató.nev})";
            //    fsorok.Add(sor);
            //}

            //szoveg += String.Join("," + Environment.NewLine, fsorok);
            //szoveg += ";";

            //File.AppendAllText(fajlKollokviumImport, szoveg);
        }

        private void delteGenerátor()
        {
            //List<string> fsorok = new List<string>();
            //fsorok.Add("DELETE FROM jelentkezes;");
            //fsorok.Add("DELETE FROM hallgato;");
            //fsorok.Add("DELETE FROM vizsga;");
            //File.WriteAllLines(fajlKollokviumImport, fsorok);
        }

       

       

        
        
    }
}
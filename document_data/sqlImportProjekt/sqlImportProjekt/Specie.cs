namespace sqlImportProjekt
{
    internal class Specie
    {
        public int id;
        public string fishname;
        public int note;
        public string frequency;
        public int occurrence;
        public int protecteds;

        public Specie(int id, string fishname, int note, string frequency, int occurrence, int protecteds)
        {
            this.id = id;
            this.fishname = fishname;
            this.note = note;
            this.frequency = frequency;
            this.occurrence = occurrence;
            this.protecteds = protecteds;
        }
    }
}
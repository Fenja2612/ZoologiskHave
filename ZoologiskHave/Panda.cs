namespace ZoologiskHave
{
    public class Panda
    {
        public string Navn { get; set; }
        public int Alder { get; set; }
        public string Køn { get; set; }
        public string Oprindelsesland { get; set; }
        public string Art { get; set; }

        public Panda(string navn, int alder, string køn, string oprindelsesland, string art)
        {
            Navn = navn;
            Alder = alder;
            Køn = køn;
            Oprindelsesland = oprindelsesland;
            Art = art;
        }   

        public void Spis()
        {
            Console.WriteLine($"{Navn} spiser bambus.");
        }



    }
}

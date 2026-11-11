public class Panda : Dyr
{
    public Panda(string navn, int alder, string køn, string oprindelsesland, string art) : base(navn, alder, køn, oprindelsesland, art)
    {
        Navn = navn;
        Alder = alder;
        Køn = køn;
        Oprindelsesland = oprindelsesland;
        Art = art;
    }

    public override void Spis()
    {
        Console.WriteLine($"{Navn} spiser bambus.");
    }

    public override void Sov()
    {
        Console.WriteLine($"{Navn} sover.");
    }

}
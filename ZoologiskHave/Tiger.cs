public class Tiger : Dyr
{

    public Tiger(string navn, int alder, string køn, string oprindelsesland, string art) : base(navn, alder, køn, oprindelsesland, art)
    {
        Navn = navn;
        Alder = alder;
        Køn = køn;
        Oprindelsesland = oprindelsesland;
        Art = art;
    }

    public override void Spis()
    {
        Console.WriteLine($"{Navn} spiser koed.");
    }

    public override void Sov()
    {
        Console.WriteLine($"{Navn} sover.");
    }

    public void Broeler()
    {
        Console.WriteLine($"{Navn} Broeler.");
    }


}
abstract class Dyr
{
    public string Navn { get; set; }
    public int Alder { get; set; }
    public string Køn { get; set; }
    public string Oprindelsesland { get; set; }
    public string Art { get; set; }

    public Dyr(string navn, int alder, string køn, string oprindelsesland, string art)
    {
        Navn = navn;
        Alder = alder;
        Køn = køn;
        Oprindelsesland = oprindelsesland;
        Art = art;
    }

    public abstract void Spis();
    public abstract void Sov();

}
public class Dyrepasser
{
    public int Id { get; }
    public string Navn { get; set; }

    public Dyrepasser(int id, string navn)
    {
        Id = id;
        Navn = navn;
    }

    public void Tal()
    {
        Console.WriteLine("Hallo, velkommen i vores zoo");
    }

    public void Tal(string tale)
    {
        Console.WriteLine(tale);
    }
}
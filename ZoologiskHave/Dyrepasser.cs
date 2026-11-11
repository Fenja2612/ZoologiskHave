public class Dyrepasser
{
    public int Id;
    public string Navn;

    public Dyrepasser(int id, string navn)
    {
        Id = id;
        Navn = navn;
    }

    public void Tal()
    {
        Console.WriteLine("Hallo, velkommen i vores zoo");
    }
}
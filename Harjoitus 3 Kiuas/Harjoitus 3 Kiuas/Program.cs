internal class Program
{
    private static void Main(string[] args)
    {
               private bool onkoPaalla;
    private double lampotila;
    private double kosteus;

    // Kiuas-luokan konstruktori
    public Kiuas()
    {
        onkoPaalla = false;
        lampotila = 0;
        kosteus = 0;
    }

    // Kiuas päälle
    public void Päälle()
    {
        onkoPaalla = true;
        Console.WriteLine("Kiuas on päällä.");
    }

    // Kiuas pois päältä
    public void PoisPäältä()
    {
        onkoPaalla = false;
        Console.WriteLine("Kiuas on pois päältä.");
    }

    // Kiuaksen lämpötilan säätö
    public void SäädäLämpötila(double uusiLämpötila)
    {
        if (uusiLämpötila >= 0 && uusiLämpötila <= 100)
        {
            lampotila = uusiLämpötila;
            Console.WriteLine("Kiuaksen lämpötila on nyt " + lampotila + " astetta.");
        }
        else
        {
            Console.WriteLine("Lämpötila ei ole sallitussa välissä (0-100).");
        }
    }

    // Kiuaksen kosteuden säätö
    public void SäädäKosteus(double uusiKosteus)
    {
        if (uusiKosteus >= 0 && uusiKosteus <= 100)
        {
            kosteus = uusiKosteus;
            Console.WriteLine("Kiuaksen kosteus on nyt " + kosteus + " %.");
        }
        else
        {
            Console.WriteLine("Kosteus ei ole sallitussa välissä (0-100).");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Luodaan uusi Kiuas-olio
        Kiuas kiuas = new Kiuas();

        // Kiuas päälle ja säädöt
        kiuas.Päälle();
        kiuas.SäädäLämpötila(80);
        kiuas.SäädäKosteus(50);

        // Kiuas pois päältä
        kiuas.PoisPäältä();

        // Odota käyttäjän syöttöä ennen ohjelman lopettamista
        Console.ReadLine();




    }
}
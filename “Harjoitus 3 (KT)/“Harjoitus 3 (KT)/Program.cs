using System;

class Kiuas
{
    private bool päällä;
    public int Lämpötila { get; private set; }
    public int Kosteus { get; private set; }

    public void Käynnistä() => päällä = true;
    public void Sammuta() => päällä = false;
    public void SäädäLämpötila(int uusiLämpötila) => Lämpötila = päällä && uusiLämpötila >= 0 && uusiLämpötila <= 100 ? uusiLämpötila : Lämpötila;
    public void SäädäKosteus(int uusiKosteus) => Kosteus = päällä && uusiKosteus >= 0 && uusiKosteus <= 100 ? uusiKosteus : Kosteus;
    public void TulostaTiedot() => Console.WriteLine($"Kiuas on päällä: {päällä}\nLämpötila: {Lämpötila} astetta\nKosteus: {Kosteus} %");
}

class Program
{
    static void Main()
    {
        Kiuas kiuas = new Kiuas();

        kiuas.TulostaTiedot();

        kiuas.Käynnistä();
        kiuas.SäädäLämpötila(80);
        kiuas.SäädäKosteus(50);
        kiuas.TulostaTiedot();

        kiuas.Sammuta();
        kiuas.SäädäLämpötila(90); 
        kiuas.TulostaTiedot();
    }
}
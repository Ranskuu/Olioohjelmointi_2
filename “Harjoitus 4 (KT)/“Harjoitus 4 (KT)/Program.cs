using System;
using System.Collections.Generic;

class Kappale
{
    public string Nimi { get; set; }
    public string Artisti { get; set; }
    public int Kesto { get; set; } // Kappaleen kesto sekunteina

    public Kappale(string nimi, string artisti, int kesto)
    {
        Nimi = nimi;
        Artisti = artisti;
        Kesto = kesto;
    }

    public override string ToString()
    {
        return $"Kappale: {Nimi}, Artisti: {Artisti}, Kesto: {Kesto} s";
    }
}

class Albumi
{
    public string Nimi { get; set; }
    public string Artisti { get; set; }
    public List<Kappale> Kappaleet { get; }

    public Albumi(string nimi, string artisti)
    {
        Nimi = nimi;
        Artisti = artisti;
        Kappaleet = new List<Kappale>();
    }

    public void LisääKappale(Kappale kappale)
    {
        Kappaleet.Add(kappale);
    }

    public void TulostaAlbuminTiedot()
    {
        Console.WriteLine($"Albumi: {Nimi}");
        Console.WriteLine($"Artisti: {Artisti}");
        Console.WriteLine("Kappaleet:");
        foreach (var kappale in Kappaleet)
        {
            Console.WriteLine(kappale);
        }
    }
}

class Program
{
    static void Main()
    {
        Albumi albumi = new Albumi("Levy1", "Artisti1");

        albumi.LisääKappale(new Kappale("Толпы", "Madk1d", 240));
        albumi.LisääKappale(new Kappale("mietfrei", "skiagu", 180));
        albumi.LisääKappale(new Kappale("TecHo", "Bushdio zho", 210));

        albumi.TulostaAlbuminTiedot();
    }
}
using System;
using System.Collections.Generic;

class Kappale
{
    public string nimi;
    public string artisti;
    public int kesto;

    public Kappale(string nimi, string artisti, int kesto)
    {
        this.nimi = nimi;
        this.artisti = artisti;
        this.kesto = kesto;
    }

    public override string ToString()
    {
        return $"{nimi} ({artisti}) - {kesto} s";
    }
}

class Albumi
{
    public string nimi;
    public string artisti;
    public int julkaisuvuosi;
    public List<Kappale> kappaleet;

    public Albumi(string nimi, string artisti, int julkaisuvuosi, List<Kappale> kappaleet)
    {
        this.nimi = nimi;
        this.artisti = artisti;
        this.julkaisuvuosi = julkaisuvuosi;
        this.kappaleet = kappaleet;
    }

    public void TulostaAlbumi()
    {
        Console.WriteLine($"Albumi: {nimi} ({artisti}), {julkaisuvuosi}");
        Console.WriteLine("Kappaleet:");
        foreach (Kappale kappale in kappaleet)
        {
            Console.WriteLine($"- {kappale.ToString()}");
        }
    }
}

class Ohjelma
{
    static void Main(string[] args)
    {
        Kappale kappale1 = new Kappale("Stairway to Heaven", "Led Zeppelin", 482);
        Kappale kappale2 = new Kappale("Bohemian Rhapsody", "Queen", 354);
        Kappale kappale3 = new Kappale("Hotel California", "Eagles", 391);
        Kappale kappale4 = new Kappale("Sweet Child O' Mine", "Guns N' Roses", 355);
        Kappale kappale5 = new Kappale("Smells Like Teen Spirit", "Nirvana", 302);

        List<Kappale> kappaleet = new List<Kappale>() { kappale1, kappale2, kappale3, kappale4, kappale5 };

        Albumi albumi = new Albumi("Classic Rock", "Various Artists", 2020, kappaleet);

        albumi.TulostaAlbumi();
    }
}
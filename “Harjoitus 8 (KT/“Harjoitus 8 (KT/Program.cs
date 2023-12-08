abstract class Henkilö
{
    string etunimi;
    string Työpaikka;
    int palkka;
}
public class Työntekijä
{
    string FirstName;
    
    string Työpaikka;

    int palkka;


    int työtunteja;
}
public class Pomo
{
    public int BoonuksenMaara { get; set; }

    
    public string Auto { get; set; }

    public Pomo (int boonuksenMaara, string auto)
    {
        BoonuksenMaara = boonuksenMaara;
        Auto = auto;
    }
}

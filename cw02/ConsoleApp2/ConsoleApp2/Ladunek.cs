namespace ConsoleApp2;

public class Ladunek
{
    public string Nazwa { get; set; }
    public double Temperatura { get; set; }
    public bool CzyNiebezpieczne { get; set; }

    public Ladunek(string nazwa, double temperatura, bool czyNiebezpieczne)
    {
        Nazwa = nazwa;
        Temperatura = temperatura;
        CzyNiebezpieczne = czyNiebezpieczne;
    }
}
namespace ConsoleApp2;

public class AbsKontener
{
    public double Masa {get; set;}
    public double Wysokosc {get; set;}
    public double Waga_wlasna {get;protected set;}
    public double Glebokosc {get; set;}
    public string Nr_seryjny {get; set;}
    
    public double Maks_ladownosc {get; set;}
    public AbsKontener(double masa, double wysokosc, double waga_wlasna, double glebokosc, 
        double maks_ladownosc)
    {
        Masa = masa;
        Wysokosc = wysokosc;
        Waga_wlasna = waga_wlasna;
        Glebokosc = glebokosc;
        Nr_seryjny = "KON";
        Maks_ladownosc = maks_ladownosc;
    }

    public void rozladuj()
    {
        Console.WriteLine($"Rozładowano konteren");
        Masa = 0;
    }

    public void zladuj(double x)
    {
        double newMasa = Masa + x;
        if (newMasa >= Maks_ladownosc)
        {
            Console.WriteLine($"Nie ma tyle miejsca w kontenerze, nie załadowano!!");
        }
        else
        {
            Masa = newMasa;
        }
    }
}
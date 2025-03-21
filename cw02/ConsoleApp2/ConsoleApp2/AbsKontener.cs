namespace ConsoleApp2;

public abstract class AbsKontener
{
    public double Masa {get; set;}
    public double Wysokosc {get; set;}
    public double Waga_wlasna {get;protected set;}
    public double Glebokosc {get; set;}
    public string Nr_seryjny {get; set;}
    public string Nazwa_ladunku { get; set; }
    
    public double Maks_ladownosc {get; set;}
    public AbsKontener(double wysokosc, double waga_wlasna, double glebokosc, 
        double maks_ladownosc)
    {
        Masa = 0;
        Wysokosc = wysokosc;
        Waga_wlasna = waga_wlasna;
        Glebokosc = glebokosc;
        Nr_seryjny = "KON";
        Maks_ladownosc = maks_ladownosc;
    }

    public void Rozladuj()
    {
        Console.WriteLine($"Rozładowano kontener {Nr_seryjny}");
        Masa = 0;
        Nazwa_ladunku = "";
    }

    public void Zaladuj(string nazwa_ladunku,double x)
    {
        double newMasa = Masa + x;
        if (newMasa >= Maks_ladownosc)
        {
            throw new OverfillException("$Nie ma tyle miejsca w kontenerze, nie załadowano!");        }
        else
        {
            Console.WriteLine($"Załadowano kontener {Nr_seryjny}!");
            Masa = newMasa;
            Nazwa_ladunku = nazwa_ladunku;
        }
    }

    public override string ToString()
    {
        return $"Numer Seryjny: {Nr_seryjny}, Masa: {Masa}KG \n";
    }
}
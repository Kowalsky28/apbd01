namespace ConsoleApp2;

public class KonPlyny : AbsKontener, IHazardNotifier
{
    private static int counter = 1;
    
    
    public KonPlyny(double masa, double wysokosc, double waga_wlasna, double glebokosc, 
        double maks_ladownosc) : base(wysokosc, waga_wlasna, glebokosc, maks_ladownosc)
    {
        Nr_seryjny += "-P-" + counter++;
    }
    public new void Zaladuj(string nazwa_ladunku,double x, bool czy_bezpieczny)
    {
        double newMasa = Masa + x;
        if (czy_bezpieczny)
        {
            if (newMasa > Maks_ladownosc*0.9)
            {
                throw new OverfillException("$Nie ma tyle miejsca w kontenerze, nie załadowano!");
            }
            else
            {
                Console.WriteLine($"Załadowano kontener {Nr_seryjny}!");
                Masa = newMasa;
                Nazwa_ladunku = nazwa_ladunku;
            }
        }
        else
        {
            if (newMasa > Maks_ladownosc*0.5)
            {
                throw new OverfillException("$Nie ma tyle miejsca w kontenerze, nie załadowano!");            }
            else
            {
                Notify($"Kontener {Nr_seryjny} posiada niebezpieczny ładunek!!!");
                Masa = newMasa;
                Nazwa_ladunku = nazwa_ladunku;
            }
        }
    }

    public void Notify(string notification)
    {
        Console.WriteLine(notification);
    }

    public override string ToString()
    {
        return base.ToString() + $"Ładunek: {Nazwa_ladunku}, Maks ladownosc: {Maks_ladownosc}KG\n";
    }
}
namespace ConsoleApp2;

public class KonPlyny : AbsKontener, IHazardNotifier
{
    private static int counter = 0;
    
    
    public KonPlyny(double masa, double wysokosc, double waga_wlasna, double glebokosc, 
        double maks_ladownosc) : base(wysokosc, waga_wlasna, glebokosc, maks_ladownosc)
    {
        Nr_seryjny += "-P-" + counter++;
    }
    public void zaladuj(string nazwa_ladunku,double x, bool czy_bezpieczny)
    {
        double newMasa = Masa + x;
        if (czy_bezpieczny)
        {
            if (newMasa >= Maks_ladownosc*0.9)
            {
                Console.WriteLine($"Nie ma tyle miejsca w kontenerze, nie załadowano!!");
            }
            else
            {
                Masa = newMasa;
                Nazwa_ladunku = nazwa_ladunku;
            }
        }
        else
        {
            if (newMasa >= Maks_ladownosc*0.5)
            {
                Console.WriteLine($"Nie ma tyle miejsca w kontenerze, nie załadowano!!");
                Console.WriteLine($"Maks ladownosc: {Maks_ladownosc*0.5}");
            }
            else
            {
                Notify("Niebezpieczny ładunek!!!");
                Masa = newMasa;
                Nazwa_ladunku = nazwa_ladunku;
            }
        }
    }

    public void Notify(string notification)
    {
        Console.WriteLine("Kontener "+Nr_seryjny+": "+notification);
    }
}
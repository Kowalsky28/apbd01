namespace ConsoleApp2;

public class KonGaz : AbsKontener, IHazardNotifier
{
    public double Cisnienie { get; set; }
    private static int counter = 1;

    
    public KonGaz(double wysokosc, double waga_wlasna, double glebokosc,
        double maks_ladownosc, double cisnienie) : base(wysokosc, waga_wlasna, glebokosc, maks_ladownosc)
    {
        Nr_seryjny += "-G-" + counter++;
        Cisnienie = cisnienie;
    }
    
    public new void Rozladuj()
    {
        Console.WriteLine($"Rozładowano kontener {Nr_seryjny}");
        Masa *= 0.05;
        Nazwa_ladunku = "";
    }

    public void Notify(string notification)
    {
        Console.WriteLine("Kontener "+Nr_seryjny+": "+notification);
    }
    public override string ToString()
    {
        return base.ToString() + $"Ładunek: {Nazwa_ladunku}, Maks ladownosc: {Maks_ladownosc}KG\nCiśnienie: {Cisnienie} Amosfer/y\n";
    }
}
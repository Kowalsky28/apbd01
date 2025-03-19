namespace ConsoleApp2;

public class KonPlyny : AbsKontener, IHazardNotifier
{
    private static int counter = 0;
    
    public KonPlyny(double masa, double wysokosc, double waga_wlasna, double glebokosc, 
        double maks_ladownosc) : base(masa, wysokosc, waga_wlasna, glebokosc, maks_ladownosc)
    {
        Nr_seryjny += "-P-" + counter++;
    }

    public void Notify(string notification)
    {
        Console.WriteLine("Kontener "+Nr_seryjny+": "+notification);
    }
}
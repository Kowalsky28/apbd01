namespace ConsoleApp2;

public class KonChlodnia : AbsKontener, IHazardNotifier
{
    private static int counter = 1;
    public List<List<string>> produkty { get; set; }
    public string Typ_produktu { get; set; }
    public double Temp { get; set; }
    public KonChlodnia(double wysokosc, double waga_wlasna, double glebokosc,
        double maks_ladownosc, double temp) : base(wysokosc, waga_wlasna, glebokosc, maks_ladownosc)
    {
        produkty = new List<List<string>>();
        Nr_seryjny += "-C-" + counter++;
        Temp = temp;
        Typ_produktu = "";
    }
    public new void Rozladuj()
    {
        Console.WriteLine($"Rozładowano kontener {Nr_seryjny}");
        Masa = 0;
        Nazwa_ladunku = "";
        Typ_produktu = "";
    }
    public void Zaladuj(string nazwa_ladunku,double masa, string typ_produktu, double temp_produktu)
    {
        if(Typ_produktu.Equals("")) Typ_produktu = typ_produktu;
        if (typ_produktu.Equals(Typ_produktu))
        {
            if (temp_produktu<Temp)
            {
                double newMasa = Masa + masa;
                if (newMasa >= Maks_ladownosc)
                {
                    Console.WriteLine($"Nie ma tyle miejsca w kontenerze {Nr_seryjny}, nie załadowano!!");
                }
                else
                {
                    Console.WriteLine($"Załadowano kontener {Nr_seryjny}!");
                    produkty.Add(new List<string>(){nazwa_ladunku,temp_produktu.ToString()});
                    Masa = newMasa;
                    Nazwa_ladunku = nazwa_ladunku;
                }
            }
            else
            {
                Console.WriteLine($"Kontener {Nr_seryjny} ma zbyt małą temperature dla tego produktu");
            }
        }
        else
        {
            Console.WriteLine($"Zły typ produktu, Kontener {Nr_seryjny} przechowuje produkty typu: {Typ_produktu}");
        }
    }

    public void Notify(string notification)
    {
        throw new NotImplementedException();
    }
    public override string ToString()
    {
        return base.ToString() + $"Maks ladownosc: {Maks_ladownosc}KG \n"+odczytaj(produkty)+"\n";
    }

    public static string odczytaj(List<List<string>> lista)
    {
        List<string> wynik = new List<string>();
        foreach (var produkt in lista)
        {
            wynik.Add(string.Join(",", produkt));
        }
        return string.Join(" - ",wynik);
    }
}
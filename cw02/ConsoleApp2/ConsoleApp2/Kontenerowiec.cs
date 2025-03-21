namespace ConsoleApp2;

public class Kontenerowiec
{
    public List<AbsKontener> Kontenery { get; set; }
    public double Predkosc { get; set; }
    public int Max_pojemnosc { get; set; }
    public double Max_waga { get; set; }
    public int Pojemnosc { get; set; }
    public string Name { get; set; }
    public static int Counter = 0;
    public double Waga { get; set; }

    public Kontenerowiec(double predkosc, int maxPojemnosc, double maxWaga)
    {
        Kontenery = new List<AbsKontener>();
        Predkosc = predkosc;
        Max_pojemnosc = maxPojemnosc;
        Max_waga = maxWaga;
        Pojemnosc = 0;
        Waga = 0;
        Name = "Kontenerowiec "+Counter.ToString();
        Counter++;
    }

    public void ZmienKontenerowiec(AbsKontener kontener, Kontenerowiec kontenerowiec)
    {
        UsunKontener(kontener);
        kontenerowiec.DodajKontener(kontener);
    }

    public void ZamienKontener(AbsKontener nowy, string stary_numer)
    {
        for (int i = 0; i < Kontenery.Count; i++)
        {
            if (Kontenery[i].Nr_seryjny.Equals(stary_numer))
            {
                UsunKontener(Kontenery[i]);
                break;
            }
        }
        DodajKontener(nowy);
    }
    public void UsunKontener(AbsKontener kontener)
    {
        Console.WriteLine($"Usunięto kontener: {kontener.Nr_seryjny} z kontenerowca: {Name}");
        Kontenery.Remove(kontener);
        Pojemnosc--;
        Waga -= kontener.Masa + kontener.Waga_wlasna;
    }
    public void DodajKontener(List<AbsKontener> kontenery)
    {
        for (int i = 0; i < kontenery.Count; i++)
        {
            DodajKontener(kontenery[i]);
        }
    }

    public void DodajKontener(AbsKontener kontener)
    {
        if (!Kontenery.Contains(kontener))
        {
            if (Pojemnosc < Max_pojemnosc)
            {
                if (Waga < Max_waga * 1000)
                {
                    Console.WriteLine($"Załadowano kontener {kontener.Nr_seryjny} na kontenerowiec: {Name}");
                    Kontenery.Add(kontener);
                    Pojemnosc++;
                    Waga += kontener.Masa + kontener.Waga_wlasna;
                }
                else
                {
                    Console.WriteLine("Limit wagi kontenerowca przekroczony");
                }
            }
            else
            {
                Console.WriteLine("Brak miejsca na kontenerowcu");
            }
        }
        else
        {
            Console.WriteLine("Ten kontener już jest na tym kontenerowcu");
        }
    }

    public override string ToString()
    {
        return $"Kontenerowiec: {Name}, Prędkość maksymalna: {Predkosc} Węzłów\nWaga: {Waga} KG, Pojemnosc: {Pojemnosc} kontenery/ów\n" +
               $"Maksymalna waga: {Max_waga} ton/y, Maksymalna pojemność: {Max_pojemnosc} kontenery/ów\n" +
               $"Kontenery:\n"+string.Join(" - ",Kontenery);
    }
}
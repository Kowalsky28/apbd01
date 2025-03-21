using ConsoleApp2;
public class Program
{
    public static void Main(string[] args)
    {
        KonPlyny kp1 = new KonPlyny(200, 300, 500, 800, 2000);
        KonPlyny kp2 = new KonPlyny(200, 300, 500, 800, 2000);
        KonGaz kg1 = new KonGaz(200, 300, 500, 800, 40);
        KonGaz kg2 = new KonGaz(200, 300, 500, 800, 40);
        KonChlodnia kc1 = new KonChlodnia(200, 300, 500, 800, 14);
        KonChlodnia kc2 = new KonChlodnia(200, 300, 500, 800, 10);
        
        kp1.Zaladuj("Woda",400,true);
        //kp2.Zaladuj("Paliwo",1200,false);
        kp2.Zaladuj("Paliwo",1000,false);
        
        //kg1.Zaladuj("Azot",900);
        kg1.Zaladuj("Azot",750);
        kg2.Zaladuj("Butan",700);
        
        kc1.Zaladuj("Banany",200,"owoce",12.5);
        kc1.Zaladuj("Maliny",200,"owoce",15);
        //kc1.Zaladuj("Morele",650,"owoce",11);
        kc1.Zaladuj("Porzeczki",230,"owoce",13.5);
        kc1.Zaladuj("Pomidory",100,"warzywa",12);
        kc2.Zaladuj("Maliny",200,"owoce",9);
        kc2.Rozladuj();
        kc2.Zaladuj("Pomidory",100,"warzywa",8);

        Kontenerowiec kon1 = new Kontenerowiec(40, 4, 4);
        Kontenerowiec kon2 = new Kontenerowiec(40, 4, 4);
        
        kon1.DodajKontener(kp1);
        kon1.DodajKontener(new List<AbsKontener>(){kp2,kg1,kc1} );
        kon1.ZamienKontener(kc2,kc1.Nr_seryjny);
        kon1.ZmienKontenerowiec(kp1,kon2);
        Console.WriteLine(kp1.ToString());
        Console.WriteLine(kg1.ToString());
        Console.WriteLine(kc1.ToString());
        Console.WriteLine(kon1.ToString());
        Console.WriteLine(kon2.ToString());






    }
}

using ConsoleApp2;
public class Program
{
    public static void Main(string[] args)
    {
        KonPlyny kp1 = new KonPlyny(200, 300, 500, 800, 2000);
        kp1.zaladuj("Paliwo",950,false);
        kp1.rozladuj();
        KonPlyny kp2 = new KonPlyny(200, 300, 500, 800, 2000);
        kp2.zaladuj("Paliwo",850,false);
        kp2.rozladuj();
        kp1.zaladuj("Mleko",2500,true);
    }
}

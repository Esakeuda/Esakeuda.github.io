using System;

class luvunarvaus
{
    static void Main()
    {
        Random satluku = new Random();
        int arvottuluku = satluku.Next(1, 13);
        
        Console.WriteLine("Arvaa luku 1-12 väliltä tai lopeta kirjoittamalla 'L'");
        
        string arvaus;
        bool arvattu = false;
        
        while (!arvattu)
        {
            Console.Write("Syötä arvaus: ");
            arvaus = Console.ReadLine();
            
            if (arvaus == "L")
            {
                Console.WriteLine("Lopetetaan...");
                Console.WriteLine("Halusit lopettaa LUUSERI !! Oikea vastaus oli " + arvottuluku);
                break;
            }
            
            int arvausluku;
            if (int.TryParse(arvaus, out arvausluku))
            {
                if (arvausluku == arvottuluku)
                {
                    Console.WriteLine("Onneksi olkoon, arvasit oikein !!");
                    arvattu = true;
                }
                else
                {
                    Console.WriteLine("Väärin arvattu. Yritä uudelleen!");
                }
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Syötä kokonaisluku tai 'L' lopettaaksesi.");
            }
        }
    }
}

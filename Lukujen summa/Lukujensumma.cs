using System;

class lukujensumma
{
    static void Main()
    {
        int summa = 0;
        
        while (summa < 100)
        {
            Console.Write("Syötä kokonaisluku: ");
            int luku = int.Parse(Console.ReadLine());
            
            summa += luku;
            Console.WriteLine("Summa: " + summa);
        }
        
        Console.WriteLine("Raja on saavutettu!");
    }
}


using System;

class Keskiarvo
{
    static void Main()
    {
        int[] luvut = new int[5];
        
        for (int i = 0; i < luvut.Length; i++)
        {
            Console.Write("Syötä luku: ");
            luvut[i] = int.Parse(Console.ReadLine());
        }
        
        int summa = 0;
        foreach (int luku in luvut)
        {
            summa += luku;
        }
        
        double keskiarvo = (double)summa / luvut.Length;
        
        Console.WriteLine("Lukujen keskiarvo: " + keskiarvo);
    }
}

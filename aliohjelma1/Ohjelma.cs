using System;

class Ohjelma
{
    static void Main()
    {
        Console.Write("Syötä kokonaisluku: ");
        int luku = int.Parse(Console.ReadLine());
        
        int tulos = LaskeNelio(luku);
        
        Console.WriteLine("Luvun neliö on: " + tulos);
    }
    
    static int LaskeNelio(int luku)
    {
        return luku * luku;
    }
}

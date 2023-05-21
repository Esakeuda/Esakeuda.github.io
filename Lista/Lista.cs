using System;
using System.Collections.Generic;

class lista
{
    static void Main()
    {
        List<int> luvut = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Syötä kokonaisluku: ");
            string syote = Console.ReadLine();

            if (!string.IsNullOrEmpty(syote) && int.TryParse(syote, out int luku))
            {
                luvut.Add(luku);
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Syötä kokonaisluku.");
                i--; // Vähennetään i:tä yhdellä, jotta käyttäjä voi yrittää uudestaan
            }
        }

        Console.WriteLine("Luvut järjestyksessä:");

        for (int i = 0; i < luvut.Count; i++)
        {
            Console.WriteLine(luvut[i]);
        }
    }
}

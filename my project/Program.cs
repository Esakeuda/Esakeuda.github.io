using System;
using System.Collections.Generic;

class Program
{
    class Tuote
    {
        public string? Nimi { get; set; }
        public decimal? Hinta { get; set; }
        public int? Maara { get; set; }

        public Tuote()
        {
            Nimi = null;
        }
    }

    static decimal LaskeYhteishinta(List<Tuote> tuotteet)
    {
        decimal yhteishinta = 0;
        foreach (Tuote tuote in tuotteet)
        {
            if (tuote.Hinta.HasValue && tuote.Maara.HasValue)
            {
                yhteishinta += tuote.Hinta.Value * tuote.Maara.Value;
            }
        }
        return yhteishinta;
    }

    static List<Tuote> KysyTuotteet()
    {
        List<Tuote> tuotteet = new List<Tuote>();
        Console.Write("Montako tuotetta haluat lisätä taulukkoon? ");
        int montako;
        string input = Console.ReadLine();
        if (int.TryParse(input, out montako))
        {
            for (int i = 0; i < montako; i++)
            {
                Tuote tuote = new Tuote();
                Console.Write("Syötä tuotteen nimi: ");
                tuote.Nimi = Console.ReadLine();
                Console.Write("Syötä tuotteen hinta: ");
                string hintaInput = Console.ReadLine();
                decimal? hinta = null;
                if (!string.IsNullOrEmpty(hintaInput) && decimal.TryParse(hintaInput, out decimal parsedHinta))
                {
                    hinta = parsedHinta;
                }
                tuote.Hinta = hinta;
                Console.Write("Syötä tuotteen lukumäärä: ");
                string maaraInput = Console.ReadLine();
                int? maara = null;
                if (!string.IsNullOrEmpty(maaraInput) && int.TryParse(maaraInput, out int parsedMaara))
                {
                    maara = parsedMaara;
                }
                tuote.Maara = maara;
                tuotteet.Add(tuote);
            }
        }
        else
        {
            Console.WriteLine("Virheellinen syöte. Montako tuotetta haluat lisätä taulukkoon?");
        }

        return tuotteet;
    }

    static void TulostaTuotteet(List<Tuote> tuotteet)
    {
        Console.WriteLine("Tuotteet:");
        foreach (Tuote tuote in tuotteet)
        {
            Console.WriteLine("Nimi: " + (tuote.Nimi ?? "ei määritelty"));
            Console.WriteLine("Hinta: " + (tuote.Hinta.HasValue ? tuote.Hinta.Value.ToString() : "ei määritelty"));
            Console.WriteLine("Lukumäärä: " + (tuote.Maara.HasValue ? tuote.Maara.Value.ToString() : "ei määritelty"));
            Console.WriteLine("--------------------");
        }
        decimal yhteishinta = LaskeYhteishinta(tuotteet);
        Console.WriteLine("Yhteishinta: " + yhteishinta + " €");
    }

    static void Main()
    {
        List<Tuote> tuotteet = KysyTuotteet();
        TulostaTuotteet(tuotteet);
    }
}

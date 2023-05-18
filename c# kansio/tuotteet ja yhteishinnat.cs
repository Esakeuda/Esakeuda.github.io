using System;

class Program
{
    static void Main()
    {
        Console.Write("Kuinka monta tuotetta haluat lisätä: ");
        int tuotteidenMaara = int.Parse(Console.ReadLine());

        string[] tuotteet = new string[tuotteidenMaara];
        decimal[] hinnat = new decimal[tuotteidenMaara];
        int[] lukumaarat = new int[tuotteidenMaara];

        for (int i = 0; i < tuotteidenMaara; i++)
        {
            Console.WriteLine($"Syötä tiedot tuotteelle {i + 1}:");
            Console.Write("Nimi: ");
            tuotteet[i] = Console.ReadLine();

            Console.Write("Hinta: ");
            hinnat[i] = decimal.Parse(Console.ReadLine());

            Console.Write("Lukumäärä: ");
            lukumaarat[i] = int.Parse(Console.ReadLine());

            Console.WriteLine();
        }

        // Lisätään erityiset tuotteet
        tuotteet[tuotteidenMaara] = "Puukko";
        hinnat[tuotteidenMaara] = 15m;
        lukumaarat[tuotteidenMaara] = 2;
        tuotteidenMaara++;

        tuotteet[tuotteidenMaara] = "Ämpäri";
        hinnat[tuotteidenMaara] = 2m;
        lukumaarat[tuotteidenMaara] = 100;
        tuotteidenMaara++;

        Console.WriteLine("Tuotteet ja niiden yhteishinnat:");

        decimal kokonaisHinta = 0;

        for (int i = 0; i < tuotteidenMaara; i++)
        {
            decimal yhteishinta = hinnat[i] * lukumaarat[i];
            kokonaisHinta += yhteishinta;

            Console.WriteLine($"{tuotteet[i]}: {yhteishinta.ToString("0.00")} €");
        }

        Console.WriteLine($"Yhteensä: {kokonaisHinta.ToString("0.00")} €");
    }
}

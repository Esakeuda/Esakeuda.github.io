using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string[] tuotteet = { "Vasara", "Saha", "Kirves" };
        int[] hinnat = { 5, 10, 15 };

        for (int i = 0; i < tuotteet.Length; i++)
        {
            Console.WriteLine(tuotteet[i] + " - " + hinnat[i] + " €");
        }
    }
}

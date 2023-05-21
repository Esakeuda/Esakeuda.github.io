using System;

class Ohjelma2
{
    static void Main()
    {
        Console.WriteLine("Anna 3 lukua, niin lasken niiden summan.");

        int[] luvut = KysyLuvut();

        int summa = LaskeSumma(luvut);

        Console.WriteLine("Kolmen luvun " + TulostaLuvut(luvut) + " summa on: " + summa);
    }

    static int[] KysyLuvut()
    {
        int[] luvut = new int[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Syötä luku " + (i + 1) + ": ");
            luvut[i] = int.Parse(Console.ReadLine());
        }

        return luvut;
    }

    static int LaskeSumma(int[] luvut)
    {
        int summa = 0;

        for (int i = 0; i < luvut.Length; i++)
        {
            summa += luvut[i];
        }

        return summa;
    }

    static string TulostaLuvut(int[] luvut)
    {
        string luvutString = "";

        for (int i = 0; i < luvut.Length; i++)
        {
            luvutString += luvut[i];

            if (i < luvut.Length - 2)
            {
                luvutString += ", ";
            }
            else if (i == luvut.Length - 2)
            {
                luvutString += " ja ";
            }
        }

        return luvutString;
    }
}
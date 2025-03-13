using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liczby = { 2, 4, 6, 8, 10 };
            double srednia = ObliczSrednia(liczby);
            Console.WriteLine("Średnia wynosi: " + srednia);
        }

        // Metoda obliczająca średnią
        static double ObliczSrednia(int[] tablica)
        {
            if (tablica == null || tablica.Length == 0)
            {
                // Opcjonalnie możesz zwrócić 0 lub rzucić wyjątek
                return 0;
            }

            double suma = 0;
            foreach (int liczba in tablica)
            {
                suma += liczba;
            }
            return suma / tablica.Length;
        }
    }
}

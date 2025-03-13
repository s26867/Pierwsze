public static int ObliczMax(int[] liczby)
{
    if (liczby == null || liczby.Length == 0)
    {
         throw new ArgumentException("Tablica nie może być pusta");
    }
    
    int max = liczby[0];
    foreach (int liczba in liczby)
    {
         if (liczba > max)
             max = liczba;
    }
    return max;
}


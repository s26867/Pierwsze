public static double ObliczSrednia(int[] liczby)
{
    if (liczby == null || liczby.Length == 0)
        return 0;
    
    double suma = 0;
    foreach (int liczba in liczby)
    {
        suma += liczba;
    }
    return suma / liczby.Length;
}


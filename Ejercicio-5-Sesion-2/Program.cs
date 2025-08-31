using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un año: ");
        int año = int.Parse(Console.ReadLine());

        // Un año es bisiesto si cumple estas condiciones
        if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
        {
            Console.WriteLine(año + " es bisiesto.");
        }
        else
        {
            Console.WriteLine(año + " no es bisiesto.");
        }
    }
}

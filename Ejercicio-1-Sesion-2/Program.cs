using System;

class ProgramaNumero
{
    static void Main()
    {
        // Declaración de variable
        int numero;

        // Pedir el número al usuario
        Console.Write("Ingrese un número: ");
        numero = Convert.ToInt32(Console.ReadLine());

        // Determinar si es positivo, negativo o cero
        if (numero > 0)
        {
            Console.WriteLine("El número es positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("El número es negativo.");
        }
        else
        {
            Console.WriteLine("El número es cero.");
        }
    }
}

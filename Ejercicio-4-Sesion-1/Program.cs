using System;

class ProgramaTanque
{
    static void Main()
    {
        // Declaración de variables
        double longitud, ancho, altura, volumen;

        // Pedir la longitud del tanque
        Console.Write("Ingrese la longitud del tanque en metros: ");
        longitud = Convert.ToDouble(Console.ReadLine());

        // Pedir el ancho del tanque
        Console.Write("Ingrese el ancho del tanque en metros: ");
        ancho = Convert.ToDouble(Console.ReadLine());

        // Pedir la altura del tanque
        Console.Write("Ingrese la altura del tanque en metros: ");
        altura = Convert.ToDouble(Console.ReadLine());

        // Calcular el volumen (fórmula: V = largo * ancho * alto)
        volumen = longitud * ancho * altura;

        // Mostrar el resultado
        Console.WriteLine("El volumen total de agua en el tanque es: " + volumen + " m³");
    }
}

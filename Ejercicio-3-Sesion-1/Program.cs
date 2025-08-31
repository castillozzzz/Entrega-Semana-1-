using System;

class ProgramaCiclista
{
    static void Main()
    {
        // Declaración de variables
        double velocidad, tiempo, distancia;

        // Pedir la velocidad promedio
        Console.Write("Ingrese la velocidad promedio en km/h: ");
        velocidad = Convert.ToDouble(Console.ReadLine());

        // Pedir el tiempo recorrido
        Console.Write("Ingrese el tiempo recorrido en horas: ");
        tiempo = Convert.ToDouble(Console.ReadLine());

        // Calcular la distancia recorrida
        distancia = velocidad * tiempo;

        // Mostrar el resultado
        Console.WriteLine("La distancia total recorrida es: " + distancia + " km");
    }
}

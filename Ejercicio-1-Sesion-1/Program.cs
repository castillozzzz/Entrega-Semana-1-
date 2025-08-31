// See https://aka.ms/new-console-template for more information
using System;

class ProgramaFinca
{
    static void Main()
    {
        // Mensaje de bienvenida
        Console.WriteLine("=== Calculadora de área en manzanas ===");
        Console.WriteLine("Este programa calcula el área de un terreno rectangular en manzanas.");
        Console.WriteLine("El ancho está fijo en 5 varas.\n");

        // Pedir la longitud al usuario
        Console.Write("Ingrese la longitud del terreno en varas: ");
        double longitud = Convert.ToDouble(Console.ReadLine());

        // Definir el ancho fijo en varas
        double ancho = 5;

        // Calcular el área en varas²
        double areaVaras2 = longitud * ancho;

        // Convertir a manzanas (1 manzana = 1428.8 varas²)
        double areaManzanas = areaVaras2 / 1428.8;

        // Mostrar resultados
        Console.WriteLine("\n--- Resultados ---");
        Console.WriteLine("Área en varas²: " + areaVaras2);
        Console.WriteLine("Área en manzanas: " + areaManzanas);

        Console.WriteLine("\n¡Cálculo completado!");
    }
}

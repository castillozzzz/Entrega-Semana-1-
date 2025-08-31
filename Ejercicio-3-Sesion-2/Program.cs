using System;

class ProgramaCalificacion
{
    static void Main()
    {
        // Declaración de variable
        int nota;

        // Pedir la nota al usuario
        Console.Write("Ingrese la calificación del estudiante (0 - 100): ");
        nota = Convert.ToInt32(Console.ReadLine());

        // Validar que esté en el rango correcto
        if (nota < 0 || nota > 100)
        {
            Console.WriteLine("La nota no es válida. Debe estar entre 0 y 100.");
        }
        else
        {
            // Evaluar la nota con if
            if (nota >= 70)
            {
                Console.WriteLine("El estudiante aprobó.");
            }
            else if (nota >= 50 && nota <= 69)
            {
                Console.WriteLine("El estudiante está en recuperación.");
            }
            else
            {
                Console.WriteLine("El estudiante reprobó.");
            }
        }
    }
}

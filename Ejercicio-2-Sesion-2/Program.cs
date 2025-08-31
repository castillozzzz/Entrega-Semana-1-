using System;

class ProgramaDias
{
    static void Main()
    {
        // Declaración de variable
        int numero;

        // Pedir el número al usuario
        Console.Write("Ingrese un número entre 1 y 7: ");
        numero = Convert.ToInt32(Console.ReadLine());

        // Evaluar con switch
        switch (numero)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miércoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Número inválido. Debe ser entre 1 y 7.");
                break;
        }
    }
}

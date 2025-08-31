string entrada = string.Empty;
bool entradaValida = false;

while (!entradaValida)
{
    Console.Write("Ingrese un número positivo: ");
    entrada = Console.ReadLine();

    if (int.TryParse(entrada, out int numero) && numero > 0)
    {
        entradaValida = true;
    }
    else
    {
        Console.WriteLine("Entrada inválida. Intente de nuevo.");
    }
}

Console.WriteLine($"Número ingresado: {entrada} (positivo)");

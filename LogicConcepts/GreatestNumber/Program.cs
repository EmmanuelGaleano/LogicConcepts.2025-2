using Shared;

var response = string.Empty;
do
{
    try
    {
        var a = ConsoleExtensions.GetInt("Ingrese primer numero: ");
        var b = ConsoleExtensions.GetInt("Ingrese segundo numero: ");
        var c = ConsoleExtensions.GetInt("Ingrese tercer numero: ");

        if (a == b || a == c || b == c)
        {
            Console.WriteLine("Error: No se permiten numeros iguales.");
        }
        else
        {
            var greatest = a;
            if (b > greatest)
            {
                greatest = b;
            }
            if (c > greatest)
            {
                greatest = c;
            }
            Console.WriteLine($"El numero mayor es: {greatest}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

    Console.Write("Desea continuar? (S/M)? ");
    response = Console.ReadLine()!.ToUpper();
} while (response == "S");
Console.WriteLine("Saliendo del programa...");
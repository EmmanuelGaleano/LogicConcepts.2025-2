using Shared;

var response = string.Empty;
do
{
    try
    {
        var number1 = ConsoleExtensions.GetInt("Ingrese primer numero: ");
        var number2 = ConsoleExtensions.GetInt("Ingrese segundo numero: ");
        var number3 = ConsoleExtensions.GetInt("Ingrese tercer numero: ");

        if (number1 == number2 || number1 == number3 || number2 == number3)
        {
            Console.WriteLine("Error: No se permiten numeros iguales.");
        }
        else
        {
            var greatest = number1;
            if (number2 > greatest)
            {
                greatest = number2;
            }
            if (number3 > greatest)
            {
                greatest = number3;
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
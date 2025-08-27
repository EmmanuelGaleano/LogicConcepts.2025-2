using Shared;

var response = string.Empty;
do
{
    Console.Write("Ingrese 3 numeros diferentes...");
    var a = ConsoleExtensions.GetInt("Ingrese primer numero: ");
    var b = ConsoleExtensions.GetInt("Ingrese segundo numero: ");
    if (a == b)
    {
        Console.WriteLine("Error: No se permiten numeros iguales.");
        continue;
    }
    var c = ConsoleExtensions.GetInt("Ingrese tercer numero: ");
    if (a == c || b == c)
    {
        Console.WriteLine("Error: No se permiten numeros iguales.");
        continue;
    }

        if (a > b && a > c)
    {
        if (b > c)
        {
            Console.WriteLine($"El numero mayor es: {a}, el medio es {b}, el menor es {c}");
        }
        else
        {
            Console.WriteLine($"El numero mayor es: {a}, el medio es {c}, el menor es {b}");
        }
    }
    else if (b > a && b > c)
    {
        if (a > c)
        {
            Console.WriteLine($"El numero mayor es: {b}, el medio es {a}, el menor es {c}");
        }
        else
        {
            Console.WriteLine($"El numero mayor es: {b} el medio es {c}, el menor es {a}");
        }
    }
    else 
    { 
        if (a > b)
        {
            Console.WriteLine($"El numero mayor es: {c}, el medio es {a}, el menor es {b}");
        }
        else
        {
            Console.WriteLine($"El numero mayor es: {c}, el medio es {b}, el menor es {a}");
        }
    }
}while (true);
Console.WriteLine("Saliendo del programa...");
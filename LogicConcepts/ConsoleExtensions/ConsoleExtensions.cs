namespace Shared
{
    public class ConsoleExtensions
    {
        public static int GetInt (String message)
        {
        Console.Write(message);
            var input = Console.ReadLine();  
            if (int.TryParse(input, out int result))
            {
                return result;
            }

            throw new FormatException("El valor ingresado no es un umero entero valido.");
        }   
    }
}

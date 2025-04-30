using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa un número: ");
        int numero;

        
        if (int.TryParse(Console.ReadLine(), out numero))
        {
            if (EsPrimo(numero))
            {
                Console.WriteLine($"El número {numero} es primo.");
            }
            else
            {
                Console.WriteLine($"El número {numero} no es primo.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingresa un número válido.");
        }
    }

    static bool EsPrimo(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true; 

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false; 
        }

        return true; 
    }
}

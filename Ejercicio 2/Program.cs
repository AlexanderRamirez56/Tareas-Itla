
using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Ingrese el primer número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Ingrese el segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        
        double resultado = numero1 * numero2;

        
        Console.WriteLine($"El resultado de la multiplicación es: {resultado}");

        
        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}

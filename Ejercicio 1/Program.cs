using System;

class ProgramaDivision
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el primer número (dividendo): ");
        double dividendo = Convert.ToDouble(Console.ReadLine());


        Console.Write("Ingrese el segundo número (divisor): ");
        double divisor = Convert.ToDouble(Console.ReadLine());


        if (divisor == 0)
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
        }
        else
        {

            double resultado = dividendo / divisor;
            Console.WriteLine($"El resultado de dividir {dividendo} entre {divisor} es: {resultado}");
        }


        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
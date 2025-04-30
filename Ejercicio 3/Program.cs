using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Ingrese el valor de a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        
        double discriminante = Math.Pow(b, 2) - 4 * a * c;

        if (discriminante > 0)
        {
            
            double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
            Console.WriteLine($"Las soluciones son x1 = {x1} y x2 = {x2}");
        }
        else if (discriminante == 0)
        {
            
            double x = -b / (2 * a);
            Console.WriteLine($"La solución es x = {x}");
        }
        else
        {
            
            double parteReal = -b / (2 * a);
            double parteImaginaria = Math.Sqrt(-discriminante) / (2 * a);
            Console.WriteLine($"Las soluciones son x1 = {parteReal} + {parteImaginaria}i y x2 = {parteReal} - {parteImaginaria}i");
        }

        
        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}

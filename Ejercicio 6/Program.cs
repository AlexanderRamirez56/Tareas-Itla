using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Numeros de serie de la Fibonacci del 1 al 50:");

        int a = 0; 
        int b = 1; 

        while (a <= 50)
        {
            if (a > 0) 
            {
                Console.WriteLine(a);
            }

            int temp = a; 
            a = b; 
            b = temp + b; 
        }
    }
}

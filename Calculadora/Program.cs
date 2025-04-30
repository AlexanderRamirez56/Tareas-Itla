using System;

namespace Matematica
{
    public class Calculadora
    {
        
        static int suma(int a, int b)
        {
            return a + b;
        }

        static int resta(int a, int b)
        {
            return a - b;
        }

        static int multiplicacion(int a, int b)
        {
            return a * b;
        }

        static int division(int a, int b)
        {
            return a / b;
        }

        
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("\n" + "Introduce el 1er número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("\n" + "Introduce el 2do número: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("\n" + "Seleccione una opción: " + "\n" + "\n");
            Console.Write("\n" + "     1º) Suma" + "\n" + "     2º) Resta" + "\n" + "     3º) Multiplicación" + "\n" + "     4º) División" + "\n" + "     5º) Salir del Programa" + "\n" + "\n");

            switch (Console.Read())
            {
                case '1':
                    Console.Write("\n" + "    Suma = " + suma(a, b));
                    break;

                case '2':
                    Console.Write("\n" + "    Resta = " + resta(a, b));
                    break;

                case '3':
                    Console.Write("\n" + "    Multiplicación = " + multiplicacion(a, b));
                    break;

                case '4':
                    Console.Write("\n" + "    División = " + division(a, b));
                    break;

                case '5':
                    Console.Write("\n" + "  Buena suerte!! ");
                    break;

                default:
                    Console.Write("\n" + "Opción no válida.");
                    break;
            }

            Console.ReadKey();
        }
    }
}

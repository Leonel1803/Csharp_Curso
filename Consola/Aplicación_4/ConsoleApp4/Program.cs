using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elige un número del uno al 3:");

            int numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Eligiste el número 1");
                    break;

                case 2:
                    Console.WriteLine("Eligiste el número 2");
                    break;

                case 3:
                    Console.WriteLine("Eligiste el número 3");
                    break;

                default:
                    Console.WriteLine("No has imprimido un valor válido");
                    break;
            }
        }
    }
}

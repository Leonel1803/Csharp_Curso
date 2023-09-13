using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 15;

            // "!": niega (convierte en contrario entre true y false) cualquier condicional

            if(edad < 18)
            {
                Console.WriteLine("Eres menor de edad");
            }
            else if(edad > 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else if (edad == 18)
            {
                Console.WriteLine("Tienes justamente 18 años");
            }

            int edad2 = 19; ;
            string sexo = "Masculino";

            if(edad2 > 18 && sexo == "Masculino")
            {
                Console.WriteLine("Eres un hombre mayor de 18");
            }
            else if(edad2 > 18 && sexo != "Masculino")
            {
                Console.WriteLine("Eres una mujer mayor de 18");
            }

            if(edad2 > 18 || edad2 < 15)
            {
                Console.WriteLine("O tienes más que 18 o tienes menos de 15");
            }

            int num = 20;
            if(num < 10)
            {
                Console.WriteLine("El número es menor a 10");
            }
            else
            {
                Console.WriteLine("El número es mayor o igual a 10");
            }

            bool condicional = true;
            if (condicional)
            {
                Console.WriteLine("La variable 'condicional' es true");
            }
            else
            {
                Console.WriteLine("La variable 'condicional' es false");
            }

        }
    }
}

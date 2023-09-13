using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            while(cont < 10) //Tiene que cumplir la condicion para entrar al while
            {
                Console.WriteLine("'cont' todavia no es igual a 10");
                cont++;
            }

            do //Se hace una sola vez, y si es que no se cumple la condicion que está abajo en la palabra while, entonces no se efectua el bucle
            {
                if (cont == 10)
                {
                    cont = 0;
                    Console.WriteLine("Ya se ha entrado al bucle do while y ya se ha igualado cont de nuevo a 0");
                }
                Console.WriteLine("Cont no es igual a 10 todavia");
                cont++;
            } while (cont < 10);
        }
    }
}

using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {   

            //Una sola excepción
            try //Intenta esto
            {
                int[] numeros = { 1, 2, 3 };
                Console.WriteLine(numeros[4]);
            }
            catch //Si hay un error en la ejecucuión, entonces haz lo siguiente
            {
                Console.WriteLine("ERROR. Haz intentado impirmir una posicion no existentre en el arreglo");
            }

            //Varias excepciones
            try
            {
                // Código que puede generar una excepción
                int[] numeros = { 1, 2, 3 };
                Console.WriteLine(numeros[4]); // Intentando acceder a un índice inválido
            }
            catch (IndexOutOfRangeException e)
            {
                // Manejo de la excepción específica de IndexOutOfRangeException
                Console.WriteLine("Ocurrió un error de índice fuera de rango: " + e.Message);
            }
            catch (Exception e) //Exception es la excepcion mayor dentro de las jerarquias de excepciones, por tanto en un bloque cach, esta es la más genérica y puede capturar cualquier excepción para no tener que poner muchas expeciones
            {
                // Exception NO es muy preciso, por lo tanto solo usalo cuando sea una excepcion no recurrente en el programa siendo ejecutado
                // Manejo de excepciones generales (cualquier excepción no capturada por los bloques catch anteriores)
                Console.WriteLine("Ocurrió un error: " + e.Message);
                //Excpecion siempre va al final del bloque de excepciones
            }
        }
    }
}

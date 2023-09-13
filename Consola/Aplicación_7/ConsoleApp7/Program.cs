using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número de mes:");
            int mes = int.Parse(Console.ReadLine());

            //Throw
            try
            {
                Console.WriteLine(nombreDelMes(mes));
            }
            catch (Exception e)
            {
                Console.WriteLine("Mensaje de la expeción: " + e.Message);
            }
            Console.WriteLine("Sigue el programa");


            //Uso del finally
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
            catch (Exception e)
            {
                // Manejo de excepciones generales (cualquier excepción no capturada por los bloques catch anteriores)
                Console.WriteLine("Ocurrió un error: " + e.Message);
            }
            finally
            {
                // El bloque 'finally' se ejecuta siempre, haya ocurrido una excepción o no, lo cual nos ayuda a liberar memoria
                Console.WriteLine("Finalizando bloque try catch.");
            }
        }

        static string nombreDelMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
                default:
                    throw new ArgumentOutOfRangeException(); //Cuando se cause una excepción por un valor no valido al llamar al método, se lanzará una excepción de tipo ArgumentOutOfRangeException
            }
        }
    }
}

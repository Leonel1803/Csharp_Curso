//using System; //Es el paquete predefinido que usa C# que viene con clases como "Console"  Método1

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");  Método1
            System.Console.WriteLine("Hello World!"); //Metodo 2; el cual define el paquete, la clase y el método de la clase a usar
            //variable++ aumento
            //variavble-- decremento

            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27; //Se inicializan las 4 variables con el valor 27


            //Casting
            double temperatura = 34.5;
            int tempaeraturaGuadalajara;

            tempaeraturaGuadalajara = (int)temperatura;

            //Conversion Implícita
            int var1 = 100000;
            long var2 = var1;

            //Conversion de primitivo  a texto (String)
            int num1 = int.Parse("275");
            double num2 = double.Parse("45.467");

            //Leer valor de consola
            int intr = int.Parse(System.Console.ReadLine());

            //Constantes
            const int VALOR = 34; //Se tiene que iniciar al declarar
        }
    }
}

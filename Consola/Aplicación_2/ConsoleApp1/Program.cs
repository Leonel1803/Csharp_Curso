using System;

namespace ConsoleApp1
{
    class Program
    {

        int num3 = 5; //Esta en el ambito "Program", por lo tanto estas dos variables no marcan error en los métodos que las usan, debido a que también están en el mimso ámbito
        int num4 = 10;
        //Campos de clase

        static void Main(string[] args)
        {
            mensajeEnPantalla();
            Console.WriteLine("Estoy devuelta en el Main");
            int val = sumatoriaDeNumeros(23, 45);
            Console.WriteLine("Métodos sumatoriaDeNumeros hecho, resultado: " + val);

            Console.WriteLine(suma(23, 45));
            Console.WriteLine(suma(23, 45, 67));

            Console.WriteLine(resta(45, 23));
            Console.WriteLine(resta(45, 23, 5));
        }

        static void mensajeEnPantalla()
        {
            Console.WriteLine("Estoy en el método 'mensajeEnPantalla'");
        }

        static int sumatoriaDeNumeros(int num2, int num1)
        {
            int sum = num2 + num1;
            return sum;
        }

        void primerMetodo() //Ambito primerMetodo
        {
            Console.WriteLine(num3 + num4);
        }

        void segundoMetodo() //Ambito segundoMetodo
        {
            //Todo lo que esta dentro de las llaves está en el mismo ambito
            Console.WriteLine(num3);
        }

        static int suma(int op1, int op2) => op1 + op2; //La flecha hace referencia a que retorna algo. Puede servir para cuando se tenga una sola sentencia en el método que sea de retorno

        static int suma(int op1, int op2, int op3) => op1 + op2 + op3; //Sobrecarga de métodos ya que reciben cantidad de parámetros diferentes entre los dos métodos de nombres iguales

        static int resta(int op1, int op2, int op3 = 0) => op1 - op2 - op3; // Cuano hacemos el "op3 = 0" (una asignación), hacemos que este parámetro sea opcional al mandarlo a llamar

    }
}

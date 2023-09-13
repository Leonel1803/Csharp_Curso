using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Circulo circ1 = new Circulo(); // Creacion de objeto de tipo "Circulo"
            Console.WriteLine(circ1.Area(12));

            Circulo circ2 = new Circulo();
            Console.WriteLine(circ1.Area(20));
            double val = circ2.GetPI(); //Asignamos a la variable "val", lo que retorna nuestro método "getPI" desde nuestro objeto "circ2"

            ConversorEuroDolar conv1 = new ConversorEuroDolar();
            Console.WriteLine(conv1.Convierte(12.52));
        }
    }

    class Circulo // Clase "Circulo"
    {
        private const double PI = 3.1416; // Constante. Rpivate debido a que solo se le puede llamar desde la propia clase

        public double Area(int radio) // Se le declara public debido a que se puede accedaer a el desde cualquier lugar al cual se le pueda llamar
        {
            return (PI * (radio * radio));
        }

        //getter de PI
        public double GetPI() // Puedes obtener el dato de PI desde otros lugares ajenos a la clase
        {
            return PI;
        }
    }

    class ConversorEuroDolar
    {
        private double euro = 1.253;

        public double Convierte(double cantidad)
        {
            return (cantidad * euro);
        }

        //setters y getters
        public void SetEuro(double cambio)
        {
            if(cambio > 0) //Restricción para que el atributo euro no valga menos que cero si es que se le quiere asignar un valor diferente
            {
                this.euro = cambio;
            }
            else
            {
                Console.WriteLine("La moneda no puede ser negativa");
            }
        }

        public double GetEuro()
        {
            return this.euro;
        }
    }
}

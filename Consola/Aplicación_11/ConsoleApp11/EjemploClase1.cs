using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class EjemploClase1
    {
        public static int contador = 0; // Variable estática compartida por todas las instancias de EjemploClase1

        public static void MetodoEstatico()
        {
            contador++; // Incrementa el contador en cada llamada al método
            Console.WriteLine("El contador en EjemploClase1 es: " + contador);
        }

        public void MetodoNoEstatico()
        {
            contador++; // Incrementa el contador en cada llamada al método
            Console.WriteLine("El contador en una instancia de EjemploClase1 es: " + contador);
        }
    }
}

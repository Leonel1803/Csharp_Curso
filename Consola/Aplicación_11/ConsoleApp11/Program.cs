using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            EjemploClase1.MetodoEstatico(); // Llamada al método estático de EjemploClase1

            EjemploClase1 instancia1 = new EjemploClase1();
            instancia1.MetodoNoEstatico(); // Llamada al método no estático de una instancia de EjemploClase1

            EjemploClase1.MetodoEstatico(); // Llamada al método estático de EjemploClase1 nuevamente

            EjemploClase2.MetodoEstatico(); // Llamada al método estático de EjemploClase2
        }
    }
}

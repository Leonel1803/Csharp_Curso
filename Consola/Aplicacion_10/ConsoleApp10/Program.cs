using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto pnt1 = new Punto(2.13, 3.14);
            Console.WriteLine("El punto esta ubicado en: x=" + pnt1.GetX() + ", y=" + pnt1.GetY());

            Punto pnt2 = new Punto(1.10, 6.35);
            Console.WriteLine("El punto esta ubicado en: x=" + pnt2.GetX() + ", y=" + pnt2.GetY());

            Console.WriteLine("La distancia entre pnt1 y pnt 2 es de: " + pnt1.DistanciaEntrePuntos(pnt2));
        }
    }
}

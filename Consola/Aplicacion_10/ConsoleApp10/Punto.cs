using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Punto
    {
        //Atributos
        private double x;
        private double y;
        
        //Constructor
        public Punto(double x, double y)
        {
            SetX(x);
            SetY(y);
        }

        //Setters y getters
        public void SetX(double x)
        {
            this.x = x;
        }

        public void SetY(double y)
        {
            this.y = y;
        }

        public double GetX()
        {
            return this.x;
        }

        public double GetY()
        {
            return this.y;
        }

        //Métodos
        public double DistanciaEntrePuntos(Punto punto)
        {
            double xDif = this.x - punto.GetX();
            double yDif = this.y - punto.GetY();

            //Teorema de Pitagoras para calcular distancia
            xDif = Math.Pow(xDif, 2);
            yDif = Math.Pow(yDif, 2);

            double distancia = Math.Sqrt(xDif + yDif);
            return distancia;
        }
    }
}

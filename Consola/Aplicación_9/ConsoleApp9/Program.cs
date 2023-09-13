using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche(4, .50, 1, "Honda"); //Llama al constructor para crear objeto y que se inicializen sus atributos
            Coche coche2 = new Coche(); //Llama al constructor que no recibe parámetros y se inicializan los atributos con lo que el constructor se le dice

            Console.WriteLine(coche1.InformacionDelCoche());
            Console.WriteLine(coche2.InformacionDelCoche());

            coche2.SetExtras(true, "cuero");

            Console.WriteLine("El coche 2 tiene de tapicería" + coche2.GetTapiceria());
        }
    }

    class Coche
    {
        //Atributos
        private int ruedas;
        private double altitud;
        private double ancho;
        private string nombre;

        private string tapiceria;
        private bool climatizador;

        //Constructores
        public Coche(int ruedas, double altitud, double ancho, string nombre) // Constructor. Siempre debe llamarse como la clasa. No tiene return y tampoco es void. Por lo general, inicializa varios atributos de una instancia (objeto) de la clase. También se puede sobrecargar
        {
            SetRuedas(ruedas);
            SetAltitud(altitud);
            SetAncho(ancho);
            SetNombre(nombre);
        }

        public Coche()
        {
            SetRuedas(4);
            SetAltitud(.70);
            SetAncho(1.1);
            SetNombre("Coche Genérico");
        }

        //setters y getters
        public void SetRuedas(int ruedas)
        {
            this.ruedas = ruedas; //"this" hace referencia al atrubuto propio de la clase, no el que pueda recibir el método por parámetros
        }

        public void SetAltitud(double altitud)
        {
            this.altitud = altitud;
        }

        public void SetAncho(double ancho)
        {
            this.ancho = ancho;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetExtras(bool climatizador, string tapiceria)
        {
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }

        public int GetRuedas()
        {
            return this.ruedas;
        }

        public double GetAltitud()
        {
            return this.altitud;
        }

        public double GetAncho()
        {
            return this.ancho;
        }

        public string GetNombre()
        {
            return this.nombre;
        }
        public bool GetClimatizador()
        {
            return this.climatizador;
        }

        public string GetTapiceria()
        {
            return this.tapiceria;
        }

        //Métodos
        public string InformacionDelCoche()
        {
            return ("Nuestro " + this.nombre + " tiene  " + this.ruedas + " ruedas, mide " + this.altitud + " de alto y " + this.ancho + "de ancho.");
        }
    }
}

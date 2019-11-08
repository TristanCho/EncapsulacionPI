using System;

namespace EncapsulacionPI
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorEuroDolar obj = new ConversorEuroDolar();

            Console.WriteLine("El resultado de la conversion es: "+obj.convierte(50) );

            obj.cambiaValorEuro(1.45);

            Circulo miCirculo = new Circulo();
            //Console.WriteLine(miCirculo.calculoArea(20)); 
            Console.WriteLine("valor de dameArea="+miCirculo.calculoArea(5)); 

          
        }
    }
    class Circulo//Clase
    {
        private const double pi = 3.1416; //Propiedad de la clase Circulo. Campo de clase.
        public double calculoArea(int radio)// Método de clase. public hace accesible, pero no tiene sentido que pueda ser accesible desde afura
        {
            double area = pi * radio * radio;
            return area;
        }
    }
    class ConversorEuroDolar
    {
        private double euro = 1.253;
        public double convierte(double cantidad)//GETTER
        {
            return cantidad * euro;
        }

        public void cambiaValorEuro(double nuevoValor)//SETTER
        {
            if (nuevoValor < 0)
            {
                Console.WriteLine("Introduzca un valor Válido ");
                euro = 1.253;
            }
            else euro = nuevoValor;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se creo la clase persona con toda la informacion solicitada
            //Se procede a utilizar el metodo que calcula el area del circulo
            string continuar = "";

            while (true)
            {
                Console.WriteLine("Este programa le permite calcular el area del circulo");

                Circulo circulo = new Circulo();

                Console.Write("Ingrese el radio del circulo: ");
                circulo.Radio = float.Parse(Console.ReadLine());

                Console.WriteLine("El area del circulo es: " + circulo.areaCirculo(circulo.Radio));

                Console.WriteLine("Desea continuar: s/n");
                continuar = Console.ReadLine().ToLower();

                if (continuar.Equals("n")) break;//
            }
        }

    }
}

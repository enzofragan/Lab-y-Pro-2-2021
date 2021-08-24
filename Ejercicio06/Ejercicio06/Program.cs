using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Ejercicio_06
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_06";

            Int32 añoIngresadoInicio;
            Int32 añoIngresadoFinal;
            Int32 contadorAnios = 0;


            Console.Write("Ingrese un año inicial para calcular: ");
            añoIngresadoInicio = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un año final para calcular: ");
            añoIngresadoFinal = int.Parse(Console.ReadLine());


            while (añoIngresadoInicio > añoIngresadoFinal)
            {
                Console.WriteLine("ERROR! El año inicial no puede ser mayor al año final");

                Console.Write("Ingrese un año inicial para calcular: ");
                añoIngresadoInicio = int.Parse(Console.ReadLine());

                Console.Write("Ingrese un año final para calcular: ");
                añoIngresadoFinal = int.Parse(Console.ReadLine());
            }


                for (int i = añoIngresadoInicio; i <= añoIngresadoFinal; i++)
                {
                    if ((i % 4) == 0 && (i % 100 != 0 || i % 400 == 0))
                    {
                        Console.Write("{0,7:#,###}", i);
                        contadorAnios++;

                        if (contadorAnios == 10)
                        { Console.WriteLine("\n"); contadorAnios = 0; }
                    }
                }

            Console.ReadLine();
        }
    }
}

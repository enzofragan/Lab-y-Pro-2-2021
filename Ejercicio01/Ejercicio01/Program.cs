using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio 1";

            string NumeroIngresado;
            Int32 ContadorNumeros = 0;
            Int32 NumeroActual;
            Int32 NumeroMinimo = 0;
            Int32 NumeroMaximo = 0;
            Int32 AcumuladorNumeros = 0;
            float NumeroPromedio = 0;

            do
            {
                ContadorNumeros++;

                Console.WriteLine("Ingrese un numero:");
                NumeroIngresado = Console.ReadLine();
                NumeroActual = int.Parse(NumeroIngresado);

                if (ContadorNumeros == 1)
                {
                    NumeroMinimo = NumeroActual;
                    NumeroMaximo = NumeroActual;
                }


                if (NumeroActual < NumeroMinimo)
                {
                    NumeroMinimo = NumeroActual;
                }

                if (NumeroActual > NumeroMaximo)
                {
                    NumeroMaximo = NumeroActual;
                }


                AcumuladorNumeros = NumeroActual + AcumuladorNumeros;

            } while (ContadorNumeros != 5);

            NumeroPromedio = (float)AcumuladorNumeros / 5;


            Console.WriteLine("El numero minimo es: {0:#,###.00}", NumeroMinimo);
            Console.WriteLine("El numero maximo es: {0:#,###.00}", NumeroMaximo);
            Console.WriteLine("El promedio de numeros es: {0:#,###.00}", NumeroPromedio);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Ejercicio_03
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_03";

            Int32 numeroIngresado;
            Int32 contador = 0;
            string auxNumeroIngresado;


            Console.WriteLine("Ingrese un numero:");
            auxNumeroIngresado = Console.ReadLine();
            numeroIngresado = int.Parse(auxNumeroIngresado);

            if (numeroIngresado <= 1 && numeroIngresado != 0)
            {
                while (numeroIngresado == 1)
                {
                    Console.WriteLine("1 No es considerado un numero primo!. ");
                    Console.WriteLine("Ingrese un numero:");
                    auxNumeroIngresado = Console.ReadLine();
                    numeroIngresado = int.Parse(auxNumeroIngresado);
                }
                while (numeroIngresado < 1)
                {
                    Console.WriteLine("Los numeros por debajo de 1 no son primos!. ");
                    Console.WriteLine("Ingrese un numero:");
                    auxNumeroIngresado = Console.ReadLine();
                    numeroIngresado = int.Parse(auxNumeroIngresado);
                }

            }

            for (int i = 2; i <= numeroIngresado; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        contador++;
                    }
                }

                if (contador == 2)
                {
                    Console.WriteLine("{0:#,###.00}", i);
                }

                contador = 0;
            }

            Console.ReadLine();
        }
    }
}

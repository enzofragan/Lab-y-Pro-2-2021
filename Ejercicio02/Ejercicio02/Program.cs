using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Ejercicio_02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_02";

            string auxNumero;
            Int32 NumeroIngresado;
            double cuadrado = 0;
            double cubo = 0;


            Console.WriteLine("Ingrese un numero:");
            auxNumero = Console.ReadLine();
            NumeroIngresado = int.Parse(auxNumero);

            while (NumeroIngresado == 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                Console.ReadKey();
                Console.WriteLine("Ingrese un numero:");
                auxNumero = Console.ReadLine();
                NumeroIngresado = int.Parse(auxNumero);
            }

            cuadrado = Math.Pow(NumeroIngresado, 2);
            cubo = Math.Pow(NumeroIngresado, 3);

            Console.WriteLine("El numero elegido es: {0:#,###.00}", NumeroIngresado);
            Console.WriteLine("El cuadrado es : {0:#,###.00}", cuadrado);
            Console.WriteLine("El cubo es : {0:#,###.00}", cubo);
            Console.ReadKey();
        }
    }
}

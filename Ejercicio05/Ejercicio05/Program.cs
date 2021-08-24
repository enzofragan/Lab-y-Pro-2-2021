﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class Ejercicio_05
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_05";


            Int32 numeroMaximo;
            Int32 acumuladorNegativos = 0;
            Int32 acumuladorPositivos = 0;
            Int32 auxiliarAcumuladorPositivos = 0;

            Console.Write("Ingrese un numero maximo hasta el cual se veran los centros numericos: ");
            numeroMaximo = int.Parse(Console.ReadLine());

            while (numeroMaximo < 1)
            { 
                Console.WriteLine("Error. Usted debe ingresar 1 o mayor.");
                Console.Write("Ingrese un numero maximo hasta el cual se veran los centros numericos: ");
                numeroMaximo = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= numeroMaximo; i++)
            {
             for (int j = 1; j < i; j++)
             {
                  acumuladorNegativos = acumuladorNegativos + j;
             }

             acumuladorPositivos = i + 1;
             auxiliarAcumuladorPositivos = i + 1;

            while (acumuladorNegativos >= acumuladorPositivos)
            {

              if (acumuladorNegativos == acumuladorPositivos)
               {
                Console.WriteLine("Grupo *** Centro numerico: 1..." + (i - 1) + " |" + i + "| " + (i + 1) + "..." + auxiliarAcumuladorPositivos);
                break;
               }

              else
               {
                   auxiliarAcumuladorPositivos = auxiliarAcumuladorPositivos + 1;
                   acumuladorPositivos = acumuladorPositivos + auxiliarAcumuladorPositivos;
               }
            }

                acumuladorNegativos = 0;
                auxiliarAcumuladorPositivos = 0;
                acumuladorPositivos = 0;

            }
            Console.ReadKey();
        }
    }
}

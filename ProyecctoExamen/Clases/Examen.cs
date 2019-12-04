﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyecctoExamen.Clases
{
    class Examen
    {
        /// <summary>
        /// Funcion que define el valor si es prim.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>

        public static Boolean esPrimo(int num)
        {
            Boolean primo = true;
            for(int i=2;i<=num/2; i++)
            {
                if(num%i==0)
                {
                    primo = false;
                    break; //abandonar bucle
                }
            }
            return primo;
        }
        public static int sumatoria(int limite)
        {
            int cont = 0;
            int num = 2, suma = 0;

            while(cont<limite)
            {
                if(esPrimo(num))
                {
                    suma += num;
                }
                num++;
            }
            return suma;

        }
    }
}

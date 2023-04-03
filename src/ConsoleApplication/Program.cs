//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            for (int i = 0; i < 1000000; i++)
            {   
                var train = new Train("12");
                int valorCount = Train.GetCount();
                Console.WriteLine($"El valor de count es: {valorCount}");
            }
            
            
            // train.StartEngines();
            // Console.WriteLine($"{}");
        }
    }
}

/* En el punto 9 se proponen dos comparaciones de objetos utilizando el operador ==.

En la primera comparación t1 == t2, se están comparando dos objetos de la clase Train que tienen el mismo valor para su propiedad de identificador.
Como se está utilizando el operador ==, la comparación se realiza por referencia, es decir, se comprueba si los dos objetos son el mismo objeto en memoria.
En este caso, como se crearon dos objetos diferentes con el mismo valor de identificador, la comparación devuelve false, ya que se trata de dos objetos distintos en memoria.
En la segunda comparación t2 == t3, se están comparando dos objetos de la clase Train que tienen diferentes valores para su propiedad de identificador.
Al igual que en la comparación anterior, la comparación se realiza por referencia utilizando el operador ==. En este caso, como se crearon dos objetos diferentes con diferentes valores de identificador, 
la comparación devuelve false, ya que se trata de dos objetos distintos en memoria. */
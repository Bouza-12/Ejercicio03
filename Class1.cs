using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI03
{
    class Math
    {
        /// <summary>
        /// Eleva un numero al cuadrado y devuelve el valor
        /// </summary>
        /// <param name="resultado">numero a elevear al cuadrado</param>
        /// <returns>cuadrado del numero</returns>
        static public int ElevarAlCuadrado(int resultado)
        {
            return resultado * resultado;
        }

        static public int Sumar(int nroUno, int nroDos)
        {
            return nroUno + nroDos;
        }
    }
}

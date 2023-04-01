using System.Text;
using M = System.Math;  //alias de clase
using System;           //namespace completo

namespace EjercicioI03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            //int numeroIngresado = int.Parse(Console.ReadLine());
            //falta validar el dato
            bool rtaParse = int.TryParse(Console.ReadLine(), out int numeroIngresado);

            if (rtaParse)
            {
                Console.WriteLine(ListarNumerosPrimos(numeroIngresado));
            }
            else
            {
                Console.WriteLine("No ingreso solo numeros.");
            }

            int cuadrado = Math.ElevarAlCuadrado(numeroIngresado);
            Console.WriteLine("el cuadrado del numero ingresado es: {0}",cuadrado);    


            // agrego un comentario para ver el cambio en el GIT
        }

        public static string ListarNumerosPrimos(int numeroTope)
        {
            StringBuilder sb = new StringBuilder(); //nos permite concatenar strings

            for(int i = 2; i <= numeroTope; i++)
            {
                if (EsPrimo(i))
                {
                    sb.AppendFormat("{0}, ", i);
                }
            }
            return sb.ToString();
        }

        public static bool EsNumerico(string cadena)
        {
            return int.TryParse(cadena, out int numero);
        }

        public static bool EsPrimo(int numero)
        {
            for(int i = 2; i < numero; i++)
            {
                if(numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


    }
}
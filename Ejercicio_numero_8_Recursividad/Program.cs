using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicio_numero_8_Recursividad
{
    internal class Program
    {
        /*  Crea una función que calcule el valor de elevar un
            número entero a otro número entero (por ejemplo, 4
            elevado a 3 = 4 * 4 * 4 = 64). Esta función se debe
            crear de forma recursiva. Piensa cuál será el caso
            base (qué potencia se puede calcular de forma trivial)
            y cómo pasar del caso "n-1" al caso "n" (por ejemplo,
            si sabes el valor de 54
            , cómo hallarías el de 55 a partir
            de él).*/

        static void Main()
        {
            Console.WriteLine("Digite numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite Potencia: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int resultado = Potencias(numero1, numero2);
            Console.WriteLine("El resultado de {0} elevando a {1} es: {2} ", numero1, numero2, resultado);
        }

        static int Potencias(int numero1, int numero2)
        {
            if(numero2 == 0)
            {
                return 1;
            }
            else
            {
                return numero1 * Potencias(numero1, numero2 - 1);
            }
        }

        
    }
}
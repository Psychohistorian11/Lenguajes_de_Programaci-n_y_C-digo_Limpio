using System;

namespace PrimeraAplicación_CodigoLimpio
{
    internal class Program
    {

        static void Main()
        {
            /*string nombre = "";
            Console.WriteLine("Por favor ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Hello C# " + nombre);*/

            int numero1, numero2;
            Console.WriteLine("Por favor ingrese un número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor Ingrese otro numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La suma de " + numero1 + " + " + numero2 + " es: " + (numero1 + numero2) );

        }
    }
}

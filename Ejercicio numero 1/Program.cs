using System;

namespace Ejercicio_numero_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Teorema de la Desigualdad Triangular:
            la suma de las longitudes de dos lados cualesquiera
            de un triángulo es mayor o igual que la longitud del tercer lado.*/

            //Algoritmo de Compruebe la Desigualdad Triangular
            Console.WriteLine("la suma de las longitudes de dos lados cualesquiera " +
                "de un triángulo es mayor o igual que la longitud del tercer lado");

            Console.WriteLine("Digite ladoA: ");
            Double ladoA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite ladoB: ");
            Double ladoB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite ladoC: ");
            Double ladoC = Convert.ToDouble(Console.ReadLine());

            Verificar_Desigualdad_Triangular(ladoA, ladoB, ladoC);
        }

        static void Verificar_Desigualdad_Triangular(Double ladoA, Double ladoB, Double ladoC)
        {
            if((ladoA + ladoB) > ladoC) 
            {
               if((ladoA + ladoC) > ladoB)
                {
                    if((ladoC + ladoB) > ladoA)
                    {
                        Cumple_Desigualdad_Triangular(ladoA, ladoB, ladoC);
                    }
                    else
                    {
                        No_cumple_Desigualdad_Triangular(ladoC, ladoB, ladoA);
                    }
                }
                else
                {
                    No_cumple_Desigualdad_Triangular(ladoA, ladoC, ladoB);
                }
            }
            else
            {
                No_cumple_Desigualdad_Triangular(ladoA, ladoB, ladoC);
            }
        }

        static void Cumple_Desigualdad_Triangular(Double ladoA, Double ladoB, Double ladoC)
        {
            Double ladoAB = (ladoA + ladoB);
            Double ladoBC = (ladoB + ladoC);
            Double ladoAC = (ladoA + ladoC);
            Console.WriteLine("Cumple Teorema de Desigualdad Triangular porque: ");
            Console.WriteLine("El ladoA: " + ladoA + " + El ladoB: " + ladoB + " = " + ladoAB + " > ladoC: " + ladoC);
            Console.WriteLine("El ladoA: " + ladoA + " + El ladoC: " + ladoC + " = " + ladoAC + " > ladoB: " + ladoB);
            Console.WriteLine("El ladoB: " + ladoB + " + El ladoC: " + ladoC + " = " + ladoBC + " > ladoA: " + ladoA);
        }

        static void No_cumple_Desigualdad_Triangular(Double ladoX, Double ladoY, Double ladoZ)
        {
            Console.WriteLine("No cumple Teorema de Desigualdad Triangular porque: ");
            Console.WriteLine("El lado: "+ ladoX + " + El lado: " + ladoY + " < que el lado: "+ ladoZ);
        }
    }
}

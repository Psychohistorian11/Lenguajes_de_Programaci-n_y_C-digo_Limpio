using System;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicio_numero_2
{
    internal class Program
    {

        /*  En un curso se practican 4
            evaluaciones con los siguientes
            porcentajes: 25%, 20%, 25% y 30%,
            respectivamente. Por cada estudiante
            se informa código y las cuatro notas.
            Hacer un algoritmo que calcule la
            nota definitiva de cada estudiante, el
            promedio de notas definitivas del
            curso y el porcentaje de perdedores.*/

        static void Main(string[] args)
        {
            double cantidadDeEstudiantes = 0;
            int codigo = 0;
            double nota25 = 0;
            double notanumero2_25 = 0;
            double nota30 = 0;
            double nota20 = 0;
            double notaDefinitiva = 0;
            double promedio = 0;
            double sumaDeNotas = 0;
            List < double> estudiantes = new List<double>();
                List<int> codigoEstudiante = new List<int>();



                Console.WriteLine("Ingrese cantidad de estudiantes: ");
                cantidadDeEstudiantes = Convert.ToInt16(Console.ReadLine());

                for (int estudiante = 0; estudiante < cantidadDeEstudiantes; estudiante++)
                {
                    Console.WriteLine("Digite Codigo del estudiante: ");
                    codigo = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("Digite Nota del 25%: ");
                    nota25 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite Nota del segundo 25%: ");
                    notanumero2_25 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite Nota del 20%: ");
                    nota20 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite Nota del 30%: ");
                    nota30 = Convert.ToDouble(Console.ReadLine());

                    notaDefinitiva = ((nota25 * 0.25) + (notanumero2_25 * 0.25) + (nota20 * 0.20) + (nota30 * 0.30));
                    estudiantes.Add(notaDefinitiva);
                    codigoEstudiante.Add(codigo);


                }

                foreach (var i in estudiantes)
                {
                    sumaDeNotas = sumaDeNotas + i;
                }
                promedio = (sumaDeNotas / cantidadDeEstudiantes);

                double materiaPerdida = 0f;
                double porcentajeMateriaPerdida = 0f;

                foreach (var i in estudiantes)
                {
                    if (i >= 3.0)
                    {
                        materiaPerdida += 1;
                    }
                }

                porcentajeMateriaPerdida = (materiaPerdida * 100) / cantidadDeEstudiantes;

                for (int i = 0; i < cantidadDeEstudiantes; i++)
                {
                    Console.WriteLine("Codigo del Estudiante: {0}, Su definita es: {1}", codigoEstudiante[i], estudiantes[i]);
                }

                Console.WriteLine("El promedio de notas definitas es: " + promedio);
                Console.WriteLine("El porcentaje de de personas que perdieron el curso es de : " + porcentajeMateriaPerdida + "%");

            }

        }
    }
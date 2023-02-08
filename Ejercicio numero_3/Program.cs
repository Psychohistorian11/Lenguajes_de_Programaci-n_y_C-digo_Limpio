using System;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicio_numero_3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Double cantidadDeEstudiantes = 0;
            int codigo = 0;
            float nota25 = 0f;
            float notanumero2_25 = 0f;
            float nota30 = 0f;
            float nota20 = 0f;
            double notaDefinitiva = 0f;
            Double promedio = 0f;
            Double sumaDeNotas = 0f;
            List<Double> estudiantes = new List<Double>();
            List<int> codigoEstudiante = new List<int>();



            Console.WriteLine("Ingrese cantidad de estudiantes: ");
            cantidadDeEstudiantes = Convert.ToInt16(Console.ReadLine());

            for (int estudiante = 0; estudiante < cantidadDeEstudiantes; estudiante++)
            {
                Console.WriteLine("Digite Codigo del estudiante: ");
                codigo = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Digite Nota del 25%: ");
                nota25 = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Digite Nota del segundo 25%: ");
                notanumero2_25 = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Digite Nota del 20%: ");
                nota20 = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Digite Nota del 30%: ");
                nota30 = Convert.ToInt16(Console.ReadLine());

                notaDefinitiva = Convert.ToDouble((nota25 * 0.25) + (notanumero2_25 * 0.25) + (nota20 * 0.20) + (nota30 * 0.30));
                estudiantes.Add(notaDefinitiva);
                codigoEstudiante.Add(codigo);


            }

            foreach (var i in estudiantes)
            {
                sumaDeNotas =+ i;
            }
            promedio = (sumaDeNotas / cantidadDeEstudiantes);

                Double materiaPerdida = 0f;
                Double porcentajeMateriaPerdida = 0f;

                foreach(var i in estudiantes)
                {
                    if(i >= 3.0)
                    {
                        materiaPerdida += 1;
                    }
                }

                porcentajeMateriaPerdida = (materiaPerdida * 100) / cantidadDeEstudiantes;

            for(int i  = 0; i < cantidadDeEstudiantes; i++)
            {
                Console.WriteLine("El codigo del Estudiante: {0}, Su definita es: {1}", codigoEstudiante[i], estudiantes[i]);
            }

            Console.WriteLine("El promedio de notas definitas es: " + promedio);
            Console.WriteLine("El porcentaje de de personas que perdieron el curso es de : " + porcentajeMateriaPerdida + "%");


        }

        

        
        
        
        
    }
}
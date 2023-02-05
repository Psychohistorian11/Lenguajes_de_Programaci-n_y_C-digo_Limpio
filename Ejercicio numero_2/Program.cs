using System;

namespace Ejercicio_numero_2
{
    internal class Program
    {
        static void Main(string[] args)
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

            List<int> studentsList = new List<int>();
            List<int> student = new List<int>();

            Console.WriteLine("Ingrese la cantidad de Estudiantes en el curso: ");
            int NumberOfStudents = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < NumberOfStudents; i++)
            {

                for (int j = 0; j < 1; j++)
                {   //Codigo del estudiante
                    Console.WriteLine("Digite el Codigo del estudiante: ");
                    student.Add(Convert.ToInt32(Console.ReadLine()));
                    //Nota del 25%
                    Console.WriteLine("Digite Nota del 25%: ");
                    student.Add(Convert.ToInt32(Console.ReadLine()));
                    //Nota del 20%
                    Console.WriteLine("Digite Nota del 20%: ");
                    student.Add(Convert.ToInt32(Console.ReadLine()));
                    //Nota del 25%
                    Console.WriteLine("Digite Nota del 25%: ");
                    student.Add(Convert.ToInt32(Console.ReadLine()));
                    //Nota del 30%
                    Console.WriteLine("Digite Nota del 30%: ");
                    student.Add(Convert.ToInt32(Console.ReadLine()));

                }
                studentsList.AddRange(student);

            }

            foreach(var i in studentsList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(studentsList);
            Console.WriteLine("hloa");
            Console.WriteLine(studentsList.Count);
        }
    }
}
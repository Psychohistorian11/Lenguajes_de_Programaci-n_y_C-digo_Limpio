using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicio_numero_3
{
    internal class Program
    {
        /*Se tiene la siguiente información por cada
        uno de los N estudiantes de la universidad:
        Edad
        Sexo (1: masculino; 2: femenino)
        Carrera (1: ingeniería; 2: otra carrera)
        Hacer un algoritmo que obtenga:
        ✓ Promedio de edad de los estudiantes de
        Ingeniería.
        ✓ Porcentaje de hombres en la universidad.
        ✓ Porcentaje de mujeres que estudian
        Ingeniería.*/

        static void Main()
        {
            InterfazPorConsola();
        }


        static void InterfazPorConsola()
        {
            Console.WriteLine("|| Bienvenido al sistema de integración de esudiantes de la universidad ||");
            Console.WriteLine("");
            int bandera = 1;
            int edad;
            int sexo;
            int carrera;
            List<int> edades = new List<int>();
            List<int> sexoDeEstudiantes = new List<int>();
            List<int> carreras = new List<int>();
            double promedio;
            double porcentajeDeHombres;
            double porcentajeDeMujereIng;

            while(bandera == 1)
            {
                Console.WriteLine("Desea Ingresar estudiante, Digite: (1) Si, (2) No");
                bandera = Convert.ToInt32(Console.ReadLine());
                if(bandera == 2)
                {
                    break;
                }

                Console.WriteLine("Edad: ");
                edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Sexo: (1): Masculino, (2): Femenino");
                sexo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Carrera: (1): Ingenieria, (2): Otra carrera");
                carrera = Convert.ToInt32(Console.ReadLine());

                edades.Add(edad);
                sexoDeEstudiantes.Add(sexo);
                carreras.Add(carrera);

            }

            promedio = PromedioDeEdades(edades);
            porcentajeDeHombres = PorcentajeDeHombres(sexoDeEstudiantes);
            porcentajeDeMujereIng = PorcentajeDeMujeresIng(sexoDeEstudiantes, carreras);

            InterfazResultado(promedio, porcentajeDeHombres, porcentajeDeMujereIng);
           
        }

        static void InterfazResultado(double promedio, double porcentajeDeHombres, double porcentajeDeMujeresIng)
        {
            Console.WriteLine("El promedio de las edades de los estudiantes es: {0}", promedio);
            Console.WriteLine("");
            Console.WriteLine("El porcentaje de hombres en la universidad es de: {0}", porcentajeDeHombres);
            Console.WriteLine("");
            Console.WriteLine("El porcentaje de mujeres en la facultad de Ingenierias es de: {0}", porcentajeDeMujeresIng);
        }

        static double PromedioDeEdades(List<int> edades)
        {
            int sumaDeEdades = 0;
            int cantidadDeEstudiantes = 0;
            double promedio;

            foreach(var i in edades)
            {
                sumaDeEdades = sumaDeEdades + i;
                cantidadDeEstudiantes++;
            }

            promedio = sumaDeEdades / cantidadDeEstudiantes;
            return promedio;
        }

        static double PorcentajeDeHombres(List<int> sexoDeEstudiantes)
        {

            int cantidadDeHombres = 0;
            int cantidadDeMujeres = 0;
            int cantidadDeEstudiantes = 0;
            double porcentajeDeHombres = 0;

            foreach(var i in sexoDeEstudiantes)
            {

                cantidadDeEstudiantes++;

                if(i == 1)
                {
                    cantidadDeHombres++;
                }
                else
                {
                    cantidadDeMujeres++;
                }
            }

            porcentajeDeHombres = (cantidadDeHombres*100) / cantidadDeEstudiantes;
            return porcentajeDeHombres;
        }

        static double PorcentajeDeMujeresIng(List<int> sexoDeEstudiantes, List<int> carreras)
        {
            double porcentajeDeMujeres = 0;
            int cantidadDeMujeres = 0;
            int cantidadDeMujeresIng = 0;

            

            foreach(var i in sexoDeEstudiantes)
            {
             
                if(i == 2 && carreras[i] == 1)
                {
                    cantidadDeMujeresIng++;
                }
                
                if(i == 2)
                {
                    cantidadDeMujeres++;
                }

            }
            porcentajeDeMujeres = (cantidadDeMujeresIng * 100) / cantidadDeMujeres;

            return porcentajeDeMujeres;
        }
    }  
}
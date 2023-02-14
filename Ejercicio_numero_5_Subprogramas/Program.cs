using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicio_numero_5_Subprogramas
{
    internal class Program
    {
        /*  1. Diseñar una función que encuentre el factorial de un número y el programa
               que la invoque.
            2. Diseñe un programa con dos funciones para encontrar el área y el
            perímetro de un rectángulo.
            3. Diseñe un programa con dos funciones, una para determinar si 3 longitudes
            forman un triángulo y otra para definir el tipo de triángulo.
            4. Crea un programa que pida dos número enteros al usuario y diga si alguno
            de ellos es múltiplo del otro. Crea una función EsMultiplo que reciba los dos
            números, y devuelve si el primero es múltiplo del segundo.*/

        static void Main()
        {
            InterfazDeLosEnunciados();
        }
     
        
        static void InterfazDeLosEnunciados()
        {
            int bandera = 0;
            Console.WriteLine("====================================================================" +
                              "|| BIENVENIDO A LA CONSOLA DE LOS EJERCICIOS N° 5 DE SUBPROGRAMAS ||" +
                              "====================================================================");
            Console.WriteLine("");
            Console.WriteLine("   Digite 1 Para saber el factorial de un numero" +
                              "   Digite 2 Para saber el Área y el perímetro de un rectángulo" +
                              "   Digite 3 Para Saber si tres longitudes forman un triángulo y que tipo de triángulo" +
                              "   Digite 4 Para saber si un numero es multipo de otro" +
                              "   Digite 5 Para salir del programa");

            bandera = Convert.ToInt32(Console.ReadLine());

            switch (bandera) 
            { 
                case 1:
                    FactorialDeUnNumeroInterfaz();
                    break;
                case 2:
                    AreayPerimetroDeUnRectanguloInterfaz();
                    break;
                case 3:
                    TresLongitudesFormanUnTrianguloySuTipo();
                    break;
                case 4:
                    SiUnNumeroEsMultiploDelOtro();
                    break;
                case 5:
                    CerrarPrograma();
                    break;


            }

            

        }

        static void FactorialDeUnNumeroInterfaz()
        {
            int numero = 0;
            Console.WriteLine("==========================" +
                              " ¡Factorial de un numero!" +
                              "==========================");
            Console.WriteLine("Digite numero que desea su factorial: ");
            numero = Convert.ToInt32(Console.ReadLine());

            int resultado = Factorial(numero);

            static int Factorial(int numero)
            {
                if(numero == 0)
                {
                    return 1;
                }
                else
                {
                    return numero * Factorial(numero - 1);
                }
            }

            Console.WriteLine("El factorial del numero {0} es: {1}", numero, resultado);
            Console.WriteLine("Digite 1 Para seguir en la pestaña del factorial");
            Console.WriteLine("Digite 2 Para volver al menu inicial: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            switch(numero1)
            {
                case 1:
                    FactorialDeUnNumeroInterfaz();
                    break;
                case 2:
                    InterfazDeLosEnunciados();
                    break;
            }
            

        }

        static void AreayPerimetroDeUnRectanguloInterfaz()
        {
            Console.WriteLine("=====================================" +
                              " ¡Área y perimetro de un rectangulo!"  +
                              "=====================================");
            Console.WriteLine("Digite Lado horizontal del rectangulo: ");
            double horizontal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite Lado Vertical del rectangulo: ");
            double vertical = Convert.ToDouble(Console.ReadLine());

            double area = Area(horizontal, vertical);
            double perimetro = Perimetro(horizontal, vertical);
            

            static double Area(double horizontal, double vertical)
            {
                double area = 0;
                area = horizontal * vertical;
                return area;
            }

            static double Perimetro(double horizontal, double vertical)
            {
                double perimetro = 0;
                perimetro = (horizontal * 2) + (vertical * 2);
                return perimetro;
            }

            Console.WriteLine("El área del rectangulo es: {0}, y su perimetro es de {1}: ", area, perimetro);
            Console.WriteLine("Digite 1 Para seguir en la pestaña del area y perimetro del rectángulo");
            Console.WriteLine("Digite 2 Para volver al menu inicial: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            switch (numero1)
            {
                case 1:
                    AreayPerimetroDeUnRectanguloInterfaz();
                    break;
                case 2:
                    InterfazDeLosEnunciados();
                    break;
            }
        }

        static void TresLongitudesFormanUnTrianguloySuTipo()
        {
            Console.WriteLine("Digite 1 Para seguir en la pestaña...");
            Console.WriteLine("Digite 2 Para volver al menu inicial: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            switch (numero1)
            {
                case 1:
                    TresLongitudesFormanUnTrianguloySuTipo();
                    break;
                case 2:
                    InterfazDeLosEnunciados();
                    break;
            }
        }

        static void SiUnNumeroEsMultiploDelOtro()
        {
            Console.WriteLine("Digite 1 Para seguir en la pestaña...");
            Console.WriteLine("Digite 2 Para volver al menu inicial: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            switch (numero1)
            {
                case 1:
                    SiUnNumeroEsMultiploDelOtro();
                    break;
                case 2:
                    InterfazDeLosEnunciados();
                    break;
            }
        }

        static void CerrarPrograma()
        {
            Console.WriteLine("no se");
        }
        
    }
}
// See https://aka.ms/new-console-template for more information
Main1 main = new Main1();
main.Main();

/*En las elecciones para Alcalde del PUEBLITO PAISA se han
presentado tres candidatos (A, B, C). El Pueblito está
dividido en 5 zonas de votación. El reporte de votos de la
zona se recibe en orden: primero la zona 1, la 2, la 3, la 4 y
por último la zona 5.
Elabore un algoritmo que:
• Forme una matriz de 5 filas y 3 columnas que contenga,
en cada fila, los votos reportados por las zonas para cada
uno de los tres candidatos.
• Encuentre el total de votos obtenidos por cada candidato
y el porcentaje que éste representa.
• Escriba un mensaje declarando ganador a un candidato,
si éste obtuvo más del 50% de la votación.*/

public class Votacion
{
    public int[,] votos;

    public Votacion(int[,] votos)
    {
        this.Votos = votos;
    }

    public int[,] Votos { get => votos; set => votos = value; }

    public int[,] llenarMatriz(int[,] matrizDeVotos)
    {
        /*Forme una matriz de 5 filas y 3 columnas que contenga,
          en cada fila, los votos reportados por las zonas para cada
          uno de los tres candidatos.*/

        string[] cantidatos = { "A", "B", "C" };

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < cantidatos.Count(); j++)
            {


                Console.WriteLine("Ingrese cantidad de votos para el candidato {0} en la zona {1}: ", cantidatos[j], i + 1);
                int voto = Convert.ToInt32(Console.ReadLine());
                matrizDeVotos[i, j] = voto;
            }
        }
        Console.WriteLine("A continación se mostraran los votos obtenidos: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Zona: " + (i + 1));
            for (int j = 0; j < cantidatos.Count(); j++)
            {
                Console.Write("  " + cantidatos[j] + " [" + matrizDeVotos[i, j] + "]");
            }
            Console.WriteLine("");

        }
        Console.WriteLine("");

        return matrizDeVotos;
    }

    public void totalDeVotosYPorcentajes(int[,] matrizDeVotos)
    {
        List<int> totalDeDatos = new List<int>();
        int sumaDeDatos = 0;
        /*Encuentre el total de votos obtenidos por cada candidato
          y el porcentaje que éste representa.*/
        for (int j = 0; j < 3; j++)
        {
            for (int i = 0; i < 5; i++)
            {
                sumaDeDatos += matrizDeVotos[i,j];
            }
            totalDeDatos.Add(sumaDeDatos);
            sumaDeDatos = 0;
        }
        Console.WriteLine("|| Total de votos ||");
        foreach (int votos in totalDeDatos)
        {
            sumaDeDatos += votos;
        }

        double porcentajeA = (totalDeDatos[0] * 100) / sumaDeDatos;
        double porcentajeB = (totalDeDatos[1] * 100) / sumaDeDatos;
        double porcentajeC = (totalDeDatos[2] * 100) / sumaDeDatos;

        Console.WriteLine("El candidato A con una suma total de: {0} " +
                          "votos representa el {1}% de la suma total de votos", totalDeDatos[0], porcentajeA);
        Console.WriteLine("");
        Console.WriteLine("El candidato B con una suma total de: {0} " +
                          "votos representa el {1}% de la suma total de votos", totalDeDatos[1], porcentajeB);
        Console.WriteLine("");
        Console.WriteLine("El candidato C con una suma total de: {0} " +
                          "votos representa el {1}% de la suma total de votos", totalDeDatos[2], porcentajeC);

        ganador(totalDeDatos);
    }


    public void ganador(List<int> totalDeDatos)
    {
        /*Escriba un mensaje declarando ganador a un candidato,
        si éste obtuvo más del 50% de la votación.*/
        int sumaDeDatos = 0;
        foreach (int votos in totalDeDatos)
        {
            sumaDeDatos += votos;
        }

        double porcentajeA = (totalDeDatos[0] * 100) / sumaDeDatos;
        double porcentajeB = (totalDeDatos[1] * 100) / sumaDeDatos;
        double porcentajeC = (totalDeDatos[2] * 100) / sumaDeDatos;

        if (porcentajeA > 50)
        {
            Console.WriteLine("El Candidato Ganador es el A con {0} votos que representan más del 50% de los votos registrados ", totalDeDatos[0]);
        }
        else
        {
            Console.WriteLine("Ninngun Candidato ha superado el 50% de los votos");
        }
        if (porcentajeB > 50)
        {
            Console.WriteLine("El Candidato Ganador es el B con {0} votos que representan más del 50% de los votos registrados ", totalDeDatos[1]);
        }
        else
        {
            Console.WriteLine("Ninngun Candidato ha superado el 50% de los votos");
        }
        if (porcentajeC > 50)
        {
            Console.WriteLine("El Candidato Ganador es el C con {0} votos que representan más del 50% de los votos registrados ", totalDeDatos[2]);
        }
        else
        {
            Console.WriteLine("Ninngun Candidato ha superado el 50% de los votos");
        }

        Console.ReadKey();
    }

    

}
public class Main1
{
    public void Main()
    {
        Console.WriteLine("||  Elecciones para Alcalde del PUEBLITO PAISA (2023) ||");
        Console.WriteLine("");
        Console.WriteLine("     Se presentan 3 Candidatos y 5 Zonas de votación    ");

        Console.WriteLine(" Digite 1: Registrar votos" +
                      " Digite 2: Salir del sistema ");

        int bandera = Convert.ToInt32(Console.ReadLine());
        switch (bandera)
        {
            case 1:
                int[,] votos = new int[5, 3];
                Votacion votacion = new Votacion(votos);
                Console.WriteLine("");
                votacion.totalDeVotosYPorcentajes(votacion.llenarMatriz(votos));
                Console.WriteLine("");
                break;
            case 2:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Digito no Valido");
                Main();
                break;

        }
    }
}

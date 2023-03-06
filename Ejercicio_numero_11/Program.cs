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

using System.Runtime.CompilerServices;
using System.Xml.Schema;

class Votacion
{
    public int[,] votos = new int[5, 3];

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

        string[] cantidatos = { "A","B","C"};

        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < cantidatos.Count(); j++)
            {
                Console.WriteLine("Ingrese cantidad de votos para el candidato {0} en la zona {1}: ", cantidatos[j],i);
                int voto = Convert.ToInt32(Console.ReadLine());
                matrizDeVotos[i,j] = voto;
            }
        }

        return matrizDeVotos;
    }

    public void totalDeVotosYPorcentajes()
    {
        /*Encuentre el total de votos obtenidos por cada candidato
          y el porcentaje que éste representa.*/

    }

    public void ganador()
    {

    }


}

public static class Main
{
    public static void Main2()
    {
        Console.WriteLine("||  Elecciones para Alcalde del PUEBLITO PAISA (2023) ||");
        Console.WriteLine("");
        Console.WriteLine("      Se presentan 3 Candidatos y 5 Zonas de votación    ");
        Console.WriteLine(" Digite 1: Registrar votos" +
                          " Digite 2: Salir del sistema ");
        int bandera = Convert.ToInt32(Console.ReadLine());
        switch (bandera)
        {
            case 1:
                int[,] votos = new int[5, 3];
                Votacion votacion = new Votacion(votos);
                votacion.llenarMatriz(votos);
                Console.WriteLine("");
                votacion.totalDeVotosYPorcentajes();
                Console.WriteLine("");
                votacion.ganador();
                break;
            case 2:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Digito no Valido");
                Main2();
                break;

        }
    }
}
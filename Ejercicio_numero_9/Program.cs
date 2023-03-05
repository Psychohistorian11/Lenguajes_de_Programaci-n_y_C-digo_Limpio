public class Estudiante
{

    string nombre = "";
    int cedula = 0;
    int estratoDeLaVivienda = 0;

    public Estudiante(string nombre, int cedula, int estratoDeLaVivienda)
    {
        this.Nombre = nombre;
        this.Cedula = cedula;
        this.EstratoDeLaVivienda = estratoDeLaVivienda;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public int Cedula { get => cedula; set => cedula = value; }
    public int EstratoDeLaVivienda { get => estratoDeLaVivienda; set => estratoDeLaVivienda = value; }


    public double CalcularValorPorMatricula(double estrato)
    {
        switch (estrato)
        {
            case 1:
                return 500000;  
            case 2:
                return 800000;
            case 3:
                return 1800000;
            case 4:
                return 3000000;
            case 5:
                return 3700000;
            case 6:
                return 4500000;

        }
        return 0;

    }

    public static void Main()
    {


        Console.WriteLine("|| Pago de Matricula ||");
        Console.WriteLine("Digite nombre, Cedula y estrato del estudiante: ");
        string nombre = Console.ReadLine();
        int cedula = Convert.ToInt32(Console.ReadLine());
        int estratoDeLaVivienda = Convert.ToInt32(Console.ReadLine());
        Estudiante Estudiante_1 = new Estudiante(nombre, cedula, estratoDeLaVivienda);
        double pago = Estudiante_1.CalcularValorPorMatricula(Estudiante_1.EstratoDeLaVivienda);

        Console.WriteLine("Estudiante: {0}, Identificado con el numero de cédula {1}, El pago" +
         " de su matricula es: {2}", Estudiante_1.Nombre, Estudiante_1.Cedula, pago);
        Console.ReadKey();


    }
}

     
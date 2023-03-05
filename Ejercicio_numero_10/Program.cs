public class Liga
{
    private string nombre_de_la_Liga;
    private int cantidad_de_Atletas;
    Atleta atleta;

    public Liga(string nombre_de_la_Liga, int cantidad_de_Atletas, Atleta atleta)
    {
        this.Nombre_de_la_Liga = nombre_de_la_Liga;
        this.Cantidad_de_Atletas = cantidad_de_Atletas;
        this.Atleta = atleta;
    }

    public string Nombre_de_la_Liga { get => nombre_de_la_Liga; set => nombre_de_la_Liga = value; }
    public int Cantidad_de_Atletas { get => cantidad_de_Atletas; set => cantidad_de_Atletas = value; }
    public Atleta Atleta { get => atleta; set => atleta = value; }

    public string LigaMayorCantidaddeAtletas(string nombre_de_la_liga,int cantidad_de_Atletas)
    {
        int cantidad;
        string mayorCantidadDeAtletas = nombre_de_la_liga;
        cantidad = cantidad_de_Atletas;

        if(cantidad_de_Atletas > cantidad)
        {

        }

        return mayorCantidadDeAtletas;
    }
}
public class Atleta
{
    private int identificación;
    private string nombre;
    private int cantidad_de_Titulos;

    public Atleta(int identificación, string nombre, int cantidad_de_Titulos)
    {
        this.Identificación = identificación;
        this.Nombre = nombre;
        this.Cantidad_de_Titulos = cantidad_de_Titulos;
    }

    public int Identificación { get => identificación; set => identificación = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public int Cantidad_de_Titulos { get => cantidad_de_Titulos; set => cantidad_de_Titulos = value; }

    public void Main()
    {
        Atleta atleta1 = new Atleta(156423,"Santiago",12); 
        Liga liga1 = new Liga("SuperLiga", 333,atleta1);

        Console.WriteLine("|| Bienvenido a software de ligas de futbol ||");
        Console.WriteLine()
    }
}
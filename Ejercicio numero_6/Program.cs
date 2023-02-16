// See https://aka.ms/new-console-template for more information

/*Crear una clase llamada Persona. Sus atributos son: nombre, edad e identificación. Construir
los siguientes métodos para la clase:
Un constructor con parámetros para la clase.
Las propiedades de acceso para cada uno de los atributos.
mostrar(): Muestra los datos de la persona.
esMayorDeEdad(): Devuelve un valor lógico indicando si es mayor de edad.*/
Persona persona = new Persona("Cristian", 18, 1045488961);
persona.Mostrar();
Console.ReadKey();

public class Persona
{
    private string nombre;
    private int edad;
    private int identificacion;

    public Persona(string nombre, int edad, int identificacion)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.identificacion = identificacion;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public int Edad { get => edad; set => edad = value; }
    public int Identificacion { get => identificacion; set => identificacion = value; }

    public void Mostrar()
    {
        Console.WriteLine("Nombre de la persona: " + Nombre);
        Console.WriteLine("Edad de la persona: " + Edad);
        Console.WriteLine("Identificacion de la persona: " + Identificacion);
        Console.WriteLine("La persona es mayor de edad: " + esMayorDeEdad());


    }

    public bool esMayorDeEdad()
    {
        if(Edad >= 18)
        {
            return true;
        }
        return false;
    }
    
}



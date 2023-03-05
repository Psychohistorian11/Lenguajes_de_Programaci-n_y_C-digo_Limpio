// See https://aka.ms/new-console-template for more information
 
Empleado empleado = new Empleado(045488961, 1000000, 30000, 10, 10, true, 2);
empleado.Main();

public class Empleado
{
    /*  Crear una clase Empleado que modele la información que una empresa mantiene sobre cada
        empleado: Identificación, sueldo base, pago por hora extra, horas extra realizadas en el mes,
        porcentaje de retención, casado o no y número de hijos.
        La clase debe contemplar las propiedades de acceso para todos los atributos. Se debe tener
        un constructor con todos los atributos. Los otros métodos que debe tener la clase serán los
        siguientes:
        • Cálculo correspondiente a las horas extra realizadas.
        • Cálculo del sueldo bruto.
        • Cálculo de retención, teniendo en cuenta que el porcentaje de retención que hay que
        aplicar es menos 2 puntos si el empleado está casado y menos 1 punto por cada hijo que
        tenga; el porcentaje se aplica sobre todo el sueldo bruto.
        • Método para la visualización toda la información del empleado.*/

    //Atributos.
    private int identificacion;
    private double sueldo_base;
    private double pago_por_hora_extra;
    private double hora_extra_realizada_en_el_mes;
    private double porcentaje_de_retencion;
    private bool casado_o_no;
    private int numero_de_hijos;

    public Empleado(int identificacion, double sueldo_base, double pago_por_hora_extra, double hora_extra_realizada_en_el_mes, double porcentaje_de_retencion, bool casado_o_no, int numero_de_hijos)
    {
        this.identificacion = identificacion;
        this.sueldo_base = sueldo_base;
        this.pago_por_hora_extra = pago_por_hora_extra;
        this.hora_extra_realizada_en_el_mes = hora_extra_realizada_en_el_mes;
        this.porcentaje_de_retencion = porcentaje_de_retencion;
        this.casado_o_no = casado_o_no;
        this.numero_de_hijos = numero_de_hijos;
    }

    public int Identificacion { get => identificacion; set => identificacion = value; }
    public double Sueldo_base { get => sueldo_base; set => sueldo_base = value; }
    public double Pago_por_hora_extra { get => pago_por_hora_extra; set => pago_por_hora_extra = value; }
    public double Hora_extra_realizada_en_el_mes { get => hora_extra_realizada_en_el_mes; set => hora_extra_realizada_en_el_mes = value; }
    public double Porcentaje_de_retencion { get => porcentaje_de_retencion; set => porcentaje_de_retencion = value; }
    public bool Casado_o_no { get => casado_o_no; set => casado_o_no = value; }
    public int Numero_de_hijos { get => numero_de_hijos; set => numero_de_hijos = value; }

    public double HorasExtrasRealizadas()
    {
        double pago = (Hora_extra_realizada_en_el_mes * Pago_por_hora_extra);
        return pago;
    }

    public double SueldoBruto()
    {
        double Horas_Extras = HorasExtrasRealizadas();
        double sueldo_bruto = Sueldo_base * Horas_Extras;
        return sueldo_bruto;
    }

    public double Retencion()
    {
        double sueldo_bruto = SueldoBruto();
        if (Casado_o_no == true)
        {
            Porcentaje_de_retencion = Porcentaje_de_retencion - 2;
        }

        Porcentaje_de_retencion = Porcentaje_de_retencion - Numero_de_hijos;

        sueldo_bruto = (Porcentaje_de_retencion / 100);
        return sueldo_bruto;
    }

    public void Interfaz()
    {
        Console.WriteLine("|| BIENVENIDO USUARIO ||");
        Console.WriteLine("Usuario: {0}", Identificacion);
        Console.WriteLine("Horas Extras realizadas: {0}", HorasExtrasRealizadas() + "horas");
        Console.WriteLine("Sueldo Bruto: {0}", SueldoBruto());
        Console.WriteLine("Su sueldo bruto menos la Retención es de: {0}", Retencion());

    }
    public void Main()
    {
        Empleado empleado = new Empleado(1045488961, 1000000, 30000, 10, 10, true, 2);
        empleado.Interfaz();
        Console.ReadKey();
    }

}


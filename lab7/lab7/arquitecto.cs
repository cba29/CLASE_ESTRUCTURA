using System;

public class Arquitecto
{
    public string Codigo { get; set; }
    public string Nombres { get; set; }
    public string CondicionContrato { get; set; }
    public string Especialidad { get; set; }
    public string TipoActividad { get; set; }
    public string TipoAfiliacion { get; set; }

    public Arquitecto(string codigo, string nombres, string condicionContrato, string especialidad, string tipoActividad, string tipoAfiliacion)
    {
        Codigo = codigo;
        Nombres = nombres;
        CondicionContrato = condicionContrato;
        Especialidad = especialidad;
        TipoActividad = tipoActividad;
        TipoAfiliacion = tipoAfiliacion;
    }

    public double CalcularSueldoBase()
    {
        if (CondicionContrato == "Estable")
        {
            if (TipoActividad == "Supervisión de Obras")
            {
                return 4000;
            }
            else if (TipoActividad == "Supervisión de Vías")
            {
                return 6000;
            }
        }
        else if (CondicionContrato == "Contratado")
        {
            if (TipoActividad == "Supervisión de Obras")
            {
                return 2000;
            }
            else if (TipoActividad == "Supervisión de Vías")
            {
                return 4500;
            }
        }
        return 0;
    }

    public double CalcularDescuento()
    {
        double sueldoBase = CalcularSueldoBase();
        if (TipoAfiliacion == "AFP")
        {
            return sueldoBase * 0.15;
        }
        else if (TipoAfiliacion == "SNP")
        {
            return sueldoBase * 0.08;
        }
        return 0;
    }

    public double CalcularSueldoNeto()
    {
        double sueldoBase = CalcularSueldoBase();
        double descuento = CalcularDescuento();
        return sueldoBase - descuento;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Código: {Codigo}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Condición de Contrato: {CondicionContrato}");
        Console.WriteLine($"Especialidad: {Especialidad}");
        Console.WriteLine($"Tipo de Actividad: {TipoActividad}");
        Console.WriteLine($"Tipo de Afiliación: {TipoAfiliacion}");
        Console.WriteLine($"Sueldo Base: {CalcularSueldoBase()}");
        Console.WriteLine($"Descuento: {CalcularDescuento()}");
        Console.WriteLine($"Sueldo Neto: {CalcularSueldoNeto()}");
    }
}




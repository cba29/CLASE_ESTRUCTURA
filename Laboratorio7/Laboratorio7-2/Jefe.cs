namespace Laboratorio7_2
{
    public class Jefe
    {
        public string Nombres { get; set; }
        public string DNI { get; set; }
        public string Cargo { get; set; }
        public string Area { get; set; }
        public int AniosAntiguedad { get; set; }

        public Jefe(string nombres, string dni, string cargo, string area, int aniosAntiguedad)
        {
            Nombres = nombres;
            DNI = dni;
            Cargo = cargo;
            Area = area;
            AniosAntiguedad = aniosAntiguedad;
        }

        public double CalcularSueldoBase()
        {
            if (Area == "Contabilidad")
            {
                if (Cargo == "Gerente")
                {
                    return 6000;
                }
                else if (Cargo == "Subgerente")
                {
                    return 5000;
                }
            }
            else if (Area == "Planificación")
            {
                if (Cargo == "Gerente")
                {
                    return 7000;
                }
                else if (Cargo == "Subgerente")
                {
                    return 6000;
                }
            }
            return 0;
        }

        public double CalcularMovilidad()
        {
            if (Cargo == "Gerente")
            {
                return 700;
            }
            else if (Cargo == "Subgerente")
            {
                return 400;
            }
            return 0;
        }

        public double CalcularBonificacion()
        {
            double sueldoBase = CalcularSueldoBase();
            if (AniosAntiguedad <= 7)
            {
                return sueldoBase * 0.05;
            }
            else if (AniosAntiguedad >= 8)
            {
                return sueldoBase * 0.04;
            }
            return 0;
        }

        public double CalcularSueldoFinal()
        {
            double sueldoBase = CalcularSueldoBase();
            double bonificacion = CalcularBonificacion();
            double movilidad = CalcularMovilidad();
            return sueldoBase + bonificacion + movilidad;
        }
    }
}

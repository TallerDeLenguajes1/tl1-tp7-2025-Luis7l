using System;
using System.Security.AccessControl;
namespace sisPersonal
{
    public enum Cargos
    {
        Auxiliar,
        administrador,
        especialista,
        investigador,
        Ingeniero
    }
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char EstadoCivil { get; set; }
        public DateTime FechaIngreso { get; set; }
        public double SueldoBasico { get; set; }
        public Cargos Cargo { get; set; }
        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, DateTime fechaIngreso, double sueldoBasico, Cargos cargo)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            EstadoCivil = estadoCivil;
            FechaIngreso = fechaIngreso;
            SueldoBasico = sueldoBasico;
            Cargo = cargo;
        }


        public int CalcularAntiguedad()
        {
            DateTime hoy = DateTime.Today;
            int antiguedad = hoy.Year - FechaIngreso.Year;
            return antiguedad;
        }
        public int edadEmpleado()
        {
            DateTime Actual = DateTime.Today;
            int edad = Actual.Year - FechaNacimiento.Year;
            return edad;
        }

        public int TiempoParaJubilarse()
        {
            int edadJ = edadEmpleado();
            int FaltaJubilacion = 65 - edadJ;
            if (FaltaJubilacion < 0)
            {
                return -1;
            }
            return FaltaJubilacion;
        }
        public double Salario()
        {
            double adicional = 0;

            int antiguedad = CalcularAntiguedad();

            if (antiguedad <= 20 && antiguedad > 0)
            {
                adicional = SueldoBasico * (0.01 * antiguedad);
            }
            else
            {
                adicional = SueldoBasico * 0.25;
            }

            if (Cargo == Cargos.Ingeniero || Cargo == Cargos.especialista)
            {
                adicional *= 1.5;
            }
            if (EstadoCivil == 'C')
            {
                adicional += 150000;
            }

            return SueldoBasico + adicional;
        }
    }
    

}
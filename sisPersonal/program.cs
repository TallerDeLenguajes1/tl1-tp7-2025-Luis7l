using System;
using sisPersonal;

class Program
{
    static void Main(string[] args)
    {
        Empleado[] emp = new Empleado[3];
        emp[0] = new Empleado("Luis", "Ledesma", new DateTime(2004, 9, 25), 'S', new DateTime(2023, 03, 09), 366000, Cargos.Ingeniero);
        emp[1] = new Empleado("Jose", "Gonzalez", new DateTime(1963, 8, 25), 'C', new DateTime(2009, 04, 01), 650000, Cargos.especialista);
        emp[2] = new Empleado("Alfonso", "Perez", new DateTime(1965, 9, 12), 'C', new DateTime(2000, 03, 05), 850000, Cargos.investigador);
        double GastadoSalarios = 0;
        int ProximoAJubilarse=100;
        string NombreProximoJubilado="";
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Empleado:");
            Console.WriteLine($"Nombre: {emp[i].Nombre} {emp[i].Apellido}");
            Console.WriteLine($"Fecha de Nacimiento: {emp[i].FechaNacimiento.ToShortDateString()}");
            Console.WriteLine($"Estado Civil: {emp[i].EstadoCivil}");
            Console.WriteLine($"Fecha de Ingreso: {emp[i].FechaIngreso.ToShortDateString()}");
            Console.WriteLine($"Sueldo Básico: ${emp[i].SueldoBasico}");
            Console.WriteLine($"Cargo: {emp[i].Cargo}");
            if (emp[i].CalcularAntiguedad() <= 0)
            {
                Console.WriteLine("El empleado aun no tiene un año en la empresa");
            }
            else
            {
                Console.WriteLine($"El empleado tiene una antiguedad de: {emp[i].CalcularAntiguedad()} años ");
            }
            Console.WriteLine($"La edad del empleado es:{emp[i].edadEmpleado()}años");
            Console.WriteLine($"Le falta para jubilarce:{emp[i].TiempoParaJubilarse()}años");
            Console.WriteLine($"El salario final del empleado {emp[i].Nombre} es de ${emp[i].Salario()}");
            double salario = emp[i].Salario();
            GastadoSalarios += salario;
            if (ProximoAJubilarse > emp[i].TiempoParaJubilarse())
            {
                ProximoAJubilarse = emp[i].TiempoParaJubilarse();
                NombreProximoJubilado = emp[i].Nombre+" "+emp[i].Apellido;
            }
        }
        Console.WriteLine($"El total gastado de salarios en la empresa es de ${GastadoSalarios}");
        Console.WriteLine($"El empleado que esta mas proximo a jubilarse es {NombreProximoJubilado}");
    }
}

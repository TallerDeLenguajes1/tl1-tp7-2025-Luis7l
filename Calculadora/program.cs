using System;
using EspacioCalculadora;

class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();
        int opcion;

        do
        {
            Console.WriteLine("\n=== Opciones de la Calculadora ===");
            Console.WriteLine("Resultado actual: " + calc.Resultado);
            Console.WriteLine("1 - Suma");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("3 - Multiplicación");
            Console.WriteLine("4 - División");
            Console.WriteLine("5 - Limpiar");
            Console.WriteLine("6 - Salir de la calculadora");
            Console.Write("Ingrese una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida. Ingrese un número del 1 al 6.");
                continue;
            }

            double valor;

            switch (opcion)
            {
                case 1:
                    valor = PedirNumero("Ingrese un número a sumar: ");
                    calc.Sumar(valor);
                    break;
                case 2:
                    valor = PedirNumero("Ingrese un número a restar: ");
                    calc.Resta(valor);
                    break;
                case 3:
                    valor = PedirNumero("Ingrese un número a multiplicar: ");
                    calc.Multiplicar(valor);
                    break;
                case 4:
                    valor = PedirNumero("Ingrese un número a dividir: ");
                    calc.Dividir(valor);
                    break;
                case 5:
                    calc.Limpiar();
                    Console.WriteLine("Calculadora reiniciada.");
                    break;
                case 6:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción fuera de rango.");
                    break;
            }
        } while (opcion != 6);
    }

    static double PedirNumero(string mensaje)
    {
        double valor;
        Console.Write(mensaje);
        while (!double.TryParse(Console.ReadLine(), out valor))
        {
            Console.Write("Entrada inválida. Intente de nuevo: ");
        }
        return valor;
    }
}

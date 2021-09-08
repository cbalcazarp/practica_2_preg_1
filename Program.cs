using System;

namespace practica_2_preg_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double capital, tasaInteres, montoDevolver;
            Int32 periodo;
            Console.WriteLine("Practica 2 - Pregunta 1");
            Console.Write("Ingrese capital (c): ");
            capital = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tasa de interes (%): ");
            tasaInteres = Convert.ToDouble(Console.ReadLine());
            Console.Write("Periodo: ");
            periodo = Convert.ToInt32(Console.ReadLine());

            montoDevolver = capital * Pow((1 + tasaInteres), periodo);

            Console.Write("Monto a devolver" + Convert.ToString(montoDevolver));;
        }
    }
}

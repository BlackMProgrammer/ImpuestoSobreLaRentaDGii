using System;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;

namespace ImpuestoSobreLaRentaDGii
{
    class Program
    {
        static void Main(string[] args)
        {
            string sueldovalor;
            double sueldo, impuesto, sueldoanual, excedentexTasa,AFP,SFS;

            Console.WriteLine("Digite su sueldo:");
            sueldovalor = Console.ReadLine();
            sueldo = Convert.ToDouble(sueldovalor);

            sueldoanual = sueldo * 12;
            AFP = sueldo * 0.0287;
            SFS = sueldo * 0.0304;

            if (sueldoanual <= 416220.00)
            {
                Console.WriteLine("Extento");
                Console.WriteLine("Valor AFP: {0}", Math.Round(AFP, 2));
                Console.WriteLine("Valor SFS: {0}", Math.Round(SFS, 2));
            }
            else if (sueldoanual >= 416220.01 && sueldoanual <= 624329.00)
            {
                impuesto = 0.15;
                Console.WriteLine("Sueldo Anual es de : {0}", sueldoanual);
                Console.WriteLine("La Tasa es de : {0}", impuesto);
                excedentexTasa = ((sueldoanual - 416220.01) * impuesto) / 12;
                Console.WriteLine("Valor mensual a retener = {0}", Math.Round(excedentexTasa, 2));
                Console.WriteLine("Valor AFP: {0}", Math.Round(AFP,2));
                Console.WriteLine("Valor SFS: {0}", Math.Round(SFS, 2));
            }
            else if (sueldoanual >= 624329.01 && sueldoanual <= 867123.00)
            {
                impuesto = 0.20;
                Console.WriteLine("Sueldo Anual es de : {0}",sueldoanual);
                Console.WriteLine("La Tasa es de : {0}", impuesto);
                excedentexTasa = ((31216.00 + ((sueldoanual - 624329.01) * impuesto))/12);
                Console.WriteLine("Valor mensual a retener = {0}", Math.Round(excedentexTasa, 2));
                Console.WriteLine("Valor AFP: {0}", Math.Round(AFP, 2));
                Console.WriteLine("Valor SFS: {0}", Math.Round(SFS, 2));
            }
            else if(sueldoanual >= 867123.01)
            {
                impuesto = 0.25;
                Console.WriteLine("Sueldo Anual es de : {0}", sueldoanual);
                Console.WriteLine("La Tasa es de : {0}", impuesto);
                excedentexTasa = ((79776.00 + (sueldoanual - 867123.01) * impuesto) / 12);
                Console.WriteLine("Valor mensual a retener = {0}", Math.Round(excedentexTasa, 2));
                Console.WriteLine("Valor AFP: {0}", Math.Round(AFP, 2));
                Console.WriteLine("Valor SFS: {0}", Math.Round(SFS, 2));
            }
        }
    }
}

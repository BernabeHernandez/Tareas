using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldo, monto, pago, minimo, interes = 0, multa = 0;

            Console.WriteLine("Ingresa el saldo enterior");
            saldo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el monto de la compra");
            monto = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el pago del corte anterior");
            pago = double.Parse(Console.ReadLine());

            minimo = saldo * .15;

            if (pago < minimo)
            {
                interes = saldo * .12;
                multa = 200;
            }
            saldo = saldo + monto + interes + multa - pago;
            minimo = saldo * .15;

            Console.WriteLine("El saldo actual es: $" + saldo);
            Console.WriteLine("El pago minimo es: $" + minimo);
            Console.WriteLine("El pago para no generar ingresos es: $" + (saldo * .85));
            Console.ReadKey();
        }
    }
}

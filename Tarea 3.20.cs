using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Npantalons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double  mtela, preciof;
            int ctela, npantalones, talla;
            string modelo;


            Console.WriteLine("cual es el modelo que se va a fabricar: A O B");
            modelo = Console.ReadLine();
            Console.WriteLine("cual es el costo del metro de tela");
            ctela = int.Parse(Console.ReadLine());
            Console.WriteLine("cuantos pantalones se van a fabricar");
            npantalones = int.Parse(Console.ReadLine());
            if (!modelo.Equals("A") & !modelo.Equals("B"))
            {
                Console.WriteLine("Error, modelo desconocido");
            }
            else
            {
                Console.WriteLine("Cual es la talla? 30 - 32 - 36");
                talla = int.Parse(Console.ReadLine());
                if (talla != 30 && talla != 32 && talla != 36)
                {
                    Console.WriteLine("Error, talla desconocida");
                }
                else
                {
                    if (modelo.Equals("A"))
                    {
                        mtela = 1.5 * npantalones;
                        preciof = (mtela * ctela) + (mtela * ctela) * 0.8;
                    }
                    else
                    {
                        mtela = 1.8 * npantalones;
                        preciof = (mtela * ctela) + (mtela * ctela) * 0.95;
                    }
                    if (talla == 32 || talla == 36)
                    {
                        preciof = preciof + (preciof * 0.04);
                    }
                    preciof = preciof + (preciof * 0.3);
                    Console.WriteLine("el precio final de venta es: " + preciof);
                }
            }
        }
    }
}

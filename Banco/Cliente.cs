using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancaria
{
    class Cliente
    {

        public double Saldo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NoCuenta { get; set; }



        public Cliente Hacer(int num)
        {
            Cliente c = new Cliente();
            Console.WriteLine("Proporcione nombre del cliente");
            c.Nombre = Console.ReadLine();
            Console.WriteLine("Proporcione apellido del cliente");
            c.Apellido = Console.ReadLine();
            Console.WriteLine("Proporcione el saldo del cliente");
            c.Saldo = double.Parse(Console.ReadLine());
            c.NoCuenta = num;

            return c;
        }
    }
}
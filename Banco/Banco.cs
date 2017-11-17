using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancaria
{
    class Banco : Cliente
    {
        public string nombre { get; set; }
        public void banco(string b)
        {
            nombre = b;
        }

        List<Cliente> clientes = new List<Cliente>();

        public void AgregarClientes(Cliente n)
        {
            clientes.Add(n);
        }
        
        public void Abonar(int item, int dinero)
        {
            int i = 0;
            foreach (Cliente item1 in clientes)
            {
                if (item == i)
                {
                    item1.Saldo += dinero;
                    Console.WriteLine($"Operacion Exitosa");
                }
                i++;
            }
        }
        public void Retirar(int item, int x)
        {
            int i = 0;
            foreach (Cliente item1 in clientes)
            {
                if (item == i)
                {
                    item1.Saldo -= x;
                    Console.WriteLine($"Operacion Concretada");
                }
            }
        }
        public void Consulta(string i)
        {

            int obj = 0;
            foreach (Cliente item in clientes)
            {
                if (i == clientes[obj].Nombre)
                {
                    Console.WriteLine("Nombre:" + item.Nombre + " " + item.Apellido + "\n Numero de cuenta:" + item.NoCuenta + "\nSaldo:" + item.Saldo + "\n");
                }
            }
        }



    }
}
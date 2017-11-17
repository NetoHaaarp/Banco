using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancaria
{
    class Program : Banco
    {
        static void Main(string[] args)
        {
            Banco b = new Banco();
            b.nombre = "Neto";

            for (;;)
            {
                int s;
                Console.WriteLine("Operacion que quiera realizar \n 1) Agregar Cliente \n 2) Abonar a Cliente \n 3) Retirar a Cliente \n 4) Consultar");

                s = byte.Parse(Console.ReadLine());
                if (s == 1)
                { 
                        b.AgregarClientes(b.Hacer(1));
                }
                if (s == 2)
                {
                    Console.WriteLine("Cuanto va a abonar");
                    s = int.Parse(Console.ReadLine());
                    Console.WriteLine("A Que Cuenta abonar");
                    b.Abonar(int.Parse(Console.ReadLine()) - 1, s);
                }
                if (s == 3)
                {
                    Console.WriteLine("¿Cuanto va a retirar?");
                    s = int.Parse(Console.ReadLine());
                    Console.WriteLine("¿En que cuenta desea retirar?");
                    b.Retirar(int.Parse(Console.ReadLine()) - 1, s);
                }                 
                if(s == 4)
                {
                    Console.WriteLine("¿Que persona desea consultar:?");
                    b.Consulta(Console.ReadLine());
                }
                       if (s != 1 && s != 2 && s != 3 && s != 4)
                {
                    Console.WriteLine("ERROR Operacion no Valida");
                    
                }
                        

                }
            }
        }
    }


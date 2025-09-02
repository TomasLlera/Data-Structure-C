using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using Interfaces;

namespace Patrones.Estructurales.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IImpresora cliente = new AdaptadorTermica(new ImpresoraTermicaVieja());
            cliente.Imprimir("Me cree que me salio");
            Console.ReadKey();
        }
    }
}

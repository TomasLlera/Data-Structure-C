using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Classes
{
    public class AdaptadorTermica : IImpresora
    {
        private readonly ImpresoraTermicaVieja _vieja;

        public AdaptadorTermica(ImpresoraTermicaVieja vieja)
        {
            _vieja = vieja;
        }
        public void Imprimir(string texto)
        {
            _vieja.PrintTicket(texto);
        }
    }
}

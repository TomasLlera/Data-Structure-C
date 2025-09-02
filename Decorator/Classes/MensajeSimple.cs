using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Classes
{
    public class MensajeSimple : IMensaje
    {
        public void Enviar(string texto)
        {
            Console.WriteLine($"[MENSAJE] Enviando: {texto}");
        }
    }
}

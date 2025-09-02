using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Classes
{
    public class MensajeEncriptado : MensajeDecorator
    {
        public MensajeEncriptado(IMensaje texto) : base(texto) { }

        public override void Enviar(string texto)
        {
            base.Enviar(texto);
            Console.WriteLine(texto.ToUpper());
        }
    }
}

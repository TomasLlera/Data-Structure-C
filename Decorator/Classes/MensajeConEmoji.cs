using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Classes
{
    class MensajeConEmoji : MensajeDecorator
    {
        public MensajeConEmoji(IMensaje texto, string v) : base(texto) { }

        public override void Enviar(string texto)
        {
            Console.WriteLine(texto + " =D");
            base.Enviar(texto);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Classes
{
    public abstract class MensajeDecorator : IMensaje
    {
        protected readonly IMensaje _texto;
        protected MensajeDecorator(IMensaje texto)
        {
            _texto = texto;
        }
        public virtual void Enviar(string texto) => _texto.Enviar(texto);
    }
}

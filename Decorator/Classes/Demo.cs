using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using Interfaces;

namespace Classes
{
    public static class Demo
    {
        public static void run()
        {
            IMensaje msj = new MensajeSimple();
            msj = new MensajeEncriptado(msj);
            msj = new MensajeConEmoji(msj, "Hola Mundo");
            msj.Enviar("Hola Mundo");
        }
    }
}

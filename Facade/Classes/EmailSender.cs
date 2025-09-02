using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class EmailSender
    {
        public void EnviarBienvenida(string email)
        {
            Console.WriteLine($"[ENVIO] Bienvenido {email}");
        }
    }
}

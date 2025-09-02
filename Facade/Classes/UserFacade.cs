using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class UserFacade
    {
        private readonly EmailSender _sender = new EmailSender();
        private readonly EmailValidator _validator = new EmailValidator();

        public bool RegistrarUsuario (string nombre,string email)
        {
            Console.WriteLine("Iniciando registro de usuario..");
            if (!email.Contains("@"))
            {
                return false;

            }
            if (string.IsNullOrEmpty(nombre))
            {
                return false;
            }

        }
    }
}

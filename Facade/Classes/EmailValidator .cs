using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class EmailValidator
    {
        public bool EsValido(string email)
        {
            Console.WriteLine($"[VALIDANDO] El mail {email} es valido");
            return true;
        }
    }
}

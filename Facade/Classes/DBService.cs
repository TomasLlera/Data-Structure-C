using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class DBService
    {
        public bool GuardarUsuario(string nombre, string mail)
        {
            Console.WriteLine($"Nombre: {nombre} || Mail: {mail}");
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCore
{
    public class Saludo : ISaludo
    {
        public string Saludar(string saludo)
        {
            return $"HOLA MUNDO {saludo}!!";
        }
    }
}

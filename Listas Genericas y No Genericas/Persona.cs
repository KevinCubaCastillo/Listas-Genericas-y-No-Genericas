using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Genericas_y_No_Genericas
{
    public class Persona
    {
        public string ci { get; set; }
        public string name { get; set; }
        public Persona()
        {
            ci = "No Definido";
            name = "No Definido";
        }
        public Persona(string ci, string name)
        {
            this.ci = ci;
            this.name = name;
        }
    }
}

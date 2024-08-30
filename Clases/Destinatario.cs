using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENVIOSMENSAJERIA.Clases
{
    public class Destinatario : Persona
    {
        // Propiedad encapsulada
        public string Compañia { get; private set; }

        public Destinatario(string nombreCompleto, string telefono, string correo, string compañia)
            : base(nombreCompleto, telefono, correo)
        {
            Compañia = compañia;
        }
    }
}

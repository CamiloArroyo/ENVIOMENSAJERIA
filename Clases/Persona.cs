using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENVIOSMENSAJERIA.Clases
{
    public class Persona
    {
        // Propiedades encapsuladas
        public string NombreCompleto { get; private set; }
        public string Telefono { get; private set; }
        public string Correo { get; private set; }

        // Constructor
        public Persona(string nombreCompleto, string telefono, string correo)
        {
            NombreCompleto = nombreCompleto;
            Telefono = telefono;
            Correo = correo;
        }
    }
}

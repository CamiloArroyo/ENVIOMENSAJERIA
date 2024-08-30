using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENVIOSMENSAJERIA.Clases
{
    public class Remitente : Persona
    {
        // Propiedad encapsulada
        public string Departamento { get; private set; }

        public Remitente(string nombreCompleto, string telefono, string correo, string departamento)
            : base(nombreCompleto, telefono, correo)
        {
            Departamento = departamento;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENVIOSMENSAJERIA.Clases
{
    public class Direccion
    {
        // Propiedades encapsuladas
        public string Calle { get; private set; }
        public string Colonia { get; private set; }
        public string Municipio { get; private set; }
        public string Estado { get; private set; }
        public string Pais { get; private set; }
        public string CodigoPostal { get; private set; }

        // Constructor
        public Direccion(string calle, string colonia, string municipio, string estado, string pais, string codigoPostal)
        {
            Calle = calle;
            Colonia = colonia;
            Municipio = municipio;
            Estado = estado;
            Pais = pais;
            CodigoPostal = codigoPostal;
        }
    }
}

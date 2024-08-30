using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENVIOSMENSAJERIA.Clases
{
    public class ServicioSobre : Servicio
    {
        private const double TarifaDocumentos = 10000;

        public override double CalcularCosto(double peso)
        {
            return ValorBase + TarifaDocumentos;
        }
    }
}

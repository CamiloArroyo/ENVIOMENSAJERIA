using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENVIOSMENSAJERIA.Clases
{
    public class ServicioPaquete : Servicio
    {
        public override double CalcularCosto(double peso)
        {
            return ValorBase * peso;
        }
    }
}

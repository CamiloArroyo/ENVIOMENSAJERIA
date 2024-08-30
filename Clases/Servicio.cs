using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENVIOSMENSAJERIA.Clases
{
    public abstract class Servicio
    {
        protected const double ValorBase = 5000;
        public abstract double CalcularCosto(double peso);

    }
}

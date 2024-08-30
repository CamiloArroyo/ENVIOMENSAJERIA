using ENVIOSMENSAJERIA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENVIOSMENSAJERIA.Clases
{
    public class ArchivoGuia
    {
        // Lista encapsulada de guías
        private List<Guia> guias = new List<Guia>();

        // Método para agregar una guía
        public void AgregarGuia(Guia guia)
        {
            guias.Add(guia);
        }

        // Método para consultar guías por estado
        public List<Guia> ConsultarGuiasPorEstado(EstadoGuia estado)
        {
            return guias.Where(g => g.Estado == estado).ToList();
        }

        // Método para consultar guías por destinatario
        public List<Guia> ConsultarGuiasPorDestinatario(Destinatario destinatario)
        {
            return guias.Where(g => g.Destinatario.NombreCompleto.Equals(destinatario.NombreCompleto, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}

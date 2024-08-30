using ENVIOSMENSAJERIA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENVIOSMENSAJERIA.Clases
{
    public class Guia
    {
        public string NumeroGuia { get; private set; }
        public Destinatario Destinatario { get; private set; }
        public Remitente Remitente { get; private set; }
        public string NumRemitente { get; private set; }
        public double Peso { get; private set; }
        public double ValorDeclarado { get; private set; }
        public DateTime? FechaEntrega { get; private set; }
        public Direccion Direccion { get; private set; }
        public EstadoGuia Estado { get; private set; }
        public TipoServicio TipoServicio { get; private set; }
        public Servicio Servicio { get; private set; }
        public bool EsInternacional { get; private set; }

        private const double IncrementoInternacional = 0.25;

        // Constructor
        public Guia(string numeroGuia, Destinatario destinatario, string numDestinatario, Remitente remitente, string numRemitente, double peso, double valorDeclarado, TipoServicio tipoServicio, bool esInternacional)
        {
            NumeroGuia = numeroGuia;
            Destinatario = destinatario;
            Remitente = remitente;
            NumRemitente = numRemitente;
            Peso = peso;
            ValorDeclarado = valorDeclarado;
            TipoServicio = tipoServicio;
            Servicio = GetServicio(TipoServicio);
            Estado = EstadoGuia.DESPACHO;
            EsInternacional = esInternacional;
        }

        // Método privado para obtener el servicio
        private Servicio GetServicio(TipoServicio tipo)
        {
            switch (tipo)
            {
                case TipoServicio.PAQUETE: return new ServicioPaquete();
                case TipoServicio.CAJA: return new ServicioCaja();
                case TipoServicio.SOBRE: return new ServicioSobre();
                default: return null;
            }
        }

        // Método para calcular el costo del envío
        public double CalcularCosto()
        {
            double costo = Servicio.CalcularCosto(Peso);
            if (EsInternacional)
            {
                costo += costo * IncrementoInternacional;
            }
            return costo;
        }

        // Método para registrar la entrega
        public void RegistrarEntrega()
        {
            if (Estado == EstadoGuia.DESPACHO)
            {
                Estado = EstadoGuia.FINALIZADA;
                FechaEntrega = DateTime.Now;
                Console.WriteLine($"La entrega ha sido finalizada. El costo del servicio es: {CalcularCosto()}");
            }
            else
            {
                Console.WriteLine("Esta guía ya fue entregada.");
            }
        }
    }
}




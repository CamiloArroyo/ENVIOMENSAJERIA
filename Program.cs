using ENVIOSMENSAJERIA.Clases;
using ENVIOSMENSAJERIA.Enums;
using System.Drawing;

public class Program
{
    public static void Main(string[] args)
    {
        ArchivoGuia archivo = new ArchivoGuia();

        Remitente remitente = new Remitente("Walberto", "3121651565", "walberto@example.com", "Ventas");
        Destinatario camilo = new Destinatario("Camilo Arroyo", "3153167411", "camilo@example.com", "Empresa ABC");
        Destinatario romario = new Destinatario("Romario Martinez", "3153167232", "romario@example.com", "Empresa XYZ");
        Destinatario daniel = new Destinatario("Daniel Arroyo", "31531624241", "daniel@example.com", "Empresa 123");

        Guia guiaSobre = new Guia("001", camilo, "3153167411", remitente, "3121651565", 0.5, 5000, TipoServicio.SOBRE, false);
        Guia guiaCaja = new Guia("002", romario, "3153167232", remitente, "3121651565", 2.0, 30000, TipoServicio.CAJA, true);
        Guia guiaPaquete = new Guia("003", daniel, "31531624241", remitente, "3121651565", 1.5, 15000, TipoServicio.PAQUETE, false);

        archivo.AgregarGuia(guiaSobre);
        archivo.AgregarGuia(guiaCaja);
        archivo.AgregarGuia(guiaPaquete);

        guiaSobre.RegistrarEntrega();
        guiaCaja.RegistrarEntrega();
        guiaPaquete.RegistrarEntrega();

        var guiasDespacho = archivo.ConsultarGuiasPorEstado(EstadoGuia.DESPACHO);
        Console.WriteLine($"Guias en despacho: {guiasDespacho.Count}");

        var guiasCamilo = archivo.ConsultarGuiasPorDestinatario(camilo);
        Console.WriteLine($"Guias de Camilo Arroyo: {guiasCamilo.Count}");
    }
}

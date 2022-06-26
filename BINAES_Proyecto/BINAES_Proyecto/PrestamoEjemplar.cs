using System;

namespace BINAES_Proyecto
{
    public class PrestamoEjemplar
    {
        public int id_prestamo { get; set; }
        
        public string Nombre { get; set; }
        
        public string Ejemplar { get; set; }
        
        public DateTime FechaReserva { get; set; }
        
        public DateTime Entrega { get; set; }

        public DateTime Devolucion { get; set; }


        public PrestamoEjemplar()
        {

        }
    }
}
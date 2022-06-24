using System;

namespace BINAES_Proyecto
{
    public class PrestamoEjemplar
    {
        public int id { get; set; }

        public string nombre { get; set; }

        public DateTime entrega { get; set; }

        public DateTime devolucion { get; set; }

        public PrestamoEjemplar()
        {

        }
    }
}
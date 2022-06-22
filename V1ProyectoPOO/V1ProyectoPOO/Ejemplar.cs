using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1ProyectoPOO
{
    public class Ejemplar
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string imagen { get; set; }
        public string coleccion { get; set; }
        public string autor { get; set; }
        //fotografia 
        public string isbn { get; set; }
        public string issn { get; set; }
        public string doi { get; set; }
        public DateTime fecha { get; set; }

        public string editorial { get; set; }
        public string formato { get; set; }

        public string idioma { get; set; }
        
        public string PC { get; set; }

    }
}

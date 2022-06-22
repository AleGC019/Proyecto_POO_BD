using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BINAES_Proyecto
{
    public class Ejemplar
    {
        public int ID { get; set; }
        public string Nombre_Ejemplar { get; set; }
        public string Portada { get; set; }
        public string Coleccion { get; set; }
        public string Autor { get; set; }
        //fotografia 
        public string ISBN { get; set; }
        public string ISSN { get; set; }
        public string DOI { get; set; }
        public DateTime Fecha_de_publicacion { get; set; }
        public string Editorial { get; set; }
        public string Formato { get; set; }
        public string Idioma { get; set; }
        public string Palabras_clave { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BINAES_Proyecto
{

    public class Evento
    {
        public int ID { get; set; }
        
        public int id_area { get; set; }
        public string Titulo_Evento { get; set; }
        
        public string Portada { get; set; }
        
        public Bitmap Imagen_del_evento { get; set; }
        
        public int Cantidad_de_asistentes { get; set; }
        
        public DateTime Inicio_del_vento { get; set; }
        
        public DateTime Finalizacion_del_evento { get; set; }
        
        public string Area { get; set; }
        
        public string Objetivos { get; set; }
        
        
        

    }
}
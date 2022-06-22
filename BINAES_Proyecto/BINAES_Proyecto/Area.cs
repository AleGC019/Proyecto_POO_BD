using System;

namespace BINAES_Proyecto
{
    public class Area
    {
        public int areaID { get; set; }
        
        public string areaNombre { get; set; }

        public DateTime areaHorario_inicio { get; set; }

        public DateTime areaHorario_cierre { get; set; }

        public string areaDescripcion { get; set; }

        public int piso { get; set; }

        public int responsableID { get; set; }
    }
}
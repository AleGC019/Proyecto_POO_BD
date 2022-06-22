namespace BINAES_Proyecto
{
    public class Objetivos
    {
        public int id_evento_objetivos { get; set; }

        public string objetivo { get; set; }
        
        public Objetivos()
        {
            id_evento_objetivos = 0;
            objetivo = "";
        }

        public Objetivos(int idEventoObjetivos, string objetivo)
        {
            id_evento_objetivos = idEventoObjetivos;
            this.objetivo = objetivo;
        }
    }
    
}
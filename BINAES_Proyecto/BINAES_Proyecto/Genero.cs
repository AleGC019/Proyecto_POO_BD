namespace BINAES_Proyecto
{
    public class Genero
    {
        public int generoID { get; set; }

        public string generoNombre { get; set; }
        
        public Genero()
        {
            generoID = 0;
            generoNombre = "";
        }

        public Genero(int generoId, string generoNombre)
        {
            generoID = generoId;
            this.generoNombre = generoNombre;
        }
    }
    
    
}
namespace BINAES_Proyecto
{
    public class Autor
    {
        public int ID { get; set; }
        public string nombreAutor { get; set; }
        public int ejemplarID { get; set; }

        public Autor()
        {
            nombreAutor = "";
            ejemplarID = 0;
        }

        public Autor(string nombreAutor, int ejemplarId)
        {
            
            this.nombreAutor = nombreAutor;
            ejemplarID = ejemplarId;
        }
    }
    
}
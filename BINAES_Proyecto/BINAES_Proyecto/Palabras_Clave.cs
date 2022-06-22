namespace BINAES_Proyecto
{
    public class Palabras_Clave
    {
        public string palabra { get; set; }
        public int ejemplarID_Palabra { get; set; }

        public Palabras_Clave()
        {
            palabra = "";
            ejemplarID_Palabra = 0;
        }

        public Palabras_Clave(string palabra, int ejemplarIdPalabra)
        {
            this.palabra = palabra;
            ejemplarID_Palabra = ejemplarIdPalabra;
        }
    }
}
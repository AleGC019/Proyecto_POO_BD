using System.Data.SqlClient;
using BINAES_Proyecto.Properties;

namespace BINAES_Proyecto
{
    public class EditorialDAO
    {
        //Crear un editorial nueva que no este en la bd 
        
        public static void InsertarNuevaEditorial(Editorial edit)
        {
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string nonquery =
                    "INSERT INTO EDITORIAL (editorial) VALUES (@nuevaeditorial)";

                SqlCommand command = new SqlCommand(nonquery, connection);
                command.Parameters.AddWithValue("@nuevaeditorial", edit.nombreEditorial);
                

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

        }
    }
}
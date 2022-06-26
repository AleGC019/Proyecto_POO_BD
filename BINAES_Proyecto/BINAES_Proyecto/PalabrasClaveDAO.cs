using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BINAES_Proyecto.Properties;

namespace BINAES_Proyecto
{
    public class PalabrasClaveDAO
    {
        public static void ActualizarPalabraClave(Palabras_Clave pc)
        {
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string noquery =
                    "UPDATE PALABRAS_CLAVE SET palabra = @nuevapalabra, id_ejemplar = @nuevoid_ejemplar WHERE id = @id";

                SqlCommand command = new SqlCommand(noquery, connection);
                command.Parameters.AddWithValue("@nuevapalabra", pc.palabra);
                command.Parameters.AddWithValue("@nuevoid_ejemplar", pc.ejemplarID_Palabra);
                command.Parameters.AddWithValue("@id", pc.ID);


                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }

        public static List<Palabras_Clave> PalabrasClave()
        {
            string cadena = Resources.Cadena_Conexion;
            List<Palabras_Clave> lista = new List<Palabras_Clave>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT id, palabra, id_ejemplar " +
                    "FROM PALABRAS_CLAVE ";

                    SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Palabras_Clave pc = new Palabras_Clave();
                        pc.ID = Convert.ToInt32(reader["id"]);
                        pc.palabra = reader["palabra"].ToString();
                        pc.ejemplarID_Palabra = Convert.ToInt32(reader["id_ejemplar"]);

                        lista.Add(pc);

                    }
                }

                connection.Close();
            }

            return lista;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BINAES_Proyecto.Properties;

namespace BINAES_Proyecto
{
    public class AutorDAO
    {
        public static void ActualizarAutor(Autor autor)
        {
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string noquery =
                    "UPDATE AUTOR SET autor = @nuevoautor, id_ejemplar = @nuevoid_ejemplar WHERE id = @id";

                SqlCommand command = new SqlCommand(noquery, connection);
                command.Parameters.AddWithValue("@nuevoautor", autor.nombreAutor);
                command.Parameters.AddWithValue("@nuevoid_ejemplar", autor.ejemplarID);
                command.Parameters.AddWithValue("@id", autor.ID);


                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }

        public static List<Autor> ListaAutor()
        {
            string cadena = Resources.Cadena_Conexion;
            List<Autor> lista = new List<Autor>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT id, autor, id_ejemplar " +
                    "FROM AUTOR ";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Autor autor = new Autor();
                        autor.ID = Convert.ToInt32(reader["id"]);
                        autor.nombreAutor = reader["autor"].ToString();
                        autor.ejemplarID = Convert.ToInt32(reader["id_ejemplar"]);

                        lista.Add(autor);

                    }
                }

                connection.Close();
            }

            return lista;
        }
    }
}
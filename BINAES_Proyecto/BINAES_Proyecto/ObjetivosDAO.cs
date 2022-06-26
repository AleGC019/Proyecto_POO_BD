using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BINAES_Proyecto.Properties;

namespace BINAES_Proyecto
{
    public class ObjetivosDAO
    {
        public static void ActualizarObjetivos(Objetivos obj)
        {
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string noquery =
                    "UPDATE OBJETIVOS SET objetivos = @nuevoobjetivos, id_evento = @nuevoid_evento WHERE id = @id";

                SqlCommand command = new SqlCommand(noquery, connection);
                command.Parameters.AddWithValue("@nuevoobjetivos", obj.objetivo);
                command.Parameters.AddWithValue("@nuevoid_evento", obj.id_evento_objetivos);
                command.Parameters.AddWithValue("@id", obj.ID);


                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }

        public static List<Objetivos> ListaObjetivos()
        {
            string cadena = Resources.Cadena_Conexion;
            List<Objetivos> lista = new List<Objetivos>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT id_evento, objetivos, id FROM OBJETIVOS ";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Objetivos obj = new Objetivos();
                        
                        obj.objetivo = reader["objetivos"].ToString();
                        obj.id_evento_objetivos = Convert.ToInt32(reader["id_evento"]);
                        obj.ID = Convert.ToInt32(reader["id"]);

                        lista.Add(obj);

                    }
                }

                connection.Close();
            }

            return lista;
        }
    }
}
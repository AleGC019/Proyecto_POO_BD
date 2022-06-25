

namespace BINAES_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using global::BINAES_Proyecto.Properties;

    namespace BINAES_Proyecto
    {
        public class ColeccionDAO
        {
            public static List<Coleccion> MostrarColeccion()
            {
                string cadena = Resources.Cadena_Conexion;
                List<Coleccion> lista = new List<Coleccion>();

                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query =
                        "SELECT COLECCION.id, COLECCION.nombre, GENERO.genero, TIPO.tipo, AREA.nombre AS 'anombre' FROM COLECCION INNER JOIN GENERO ON GENERO.id = COLECCION.id_genero INNER JOIN TIPO ON TIPO.id = COLECCION.id_tipo INNER JOIN AREA ON AREA.id = COLECCION.id_area ";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Coleccion eje = new Coleccion();
                            eje.Coleccion_ID = Convert.ToInt32(reader["id"].ToString());
                            eje.Coleccion_Nombre = reader["nombre"].ToString();
                            eje.Genero_Nombre = reader["genero"].ToString();
                            eje.Tipo_Nombre = reader["tipo"].ToString();
                            eje.Area_Nombre = reader["anombre"].ToString();
                            lista.Add(eje);
                        }
                    }
                    connection.Close();
                }
                return lista;
            }
        }


        
        
    }
}

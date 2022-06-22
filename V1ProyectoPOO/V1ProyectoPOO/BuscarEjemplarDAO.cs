using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V1ProyectoPOO.Properties;
using System.Data.SqlClient;

namespace V1ProyectoPOO
{
    public class BuscarEjemplarDAO
    {
        public static List<Ejemplar> FiltrarPorTitulo(string titulo)
        {
            string cadena = Resources.Cadena_Conexion;
            List<Ejemplar> lista = new List<Ejemplar>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                

                string query =
                    "SELECT EJEMPLAR.id, EJEMPLAR.nombre, EJEMPLAR.imagen_portada, COLECCION.nombre AS 'cnombre', AUTOR.autor AS 'aautor', EJEMPLAR.isbn, issn, doi, fecha_publicada, EDITORIAL.editorial AS 'eeditorial', FORMATO.formato AS 'fformato', IDIOMA.idioma AS 'iidioma', STRING_AGG(PALABRAS_CLAVE.palabra, ', ') 'Palabras_clave' " +
                    "fROM EJEMPLAR INNER JOIN EDITORIAL ON EJEMPLAR.id_editorial = EDITORIAL.id " +
                    "INNER JOIN IDIOMA  ON IDIOMA.id = EJEMPLAR.id_idioma " +
                    " INNER JOIN FORMATO ON FORMATO.id = EJEMPLAR.id_formato " +
                    "INNER JOIN AUTOR ON AUTOR.id_ejemplar = EJEMPLAR.id " +
                    "INNER JOIN COLECCION ON COLECCION.id = EJEMPLAR.id_coleccion " +
                    "INNER JOIN PALABRAS_CLAVE ON PALABRAS_CLAVE.id_ejemplar = EJEMPLAR.id " +
                    "WHERE EJEMPLAR.nombre like @titulobuscar GROUP BY EJEMPLAR.id, EJEMPLAR.nombre, EJEMPLAR.imagen_portada, COLECCION.nombre, AUTOR.autor, EJEMPLAR.isbn, issn, doi, fecha_publicada, EDITORIAL.editorial, FORMATO.formato, IDIOMA.idioma ";
                
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@titulobuscar", titulo + '%');

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Ejemplar eje = new Ejemplar();
                        eje.imagen = reader["imagen_portada"].ToString();
                        eje.id = Convert.ToInt32(reader["id"].ToString());
                        eje.nombre = reader["nombre"].ToString();
                        eje.fecha = Convert.ToDateTime(reader["fecha_publicada"].ToString());
                        eje.idioma = reader["iidioma"].ToString();
                        eje.editorial = reader["eeditorial"].ToString();
                        eje.formato = (reader["fformato"].ToString());
                        eje.autor = reader["aautor"].ToString();
                        eje.isbn = reader["isbn"].ToString();
                        eje.issn = reader["issn"].ToString();
                        eje.doi = reader["doi"].ToString();
                        eje.coleccion = reader["cnombre"].ToString();
                        eje.PC = reader["Palabras_clave"].ToString();
                        lista.Add(eje);
                    }
                }
                connection.Close();
            }
            return lista;
        }

	
	//-------------------------------------------------------------------------------------------

	
	public static List<Ejemplar> FiltrarPorTituloParcial(string titulo)
        {
            string cadena = Resources.Cadena_Conexion;
            List<Ejemplar> lista = new List<Ejemplar>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT EJEMPLAR.id, EJEMPLAR.nombre, EJEMPLAR.imagen_portada, COLECCION.nombre AS 'cnombre', AUTOR.autor AS 'aautor', EJEMPLAR.isbn, issn, doi, fecha_publicada, EDITORIAL.editorial AS 'eeditorial', FORMATO.formato AS 'fformato', IDIOMA.idioma AS 'iidioma', STRING_AGG(PALABRAS_CLAVE.palabra, ', ') 'Palabras_clave' " +
                    "fROM EJEMPLAR INNER JOIN EDITORIAL ON EJEMPLAR.id_editorial = EDITORIAL.id " +
                    "INNER JOIN IDIOMA  ON IDIOMA.id = EJEMPLAR.id_idioma " +
                    " INNER JOIN FORMATO ON FORMATO.id = EJEMPLAR.id_formato " +
                    "INNER JOIN AUTOR ON AUTOR.id_ejemplar = EJEMPLAR.id " +
                    "INNER JOIN COLECCION ON COLECCION.id = EJEMPLAR.id_coleccion " +
                    "INNER JOIN PALABRAS_CLAVE ON PALABRAS_CLAVE.id_ejemplar = EJEMPLAR.id " +
                    "WHERE EJEMPLAR.nombre like @%titulobuscar% GROUP BY EJEMPLAR.id, EJEMPLAR.nombre, EJEMPLAR.imagen_portada, COLECCION.nombre, AUTOR.autor, EJEMPLAR.isbn, issn, doi, fecha_publicada, EDITORIAL.editorial, FORMATO.formato, IDIOMA.idioma ";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@titulobuscar",  titulo + '%');

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Ejemplar eje = new Ejemplar();
                        eje.imagen = reader["imagen_portada"].ToString();
                        eje.id = Convert.ToInt32(reader["id"].ToString());
                        eje.nombre = reader["nombre"].ToString();
                        eje.fecha = Convert.ToDateTime(reader["fecha_publicada"].ToString());
                        eje.idioma = reader["iidioma"].ToString();
                        eje.editorial = reader["eeditorial"].ToString();
                        eje.formato = (reader["fformato"].ToString());
                        eje.autor = reader["aautor"].ToString();
                        eje.isbn = reader["isbn"].ToString();
                        eje.issn = reader["issn"].ToString();
                        eje.doi = reader["doi"].ToString();
                        eje.coleccion = reader["cnombre"].ToString();
                        eje.PC = reader["Palabras_clave"].ToString();
                        lista.Add(eje);
                    }
                }
                connection.Close();
            }
            return lista;
        }

	
	//-------------------------------------------------------------------------------------------

	
	public static List<Ejemplar> FiltrarPorAutor(string autor)
        {
            string cadena = Resources.Cadena_Conexion;
            List<Ejemplar> lista = new List<Ejemplar>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT EJEMPLAR.id, EJEMPLAR.nombre, EJEMPLAR.imagen_portada, COLECCION.nombre AS 'cnombre', AUTOR.autor AS 'aautor', EJEMPLAR.isbn, issn, doi, fecha_publicada, EDITORIAL.editorial AS 'eeditorial', FORMATO.formato AS 'fformato', IDIOMA.idioma AS 'iidioma', STRING_AGG(PALABRAS_CLAVE.palabra, ', ') 'Palabras_clave' " +
                    "fROM EJEMPLAR INNER JOIN EDITORIAL ON EJEMPLAR.id_editorial = EDITORIAL.id " +
                    "INNER JOIN IDIOMA  ON IDIOMA.id = EJEMPLAR.id_idioma " +
                    " INNER JOIN FORMATO ON FORMATO.id = EJEMPLAR.id_formato " +
                    "INNER JOIN AUTOR ON AUTOR.id_ejemplar = EJEMPLAR.id " +
                    "INNER JOIN COLECCION ON COLECCION.id = EJEMPLAR.id_coleccion " +
                    "INNER JOIN PALABRAS_CLAVE ON PALABRAS_CLAVE.id_ejemplar = EJEMPLAR.id " +
                    "WHERE AUTOR.autor like @autorbuscado GROUP BY EJEMPLAR.id, EJEMPLAR.nombre, EJEMPLAR.imagen_portada, COLECCION.nombre, AUTOR.autor, EJEMPLAR.isbn, issn, doi, fecha_publicada, EDITORIAL.editorial, FORMATO.formato, IDIOMA.idioma ";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@autorbuscado", autor + '%');

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Ejemplar eje = new Ejemplar();
                        eje.imagen = reader["imagen_portada"].ToString();
                        eje.id = Convert.ToInt32(reader["id"].ToString());
                        eje.nombre = reader["nombre"].ToString();
                        eje.fecha = Convert.ToDateTime(reader["fecha_publicada"].ToString());
                        eje.idioma = reader["iidioma"].ToString();
                        eje.editorial = reader["eeditorial"].ToString();
                        eje.formato = (reader["fformato"].ToString());
                        eje.autor = reader["aautor"].ToString();
                        eje.isbn = reader["isbn"].ToString();
                        eje.issn = reader["issn"].ToString();
                        eje.doi = reader["doi"].ToString();
                        eje.coleccion = reader["cnombre"].ToString();
                        eje.PC = reader["Palabras_clave"].ToString();
                        lista.Add(eje);
                    }
                }
                connection.Close();
            }
            return lista;
        }
	

	//-------------------------------------------------------------------------------------------


	public static List<Ejemplar> FiltrarPorFormato(string formato)
        {
            string cadena = Resources.Cadena_Conexion;
            List<Ejemplar> lista = new List<Ejemplar>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT EJEMPLAR.id, EJEMPLAR.nombre, EJEMPLAR.imagen_portada, COLECCION.nombre AS 'cnombre', AUTOR.autor AS 'aautor', EJEMPLAR.isbn, issn, doi, fecha_publicada, EDITORIAL.editorial AS 'eeditorial', FORMATO.formato AS 'fformato', IDIOMA.idioma AS 'iidioma', STRING_AGG(PALABRAS_CLAVE.palabra, ', ') 'Palabras_clave' " +
                    "fROM EJEMPLAR INNER JOIN EDITORIAL ON EJEMPLAR.id_editorial = EDITORIAL.id " +
                    "INNER JOIN IDIOMA  ON IDIOMA.id = EJEMPLAR.id_idioma " +
                    " INNER JOIN FORMATO ON FORMATO.id = EJEMPLAR.id_formato " +
                    "INNER JOIN AUTOR ON AUTOR.id_ejemplar = EJEMPLAR.id " +
                    "INNER JOIN COLECCION ON COLECCION.id = EJEMPLAR.id_coleccion " +
                    "INNER JOIN PALABRAS_CLAVE ON PALABRAS_CLAVE.id_ejemplar = EJEMPLAR.id " +
                    "WHERE FORMATO.formato like @formatobuscado GROUP BY EJEMPLAR.id, EJEMPLAR.nombre, EJEMPLAR.imagen_portada, COLECCION.nombre, AUTOR.autor, EJEMPLAR.isbn, issn, doi, fecha_publicada, EDITORIAL.editorial, FORMATO.formato, IDIOMA.idioma ";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@formatobuscado", formato + '%');

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Ejemplar eje = new Ejemplar();
                        eje.imagen = reader["imagen_portada"].ToString();
                        eje.id = Convert.ToInt32(reader["id"].ToString());
                        eje.nombre = reader["nombre"].ToString();
                        eje.fecha = Convert.ToDateTime(reader["fecha_publicada"].ToString());
                        eje.idioma = reader["iidioma"].ToString();
                        eje.editorial = reader["eeditorial"].ToString();
                        eje.formato = (reader["fformato"].ToString());
                        eje.autor = reader["aautor"].ToString();
                        eje.isbn = reader["isbn"].ToString();
                        eje.issn = reader["issn"].ToString();
                        eje.doi = reader["doi"].ToString();
                        eje.coleccion = reader["cnombre"].ToString();
                        eje.PC = reader["Palabras_clave"].ToString();
                        lista.Add(eje);
                    }
                }
                connection.Close();
            }
            return lista;
        }

	//-------------------------------------------------------------------------------------------

	
	public static List<Ejemplar> FiltrarPorPalabraClave(string palabra)
        {
            string cadena = Resources.Cadena_Conexion;
            List<Ejemplar> lista = new List<Ejemplar>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT EJEMPLAR.id, EJEMPLAR.nombre, EJEMPLAR.imagen_portada, COLECCION.nombre AS 'cnombre', AUTOR.autor AS 'aautor', EJEMPLAR.isbn, issn, doi, fecha_publicada, EDITORIAL.editorial AS 'eeditorial', FORMATO.formato AS 'fformato', IDIOMA.idioma AS 'iidioma', STRING_AGG(PALABRAS_CLAVE.palabra, ', ') 'Palabras_clave' " +
                    "fROM EJEMPLAR INNER JOIN EDITORIAL ON EJEMPLAR.id_editorial = EDITORIAL.id " +
                    "INNER JOIN IDIOMA  ON IDIOMA.id = EJEMPLAR.id_idioma " +
                    " INNER JOIN FORMATO ON FORMATO.id = EJEMPLAR.id_formato " +
                    "INNER JOIN AUTOR ON AUTOR.id_ejemplar = EJEMPLAR.id " +
                    "INNER JOIN COLECCION ON COLECCION.id = EJEMPLAR.id_coleccion " +
                    "INNER JOIN PALABRAS_CLAVE ON PALABRAS_CLAVE.id_ejemplar = EJEMPLAR.id " +
                    "WHERE PALABRAS_CLAVE.palabra like @palabrabuscado GROUP BY EJEMPLAR.id, EJEMPLAR.nombre, EJEMPLAR.imagen_portada, COLECCION.nombre, AUTOR.autor, EJEMPLAR.isbn, issn, doi, fecha_publicada, EDITORIAL.editorial, FORMATO.formato, IDIOMA.idioma ";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@palabrabuscado", palabra + '%');

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Ejemplar eje = new Ejemplar();
                        eje.imagen = reader["imagen_portada"].ToString();
                        eje.id = Convert.ToInt32(reader["id"].ToString());
                        eje.nombre = reader["nombre"].ToString();
                        eje.fecha = Convert.ToDateTime(reader["fecha_publicada"].ToString());
                        eje.idioma = reader["iidioma"].ToString();
                        eje.editorial = reader["eeditorial"].ToString();
                        eje.formato = (reader["fformato"].ToString());
                        eje.autor = reader["aautor"].ToString();
                        eje.isbn = reader["isbn"].ToString();
                        eje.issn = reader["issn"].ToString();
                        eje.doi = reader["doi"].ToString();
                        eje.coleccion = reader["cnombre"].ToString();
                        eje.PC = reader["Palabras_clave"].ToString();
                        lista.Add(eje);
                    }
                }
                connection.Close();
            }
            return lista; 
        }

        public static List<Ejemplar> General()
        {
            string cadena = Resources.Cadena_Conexion;
            List<Ejemplar> lista = new List<Ejemplar>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT EJEMPLAR.id, EJEMPLAR.nombre, EJEMPLAR.imagen_portada, COLECCION.nombre AS 'cnombre', AUTOR.autor AS 'aautor', EJEMPLAR.isbn, issn, doi, fecha_publicada, EDITORIAL.editorial AS 'eeditorial', FORMATO.formato AS 'fformato', IDIOMA.idioma AS 'iidioma', STRING_AGG(PALABRAS_CLAVE.palabra, ', ') 'Palabras_clave' " +
                    "fROM EJEMPLAR INNER JOIN EDITORIAL ON EJEMPLAR.id_editorial = EDITORIAL.id " +
                    "INNER JOIN IDIOMA  ON IDIOMA.id = EJEMPLAR.id_idioma " +
                    " INNER JOIN FORMATO ON FORMATO.id = EJEMPLAR.id_formato " +
                    "INNER JOIN AUTOR ON AUTOR.id_ejemplar = EJEMPLAR.id " +
                    "INNER JOIN COLECCION ON COLECCION.id = EJEMPLAR.id_coleccion " +
                    "INNER JOIN PALABRAS_CLAVE ON PALABRAS_CLAVE.id_ejemplar = EJEMPLAR.id " +
                    "GROUP BY EJEMPLAR.id, EJEMPLAR.nombre, EJEMPLAR.imagen_portada, COLECCION.nombre, AUTOR.autor, EJEMPLAR.isbn, issn, doi, fecha_publicada, EDITORIAL.editorial, FORMATO.formato, IDIOMA.idioma ";


                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Ejemplar eje = new Ejemplar();
                        eje.imagen = reader["imagen_portada"].ToString();
                        eje.id = Convert.ToInt32(reader["id"].ToString());
                        eje.nombre = reader["nombre"].ToString();
                        eje.fecha = Convert.ToDateTime(reader["fecha_publicada"].ToString());
                        eje.idioma = reader["iidioma"].ToString();
                        eje.editorial = reader["eeditorial"].ToString();
                        eje.formato = (reader["fformato"].ToString());
                        eje.autor = reader["aautor"].ToString();
                        eje.isbn = reader["isbn"].ToString();
                        eje.issn = reader["issn"].ToString();
                        eje.doi = reader["doi"].ToString();
                        eje.coleccion = reader["cnombre"].ToString();
                        eje.PC = reader["Palabras_clave"].ToString();
                        lista.Add(eje);
                    }
                }
                connection.Close();
            }
            return lista;
        }


    }


}



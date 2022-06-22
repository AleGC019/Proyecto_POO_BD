using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BINAES_Proyecto.Properties;
using System.Data.SqlClient;

namespace BINAES_Proyecto
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
                        eje.Portada = reader["imagen_portada"].ToString();
                        eje.ID = Convert.ToInt32(reader["id"].ToString());
                        eje.Nombre_Ejemplar = reader["nombre"].ToString();
                        eje.Fecha_de_publicacion = Convert.ToDateTime(reader["fecha_publicada"].ToString());
                        eje.Idioma = reader["iidioma"].ToString();
                        eje.Editorial = reader["eeditorial"].ToString();
                        eje.Formato = reader["fformato"].ToString();
                        eje.Autor = reader["aautor"].ToString();
                        eje.ISBN = reader["isbn"].ToString();
                        eje.ISSN = reader["issn"].ToString();
                        eje.DOI = reader["doi"].ToString();
                        eje.Coleccion = reader["cnombre"].ToString();
                        eje.Palabras_clave = reader["Palabras_clave"].ToString();
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
                    "WHERE EJEMPLAR.nombre like %@titulobuscar% GROUP BY EJEMPLAR.id, EJEMPLAR.nombre, EJEMPLAR.imagen_portada, COLECCION.nombre, AUTOR.autor, EJEMPLAR.isbn, issn, doi, fecha_publicada, EDITORIAL.editorial, FORMATO.formato, IDIOMA.idioma ";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@titulobuscar",  titulo);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Ejemplar eje = new Ejemplar();
                        eje.Portada = reader["imagen_portada"].ToString();
                        eje.ID = Convert.ToInt32(reader["id"].ToString());
                        eje.Nombre_Ejemplar = reader["nombre"].ToString();
                        eje.Fecha_de_publicacion = Convert.ToDateTime(reader["fecha_publicada"].ToString());
                        eje.Idioma = reader["iidioma"].ToString();
                        eje.Editorial = reader["eeditorial"].ToString();
                        eje.Formato= reader["fformato"].ToString();
                        eje.Autor = reader["aautor"].ToString();
                        eje.ISBN = reader["isbn"].ToString();
                        eje.ISSN = reader["issn"].ToString();
                        eje.DOI = reader["doi"].ToString();
                        eje.Coleccion = reader["cnombre"].ToString();
                        eje.Palabras_clave = reader["Palabras_clave"].ToString();
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
                        eje.Portada = reader["imagen_portada"].ToString();
                        eje.ID = Convert.ToInt32(reader["id"].ToString());
                        eje.Nombre_Ejemplar = reader["nombre"].ToString();
                        eje.Fecha_de_publicacion = Convert.ToDateTime(reader["fecha_publicada"].ToString());
                        eje.Idioma = reader["iidioma"].ToString();
                        eje.Editorial = reader["eeditorial"].ToString();
                        eje.Formato = reader["fformato"].ToString();
                        eje.Autor = reader["aautor"].ToString();
                        eje.ISBN = reader["isbn"].ToString();
                        eje.ISSN = reader["issn"].ToString();
                        eje.DOI = reader["doi"].ToString();
                        eje.Coleccion = reader["cnombre"].ToString();
                        eje.Palabras_clave = reader["Palabras_clave"].ToString();
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
                        eje.Portada = reader["imagen_portada"].ToString();
                        eje.ID = Convert.ToInt32(reader["id"].ToString());
                        eje.Nombre_Ejemplar = reader["nombre"].ToString();
                        eje.Fecha_de_publicacion = Convert.ToDateTime(reader["fecha_publicada"].ToString());
                        eje.Idioma = reader["iidioma"].ToString();
                        eje.Editorial = reader["eeditorial"].ToString();
                        eje.Formato = reader["fformato"].ToString();
                        eje.Autor = reader["aautor"].ToString();
                        eje.ISBN = reader["isbn"].ToString();
                        eje.ISSN = reader["issn"].ToString();
                        eje.DOI = reader["doi"].ToString();
                        eje.Coleccion = reader["cnombre"].ToString();
                        eje.Palabras_clave = reader["Palabras_clave"].ToString();
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
                        eje.Portada = reader["imagen_portada"].ToString();
                        eje.ID = Convert.ToInt32(reader["id"].ToString());
                        eje.Nombre_Ejemplar = reader["nombre"].ToString();
                        eje.Fecha_de_publicacion = Convert.ToDateTime(reader["fecha_publicada"].ToString());
                        eje.Idioma = reader["iidioma"].ToString();
                        eje.Editorial = reader["eeditorial"].ToString();
                        eje.Formato = reader["fformato"].ToString();
                        eje.Autor = reader["aautor"].ToString();
                        eje.ISBN = reader["isbn"].ToString();
                        eje.ISSN = reader["issn"].ToString();
                        eje.DOI = reader["doi"].ToString();
                        eje.Coleccion = reader["cnombre"].ToString();
                        eje.Palabras_clave = reader["Palabras_clave"].ToString();
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
                        eje.Portada = reader["imagen_portada"].ToString();
                        eje.ID = Convert.ToInt32(reader["id"].ToString());
                        eje.Nombre_Ejemplar = reader["nombre"].ToString();
                        eje.Fecha_de_publicacion = Convert.ToDateTime(reader["fecha_publicada"].ToString());
                        eje.Idioma = reader["iidioma"].ToString();
                        eje.Editorial = reader["eeditorial"].ToString();
                        eje.Formato = reader["fformato"].ToString();
                        eje.Autor = reader["aautor"].ToString();
                        eje.ISBN = reader["isbn"].ToString();
                        eje.ISSN = reader["issn"].ToString();
                        eje.DOI = reader["doi"].ToString();
                        eje.Coleccion = reader["cnombre"].ToString();
                        eje.Palabras_clave = reader["Palabras_clave"].ToString();
                        lista.Add(eje);
                    }
                }
                connection.Close();
            }
            return lista;
        }


    }


}


using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BINAES_Proyecto.Properties;

namespace BINAES_Proyecto
{
    internal static class PrestamoDAO
    {
        public static bool TitleSearch(string titulo)
        {
            bool existence = false;

            Ejemplar eje = null;

            string cadena = Resources.Cadena_Conexion;
            
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT * FROM [EJEMPLAR] WHERE nombre = @searchname;";
                                 
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@searchname", titulo);

                connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            eje = new Ejemplar();
                            eje.ID = Convert.ToInt32(reader["id"].ToString());
                            eje.Nombre_Ejemplar = reader["nombre"].ToString();
                        }
                    }

                connection.Close();

                if(eje != null)
                {
                    existence = true;
                }
            }
            return existence;
        }

        public static Ejemplar TituloCompleto(string titulo)
        {
            string cadena = Resources.Cadena_Conexion;

            Ejemplar eje = new Ejemplar();

            eje.ID = -1;

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
                    "WHERE EJEMPLAR.nombre = @titulobuscar GROUP BY EJEMPLAR.id, EJEMPLAR.nombre, EJEMPLAR.imagen_portada, COLECCION.nombre, AUTOR.autor, EJEMPLAR.isbn, issn, doi, fecha_publicada, EDITORIAL.editorial, FORMATO.formato, IDIOMA.idioma ";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@titulobuscar", titulo);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
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
                    }
                }
                connection.Close();
            }
            return eje;
        }

        public static Ejemplar TituloParcial(string titulo)
        {
            string cadena = Resources.Cadena_Conexion;

            Ejemplar eje = new Ejemplar();

            List<Ejemplar> quantityVerifier = new List<Ejemplar>();

            eje.ID = -1;

            try
            {
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
                    command.Parameters.AddWithValue("@titulobuscar", '%' + titulo + '%');

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
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

                            Ejemplar tempItem = new Ejemplar();

                            tempItem.Portada = reader["imagen_portada"].ToString();
                            tempItem.ID = Convert.ToInt32(reader["id"].ToString());
                            tempItem.Nombre_Ejemplar = reader["nombre"].ToString();
                            tempItem.Fecha_de_publicacion = Convert.ToDateTime(reader["fecha_publicada"].ToString());
                            tempItem.Idioma = reader["iidioma"].ToString();
                            tempItem.Editorial = reader["eeditorial"].ToString();
                            tempItem.Formato = reader["fformato"].ToString();
                            tempItem.Autor = reader["aautor"].ToString();
                            tempItem.ISBN = reader["isbn"].ToString();
                            tempItem.ISSN = reader["issn"].ToString();
                            tempItem.DOI = reader["doi"].ToString();
                            tempItem.Coleccion = reader["cnombre"].ToString();
                            tempItem.Palabras_clave = reader["Palabras_clave"].ToString();

                            quantityVerifier.Add(tempItem);

                        }
                    }
                    connection.Close();

                    if(quantityVerifier.Count > 1)
                    {
                        MessageBox.Show("Existe mas de un titulo con su titulo parcial.");

                        eje.ID = -1;
                    }

                }
            }
            catch(Exception E)
            {
                MessageBox.Show("Error en busqueda");
            }

            MessageBox.Show(quantityVerifier.Count.ToString());

            return eje;
        }
    }
}

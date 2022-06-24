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

        public static Ejemplar TituloCompleto(string titulo_buscado)
        {
            string cadena_conexion = Resources.Cadena_Conexion;

            Ejemplar eje = new Ejemplar();

            List<Ejemplar> lista = new List<Ejemplar>();

            eje.ID = -1;

            try
            {
                using (SqlConnection conexion_actual = new SqlConnection(cadena_conexion))
                {
                    string consulta;

                    consulta = "SELECT EJEMPLAR.id, EJEMPLAR.nombre, EJEMPLAR.imagen_portada, COLECCION.nombre AS 'nombre_coleccion', " +
                                "AUTOR.autor, EJEMPLAR.isbn, EJEMPLAR.issn, EJEMPLAR.doi, EJEMPLAR.fecha_publicada, EDITORIAL.editorial, " +
                                "FORMATO.formato, IDIOMA.idioma, STRING_AGG(PALABRAS_CLAVE.palabra, ', ') 'Palabras_clave' FROM EJEMPLAR " +
                                "INNER JOIN EDITORIAL ON EJEMPLAR.id_editorial = EDITORIAL.id INNER JOIN IDIOMA  ON IDIOMA.id = EJEMPLAR.id_idioma " +
                                "INNER JOIN FORMATO ON FORMATO.id = EJEMPLAR.id_formato INNER JOIN AUTOR ON AUTOR.id_ejemplar = EJEMPLAR.id " +
                                "INNER JOIN COLECCION ON COLECCION.id = EJEMPLAR.id_coleccion INNER JOIN PALABRAS_CLAVE ON PALABRAS_CLAVE.id_ejemplar = EJEMPLAR.id " +
                                "WHERE EJEMPLAR.nombre = @titulo GROUP BY    EJEMPLAR.id, EJEMPLAR.nombre, EJEMPLAR.imagen_portada, COLECCION.nombre, AUTOR.autor, " +
                                "EJEMPLAR.isbn, issn, doi, fecha_publicada, EDITORIAL.editorial, FORMATO.formato, IDIOMA.idioma;";

                    SqlCommand comando = new SqlCommand(consulta, conexion_actual);

                    comando.Parameters.AddWithValue("@titulo", titulo_buscado);

                    conexion_actual.Open();

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            eje.ID = Convert.ToInt32(lector["id"].ToString());

                            eje.Nombre_Ejemplar = lector["nombre"].ToString();

                            eje.Portada = lector["imagen_portada"].ToString();

                            eje.Coleccion = lector["nombre_coleccion"].ToString();

                            eje.Autor = lector["autor"].ToString();

                            eje.ISBN = lector["isbn"].ToString();

                            eje.ISSN = lector["issn"].ToString();

                            eje.DOI = lector["doi"].ToString();

                            eje.Fecha_de_publicacion = Convert.ToDateTime(lector["fecha_publicada"].ToString());

                            eje.Editorial = lector["editorial"].ToString();

                            eje.Formato = lector["formato"].ToString();

                            eje.Idioma = lector["idioma"].ToString();

                            eje.Palabras_clave = lector["Palabras_clave"].ToString();

                            lista.Add(eje);
                        }
                    }

                    conexion_actual.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Error en busqueda.", "Conflicto en conexion con la base de datos.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }

            if (lista.Count > 1)
            {
                MessageBox.Show("Existe más de un título con su palabra parcial." + Environment.NewLine + "Sea un poco más específico o intente con título completo, " +
                                "por favor.", "Coincidencia de resultados.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                eje.ID = -1;

                return eje;
            }
            else
            {
                return eje;
            }
        }

        public static Ejemplar TituloParcial(string titulo_buscado)
        {
            string cadena_conexion = Resources.Cadena_Conexion;

            Ejemplar eje = new Ejemplar();

            List<Ejemplar> lista = new List<Ejemplar>();

            eje.ID = -1;

            try
            {
                using (SqlConnection conexion_actual = new SqlConnection(cadena_conexion))
                {
                    string consulta;

                    consulta =  "SELECT EJEMPLAR.id, EJEMPLAR.nombre, EJEMPLAR.imagen_portada, COLECCION.nombre AS 'nombre_coleccion', " +
                                "AUTOR.autor, EJEMPLAR.isbn, EJEMPLAR.issn, EJEMPLAR.doi, EJEMPLAR.fecha_publicada, EDITORIAL.editorial, " +
                                "FORMATO.formato, IDIOMA.idioma, STRING_AGG(PALABRAS_CLAVE.palabra, ', ') 'Palabras_clave' FROM EJEMPLAR " +
                                "INNER JOIN EDITORIAL ON EJEMPLAR.id_editorial = EDITORIAL.id INNER JOIN IDIOMA  ON IDIOMA.id = EJEMPLAR.id_idioma " +
                                "INNER JOIN FORMATO ON FORMATO.id = EJEMPLAR.id_formato INNER JOIN AUTOR ON AUTOR.id_ejemplar = EJEMPLAR.id " +
                                "INNER JOIN COLECCION ON COLECCION.id = EJEMPLAR.id_coleccion INNER JOIN PALABRAS_CLAVE ON PALABRAS_CLAVE.id_ejemplar = EJEMPLAR.id " +
                                "WHERE EJEMPLAR.nombre LIKE @titulo GROUP BY    EJEMPLAR.id, EJEMPLAR.nombre, EJEMPLAR.imagen_portada, COLECCION.nombre, AUTOR.autor, " +
                                "EJEMPLAR.isbn, issn, doi, fecha_publicada, EDITORIAL.editorial, FORMATO.formato, IDIOMA.idioma;";

                    SqlCommand comando = new SqlCommand(consulta, conexion_actual);

                    comando.Parameters.AddWithValue("@titulo", '%' + titulo_buscado + '%');

                    conexion_actual.Open();

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                eje.ID = Convert.ToInt32(lector["id"].ToString());

                                eje.Nombre_Ejemplar = lector["nombre"].ToString();

                                eje.Portada = lector["imagen_portada"].ToString();
                                
                                eje.Coleccion = lector["nombre_coleccion"].ToString();
                                
                                eje.Autor = lector["autor"].ToString();

                                eje.ISBN = lector["isbn"].ToString();

                                eje.ISSN = lector["issn"].ToString();

                                eje.DOI = lector["doi"].ToString();

                                eje.Fecha_de_publicacion = Convert.ToDateTime(lector["fecha_publicada"].ToString());

                                eje.Editorial = lector["editorial"].ToString();

                                eje.Formato = lector["formato"].ToString();

                                eje.Idioma = lector["idioma"].ToString();

                                eje.Palabras_clave = lector["Palabras_clave"].ToString();

                                lista.Add(eje);
                            }
                        }
                    
                    conexion_actual.Close();
                }
            }
            catch(Exception E)
            {
                MessageBox.Show("Error en busqueda.", "Conflicto en conexion con la base de datos.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }

            if (lista.Count > 1)
            {
                MessageBox.Show("Existe más de un título con su palabra parcial." + Environment.NewLine + "Sea un poco más específico o intente con título completo, " +
                                "por favor.", "Coincidencia de resultados.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                eje.ID = -1;

                return eje;
            }
            else
            {
                return eje;
            }
        }

        public static void VerifyPrestamo (Ejemplar v_eje)
        {
            bool prestado = true;

            string fecha_hoy = DateTime.Now.ToString();

            PrestamoEjemplar comparacion_base = new PrestamoEjemplar();

            comparacion_base.id = -1;

            string cadena_conexion = Resources.Cadena_Conexion;

            try
            {
                using (SqlConnection conexion_actual = new SqlConnection(cadena_conexion))
                {
                    string consulta;

                    consulta =  "SELECT PRESTAMO.id, EJEMPLAR.nombre, PRESTAMO.prestamo_devolucion_hora_fecha, " +
                                "PRESTAMO.prestamo_entrega_hora_fecha FROM EJEMPLAR INNER JOIN PRESTAMO ON PRESTAMO.id_ejemplar = EJEMPLAR.id " +
                                "WHERE EJEMPLAR.nombre = @titulo;";

                    SqlCommand comando = new SqlCommand(consulta, conexion_actual);

                    comando.Parameters.AddWithValue("@titulo", v_eje.Nombre_Ejemplar);

                    conexion_actual.Open();

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                comparacion_base.id = Convert.ToInt32(lector["id"].ToString());

                                comparacion_base.nombre = lector["nombre"].ToString();

                                //comparacion_base.entrega = lector.GetDateTime(["prestamo_entrega_hora_fecha"]);

                                int colIndex = lector.GetOrdinal("prestamo_entrega_hora_fecha");
                                
                                if (!lector.IsDBNull(colIndex))
                                    comparacion_base.entrega = lector.GetDateTime(colIndex);
                            //comparacion_base.devolucion = lector["prestamo_devolucion_hora_fecha"].ToString();
                        }
                        }

                    conexion_actual.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Error en busqueda.", "Conflicto en conexion con la base de datos.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }

            MessageBox.Show(v_eje.Fecha_de_publicacion.ToString());
            MessageBox.Show(fecha_hoy);

            /*if (comparacion_base.id != -1)
            {
                MessageBox.Show(comparacion_base.entrega);
                MessageBox.Show(fecha_hoy);
            }*/

        }
    }
}

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
        /*public static bool TitleSearch(string titulo)
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
        }*/

        public static Ejemplar TituloCompleto(string titulo_buscado)
        {
            Ejemplar eje = new Ejemplar();

            eje.ID = -1;

            string cadena_conexion = Resources.Cadena_Conexion;

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
                            }
                        }

                    conexion_actual.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Error en busqueda dentro de la base de datos.", "Conflicto en la busqueda.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }

            return eje;
        }

        public static Ejemplar TituloParcial(string titulo_buscado)
        {
            Ejemplar eje = new Ejemplar();

            List<Ejemplar> lista = new List<Ejemplar>();

            eje.ID = -1;

            string cadena_conexion = Resources.Cadena_Conexion;

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

                                /*Ejemplar TEST = new Ejemplar();

                                TEST.ID = Convert.ToInt32(lector["id"].ToString());

                                TEST.Nombre_Ejemplar = lector["nombre"].ToString();

                                TEST.Portada = lector["imagen_portada"].ToString();

                                TEST.Coleccion = lector["nombre_coleccion"].ToString();

                                TEST.Autor = lector["autor"].ToString();

                                TEST.ISBN = lector["isbn"].ToString();

                                TEST.ISSN = lector["issn"].ToString();

                                TEST.DOI = lector["doi"].ToString();

                                TEST.Fecha_de_publicacion = Convert.ToDateTime(lector["fecha_publicada"].ToString());

                                TEST.Editorial = lector["editorial"].ToString();

                                TEST.Formato = lector["formato"].ToString();

                                TEST.Idioma = lector["idioma"].ToString();

                                TEST.Palabras_clave = lector["Palabras_clave"].ToString();*/

                                lista.Add(eje);
                            }
                        }
                    
                    conexion_actual.Close();
                }
            }
            catch(Exception E)
            {
                MessageBox.Show("Error en busqueda dentro de la base de datos.", "Conflicto en la busqueda.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }

            if (lista.Count > 1)
            {
                eje.ID = 0;

                return eje;
            }
            else
            {
                return eje;
            }
        }

        public static bool VerifyPrestamo (Ejemplar v_eje, DateTime hoy)
        {
            bool prestado = true;

            PrestamoEjemplar comparacion_base = new PrestamoEjemplar();

            comparacion_base.id_prestamo = 0;

            string cadena_conexion = Resources.Cadena_Conexion;

            try
            {
                using (SqlConnection conexion_actual = new SqlConnection(cadena_conexion))
                {
                    string consulta;

                    consulta = "SELECT id, prestamo_entrega_hora_fecha, prestamo_devolucion_hora_fecha " +
                        "FROM PRESTAMO WHERE CAST(PRESTAMO.prestamo_entrega_hora_fecha AS DATE) <= @hoy " +
                        "AND CAST(PRESTAMO.prestamo_devolucion_hora_fecha AS DATE) >= @hoy " +
                        "AND PRESTAMO.id_ejemplar = @ideje;";

                    SqlCommand comando = new SqlCommand(consulta, conexion_actual);

                    comando.Parameters.AddWithValue("@hoy", hoy);
                    comando.Parameters.AddWithValue("@ideje", v_eje.ID.ToString());

                    conexion_actual.Open();

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                comparacion_base.id_prestamo = (Int32)lector[0];
                            }
                        }

                    conexion_actual.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Error en busqueda.", "Conflicto en conexion con la base de datos.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                prestado = false;
            }

            if(comparacion_base.id_prestamo != 0)
            {
                prestado = true;
            }
            else
            {
                prestado = false;
            }

            return prestado;
        }

        public static bool NewPrestamo(int usuID, int ejeID, DateTime entrega, DateTime devolucion)
        {
            bool prestado;

            string cadena_conexion = Resources.Cadena_Conexion;

            try
            {
                using (SqlConnection conexion_actual = new SqlConnection(cadena_conexion))
                {
                    string consulta;

                    consulta = "INSERT INTO PRESTAMO (prestamo_entrega_hora_fecha, prestamo_devolucion_hora_fecha, id_usuario, id_ejemplar) " +
                                "VALUES(@entrega, @devolucion, @idusu, @ideje);";

                    SqlCommand comando = new SqlCommand(consulta, conexion_actual);

                    comando.Parameters.AddWithValue("@entrega", entrega);

                    comando.Parameters.AddWithValue("@devolucion", devolucion);

                    comando.Parameters.AddWithValue("@idusu", usuID);

                    comando.Parameters.AddWithValue("@ideje", ejeID);

                    conexion_actual.Open();

                    comando.ExecuteNonQuery();

                    conexion_actual.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Error en ingreso.", "Conflicto en conexion con la base de datos.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                prestado = false;

                return prestado;
            }

            prestado = true;

            return prestado;
        }
        
        
        public static List<PrestamoEjemplar> MostrarTodo()
        {
            string cadena = Resources.Cadena_Conexion;
            List<PrestamoEjemplar> lista = new List<PrestamoEjemplar>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT PRESTAMO.id, EJEMPLAR.nombre AS 'ejemplar', USUARIO.nombre AS 'usuario', PRESTAMO.prestamo_entrega_hora_fecha, PRESTAMO.prestamo_devolucion_hora_fecha FROM PRESTAMO INNER JOIN EJEMPLAR ON EJEMPLAR.id = PRESTAMO.id_ejemplar INNER JOIN IDIOMA  ON IDIOMA.id = EJEMPLAR.id_idioma " +
                    "INNER JOIN USUARIO ON USUARIO.id = PRESTAMO.id_usuario";

                    SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PrestamoEjemplar eje = new PrestamoEjemplar();
                        
                        eje.id_prestamo = Convert.ToInt32(reader["id"].ToString());
                        
                        eje.Ejemplar = reader["ejemplar"].ToString();
                        
                        eje.Nombre =  reader["usuario"].ToString();
                        
                        eje.Entrega = Convert.ToDateTime(reader["prestamo_entrega_hora_fecha"].ToString());
                        
                        eje.Devolucion = Convert.ToDateTime(reader["prestamo_devolucion_hora_fecha"].ToString());
                        
                        lista.Add(eje);
                    }
                }
                connection.Close();
            }
            return lista;
        }
        
        public static List<PrestamoEjemplar> MostrarTodoReservaciones()
        {
            string cadena = Resources.Cadena_Conexion;
            List<PrestamoEjemplar> lista = new List<PrestamoEjemplar>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT RESERVACION.id, EJEMPLAR.nombre AS 'ejemplarr', USUARIO.nombre AS 'usuario', RESERVACION.reservacion_hora_fecha,RESERVACION.prestamo_hora_fecha, RESERVACION.devolucion_hora_fecha FROM RESERVACION INNER JOIN EJEMPLAR ON EJEMPLAR.id = RESERVACION.id_ejemplar INNER JOIN USUARIO ON USUARIO.id = RESERVACION.id_usuario";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PrestamoEjemplar eje = new PrestamoEjemplar();
                        
                        eje.id_prestamo = Convert.ToInt32(reader["id"].ToString());
                        
                        eje.Ejemplar = reader["ejemplarr"].ToString();
                        
                        eje.Nombre =  reader["usuario"].ToString();
                        
                        eje.Entrega = Convert.ToDateTime(reader["prestamo_hora_fecha"].ToString());
                        
                        eje.Devolucion = Convert.ToDateTime(reader["devolucion_hora_fecha"].ToString());
                        
                        eje.FechaReserva = Convert.ToDateTime(reader["reservacion_hora_fecha"].ToString());
                        
                        lista.Add(eje);
                    }
                }
                connection.Close();
            }
            return lista;
        }
    }
}

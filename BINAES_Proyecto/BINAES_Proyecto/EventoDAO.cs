using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BINAES_Proyecto.Properties;
using System.Data.SqlClient;
using System.Drawing;


namespace BINAES_Proyecto
{
    public class EventoDAO
    {
        public static List<Evento> NombreEvento(string nombre)
        {
            string cadena = Resources.Cadena_Conexion;
            List<Evento> lista = new List<Evento>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT EVENTO.id, EVENTO.titulo, EVENTO.imagen, EVENTO.asistentes_cantidad, EVENTO.incio_evento_hora_fecha AS 'IE', EVENTO.finalizacion_evento_hora_fecha AS 'FE', AREA.nombre, STRING_AGG(OBJETIVOS.objetivos, ' ') 'Objetivos' " +
                    "FROM EVENTO INNER JOIN AREA ON AREA.id = EVENTO.id_area " +
                    "INNER JOIN OBJETIVOS ON OBJETIVOS.id_evento = EVENTO.id WHERE EVENTO.titulo like @titulobuscar GROUP BY EVENTO.id, EVENTO.titulo, EVENTO.imagen, EVENTO.asistentes_cantidad, EVENTO.incio_evento_hora_fecha, EVENTO.finalizacion_evento_hora_fecha, AREA.nombre";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@titulobuscar",  nombre);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Evento eje = new Evento();
                        eje.Titulo_Evento = reader["titulo"].ToString();
                        eje.Portada = reader["imagen"].ToString();
                        //eje.Imagen_del_evento = EventoDAO.obtenerimagen(eje.Portada);
                        eje.ID = Convert.ToInt32(reader["id"].ToString());
                        eje.Cantidad_de_asistentes = Convert.ToInt32(reader["asistentes_cantidad"].ToString());
                        eje.Area = reader["nombre"].ToString();
                        eje.Inicio_del_vento = Convert.ToDateTime(reader["IE"].ToString());
                        eje.Finalizacion_del_evento = Convert.ToDateTime(reader["FE"].ToString());
                        eje.Objetivos = reader["Objetivos"].ToString();
                        lista.Add(eje);
                        
                    }
                }
                connection.Close();
            }
            return lista;
        }
        
        
        public static List<Evento> Eventos()
        {
            string cadena = Resources.Cadena_Conexion;
            List<Evento> lista = new List<Evento>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT EVENTO.id, EVENTO.titulo, EVENTO.imagen, EVENTO.asistentes_cantidad, EVENTO.incio_evento_hora_fecha AS 'IE', EVENTO.finalizacion_evento_hora_fecha AS 'FE', AREA.nombre, STRING_AGG(OBJETIVOS.objetivos, ' ') 'Objetivos' " +
                    "FROM EVENTO INNER JOIN AREA ON AREA.id = EVENTO.id_area " +
                    "INNER JOIN OBJETIVOS ON OBJETIVOS.id_evento = EVENTO.id GROUP BY EVENTO.id, EVENTO.titulo, EVENTO.imagen, EVENTO.asistentes_cantidad, EVENTO.incio_evento_hora_fecha, EVENTO.finalizacion_evento_hora_fecha, AREA.nombre";


                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Evento eje = new Evento();
                        eje.Titulo_Evento = reader["titulo"].ToString();
                        eje.Portada = reader["imagen"].ToString();
                        //eje.Imagen_del_evento = obtenerimagen(eje.Portada);
                        eje.ID = Convert.ToInt32(reader["id"].ToString());
                        eje.Cantidad_de_asistentes = Convert.ToInt32(reader["asistentes_cantidad"].ToString());
                        eje.Area = reader["nombre"].ToString();
                        eje.Inicio_del_vento = Convert.ToDateTime(reader["IE"].ToString());
                        eje.Finalizacion_del_evento = Convert.ToDateTime(reader["FE"].ToString());
                        eje.Objetivos = reader["Objetivos"].ToString();
                        lista.Add(eje);
                        
                    }
                }
                connection.Close();
            }
            return lista;
        }
        
        public static void IngresarEvento(Evento eve)
        {
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string nonquery =
                    "INSERT INTO EVENTO (titulo, imagen, asistentes_cantidad, incio_evento_hora_fecha, finalizacion_evento_hora_fecha, id_area)" +
                    "VALUES (@nuevotitulo, @nuevaimagen, @nuevaasistentes_cantidad, @nuevoinicio_evento_hora_fecha, @nuevofinalizacoin_evento_hora_fecha, @nuevaid_area)";

                SqlCommand command = new SqlCommand(nonquery, connection);
                command.Parameters.AddWithValue("@nuevotitulo", eve.Titulo_Evento);
                command.Parameters.AddWithValue("@nuevaimagen", eve.Portada);
                command.Parameters.AddWithValue("@nuevaasistentes_cantidad", eve.Cantidad_de_asistentes);
                command.Parameters.AddWithValue("@nuevoinicio_evento_hora_fecha", eve.Inicio_del_vento);
                command.Parameters.AddWithValue("@nuevofinalizacoin_evento_hora_fecha", eve.Finalizacion_del_evento);
                command.Parameters.AddWithValue("@nuevaid_area", eve.id_area);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            
            Objetivos Objetivos = new Objetivos(EventoDAO.nuevoidEvento(), eve.Objetivos);
            InsertarNuevoObjetivo(Objetivos);

        }
        
        public static void InsertarNuevoObjetivo(Objetivos obe)
        {
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string nonquery =
                    "INSERT INTO  OBJETIVOS(objetivos, id_evento)" +
                    "VALUES (@objetivo, @id_evento_objetivos)";

                SqlCommand command = new SqlCommand(nonquery, connection);
                command.Parameters.AddWithValue("@objetivo", obe.objetivo);
                command.Parameters.AddWithValue("@id_evento_objetivos", obe.id_evento_objetivos);
                
                
                    
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

        }
        
        
        public static int nuevoidEvento()
        {
            string cadena = Resources.Cadena_Conexion;
            int nuevoidEvento = 0;

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT id FROM EVENTO WHERE EVENTO.id = IDENT_CURRENT('EVENTO')";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Evento eve = new Evento();
                        eve.ID = Convert.ToInt32(reader["id"].ToString());

                        nuevoidEvento = eve.ID;
                        
                        
                    }
                }

                connection.Close();
                
            }

            return nuevoidEvento;
        }
        
        public static List<Area> CargarDatosArea()
        {
            string cadena = Resources.Cadena_Conexion;
            List<Area> lista = new List<Area>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT id, nombre FROM AREA";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Area area = new Area();
                        area.areaID = Convert.ToInt32(reader["id"].ToString());
                        area.areaNombre = reader["nombre"].ToString();

                        lista.Add(area);
                    }
                }

                connection.Close();
            }

            return lista;
        }
        
        
        
        
        
        
        public static Bitmap obtenerimagen(string ruta)
        {
            Bitmap imagen = new Bitmap(ruta);
            return imagen; 
        }
    }
}
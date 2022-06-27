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
                        eje.Imagen_del_evento = (Bitmap)Image.FromFile(eje.Portada);
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
                        eje.Imagen_del_evento = (Bitmap)Image.FromFile(eje.Portada);
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
            
            //Objetivos Objetivos = new Objetivos(EventoDAO.nuevoidEvento(), eve.Objetivos);
            //InsertarNuevoObjetivo(Objetivos);

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
        
        //-----------FUNCION PARA VERIFICAR EL RANGO DE FECHAS RESERVADAS DE LOS EVENTOS------------------------
        public static bool VerificarDisponibilidadFechas(Evento eve)
        {
            bool verify = false, alguna = false, todos1 = true, todos2 = true;
            int contareasdif = 0, contsameareamay = 0, contsameareamin = 0, loops = 0;
            DateTime Inicio_del_vento = eve.Inicio_del_vento;
            DateTime Finalizacion_del_evento = eve.Finalizacion_del_evento;
            int idarea = eve.id_area;
            List<Evento> lista = ObtenerFechas();

            try
            {
                /*foreach (var evento in lista)
                {
                    if ((DateTime.Compare(fechini, evento.fechFin) > 0 
                         && DateTime.Compare(fechfin, evento.fechInicio) < 0) && idarea == evento.idareaeve)
                    {
                        alguna = true;
                        todos1 = false;
                        todos2 = false;
                    }
                    else
                    {
                        if ((DateTime.Compare(fechini, evento.fechFin) < 0 
                             && DateTime.Compare(fechfin, evento.fechInicio) < 0) && idarea == evento.idareaeve)//todos1
                        {
                            //todos2 = false;
                            contsameareamin++;
                        }
                        else
                        {
                            if ((DateTime.Compare(fechini, evento.fechFin) > 0 
                                 && DateTime.Compare(fechfin, evento.fechInicio) > 0) && idarea == evento.idareaeve)//todos2
                            {
                                contsameareamay++;
                                //todos1 = false;
                            }
                            else
                            {
                                if (idarea != evento.idareaeve)
                                {
                                    contareasdif++;
                                }
                                else
                                {
                                    todos1 = false;
                                    todos2 = false;
                                    alguna = false;   
                                }
                            }
                        }
                    }
                    //contador
                    loops++;//calcula la cantidad de datos/veces q se ha recorrido el bucle
                }

                loops = loops - contareasdif;//veces recorrido - veces q se comparo con un area diferente
                if (loops == contsameareamin)
                {
                    todos2 = false;
                }else if (loops == contsameareamay)
                {
                    todos1 = false;
                }else if (loops == 0)
                {
                    verify = true;
                }*/
                //----PRUEBA DE VERIFICACION DE FECHAS CON BUCLE FOR-----------------
                
                int lis = lista.Count;//contar elementos de la lista
                
                for(int i = 1; i <= lis; i++)
                {
                    if ((DateTime.Compare(Inicio_del_vento, lista[i].Finalizacion_del_evento/*evento.fechFin*/) > 0 
                         && DateTime.Compare(Finalizacion_del_evento, lista[i+1].Inicio_del_vento) < 0) && idarea == lista[i].id_area)
                    {
                        alguna = true;
                        todos1 = false;
                        todos2 = false;
                    }
                    else
                    {
                        if ((DateTime.Compare(Inicio_del_vento , lista[i].Finalizacion_del_evento) < 0 
                             && DateTime.Compare(Finalizacion_del_evento, lista[i].Inicio_del_vento) < 0) && idarea == lista[i].id_area)//todos1
                        {
                            //todos2 = false;
                            contsameareamin++;
                        }
                        else
                        {
                            if ((DateTime.Compare(Inicio_del_vento , lista[i].Finalizacion_del_evento) > 0 
                                 && DateTime.Compare(Finalizacion_del_evento, lista[i].Inicio_del_vento) > 0) && idarea == lista[i].id_area)//todos2
                            {
                                contsameareamay++;
                                //todos1 = false;
                            }
                            else
                            {
                                if (idarea != lista[i].id_area)
                                {
                                    contareasdif++;
                                }
                                else
                                {
                                    todos1 = false;
                                    todos2 = false;
                                    alguna = false;   
                                }
                            }
                        }
                    }
                    //contador
                    loops++;//calcula la cantidad de datos/veces q se ha recorrido el bucle
                }

                loops = loops - contareasdif;//veces recorrido - veces q se comparo con un area diferente
                if (loops == contsameareamin)
                {
                    todos2 = false;
                }else if (loops == contsameareamay)
                {
                    todos1 = false;
                }else if (loops == 0)
                {
                    verify = true;
                }
                //---TERMINA PRUEBAAA-------------------------------
            }
            catch (Exception e)
            {
                verify = false;
            }

            if (alguna)
            {
                verify = true;
            }else if (todos1 || todos2)
            {
                verify = true;
            }
            
            return verify;
        }
        
        //-----FUNCION PARA OBTENER LAS FECHAS RESERVADA DE EVENTOS EN ORDEN ASCENDENTE-------------------------
        public static List<Evento> ObtenerFechas(){
                string cadena = Resources.Cadena_Conexion;
                List<Evento> lista = new List<Evento>();
                
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query =
                        "SELECT incio_evento_hora_fecha, finalizacion_evento_hora_fecha, id_area FROM EVENTO, AREA where EVENTO.id_area = AREA.id ORDER BY incio_evento_hora_fecha asc";
                    SqlCommand command = new SqlCommand(query, connection);
                
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()){
                        while (reader.Read())
                        {
                            Evento eve = new Evento();
                            eve.id_area = Convert.ToInt32(reader["id_area"].ToString());
                            eve.Inicio_del_vento = Convert.ToDateTime(reader["incio_evento_hora_fecha"].ToString());
                            eve.Finalizacion_del_evento = Convert.ToDateTime(reader["finalizacion_evento_hora_fecha"].ToString());
                            lista.Add(eve);
                        }   
                    }
                    connection.Close();
                }
                
                return lista;
        }
        
        public static void ActualizarEvento(Evento even)
        {
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string noquery =
                    "UPDATE EVENTO SET titulo = @nuevotitulo, imagen = @nuevaimagen, asistentes_cantidad = @nuevaasistentes_cantidad, incio_evento_hora_fecha = @nuevoincio_evento_hora_fecha, finalizacion_evento_hora_fecha = @nuevafinalizacion_evento_hora_fecha, id_area = @nuevoid_area FROM EVENTO WHERE id = @id";

                SqlCommand command = new SqlCommand(noquery, connection);
                command.Parameters.AddWithValue("@nuevotitulo", even.Titulo_Evento);
                command.Parameters.AddWithValue("@nuevaimagen", even.Imagen_evento);
                command.Parameters.AddWithValue("@nuevaasistentes_cantidad", even.Cantidad_de_asistentes);
                command.Parameters.AddWithValue("@nuevoincio_evento_hora_fecha", even.Inicio_del_vento);
                command.Parameters.AddWithValue("@nuevafinalizacion_evento_hora_fecha", even.Finalizacion_del_evento);
                command.Parameters.AddWithValue("@nuevoid_area", even.id_area);
                command.Parameters.AddWithValue("@id", even.ID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }
        
        public static bool EliminarEvento(int id)
        {
            bool exito = true;

            try
            {
                string cadena = Resources.Cadena_Conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "DELETE FROM EVENTO WHERE id = @id";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

            }
            catch (Exception)
            {
                exito = false;
            }

            return exito;
        }
        

        public static void ingresarNuevoObjetivo(Objetivos obj)
        {
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string nonquery =
                    "INSERT INTO OBJETIVOS (objetivos, id_evento" +
                    "VALUES (@objetivos, @id_evento)";

                SqlCommand command = new SqlCommand(nonquery, connection);
                command.Parameters.AddWithValue("@objetivos", obj.objetivo);
                command.Parameters.AddWithValue("@id_evento", obj.id_evento_objetivos);





                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
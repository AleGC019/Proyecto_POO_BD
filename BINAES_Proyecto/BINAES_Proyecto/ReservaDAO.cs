using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BINAES_Proyecto.Properties;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BINAES_Proyecto
{
    internal static class ReservaDAO
    {
        public static DateTime DisponibleAPartir(Ejemplar eje, DateTime hoy)
        {
            string cadena_conexion = Resources.Cadena_Conexion;

            DateTime finaliza = Convert.ToDateTime("2022-01-01");
            int ID = 0;

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

                        comando.Parameters.AddWithValue("@ideje", eje.ID.ToString());
                        comando.Parameters.AddWithValue("@hoy", hoy.Date);

                    conexion_actual.Open();

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                //ID = Convert.ToInt32(lector[0]);
                                finaliza = (DateTime)lector["prestamo_devolucion_hora_fecha"];
                            }
                        }

                    conexion_actual.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Error en busqueda.", "Conflicto en conexion con la base de datos.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }

            

            if (VerifyReservaExistente(finaliza, eje))
            {
                

                do
                {
                    finaliza = finaliza.AddDays(14);

                } while (VerifyReservaExistente(finaliza, eje));
            }

            return finaliza;
        }
        
        public static bool VerifyReservaExistente(DateTime inicio, Ejemplar eje)
        {
            string cadena_conexion = Resources.Cadena_Conexion;

            DateTime comienzo = Convert.ToDateTime("2022-01-01");
            int id = 0;

            try
            {
                using (SqlConnection conexion_actual = new SqlConnection(cadena_conexion))
                {
                    string consulta;

                    consulta = "SELECT [RESERVACION].id, [EJEMPLAR].nombre, [RESERVACION].prestamo_hora_fecha, " +
                        "[RESERVACION].devolucion_hora_fecha FROM [RESERVACION] INNER JOIN [EJEMPLAR] ON [EJEMPLAR].id = [RESERVACION].id_ejemplar " +
                        "WHERE CAST(RESERVACION.prestamo_hora_fecha AS DATE) = @fechareserva AND [EJEMPLAR].nombre = @nombreReserva;";

                    SqlCommand comando = new SqlCommand(consulta, conexion_actual);

                    comando.Parameters.AddWithValue("@fechareserva", inicio.Date);
                    comando.Parameters.AddWithValue("@nombreReserva", eje.Nombre_Ejemplar);

                    conexion_actual.Open();

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                id = Convert.ToInt32(lector[0]);
                                comienzo = (DateTime)lector[2];
                            }
                        }
                    conexion_actual.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Error en busqueda.", "Conflicto en conexion con la base de datos.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }

            bool reservado = true;

            if(id != 0)
            {
                reservado = true;
            }
            else if (id == 0)
            {
                reservado = false;
            }

            return reservado;
        }
        
        public static bool NewReserva(int usuID, int ejeID, DateTime reserva, DateTime entrega, DateTime devolucion)
        {
            bool prestado;

            string cadena_conexion = Resources.Cadena_Conexion;

            try
            {
                using (SqlConnection conexion_actual = new SqlConnection(cadena_conexion))
                {
                    string consulta;

                    consulta = "INSERT INTO RESERVACION(id_ejemplar, id_usuario, reservacion_hora_fecha, prestamo_hora_fecha, devolucion_hora_fecha) " +
                                "VALUES(@ideje, @idusu, @fechareserva, @fechaentrega, @fechadevo);";


                    SqlCommand comando = new SqlCommand(consulta, conexion_actual);

                        comando.Parameters.AddWithValue("@ideje", ejeID.ToString());

                        comando.Parameters.AddWithValue("@idusu", usuID.ToString());

                        comando.Parameters.AddWithValue("@fechareserva", reserva);

                        comando.Parameters.AddWithValue("@fechaentrega", entrega);

                        comando.Parameters.AddWithValue("@fechadevo", devolucion);

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

        public static bool VerifyReserva(string ejenombre, DateTime entrega, DateTime devolucion)
        {
            bool reservado = true;

            ReservaComparacion comparacion_base = new ReservaComparacion();

            string cadena_conexion = Resources.Cadena_Conexion;

            try
            {
                using (SqlConnection conexion_actual = new SqlConnection(cadena_conexion))
                {
                    string consulta;

                    consulta = "SELECT [RESERVACION].id, [EJEMPLAR].nombre, [RESERVACION].prestamo_hora_fecha, " +
                                "[RESERVACION].devolucion_hora_fecha FROM [RESERVACION] INNER JOIN [EJEMPLAR] ON [EJEMPLAR].id = [RESERVACION].id_ejemplar " +
                                "WHERE DAY(RESERVACION.prestamo_hora_fecha) = @dia " +
                                "AND MONTH(RESERVACION.prestamo_hora_fecha) = @mes " +
                                "AND YEAR(RESERVACION.prestamo_hora_fecha) = @anio " +
                                "AND [EJEMPLAR].nombre = @ejemplar;";

                    SqlCommand comando = new SqlCommand(consulta, conexion_actual);

                    comando.Parameters.AddWithValue("@dia", ejenombre);
                    comando.Parameters.AddWithValue("@titulo", ejenombre);
                        comando.Parameters.AddWithValue("@entrega", entrega.Date);

                    conexion_actual.Open();

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            //comparacion_base.id_libro = (Int32)lector["id_ejemplar"];

                            comparacion_base.entrega = (DateTime)lector["prestamo_hora_fecha"];

                            comparacion_base.devolucion = (DateTime)lector["devolucion_hora_fecha"];

                        }
                    }

                    conexion_actual.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Error en busqueda.", "Conflicto en conexion con la base de datos.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                reservado = true;

                return reservado;
            }

            if (entrega.Date >= comparacion_base.devolucion.Date)
            {
                if (entrega.Date == comparacion_base.devolucion.Date && entrega.Hour > comparacion_base.devolucion.Hour)
                {
                    reservado = false;
                }
                else
                {
                    reservado = true;
                }
            }
            else
            {
                reservado = true;
            }
            
            return reservado;
        }
    }
}

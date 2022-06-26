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
        public static Nullable<DateTime> DisponibleAPartir(Ejemplar eje)
        {
            string cadena_conexion = Resources.Cadena_Conexion;

            Nullable<DateTime> finaliza = null;

            try
            {
                using (SqlConnection conexion_actual = new SqlConnection(cadena_conexion))
                {
                    string consulta;

                    consulta = "SELECT prestamo_devolucion_hora_fecha FROM [PRESTAMO] WHERE id_ejemplar = @ideje;";

                    SqlCommand comando = new SqlCommand(consulta, conexion_actual);

                        comando.Parameters.AddWithValue("@ideje", eje.ID);

                    conexion_actual.Open();

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                finaliza = (DateTime)lector[0];
                            }
                        }

                    conexion_actual.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Error en busqueda.", "Conflicto en conexion con la base de datos.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }

            return finaliza;
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

                    consulta = "SELECT RESERVACION.[prestamo_hora_fecha], " +
                                "RESERVACION.[devolucion_hora_fecha] FROM [RESERVACION] INNER JOIN EJEMPLAR ON EJEMPLAR.id = RESERVACION.id_ejemplar WHERE EJEMPLAR.nombre = @titulo AND " +
                                "RESERVACION.[prestamo_hora_fecha] = @entrega;";

                    SqlCommand comando = new SqlCommand(consulta, conexion_actual);

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

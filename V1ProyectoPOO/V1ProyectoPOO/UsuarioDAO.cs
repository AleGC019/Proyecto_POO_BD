using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using V1ProyectoPOO.Properties;

namespace V1ProyectoPOO
{
    public class UsuarioDAO
    {
        public static void IngresarUsuario(Usuario user)
        {
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string nonquery =
                    "INSERT INTO USUARIO (id, nombre, ocupacion, direccion, correo, telefono, institucion)" +
                    "VALUES (@nuevoid, @nuevonombre, @nuevaocupacion, @nuevadireccion, @nuevocorreo, @nuevotelefono, @nuevainstitucion)";

                SqlCommand command = new SqlCommand(nonquery, connection);
                command.Parameters.AddWithValue("@nuevoid", user.UsuarioID);
                command.Parameters.AddWithValue("@nuevonombre", user.UsuarioNombre);
                command.Parameters.AddWithValue("@nuevaocupacion", user.UserOcupacion);
                command.Parameters.AddWithValue("@nuevadireccion", user.UserDireccion);
                command.Parameters.AddWithValue("@nuevocorreo", user.UserCorreo);
                command.Parameters.AddWithValue("@nuevotelefono", user.UserTelefono);
                command.Parameters.AddWithValue("@nuevainstitucion", user.UserInstitucion);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

        }

        public static List<Usuario> MostrarUsuarios()
        {
            //cadena de conexion 
            List<Usuario> ListaUsuarios = new List<Usuario>();
            string cadena = Resources.Cadena_Conexion;
            MessageBox.Show("Cadena: " + cadena);

            
            
            //conectar a la BD 
            using (SqlConnection connection = new SqlConnection(cadena))
                
            {
                string query = "SELECT id, nombre, ocupacion, direccion, correo, telefono, institucion FROM USUARIO";
                SqlCommand command = new SqlCommand(query, connection);
                MessageBox.Show("Queary configurada");
                
                //abrir la conexion, ejecutar la query 
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        Usuario user = new Usuario();
                        
                        user.UsuarioID = Convert.ToInt32(reader["id"].ToString());
                        user.UsuarioNombre = reader["nombre"].ToString();
                        user.UserOcupacion = reader["ocupacion"].ToString();
                        user.UserDireccion = reader["direccion"].ToString();
                        user.UserCorreo = reader["correo"].ToString();
                        user.UserTelefono = reader["telefono"].ToString();
                        user.UserInstitucion = reader["institucion"].ToString();
                        
                        ListaUsuarios.Add(user);
                        

                    }
                }
                connection.Close();
            }


            return ListaUsuarios;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using BINAES_Proyecto.Properties;

namespace BINAES_Proyecto
{
    public class UsuarioDAO
    {
        public static void IngresarUsuario(Usuario user)
        {
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string nonquery =
                    "INSERT INTO USUARIO (nombre, ocupacion, direccion, correo, telefono, institucion, fotografia)" +
                    "VALUES (@nuevonombre, @nuevaocupacion, @nuevadireccion, @nuevocorreo, @nuevotelefono, @nuevainstitucion, @nuevafotografia)";

                SqlCommand command = new SqlCommand(nonquery, connection);
                command.Parameters.AddWithValue("@nuevonombre", user.UsuarioNombre);
                command.Parameters.AddWithValue("@nuevaocupacion", user.UserOcupacion);
                command.Parameters.AddWithValue("@nuevadireccion", user.UserDireccion);
                command.Parameters.AddWithValue("@nuevocorreo", user.UserCorreo);
                command.Parameters.AddWithValue("@nuevotelefono", user.UserTelefono);
                command.Parameters.AddWithValue("@nuevainstitucion", user.UserInstitucion);
                command.Parameters.AddWithValue("@nuevafotografia", user.fotoUsuario);

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

        public static bool EliminarUsuario(int id)
        {
            bool exito = true;

            try
            {
                string cadena = Resources.Cadena_Conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "DELETE FROM USUARIO WHERE id = @id";
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

        public static void ActualizarUsuario(Usuario user)
        {
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string noquery =
                    "UPDATE USUARIO SET nombre = @nuevonombre, ocupacion = @nuevaocupacion, direccion = @nuevadireccion, correo = @nuevocorreo, telefono = @nuevotelefono, institucion = @nuevainstitucin  " +
                    "WHERE id = @id";

                SqlCommand command = new SqlCommand(noquery, connection);
                command.Parameters.AddWithValue("@nuevonombre", user.UsuarioNombre);
                command.Parameters.AddWithValue("@nuevaocupacion", user.UserOcupacion);
                command.Parameters.AddWithValue("@nuevadireccion", user.UserDireccion);
                command.Parameters.AddWithValue("@nuevocorreo", user.UserCorreo);
                command.Parameters.AddWithValue("@nuevotelefono", user.UserTelefono);
                command.Parameters.AddWithValue("@nuevainstitucin", user.UserInstitucion);
                command.Parameters.AddWithValue("@id", user.UsuarioID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }


        public static List<Usuario> AdminLoginInfo(string nombre, string contra)
        {
            string cadena = Resources.Cadena_Conexion;
            List<Usuario> Listausu = new List<Usuario>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT USUARIO.nombre AS 'usuario', USUARIO.contra AS 'contra'" +
                               "FROM USUARIO " +
                               "WHERE USUARIO.nombre like @nombre AND Usuario.contra like @contra";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@contra", contra);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Usuario usu = new Usuario();
                        usu.UsuarioNombre = reader["usuario"].ToString();
                        usu.Contra = reader["contra"].ToString();
                    }
                }
                connection.Close();
            }
            return Listausu;
        }

        public static Usuario AdminLoginInfo2(string nombre, string contra)
        {
            string cadena = Resources.Cadena_Conexion;
            
            Usuario UsuarioBuscado = new Usuario();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT nombre, contra, ocupacion FROM USUARIO " +
                                "WHERE nombre = @nombre AND contra = @contra;";

                SqlCommand command = new SqlCommand(query, connection);
                
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@contra", contra);

                connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UsuarioBuscado.UsuarioNombre = reader["nombre"].ToString();

                            UsuarioBuscado.Contra = reader["contra"].ToString();
                            
                            UsuarioBuscado.UserOcupacion = reader["ocupacion"].ToString();
                        }
                    }

                connection.Close();
            }

            if(UsuarioBuscado.UsuarioNombre == nombre)
            {
                return UsuarioBuscado;
            }
            else
            {
                UsuarioBuscado = null;

                return UsuarioBuscado;
            }
        }
    }
}


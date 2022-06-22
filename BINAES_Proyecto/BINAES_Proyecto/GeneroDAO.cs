using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BINAES_Proyecto.Properties;

namespace BINAES_Proyecto
{
    public class GeneroDAO
    {

        public static List<Genero> CargarDatos()
        {
            string cadena = Resources.Cadena_Conexion;
            List<Genero> lista = new List<Genero>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT id, genero FROM GENERO";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Genero gen = new Genero();
                        gen.generoID = Convert.ToInt32(reader["id"].ToString());
                        gen.generoNombre = reader["genero"].ToString();

                        lista.Add(gen);
                    }
                }

                connection.Close();
            }

            return lista;
        }


        public static List<Tipo> CargarDatosTipo()
        {
            string cadena = Resources.Cadena_Conexion;
            List<Tipo> listaTipo = new List<Tipo>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT id, tipo FROM TIPO";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Tipo tipo = new Tipo();
                        tipo.tipoID = Convert.ToInt32(reader["id"].ToString());
                        tipo.tipoNombre = reader["tipo"].ToString();

                        listaTipo.Add(tipo);
                    }
                }

                connection.Close();
            }

            return listaTipo;

        }

        public static List<Area> CargarDatosArea()
        {
            string cadena = Resources.Cadena_Conexion;
            List<Area> ListaArea = new List<Area>();

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

                        ListaArea.Add(area);
                    }
                }

                connection.Close();
            }

            return ListaArea;

        }

        public static void IngresarColeccion(Coleccion col )
        {
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string nonquery =
                    "INSERT INTO COLECCION (nombre, id_genero, id_tipo, id_area)" +
                    "VALUES (@nuevonombre, @id_genero, @id_tipo, @id_area)";

                SqlCommand command = new SqlCommand(nonquery, connection);
                command.Parameters.AddWithValue("@nuevonombre", col.coleccionNombre);
                command.Parameters.AddWithValue("@id_genero", col.generoID);
                command.Parameters.AddWithValue("@id_tipo", col.tipoID);
                command.Parameters.AddWithValue("@id_area", col.areaID);
                

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
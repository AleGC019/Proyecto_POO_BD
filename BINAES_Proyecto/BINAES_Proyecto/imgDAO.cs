using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BINAES_Proyecto.Properties;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace BINAES_Proyecto
{
    internal static class imgDAO
    {
        public static void CargaInicialIMG()
        {
            for (int i = 1; i <= 8; i++)
            {
                string ruta_local = AppDomain.CurrentDomain.BaseDirectory + @"RESOURCES\Image\";

                switch (i)
                {
                    case 1:
                        ruta_local += "CienAniosDeSoledad.jpg";

                        imgDAO.SQLAddEjemplarImagen(ruta_local, i.ToString());

                        break;

                    case 2:
                        ruta_local += "HarryPotterYLaPiedraFilosofal.jpg";

                        imgDAO.SQLAddEjemplarImagen(ruta_local, i.ToString());

                        break;

                    case 3:
                        ruta_local += "ElSenorDeLosAnillos.jpg";

                        imgDAO.SQLAddEjemplarImagen(ruta_local, i.ToString());

                        break;

                    case 4:
                        ruta_local += "CodigoDaVinci.jpg";

                        imgDAO.SQLAddEjemplarImagen(ruta_local, i.ToString());

                        break;

                    case 5:
                        ruta_local += "LoQueElVientoSeLlevo.jpg";

                        imgDAO.SQLAddEjemplarImagen(ruta_local, i.ToString());

                        break;

                    case 6:
                        ruta_local += "LosMiserables.jpg";

                        imgDAO.SQLAddEjemplarImagen(ruta_local, i.ToString());

                        break;

                    case 7:
                        ruta_local += "PedroParamo.jpg";

                        imgDAO.SQLAddEjemplarImagen(ruta_local, i.ToString());

                        break;

                    case 8:
                        ruta_local += "CrimenYCastigo.jpg";

                        imgDAO.SQLAddEjemplarImagen(ruta_local, i.ToString());

                        break;

                    default:
                        break;
                }

            }

            for (int i = 1; i <= 8; i++)
            {
                string ruta_local = AppDomain.CurrentDomain.BaseDirectory + @"RESOURCES\Image\EVENTOS\";

                switch (i)
                {
                    case 1:
                        ruta_local += "DiaMujer.png";

                        imgDAO.SQLImageEVENTO(ruta_local, i.ToString());

                        break;

                    case 2:
                        ruta_local += "AmoresIntensos.png";

                        imgDAO.SQLImageEVENTO(ruta_local, i.ToString());

                        break;

                    case 3:
                        ruta_local += "Clases.png";

                        imgDAO.SQLImageEVENTO(ruta_local, i.ToString());

                        break;

                    case 4:
                        ruta_local += "FeriaCiencia.png";

                        imgDAO.SQLImageEVENTO(ruta_local, i.ToString());

                        break;

                    case 5:
                        ruta_local += "DiaLibro.png";

                        imgDAO.SQLImageEVENTO(ruta_local, i.ToString());

                        break;

                    default:
                        break;
                }

            }

            for (int i = 1; i <= 10; i++)
            {
                string ruta_local = AppDomain.CurrentDomain.BaseDirectory + @"RESOURCES\Image\USUARIOS\";

                switch (i)
                {
                    case 1:
                        ruta_local += "FER.jpeg";

                        imgDAO.SQLImageUSUARIO(ruta_local, i.ToString());

                        break;

                    case 2:
                        ruta_local += "PAMELA.jpeg";

                        imgDAO.SQLImageUSUARIO(ruta_local, i.ToString());

                        break;

                    case 3:
                        ruta_local += "CLAUDIA.jpeg";

                        imgDAO.SQLImageUSUARIO(ruta_local, i.ToString());

                        break;

                    case 4:
                        ruta_local += "ALEJANDRO.jpeg";

                        imgDAO.SQLImageUSUARIO(ruta_local, i.ToString());

                        break;

                    case 5:
                        ruta_local += "DIEGO.jpeg";

                        imgDAO.SQLImageUSUARIO(ruta_local, i.ToString());

                        break;

                    case 6:
                        ruta_local += "FRANCISCO.jpeg";

                        imgDAO.SQLImageUSUARIO(ruta_local, i.ToString());

                        break;

                    case 7:
                        ruta_local += "VICTOR.jpeg";

                        imgDAO.SQLImageUSUARIO(ruta_local, i.ToString());

                        break;

                    case 8:
                        ruta_local += "LAZARO.jpeg";

                        imgDAO.SQLImageUSUARIO(ruta_local, i.ToString());

                        break;

                    case 9:
                        ruta_local += "JUANPABLO.jpeg";

                        imgDAO.SQLImageUSUARIO(ruta_local, i.ToString());

                        break;

                    case 10:
                        ruta_local += "MARIA.jpeg";

                        imgDAO.SQLImageUSUARIO(ruta_local, i.ToString());

                        break;

                    default:
                        break;

                }

            }

        }

        public static void SQLAddEjemplarImagen(string img, string id)
        {
            string cadena_conexion_string = Resources.Cadena_Conexion;

            try
            {
                using (SqlConnection e_conexion = new SqlConnection(cadena_conexion_string))
                {
                    string query = "UPDATE [EJEMPLAR] SET imagen_portada = @direccion_foto WHERE id = @identificador;";

                    SqlCommand command = new SqlCommand(query, e_conexion);

                    command.Parameters.AddWithValue("@direccion_foto", img);
                    command.Parameters.AddWithValue("@identificador", id);

                    e_conexion.Open();

                    command.ExecuteNonQuery();

                    e_conexion.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("error");
            }

            /*
            if (!File.Exists(local_route))
            {
                File.Copy(img, local_route);

                

                try
                {
                    using (SqlConnection e_conexion = new SqlConnection(cadena_conexion_string))
                    {
                        string query = "INSERT INTO [EJEMPLAR] (imagen_portada) VALUES (@direccion_foto) WHERE id = @identificador;";

                        SqlCommand command = new SqlCommand(query, e_conexion);

                        command.Parameters.AddWithValue("@direccion_foto", local_route);
                        command.Parameters.AddWithValue("@identificador", id);

                        e_conexion.Open();

                        command.ExecuteNonQuery();

                        e_conexion.Close();
                    }
                }
                catch (Exception E)
                {
                    exito = false;
                }

            }
            */
        }

        public static void SQLImageEVENTO(string img, string id)
        {
            string cadena_conexion_string = Resources.Cadena_Conexion;

            try
            {
                using (SqlConnection e_conexion = new SqlConnection(cadena_conexion_string))
                {
                    string query = "UPDATE [EVENTO] SET imagen = @direccion_foto WHERE id = @identificador;";

                    SqlCommand command = new SqlCommand(query, e_conexion);

                    command.Parameters.AddWithValue("@direccion_foto", img);
                    command.Parameters.AddWithValue("@identificador", id);

                    e_conexion.Open();

                    command.ExecuteNonQuery();

                    e_conexion.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("error");
            }
        }

        public static void SQLImageUSUARIO(string img, string id)
        {
            string cadena_conexion_string = Resources.Cadena_Conexion;

            try
            {
                using (SqlConnection e_conexion = new SqlConnection(cadena_conexion_string))
                {
                    string query = "UPDATE [USUARIO] SET fotografia = @direccion_foto WHERE id = @identificador;";

                    SqlCommand command = new SqlCommand(query, e_conexion);

                    command.Parameters.AddWithValue("@direccion_foto", img);
                    command.Parameters.AddWithValue("@identificador", id);

                    e_conexion.Open();

                    command.ExecuteNonQuery();

                    e_conexion.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("error");
            }
        }
    }
}

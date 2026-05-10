using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NexusApp.Clases
{
    internal class clsUsuarios : clsConexion
    {
      
        // Propiedades de la tabla Usuarios
        public int usuario_id { get; set; }
        public string email { get; set; }
        public string contrasena { get; set; }
        public string username { get; set; }
        public int tipoUsuario_id { get; set; }
        public DateTime fechaCreacion { get; set; }


        // Método para registrar un nuevo usuario
        public void InsertarUsuario()
        {
            try
            {
                GetConnection();

                string query = "INSERT INTO usuarios (email, contrasena, username, tipoUsuario_id) VALUES (@email, @contrasena, @username, @tipoUsuario_id)";
                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@tipoUsuario_id", tipoUsuario_id);

                    cmd.ExecuteNonQuery();
                    objConnection.Close();
                    MessageBox.Show("Usuario agregado con éxito!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error... " + ex.ToString());
            }

        }
        // Método para actualizar todos los datos del usuario a la vez
        public void ActualizarUsuario()
        {
            try
            {
                GetConnection();
                // Se actualizan email, contraseña y username en una sola consulta
                string query = "UPDATE usuarios SET email = @email, contrasena = @contrasena, username = @username WHERE usuario_id = @usuario_id";

                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@usuario_id", usuario_id);
                    cmd.Parameters.AddWithValue("@tipoUsuario_id", tipoUsuario_id);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error... " + ex.ToString());
            }
            finally
            {
                objConnection.Close();
            }
        }
        public DataTable ObtenerUsuarios()
        {
            DataTable dt = new DataTable();
            try
            {
                GetConnection();
                // Seleccionamos los campos. (Es buena práctica no mostrar la contraseña en las tablas, pero la incluyo por si la necesitas).
                string query = "SELECT usuario_id, email, contrasena, username, fechaCreacion FROM usuarios";
                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.ToString());
            }
            finally
            {
                objConnection.Close();
            }
            return dt;
        }


        // Método para eliminar un usuario
        public void EliminarUsuario()
        {
            try
            {
                GetConnection();
                string query = "DELETE FROM usuarios WHERE usuario_id = @usuario_id";
                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@usuario_id", usuario_id);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error... " + ex.ToString());
            }
            finally
            {
                objConnection.Close();
            }
        }
    }
}

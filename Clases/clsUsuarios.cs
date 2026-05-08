using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NexusApp.Clases
{
    internal class clsUsuarios : ClsConexion
    {
      
        // Propiedades de la tabla Usuarios
        public int usuario_id { get; set; }
        public string email { get; set; }
        public string contrasena { get; set; }
        public string username { get; set; }
        public DateTime fechaCreacion { get; set; }

        // Método para registrar un nuevo usuario
        public void InsertarUsuario()
        {
            try
            {
                GetConnection();

                string query = "INSERT INTO usuarios (email, contrasena, username) VALUES (@email, @contrasena, @username)";
                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);
                    cmd.Parameters.AddWithValue("@username", username);

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

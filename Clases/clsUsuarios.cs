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

        public void GetUsuario_ID()
        {
            try
            {
                GetConnection();

                string query = "SELECT usuario_id FROM usuarios WHERE username = @username";
                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario_id = Convert.ToInt32(reader["usuario_id"]);
                        }
                    }
                    objConnection.Close();
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
                string query = "SELECT usuario_id, email, contrasena, username, fechaCreacion,tipoUsuario_id FROM usuarios";
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

        //public int Login(string email, string contraseña)
        //{
        //    //try
        //    //{
        //    //    GetConnection();
        //    //    string query = "SELECT usuario_id, contrasena FROM usuarios WHERE email = @email";
        //    //    using (SqlCommand cmd = new SqlCommand(query, objConnection))
        //    //    {
        //    //        cmd.Parameters.AddWithValue("@email", email);

        //    //        cmd.ExecuteNonQuery();
        //    //    }
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    MessageBox.Show("Usuario Inexistente" + ex.ToString());
        //    //}
        //    //finally
        //    //{
        //    //    objConnection.Close();
        //    //}
        //    string queryGetUsers = "SELECT usuario_id FROM usuarios";
        //    string queryGetUserRol = $"SELECT tipo_usuario FROM Usuarios WHERE email = '{email}'";
        //    string queryGetUserPass = $"SELECT Contrasena FROM Usuarios WHERE ID_email = '{email}'";
        //    string txtUser = string.Empty;
        //    List<string> lstUsuarios = new List<string>();
        //    //List<string> lstPromotores = new List<string>();
        //    string item = string.Empty;
        //    string pass = string.Empty;
        //    int goTo = 3;

        //    try
        //    {
        //        objCommand = new SqlCommand(queryGetUsers, GetConnection());
        //        SqlDataReader reader = objCommand.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            item = reader.GetString(0);
        //            lstUsuarios.Add(item);
        //        }
        //        objConnection.Close();

        //        if (lstUsuarios.Contains(user))
        //        {
        //            objCommand = new SqlCommand(queryGetUserPass, GetConnection());
        //            SqlDataReader reader1 = objCommand.ExecuteReader();
        //            while (reader1.Read())
        //            {
        //                item = reader1.GetString(0);
        //            }
        //            objConnection.Close();

        //            if (item == contraseña)
        //            {
        //                objCommand = new SqlCommand(queryGetUserRol, GetConnection());
        //                reader = objCommand.ExecuteReader();
        //                while (reader.Read())
        //                {
        //                    goTo = reader.GetInt32(0);
        //                }
        //                objConnection.Close();
        //                return goTo;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Contraseña incorrecta", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return goTo;
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("No se encontró al usuario", "Username incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return goTo;
        //        }
        //    }
        //    catch (SqlException sqlError)
        //    {
        //        MessageBox.Show("Ha ocurrido un error relacionado a la base de datos" + sqlError.Message, "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Ha ocurrido un error con el programa" + ex.Message, "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    return goTo;
        //}
    }
}

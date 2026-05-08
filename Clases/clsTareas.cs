using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NexusApp
{
    internal class clsTareas : ClsConexion
    {
        public int tarea_id { get; set; }
        public int proyecto_id { get; set; }
        public int usuario_id { get; set; }
        public string tituloTarea { get; set; }
        public string contenido { get; set; }
        public int estatus_id { get; set; }
        public int prioridad_id { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaLimite { get; set; }
        public DateTime fechaFin {  get; set; }

        public void InsertarTareaDependiente()
        {
            try
            {
                GetConnection();
                string query = "INSERT INTO tareas (proyecto_id, usuario_id, tituloTarea) VALUES (@proyecto_id, @usuario_id, @tituloTarea)";
                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@proyecto_id", proyecto_id);
                    cmd.Parameters.AddWithValue("@usuario_id", usuario_id);
                    cmd.Parameters.AddWithValue("@tituloTarea", tituloTarea);

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
        public void InsertarTareaIndependiente()
        {
            try
            {
                GetConnection();
                string query = "INSERT INTO tareas (usuario_id, tituloTarea) VALUES (@usuario_id, @tituloTarea)";
                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@usuario_id", usuario_id);
                    cmd.Parameters.AddWithValue("@tituloTarea", tituloTarea);

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

        public void ActualizarTituloTarea()
        {
            try
            {
                GetConnection();
                string query = "UPDATE tareas SET tituloTarea = @tituloTarea WHERE tarea_id = @tarea_id";
                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@tituloTarea", tituloTarea);
                    cmd.Parameters.AddWithValue("@tarea_id", tarea_id);

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

        public void ActualizarProyectoTarea()
        {
            try
            {
                GetConnection();
                string query = "UPDATE tareas SET proyecto_id = @proyecto_id WHERE tarea_id = @tarea_id";
                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@tituloTarea", tituloTarea);
                    cmd.Parameters.AddWithValue("@tarea_id", tarea_id);

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

        public void ActualizarEstatusTarea()
        {
            try
            {
                GetConnection();
                string query = "UPDATE tareas SET estatus_id = @estatus_id WHERE tarea_id = @tarea_id";
                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@estatus_id", estatus_id);
                    cmd.Parameters.AddWithValue("@tarea_id", tarea_id);

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

        public void ActualizarPrioridadTarea()
        {
            try
            {
                GetConnection();
                string query = "UPDATE tareas SET prioridad_id = @prioridad_id WHERE tarea_id = @tarea_id";
                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@prioridad_id", prioridad_id);
                    cmd.Parameters.AddWithValue("@tarea_id", tarea_id);

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

        public void ActualizarFechaLimiteTarea()
        {
            try
            {
                GetConnection();
                string query = "UPDATE tareas SET fechaLimite = @fechaLimite WHERE tarea_id = @tarea_id";
                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@fechaLimite", fechaLimite);
                    cmd.Parameters.AddWithValue("@tarea_id", tarea_id);

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

        public void ActualizarFechaFinTarea()
        {
            try
            {
                GetConnection();
                string query = "UPDATE tareas SET fechaFin = GETDATE() WHERE tarea_id = @tarea_id";
                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@fechaLimite", fechaLimite);
                    cmd.Parameters.AddWithValue("@tarea_id", tarea_id);

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

        public void EliminarTarea()
        {
            try
            {
                GetConnection();
                string query = "DELETE FROM tareas WHERE tarea_id = @tarea_id";
                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@tarea_id", tarea_id);

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

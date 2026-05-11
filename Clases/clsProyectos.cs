using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace NexusApp
{
    internal class clsProyectos : clsConexion
    {
        public int proyecto_id { get; set; }
        public int usuario_id { get; set; }
        public string tituloProyecto { get; set; }
        public int estatus_id { get; set; }
        public int prioridad_id { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaLimite { get; set; }
        public DateTime fechaFin { get; set; }

        DataTable dtProyectos = new DataTable();

        public void InsertarProyectoRegParcial()
        {
            try
            {
                GetConnection();
                string query = "INSERT INTO proyectos (usuario_id, tituloProyecto) VALUES (@usuario_id, @tituloProyecto)";
                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@usuario_id", usuario_id);
                    cmd.Parameters.AddWithValue("@tituloProyecto", tituloProyecto);

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

        public void InsertarProyectoRegTotal()
        {
            try
            {
                GetConnection();
                string query = "INSERT INTO proyectos (usuario_id, tituloProyecto, estatus_id, prioridad_id, fechaLimite) VALUES (@usuario_id, @tituloProyecto, @estatus_id, @prioridad_id, @fechaLimite)";
                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@usuario_id", usuario_id);
                    cmd.Parameters.AddWithValue("@tituloProyecto", tituloProyecto);
                    cmd.Parameters.AddWithValue("@estatus_id", estatus_id);
                    cmd.Parameters.AddWithValue("@prioridad_id", prioridad_id);
                    cmd.Parameters.AddWithValue("@fechaLimite", fechaLimite);

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

        public DataTable GetProyectos()
        {
            DataTable dt = new DataTable();
            try
            {
                GetConnection();
                // Seleccionamos los campos. 
                string query = "SELECT * FROM proyectos WHERE usuario_id = @usuario_id";

                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@usuario_id", usuario_id);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proyectos: " + ex.ToString());
            }
            finally
            {
                objConnection.Close();
            }
            return dt;
        }

        public DataTable GetEstatus()
        {
            DataTable dt = new DataTable();
            try
            {
                GetConnection();
                // Seleccionamos los campos. 
                string query = "SELECT * FROM estatus";

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
                MessageBox.Show("Error al cargar Estatus: " + ex.ToString());
            }
            finally
            {
                objConnection.Close();
            }
            return dt;
        }

        public DataTable GetPrioridad()
        {
            DataTable dt = new DataTable();
            try
            {
                GetConnection();
                // Seleccionamos los campos. 
                string query = "SELECT * FROM prioridad";

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
                MessageBox.Show("Error al cargar Prioridad: " + ex.ToString());
            }
            finally
            {
                objConnection.Close();
            }
            return dt;
        }

        public void ActualizarProyecto()
        {
            try
            {
                GetConnection();
                string query = "UPDATE proyectos SET tituloProyecto = @tituloProyecto, estatus_id = @estatus_id, prioridad_id = @prioridad_id, fechaLimite = @fechaLimite WHERE proyecto_id = @proyecto_id";
                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@tituloProyecto", tituloProyecto);
                    cmd.Parameters.AddWithValue("@estatus_id", estatus_id);
                    cmd.Parameters.AddWithValue("@prioridad_id", prioridad_id);
                    cmd.Parameters.AddWithValue("@fechaLimite", fechaLimite);
                    //cmd.Parameters.AddWithValue("@fechaFin", fechaFin);
                    cmd.Parameters.AddWithValue("@proyecto_id", proyecto_id);

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

        public void ActualizarTituloProyecto()
        {
            try
            {
                GetConnection();
                string query = "UPDATE proyectos SET tituloProyecto = @tituloProyecto WHERE proyecto_id = @proyecto_id";
                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@tituloProyecto", tituloProyecto);
                    cmd.Parameters.AddWithValue("@proyecto_id", proyecto_id);

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

        public void ActualizarEstatusProyecto()
        {
            try
            {
                GetConnection();
                string query = "UPDATE proyectos SET estatus_id = @estatus_id WHERE proyecto_id = @proyecto_id";
                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@estatus_id", estatus_id);
                    cmd.Parameters.AddWithValue("@proyecto_id", proyecto_id);

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

        public void ActualizarPrioridadProyecto()
        {
            try
            {
                GetConnection();
                string query = "UPDATE proyectos SET prioridad_id = @prioridad_id WHERE proyecto_id = @proyecto_id";
                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@prioridad_id", prioridad_id);
                    cmd.Parameters.AddWithValue("@proyecto_id", proyecto_id);

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

        public void ActualizarFechaLimiteProyecto()
        {
            try
            {
                GetConnection();
                string query = "UPDATE proyectos SET fechaLimite = @fechaLimite WHERE proyecto_id = @proyecto_id";
                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@fechaLimite", fechaLimite);
                    cmd.Parameters.AddWithValue("@proyecto_id", proyecto_id);

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

        public void InsertarFechaFinProyecto()
        {
            try
            {
                GetConnection();
                string query = "UPDATE proyectos SET estatus_id = @estatus_id, fechaFin = GETDATE() WHERE proyecto_id = @proyecto_id";
                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@estatus_id", estatus_id);
                    cmd.Parameters.AddWithValue("@proyecto_id", proyecto_id);

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

        public void LimpiarFechaFinProyecto()
        {
            try
            {
                GetConnection();
                string query = "UPDATE proyectos SET estatus_id = @estatus_id, fechaFin = NULL WHERE proyecto_id = @proyecto_id";
                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@estatus_id", estatus_id);
                    cmd.Parameters.AddWithValue("@proyecto_id", proyecto_id);

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

        public void EliminarProyecto()
        {
            try
            {
                GetConnection();
                string query = "DELETE FROM proyectos WHERE proyecto_id = @proyecto_id";
                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    cmd.Parameters.AddWithValue("@proyecto_id", proyecto_id);

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

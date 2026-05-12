using System;
using System.Data;
using System.Data.SqlClient;

namespace NexusApp
{
    internal class clsNotas : clsConexion
    {
        public int nota_id { get; set; }
        public int bloc_id { get; set; }
        public string tituloNota { get; set; }
        public string contenido { get; set; }
        public DateTime fechaCreacion { get; set; }

        public void Guardar(clsNotas objeto)
        {
            try
            {
                GetConnection();
                string query = "INSERT INTO Notas (bloc_id, tituloNota, fechaCreacion, contenido) VALUES (@bloc, @tit, GETDATE(), @cont)";
                SqlCommand cmd = new SqlCommand(query, objConnection);

                cmd.Parameters.AddWithValue("@bloc", objeto.bloc_id);
                cmd.Parameters.AddWithValue("@tit", objeto.tituloNota);
                cmd.Parameters.AddWithValue("@cont", objeto.contenido);

                cmd.ExecuteNonQuery();
            }
            finally { objConnection.Close(); }
        }

        public void Editar(clsNotas objeto)
        {
            try
            {
                GetConnection();
                string query = "UPDATE Notas SET tituloNota = @tit, contenido = @cont, fechaModificacion = GETDATE() WHERE nota_id = @id";
                SqlCommand cmd = new SqlCommand(query, objConnection);

                cmd.Parameters.AddWithValue("@tit", objeto.tituloNota);
                cmd.Parameters.AddWithValue("@cont", objeto.contenido);
                cmd.Parameters.AddWithValue("@id", objeto.nota_id);

                cmd.ExecuteNonQuery();
            }
            finally { objConnection.Close(); }
        }

        public void Eliminar()
        {
            try
            {
                GetConnection();
                string query = "DELETE FROM notas WHERE nota_id = @nota_id";
                SqlCommand cmd = new SqlCommand(query, objConnection);

                cmd.Parameters.AddWithValue("@nota_id", nota_id);

                cmd.ExecuteNonQuery();
            }
            finally { objConnection.Close(); }
        }

        public DataTable Listar(int idBloc)
        {
            try
            {
                GetConnection();
                string query = "SELECT nota_id, tituloNota, contenido, fechaCreacion FROM Notas WHERE bloc_id = @id";
                SqlCommand cmd = new SqlCommand(query, objConnection);
                cmd.Parameters.AddWithValue("@id", idBloc);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
            finally
            {
                objConnection.Close();
            }
        }
    }
}
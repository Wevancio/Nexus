using System.Data.SqlClient;

namespace NexusApp
{
    internal class clsBlocNotas : clsConexion
    {
        public int bloc_id { get; set; }
        public int usuario_id { get; set; }
        public string tituloBloc { get; set; }

        public void Insertar(clsBlocNotas objeto)
        {
            try
            {
                GetConnection();
                string query = "INSERT INTO BlocNotas (usuario_id, tituloBloc) VALUES (@user, @titulo)";
                SqlCommand cmd = new SqlCommand(query, objConnection);

                cmd.Parameters.AddWithValue("@user", objeto.usuario_id);
                cmd.Parameters.AddWithValue("@titulo", objeto.tituloBloc);

                cmd.ExecuteNonQuery();
            }
            finally { objConnection.Close(); }
        }

        public void Editar(clsBlocNotas objeto)
        {
            try
            {
                GetConnection();
                string query = "UPDATE BlocNotas SET tituloBloc = @titulo WHERE bloc_id = @id";
                SqlCommand cmd = new SqlCommand(query, objConnection);

                cmd.Parameters.AddWithValue("@titulo", objeto.tituloBloc);
                cmd.Parameters.AddWithValue("@id", objeto.bloc_id);

                cmd.ExecuteNonQuery();
            }
            finally { objConnection.Close(); }
        }
    }
}
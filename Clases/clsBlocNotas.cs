using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexusApp
{
    internal class clsBlocNotas : clsConexion
    {
        public int Bloc_ID { get; set; }
        public int ID_Usuario { get; set; }
        public string TituloBloc { get; set; }

        public void Insertar(clsBlocNotas objeto)
        {
            try
            {
                GetConnection();
                string query = "INSERT INTO BlocNotas (usuario_id, tituloBloc) VALUES (@user, @titulo)";
                SqlCommand cmd = new SqlCommand(query, objConnection);

                cmd.Parameters.AddWithValue("@user", objeto.ID_Usuario);
                cmd.Parameters.AddWithValue("@titulo", objeto.TituloBloc);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                objConnection.Close();

            }
        }

        public void Editar(clsBlocNotas objeto)
        {
            try
            {
                GetConnection();
                string query = "UPDATE BlocNotas SET tituloBloc = @titulo WHERE bloc_id = @id";
                SqlCommand cmd = new SqlCommand(query, objConnection);

                cmd.Parameters.AddWithValue("@titulo", objeto.TituloBloc);
                cmd.Parameters.AddWithValue("@id", objeto.Bloc_ID);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                objConnection.Close();
            }
        }
    }
}

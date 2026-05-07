using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexusApp
{
    internal class BlocNotas : ClsConexion
    {
        public int Bloc_ID { get; set; }
        public int ID_Usuario { get; set; }
        public string TituloBloc { get; set; }

        public void Insertar(BlocNotas objeto)
        {
            try
            {
                GetConnection();
                string query = "INSERT INTO BlocNotas (ID_Usuario, TituloBloc) VALUES (@user, @titulo)";
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

        public void Editar(BlocNotas objeto)
        {
            try
            {
                GetConnection();
                string query = "UPDATE BlocNotas SET TituloBloc = @titulo WHERE Bloc_ID = @id";
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

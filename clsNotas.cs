using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexusApp
{
    internal class clsNotas : ClsConexion
    {
        public int Nota_ID { get; set; }
        public int Bloc_ID { get; set; }
        public string Contenido { get; set; }
        public void Guardar(clsNotas objeto)
        {
            try
            {
                GetConnection();
                string query = "INSERT INTO Notas (Bloc_ID, Contenido) VALUES (@bloc, @cont)";
                SqlCommand cmd = new SqlCommand(query, objConnection);

                cmd.Parameters.AddWithValue("@bloc", objeto.Bloc_ID);
                cmd.Parameters.AddWithValue("@cont", objeto.Contenido);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                objConnection.Close();
            }
        }

        // Método para eliminar una nota por su ID
        public void Eliminar(int idNota)
        {
            try
            {
                GetConnection();
                string query = "DELETE FROM Notas WHERE Nota_ID = @id";
                SqlCommand cmd = new SqlCommand(query, objConnection);
                cmd.Parameters.AddWithValue("@id", idNota);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                objConnection.Close();
            }
        }
        public void Editar(clsNotas objeto)
        {
            try
            {
                GetConnection();
                string query = "UPDATE Notas SET Contenido = @cont WHERE Nota_ID = @id";
                SqlCommand cmd = new SqlCommand(query, objConnection);
                cmd.Parameters.AddWithValue("@cont", objeto.Contenido);
                cmd.Parameters.AddWithValue("@id", objeto.Nota_ID);
                cmd.ExecuteNonQuery();
            }
            finally { objConnection.Close(); }
        }
    }
}
}

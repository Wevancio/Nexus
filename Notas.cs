using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexusApp
{
    internal class Notas
    {
        public void Guardar(Nota objeto)
        {
            try
            {
                Abrir();
                string query = "INSERT INTO Notas (Bloc_ID, Contenido) VALUES (@bloc, @cont)";
                SqlCommand cmd = new SqlCommand(query, conectar);

                cmd.Parameters.AddWithValue("@bloc", objeto.Bloc_ID);
                cmd.Parameters.AddWithValue("@cont", objeto.Contenido);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                Cerrar();
            }
        }

        // Método para eliminar una nota por su ID
        public void Eliminar(int idNota)
        {
            try
            {
                Abrir();
                string query = "DELETE FROM Notas WHERE Nota_ID = @id";
                SqlCommand cmd = new SqlCommand(query, conectar);
                cmd.Parameters.AddWithValue("@id", idNota);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                Cerrar();
            }
        }
        public void Editar(Nota objeto)
        {
            try
            {
                Abrir();
                string query = "UPDATE Notas SET Contenido = @cont WHERE Nota_ID = @id";
                SqlCommand cmd = new SqlCommand(query, conectar);
                cmd.Parameters.AddWithValue("@cont", objeto.Contenido);
                cmd.Parameters.AddWithValue("@id", objeto.Nota_ID);
                cmd.ExecuteNonQuery();
            }
            finally { Cerrar(); }
        }
    }
}

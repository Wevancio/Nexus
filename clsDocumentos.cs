using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NexusApp
{
    internal class clsDocumentos : ClsConexion
    {
        public int Documento_ID { get; set; }
        public int Usuario_ID { get; set; }
        public string Titulo { get; set; }
        public string URL { get; set; }
        public DateTime FechaSubida { get; set; }
      public void Registrar(clsDocumentos objeto)
        {
            try
            {
                GetConnection();
                string query = "INSERT INTO Documentos (usuario_id, tituloDocumento, urlDoc, fechaSubida) VALUES (@uID, @tit, @url, GETDATE())";
                SqlCommand cmd = new SqlCommand(query, objConnection);

                cmd.Parameters.AddWithValue("@uID", objeto.Usuario_ID);
                cmd.Parameters.AddWithValue("@tit", objeto.Titulo);
                cmd.Parameters.AddWithValue("@url", objeto.URL);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                objConnection.Close();
            }
        }

        public DataTable ListarPorUsuario(int idUsuario)
        {
            try
            {
                GetConnection();
                string query = "SELECT * FROM Documentos WHERE Usuario_ID = @uID";
                SqlDataAdapter da = new SqlDataAdapter(query, objConnection);
                da.SelectCommand.Parameters.AddWithValue("@uID", idUsuario);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            finally
            {
                objConnection.Close();
            }
        }
        public void Editar(clsDocumentos objeto)
        {
            try
            {
                GetConnection();
                string query = "UPDATE Documentos SET Titulo = @tit, URL = @url WHERE Documento_ID = @id";
                SqlCommand cmd = new SqlCommand(query, objConnection);
                cmd.Parameters.AddWithValue("@tit", objeto.Titulo);
                cmd.Parameters.AddWithValue("@url", objeto.URL);
                cmd.Parameters.AddWithValue("@id", objeto.Documento_ID);
                cmd.ExecuteNonQuery();
            }
            finally { objConnection.Close(); }
        }
    }
}

using NexusApp;
using System.Data;
using System.Data.SqlClient;

internal class clsDocumentos : clsConexion
{
    // Propiedades (Asegúrate de que se llamen así)
    public int documento_id { get; set; }
    public int usuario_id { get; set; }
    public string tituloDocumento { get; set; }
    public string urlDoc { get; set; }

    // Corrigiendo el método GetDocumentos que pide el frmMain
    public DataTable GetDocumentos()
    {
        try
        {
            GetConnection(); // Asegúrate de que este método herede de clsConexion
                             // Usamos el usuario_id que ya tiene la instancia de la clase
            string query = "SELECT documento_id, tituloDocumento, urlDoc FROM Documentos WHERE usuario_id = @user";
            SqlCommand cmd = new SqlCommand(query, objConnection);
            cmd.Parameters.AddWithValue("@user", this.usuario_id);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        finally { objConnection.Close(); }
    }

    public void Insertar() // Sin parámetros, usa las propiedades de la clase
    {
        try
        {
            GetConnection();
            string query = "INSERT INTO Documentos (usuario_id, tituloDocumento, urlDoc) VALUES (@user, @tit, @url)";
            SqlCommand cmd = new SqlCommand(query, objConnection);
            cmd.Parameters.AddWithValue("@user", this.usuario_id);
            cmd.Parameters.AddWithValue("@tit", this.tituloDocumento);
            cmd.Parameters.AddWithValue("@url", this.urlDoc);
            cmd.ExecuteNonQuery();
        }
        finally { objConnection.Close(); }
    }

    // Agrega el método Eliminar si no lo tienes
    public void Eliminar(int id)
    {
        try
        {
            GetConnection();
            string query = "DELETE FROM Documentos WHERE documento_id = @id";
            SqlCommand cmd = new SqlCommand(query, objConnection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
        finally { objConnection.Close(); }
    }
    public void Editar(clsDocumentos objeto)
    {
        try
        {
            GetConnection();
            // Asegúrate de que los nombres de las columnas coincidan con tu BD: documento_id, tituloDocumento, urlDoc
            string query = "UPDATE Documentos SET tituloDocumento = @titulo, urlDoc = @url WHERE documento_id = @id";
            SqlCommand cmd = new SqlCommand(query, objConnection);

            cmd.Parameters.AddWithValue("@titulo", objeto.tituloDocumento);
            cmd.Parameters.AddWithValue("@url", objeto.urlDoc);
            cmd.Parameters.AddWithValue("@id", objeto.documento_id);

            cmd.ExecuteNonQuery();
        }
        finally
        {
            objConnection.Close();
        }
    }
}
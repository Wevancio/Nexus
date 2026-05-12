using NexusApp;
using System;
using System.Data;
using System.Data.SqlClient;

internal class clsDocumentos : clsConexion
{
    public int documento_id { get; set; }
    public int usuario_id { get; set; }
    public string tituloDocumento { get; set; }
    public string urlDoc { get; set; }
    // Nuevas propiedades para cumplir con lo que pidió el equipo
    public string tipoDoc { get; set; }
    public string tamanoDoc { get; set; }

    public void Insertar()
    {
        try
        {
            GetConnection();
            // Actualizamos el query para incluir las nuevas columnas
            string query = "INSERT INTO Documentos (usuario_id, tituloDocumento, urlDoc, tipoDoc, tamanoDoc) " +
                           "VALUES (@user, @tit, @url, @tipo, @tamano)";
            SqlCommand cmd = new SqlCommand(query, objConnection);

            cmd.Parameters.AddWithValue("@user", this.usuario_id);
            cmd.Parameters.AddWithValue("@tit", this.tituloDocumento);
            cmd.Parameters.AddWithValue("@url", this.urlDoc);
            cmd.Parameters.AddWithValue("@tipo", this.tipoDoc);
            cmd.Parameters.AddWithValue("@tamano", this.tamanoDoc);

            cmd.ExecuteNonQuery();
        }
        finally { objConnection.Close(); }
    }
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
    public void EditarNombre(clsDocumentos objeto)
    {
        try
        {
            GetConnection();
            string query = "UPDATE Documentos SET tituloDocumento = @tit WHERE documento_id = @id";
            SqlCommand cmd = new SqlCommand(query, objConnection);

            cmd.Parameters.AddWithValue("@tit", objeto.tituloDocumento);
            cmd.Parameters.AddWithValue("@id", objeto.documento_id);

            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception("Error en la base de datos al renombrar: " + ex.Message);
        }
        finally
        {
            objConnection.Close();
        }
    }
}
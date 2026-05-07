using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexusApp
{
    internal class ClsConexion
    {
        protected SqlConnection objConnection;
        protected SqlCommand objCommand;

        public SqlConnection GetConnection()
        {
            objConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionSQL"].ToString());
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            return objConnection;
        }

    }
}

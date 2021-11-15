using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Examen2F.Modelos.DAO
{
    class Conexion
    {
        protected SqlConnection Nuestraconexion = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConexion"].ConnectionString);
    }
}

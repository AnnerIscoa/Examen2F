using Examen2F.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2F.Modelos.DAO
{
    class UsuarioDAO : Conexion
    {
            SqlCommand comando = new SqlCommand();

            public bool ValidarUsuario(Usuario user)
            {
                bool valido = false;
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.Append("SELECT * FROM USUARIO WHERE CORREO = @Correo AND CLAVE = @Clave;");

                    comando.Connection = Nuestraconexion;
                    Nuestraconexion.Open();
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = sql.ToString();
                    comando.Parameters.Add("@Correo", SqlDbType.NVarChar, 50).Value = user.Correo;
                    comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 16).Value = user.Clave;
                    valido = Convert.ToBoolean(comando.ExecuteScalar());

                }
                catch (Exception)
                {
                }
                return valido;
            }
        }
    }


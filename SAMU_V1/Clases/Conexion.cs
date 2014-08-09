using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SAMU_V1.Clases
{   
    class Conexion
    {
        static SqlConnection conexion = new SqlConnection();
        public static void abrirConexion()
        {
            conexion.ConnectionString=@"Data Source=VIVI-PC2\SQLSERVER;Initial Catalog=SAMU;User ID=sa;Password=1q2w3e4r";
            conexion.Open();
        }
        public static void cerrarConexion()
        {
            conexion.Close();
        }
        public static string IniciarSesion(string usuario, string contrasenha)
        {
            int logueado = 0;
            string mensaje =  " ";
            abrirConexion();
            SqlCommand cmd= new SqlCommand();
            cmd.CommandText = "pa_loguear";
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@usuario", usuario));
            cmd.Parameters.Add(new SqlParameter("@contrasenha", contrasenha));

            SqlParameter pLogueado = new SqlParameter("@logueado",0);
            pLogueado.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pLogueado);

            SqlParameter pMensaje = new SqlParameter("@mensaje", SqlDbType.VarChar);
            pMensaje.Direction = ParameterDirection.Output;
            pMensaje.Size= 40;
            cmd.Parameters.Add(pMensaje);

            cmd.ExecuteNonQuery();
            cerrarConexion();

            logueado = Int32.Parse(cmd.Parameters["@logueado"].Value.ToString());
            if (logueado > 0)
            {
                mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                return mensaje;
            }
            else
            {
                return mensaje;
            }
        }
    }
}

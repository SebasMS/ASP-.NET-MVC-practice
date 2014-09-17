using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        public SqlConnection con { get; set; }

        // retorno cadenaconexión
        public string cadenaConexion()
        {
            return @"data source=.;initial=dbSMTutorial;user id=sebasMS;password=mejias123";
        }

        #region Conectar
        public SqlConnection conectar()
        {
            con = new SqlConnection(cadenaConexion());

            try
            {
                con.Open();
                return this.con;
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

        #region Deconectar
        public void desconectar()
        {
            if (this.con != null)
            {
                this.con.Close();
            }
        }
        #endregion
    }
}

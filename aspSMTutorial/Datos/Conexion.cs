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

        #region Conectar

        // retorno cadenaconexión
        public string cadenaConexion()
        {
            //return @"Data Source=.; Initial Catalog=dbSMTutorial;user id=sebasMS;password=mejias123";
            return @"Data Source=localhost; Initial Catalog=dbSMTutorial; Integrated Security=true";
        }
        
        public SqlConnection conectar()
        {
            this.con = new SqlConnection(cadenaConexion());

            try
            {
                this.con.Open();
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

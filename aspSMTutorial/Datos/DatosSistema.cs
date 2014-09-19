using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosSistema
    {
        /*  El método de tipo DataTable sirve para consultar registros de una base de datos, 
         *  sean mostrar todos los registros o los que necesitemos. Es necesario pasarle tres 
         *  parametros al método: 
         *  
         *  1. Nombre del procedimiento almacenado. 
         *  2.Parámetros del procedimiento.
         *  3. Valores de los parametros */

        public DataTable getDatos(string procedimiento, string[] parametros, params Object[] valParametro)
        {
            // Instanciamos la conexión
            Conexion con = new Conexion();
            
            // Se crea una nueva DataTable
            DataTable dt = new DataTable();

            // Creamos un nuevo SqlCommand
            SqlCommand cmd = new SqlCommand();

            // Nos conectamos a la base de datos en el método conectar()
            cmd.Connection = con.conectar();

            // Especifica el nombre del procedimiento a ejecutar
            cmd.CommandText = procedimiento;

            // Determinamos que es un procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure;

            // Se valida que los valores esten y sean correctos
            if (procedimiento.Length != 0 && parametros.Length == valParametro.Length)
            {
                // Creamos una variable para recorrer los valores ingresados
                int index = 0;

                // Recorre los parametros
                foreach (string parametro in parametros)
                {
                    // Ejecuta los valores que ingresaron 
                    cmd.Parameters.AddWithValue(parametro, valParametro[index++]);
                }
                                
                try
                {
                    // Efectuamos la instrucción con el SqlDataReader
                    SqlDataReader dr = cmd.ExecuteReader();

                    // Carga los registro en el dt (DataTable)
                    dt.Load(dr);

                    // Cierra la conexión
                    con.desconectar();

                    // Retornamos el dt (DataTable)
                    return dt;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            // Retorno del DataTable
            return dt;
        }


        /* Método para ejecutar procedimiento almacenado en la base de datos. 
         * Funciona igual que el anterior, a diferencia de que no utilizamos DataTable*/

        public int? Ejecutar(string procedimiento, string[] parametros, params Object[] valParametros)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.conectar();
            cmd.CommandText = procedimiento;
            cmd.CommandType = CommandType.StoredProcedure;
            
            if (procedimiento.Length != 0 && parametros.Length == valParametros.Length)
            {
                int index = 0;
                foreach (string parametro in parametros)
                {
                    cmd.Parameters.AddWithValue(parametro, valParametros[index++]);
                }
                    
                try
                {
                    // Lo unico que cambia es esto, ya que retorna la ejecución directa.
                    return cmd.ExecuteNonQuery();//
                }
                catch (Exception)
                {
                    return null;
                }
            }
            //Si no, retornamos cero
            return 0;
        }

    }
}

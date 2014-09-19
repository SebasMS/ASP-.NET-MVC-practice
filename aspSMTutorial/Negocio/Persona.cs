using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Persona
    {
        #region Atributos

        private string cedula;
        private string nombre;
        private string apellido;
        private DateTime fecha;
        private int edad;
        private string direccion;

        #endregion

        #region Propiedades

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        #endregion

        #region Métodos para base de datos

        // Método insertar y modificar
        public int? insertarActualizar(Persona persona, string operacion)
        {
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@operacion", "@cedula", "@nombre", "@apellido", 
                "@fechaNacimiento", "@edad", "@direccion" };

            return datos.Ejecutar("spPersonaIA", parametros, operacion, persona.cedula, 
                persona.nombre, persona.apellido, persona.fecha, persona.edad, persona.direccion);
        }

        // Método eliminar
        public int? Eliminar(Persona persona)
        {
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@operacion", "@cedula" };

            return datos.Ejecutar("spPersonaSE", parametros, "E", persona.cedula);
        }

        // Método consultar un registro
        public Persona getPersona(Persona persona)
        {
            DatosSistema datos = new DatosSistema();
            DataTable dt = new DataTable();

            string[] parametros = { "@operacion", "@cedula" };
            dt = datos.getDatos("spPersonaSE", parametros, "S", 0);

            foreach (DataRow row in dt.Rows)
            {
                persona.cedula = row["cedula"].ToString();
                persona.nombre = row["nombre"].ToString();
                persona.apellido = row["apellido"].ToString();
                persona.fecha = Convert.ToDateTime(row["fechaNacimiento"].ToString());
                persona.edad = Convert.ToInt16(row["edad"].ToString());
                persona.direccion = row["direccion"].ToString();
            }

            return persona;
        }
        
        // Método consultar personas
        public DataTable getPersonas()
        {
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@operacion", "@cedula" };

            return datos.getDatos("spPersonaSE", parametros, "T", 0);
        }

        #endregion
    }
}

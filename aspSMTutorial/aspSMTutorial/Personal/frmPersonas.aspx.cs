using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspSMTutorial
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Persona persona = new Persona();

            // Cargamos los datos en el DataGrid
            dgvPersonas.DataSource = persona.getPersonas();

            // Actualiza el DataGrid
            dgvPersonas.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Cedula = txtCedula.Text;
            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            persona.Fecha = Convert.ToDateTime(txtFechaNacimiento.Text);
            persona.Edad = Convert.ToInt16(txtEdad.Text);
            persona.Direccion = txtDireccion.Text;

            if (persona.insertarActualizar(persona, "I") > 0)
            {
                dgvPersonas.DataBind();
                lblMensaje.Text = "Registro ingresado correctamente";
            }
            else
            {
                lblMensaje.Text = "Falló el intento de registro";
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Cedula = txtCedula.Text;
            persona.getPersona(persona);

            if (persona != null)
            {
                lblMensaje.Text = "Registro encontrado";
                txtCedula.Text = persona.Cedula;
                txtNombre.Text = persona.Nombre;
                txtApellido.Text = persona.Apellido;
                txtFechaNacimiento.Text = persona.Fecha.ToString();
                txtEdad.Text = persona.Edad.ToString();
                txtDireccion.Text = persona.Direccion;

            }
            else
            {
                lblMensaje.Text = "El registro no se encontró";
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Cedula = txtCedula.Text;
            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            persona.Fecha = Convert.ToDateTime(txtFechaNacimiento.Text);
            persona.Edad = Convert.ToInt16(txtEdad.Text);
            persona.Direccion = txtDireccion.Text;

            if (persona.insertarActualizar(persona, "A") > 0)
            {
                dgvPersonas.DataBind();
                lblMensaje.Text = "Registro actualizado correctamente";
            }
            else
            {
                lblMensaje.Text = "Falló el intento de actualizar el registro";
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Cedula = txtCedula.Text;
            if (persona.Eliminar(persona) > 0)
            {
                dgvPersonas.DataBind();
                lblMensaje.Text = "Persona eliminada correctamente";
            }
            else
            {
                lblMensaje.Text = "Falló el intento de borrado";
            }
        }
    }
}
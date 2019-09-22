using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesCompartidas;
using Logica;

public partial class ABMCliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.LimpioFormulario();
            this.DesactivoBotones();
        }

    }

    private void LimpioFormulario() 
    {
        txtCI.Text = "";
        txtNombre.Text = "";
        txtApellido.Text = "";
        txtTelefono.Text = "";
        BtnBuscar.Enabled = true;

    }

    private void DesactivoBotones()
    {
        BtnAgregar.Enabled = false;
        BtnEliminar.Enabled = false;
        BtnModificar.Enabled = false;
        BtnBuscar.Enabled = true;
    }


    protected void BtnBuscar_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        int ci = 0;

        try
        {
            
            ci = Convert.ToInt32(txtCI.Text);

        }
        catch 
        {
            lblError.Text = "La cedula debe ser un numero!";
        }

        try
        {
            Cliente c = LogicaCliente.Buscar(ci);

            if (c != null)
            {
                txtNombre.Text = c.Nombre;
                txtApellido.Text = c.Apellido;
                txtTelefono.Text = c.Telefono.ToString();

                Session["unCliente"] = c;

                txtCI.Enabled = false;
                BtnEliminar.Enabled = true;
                BtnModificar.Enabled = true;
            }
            else
            {
                lblError.Text = "Cliente no encontrado";
                BtnAgregar.Enabled = true;

                Session["unCliente"] = null;
            }

        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }


    }



    protected void BtnModificar_Click(object sender, EventArgs e)
    { 
       

        try
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int telefono = Convert.ToInt32(txtTelefono.Text);

            Cliente c = (Cliente)Session["unCliente"];
            c.Nombre = nombre;
            c.Apellido = apellido;
            c.Telefono = telefono;


            LogicaCliente.Modificar(c);
            lblError.Text = "Modificacion exitosa!";
            txtCI.Enabled = true;
            this.LimpioFormulario();
            this.DesactivoBotones();
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;

        }

    }

    protected void BtnEliminar_Click(object sender, EventArgs e) 
    {
        try
        {
            Cliente c = (Cliente)Session["unCliente"];

            LogicaCliente.Eliminar(c);
            lblError.Text = "Eliminacion exitosa!";
            txtCI.Enabled = true;
            this.LimpioFormulario();
            this.DesactivoBotones();


        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;

        }


    }

    protected void BtnAgregar_Click(object sender, EventArgs e)
    {
        try
        {
            int ci = Convert.ToInt32(txtCI.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int telefono = Convert.ToInt32(txtTelefono.Text);


            Cliente c = new Cliente(ci, nombre, apellido, telefono);


            LogicaCliente.Agregar(c);

            lblError.Text = "Cliente agregado exitosamente!";
            txtCI.Enabled = true;
            this.LimpioFormulario(); 
            this.DesactivoBotones();

        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }



    }


    protected void BtnLimpiar_Click(object sender, EventArgs e)
    {
        txtCI.Enabled = true;
        this.LimpioFormulario();
        this.DesactivoBotones(); 
        lblError.Text = "";
    }
}
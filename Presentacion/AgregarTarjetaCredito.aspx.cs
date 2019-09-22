using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesCompartidas;
using Logica;

public partial class AgregarTarjetaCredito : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.LimpioFormulario();

        }
    }
    private void LimpioFormulario()
    {
        txtCI.Text = "";       
        txtLimite.Text = "";
        chkProtegida.Checked = false;

    }






    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        try
        {
            int nroTarjeta = 0;
            Cliente Cli = LogicaCliente.Buscar(Convert.ToInt32(txtCI.Text));
            DateTime fechaVen = Calendario.SelectedDate;
            bool personalizada = chkProtegida.Checked;
            string categoria = ddlCategoria.Text;
            int limite = Convert.ToInt32(txtLimite.Text);

            Credito c = new Credito(nroTarjeta, Cli, fechaVen, personalizada, limite, categoria);

            LogicaTarjeta.Agregar(c);

            lblError.Text = "Tarjeta generada exitosamente!";

            this.LimpioFormulario();


        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;

        }





    }
}
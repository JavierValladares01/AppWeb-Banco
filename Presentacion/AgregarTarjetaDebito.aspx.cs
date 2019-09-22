using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesCompartidas;
using Logica;

public partial class AgregarTarjetaDebito : System.Web.UI.Page
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
        txtCantCuentas.Text = "";
        txtSaldo.Text = "";
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
            double saldo = Convert.ToDouble(txtSaldo.Text);
            int cantCuentas = Convert.ToInt32(txtCantCuentas.Text);

            Debito d = new Debito(nroTarjeta, Cli, fechaVen, personalizada, saldo, cantCuentas);

            LogicaTarjeta.Agregar(d);

            lblError.Text = "Tarjeta generada exitosamente!";

            this.LimpioFormulario();


        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;

        }
    }
}
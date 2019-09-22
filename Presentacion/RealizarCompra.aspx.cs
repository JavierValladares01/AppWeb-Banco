using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesCompartidas;
using Logica;

public partial class RealizarCompra : System.Web.UI.Page
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
        txtNroTarjeta.Text = "";       
        txtImporte.Text = "";
       

    }

         
    protected void btnComprar_Click(object sender, EventArgs e)
    {

        try
        {
            int idCompra = 0;
            int nroTarjeta = Convert.ToInt32(txtNroTarjeta.Text);
            DateTime fechaCompra = Calendario.SelectedDate;
            double importe = Convert.ToDouble(txtImporte.Text);

            Compra c = new Compra(nroTarjeta, idCompra, fechaCompra, importe);

            LogicaCompra.RealizarCompra(c);

            lblError.Text = "Compra realizada exitosamente!";

            this.LimpioFormulario();

        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }



    }
}
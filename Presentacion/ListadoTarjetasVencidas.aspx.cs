using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesCompartidas;
using Logica;

public partial class ListadoTarjetasVencidas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
 
    }

    protected void btnCredito_Click(object sender, EventArgs e)
    {
        try
        {
            lbTarjetasVencidas.Items.Clear();
            List<Tarjeta> oTarjetasVencidas = LogicaTarjeta.ListadoTarjetasCreditoVencidas();

            for (int i = 0; i < oTarjetasVencidas.Count; i++)
            {
                lbTarjetasVencidas.Items.Add(oTarjetasVencidas[i].ToString());
            }

        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }

    protected void btnDebito_Click(object sender, EventArgs e)
    {

        lbTarjetasVencidas.Items.Clear();
        List<Tarjeta> oTarjetasVencidas = LogicaTarjeta.ListadoTarjetasDebitoVencidas();

        for (int i = 0; i < oTarjetasVencidas.Count; i++)
        {
            lbTarjetasVencidas.Items.Add(oTarjetasVencidas[i].ToString());
        }
    }

    protected void btnTodas_Click(object sender, EventArgs e)
    {
        try
        {
            lbTarjetasVencidas.Items.Clear();
            List<Tarjeta> otarjetast = LogicaTarjeta.ListadoTarjetasVencidas();

            for (int i = 0; i < otarjetast.Count; i++)
            {
                lbTarjetasVencidas.Items.Add(otarjetast[i].ToString());
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
}
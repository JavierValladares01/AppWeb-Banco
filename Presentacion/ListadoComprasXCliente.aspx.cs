using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesCompartidas;
using Logica;

public partial class ListadoComprasXCliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<Cliente> oClientes = LogicaCliente.ListarClientes();

            if (oClientes.Count > 0)
            {
                ddlClientes.DataSource = oClientes;
                ddlClientes.DataTextField = "DatosCliente";
                ddlClientes.DataValueField = "Cedula";
                ddlClientes.DataBind();
            }
        }

    }



    protected void btnListar_Click(object sender, EventArgs e)
    {
        List<Compra> ocompra = LogicaCompra.ListadoComprasXCliente(Convert.ToInt32(ddlClientes.Text));
        GVCompras.DataSource = ocompra;
        GVCompras.DataBind();
    }
}
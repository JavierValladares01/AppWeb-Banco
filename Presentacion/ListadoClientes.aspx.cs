using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesCompartidas;
using Logica;
using System.Drawing;


public partial class ListadoClientes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
          


            //cargo dos listas en la session para trabajar
            Session["_listaC"] = LogicaCliente.ListarClientes();
            Session["_listaS"] = new List<Tarjeta>();

            //cargo las dos grillas
            GridView1.DataSource = (List<Cliente>)Session["_listaC"];
            GridView1.DataBind();

            GridView2.DataSource = (List<Tarjeta>)Session["_listaS"];
            GridView2.DataBind();

            

        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

        GridViewRow r = GridView1.SelectedRow;
        r.BackColor = Color.DeepSkyBlue;

        List<Tarjeta> _listaS = (List<Tarjeta>)Session["_listaS"];
        

        int CI = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);
        _listaS = LogicaTarjeta.ListadoTarjetasCliente(CI);


        GridView2.DataSource = _listaS;
        GridView2.DataBind();

        

    }
}  


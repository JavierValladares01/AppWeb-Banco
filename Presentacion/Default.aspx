<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
        .auto-style2 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>
            <em>
            <asp:Label ID="Label1" runat="server" Text="Pagina Principal" CssClass="auto-style2"></asp:Label>
            </em>
            <br />
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/ABMCliente.aspx">Mantenimiento Clientes</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/AgregarTarjetaCredito.aspx">Solicitar Tarjeta de Credito</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/AgregarTarjetaDebito.aspx">Solicitar Tarjeta de Debito</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton4" runat="server" PostBackUrl="~/RealizarCompra.aspx">Realizar Compra</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton7" runat="server" PostBackUrl="~/ListadoClientes.aspx">Listado de Clientes</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton6" runat="server" PostBackUrl="~/ListadoComprasXCliente.aspx">Listado de Compras por Cliente</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton5" runat="server" PostBackUrl="~/ListadoTarjetasVencidas.aspx">Listado de Tarjetas Vencidas</asp:LinkButton>
            <br />
            <br />
            <br />
            <br />
            <br />
            </strong>
        </div>
    </form>
</body>
</html>

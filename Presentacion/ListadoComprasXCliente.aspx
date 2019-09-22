<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListadoComprasXCliente.aspx.cs" Inherits="ListadoComprasXCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 334px;
        }
        .auto-style2 {
            height: 364px;
        }
        .auto-style3 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
            <span class="auto-style1"><strong><em><span class="auto-style3">Listado de compras por cliente</span><br />
            </em></strong></span>
            <br />
            <br />
            <asp:DropDownList ID="ddlClientes" runat="server" Height="23px" Width="196px">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:GridView ID="GVCompras" runat="server">
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="btnListar" runat="server" Height="26px" OnClick="btnListar_Click" Text="Listar" />
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Default.aspx">Volver</asp:LinkButton>
            <br />
        </div>
    </form>
</body>
</html>

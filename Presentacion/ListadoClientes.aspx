<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListadoClientes.aspx.cs" Inherits="ListadoClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 308px;
        }
        .auto-style2 {
            width: 63%;
            height: 358px;
        }
        .auto-style3 {
            width: 270px;
        }
        .auto-style4 {
            width: 98px;
        }
        .auto-style5 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
            <span class="auto-style1"><strong><em><span class="auto-style3"><span class="auto-style5">Listado de clientes y
            <br />
            tarjetas&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span></em></strong></span>
        <br />
        <br />
        <br />
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">
                    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td>
                    <br />
                    <asp:GridView ID="GridView2" runat="server">
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Default.aspx">Volver</asp:LinkButton>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <p class="auto-style1">
            &nbsp;</p>
        <div>
        </div>
    </form>
</body>
</html>

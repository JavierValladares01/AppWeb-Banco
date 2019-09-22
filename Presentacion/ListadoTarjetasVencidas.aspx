<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListadoTarjetasVencidas.aspx.cs" Inherits="ListadoTarjetasVencidas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
        .auto-style2 {
            width: 18%;
            height: 320px;
        }
        .auto-style3 {
            width: 85%;
            height: 253px;
        }
        .auto-style4 {
            width: 332px;
            height: 85px;
        }
        .auto-style5 {
            text-align: center;
            height: 256px;
            width: 772px;
        }
        .auto-style6 {
            width: 332px;
            height: 84px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span class="auto-style1"><strong><em>Listado de tarjetas vencidas</em></strong></span><br />
            <br />
            <br />
            <table class="auto-style3">
                <tr>
                    <td class="auto-style6">
                        <asp:Button ID="btnDebito" runat="server" Height="33px" Text="Debito" Width="80px" OnClick="btnDebito_Click" />
                    </td>
                    <td rowspan="3" class="auto-style5">
                        <asp:ListBox ID="lbTarjetasVencidas" runat="server" Height="164px" Width="736px"></asp:ListBox>
                        <br />
                        <br />
                        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Button ID="btnCredito" runat="server" Height="33px" Text="Credito" Width="77px" OnClick="btnCredito_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Button ID="btnTodas" runat="server" Height="29px" Text="Todas" Width="77px" OnClick="btnTodas_Click" />
                        <br />
                        <br />
                        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Default.aspx">Volver</asp:LinkButton>
                        <br />
                    </td>
                </tr>
            </table>
            <table class="auto-style2">
            </table>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>

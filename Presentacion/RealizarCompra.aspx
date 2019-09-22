<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RealizarCompra.aspx.cs" Inherits="RealizarCompra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style3 {
            width: 104px;
        }
        .auto-style2 {
            text-align: center;
            width: 162px;
        }
        .auto-style4 {
            width: 162px;
        }
        

        .auto-style1 {
            width: 43%;
            height: 413px;
        }
        .auto-style6 {
            text-align: center;
            width: 162px;
            font-size: large;
        }
        .auto-style7 {
            width: 104px;
            height: 36px;
        }
        .auto-style8 {
            width: 162px;
            height: 36px;
        }
        .auto-style9 {
            height: 36px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style6"><strong><em>Realizar
                        <br />
                        compra</em></strong></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Nro. Tarjeta</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtNroTarjeta" runat="server" Width="142px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNroTarjeta" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Fecha de compra:</td>
                    <td class="auto-style4">
                        <asp:Calendar ID="Calendario" runat="server" VisibleDate="2019-08-21"></asp:Calendar>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Importe:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtImporte" runat="server" Width="141px" Height="22px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtImporte" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style9">
                        <asp:Button ID="btnComprar" runat="server" OnClick="btnComprar_Click" Text="Comprar" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <p>
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Default.aspx" CausesValidation="False">Volver</asp:LinkButton>
        </p>
            <br />
        </div>
    </form>
</body>
</html>

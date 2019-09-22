<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AgregarTarjetaDebito.aspx.cs" Inherits="AgregarTarjetaDebito" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">


        .auto-style1 {
            width: 45%;
            height: 413px;
        }
        .auto-style3 {
            width: 104px;
        }
        .auto-style2 {
            text-align: center;
            width: 168px;
        }
        .auto-style5 {
            font-size: large;
        }
        .auto-style4 {
            width: 168px;
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
                    <td class="auto-style2"><strong><em><span class="auto-style5">Solicitar tarjeta</span><br class="auto-style5" />
                        <span class="auto-style5">&nbsp;de debito</span></em></strong></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Cedula</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtCI" runat="server" Width="142px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCI" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Fecha de vencimiento</td>
                    <td class="auto-style4">
                        <asp:Calendar ID="Calendario" runat="server" VisibleDate="2021-01-01"></asp:Calendar>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Personalizada?</td>
                    <td class="auto-style4">
                        <asp:CheckBox ID="chkProtegida" runat="server" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Saldo</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtSaldo" runat="server" Width="144px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSaldo" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Cant. cuentas asociaciadas</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtCantCuentas" runat="server" Width="143px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCantCuentas" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Solicitar!" />
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
        </div>
    </form>
</body>
</html>

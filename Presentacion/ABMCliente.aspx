<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ABMCliente.aspx.cs" Inherits="ABMCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">


        .auto-style1 {
            width: 472px;
            height: 211px;
        }
        .auto-style13 {
            height: 26px;
            text-align: left;
        }
        .auto-style11 {
            height: 44px;
            text-align: left;
        }
        .auto-style7 {
            width: 124px;
            height: 77px;
        }
        .auto-style16 {
            margin-left: 360px;
            width: 243px;
        }
        .auto-style17 {
            width: 34px;
            text-align: left;
        }
        .auto-style19 {
            width: 187px;
            height: 26px;
        }
        .auto-style20 {
            width: 187px;
            height: 44px;
        }
        .auto-style22 {
            width: 124px;
            height: 26px;
        }
        .auto-style23 {
            width: 124px;
            height: 44px;
            text-align: left;
        }
        .auto-style24 {
            width: 187px;
        }
        .auto-style25 {
            width: 124px;
        }
        .auto-style26 {
            text-align: left;
        }
        .auto-style27 {
            width: 124px;
            text-align: left;
            height: 26px;
        }
        .auto-style28 {
            font-size: large;
        }
        .auto-style29 {
            height: 386px;
        }
        .auto-style30 {
            width: 124px;
            height: 23px;
        }
    </style>
</head>
<body style="height: 397px">
    <form id="form1" runat="server" class="auto-style29">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em><strong>
            <asp:Label ID="Label1" runat="server" Text="Mantenimiento de Clientes" CssClass="auto-style28"></asp:Label>
            </strong></em>
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td colspan="2" class="auto-style26">Cédula:</td>
                    <td class="auto-style24">
                        <asp:TextBox ID="txtCI" runat="server" Width="166px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCI" ErrorMessage="*" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style25">
                        <asp:Button ID="BtnBuscar" runat="server" OnClick="BtnBuscar_Click" Text="Buscar" Width="121px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13" colspan="2">Nombre:</td>
                    <td class="auto-style19">
                        <asp:TextBox ID="txtNombre" runat="server" Width="167px"></asp:TextBox>
                    </td>
                    <td class="auto-style22"></td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style13">Apellido:</td>
                    <td class="auto-style19">
                        <asp:TextBox ID="txtApellido" runat="server" Width="168px"></asp:TextBox>
                    </td>
                    <td class="auto-style27"></td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="2">Teléfono:</td>
                    <td class="auto-style20">
                        <asp:TextBox ID="txtTelefono" runat="server" Width="109px"></asp:TextBox>
                    </td>
                    <td class="auto-style23">&nbsp;</td>
                </tr>
                <tr>
                    <td rowspan="2" class="auto-style17">&nbsp;</td>
                    <td colspan="2" rowspan="2" class="auto-style26">&nbsp;
                        <asp:Button ID="BtnAgregar" runat="server" Height="30px" OnClick="BtnAgregar_Click" Text="Agregar" Width="79px" />
                        <asp:Button ID="BtnModificar" runat="server" Height="30px" OnClick="BtnModificar_Click" Text="Modificar" Width="79px" />
                        &nbsp;<br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="BtnEliminar" runat="server" CssClass="auto-style12" Height="26px" OnClick="BtnEliminar_Click" Text="Eliminar" Width="88px" />
                    </td>
                    <td class="auto-style30"></td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="BtnLimpiar" runat="server" OnClick="BtnLimpiar_Click" Text="Limpiar" CausesValidation="False" />
                    </td>
                </tr>
            </table>
        </div>
            <div class="auto-style16">
                <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
                <br />
                <br />
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Default.aspx" CausesValidation="False">Volver</asp:LinkButton>
            </div>
    </form>
</body>
</html>

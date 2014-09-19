<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmPersonas.aspx.cs" Inherits="aspSMTutorial.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <hr />
    <table class="nav-justified">
        <tr>
            <td style="width: 158px; height: 30px;">Cedula:</td>
            <td style="width: 216px; height: 30px">
                <asp:TextBox ID="txtCedula" runat="server" Width="188px"></asp:TextBox>
            </td>
            <td style="height: 30px">
                <%--<asp:RequiredFieldValidator ID="rfvCedula" runat="server" ErrorMessage="Debe ingresar la cédula"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td style="width: 158px; height: 30px;">Nombre:</td>
            <td style="width: 216px; height: 30px">
                <asp:TextBox ID="txtNombre" runat="server" Width="188px"></asp:TextBox>
            </td>
            <td style="height: 30px">
                <%--<asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="Debe ingresar el nombre"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td style="width: 158px; height: 30px;">Apellido:</td>
            <td style="width: 216px; height: 30px">
                <asp:TextBox ID="txtApellido" runat="server" Width="188px"></asp:TextBox>
            </td>
            <td style="height: 30px">
                <%--<asp:RequiredFieldValidator ID="rfvApellido" runat="server" ErrorMessage="Debe ingresar el apellido"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td style="width: 158px; height: 30px;">Fecha Nacimiento:</td>
            <td style="width: 216px; height: 30px">
                <asp:TextBox ID="txtFechaNacimiento" runat="server" Width="188px"></asp:TextBox>
            </td>
            <td style="height: 30px">
                <%--<asp:RequiredFieldValidator ID="rfvFecha" runat="server" ErrorMessage="Debe ingresar la fecha en que nació"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td style="width: 158px; height: 30px;">Edad:</td>
            <td style="width: 216px; height: 30px">
                <asp:TextBox ID="txtEdad" runat="server" Width="188px"></asp:TextBox>
            </td>
            <td style="height: 30px">
                <%--<asp:RequiredFieldValidator ID="rfvEdad" runat="server" ErrorMessage="Debe ingresar su edad"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td style="width: 158px; height: 30px;">Dirección:</td>
            <td style="width: 216px; height: 30px">
                <asp:TextBox ID="txtDireccion" runat="server" Width="188px"></asp:TextBox>
            </td>
            <td style="height: 30px">
                <%--<asp:RequiredFieldValidator ID="rfv" runat="server" ErrorMessage="Debe ingresar la dirección"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
    </table>
    <br />
    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
    <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
    <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
    <br />
    <asp:Label ID="lblMensaje" runat="server" Font-Bold="True" ForeColor="#0066FF"></asp:Label>
    <br />
    <br />
    <asp:GridView ID="dgvPersonas" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
</asp:Content>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebAppActualizar1.aspx.cs" Inherits="AppParcial.WebAppActualizar1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 662px">
    
        <asp:Label ID="lblCedula" runat="server" Text="CEDULA"></asp:Label>
        <asp:TextBox ID="txtCedula" runat="server" style="margin-left: 95px"></asp:TextBox>
        <asp:Button ID="btnBUSCAR" runat="server" Height="34px" OnClick="btnBUSCAR_Click" style="margin-left: 201px" Text="BUSCAR" Width="92px" />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <asp:Label ID="lblcedula1" runat="server" Text="cedula"></asp:Label>
        <asp:TextBox ID="txtcedula1" runat="server" style="margin-left: 28px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblnombre1" runat="server" Text="nombre"></asp:Label>
        <asp:TextBox ID="txtnombre1" runat="server" style="margin-left: 26px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblapellido1" runat="server" Text="apellido"></asp:Label>
        <asp:TextBox ID="txtapellido1" runat="server" style="margin-left: 26px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblemail1" runat="server" Text="email"></asp:Label>
        <asp:TextBox ID="txtemail1" runat="server" style="margin-left: 45px" Width="132px"></asp:TextBox>
        <asp:Button ID="btnActualizar" runat="server" OnClick="Button1_Click" style="margin-left: 238px" Text="ACTUALIZAR" Width="245px" />
        <br />
        <br />
        <asp:Label ID="lbldomicilio1" runat="server" Text="domicilio"></asp:Label>
        <asp:TextBox ID="txtdomicilio1" runat="server" style="margin-left: 24px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblciudad1" runat="server" Text="ciudad"></asp:Label>
        <asp:TextBox ID="txtciudad1" runat="server" style="margin-left: 36px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lbltelefono1" runat="server" Text="telefono"></asp:Label>
        <asp:TextBox ID="txttelefono1" runat="server" style="margin-left: 31px"></asp:TextBox>
        <br />
    
    </div>
    </form>
</body>
</html>

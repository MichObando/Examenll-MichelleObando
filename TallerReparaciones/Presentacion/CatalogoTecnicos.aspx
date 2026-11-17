<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoTecnicos.aspx.cs" Inherits="TallerReparaciones.Presentacion.CatalogoTecnicos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Catálogo de Técnicos</title>
    <link rel="stylesheet" type="text/css" href="../css/Estilo.css" />
</head>
<body>
    <form id="form1" runat="server">
        <ul class="menu">
            <li class="titulo">Taller de Reparaciones</li>
            <li><a href="Menu.aspx">Inicio</a></li>
            <li><a href="CatalogoUsuarios.aspx">Usuarios</a></li>
            <li><a class="active" href="CatalogoTecnicos.aspx">Técnicos</a></li>
        </ul>

        <div class="contenedor">
            <div class="tarjeta">
                <h2>Catálogo de Técnicos</h2>
                <asp:GridView ID="gvTecnicos" runat="server" CssClass="tabla" GridLines="None"></asp:GridView>
            </div>

            <div class="tarjeta">
                <h3>Datos del técnico</h3>
                <p class="nota">Para modificar o borrar, escriba el ID del técnico.</p>

                <div class="campo">
                    <label>ID:</label>
                    <asp:TextBox ID="txtTecnicoID" runat="server" placeholder="Ej: 1"></asp:TextBox>
                </div>
                <div class="campo">
                    <label>Nombre:</label>
                    <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre completo"></asp:TextBox>
                </div>
                <div class="campo">
                    <label>Especialidad:</label>
                    <asp:TextBox ID="txtEspecialidad" runat="server" placeholder="Ej: Laptops, Impresoras"></asp:TextBox>
                </div>

                <div class="botones">
                    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="boton boton-agregar" OnClick="btnAgregar_Click" />
                    <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="boton boton-modificar" OnClick="btnModificar_Click" />
                    <asp:Button ID="btnBorrar" runat="server" Text="Borrar" CssClass="boton boton-borrar" OnClick="btnBorrar_Click" />
                </div>

                <asp:Label ID="lblMensaje" runat="server" Text="" CssClass="mensaje"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="TallerReparaciones.Presentacion.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Taller de Reparaciones</title>
    <link rel="stylesheet" type="text/css" href="../css/Estilo.css" />
</head>
<body>
    <form id="form1" runat="server">
        <ul class="menu">
            <li class="titulo">Taller de Reparaciones</li>
            <li><a class="active" href="Menu.aspx">Inicio</a></li>
            <li><a href="CatalogoUsuarios.aspx">Usuarios</a></li>
            <li><a href="CatalogoTecnicos.aspx">Técnicos</a></li>
        </ul>

        <div class="contenedor">
            <div class="tarjeta">
                <h2>Bienvenido</h2>
                <p>Sistema para administrar los usuarios y técnicos del taller. Seleccione una opción:</p>
            </div>

            <div class="opciones">
                <a class="opcion" href="CatalogoUsuarios.aspx">
                    <h3>Usuarios</h3>
                    <p>Agregar, modificar y borrar los clientes que traen equipos al taller.</p>
                </a>
                <a class="opcion" href="CatalogoTecnicos.aspx">
                    <h3>Técnicos</h3>
                    <p>Agregar, modificar y borrar los técnicos y su especialidad.</p>
                </a>
            </div>
        </div>
    </form>
</body>
</html>

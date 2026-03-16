<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="BibliotecaMVC.Views.vistasBiblioteca.Consultaraspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Consultar Libros</h2> <!-- Encabezado -->

    <!-- Campo de filtro por código o título -->
    <asp:Label runat="server" AssociatedControlID="txtFiltro" Text="Filtrar por código o título:" />
    <asp:TextBox ID="txtFiltro" runat="server" />

    <asp:Button ID="btnBuscar" runat="server" Text="Buscar"
        OnClick="btnBuscar_Click" CssClass="btn" />
    <asp:Button ID="btnRefrescar" runat="server" Text="Ver todos"
        OnClick="btnRefrescar_Click" CssClass="btn" />

    <br /><br />


    <asp:GridView ID="gvLibros" runat="server" AutoGenerateColumns="false"
    <asp:GridView ID="gvLibros" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Codigo" HeaderText="Código" />
            <asp:BoundField DataField="Titulo" HeaderText="Título" />
            <asp:BoundField DataField="Autor" HeaderText="Autor" />
            <asp:BoundField DataField="FechaPublicacion" HeaderText="Fecha Publicación" DataFormatString="{0:yyyy-MM-dd}" />
        </Columns>
    </asp:GridView>
</asp:Content>
           

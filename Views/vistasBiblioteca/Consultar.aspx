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
    OnRowCommand="gvLibros_RowCommand" DataKeyNames="Codigo">
    <Columns>
        <asp:BoundField DataField="Codigo" HeaderText="Código" />
        <asp:BoundField DataField="Titulo" HeaderText="Título" />
        <asp:BoundField DataField="Editorial" HeaderText="Editorial" />

        
        <asp:TemplateField HeaderText="Acciones">
            <ItemTemplate>
                <!-- Botón Ver Detalles -->
                <asp:Button ID="btnVerDetalles" runat="server" Text="Ver detalles"
                    CommandName="Ver"
                    CommandArgument='<%# Container.DataItemIndex %>' />

                <!-- Botón Eliminar -->
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar"
                    CommandName="Eliminar"
                    CommandArgument='<%# Container.DataItemIndex %>'
                    OnClientClick="return confirm('¿Seguro que deseas eliminar este libro?');" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>


</asp:Content>
           

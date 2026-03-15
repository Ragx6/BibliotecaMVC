<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="BibliotecaMVC.Views.vistasBiblioteca.Registrar" %>
<%@ Register Assembly="System.Web" Namespace="System.Web.UI.WebControls" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <h2>Registrar Libro</h2>

    <asp:Label runat="server" AssociatedControlID="txtCodigo" Text="Código:" />
    <br />
    <asp:TextBox ID="txtCodigo" runat="server" />
    <br />

    <asp:Label runat="server" AssociatedControlID="txtTitulo" Text="Título:" />
    <br />
    <asp:TextBox ID="txtTitulo" runat="server" />
    <br />

    <asp:Label runat="server" AssociatedControlID="txtAutor" Text="Autor:" />
    <br />
    <asp:TextBox ID="txtAutor" runat="server" />
    <br />


    <asp:Label runat="server" AssociatedControlID="txtFecha" Text="Fecha publicación (yyyy-mm-dd):" />
    <br />
    <asp:TextBox ID="txtFecha" runat="server" />

    <br />
    <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" CssClass="btn" />

    <br /><br />
    <asp:Label ID="lblMensaje" runat="server" />


</asp:Content>

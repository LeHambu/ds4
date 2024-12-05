<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BibliotecaWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Biblioteca Web</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1 class="mt-4 mb-4">Biblioteca Web</h1>
            
            <asp:Label ID="lblMensaje" runat="server" CssClass="alert" Visible="false"></asp:Label>

            <div class="row mb-3">
                <div class="col">
                    <asp:TextBox ID="txtBusqueda" runat="server" CssClass="form-control" placeholder="Buscar libros..."></asp:TextBox>
                </div>
                <div class="col-auto">
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="btnBuscar_Click" />
                </div>
            </div>

            <asp:Panel ID="pnlResultadosBusqueda" runat="server" Visible="false">
                <h2 class="mt-4 mb-3">Resultados de la búsqueda</h2>
                <asp:Label ID="lblResultados" runat="server" CssClass="mb-3 d-block"></asp:Label>
                <asp:GridView ID="gvResultadosBusqueda" runat="server" CssClass="table table-striped" AutoGenerateColumns="False" DataKeyNames="ID">
                    <Columns>
                        <asp:BoundField DataField="Titulo" HeaderText="Título" />
                        <asp:BoundField DataField="Autor" HeaderText="Autor" />
                        <asp:BoundField DataField="ISBN" HeaderText="ISBN" />
                        <asp:CheckBoxField DataField="Disponible" HeaderText="Disponible" />
                    </Columns>
                </asp:GridView>
            </asp:Panel>

            <h2 class="mt-5 mb-3">Agregar/Editar Libro</h2>
            <asp:HiddenField ID="hfLibroID" runat="server" />
            <div class="card">
                <div class="card-body">
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtTitulo">Título:</asp:Label>
                        <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtAutor">Autor:</asp:Label>
                        <asp:TextBox ID="txtAutor" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtISBN">ISBN:</asp:Label>
                        <asp:TextBox ID="txtISBN" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:CheckBox ID="chkDisponible" runat="server" Text="Disponible" />
                    </div>
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="btnGuardar_Click" />
                </div>
            </div>

            <h2 class="mt-5 mb-3">Registro Total de la Biblioteca</h2>
            <asp:GridView ID="gvTodosLosLibros" runat="server" 
        CssClass="table table-striped" 
        AutoGenerateColumns="False" 
        DataKeyNames="ID" 
        OnRowCommand="gvTodosLosLibros_RowCommand"
        AllowPaging="True"
        PageSize="10"
        OnPageIndexChanging="gvTodosLosLibros_PageIndexChanging"><Columns>

                    <asp:BoundField DataField="Titulo" HeaderText="Título" />
                    <asp:BoundField DataField="Autor" HeaderText="Autor" />
                    <asp:BoundField DataField="ISBN" HeaderText="ISBN" />
                    <asp:CheckBoxField DataField="Disponible" HeaderText="Disponible" />
                    <asp:ButtonField CommandName="Editar" Text="Editar" ButtonType="Button" ControlStyle-CssClass="btn btn-sm btn-warning" />
                    <asp:ButtonField CommandName="Eliminar" Text="Eliminar" ButtonType="Button" ControlStyle-CssClass="btn btn-sm btn-danger" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.3/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</body>
</html>


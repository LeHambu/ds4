<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Api_Calculadora._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">API Calculadora</h1>
            <p class="lead">Esta es una aplicación de ejemplo que muestra los datos de la API de Calculadora.</p>
        </section>

        <div class="row">
            <section class="col-md-12" aria-labelledby="apiDataTitle">
                <h2 id="apiDataTitle">Datos de la API</h2>
                <p>
                    Haga clic en el botón para obtener todos los datos de la API de Calculadora.
                </p>
                <asp:Button ID="btnGetApiData" runat="server" Text="Obtener Datos de la API" CssClass="btn btn-primary" OnClick="btnGetApiData_Click" />
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:GridView ID="gvApiData" runat="server" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="false">
                            <Columns>
                                <asp:BoundField DataField="Id" HeaderText="ID" />
                                <asp:BoundField DataField="Num1" HeaderText="Número 1" />
                                <asp:BoundField DataField="Operador" HeaderText="Operador" />
                                <asp:BoundField DataField="Num2" HeaderText="Número 2" />
                                <asp:BoundField DataField="Resultado" HeaderText="Resultado" />
                            </Columns>
                        </asp:GridView>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="btnGetApiData" EventName="Click" />
                    </Triggers>
                </asp:UpdatePanel>
            </section>
        </div>
    </main>

</asp:Content>

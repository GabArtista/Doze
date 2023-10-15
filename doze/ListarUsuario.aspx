<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ListarUsuario.aspx.cs" Inherits="ListarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <div class="container">

        <form id="ListaUsuarioForm" runat="server">
            <asp:GridView ID="gdvUsuarios" AutoGenerateColumns="false" runat="server" CssClass="table table-hover MyTable" Visible="false">

                
                <Columns>
                    <asp:BoundField DataField ="IDUsu" HeaderText="#" />
                    <asp:BoundField DataField="NomeUsu" HeaderText="Nome" />
                    <asp:BoundField DataField="EmailUsu" HeaderText="E-mail" />
                    <asp:BoundField DataField="TelefoneUsu" HeaderText="Telefone" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <!-- Modificações css durante a empressão da tabela -->
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>


            </asp:GridView> 
            <br />
            <asp:Label ID="lblMsg" runat="server"></asp:Label>

            



           


            <div class="row" style="text-align: center;">

                <h3>Usuarios</h3>
            </div>

            <!-- Solicitação -->

            <div class="list-group">

                <!-- Solicitação 1 -->

                <div type="button" class="list-group-item list-group-item-action" style="padding: 30px;">

                    <div class="card-body">
                        <h5 class="card-title">01</h5>
                        <h6>Gabriel Willian</h6>
                        <h6 class="card-subtitle mb-2 text-body-secondary">Gabrielw.dev@gmail.com</h6>
                        <h6 class="card-subtitle mb-2 text-body-secondary">(12)99856-9613</h6>
                        <h6 class="card-subtitle mb-2 text-body-secondary">ADM</h6>
                        <h6 class="card-subtitle mb-2 text-body-secondary">Cadastrado Dia: 01/05/1999</h6>
                    </div>
                    <!-- Status -->
                    <div class="spinner-grow text-success" role="status">
                    </div>
                    <h6 class="card-subtitle mb-2 text-body-secondary">Online</h6>

                    <asp:LinkButton ID="btnEditar" type="button" CssClass="btn btn-light  " OnClick="btnEditar_Click" runat="server">
                        <i class="fas fa-file"></i>Editar
                    </asp:LinkButton>

                </div>

                <!-- Solicitação 2 -->

                <div type="button" class="list-group-item list-group-item-action" style="padding: 30px;">

                    <div class="card-body">
                        <h5 class="card-title">02</h5>
                        <h6>Mathias</h6>
                        <h6 class="card-subtitle mb-2 text-body-secondary">Ma.Mathias@gmail.com</h6>
                        <h6 class="card-subtitle mb-2 text-body-secondary">(12)99856-9613</h6>
                        <h6 class="card-subtitle mb-2 text-body-secondary">Cliente</h6>
                        <h6 class="card-subtitle mb-2 text-body-secondary">Cadastrado Dia: 05/04/2024</h6>
                    </div>
                    <!-- Status -->
                    <div class="spinner-grow text-success" role="status">
                    </div>
                    <h6 class="card-subtitle mb-2 text-body-secondary">Online</h6>

                    <asp:LinkButton ID="LinkButton1" type="button" CssClass="btn btn-light  " OnClick="btnEditar_Click" runat="server">
                        <i class="fas fa-file"></i>Editar
                    </asp:LinkButton>

                </div>

                <!-- Solicitação 3 -->

                <div type="button" class="list-group-item list-group-item-action" style="padding: 30px;">

                    <div class="card-body">
                        <h5 class="card-title">01</h5>
                        <h6>Bianca Mello</h6>
                        <h6 class="card-subtitle mb-2 text-body-secondary">Bibica@gmail.com</h6>
                        <h6 class="card-subtitle mb-2 text-body-secondary">(12)99856-9613</h6>
                        <h6 class="card-subtitle mb-2 text-body-secondary">ADM</h6>
                        <h6 class="card-subtitle mb-2 text-body-secondary">Cadastrado Dia: 07/03/2001</h6>
                    </div>

                    <!-- Status -->
                    <div class="spinner-grow text-danger" role="status">
                    </div>
                    <h6 class="card-subtitle mb-2 text-body-secondary">Offline</h6>

                    <asp:LinkButton ID="LinkButton2" type="button" CssClass="btn btn-light  " OnClick="btnEditar_Click" runat="server">
                        <i class="fas fa-file"></i>Editar
                    </asp:LinkButton>

                </div>

            </div>
            <!-- Botão -->
            <div class="row">
                <asp:LinkButton ID="btnCriar" runat="server" OnClick="btnCriar_Click" class="btn-floating btn-large waves-effect waves-light red"><i class="fas fa-plus"></i></asp:LinkButton>
            </div>
            <div class="row">
                <div class="col">
                    <asp:Button ID="btnVoltar" Text="Voltar" runat="server" OnClick="btnVoltar_Click" CssClass="btn btn-outline-danger" />
                </div>
            </div>
        </form>


    </div>

</asp:Content>

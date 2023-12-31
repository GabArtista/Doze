﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ListarUsuario.aspx.cs" Inherits="ListarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <div class="container">

        <form id="ListaUsuarioForm" runat="server">

            <asp:GridView ID="gdvUsuarios" runat="server" AutoGenerateColumns="false" CssClass="table table-hover MyTable" Visible="false" OnRowDataBound="gdvUsuarios_RowDataBound" OnRowCommand="gdvUsuarios_RowCommand">


                <Columns>

                    <asp:BoundField DataField="IDUSU" HeaderText="#" />
                    <asp:BoundField DataField="NomeUsu" HeaderText="E-Mail" />
                    <asp:BoundField DataField="EmailUsu" HeaderText="Ativo" />
                    <asp:BoundField DataField="SenhaUsu" HeaderText="Ativo" />
                    <asp:BoundField DataField="TipoUsu" HeaderText="Ativo" />
                    <asp:BoundField DataField="StatusConexaoUsu" HeaderText="Ativo" />
                    <asp:BoundField DataField="StatusAtivacaoUsu" HeaderText="Ativo" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <!-- Modificações css durante a empressão da tabela -->
                            <asp:LinkButton CommandArgument='<%# Bind("IDUsu") %>' ID="lkb_ativar" CssClass="btn btn-default" runat="server"></asp:LinkButton>

                            <asp:LinkButton CommandArgument='<%# Bind("IDUsu") %>' ID="lkb_editar" CommandName="Encaminhar" Text="<i class='fa fa-edit text-danger'> </i>" CssClass="btn btn-default" runat="server"></asp:LinkButton>


                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:Label ID="lblMsg" runat="server"></asp:Label>

            <table class="table table-hover">
                <thead>
                    <tr>
                        <th>Cogido
                        </th>

                        <th>Email
                        </th>

                        <th>Telefone
                        </th>
                    </tr>

                </thead>

                <tbody>
                    <asp:Literal ID="lblLinhas" runat="server"></asp:Literal>
                </tbody>
            </table>



            <div class="row">
                <asp:Repeater ID="rptUsuarios" runat="server">
                    <ItemTemplate>
                        <div class="col-xs-12 col-md-6 col-lg-3 col-6">
                            <div class="small-box bg-warning">
                                <div class="inner">
                                    <h3><%# Eval("NomeUsu") %></h3>
                                </div>
                                <div class="icon">
                                    <i class="fas fa-user-plus"></i>
                                </div>
                                <a href="#" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i>
                                </a>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>


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

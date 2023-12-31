<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ListarServico.aspx.cs" Inherits="ListarServico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <div class="container">

        <form id="ListaServicoForm" runat="server">

            <div class="row" style="text-align: center;">

                <h3>Serviços</h3>
            </div>

            <!-- Solicitação -->
            <br />
            <br />
            <br />
            <asp:GridView ID="gdvServicos" runat="server" AutoGenerateColumns="false" CssClass="table table-hover MyTable" Visible="false" OnRowDataBound="gdvServicos_RowDataBound" OnRowCommand="gdvServicos_RowCommand" >


                <Columns>

                    <asp:BoundField DataField="IDSvc" HeaderText="#" />
                    <asp:BoundField DataField="NomeSvc" HeaderText="Nome" />
                    <asp:BoundField DataField="PrecoSvc" HeaderText="Preço" />
                    <asp:BoundField DataField="ObservacaoSvc" HeaderText="Observação" />
                    <asp:BoundField DataField="StatusAtivacaoSvc" HeaderText="Ativo" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <!-- Modificações css durante a empressão da tabela -->
                            <asp:LinkButton CommandArgument='<%# Bind("IDSvc") %>' ID="lkb_ativar" CssClass="btn btn-default" runat="server"></asp:LinkButton>

                            <asp:LinkButton CommandArgument='<%# Bind("IDSvc") %>' ID="lkb_editar" CommandName="Encaminhar" Text="<i class='fa fa-edit text-danger'> </i>" CssClass="btn btn-default" runat="server"></asp:LinkButton>


                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <br />
            <br />
            <asp:Label ID="lblMsg" runat="server"></asp:Label>

            <div class="list-group">

                <!-- Solicitação 1 -->

                <div type="button" class="list-group-item list-group-item-action" style="padding: 30px;">

                    <div class="col">
                        <div class="card-body">
                            <h5 class="card-title">01</h5>
                            <h6>SEO do Gabriel Willian</h6>
                            <h6 class="card-subtitle mb-2 text-body-secondary">R$200,00</h6>
                        </div>
                        <div class="spinner-grow text-success" role="status">
                        </div>

                    </div>

                    <div class="col">
                        <div class="card" style="width: auto;">
                            <div class="card-body">

                                <h6>SEO's da empresa ficaram sob cuidado de Gabriel Willian</h6>

                            </div>
                        </div>
                    </div>

                    <asp:LinkButton ID="btnEditar" type="button" CssClass="btn btn-light  " OnClick="btnEditar_Click" runat="server">
                        <i class="fas fa-file"></i>Editar
                    </asp:LinkButton>

                </div>

                <!-- Solicitação 2 -->

                <div type="button" class="list-group-item list-group-item-action" style="padding: 30px;">

                    <div class="col">
                        <div class="card-body">
                            <h5 class="card-title">02</h5>
                            <h6>Design de Publicação do Unoog</h6>
                            <h6 class="card-subtitle mb-2 text-body-secondary">R$100,00</h6>
                        </div>
                        <div class="spinner-grow text-success" role="status">
                        </div>

                    </div>

                    <div class="col">
                        <div class="card" style="width: auto;">
                            <div class="card-body">

                                <h6>Publicações da empresa ficaram sob cuidado de Unoog</h6>

                            </div>
                        </div>
                    </div>

                    <asp:LinkButton ID="LinkButton1" type="button" CssClass="btn btn-light  " OnClick="btnEditar_Click" runat="server">
                        <i class="fas fa-file"></i>Editar
                    </asp:LinkButton>

                </div>

                <!-- Solicitação 3 -->

                <div type="button" class="list-group-item list-group-item-action" style="padding: 30px;">

                    <div class="col">
                        <div class="card-body">
                            <h5 class="card-title">03</h5>
                            <h6>Web Designer de Gabriel Willian</h6>
                            <h6 class="card-subtitle mb-2 text-body-secondary">R$100,00</h6>
                        </div>
                        <div class="spinner-grow text-success" role="status">
                        </div>

                    </div>

                    <div class="col">
                        <div class="card" style="width: auto;">
                            <div class="card-body">

                                <h6>Site da empresa ficaram sob cuidado de Gabriel Willian</h6>

                            </div>
                        </div>
                    </div>

                    <asp:LinkButton ID="LinkButton2" type="button" CssClass="btn btn-light  " OnClick="btnEditar_Click" runat="server">
                        <i class="fas fa-file"></i>Editar
                    </asp:LinkButton>

                </div>

                <!-- Solicitação 4 -->

                <div type="button" class="list-group-item list-group-item-action" style="padding: 30px;">

                    <div class="col">
                        <div class="card-body">
                            <h5 class="card-title">04</h5>
                            <h6>Fotografia do Carlinhos</h6>
                            <h6 class="card-subtitle mb-2 text-body-secondary">R$100,00</h6>
                        </div>
                        <div class="spinner-grow text-success" role="status">
                        </div>

                    </div>

                    <div class="col">
                        <div class="card" style="width: auto;">
                            <div class="card-body">

                                <h6>Fotos da empresa ficaram sob cuidado de Carlinhos</h6>

                            </div>
                        </div>
                    </div>

                    <asp:LinkButton ID="LinkButton3" type="button" CssClass="btn btn-light  " OnClick="btnEditar_Click" runat="server">
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

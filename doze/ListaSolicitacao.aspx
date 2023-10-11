<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ListaSolicitacao.aspx.cs" Inherits="ListaSolicitacao" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">

    <div class="container">

        <form id="ListaSolicitacaoForm" runat="server">

            <div class="row" style="text-align: center;">

                <h3>Solicitações</h3>
            </div>


            <!-- Solicitação -->


            <asp:GridView ID="gdvSolicitacoes" runat="server" CssClass="table table-hover" Visible="false"></asp:GridView>
            <br />
            <asp:Label ID="lblMsg" runat="server"></asp:Label>

            <div class="list-group">

                <!-- Solicitação 1 -->

                <div type="button" class="list-group-item list-group-item-action" style="padding: 30px;">

                    <div class="col">

                        <div class="card-body">
                            <h5 class="card-title">01</h5>
                            <h6>Gabriel Willian</h6>
                            <h6 class="card-subtitle mb-2 text-body-secondary">Gabrielw.dev@gmail.com</h6>
                            <h6 class="card-subtitle mb-2 text-body-secondary">(12)99856-9613</h6>
                        </div>
                        <div class="spinner-grow text-success" role="status">
                        </div>
                        <div class="row col-3">
                            <asp:LinkButton ID="btnEditar" type="button" CssClass="btn btn-light  " OnClick="btnEditar_Click" runat="server">
                                <i class="fas fa-file"></i>Editar
                            </asp:LinkButton>
                        </div>

                    </div>

                    <div class="col">
                        <div class="card" style="width: auto;">
                            <div class="card-body">

                                <h6>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</h6>

                            </div>
                        </div>
                    </div>

                </div>

                <!-- Solicitação 2 -->

                <div type="button" class="list-group-item list-group-item-action" style="padding: 30px;">

                    <div class="col">

                        <div class="card-body">
                            <h5 class="card-title">02</h5>
                            <h6>Mathias</h6>
                            <h6 class="card-subtitle mb-2 text-body-secondary">Ma.Mathias@gmail.com</h6>
                            <h6 class="card-subtitle mb-2 text-body-secondary">(12)99856-9613</h6>
                        </div>
                        <div class="spinner-grow text-warning" role="status">
                        </div>
                        <div class="row col-3">
                            <asp:LinkButton ID="btnEditar2" type="button" CssClass="btn btn-light  " OnClick="btnEditar_Click" runat="server">
                                <i class="fas fa-file"></i>Editar
                            </asp:LinkButton>
                        </div>
                    </div>
                    <div class="col">
                        <div class="card" style="width: auto;">
                            <div class="card-body">

                                <h6>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</h6>

                            </div>
                        </div>
                    </div>

                </div>

                <!-- Solicitação 3 -->

                <div type="button" class="list-group-item list-group-item-action" style="padding: 30px;">

                    <div class="col">

                        <div class="card-body">
                            <h5 class="card-title">01</h5>
                            <h6>Bianca Mello</h6>
                            <h6 class="card-subtitle mb-2 text-body-secondary">Bibica@gmail.com</h6>
                            <h6 class="card-subtitle mb-2 text-body-secondary">(12)99856-9613</h6>
                        </div>
                        <div class="spinner-grow text-danger" role="status">
                        </div>
                        <div class="row col-3">
                            <asp:LinkButton ID="btnEditar3" type="button" CssClass="btn btn-light  " OnClick="btnEditar_Click" runat="server">
                                <i class="fas fa-file"></i>Editar
                            </asp:LinkButton>
                        </div>

                    </div>
                    <div class="col">
                        <div class="card" style="width: auto;">
                            <div class="card-body">

                                <h6>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</h6>

                            </div>
                        </div>
                    </div>

                </div>

            </div>


            <!-- Botão -->

            <asp:Button ID="btnVoltar" Text="Voltar" runat="server" OnClick="btnVoltar_Click" CssClass="btn btn-outline-danger" />


        </form>



    </div>
</asp:Content>

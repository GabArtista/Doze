<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ListarFormaPagamento.aspx.cs" Inherits="ListarFormaPagamento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">

    <div class="container">

        <form id="FormaPagamentoForm" runat="server">

            <div class="row" style="text-align: center;">

                <h3>Formas de Pagamento</h3>
            </div>

            <!-- Solicitação -->

            <div class="list-group">

                <!-- Solicitação 1 -->

                <div class="list-group-item list-group-item-action" style="padding: 30px;">

                    <div class="row">
                        <div class="col">
                            <div class="card-body">
                                <h5 class="card-title">01</h5>
                                <h6>Cartão Debto</h6>

                            </div>
                            <div class="spinner-grow text-success" role="status">
                            </div>
                            <div class="row col-6">
                                <asp:LinkButton ID="btnEditar" type="button" CssClass="btn btn-light  " OnClick="btnEditar_Click" runat="server">
                                    <i class="fas fa-file"></i> Editar
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

                <!-- Solicitação 2 -->

                 <div class="list-group-item list-group-item-action" style="padding: 30px;">

                    <div class="row">
                        <div class="col">
                            <div class="card-body">
                                <h5 class="card-title">01</h5>
                                <h6>Cartão Credito</h6>

                            </div>
                            <div class="spinner-grow text-success" role="status">
                            </div>
                            <div class="row col-6">
                                <asp:LinkButton ID="LinkButton1" type="button" CssClass="btn btn-light  " OnClick="btnEditar_Click" runat="server">
                                    <i class="fas fa-file"></i> Editar
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

                <!-- Solicitação 3 -->

                 <div class="list-group-item list-group-item-action" style="padding: 30px;">

                    <div class="row">
                        <div class="col">
                            <div class="card-body">
                                <h5 class="card-title">01</h5>
                                <h6>Boleto</h6>

                            </div>
                            <div class="spinner-grow text-success" role="status">
                            </div>
                            <div class="row col-6">
                                <asp:LinkButton ID="LinkButton2" type="button" CssClass="btn btn-light  " OnClick="btnEditar_Click" runat="server">
                                    <i class="fas fa-file"></i> Editar
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

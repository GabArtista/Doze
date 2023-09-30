<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ListarContrato.aspx.cs" Inherits="ListarContrato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">

    <div class="container">



        <form id="ListaContratoForm" runat="server">
            <div class="row" style="text-align: center;">

                <h3>Tipo de Contrato</h3>
            </div>

            <!-- Solicitação -->

            <div class="list-group">

                <!-- Solicitação 1 -->

                <div type="button" class="list-group-item list-group-item-action" style="padding: 30px;">

                    <div class="col">
                        <div class="card-body">
                            <h5 class="card-title">01</h5>
                            <h6>Bimestral</h6>

                        </div>
                        <div class="spinner-grow text-success" role="status">
                        </div>

                    </div>

                    <div class="col">
                        <div class="card" style="width: auto;">
                            <div class="card-body">

                                <h6>O investimento e aplicado a cada Bimestre</h6>

                            </div>
                        </div>
                    </div>

                    <div class="row col-6">
                        <asp:LinkButton ID="btnEditar" type="button" CssClass="btn btn-light  " OnClick="btnEditar_Click" runat="server">
                                    <i class="fas fa-file"></i> Editar
                        </asp:LinkButton>
                    </div>

                </div>

                <!-- Solicitação 2 -->

                <div type="button" class="list-group-item list-group-item-action" style="padding: 30px;">

                    <div class="col">
                        <div class="card-body">
                            <h5 class="card-title">03</h5>
                            <h6>Trimestral</h6>

                        </div>
                        <div class="spinner-grow text-success" role="status">
                        </div>

                    </div>

                    <div class="col">
                        <div class="card" style="width: auto;">
                            <div class="card-body">

                                <h6>O investimento e aplicado a cada Trimestre</h6>

                            </div>
                        </div>
                    </div>

                    <div class="row col-6">
                        <asp:LinkButton ID="btnEditar2" type="button" CssClass="btn btn-light  " OnClick="btnEditar_Click" runat="server">
                                    <i class="fas fa-file"></i> Editar
                        </asp:LinkButton>
                    </div>

                </div>

                <!-- Solicitação 3 -->

                <div type="button" class="list-group-item list-group-item-action" style="padding: 30px;">

                    <div class="col">
                        <div class="card-body">
                            <h5 class="card-title">03</h5>
                            <h6>Mensal</h6>

                        </div>
                        <div class="spinner-grow text-success" role="status">
                        </div>

                    </div>

                    <div class="col">
                        <div class="card" style="width: auto;">
                            <div class="card-body">

                                <h6>O investimento e aplicado a cada Mes</h6>

                            </div>
                        </div>
                    </div>

                    <div class="row col-6">
                        <asp:LinkButton ID="btnEditar3" type="button" CssClass="btn btn-light  " OnClick="btnEditar_Click" runat="server">
                                    <i class="fas fa-file"></i> Editar
                        </asp:LinkButton>
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

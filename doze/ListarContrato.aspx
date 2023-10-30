<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ListarContrato.aspx.cs" Inherits="ListarContrato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">

    <div class="container">



        <form id="ListaContratoForm" runat="server">
            <div class="row" style="text-align: center;">

                <h3>Tipo de Contrato</h3>
            </div>

            <br />
            <br />
            <br />
            <asp:GridView ID="gdvTipoDeContrato" runat="server" AutoGenerateColumns="false" CssClass="table table-hover MyTable" Visible="false" OnRowDataBound="gdvTipoDeContrato_RowDataBound" OnRowCommand="gdvTipoDeContrato_RowCommand">


                <Columns>

                    <asp:BoundField DataField="IDCnt" HeaderText="#" />
                    <asp:BoundField DataField="NomeCnt" HeaderText="Nome" />
                    <asp:BoundField DataField="ObservacaoCnt" HeaderText="Observação" />
                    <asp:BoundField DataField="StatusAtivacaoCnt" HeaderText="Ativo" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <!-- Modificações css durante a empressão da tabela -->
                            <asp:LinkButton CommandArgument='<%# Bind("IDCnt") %>' ID="lkb_ativar" CssClass="btn btn-default" runat="server"></asp:LinkButton>

                            <asp:LinkButton CommandArgument='<%# Bind("IDCnt") %>' ID="lkb_editar" CommandName="Encaminhar" Text="<i class='fa fa-link text-danger'> </i>" CssClass="btn btn-default" runat="server"></asp:LinkButton>


                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <br />
            <br />
            <asp:Label ID="lblMsg" runat="server"></asp:Label>

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

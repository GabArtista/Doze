<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CriarServico.aspx.cs" Inherits="CriarServico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">

    <div class="container" style="padding: 100px 0;">

        <div class="card">
            <div class="card-body">
                <form id="CriarServicoForm" runat="server">

                    <div class="mb-3">
                        <label for="exampleInputEmail1" class="form-label">Nome</label>
                        <asp:TextBox ID="txtNomeSvc" runat="server" placeholder="Novo Serviço" CssClass="form-control" ClientIDMode="Static" TextMode="SingleLine"></asp:TextBox>
                        <div id="odsNome" class="form-text">Coloque o nome do Serviço.</div>
                    </div>

                    <div class="mb-3">
                        <label for="exampleInputPassword1" class="form-label">Valor do Serviço</label>
                        <asp:TextBox ID="txtPrecoSlv" runat="server" placeholder="Preço" CssClass="form-control" ClientIDMode="Static" TextMode="Number"></asp:TextBox>
                    </div>

                     <div class="mb-3">
                        <label for="exampleInputPassword1" class="form-label">Valor do Serviço</label>
                        <asp:TextBox ID="TxtObservacao" runat="server" placeholder="Observação" CssClass="form-control" ClientIDMode="Static" TextMode="MultiLine"></asp:TextBox>
                    </div>
                    <div class="mb-3 form-check">
                        <label class="form-check-label" for="exampleCheck1">Status de Atividade</label>
                    </div>

                    <div class="row">
                        <asp:CheckBox ID="chbStatusAtivacaoSvc" AutoPostBack="true" OnCheckedChanged="chbStatusAtivacao_Click" runat="server" Text="Ativado" />
                    </div>


                    <asp:LinkButton ID="btnCriar" type="button" CssClass="btn btn-success" OnClick="btnCriar_Click" runat="server">Criar
                    </asp:LinkButton>
                    <div class="row">
                        <div class="col">
                            <asp:Button ID="btnVoltar" Text="Voltar" runat="server" OnClick="btnVoltar_Click" CssClass="btn btn-outline-danger" />
                        </div>
                    </div>
                </form>
            </div>
        </div>

    </div>

</asp:Content>


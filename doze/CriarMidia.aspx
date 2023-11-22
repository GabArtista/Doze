<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CriarMidia.aspx.cs" Inherits="CriarMidia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">

    <div class="container" style="padding: 100px 0;">

        <div class="card">
            <div class="card-body">
                <form id="CriarMidiaForm" runat="server">

                    <div class="mb-3">
                        <label for="exampleInputEmail1" class="form-label">Observação</label>
                        <asp:TextBox ID="txtObservacaoMda" runat="server" placeholder="Observação da Midia" CssClass="form-control" ClientIDMode="Static" TextMode="MultiLine"></asp:TextBox>
                        <div id="observacaoMidia" class="form-text">Coloque uma observação sobre a midia a ser carregada</div>
                    </div>
                    
                    <div class="mb-3">
                        <label for="exampleInputEmail1" class="form-label">Midia</label>
                        <asp:FileUpload ID="FileUpload2" runat="server" />
                        <div id="Midia" class="form-text">Coloque a midia a ser carregada</div>
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


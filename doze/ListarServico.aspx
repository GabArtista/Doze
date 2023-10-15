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

            <asp:GridView ID="gdvServicos" AutoGenerateColumns="false" runat="server" CssClass="table table-hover MyTable" Visible="false">

                
                <Columns>
                    <asp:BoundField DataField ="IDSvc" HeaderText="#" />
                    <asp:BoundField DataField="NomeSvc" HeaderText="Nome" />
                    <asp:BoundField DataField="ObservacaoSvc" HeaderText="Observação" />
                    <asp:BoundField DataField="PrecoSvc" HeaderText="Preço" />
                    <asp:BoundField DataField="StatusAtivacaoSvc" HeaderText="Status atividade 0F 1T" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <!-- Modificações css durante a empressão da tabela -->
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>


            </asp:GridView> 
            <br />
            <asp:Label ID="lblMsg" runat="server"></asp:Label>




            
            

          

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

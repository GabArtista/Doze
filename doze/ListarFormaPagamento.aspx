<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ListarFormaPagamento.aspx.cs" Inherits="ListarFormaPagamento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">

    <div class="container">

        <form id="FormaPagamentoForm" runat="server">

            <!-- Solicitação -->


            <div class="row" style="text-align: center;">

                <h3>Formas de Pagamento</h3>
            </div>
           <asp:GridView ID="gdvFormasDePagamentos" runat="server" AutoGenerateColumns="false" CssClass="table table-hover MyTable" Visible="false" OnRowDataBound="gdvFormaPagamento_RowDataBound" OnRowCommand="gdvFormaPagamento_RowCommand">
                
                
                <Columns>
                    
                    <asp:BoundField DataField="IDFop" HeaderText="#" />
                    <asp:BoundField DataField="NomeFop" HeaderText="Nome" /> 
                    <asp:BoundField DataField="ObservacaoFop" HeaderText="observação" />
                    <asp:BoundField DataField="StatusAtivacaoFop" HeaderText="Status" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <!-- Modificações css durante a empressão da tabela -->
                            <asp:LinkButton CommandArgument='<%# Bind("IDFop") %>' ID="lkb_ativar" CssClass="btn btn-default" runat="server"></asp:LinkButton>
                            <asp:LinkButton CommandArgument='<%# Bind("IDFop") %>' ID="lkb_editar" CommandName="Encaminhar" Text="<i class='fa fa-edit text-danger'> </i>" CssClass="btn btn-default" runat="server"></asp:LinkButton>
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

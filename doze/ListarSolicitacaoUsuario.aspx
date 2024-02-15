<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ListarSolicitacaoUsuario.aspx.cs" Inherits="ListarSolicitacaoUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">

    <div class="container">

        <form id="ListarSolicitacaoUsuarioForm" runat="server">

            <div class="row" style="text-align: center;">

                <h3>Solicitações</h3>
            </div>


            <!-- 
                Solicitação:
                Tabela de solicitações recebidas
                -->
            

            <asp:GridView ID="gdvSolicitacoesUsuario" runat="server" AutoGenerateColumns="false" CssClass="table table-hover MyTable" Visible="false" OnRowCommand="gdvSolicitacao_RowCommand">
                
               
                <Columns>
                    
                    <asp:BoundField DataField="IDSLC" HeaderText="#" />
                    <asp:BoundField DataField="IDadm" HeaderText="ID Do ADM" /> 
                    <asp:BoundField DataField="DataSlc" HeaderText="Data" />
                    <asp:BoundField DataField="DescricaoSlc" HeaderText="Descrição" />
                    <asp:BoundField DataField="StatusSlc" HeaderText="Status" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <!-- Modificações css durante a empressão da tabela -->
                            <asp:LinkButton CommandArgument='<%# Bind("IDSlc") %>' ID="lkb_editar" CommandName="Encaminhar" Text="<i class='fa fa-edit text-danger'> </i>" CssClass="btn btn-default" runat="server"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>


            </asp:GridView>


            <asp:Label ID="lblMsg" runat="server"></asp:Label>




            <!-- Botão -->

            <asp:Button ID="btnVoltar" Text="Voltar" runat="server" OnClick="btnVoltar_Click" CssClass="btn btn-outline-danger" />


        </form>



    </div>

</asp:Content>


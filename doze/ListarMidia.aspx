<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ListarMidia.aspx.cs" Inherits="ListarMidia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <div class="container">
        <form id="ListaMidiaForm" runat="server">
            <div class="row" style="text-align: center;">

                <h3>Midias</h3>
            </div>

            <br />
            <br />
            <br />
            <asp:GridView ID="gdvMidia" runat="server" AutoGenerateColumns="false" CssClass="table table-hover MyTable" Visible="false" OnRowCommand="gdvMidia_RowCommand">


                <columns>

                    <asp:BoundField DataField="IDMda" HeaderText="#" />
                    <asp:BoundField DataField="ObservacaoMda" HeaderText="Observação" />
                    <asp:TemplateField>
                        <itemtemplate>
                            <!-- Modificações css durante a empressão da tabela -->

                       <asp:Image runat="server" ID="im" ImageUrl='<%# Bind("Midia do banco") %>' />

                            


                        </itemtemplate>
                    
                        <itemtemplate>
                            <!-- Modificações css durante a empressão da tabela -->

                       <asp:Image runat="server" ID="im" ImageUrl='<%# Bind("IDSlc") %>'´ />

                            <asp:LinkButton CommandArgument='<%# Bind("IDMda") %>' ID="lkb_editar" CommandName="Encaminhar" Text="<i class='fa fa-edit text-danger'> </i>" CssClass="btn btn-default" runat="server"></asp:LinkButton>


                        </itemtemplate>
                    </asp:TemplateField>
                </columns>
            </asp:GridView>
            <br />
            <br />
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


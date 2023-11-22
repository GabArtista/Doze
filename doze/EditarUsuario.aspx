<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EditarUsuario.aspx.cs" Inherits="EditarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">

    <div class="container" style="padding: 100px 0;">

        <div class="card" style="padding: 30px 100px;">
            <div class="card-body">
                <form id="CriarUsuarioForm" runat="server">

                    <div class="mb-3">
                        <label for="exampleInputEmail1" class="form-label">Nome</label>
                        <asp:TextBox ID="txtNomeUsu" runat="server" placeholder="Seu Nome" CssClass="form-control" ClientIDMode="Static" TextMode="SingleLine"></asp:TextBox>
                        <div id="emailHelp" class="form-text">Coloque o novo nome da forma de pagamento.</div>
                    </div>
                    <div class="mb-3">
                        <label for="exampleInputPassword1" class="form-label">Telefone de Contato</label>
                        <asp:TextBox ID="txtTelefoneUsu" runat="server" placeholder="(00) 0 0000-0000" CssClass="form-control" ClientIDMode="Static" TextMode="Number"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="exampleInputPassword1" class="form-label">E-mail</label>
                        <asp:TextBox ID="txtEmailUsu" runat="server" placeholder="Exemplo@exemplo.com" CssClass="form-control" ClientIDMode="Static" TextMode="SingleLine"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="exampleInputPassword1" class="form-label">Senha</label>
                        <asp:TextBox ID="txtSenhaUsu" runat="server" placeholder="*********" CssClass="form-control" ClientIDMode="Static" TextMode="Password"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="exampleInputPassword1" class="form-label">Tipo de Cliente</label>
                        <div class="input-group mb-3">
                            <asp:DropDownList ID="txtTipoUsuarioUsu" runat="server" placeholder="Tipo de Usuario" CssClass="form-control" ClientIDMode="Static">
                                <asp:ListItem Selected="True" Value="Cliente"> Cliente </asp:ListItem>
                                <asp:ListItem Value="Em Andamento"> ADM </asp:ListItem>
                            </asp:DropDownList>

                        </div>
                    </div>
                    <div class="mb-3 form-check">
                        <label class="form-check-label" for="exampleCheck1">Status de Atividade</label>
                    </div>

                    <div class="row">
                        <asp:CheckBox ID="chbStatusAtivacaoCtr" AutoPostBack="true" OnCheckedChanged="chbStatusAtivacao_Click" runat="server" Text="Ativdo" />
                    </div>


                    <asp:LinkButton ID="btnEditar" type="button" CssClass="btn btn-light  " OnClick="btnEditar_Click" runat="server">
                                    <i class="fas fa-file"></i> Editar
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


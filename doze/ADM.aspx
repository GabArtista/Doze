<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ADM.aspx.cs" Inherits="ADM" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">




    <!-- Conteudo -->
    <div class="container" style="padding:100px 0;">
        <form id="ADMForm" runat="server">



            <div class="card" style="padding: 80px; margin: 30px auto;">

                <div class="row">

                    <h2 style="text-align: center">Administrador</h2>

                </div>

                <!-- Botões -->

                <!--Botão 1 -->
                <div class="col">
                    <div class="small-box bg-red">
                        <div class="inner">
                            <h3>150</h3>
                            <p>Forma de Pagamento</p>
                        </div>
                        <div class="icon">
                            <i class="fas fa-credit-card"></i>
                        </div>
                        <a href="ListarFormaPagamento.aspx" class="small-box-footer">Acessar <i class="fas fa-arrow-circle-right"></i>
                        </a>
                    </div>
                </div>

                <!--Botão 2 -->
                <div class="col">
                    <div class="small-box bg-warning">
                        <div class="inner">
                            <h3>150</h3>
                            <p>Solicitações</p>
                        </div>
                        <div class="icon">
                            <i class="fas fa-file"></i>
                        </div>
                        <a href="ListaSolicitacao.aspx" class="small-box-footer">Acessar <i class="fas fa-arrow-circle-right"></i>
                        </a>
                    </div>
                </div>

                <!--Botão 3 -->
                <div class="col">
                    <div class="small-box bg-success">
                        <div class="inner">
                            <h3>150</h3>
                            <p>Usuarios</p>
                        </div>
                        <div class="icon">
                            <i class="fas fa-user"></i>
                        </div>
                        <a href="ListarUsuario.aspx" class="small-box-footer">Acessar <i class="fas fa-arrow-circle-right"></i>
                        </a>
                    </div>
                </div>

                <!--Botão 4 -->
                <div class="col">
                    <div class="small-box bg-light">
                        <div class="inner">
                            <h3>150</h3>
                            <p>Serviços</p>
                        </div>
                        <div class="icon">
                            <i class="fas fa-building"></i>
                        </div>
                        <a href="ListarServico.aspx" class="small-box-footer">Acessar <i class="fas fa-arrow-circle-right"></i>
                        </a>
                    </div>
                </div>

                <!--Botão 5 -->
                <div class="col">
                    <div class="small-box badge-primary">
                        <div class="inner">
                            <h3>150</h3>
                            <p>Tipo de Contratos</p>
                        </div>
                        <div class="icon">
                            <i class="fas fa-briefcase"></i>
                        </div>
                        <a href="ListarContrato.aspx" class="small-box-footer">Acessar <i class="fas fa-arrow-circle-right"></i>
                        </a>
                    </div>
                </div>

            </div>

            <!-- Botão -->


            <asp:Button ID="btnSair" Text="Sair" runat="server" OnClick="btnSair_Click" CssClass="btn btn-outline-danger" />



        </form>
    </div>

</asp:Content>

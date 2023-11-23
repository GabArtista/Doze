<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NegociacaoAdm.aspx.cs" Inherits="NegociacaoAdm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">


    <div class="container" style="padding: 10px 0">
        <form id="NegociacaoAdmForm" runat="server">


            <!-- Informação do Lead-->
            <h1>Usuario</h1>

            <div class="card" style="margin: 10px 0">
                <div class="card-body" style="padding: 30px">



                    <!-- Nome -->

                    <div class="input-group mb-3">
                        <asp:TextBox ID="txtNome" runat="server" placeholder="Nome" CssClass="form-control" ClientIDMode="Static" TextMode="SingleLine"></asp:TextBox>
                        <div class="input-group-append">
                            <div class="input-group-text" style="padding: 10px">
                                <span class="fas fa-user"></span>
                            </div>
                        </div>
                    </div>



                    <!-- Email -->
                    <div class="row">
                        <div class="col">
                            <div class="input-group mb-3">
                                <asp:TextBox ID="txtEmail" runat="server" placeholder="E-mail" CssClass="form-control" ClientIDMode="Static" TextMode="Email"></asp:TextBox>
                                <div class="input-group-append">
                                    <div class="input-group-text" style="padding: 10px">
                                        <span class="fas fa-envelope"></span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- Senha -->
                        <div class="col">
                            <div class="input-group mb-3">
                                <asp:TextBox ID="txtSenha" runat="server" placeholder="Senha" CssClass="form-control" ClientIDMode="Static" TextMode="Password"></asp:TextBox>
                                <div class="input-group-append">
                                    <div class="input-group-text" style="padding: 10px">
                                        <span class="fas fa-key"></span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- Telefone -->

                    <div class="input-group mb-3">
                        <asp:TextBox ID="txtTelefone" runat="server" placeholder="Telefone" CssClass="form-control" ClientIDMode="Static" TextMode="Number"></asp:TextBox>
                        <div class="input-group-append">
                            <div class="input-group-text" style="padding: 10px">
                                <span class="fas fa-phone"></span>
                            </div>
                        </div>
                    </div>

                    <!-- Descrição -->

                    <div class="input-group mb-3">
                        <asp:TextBox ID="txtDescricao" runat="server" placeholder="Descrição" CssClass="form-control" ClientIDMode="Static" TextMode="MultiLine"></asp:TextBox>
                        <div class="input-group-append">
                            <div class="input-group-text" style="padding: 10px;">
                                <span class="fas fa-file"></span>
                            </div>
                        </div>
                    </div>


                </div>
            </div>


            <!-- Informações do contrato -->

            <h1>Solicitação</h1>
            <div class="card">
                <div class="card-body" style="padding: 30px">


                    <!-- Serviços -->

                    <div class="form-check form-switch">
                        <asp:CheckBox ID="cbServico" runat="server" AutoPostBack="True" Text="- Serviço 01" TextAlign="Right" OnCheckedChanged="Checkservic_Clicked" />
                    </div>




                    <!-- Obs e Status -->

                    <div class="input-group mb-3">
                        <asp:TextBox ID="txtObservacaoContrato" runat="server" placeholder="Observação" CssClass="form-control" ClientIDMode="Static" TextMode="MultiLine"></asp:TextBox>
                        <div class="input-group-append">
                            <div class="input-group-text" style="padding: 10px;">
                                <span class="fas fa-file"></span>
                            </div>
                        </div>
                    </div>

                    <div class="col">
                        <div class="input-group mb-3">
                            <asp:DropDownList ID="txtStatus" runat="server" placeholder="Status da Solicitação" CssClass="form-control" ClientIDMode="Static">
                                <asp:ListItem Value="Fechado"> Fechado </asp:ListItem>
                                <asp:ListItem Selected="True" Value="Em Andamento"> Em Andamento </asp:ListItem>
                                <asp:ListItem Value="Cancelado"> Cancelado </asp:ListItem>
                            </asp:DropDownList>
                            <div class="input-group-append">
                                <div class="input-group-text" style="padding: 10px">
                                    <span class="fas fa-file"></span>
                                </div>
                            </div>
                        </div>
                    </div>

                    <!-- Dia de fechamento e Link do Trello -->
                    <div class="row">
                        <div class="col">
                            <div class="input-group mb-3">
                                <asp:TextBox ID="txtDiaFechamento" runat="server" placeholder="Dia de Fechamento" CssClass="form-control" ClientIDMode="Static" TextMode="Date"></asp:TextBox>
                                <div class="input-group-append">
                                    <div class="input-group-text" style="padding: 10px">
                                        <span class="fas fa-calendar"></span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col">
                            <div class="input-group mb-3">
                                <asp:TextBox ID="txtLinkTrello" runat="server" placeholder="Trello Link" CssClass="form-control" ClientIDMode="Static" TextMode="SingleLine"></asp:TextBox>
                                <div class="input-group-append">
                                    <div class="input-group-text" style="padding: 10px">
                                        <span class="fas fa-link"></span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>


                    <!-- Gmail e GSenha -->
                    <div class="row">
                        <div class="col">
                            <div class="input-group mb-3">
                                <asp:TextBox ID="txtGmail" runat="server" placeholder="Gmail do contrato" CssClass="form-control" ClientIDMode="Static" TextMode="Email"></asp:TextBox>
                                <div class="input-group-append">
                                    <div class="input-group-text" style="padding: 10px">
                                        <span class="fas fa-envelope"></span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col">
                            <div class="input-group mb-3">
                                <asp:TextBox ID="txtGSenha" runat="server" placeholder="Senha do Gmail" CssClass="form-control" ClientIDMode="Static" TextMode="Password"></asp:TextBox>
                                <div class="input-group-append">
                                    <div class="input-group-text" style="padding: 10px">
                                        <span class="fas fa-key"></span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>


                    <!-- Estrategia de combrança e valor Acordado -->

                    <div class="row">

                        <div class="col">
                            <div class="input-group mb-3">
                                <asp:TextBox ID="txtEstrategiaDecobranca" runat="server" placeholder="Como sera cobrado:" CssClass="form-control" ClientIDMode="Static" TextMode="MultiLine"></asp:TextBox>
                                <div class="input-group-append">
                                    <div class="input-group-text" style="padding: 10px">
                                        <span class="fas fa-key"></span>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="col">
                            <div class="input-group mb-3">
                                <asp:TextBox ID="txtValorAcordado" runat="server" placeholder="Valor" CssClass="form-control" ClientIDMode="Static" TextMode="Number"></asp:TextBox>
                                <div class="input-group-append">
                                    <div class="input-group-text" style="padding: 10px">
                                        <span class="fas fa-star"></span>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>



                </div>
            </div>


            <!-- Informação da Forma de Pagamento -->

            <h1>Forma de Pagamento</h1>

            <div class="card">
                <div class="card-body" style="padding: 30px">


                    <div class="col">
                        <div class="input-group mb-3">
                            <asp:DropDownList ID="ddnFormaDePagamento" runat="server" placeholder="Forma de Pagamento" CssClass="form-control" ClientIDMode="Static">
                                
                            </asp:DropDownList>

                        </div>
                    </div>


                    <div class="col">
                        <div class="input-group mb-3">
                            <asp:TextBox ID="txtObservacaoFop" runat="server" placeholder="Observação" CssClass="form-control" ClientIDMode="Static" TextMode="MultiLine"></asp:TextBox>
                            <div class="input-group-append">
                                <div class="input-group-text" style="padding: 10px;">
                                    <span class="fas fa-file"></span>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>



            <!-- Informação tipo de Contrato -->

            <h1>Tipo de Contrato</h1>

            <div class="card">
                <div class="card-body" style="padding: 30px">

                    <!-- Tipo de Contrato -->

                    <div class="col">
                        <div class="input-group mb-3">
                            <asp:DropDownList ID="ddnTipoContrato" runat="server" placeholder="Tipo de Contrato" CssClass="form-control" ClientIDMode="Static">
                                
                            </asp:DropDownList>

                        </div>
                    </div>

                    <!-- Observação do tipo de contrato -->
                    <div class="col">
                        <div class="input-group mb-3">
                            <asp:TextBox ID="txtObservacaoTipoContrato" runat="server" placeholder="Observação do Tipo de Contra" CssClass="form-control" ClientIDMode="Static" TextMode="MultiLine"></asp:TextBox>
                            <div class="input-group-append">
                                <div class="input-group-text" style="padding: 10px;">
                                    <span class="fas fa-file"></span>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>

            <!-- Botão -->

            <asp:LinkButton ID="btnLead" Text="ENVIAR" runat="server" CssClass="btn btn-light styleBotao" OnClick="btnLead_Click"></asp:LinkButton>




        </form>
    </div>

</asp:Content>

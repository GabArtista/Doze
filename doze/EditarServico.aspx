﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EditarServico.aspx.cs" Inherits="EditarServico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <div class="container" style="padding: 100px 0;">

        <div class="card">
            <div class="card-body">
                <form id="EditarServicoForm" runat="server">

                    <div class="mb-3">
                        <label for="exampleInputEmail1" class="form-label">Nome do Serviço</label>
                        <asp:TextBox ID="txtNomeSvc" runat="server" placeholder="Novo Serviço" CssClass="form-control" ClientIDMode="Static" TextMode="SingleLine"></asp:TextBox>
                        <div id="emailHelp" class="form-text">Coloque o nome do Serviço.</div>
                    </div>
                    <div class="mb-3">
                        <label for="exampleInputPassword1" class="form-label">Valor do Serviço</label>
                        <asp:TextBox ID="txtPrecoSvc" runat="server" placeholder="Preço" CssClass="form-control" ClientIDMode="Static" TextMode="Number"></asp:TextBox>
                    </div>
                    
                    <div class="mb-3">
                        <label for="exampleInputPassword1" class="form-label">Valor do Serviço</label>
                        <asp:TextBox ID="txtObservacaoSvc" runat="server" placeholder="Preço" CssClass="form-control" ClientIDMode="Static" TextMode="MultiLine"></asp:TextBox>
                    </div>

                    <div class="mb-3 form-check">
                        <label class="form-check-label" for="exampleCheck1">Status de Atividade</label>
                    </div>

                    <div class="row">
                        <asp:CheckBox ID="chbStatusAtivacaoSvc" AutoPostBack="true" OnCheckedChanged="chbStatusAtivacao_Click" runat="server" Text="Ativdo" />
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


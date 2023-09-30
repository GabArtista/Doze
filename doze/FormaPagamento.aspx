<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FormaPagamento.aspx.cs" Inherits="FormaPagamento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-4bw+/aepP/YC94hEpVNVgiZdgIC5+VKNBQNGCHeKRQN+PtmoHDEXuppvnDJzQIu9" crossorigin="anonymous">
    <!-- Materialize CSS -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css">
    <!-- Font Awesome -->
    <link rel="stylesheet" href="//use.fontawesome.com/releases/v5.0.7/css/all.css">
</head>
<body style="background-color: whitesmoke;">


    <nav class="navbar navbar-expand-lg bg-body-tertiary">
        <div class="container-fluid">

            <a class="navbar-brand" href="#">
                <img src="ASSETS/IMG/IMG-20220601-WA0073__1___1_-removebg-preview.png" alt="Logo" width="80" class="d-inline-block align-text-top ">
                Crew
            </a>

            <div class="collapse navbar-collapse" id="navbarNav">
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <a class="nav-link active" aria-current="page" href="#contato">Contato</a>
                    </li>

                    <li class="nav-item">
                        <a class="nav-link" href="login.aspx">Login</a>
                    </li>

                    <li class="nav-item">
                        <a class="nav-link disabled" aria-disabled="true" href="#">Rede Social</a>
                    </li>
                </ul>
            </div>

        </div>
    </nav>



    <div class="container">
        <form id="FormaPagamentoForm" runat="server">

            <div class="list-group" style="margin: 50px auto;">

                <button type="button" class="list-group-item list-group-item-action" style="padding: 30px;">

                    <div class="col">

                        <div class="card-body">
                            <h5 class="card-title">01</h5>
                            <h6>Boleto</h6>
                            <h6 class="card-subtitle mb-2 text-body-secondary">Status Ativação: Ativo</h6>

                        </div>


                    </div>

                    <div class="col">
                        <div class="card" style="width: auto;">
                            <div class="card-body">

                                <h6>A empresa deve gerar um boleto bancario sempre que chegar o dia do pagamento do Contrato.</h6>

                            </div>
                        </div>
                    </div>

                </button>

                <button type="button" class="list-group-item list-group-item-action" style="padding: 30px;">

                    <div class="col">

                        <div class="card-body">
                            <h5 class="card-title">02</h5>
                            <h6>Cartão de Creito</h6>
                            <h6 class="card-subtitle mb-2 text-body-secondary">Status Ativação: Ativo</h6>

                        </div>


                    </div>

                    <div class="col">
                        <div class="card" style="width: auto;">
                            <div class="card-body">

                                <h6>A empresa deve gerar Debitar atomaticamente sempre que chegar o dia do pagamento do Contrato.</h6>

                            </div>
                        </div>
                    </div>

                </button>

                <button type="button" class="list-group-item list-group-item-action" style="padding: 30px;">

                    <div class="col">

                        <div class="card-body">
                            <h5 class="card-title">03</h5>
                            <h6>Cartão de Debito</h6>
                            <h6 class="card-subtitle mb-2 text-body-secondary">Status Ativação: Ativo</h6>

                        </div>


                    </div>

                    <div class="col">
                        <div class="card" style="width: auto;">
                            <div class="card-body">

                                <h6>A empresa deve gerar uma cobrança sempre que chegar o dia do pagamento do Contrato.</h6>

                            </div>
                        </div>
                    </div>

                </button>

                <button type="button" class="list-group-item list-group-item-action" style="padding: 30px;">

                    <div class="col">

                        <div class="card-body">
                            <h5 class="card-title">04</h5>
                            <h6>Pix</h6>
                            <h6 class="card-subtitle mb-2 text-body-secondary">Status Ativação: Ativo</h6>

                        </div>


                    </div>

                    <div class="col">
                        <div class="card" style="width: auto;">
                            <div class="card-body">

                                <h6>A empresa deve gerar um Pix sempre que chegar o dia do pagamento do Contrato.</h6>

                            </div>
                        </div>
                    </div>

                </button>
            </div>

            <!-- Botão -->
            <div class="row">
                <asp:Button class="btn-floating btn-large waves-effect waves-light red"><i class="fas fa-plus"></i></asp:Button>
            </div>
            <div class="row">
                <div class="col">
                    <asp:Button ID="btnVoltar" Text="Voltar" runat="server" OnClick="btnVoltar_Click" CssClass="btn btn-outline-danger" />
                </div>
            </div>
        </form>
    </div>


        <!-- Bootstrap JS -->
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-HwwvtgBNo3bZJJLYd8oVXjrBZt8cqVSpeBNS5n7C8IVInixGAoxmnlMuBnhbgrkm" crossorigin="anonymous"></script>
        <!-- Materialize JS -->
        <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js"></script>
        <!--JS -->
        <script src="ASSETS/plugins/jquery/jquery.min.js"></script>
        <!-- Theme style -->
        <link href="ASSETS/CSS/adminlte.min.css" rel="stylesheet" />
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ErroSenhaIgual.aspx.cs" Inherits="ErroSenhaIgual" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>DOZE Crew</title>


    <!-- Links -->

    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-4bw+/aepP/YC94hEpVNVgiZdgIC5+VKNBQNGCHeKRQN+PtmoHDEXuppvnDJzQIu9" crossorigin="anonymous">

    <!-- Font Awesome -->
    <link rel="stylesheet" href="//use.fontawesome.com/releases/v5.0.7/css/all.css">


    <style>
     

    

        .fundo {
            background-color: #FFBD59;
            padding: 110px;
        }

        .styleBotao {
            width: 100%;
            margin: 3px 0;
            background-color: white;
            font-family: Calibri;
            border-color: black;
            color: black;
        }

        .styleCardHeader {
            background-color: white;
        }

        .styleCard {
            padding: 40px 5%;
            margin:150px auto;
            max-width: 500px;
        }
        /*Fim Parte 1*/
    </style>
</head>
<body>
    <div class="fundo">

        <div class="container ">

            <div class="card styleCard">


                <div class="card-header text-center styleCardHeader">
                    <h1>
                        <b>ERRO</b>
                        <p>A senha fornecida é igual a senha original do Usuario</p>
                    </h1>
                </div>


                <!-- Links esqueceu a senha e cadastrar -->
                <p class="mb-1">
                    <a href="ListaSolicitacao.aspx">Voltar</a>
                </p>
            </div>
        </div>

    </div>






    <script>
        function valida_form() {
            if (document.getElementById("email").value.length < 3) {
                alert('E-mail = null');
                document.getElementById("email").focus();
                return false
            }

            if (document.getElementById("password").value.length == 0) {
                alert('Password = null');
                document.getElementById("password").focus();
                return false
            }

        }

        $(document).ready(function () {
            $("#iconever").click(function () {

                var senhaInput = $("#txtSenha");

                var iconeOlho = $("#iconever");

                if (senhaInput.attr("type") === "password") {
                    senhaInput.attr("type", "text");
                    iconeOlho.removeClass("fa-eye-slash").addClass("fa-eye");
                }
                else {
                    senhaInput.attr("type", "password");
                    iconeOlho.removeClass("fa-eye").addClass("fa-eye-slash");
                }

            });
        });
    </script>









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



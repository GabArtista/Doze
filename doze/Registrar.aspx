<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registrar.aspx.cs" Inherits="Registrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    <!-- Links -->
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-4bw+/aepP/YC94hEpVNVgiZdgIC5+VKNBQNGCHeKRQN+PtmoHDEXuppvnDJzQIu9" crossorigin="anonymous">
    <!-- Materialize CSS -->
    <!-- <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css"> -->

</head>
<body>

    <div class="container">

        <div class="card" style="padding: 40px 5%; margin: 100px 30%">


            <form id="form1" runat="server">


                <!-- Nome -->
                <label for="nome" class="form-label">Name:</label>
                <div class="input-group mb-3">
                    <input type="text" class="form-control" id="nome" aria-describedby="text" placeholder="Ex: Joaquim">
                    <div class="input-group-append">
                        <div class="input-group-text">
                            <span class="fas fa-envelope"></span>
                        </div>
                    </div>
                </div>

                <!-- Email -->
                <label for="email" class="form-label">E-mail:</label>
                <div class="input-group mb-3">
                    <input type="email" class="form-control" id="email" aria-describedby="email" placeholder="Ex: Exemple@exemple.com">
                    <div class="input-group-append">
                        <div class="input-group-text">
                            <span class="fas fa-envelope"></span>
                        </div>
                    </div>
                </div>

                <!-- Senha -->
                <label for="password" class="form-label">Password:</label>
                <div class="input-group mb-3">
                    <input type="password" class="form-control" id="password" aria-describedby="password" placeholder="Ex: *********">
                    <div class="input-group-append">
                        <div class="input-group-text">
                            <span class="fas fa-envelope"></span>
                        </div>
                    </div>
                </div>

                <!-- Senha Confirmação -->
                <label for="password" class="form-label">Password Confirm:</label>
                <div class="input-group mb-3">
                    <input type="password" class="form-control" id="password" aria-describedby="password" placeholder="Ex: *********">
                    <div class="input-group-append">
                        <div class="input-group-text">
                            <span class="fas fa-envelope"></span>
                        </div>
                    </div>
                </div>


                 <!-- CheckBox e Botão -->
                <div class="mb-3 form-check">
                    <input type="checkbox" class="form-check-input" id="check">
                    <label class="form-check-label" for="check">Relembrar-me</label>

                    <!--Class= "waves-effect waves-light btn" . Para botão do materialize -->
                    <button type="submit" class="btn btn-primary" onclick="valida_form()" style="float: right">Login</button>
                </div>

                <!-- Botão Google e Facebook -->

                <button type="submit" class="btn btn-primary " style="width: 100%; margin: 3px 0">Facebook</button>
                <button type="submit" class="btn btn-danger " style="width: 100%; margin: 3px 0">Google</button>

            </form>

            <!-- Links esqueceu a senha e cadastrar -->
            <p class="mb-1">
                <a href="#">Esqueceu senha</a>
            </p>
            <p class="mb-0">
                <a href="#" class="text-center">Cadastrar usuário</a>
            </p>

        </div>
    </div>
</body>
</html>

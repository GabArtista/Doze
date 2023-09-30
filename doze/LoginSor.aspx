<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginSor.aspx.cs" Inherits="LoginSor" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>AdminLTE 3 | Log in (v2)</title>

    <!-- Google Font: Source Sans Pro -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback">
    <!-- Font Awesome -->
    <link rel="stylesheet" href="ASSETS/plugins/fontawesome-free/css/all.min.css">
    <!-- icheck bootstrap -->
    <link rel="stylesheet" href="ASSETS/plugins/icheck-bootstrap/icheck-bootstrap.min.css">
    <!-- Theme style -->
    <link rel="stylesheet" href="ASSETS/css/adminlte.min.css">
</head>
<body class="hold-transition login-page">
    <div class="login-box">
        <!-- /.login-logo -->
        <div class="card card-outline card-primary">
            <div class="card-header text-center">
                <a href="#" class="h1"><b>Admin</b>LTE</a>
            </div>
            <div class="card-body">
                <p class="login-box-msg">Sign in to start your session</p>

                <form id="form1" runat="server">
                    <div class="input-group mb-3">

                        <asp:TextBox ID="txtemail" runat="server" placeholder="E-mail" CssClass="form-control" ClientIDMode="Static" TextMode="Email"></asp:TextBox>

                        <div class="input-group-append">
                            <div class="input-group-text">
                                <span class="fas fa-envelope"></span>
                            </div>
                        </div>
                    </div>
                    <div class="input-group mb-3">
                        
                        <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control"  ClientIDMode="Static" TextMode="Password"></asp:TextBox>
                        <div class="input-group-append">
                            <div class="input-group-text">
                                <span class="fas fa-lock"></span>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-8">
                            <div class="icheck-primary">
                                <input type="checkbox" id="remember">
                                <label for="remember">
                                    Remember Me
             
                                </label>
                            </div>
                        </div>
                        <!-- /.col -->
                        <div class="col-4">
                        
                            <asp:LinkButton ID="Button1" Text="ENTRAR" runat="server" CssClass="btn btn-primary" onClick="Button1_Click">
                                
                                <i class="fa fa-random"> Entrar</i>

                            </asp:LinkButton>
                            
                        </div>
                        <!-- /.col -->
                    </div>
                </form>

                
                <!-- /.social-auth-links -->

                <p class="mb-1">
                    <a href="#">Esqueceu a Senha</a>
                </p>
                <p class="mb-0">
                    <a href="RegistrarSor.aspx"  class="text-center">Register a new membership</a>
                </p>
            </div>
            <!-- /.card-body -->
        </div>
        <!-- /.card -->
    </div>
    <!-- /.login-box -->

    <!-- jQuery -->
    <script src="ASSETS/plugins/jquery/jquery.min.js"></script>
    <!-- Bootstrap 4 -->
    <script src="ASSETS/plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- AdminLTE App -->
    <script src="ASSETS/js/adminlte.min.js"></script>
</body>
</html>


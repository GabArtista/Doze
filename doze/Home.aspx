<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
   
    
    <div class="container text-center fundo">


        <div class="row">
            <div class="parte2 ">
                <!--Texto Serviço-->
                <div class="row">

                    <h2 style="text-align: center">Serviços</h2>

                </div>

                <!--Serviços-->


                <div class="row">

                    <div class="col-md g-5">
                        <div class="card">
                            <div id="carouselExampleSlidesOnly" class="carousel slide" data-bs-ride="carousel">
                                <div class="carousel-inner">
                                    <div class="carousel-item active">
                                        <img src="ASSETS/IMG/servico seo/1a.png" class="d-block w-100" alt="..." />
                                    </div>
                                    <div class="carousel-item">
                                        <img src="ASSETS/IMG/servico seo/2a.png" class="d-block w-100" alt="..." />
                                    </div>
                                    <div class="carousel-item active">
                                        <img src="ASSETS/IMG/servico seo/1.png" class="d-block w-100" alt="..." />
                                    </div>
                                    <div class="carousel-item">
                                        <img src="ASSETS/IMG/servico seo/2.png" class="d-block w-100" alt="..." />
                                    </div>
                                </div>
                            </div>
                            <div class="card-body">
                                <h3>SEO</h3>
                                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            </div>
                        </div>
                    </div>

                    <div class="col-md  g-5">
                        <div class="card">
                            <div id="carouselExampleSlidesOnly" class="carousel slide" data-bs-ride="carousel">
                                <div class="carousel-inner">
                                    <div class="carousel-item active">
                                        <img src="ASSETS/IMG/1.png" class="d-block w-100" alt="...">
                                    </div>
                                    <div class="carousel-item">
                                        <img src="ASSETS/IMG/2.png" class="d-block w-100" alt="...">
                                    </div>
                                    <div class="carousel-item">
                                        <img src="ASSETS/IMG/3.png" class="d-block w-100" alt="...">
                                    </div>
                                </div>
                            </div>
                            <div class="card-body">
                                <h3>WebDesign</h3>
                                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            </div>
                        </div>
                    </div>

                    <div class="col-md  g-5">
                        <div class="card">
                            <div id="carouselExampleSlidesOnly" class="carousel slide" data-bs-ride="carousel">
                                <div class="carousel-inner">
                                    <div class="carousel-item active">
                                        <img src="ASSETS/IMG/design/1Design.png" class="d-block w-100" alt="...">
                                    </div>
                                    <div class="carousel-item">
                                        <img src="ASSETS/IMG/design/2Design.png" class="d-block w-100" alt="...">
                                    </div>
                                    <div class="carousel-item">
                                        <img src="ASSETS/IMG/design/3Design.png" class="d-block w-100" alt="...">
                                    </div>
                                </div>
                            </div>
                            <div class="card-body">
                                <h3>Marketing</h3>
                                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            </div>
                        </div>
                    </div>

                    <div class="col-md  g-5">
                        <div class="card">
                            <div id="carouselExampleSlidesOnly" class="carousel slide" data-bs-ride="carousel">
                                <div class="carousel-inner">
                                    <div class="carousel-item active">
                                        <img src="ASSETS/IMG/analista/Analista1.png" class="d-block w-100" alt="...">
                                    </div>
                                    <div class="carousel-item">
                                        <img src="ASSETS/IMG/analista/Analista2.png" class="d-block w-100" alt="...">
                                    </div>
                                    <div class="carousel-item">
                                        <img src="ASSETS/IMG/analista/Analista3.png" class="d-block w-100" alt="...">
                                    </div>
                                </div>
                            </div>
                            <div class="card-body">
                                <h3>Eventos</h3>
                                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            </div>
                        </div>
                    </div>

                </div>

                <div class="col" style="margin:100px auto">
                    <div class="card" style="padding: 20px">
                        <div id="carouselServico" class="carousel slide" data-bs-ride="carousel">
                            <div class="carousel-inner">
                            </div>
                        </div>
                        <div class="card-body">
                            <h3>Sobre</h3>
                            <p class="card-text">Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</p>
                        </div>
                    </div>
                </div>



            </div>

        </div>

        <div class="row">
            <div class="parte1">


                <div class="row g-5 text-center sobreForm">


                    <!-- Card Formulario-->


                    <div class="card">
                        <div class="card-body" style="padding: 30px;">


                            <form id="LeadForm" runat="server">

                                <div class="row">

                                    <h2 style="text-align: center">Formulário de Contato</h2>

                                </div>

                                <!-- Nome -->
                                <div class="container" id="contato">
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





                                <!-- Botão Login -->


                                <asp:LinkButton ID="btnLead" Text="ENVIAR" runat="server" CssClass="btn btn-dark styleBotao" OnClick="btnLead_Click"></asp:LinkButton>

                                
                            </form>


                        </div>
                    </div>

                </div>


            </div>
        </div>
    </div>

    
     

</asp:Content>








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
                                <h3>Desenvolvimento de Software</h3>
                                <p class="card-text">Conquiste o Site que irá elevar o nível de sua empresa com um sistema feito 100% para seu negocio</p>
                            </div>
                        </div>
                    </div>

                    <div class="col-md  g-5">
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
                                <p class="card-text">Posicionar seu site nas plataformas de busca como o Google é essencial para alcançar seus clientes!</p>
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
                                <h3>Marketing Digital</h3>
                                <p class="card-text">É preciso estar em todos os lugares! Um bom posicionamento nas Redes é muito importante para elevar a confiabilidade da sua empresa!</p>
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
                            <h3>Sobre nós</h3>
                            <p class="card-text">A Doze Crew atua no mercado do Desenvolvimento de Software e Marketing a mais de 7 anos! Nossos desenvolvedores estão prontos e preparados para qualquer desafio, enquanto nossa equipe de Marketing já criaram campanhar iconicas que marcaram os lugares por onde passaram! A Doze oferece soluções de software para empresas desde o desenvolvimento de site, garantir o posicionamento do mesmo nas plataformas de busca (Google por exemplo), posicionar a empresa em Midias Sociais e até mesmo criar identidade virtual para empresas começarem no mercado! Contando sempre com profissionais que sabem oque estão fazendo!</p>
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








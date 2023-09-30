using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["emailsemabase"] != null && Request.QueryString["emailcombase"] != null)
        {
            string emailsemabase = Request.QueryString["emailsemabase"].ToString();
            string emailcombase = Request.QueryString["emailcombase"].ToString();
        }

    }

    protected void btnLead_Click(object sender, EventArgs e)
    {
        String nome = txtNome.Text;
        String email = txtEmail.Text;
        String senha = txtSenha.Text;
        String telefone = txtTelefone.Text;
        String descricao = txtDescricao.Text;


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class CriarMidia : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCriar_Click(object sender, EventArgs e)
    {
        Midia mda = new Midia();

        mda._mdaObservacao = txtObservacaoMda.Text;
        mda._mdaMidia = FileUpload2.FileBytes;


        MidiaBD.Insert(mda);

        //Se o cadastro for sussedido:
        Response.Redirect("ListarMidia.aspx");

    }

    protected void btnVoltar_Click(object sender, EventArgs e)
    {


        Response.Redirect("ListarContrato.aspx");

    }
}
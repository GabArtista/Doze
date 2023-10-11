using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Solicitacao
/// </summary>
public class Solicitacao
{
    
    public int _slcID { get; set; }
    public DateTime _slcData { get; set; }
    public String _slcDescricao { get; set; }
    public String _slcObservacao { get; set; }
    public DateTime _slcDataFechamento { get; set; }
    public String _slcLinkTrello { get; set; }
    public String _slcStatusSolicitacao { get; set; }
    public String _slcGmail { get; set; }
    public String _slcGsenha { get; set; }
    public Double _slcValorAcordado { get; set; }
    public String _slcEstrategiaCobranca { get; set; }
    public int _slcIDAdm { get; set; }



    //Relacao de classes Usuario: 
    public Usuario usu { set; get; }

    //Relacao de classes Tipo De Contrato: 
    public TipoDeContrato tdc { set; get; }

    //Relacao de classes Forma De Pagamento: 
    public FormaDePagamento fop { set; get; }

    //Relacao de classes Servico: 
    public Servico svc { set; get; }

}


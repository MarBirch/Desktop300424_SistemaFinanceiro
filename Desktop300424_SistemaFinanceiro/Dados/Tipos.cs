using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public enum TipoPessoa { PESSOA_FISICA=1, PESSOA_JURIDICA=2};
    public enum MeioPagamento {PIX = 1, BOLETO = 2, CREDITO = 3};
    public enum EstadoPagamento { CONCLUIDO =1, QUITADO = 2, CANCELADO=3}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class ContaPagar
    {
        public int id { get; set; }
        public decimal valor { get; set; }
        public DateTime dataVencimento { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataRecebimento { get; set; }
        public MeioPagamento meioPagamento { get; set; }
        public EstadoPagamento situacao { get; set; }

        public ContaReceber()
        {
        }

        public ContaReceber(int id, decimal valor, DateTime dataVencimento, DateTime dataCadastro, DateTime dataRecebimento, MeioPagamento meioPagamento, EstadoPagamento situacao)
        {
            this.id = id;
            this.valor = valor;
            this.dataVencimento = dataVencimento;
            this.dataCadastro = dataCadastro;
            this.dataRecebimento = dataRecebimento;
            this.meioPagamento = meioPagamento;
            this.situacao = situacao;
        }

        public override bool Equals(object obj)
        {
            return obj is ContaReceber receber &&
                   id == receber.id &&
                   valor == receber.valor &&
                   dataVencimento == receber.dataVencimento &&
                   dataCadastro == receber.dataCadastro &&
                   dataRecebimento == receber.dataRecebimento &&
                   meioPagamento == receber.meioPagamento &&
                   situacao == receber.situacao;
        }

        public override int GetHashCode()
        {
            int hashCode = -2132317777;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + valor.GetHashCode();
            hashCode = hashCode * -1521134295 + dataVencimento.GetHashCode();
            hashCode = hashCode * -1521134295 + dataCadastro.GetHashCode();
            hashCode = hashCode * -1521134295 + dataRecebimento.GetHashCode();
            hashCode = hashCode * -1521134295 + meioPagamento.GetHashCode();
            hashCode = hashCode * -1521134295 + situacao.GetHashCode();
            return hashCode;
        }
    }
}

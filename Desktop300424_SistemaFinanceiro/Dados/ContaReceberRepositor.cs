using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ContaReceberRepository
    {
        private IList<ContaReceber> contaReceber = new List<ContaReceber>();

        public ContaReceber Insert(ContaReceber contaReceber)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            this._contaReceber.Add(contaReceber);
            return contaReceber;
        }

        public ContaReceber Update(ContaReceber contaReceber)
        {
            this._contaReceber[this._contaReceber.IndexOf(contaReceber)] = contaReceber;
            return contaReceber;
        }

        public void Remove(ContaReceber contaReceber)
        {
            this.contaReceber.Remove(contaReceber);
        }

        public IEnumerable<ContaReceber> ObterTodos()
        {
            return _contaReceber;
        }

        public IList<ContaReceber> getAll()
        {
            return _contaReceber;
        }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class ContaPagarService
    {
        private ContaPagarRepository _repository;

        public ContaPagarService()
        {
            _repository = new ContaPagarRepository();
        }

        public void Insert(int id, decimal valor, DateTime dataVencimento, DateTime dataCadastro, DateTime dataRecebimento, MeioPagamento meioPagamento, EstadoPagamento situacao)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var contaPagar = new ContaPagar
            {
                //mudar variaves
                Id = id,
                Valor = valor,
                DataVencimento = dataVencimento,
                DataCadastro = dataCadastro,
                DataRecebimento = dataRecebimento,
                MeioPagamento = meioPagamento,
                Situacao = situacao
            };

            _repository.Insert(contaPagar);

        }

        public void Insert(ContaPagar contaPagar)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Insert(contaPagar);

        }

        public ContaPagar FindById(int id)
        {
            foreach (ContaPagar c in _repository.getAll())
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public IEnumerable<ContaPagar> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public List<ContaPagar> getAll()
        {
            return _repository.ObterTodos().ToList<Cliente>();
        }

    }
}
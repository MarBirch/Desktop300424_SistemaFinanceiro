using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ContaPagarRepository
    {
        private IList<ContaPagar> contaPagar = new List<ContaPagar>();

        public ContaPagar Insert(ContaPagar contaPagar)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            this._contaPagar.Add(contaPagar);
            return contaPagar;
        }

        public ContaPagar Update(ContaPagar contaPagar)
        {
            this._contaPagar[this._contaPagar.IndexOf(contaPagar)] = contaPagar;
            return contaPagar;
        }

        public void Remove(ContaPagar contaPagar)
        {
            this.contaPagar.Remove(contaPagar);
        }

        public IEnumerable<ContaPagar> ObterTodos()
        {
            return _contaPagar;
        }

        public IList<ContaPagar> getAll()
        {
            return _contaPagar;
        }
    }

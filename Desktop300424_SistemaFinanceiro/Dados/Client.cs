using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class Client
    {
        public int id { get; set; }
        public String cpf_cnpf { get; set; }
        public string RazaoSocial { get; set; }

        public Client()
        {

        }

        public Client(int id, string cpf_cnpf, string razaoSocial)
        {
            this.id = id;
            this.cpf_cnpf = cpf_cnpf;
            RazaoSocial = razaoSocial;
        }

        public override bool Equals(object obj)
        {
            return obj is Client client &&
                   id == client.id &&
                   cpf_cnpf == client.cpf_cnpf &&
                   RazaoSocial == client.RazaoSocial;
        }

        public override int GetHashCode()
        {
            //hash code é uma representação do objeto
            int hashCode = -281779745;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cpf_cnpf);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(RazaoSocial);
            return hashCode;
        }
    }
}

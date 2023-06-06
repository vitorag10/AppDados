using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUa.Dominio
{
    public class PessoaJuridica:Pessoa
    {
        private string cnpj;
        private string NomeFantasia;

        public PessoaJuridica()
        {
        }

        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string NomeFantasia1 { get => NomeFantasia; set => NomeFantasia = value; }
    }
}

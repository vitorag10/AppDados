using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUa.Dominio
{
    public class PessoaFisica:Pessoa
    {
        private string cpf;

        public PessoaFisica()
        {
        }

        public string Cpf { get => cpf; set => cpf = value; }
    }
}

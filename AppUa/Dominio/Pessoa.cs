using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUa.Dominio
{
    public class Pessoa
    {
        private string nome;
        private string endereco;
        private string telefone;

        public Pessoa()
        {
        }

        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}

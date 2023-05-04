using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento.Classes
{
    public class Endereco
    {
        public int id_endereco { get; set; }
        public int id_funcionario { get; set; }
        public string bairro { get; set; }
        public string rua { get; set; }
        public string cep { get; set; }


        
    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento.Classes
{
    class Telefone : Funcionario
    {
        public int id_telefone {  get; set; }
        public int id_funcionario { get; set; }
        public string ddd { get; set; }
        public string telefone { get; set; }
        public string tipo { get; set; }
    }
}

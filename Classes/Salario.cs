using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento.Classes
{
    class Salario : Funcionario
    {
        public int id_salario { get; }
        public double salario_base { get; set;}
        public int id_funcionario { get; set;}
    }
}

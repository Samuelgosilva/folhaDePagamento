using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento.Classes
{
    class Folha : Funcionario
    {
        public int id_demonstra_pagamento { get; }
        public int id_funcionario { get; }
        public string nome_funcionario { get;}
        public double inss { get; set; }
        public double irrf { get; set; }
        public double descontos { get; set; }
        public double adicionais { get; set; }
        public double salario_liquido { get; set; }
        public double salario_bruto { get;}
        public DateTime dt_pagamento {get; set;}
    }
}

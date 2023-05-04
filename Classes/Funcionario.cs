using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento.Classes
{
    class Funcionario
    {
        public int id_funcionario { get; set; }
        public string cpf_funcionario { get; set; }
        public string nome_funcionario { get; set; }
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        public DateTime dt_nasc_funcionario { get; set; }
        public string estado_civil_funcionario { get; set; }
        public string cargo { get; set; }

        public string senha { get; set; }
        public string login { get; set; }

        public string bairro_funcionario { get; set; }
        public string rua_funcionario { get; set; }
        public string cep_funcionario { get; set; }

        public string telefone_funcionario { get; set; }
        public string ddd_funcionario { get; set; }
        public string tipo { get; set; }

        public double salario_base { get; set; }


    }
}

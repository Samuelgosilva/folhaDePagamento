using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento.Classes
{
    class Frequencia
    {
        public int id_frequencia { get; set; } = 0;
        public int id_funcionario { get; } = 0;
        public string name_funcionario { get; } = "";
        public double horas_trabalhadas { get; set; } = 0;
        public int faltas { get; set; } = 0;
        public int faltas_justificadas { get; set; } = 0;
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        public DateTime dt_frequencia { get; set; }

    }
}

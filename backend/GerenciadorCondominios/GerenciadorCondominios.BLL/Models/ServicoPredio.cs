using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.BLL.Models
{
    public class ServicoPredio
    {
        public int ServicoPredio { get; set; }
        public int ServicoId { get; set; }
        public virtual Servico Servico { get; set; }
        public DateTime DataExecucao { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.BLL.Models
{
    public class Servico
    {
        public int ServicoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public Servico Status { get; set; }
        public string UsuarioId { get; set; }
        public ICollection<ServicoPreio> ServicoPredios { get; set; }
    }

    public enum StatusServico
    {
        Pendente, Recusado, 
    }
}

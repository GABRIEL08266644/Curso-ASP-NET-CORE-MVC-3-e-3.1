﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GerenciadorCondominios.BLL.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
    
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(50, ErrorMessage = "Usem menos caracteres")]
        public string Nome { get; set; }

        public DateTime Data { get; set; }
        public string UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}

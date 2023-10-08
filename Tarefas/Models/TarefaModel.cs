﻿using Tarefas.Enums;

namespace Tarefas.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public StatutsTarefa Status {get; set; }
    }
}

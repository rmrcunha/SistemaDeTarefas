﻿using System.ComponentModel;

namespace Tarefas.Enums
{
    public enum StatutsTarefa
    {
        [Description("A fazer")]
        AFazer = 1,
        [Description("Em andamento")]
        EmAndamento = 2,
        [Description("Concluído")]
        Concluido = 3
    }
}

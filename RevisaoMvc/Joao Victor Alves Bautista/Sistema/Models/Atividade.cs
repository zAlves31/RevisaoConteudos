using System;
using System.Collections.Generic;

namespace Sistema.Models;

public partial class Atividade
{
    public int AtividadeId { get; set; }

    public string? Descricao { get; set; }

    public int? TurmaId { get; set; }

    public virtual Turma? Turma { get; set; }
}

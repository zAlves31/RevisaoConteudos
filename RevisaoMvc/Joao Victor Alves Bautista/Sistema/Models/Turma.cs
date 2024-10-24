﻿using System;
using System.Collections.Generic;

namespace Sistema.Models;

public partial class Turma
{
    public int TurmaId { get; set; }

    public string? Nome { get; set; }

    public int? ProfessorId { get; set; }

    public virtual ICollection<Atividade> Atividades { get; set; } = new List<Atividade>();

    public virtual Professore? Professor { get; set; }
}

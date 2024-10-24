﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Sistema.Models;

namespace Sistema.Contexts;

public partial class SistemaContext : DbContext
{
    public SistemaContext()
    {
    }

    public SistemaContext(DbContextOptions<SistemaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Atividade> Atividades { get; set; }

    public virtual DbSet<Professore> Professores { get; set; }

    public virtual DbSet<Turma> Turmas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-MHF127S; Initial Catalog=dev_db;  User Id=sa; Password=Senai@134; TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Atividade>(entity =>
        {
            entity.HasKey(e => e.AtividadeId).HasName("PK__Atividad__742A5DF456A28F2E");

            entity.Property(e => e.Descricao)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Turma).WithMany(p => p.Atividades)
                .HasForeignKey(d => d.TurmaId)
                .HasConstraintName("FK__Atividade__Turma__4E88ABD4");
        });

        modelBuilder.Entity<Professore>(entity =>
        {
            entity.HasKey(e => e.ProfessorId).HasName("PK__Professo__90035949E51F21A1");

            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Senha)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Turma>(entity =>
        {
            entity.HasKey(e => e.TurmaId).HasName("PK__Turmas__BABB9304DD0C456E");

            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Professor).WithMany(p => p.Turmas)
                .HasForeignKey(d => d.ProfessorId)
                .HasConstraintName("FK__Turmas__Professo__4BAC3F29");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

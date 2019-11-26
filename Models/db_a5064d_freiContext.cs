using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections;

namespace Vivencia19TardeAPI.Models
{
    public partial class db_a5064d_freiContext : DbContext
    {
        public db_a5064d_freiContext()
        {
        }

        public db_a5064d_freiContext(DbContextOptions<db_a5064d_freiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAluno> TbAluno { get; set; }
        public virtual DbSet<TbAlunoCarometro> TbAlunoCarometro { get; set; }
        public virtual DbSet<TbAlunoDocumentos> TbAlunoDocumentos { get; set; }
        public virtual DbSet<TbAlunoFichaMedica> TbAlunoFichaMedica { get; set; }
        public virtual DbSet<TbAlunoLocalizacao> TbAlunoLocalizacao { get; set; }
        public virtual DbSet<TbAlunoMensalidade> TbAlunoMensalidade { get; set; }
        public virtual DbSet<TbAnoLetivo> TbAnoLetivo { get; set; }
        public virtual DbSet<TbCalendario> TbCalendario { get; set; }
        public virtual DbSet<TbCalendarioEvento> TbCalendarioEvento { get; set; }
        public virtual DbSet<TbCurso> TbCurso { get; set; }
        public virtual DbSet<TbCursoDisciplina> TbCursoDisciplina { get; set; }
        public virtual DbSet<TbDiarioAvaliacao> TbDiarioAvaliacao { get; set; }
        public virtual DbSet<TbDiarioAvaliacaoAluno> TbDiarioAvaliacaoAluno { get; set; }
        public virtual DbSet<TbDiarioAvaliacaoAlunoMedia> TbDiarioAvaliacaoAlunoMedia { get; set; }
        public virtual DbSet<TbDiarioAvaliacaoGeral> TbDiarioAvaliacaoGeral { get; set; }
        public virtual DbSet<TbDiarioConteudoGeral> TbDiarioConteudoGeral { get; set; }
        public virtual DbSet<TbDiarioFrequencia> TbDiarioFrequencia { get; set; }
        public virtual DbSet<TbDiarioFrequenciaAuto> TbDiarioFrequenciaAuto { get; set; }
        public virtual DbSet<TbDiarioFrequenciaGeral> TbDiarioFrequenciaGeral { get; set; }
        public virtual DbSet<TbDisciplina> TbDisciplina { get; set; }
        public virtual DbSet<TbEmail> TbEmail { get; set; }
        public virtual DbSet<TbFuncionario> TbFuncionario { get; set; }
        public virtual DbSet<TbGradeSemanal> TbGradeSemanal { get; set; }
        public virtual DbSet<TbInscricao> TbInscricao { get; set; }
        public virtual DbSet<TbInscricaoConflito> TbInscricaoConflito { get; set; }
        public virtual DbSet<TbInscricaoPagamento> TbInscricaoPagamento { get; set; }
        public virtual DbSet<TbInscritoAprovado> TbInscritoAprovado { get; set; }
        public virtual DbSet<TbIntegrationAcadesc> TbIntegrationAcadesc { get; set; }
        public virtual DbSet<TbLogin> TbLogin { get; set; }
        public virtual DbSet<TbModulo> TbModulo { get; set; }
        public virtual DbSet<TbModuloDisciplina> TbModuloDisciplina { get; set; }
        public virtual DbSet<TbModuloDisciplinaProfessor> TbModuloDisciplinaProfessor { get; set; }
        public virtual DbSet<TbProfessor> TbProfessor { get; set; }
        public virtual DbSet<TbProfessorDisciplina> TbProfessorDisciplina { get; set; }
        public virtual DbSet<TbRole> TbRole { get; set; }
        public virtual DbSet<TbSala> TbSala { get; set; }
        public virtual DbSet<TbSalaVestibular> TbSalaVestibular { get; set; }
        public virtual DbSet<TbTurma> TbTurma { get; set; }
        public virtual DbSet<TbTurmaAluno> TbTurmaAluno { get; set; }
        public virtual DbSet<TbTurmaAlunoHist> TbTurmaAlunoHist { get; set; }
        public virtual DbSet<TbTurmaInscricaoTransicao> TbTurmaInscricaoTransicao { get; set; }
        public virtual DbSet<TbTurmaSemana> TbTurmaSemana { get; set; }
        public virtual DbSet<TbVersaoSistema> TbVersaoSistema { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=mysql5022.site4now.net;user id=a5064d_frei;password=frei@123;database=db_a5064d_frei");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAluno>(entity =>
            {
                entity.HasKey(e => e.IdAluno)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsCelular)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsComoConheceu)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsCpf)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsEmail)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsEscolaridade)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsEtinia)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsObservacao)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsOrgao)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsRg)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsSexo)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmAluno)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmEscola)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.TpEscola)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TbAlunoCarometro>(entity =>
            {
                entity.HasKey(e => e.IdAlunoCarometro)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdAluno)
                    .HasName("fk_tb_aluno_carometro_tb_aluno_idx");

                entity.Property(e => e.DsImagem)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdAlunoNavigation)
                    .WithMany(p => p.TbAlunoCarometro)
                    .HasForeignKey(d => d.IdAluno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_aluno_carometro_tb_aluno");
            });

            modelBuilder.Entity<TbAlunoDocumentos>(entity =>
            {
                entity.HasKey(e => e.IdAlunoDocumentos)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdAluno)
                    .HasName("fk_tb_aluno_documentos_tb_aluno1_idx");

                entity.Property(e => e.NmDocumento)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdAlunoNavigation)
                    .WithMany(p => p.TbAlunoDocumentos)
                    .HasForeignKey(d => d.IdAluno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_aluno_documentos_tb_aluno1");
            });

            modelBuilder.Entity<TbAlunoFichaMedica>(entity =>
            {
                entity.HasKey(e => e.IdAlunoFichaMedica)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdAluno)
                    .HasName("fk_tb_aluno_ficha_medica_tb_aluno1_idx");

                entity.Property(e => e.DsAcompanhamento)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsAlergias)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsCongenitas)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsMedicacao)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsObservacao)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsTratamento)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdAlunoNavigation)
                    .WithMany(p => p.TbAlunoFichaMedica)
                    .HasForeignKey(d => d.IdAluno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_aluno_ficha_medica_tb_aluno1");
            });

            modelBuilder.Entity<TbAlunoLocalizacao>(entity =>
            {
                entity.HasKey(e => e.IdAlunoLocalizacao)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdAluno)
                    .HasName("fk_tb_aluno_localizacao_tb_aluno1_idx");

                entity.Property(e => e.DsNascimentoCidade)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsNascimentoEstado)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsNascimentoPais)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsResidenciaBairro)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsResidenciaCep)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsResidenciaCidade)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsResidenciaComplelemento)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsResidenciaEndereco)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsResidenciaEstado)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdAlunoNavigation)
                    .WithMany(p => p.TbAlunoLocalizacao)
                    .HasForeignKey(d => d.IdAluno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_aluno_localizacao_tb_aluno1");
            });

            modelBuilder.Entity<TbAlunoMensalidade>(entity =>
            {
                entity.HasKey(e => e.IdAlunoMensalidade)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdAluno)
                    .HasName("fk_tb_aluno_mensalidade_tb_aluno1_idx");

                entity.HasIndex(e => e.IdAnoLetivo)
                    .HasName("fk_tb_aluno_mensalidade_tb_ano_letivo1_idx");

                entity.Property(e => e.DsEmail)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsParentesco)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsRg)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsTelefone1)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsTelefone2)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmResponsavel)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdAlunoNavigation)
                    .WithMany(p => p.TbAlunoMensalidade)
                    .HasForeignKey(d => d.IdAluno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_aluno_mensalidade_tb_aluno1");

                entity.HasOne(d => d.IdAnoLetivoNavigation)
                    .WithMany(p => p.TbAlunoMensalidade)
                    .HasForeignKey(d => d.IdAnoLetivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_aluno_mensalidade_tb_ano_letivo1");
            });

            modelBuilder.Entity<TbAnoLetivo>(entity =>
            {
                entity.HasKey(e => e.IdAnoLetivo)
                    .HasName("PRIMARY");

                entity.Property(e => e.TpStatus)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TbCalendario>(entity =>
            {
                entity.HasKey(e => e.IdCalendario)
                    .HasName("PRIMARY");

                entity.Property(e => e.TpDia)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TbCalendarioEvento>(entity =>
            {
                entity.HasKey(e => e.IdCalendarioEvento)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdCalendario)
                    .HasName("fk_tb_calendario_evento_tb_calendario1_idx");

                entity.Property(e => e.DsEvento)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.TpEvento)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdCalendarioNavigation)
                    .WithMany(p => p.TbCalendarioEvento)
                    .HasForeignKey(d => d.IdCalendario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_calendario_evento_tb_calendario1");
            });

            modelBuilder.Entity<TbCurso>(entity =>
            {
                entity.HasKey(e => e.IdCurso)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsCategoria)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsSigla)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmCurso)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TbCursoDisciplina>(entity =>
            {
                entity.HasKey(e => e.IdCursoDisciplina)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdCurso)
                    .HasName("fk_tb_curso_disciplina_tb_curso1_idx");

                entity.HasIndex(e => e.IdDisciplina)
                    .HasName("fk_tb_curso_disciplina_tb_disciplina1_idx");

                entity.HasOne(d => d.IdCursoNavigation)
                    .WithMany(p => p.TbCursoDisciplina)
                    .HasForeignKey(d => d.IdCurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_curso_disciplina_tb_curso1");

                entity.HasOne(d => d.IdDisciplinaNavigation)
                    .WithMany(p => p.TbCursoDisciplina)
                    .HasForeignKey(d => d.IdDisciplina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_curso_disciplina_tb_disciplina1");
            });

            modelBuilder.Entity<TbDiarioAvaliacao>(entity =>
            {
                entity.HasKey(e => e.IdDiarioAvaliacao)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdModuloDisciplina)
                    .HasName("fk_tb_diario_avaliacao_tb_modulo_disciplina1_idx");

                entity.Property(e => e.DsGrupo)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsSigla)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmAvaliacao)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdModuloDisciplinaNavigation)
                    .WithMany(p => p.TbDiarioAvaliacao)
                    .HasForeignKey(d => d.IdModuloDisciplina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_diario_avaliacao_tb_modulo_disciplina1");
            });

            modelBuilder.Entity<TbDiarioAvaliacaoAluno>(entity =>
            {
                entity.HasKey(e => e.IdDiarioAvaliacaoAluno)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdDiarioAvaliacao)
                    .HasName("fk_tb_diario_avaliacao_aluno_tb_diario_avaliacao1_idx");

                entity.HasIndex(e => e.IdTurma)
                    .HasName("fk_tb_diario_avaliacao_aluno_tb_turma1_idx");

                entity.HasOne(d => d.IdDiarioAvaliacaoNavigation)
                    .WithMany(p => p.TbDiarioAvaliacaoAluno)
                    .HasForeignKey(d => d.IdDiarioAvaliacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_diario_avaliacao_aluno_tb_diario_avaliacao1");

                entity.HasOne(d => d.IdTurmaNavigation)
                    .WithMany(p => p.TbDiarioAvaliacaoAluno)
                    .HasForeignKey(d => d.IdTurma)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_diario_avaliacao_aluno_tb_turma1");
            });

            modelBuilder.Entity<TbDiarioAvaliacaoAlunoMedia>(entity =>
            {
                entity.HasKey(e => e.IdDiarioAvaliacaoAlunoMedia)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdModuloDisciplina)
                    .HasName("fk_tb_diario_avaliacao_aluno_media_tb_modulo_disciplina1_idx");

                entity.HasIndex(e => e.IdTurmaAluno)
                    .HasName("fk_tb_diario_avaliacao_aluno_media_tb_turma_aluno1_idx");

                entity.HasOne(d => d.IdModuloDisciplinaNavigation)
                    .WithMany(p => p.TbDiarioAvaliacaoAlunoMedia)
                    .HasForeignKey(d => d.IdModuloDisciplina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_diario_avaliacao_aluno_media_tb_modulo_disciplina1");

                entity.HasOne(d => d.IdTurmaAlunoNavigation)
                    .WithMany(p => p.TbDiarioAvaliacaoAlunoMedia)
                    .HasForeignKey(d => d.IdTurmaAluno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_diario_avaliacao_aluno_media_tb_turma_aluno1");
            });

            modelBuilder.Entity<TbDiarioAvaliacaoGeral>(entity =>
            {
                entity.HasKey(e => e.IdDiarioAvaliacaoGeral)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdAluno)
                    .HasName("fk_tb_diario_avaliacao_geral_tb_aluno1_idx");

                entity.HasIndex(e => e.IdModulo)
                    .HasName("fk_tb_diario_avaliacao_geral_tb_modulo1_idx");

                entity.HasIndex(e => e.TbDisciplinaIdDisciplina)
                    .HasName("fk_tb_diario_avaliacao_geral_tb_disciplina1_idx");

                entity.Property(e => e.TpNota)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdAlunoNavigation)
                    .WithMany(p => p.TbDiarioAvaliacaoGeral)
                    .HasForeignKey(d => d.IdAluno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_diario_avaliacao_geral_tb_aluno1");

                entity.HasOne(d => d.IdModuloNavigation)
                    .WithMany(p => p.TbDiarioAvaliacaoGeral)
                    .HasForeignKey(d => d.IdModulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_diario_avaliacao_geral_tb_modulo1");

                entity.HasOne(d => d.TbDisciplinaIdDisciplinaNavigation)
                    .WithMany(p => p.TbDiarioAvaliacaoGeral)
                    .HasForeignKey(d => d.TbDisciplinaIdDisciplina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_diario_avaliacao_geral_tb_disciplina1");
            });

            modelBuilder.Entity<TbDiarioConteudoGeral>(entity =>
            {
                entity.HasKey(e => e.IdDiarioConteudoGeral)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdModulo)
                    .HasName("fk_tb_diario_conteudo_geral_tb_modulo1_idx");

                entity.HasIndex(e => e.IdTurma)
                    .HasName("fk_tb_diario_conteudo_geral_tb_turma1_idx");

                entity.HasIndex(e => e.TbDisciplinaIdDisciplina)
                    .HasName("fk_tb_diario_conteudo_geral_tb_disciplina1_idx");

                entity.Property(e => e.DsConteudo)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdModuloNavigation)
                    .WithMany(p => p.TbDiarioConteudoGeral)
                    .HasForeignKey(d => d.IdModulo)
                    .HasConstraintName("fk_tb_diario_conteudo_geral_tb_modulo1");

                entity.HasOne(d => d.IdTurmaNavigation)
                    .WithMany(p => p.TbDiarioConteudoGeral)
                    .HasForeignKey(d => d.IdTurma)
                    .HasConstraintName("fk_tb_diario_conteudo_geral_tb_turma1");

                entity.HasOne(d => d.TbDisciplinaIdDisciplinaNavigation)
                    .WithMany(p => p.TbDiarioConteudoGeral)
                    .HasForeignKey(d => d.TbDisciplinaIdDisciplina)
                    .HasConstraintName("fk_tb_diario_conteudo_geral_tb_disciplina1");
            });

            modelBuilder.Entity<TbDiarioFrequencia>(entity =>
            {
                entity.HasKey(e => e.IdDiarioFrequencia)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdModuloDisciplina)
                    .HasName("fk_tb_diario_frequencia_tb_modulo_disciplina1_idx");

                entity.HasIndex(e => e.IdTurmaAluno)
                    .HasName("fk_tb_diario_frequencia_tb_turma_aluno1_idx");

                entity.Property(e => e.TpFrequencia)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdModuloDisciplinaNavigation)
                    .WithMany(p => p.TbDiarioFrequencia)
                    .HasForeignKey(d => d.IdModuloDisciplina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_diario_frequencia_tb_modulo_disciplina1");

                entity.HasOne(d => d.IdTurmaAlunoNavigation)
                    .WithMany(p => p.TbDiarioFrequencia)
                    .HasForeignKey(d => d.IdTurmaAluno)
                    .HasConstraintName("fk_tb_diario_frequencia_tb_turma_aluno1");
            });

            modelBuilder.Entity<TbDiarioFrequenciaAuto>(entity =>
            {
                entity.HasKey(e => e.IdDiarioFrequenciaAuto)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdLogin)
                    .HasName("fk_tb_diario_frequencia_auto_tb_login1_idx");

                entity.HasIndex(e => e.IdTurmaAluno)
                    .HasName("fk_tb_diario_frequencia_auto_tb_turma_aluno1_idx");

                entity.Property(e => e.DsObservacao)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.TpFrequencia)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdLoginNavigation)
                    .WithMany(p => p.TbDiarioFrequenciaAuto)
                    .HasForeignKey(d => d.IdLogin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_diario_frequencia_auto_tb_login1");

                entity.HasOne(d => d.IdTurmaAlunoNavigation)
                    .WithMany(p => p.TbDiarioFrequenciaAuto)
                    .HasForeignKey(d => d.IdTurmaAluno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_diario_frequencia_auto_tb_turma_aluno1");
            });

            modelBuilder.Entity<TbDiarioFrequenciaGeral>(entity =>
            {
                entity.HasKey(e => e.IdDiarioFrequenciaGeral)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdAluno)
                    .HasName("fk_tb_diario_frequencia_geral_tb_aluno1_idx");

                entity.HasIndex(e => e.IdDisciplina)
                    .HasName("fk_tb_diario_frequencia_geral_tb_disciplina1_idx");

                entity.HasIndex(e => e.IdModulo)
                    .HasName("fk_tb_diario_frequencia_geral_tb_modulo1_idx");

                entity.HasOne(d => d.IdAlunoNavigation)
                    .WithMany(p => p.TbDiarioFrequenciaGeral)
                    .HasForeignKey(d => d.IdAluno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_diario_frequencia_geral_tb_aluno1");

                entity.HasOne(d => d.IdDisciplinaNavigation)
                    .WithMany(p => p.TbDiarioFrequenciaGeral)
                    .HasForeignKey(d => d.IdDisciplina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_diario_frequencia_geral_tb_disciplina1");

                entity.HasOne(d => d.IdModuloNavigation)
                    .WithMany(p => p.TbDiarioFrequenciaGeral)
                    .HasForeignKey(d => d.IdModulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_diario_frequencia_geral_tb_modulo1");
            });

            modelBuilder.Entity<TbDisciplina>(entity =>
            {
                entity.HasKey(e => e.IdDisciplina)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsSigla)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmDisciplina)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TbEmail>(entity =>
            {
                entity.HasKey(e => e.IdEmail)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsMotivo)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TbFuncionario>(entity =>
            {
                entity.HasKey(e => e.IdFuncionario)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdLogin)
                    .HasName("fk_tb_funcionario_tb_login1_idx");

                entity.Property(e => e.DsCelular)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsCep)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsEmail)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsEndereco)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsTelefone)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmFuncionario)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdLoginNavigation)
                    .WithMany(p => p.TbFuncionario)
                    .HasForeignKey(d => d.IdLogin)
                    .HasConstraintName("fk_tb_funcionario_tb_login1");
            });

            modelBuilder.Entity<TbGradeSemanal>(entity =>
            {
                entity.HasKey(e => e.IdGradeSemanal)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdModulo)
                    .HasName("fk_tb_grade_semanal_tb_modulo1_idx");

                entity.HasIndex(e => e.IdTurma)
                    .HasName("fk_tb_grade_semanal_tb_turma1_idx");

                entity.HasIndex(e => e.TbDisciplinaIdDisciplina)
                    .HasName("fk_tb_grade_semanal_tb_disciplina1_idx");

                entity.Property(e => e.DsDia)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsHorario)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdModuloNavigation)
                    .WithMany(p => p.TbGradeSemanal)
                    .HasForeignKey(d => d.IdModulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_grade_semanal_tb_modulo1");

                entity.HasOne(d => d.IdTurmaNavigation)
                    .WithMany(p => p.TbGradeSemanal)
                    .HasForeignKey(d => d.IdTurma)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_grade_semanal_tb_turma1");

                entity.HasOne(d => d.TbDisciplinaIdDisciplinaNavigation)
                    .WithMany(p => p.TbGradeSemanal)
                    .HasForeignKey(d => d.TbDisciplinaIdDisciplina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_grade_semanal_tb_disciplina1");
            });

            modelBuilder.Entity<TbInscricao>(entity =>
            {
                entity.HasKey(e => e.IdInscricao)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdAnoLetivo)
                    .HasName("fk_tb_inscricao_tb_ano_letivo1_idx");

                entity.HasIndex(e => e.IdCurso)
                    .HasName("fk_tb_inscricao_tb_curso1_idx");

                entity.HasIndex(e => e.IdCurso2)
                    .HasName("fk_tb_inscricao_tb_curso2_idx");

                entity.HasIndex(e => e.IdSalaVestibular)
                    .HasName("fk_tb_inscricao_tb_sala_vestibular1_idx");

                entity.Property(e => e.DsComoConheceu)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsCorPele)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsCpf)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsCurso2Periodo)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsCursoPeriodo)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsEmail)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsEmailInscrito)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsEscolaridade)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsNascimentoCidade)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsNascimentoEstado)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsNascimentoPais)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsObservacao)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsOrgao)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsResidenciaBairro)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsResidenciaCep)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsResidenciaCidade)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsResidenciaComplelemento)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsResidenciaEndereco)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsResidenciaEstado)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsResponsavelCpf)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsResponsavelEmail)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsResponsavelNome)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsResponsavelParentesco)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsResponsavelRg)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsResponsavelTelefone)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsResponsavelTelefone2)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsRg)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsSexo)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsSituacao)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsTelefone)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsTelefone2)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmContato)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmEscola)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmInscrito)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.TpEscola)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdAnoLetivoNavigation)
                    .WithMany(p => p.TbInscricao)
                    .HasForeignKey(d => d.IdAnoLetivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_inscricao_tb_ano_letivo1");

                entity.HasOne(d => d.IdCursoNavigation)
                    .WithMany(p => p.TbInscricaoIdCursoNavigation)
                    .HasForeignKey(d => d.IdCurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_inscricao_tb_curso1");

                entity.HasOne(d => d.IdCurso2Navigation)
                    .WithMany(p => p.TbInscricaoIdCurso2Navigation)
                    .HasForeignKey(d => d.IdCurso2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_inscricao_tb_curso2");

                entity.HasOne(d => d.IdSalaVestibularNavigation)
                    .WithMany(p => p.TbInscricao)
                    .HasForeignKey(d => d.IdSalaVestibular)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_inscricao_tb_sala_vestibular1");
            });

            modelBuilder.Entity<TbInscricaoConflito>(entity =>
            {
                entity.HasKey(e => e.IdInscricaoConflito)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsEscolaridade)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsMotivo)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsRg)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmInscrito)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TbInscricaoPagamento>(entity =>
            {
                entity.HasKey(e => e.IdInscricaoPagamento)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsPeriodo)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmCurso)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmInscrito)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.TpPagamento)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TbInscritoAprovado>(entity =>
            {
                entity.HasKey(e => e.IdInscritoAprovado)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdInscricao)
                    .HasName("fk_tb_inscrito_aprovado_tb_inscricao1_idx");

                entity.HasOne(d => d.IdInscricaoNavigation)
                    .WithMany(p => p.TbInscritoAprovado)
                    .HasForeignKey(d => d.IdInscricao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_inscrito_aprovado_tb_inscricao1");
            });

            modelBuilder.Entity<TbIntegrationAcadesc>(entity =>
            {
                entity.HasKey(e => e.IdIntegrationAcadesc)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsPeriodo)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsRg)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsSituacao)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsTurma)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmAluno)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmCurso)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NrAnoLetivo)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TbLogin>(entity =>
            {
                entity.HasKey(e => e.IdLogin)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdRole)
                    .HasName("fk_tb_login_tb_role1_idx");

                entity.Property(e => e.DsLogin)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsSenha)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.TbLogin)
                    .HasForeignKey(d => d.IdRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_login_tb_role1");
            });

            modelBuilder.Entity<TbModulo>(entity =>
            {
                entity.HasKey(e => e.IdModulo)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdAnoLetivo)
                    .HasName("fk_tb_modulo_tb_ano_letivo1_idx");

                entity.Property(e => e.NmModulo)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.TpModulo)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdAnoLetivoNavigation)
                    .WithMany(p => p.TbModulo)
                    .HasForeignKey(d => d.IdAnoLetivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_modulo_tb_ano_letivo1");
            });

            modelBuilder.Entity<TbModuloDisciplina>(entity =>
            {
                entity.HasKey(e => e.IdModuloDisciplina)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdCurso)
                    .HasName("fk_tb_modulo_disciplina_tb_curso1_idx");

                entity.HasIndex(e => e.IdDisciplina)
                    .HasName("fk_tb_modulo_disciplina_tb_disciplina1_idx");

                entity.HasIndex(e => e.IdModulo)
                    .HasName("fk_tb_modulo_disciplina_tb_modulo1_idx");

                entity.HasOne(d => d.IdCursoNavigation)
                    .WithMany(p => p.TbModuloDisciplina)
                    .HasForeignKey(d => d.IdCurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_modulo_disciplina_tb_curso1");

                entity.HasOne(d => d.IdDisciplinaNavigation)
                    .WithMany(p => p.TbModuloDisciplina)
                    .HasForeignKey(d => d.IdDisciplina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_modulo_disciplina_tb_disciplina1");

                entity.HasOne(d => d.IdModuloNavigation)
                    .WithMany(p => p.TbModuloDisciplina)
                    .HasForeignKey(d => d.IdModulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_modulo_disciplina_tb_modulo1");
            });

            modelBuilder.Entity<TbModuloDisciplinaProfessor>(entity =>
            {
                entity.HasKey(e => e.IdModuloDisciplinaProfessor)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdModuloDisciplina)
                    .HasName("fk_tb_modulo_disciplina_professor_tb_modulo_disciplina1_idx");

                entity.HasIndex(e => e.IdProfessor)
                    .HasName("fk_tb_modulo_disciplina_professor_tb_professor1_idx");

                entity.HasIndex(e => e.IdTurma)
                    .HasName("fk_tb_modulo_disciplina_professor_tb_turma1_idx");

                entity.HasOne(d => d.IdModuloDisciplinaNavigation)
                    .WithMany(p => p.TbModuloDisciplinaProfessor)
                    .HasForeignKey(d => d.IdModuloDisciplina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_modulo_disciplina_professor_tb_modulo_disciplina1");

                entity.HasOne(d => d.IdProfessorNavigation)
                    .WithMany(p => p.TbModuloDisciplinaProfessor)
                    .HasForeignKey(d => d.IdProfessor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_modulo_disciplina_professor_tb_professor1");

                entity.HasOne(d => d.IdTurmaNavigation)
                    .WithMany(p => p.TbModuloDisciplinaProfessor)
                    .HasForeignKey(d => d.IdTurma)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_modulo_disciplina_professor_tb_turma1");
            });

            modelBuilder.Entity<TbProfessor>(entity =>
            {
                entity.HasKey(e => e.IdProfessor)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdLogin)
                    .HasName("fk_tb_professor_tb_login1_idx");

                entity.Property(e => e.DsCelular)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsCpf)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsCurso)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsCvLattes)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsEmail)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsEstado)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsFaculdade)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsRg)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsRgEmissor)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsRgOrgao)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsTelefone)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmMae)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmPai)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmProfessor)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.TpContratacao)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdLoginNavigation)
                    .WithMany(p => p.TbProfessor)
                    .HasForeignKey(d => d.IdLogin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_professor_tb_login1");
            });

            modelBuilder.Entity<TbProfessorDisciplina>(entity =>
            {
                entity.HasKey(e => e.IdProfessorDisciplina)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdDisciplina)
                    .HasName("fk_tb_professor_disciplina_tb_disciplina1_idx");

                entity.HasIndex(e => e.IdProfessor)
                    .HasName("fk_tb_professor_disciplina_tb_professor1_idx");

                entity.HasOne(d => d.IdDisciplinaNavigation)
                    .WithMany(p => p.TbProfessorDisciplina)
                    .HasForeignKey(d => d.IdDisciplina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_professor_disciplina_tb_disciplina1");

                entity.HasOne(d => d.IdProfessorNavigation)
                    .WithMany(p => p.TbProfessorDisciplina)
                    .HasForeignKey(d => d.IdProfessor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_professor_disciplina_tb_professor1");
            });

            modelBuilder.Entity<TbRole>(entity =>
            {
                entity.HasKey(e => e.IdRole)
                    .HasName("PRIMARY");

                entity.Property(e => e.NmRole)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TbSala>(entity =>
            {
                entity.HasKey(e => e.IdSala)
                    .HasName("PRIMARY");

                entity.Property(e => e.NmLocal)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmSala)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TbSalaVestibular>(entity =>
            {
                entity.HasKey(e => e.IdSalaVestibular)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdSala)
                    .HasName("fk_tb_sala_vestibular_tb_sala1_idx");

                entity.Property(e => e.DsPeriodo)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdSalaNavigation)
                    .WithMany(p => p.TbSalaVestibular)
                    .HasForeignKey(d => d.IdSala)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_sala_vestibular_tb_sala1");
            });

            modelBuilder.Entity<TbTurma>(entity =>
            {
                entity.HasKey(e => e.IdTurma)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdAnoLetivo)
                    .HasName("fk_tb_turma_tb_ano_letivo1_idx");

                entity.HasIndex(e => e.IdCurso)
                    .HasName("fk_tb_turma_tb_curso1_idx");

                entity.Property(e => e.NmTurma)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.TpPeriodo)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdAnoLetivoNavigation)
                    .WithMany(p => p.TbTurma)
                    .HasForeignKey(d => d.IdAnoLetivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_turma_tb_ano_letivo1");

                entity.HasOne(d => d.IdCursoNavigation)
                    .WithMany(p => p.TbTurma)
                    .HasForeignKey(d => d.IdCurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_turma_tb_curso1");
            });

            modelBuilder.Entity<TbTurmaAluno>(entity =>
            {
                entity.HasKey(e => e.IdTurmaAluno)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdAluno)
                    .HasName("fk_tb_turma_aluno_tb_aluno1_idx");

                entity.HasIndex(e => e.IdTurma)
                    .HasName("fk_tb_turma_aluno_tb_turma1_idx");

                entity.Property(e => e.CdRa)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsObservacao)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.TpStatus)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdAlunoNavigation)
                    .WithMany(p => p.TbTurmaAluno)
                    .HasForeignKey(d => d.IdAluno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_turma_aluno_tb_aluno1");

                entity.HasOne(d => d.IdTurmaNavigation)
                    .WithMany(p => p.TbTurmaAluno)
                    .HasForeignKey(d => d.IdTurma)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_turma_aluno_tb_turma1");
            });

            modelBuilder.Entity<TbTurmaAlunoHist>(entity =>
            {
                entity.HasKey(e => e.IdTurmaAlunoHist)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdAluno)
                    .HasName("fk_tb_turma_aluno_hist_tb_aluno1_idx");

                entity.HasIndex(e => e.IdTurma)
                    .HasName("fk_tb_turma_aluno_hist_tb_turma1_idx");

                entity.HasIndex(e => e.IdTurmaAluno)
                    .HasName("fk_tb_turma_aluno_hist_tb_turma_aluno1_idx");

                entity.Property(e => e.DsObserrvacao)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.TpStatus)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdAlunoNavigation)
                    .WithMany(p => p.TbTurmaAlunoHist)
                    .HasForeignKey(d => d.IdAluno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_turma_aluno_hist_tb_aluno1");

                entity.HasOne(d => d.IdTurmaNavigation)
                    .WithMany(p => p.TbTurmaAlunoHist)
                    .HasForeignKey(d => d.IdTurma)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_turma_aluno_hist_tb_turma1");

                entity.HasOne(d => d.IdTurmaAlunoNavigation)
                    .WithMany(p => p.TbTurmaAlunoHist)
                    .HasForeignKey(d => d.IdTurmaAluno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_turma_aluno_hist_tb_turma_aluno1");
            });

            modelBuilder.Entity<TbTurmaInscricaoTransicao>(entity =>
            {
                entity.HasKey(e => e.IdTurmaInscricaoTransicao)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdInscricao)
                    .HasName("fk_tb_turma_inscricao_transicao_tb_inscricao1_idx");

                entity.HasIndex(e => e.IdTurma)
                    .HasName("fk_tb_turma_inscricao_transicao_tb_turma1_idx");

                entity.HasOne(d => d.IdInscricaoNavigation)
                    .WithMany(p => p.TbTurmaInscricaoTransicao)
                    .HasForeignKey(d => d.IdInscricao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_turma_inscricao_transicao_tb_inscricao1");

                entity.HasOne(d => d.IdTurmaNavigation)
                    .WithMany(p => p.TbTurmaInscricaoTransicao)
                    .HasForeignKey(d => d.IdTurma)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_turma_inscricao_transicao_tb_turma1");
            });

            modelBuilder.Entity<TbTurmaSemana>(entity =>
            {
                entity.HasKey(e => e.IdTurmaSemana)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdTurma)
                    .HasName("fk_tb_turma_semana_tb_turma1_idx");

                entity.Property(e => e.TpDiaSemana)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdTurmaNavigation)
                    .WithMany(p => p.TbTurmaSemana)
                    .HasForeignKey(d => d.IdTurma)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_turma_semana_tb_turma1");
            });

            modelBuilder.Entity<TbVersaoSistema>(entity =>
            {
                entity.HasKey(e => e.IdVersaoSistema)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsCaminho)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsVersao)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

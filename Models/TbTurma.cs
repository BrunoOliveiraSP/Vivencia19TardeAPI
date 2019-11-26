using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_turma")]
    public partial class TbTurma
    {
        public TbTurma()
        {
            TbDiarioAvaliacaoAluno = new HashSet<TbDiarioAvaliacaoAluno>();
            TbDiarioConteudoGeral = new HashSet<TbDiarioConteudoGeral>();
            TbGradeSemanal = new HashSet<TbGradeSemanal>();
            TbModuloDisciplinaProfessor = new HashSet<TbModuloDisciplinaProfessor>();
            TbTurmaAluno = new HashSet<TbTurmaAluno>();
            TbTurmaAlunoHist = new HashSet<TbTurmaAlunoHist>();
            TbTurmaInscricaoTransicao = new HashSet<TbTurmaInscricaoTransicao>();
            TbTurmaSemana = new HashSet<TbTurmaSemana>();
        }

        [Key]
        [Column("id_turma", TypeName = "int(11)")]
        public int IdTurma { get; set; }
        [Column("id_curso", TypeName = "int(11)")]
        public int IdCurso { get; set; }
        [Column("id_ano_letivo", TypeName = "int(11)")]
        public int IdAnoLetivo { get; set; }
        [Required]
        [Column("nm_turma", TypeName = "varchar(50)")]
        public string NmTurma { get; set; }
        [Required]
        [Column("tp_periodo", TypeName = "varchar(50)")]
        public string TpPeriodo { get; set; }
        [Column("nr_capacidade_max", TypeName = "int(11)")]
        public int NrCapacidadeMax { get; set; }

        [ForeignKey(nameof(IdAnoLetivo))]
        [InverseProperty(nameof(TbAnoLetivo.TbTurma))]
        public virtual TbAnoLetivo IdAnoLetivoNavigation { get; set; }
        [ForeignKey(nameof(IdCurso))]
        [InverseProperty(nameof(TbCurso.TbTurma))]
        public virtual TbCurso IdCursoNavigation { get; set; }
        [InverseProperty("IdTurmaNavigation")]
        public virtual ICollection<TbDiarioAvaliacaoAluno> TbDiarioAvaliacaoAluno { get; set; }
        [InverseProperty("IdTurmaNavigation")]
        public virtual ICollection<TbDiarioConteudoGeral> TbDiarioConteudoGeral { get; set; }
        [InverseProperty("IdTurmaNavigation")]
        public virtual ICollection<TbGradeSemanal> TbGradeSemanal { get; set; }
        [InverseProperty("IdTurmaNavigation")]
        public virtual ICollection<TbModuloDisciplinaProfessor> TbModuloDisciplinaProfessor { get; set; }
        [InverseProperty("IdTurmaNavigation")]
        public virtual ICollection<TbTurmaAluno> TbTurmaAluno { get; set; }
        [InverseProperty("IdTurmaNavigation")]
        public virtual ICollection<TbTurmaAlunoHist> TbTurmaAlunoHist { get; set; }
        [InverseProperty("IdTurmaNavigation")]
        public virtual ICollection<TbTurmaInscricaoTransicao> TbTurmaInscricaoTransicao { get; set; }
        [InverseProperty("IdTurmaNavigation")]
        public virtual ICollection<TbTurmaSemana> TbTurmaSemana { get; set; }
    }
}

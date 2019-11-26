using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_diario_frequencia")]
    public partial class TbDiarioFrequencia
    {
        [Key]
        [Column("id_diario_frequencia", TypeName = "int(11)")]
        public int IdDiarioFrequencia { get; set; }
        [Column("id_modulo_disciplina", TypeName = "int(11)")]
        public int IdModuloDisciplina { get; set; }
        [Column("id_turma_aluno", TypeName = "int(11)")]
        public int? IdTurmaAluno { get; set; }
        [Column("dt_letivo", TypeName = "date")]
        public DateTime? DtLetivo { get; set; }
        [Column("tp_frequencia", TypeName = "varchar(50)")]
        public string TpFrequencia { get; set; }
        [Column("hr_aula", TypeName = "time")]
        public TimeSpan? HrAula { get; set; }
        [Column("dt_inclusao", TypeName = "datetime")]
        public DateTime? DtInclusao { get; set; }
        [Column("dt_ultima_alteracao", TypeName = "datetime")]
        public DateTime? DtUltimaAlteracao { get; set; }
        [Column("id_funcionario_alteracao", TypeName = "int(11)")]
        public int? IdFuncionarioAlteracao { get; set; }

        [ForeignKey(nameof(IdModuloDisciplina))]
        [InverseProperty(nameof(TbModuloDisciplina.TbDiarioFrequencia))]
        public virtual TbModuloDisciplina IdModuloDisciplinaNavigation { get; set; }
        [ForeignKey(nameof(IdTurmaAluno))]
        [InverseProperty(nameof(TbTurmaAluno.TbDiarioFrequencia))]
        public virtual TbTurmaAluno IdTurmaAlunoNavigation { get; set; }
    }
}

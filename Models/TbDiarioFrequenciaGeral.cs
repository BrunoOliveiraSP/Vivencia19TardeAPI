using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_diario_frequencia_geral")]
    public partial class TbDiarioFrequenciaGeral
    {
        [Key]
        [Column("id_diario_frequencia_geral", TypeName = "int(11)")]
        public int IdDiarioFrequenciaGeral { get; set; }
        [Column("id_aluno", TypeName = "int(11)")]
        public int IdAluno { get; set; }
        [Column("id_modulo", TypeName = "int(11)")]
        public int IdModulo { get; set; }
        [Column("id_disciplina", TypeName = "int(11)")]
        public int IdDisciplina { get; set; }
        [Column("qtd_faltas", TypeName = "int(11)")]
        public int QtdFaltas { get; set; }
        [Column("dt_inclusao", TypeName = "date")]
        public DateTime DtInclusao { get; set; }
        [Column("dt_ultimaalteracao", TypeName = "date")]
        public DateTime DtUltimaalteracao { get; set; }

        [ForeignKey(nameof(IdAluno))]
        [InverseProperty(nameof(TbAluno.TbDiarioFrequenciaGeral))]
        public virtual TbAluno IdAlunoNavigation { get; set; }
        [ForeignKey(nameof(IdDisciplina))]
        [InverseProperty(nameof(TbDisciplina.TbDiarioFrequenciaGeral))]
        public virtual TbDisciplina IdDisciplinaNavigation { get; set; }
        [ForeignKey(nameof(IdModulo))]
        [InverseProperty(nameof(TbModulo.TbDiarioFrequenciaGeral))]
        public virtual TbModulo IdModuloNavigation { get; set; }
    }
}

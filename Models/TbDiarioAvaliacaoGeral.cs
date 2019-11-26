using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_diario_avaliacao_geral")]
    public partial class TbDiarioAvaliacaoGeral
    {
        [Key]
        [Column("id_diario_avaliacao_geral", TypeName = "int(11)")]
        public int IdDiarioAvaliacaoGeral { get; set; }
        [Column("id_aluno", TypeName = "int(11)")]
        public int IdAluno { get; set; }
        [Column("id_modulo", TypeName = "int(11)")]
        public int IdModulo { get; set; }
        [Column("tb_disciplina_id_disciplina", TypeName = "int(11)")]
        public int TbDisciplinaIdDisciplina { get; set; }
        [Column("tp_nota", TypeName = "varchar(100)")]
        public string TpNota { get; set; }
        [Column("vl_nota", TypeName = "decimal(15,2)")]
        public decimal VlNota { get; set; }
        [Column("dt_inclusao", TypeName = "datetime")]
        public DateTime DtInclusao { get; set; }
        [Column("dt_ultimaalteracao", TypeName = "datetime")]
        public DateTime DtUltimaalteracao { get; set; }

        [ForeignKey(nameof(IdAluno))]
        [InverseProperty(nameof(TbAluno.TbDiarioAvaliacaoGeral))]
        public virtual TbAluno IdAlunoNavigation { get; set; }
        [ForeignKey(nameof(IdModulo))]
        [InverseProperty(nameof(TbModulo.TbDiarioAvaliacaoGeral))]
        public virtual TbModulo IdModuloNavigation { get; set; }
        [ForeignKey(nameof(TbDisciplinaIdDisciplina))]
        [InverseProperty(nameof(TbDisciplina.TbDiarioAvaliacaoGeral))]
        public virtual TbDisciplina TbDisciplinaIdDisciplinaNavigation { get; set; }
    }
}

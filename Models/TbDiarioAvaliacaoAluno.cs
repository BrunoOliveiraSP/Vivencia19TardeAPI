using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_diario_avaliacao_aluno")]
    public partial class TbDiarioAvaliacaoAluno
    {
        [Key]
        [Column("id_diario_avaliacao_aluno", TypeName = "int(11)")]
        public int IdDiarioAvaliacaoAluno { get; set; }
        [Column("id_diario_avaliacao", TypeName = "int(11)")]
        public int IdDiarioAvaliacao { get; set; }
        [Column("id_turma", TypeName = "int(11)")]
        public int IdTurma { get; set; }

        [ForeignKey(nameof(IdDiarioAvaliacao))]
        [InverseProperty(nameof(TbDiarioAvaliacao.TbDiarioAvaliacaoAluno))]
        public virtual TbDiarioAvaliacao IdDiarioAvaliacaoNavigation { get; set; }
        [ForeignKey(nameof(IdTurma))]
        [InverseProperty(nameof(TbTurma.TbDiarioAvaliacaoAluno))]
        public virtual TbTurma IdTurmaNavigation { get; set; }
    }
}

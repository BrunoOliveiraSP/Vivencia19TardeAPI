using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_turma_inscricao_transicao")]
    public partial class TbTurmaInscricaoTransicao
    {
        [Key]
        [Column("id_turma_inscricao_transicao", TypeName = "int(11)")]
        public int IdTurmaInscricaoTransicao { get; set; }
        [Column("id_turma", TypeName = "int(11)")]
        public int IdTurma { get; set; }
        [Column("id_inscricao", TypeName = "int(11)")]
        public int IdInscricao { get; set; }

        [ForeignKey(nameof(IdInscricao))]
        [InverseProperty(nameof(TbInscricao.TbTurmaInscricaoTransicao))]
        public virtual TbInscricao IdInscricaoNavigation { get; set; }
        [ForeignKey(nameof(IdTurma))]
        [InverseProperty(nameof(TbTurma.TbTurmaInscricaoTransicao))]
        public virtual TbTurma IdTurmaNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_diario_avaliacao_aluno_media")]
    public partial class TbDiarioAvaliacaoAlunoMedia
    {
        [Key]
        [Column("id_diario_avaliacao_aluno_media", TypeName = "int(11)")]
        public int IdDiarioAvaliacaoAlunoMedia { get; set; }
        [Column("id_modulo_disciplina", TypeName = "int(11)")]
        public int IdModuloDisciplina { get; set; }
        [Column("id_turma_aluno", TypeName = "int(11)")]
        public int IdTurmaAluno { get; set; }
        [Column("vl_media", TypeName = "decimal(15,2)")]
        public decimal VlMedia { get; set; }

        [ForeignKey(nameof(IdModuloDisciplina))]
        [InverseProperty(nameof(TbModuloDisciplina.TbDiarioAvaliacaoAlunoMedia))]
        public virtual TbModuloDisciplina IdModuloDisciplinaNavigation { get; set; }
        [ForeignKey(nameof(IdTurmaAluno))]
        [InverseProperty(nameof(TbTurmaAluno.TbDiarioAvaliacaoAlunoMedia))]
        public virtual TbTurmaAluno IdTurmaAlunoNavigation { get; set; }
    }
}

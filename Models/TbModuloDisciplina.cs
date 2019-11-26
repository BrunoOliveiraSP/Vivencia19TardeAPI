using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_modulo_disciplina")]
    public partial class TbModuloDisciplina
    {
        public TbModuloDisciplina()
        {
            TbDiarioAvaliacao = new HashSet<TbDiarioAvaliacao>();
            TbDiarioAvaliacaoAlunoMedia = new HashSet<TbDiarioAvaliacaoAlunoMedia>();
            TbDiarioFrequencia = new HashSet<TbDiarioFrequencia>();
            TbModuloDisciplinaProfessor = new HashSet<TbModuloDisciplinaProfessor>();
        }

        [Key]
        [Column("id_modulo_disciplina", TypeName = "int(11)")]
        public int IdModuloDisciplina { get; set; }
        [Column("id_disciplina", TypeName = "int(11)")]
        public int IdDisciplina { get; set; }
        [Column("id_curso", TypeName = "int(11)")]
        public int IdCurso { get; set; }
        [Column("id_modulo", TypeName = "int(11)")]
        public int IdModulo { get; set; }

        [ForeignKey(nameof(IdCurso))]
        [InverseProperty(nameof(TbCurso.TbModuloDisciplina))]
        public virtual TbCurso IdCursoNavigation { get; set; }
        [ForeignKey(nameof(IdDisciplina))]
        [InverseProperty(nameof(TbDisciplina.TbModuloDisciplina))]
        public virtual TbDisciplina IdDisciplinaNavigation { get; set; }
        [ForeignKey(nameof(IdModulo))]
        [InverseProperty(nameof(TbModulo.TbModuloDisciplina))]
        public virtual TbModulo IdModuloNavigation { get; set; }
        [InverseProperty("IdModuloDisciplinaNavigation")]
        public virtual ICollection<TbDiarioAvaliacao> TbDiarioAvaliacao { get; set; }
        [InverseProperty("IdModuloDisciplinaNavigation")]
        public virtual ICollection<TbDiarioAvaliacaoAlunoMedia> TbDiarioAvaliacaoAlunoMedia { get; set; }
        [InverseProperty("IdModuloDisciplinaNavigation")]
        public virtual ICollection<TbDiarioFrequencia> TbDiarioFrequencia { get; set; }
        [InverseProperty("IdModuloDisciplinaNavigation")]
        public virtual ICollection<TbModuloDisciplinaProfessor> TbModuloDisciplinaProfessor { get; set; }
    }
}

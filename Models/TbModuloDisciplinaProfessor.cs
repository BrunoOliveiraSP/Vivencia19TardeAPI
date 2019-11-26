using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_modulo_disciplina_professor")]
    public partial class TbModuloDisciplinaProfessor
    {
        [Key]
        [Column("id_modulo_disciplina_professor", TypeName = "int(11)")]
        public int IdModuloDisciplinaProfessor { get; set; }
        [Column("id_professor", TypeName = "int(11)")]
        public int IdProfessor { get; set; }
        [Column("id_modulo_disciplina", TypeName = "int(11)")]
        public int IdModuloDisciplina { get; set; }
        [Column("id_turma", TypeName = "int(11)")]
        public int IdTurma { get; set; }
        [Column("qtd_carga_horaria", TypeName = "int(11)")]
        public int QtdCargaHoraria { get; set; }

        [ForeignKey(nameof(IdModuloDisciplina))]
        [InverseProperty(nameof(TbModuloDisciplina.TbModuloDisciplinaProfessor))]
        public virtual TbModuloDisciplina IdModuloDisciplinaNavigation { get; set; }
        [ForeignKey(nameof(IdProfessor))]
        [InverseProperty(nameof(TbProfessor.TbModuloDisciplinaProfessor))]
        public virtual TbProfessor IdProfessorNavigation { get; set; }
        [ForeignKey(nameof(IdTurma))]
        [InverseProperty(nameof(TbTurma.TbModuloDisciplinaProfessor))]
        public virtual TbTurma IdTurmaNavigation { get; set; }
    }
}

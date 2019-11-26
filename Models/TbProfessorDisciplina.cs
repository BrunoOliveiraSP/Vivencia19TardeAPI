using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_professor_disciplina")]
    public partial class TbProfessorDisciplina
    {
        [Key]
        [Column("id_professor_disciplina", TypeName = "int(11)")]
        public int IdProfessorDisciplina { get; set; }
        [Column("id_professor", TypeName = "int(11)")]
        public int IdProfessor { get; set; }
        [Column("id_disciplina", TypeName = "int(11)")]
        public int IdDisciplina { get; set; }

        [ForeignKey(nameof(IdDisciplina))]
        [InverseProperty(nameof(TbDisciplina.TbProfessorDisciplina))]
        public virtual TbDisciplina IdDisciplinaNavigation { get; set; }
        [ForeignKey(nameof(IdProfessor))]
        [InverseProperty(nameof(TbProfessor.TbProfessorDisciplina))]
        public virtual TbProfessor IdProfessorNavigation { get; set; }
    }
}

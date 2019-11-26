using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_curso_disciplina")]
    public partial class TbCursoDisciplina
    {
        [Key]
        [Column("id_curso_disciplina", TypeName = "int(11)")]
        public int IdCursoDisciplina { get; set; }
        [Column("id_curso", TypeName = "int(11)")]
        public int IdCurso { get; set; }
        [Column("id_disciplina", TypeName = "int(11)")]
        public int IdDisciplina { get; set; }
        [Column("nr_carga_horaria", TypeName = "int(11)")]
        public int NrCargaHoraria { get; set; }

        [ForeignKey(nameof(IdCurso))]
        [InverseProperty(nameof(TbCurso.TbCursoDisciplina))]
        public virtual TbCurso IdCursoNavigation { get; set; }
        [ForeignKey(nameof(IdDisciplina))]
        [InverseProperty(nameof(TbDisciplina.TbCursoDisciplina))]
        public virtual TbDisciplina IdDisciplinaNavigation { get; set; }
    }
}

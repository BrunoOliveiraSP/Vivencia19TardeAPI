using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_grade_semanal")]
    public partial class TbGradeSemanal
    {
        [Key]
        [Column("id_grade_semanal", TypeName = "int(11)")]
        public int IdGradeSemanal { get; set; }
        [Column("id_modulo", TypeName = "int(11)")]
        public int IdModulo { get; set; }
        [Column("id_turma", TypeName = "int(11)")]
        public int IdTurma { get; set; }
        [Column("tb_disciplina_id_disciplina", TypeName = "int(11)")]
        public int TbDisciplinaIdDisciplina { get; set; }
        [Required]
        [Column("ds_dia", TypeName = "varchar(100)")]
        public string DsDia { get; set; }
        [Column("nr_horario", TypeName = "int(11)")]
        public int NrHorario { get; set; }
        [Required]
        [Column("ds_horario", TypeName = "varchar(100)")]
        public string DsHorario { get; set; }
        [Column("dt_inclusao", TypeName = "datetime")]
        public DateTime DtInclusao { get; set; }
        [Column("dt_ultimaalteracao", TypeName = "datetime")]
        public DateTime DtUltimaalteracao { get; set; }

        [ForeignKey(nameof(IdModulo))]
        [InverseProperty(nameof(TbModulo.TbGradeSemanal))]
        public virtual TbModulo IdModuloNavigation { get; set; }
        [ForeignKey(nameof(IdTurma))]
        [InverseProperty(nameof(TbTurma.TbGradeSemanal))]
        public virtual TbTurma IdTurmaNavigation { get; set; }
        [ForeignKey(nameof(TbDisciplinaIdDisciplina))]
        [InverseProperty(nameof(TbDisciplina.TbGradeSemanal))]
        public virtual TbDisciplina TbDisciplinaIdDisciplinaNavigation { get; set; }
    }
}

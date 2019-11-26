using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_turma_semana")]
    public partial class TbTurmaSemana
    {
        [Key]
        [Column("id_turma_semana", TypeName = "int(11)")]
        public int IdTurmaSemana { get; set; }
        [Column("id_turma", TypeName = "int(11)")]
        public int IdTurma { get; set; }
        [Column("hr_entrada", TypeName = "time")]
        public TimeSpan HrEntrada { get; set; }
        [Column("hr_saida", TypeName = "time")]
        public TimeSpan HrSaida { get; set; }
        [Required]
        [Column("tp_dia_semana", TypeName = "varchar(55)")]
        public string TpDiaSemana { get; set; }

        [ForeignKey(nameof(IdTurma))]
        [InverseProperty(nameof(TbTurma.TbTurmaSemana))]
        public virtual TbTurma IdTurmaNavigation { get; set; }
    }
}

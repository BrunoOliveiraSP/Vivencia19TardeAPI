using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_calendario_evento")]
    public partial class TbCalendarioEvento
    {
        [Key]
        [Column("id_calendario_evento", TypeName = "int(11)")]
        public int IdCalendarioEvento { get; set; }
        [Column("id_calendario", TypeName = "int(11)")]
        public int IdCalendario { get; set; }
        [Required]
        [Column("tp_evento", TypeName = "varchar(100)")]
        public string TpEvento { get; set; }
        [Column("hr_inicio", TypeName = "time")]
        public TimeSpan HrInicio { get; set; }
        [Column("hr_fim", TypeName = "time")]
        public TimeSpan HrFim { get; set; }
        [Required]
        [Column("ds_evento", TypeName = "varchar(4000)")]
        public string DsEvento { get; set; }

        [ForeignKey(nameof(IdCalendario))]
        [InverseProperty(nameof(TbCalendario.TbCalendarioEvento))]
        public virtual TbCalendario IdCalendarioNavigation { get; set; }
    }
}

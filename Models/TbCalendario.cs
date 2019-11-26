using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_calendario")]
    public partial class TbCalendario
    {
        public TbCalendario()
        {
            TbCalendarioEvento = new HashSet<TbCalendarioEvento>();
        }

        [Key]
        [Column("id_calendario", TypeName = "int(11)")]
        public int IdCalendario { get; set; }
        [Column("dt_calendario", TypeName = "date")]
        public DateTime DtCalendario { get; set; }
        [Required]
        [Column("tp_dia", TypeName = "varchar(100)")]
        public string TpDia { get; set; }

        [InverseProperty("IdCalendarioNavigation")]
        public virtual ICollection<TbCalendarioEvento> TbCalendarioEvento { get; set; }
    }
}

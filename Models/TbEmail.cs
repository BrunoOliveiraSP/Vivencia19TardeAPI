using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_email")]
    public partial class TbEmail
    {
        [Key]
        [Column("id_email", TypeName = "int(11)")]
        public int IdEmail { get; set; }
        [Column("dt_enviado", TypeName = "date")]
        public DateTime DtEnviado { get; set; }
        [Required]
        [Column("ds_motivo", TypeName = "varchar(100)")]
        public string DsMotivo { get; set; }
    }
}

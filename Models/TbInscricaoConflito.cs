using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_inscricao_conflito")]
    public partial class TbInscricaoConflito
    {
        [Key]
        [Column("id_inscricao_conflito", TypeName = "int(11)")]
        public int IdInscricaoConflito { get; set; }
        [Required]
        [Column("nm_inscrito", TypeName = "varchar(100)")]
        public string NmInscrito { get; set; }
        [Required]
        [Column("ds_rg", TypeName = "varchar(100)")]
        public string DsRg { get; set; }
        [Required]
        [Column("ds_motivo", TypeName = "varchar(50)")]
        public string DsMotivo { get; set; }
        [Required]
        [Column("ds_escolaridade", TypeName = "varchar(50)")]
        public string DsEscolaridade { get; set; }
    }
}

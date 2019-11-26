using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_integration_acadesc")]
    public partial class TbIntegrationAcadesc
    {
        [Key]
        [Column("id_integration_acadesc", TypeName = "int(11)")]
        public int IdIntegrationAcadesc { get; set; }
        [Required]
        [Column("nm_aluno", TypeName = "varchar(100)")]
        public string NmAluno { get; set; }
        [Required]
        [Column("ds_situacao", TypeName = "varchar(1)")]
        public string DsSituacao { get; set; }
        [Required]
        [Column("nm_curso", TypeName = "varchar(50)")]
        public string NmCurso { get; set; }
        [Required]
        [Column("ds_turma", TypeName = "varchar(1)")]
        public string DsTurma { get; set; }
        [Required]
        [Column("ds_rg", TypeName = "varchar(50)")]
        public string DsRg { get; set; }
        [Required]
        [Column("ds_periodo", TypeName = "varchar(50)")]
        public string DsPeriodo { get; set; }
        [Required]
        [Column("nr_ano_letivo", TypeName = "varchar(10)")]
        public string NrAnoLetivo { get; set; }
    }
}

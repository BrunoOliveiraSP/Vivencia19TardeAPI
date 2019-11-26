using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_inscricao_pagamento")]
    public partial class TbInscricaoPagamento
    {
        [Key]
        [Column("id_inscricao_pagamento", TypeName = "int(11)")]
        public int IdInscricaoPagamento { get; set; }
        [Column("cd_inscricao", TypeName = "int(11)")]
        public int CdInscricao { get; set; }
        [Required]
        [Column("nm_inscrito", TypeName = "varchar(200)")]
        public string NmInscrito { get; set; }
        [Required]
        [Column("nm_curso", TypeName = "varchar(50)")]
        public string NmCurso { get; set; }
        [Column("nr_ano_letivo", TypeName = "int(11)")]
        public int NrAnoLetivo { get; set; }
        [Required]
        [Column("ds_periodo", TypeName = "varchar(50)")]
        public string DsPeriodo { get; set; }
        [Column("dt_inclusao", TypeName = "date")]
        public DateTime? DtInclusao { get; set; }
        [Column("bt_isento", TypeName = "bit(1)")]
        public ulong BtIsento { get; set; }
        [Column("dt_pagamento", TypeName = "datetime")]
        public DateTime? DtPagamento { get; set; }
        [Column("tp_pagamento", TypeName = "varchar(50)")]
        public string TpPagamento { get; set; }
        [Column("nr_parcela", TypeName = "int(11)")]
        public int? NrParcela { get; set; }
    }
}

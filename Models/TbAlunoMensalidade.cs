using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_aluno_mensalidade")]
    public partial class TbAlunoMensalidade
    {
        [Key]
        [Column("id_aluno_mensalidade", TypeName = "int(11)")]
        public int IdAlunoMensalidade { get; set; }
        [Column("id_aluno", TypeName = "int(11)")]
        public int IdAluno { get; set; }
        [Column("id_ano_letivo", TypeName = "int(11)")]
        public int IdAnoLetivo { get; set; }
        [Column("ds_mesref", TypeName = "varchar(100)")]
        public string DsMesref { get; set; }
        [Column("nr_ordem", TypeName = "int(11)")]
        public int? NrOrdem { get; set; }
        [Column("bt_pago", TypeName = "bit(1)")]
        public ulong? BtPago { get; set; }
        [Column("bt_isento", TypeName = "bit(1)")]
        public ulong? BtIsento { get; set; }
        [Column("dt_inclusao", TypeName = "datetime")]
        public DateTime DtInclusao { get; set; }
        [Column("dt_ultima_alteracao", TypeName = "datetime")]
        public DateTime DtUltimaAlteracao { get; set; }
        [Column("id_funcionario_alteracao", TypeName = "int(11)")]
        public int IdFuncionarioAlteracao { get; set; }
        [Column("nr_folha_carne", TypeName = "varchar(50)")]
        public string NrFolhaCarne { get; set; }
        [Column("ds_observacao", TypeName = "varchar(800)")]
        public string DsObservacao { get; set; }
        [Column("vl_mensalidade", TypeName = "decimal(15,2)")]
        public decimal? VlMensalidade { get; set; }
        [Column("dt_pagamento", TypeName = "date")]
        public DateTime? DtPagamento { get; set; }
        [Required]
        [Column("tp_pagamento", TypeName = "varchar(50)")]
        public string TpPagamento { get; set; }
        [Column("nr_parcela", TypeName = "int(11)")]
        public int NrParcela { get; set; }

        [ForeignKey(nameof(IdAluno))]
        [InverseProperty(nameof(TbAluno.TbAlunoMensalidade))]
        public virtual TbAluno IdAlunoNavigation { get; set; }
        [ForeignKey(nameof(IdAnoLetivo))]
        [InverseProperty(nameof(TbAnoLetivo.TbAlunoMensalidade))]
        public virtual TbAnoLetivo IdAnoLetivoNavigation { get; set; }
    }
}

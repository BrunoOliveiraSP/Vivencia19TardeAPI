using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_ano_letivo")]
    public partial class TbAnoLetivo
    {
        public TbAnoLetivo()
        {
            TbAlunoMensalidade = new HashSet<TbAlunoMensalidade>();
            TbInscricao = new HashSet<TbInscricao>();
            TbModulo = new HashSet<TbModulo>();
            TbTurma = new HashSet<TbTurma>();
        }

        [Key]
        [Column("id_ano_letivo", TypeName = "int(11)")]
        public int IdAnoLetivo { get; set; }
        [Column("nr_ano", TypeName = "int(11)")]
        public int NrAno { get; set; }
        [Column("dt_inicio", TypeName = "date")]
        public DateTime DtInicio { get; set; }
        [Column("dt_fim", TypeName = "date")]
        public DateTime DtFim { get; set; }
        [Column("bt_ativo", TypeName = "bit(1)")]
        public ulong BtAtivo { get; set; }
        [Required]
        [Column("tp_status", TypeName = "varchar(50)")]
        public string TpStatus { get; set; }

        [InverseProperty("IdAnoLetivoNavigation")]
        public virtual ICollection<TbAlunoMensalidade> TbAlunoMensalidade { get; set; }
        [InverseProperty("IdAnoLetivoNavigation")]
        public virtual ICollection<TbInscricao> TbInscricao { get; set; }
        [InverseProperty("IdAnoLetivoNavigation")]
        public virtual ICollection<TbModulo> TbModulo { get; set; }
        [InverseProperty("IdAnoLetivoNavigation")]
        public virtual ICollection<TbTurma> TbTurma { get; set; }
    }
}

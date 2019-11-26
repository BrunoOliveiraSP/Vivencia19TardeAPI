using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_modulo")]
    public partial class TbModulo
    {
        public TbModulo()
        {
            TbDiarioAvaliacaoGeral = new HashSet<TbDiarioAvaliacaoGeral>();
            TbDiarioConteudoGeral = new HashSet<TbDiarioConteudoGeral>();
            TbDiarioFrequenciaGeral = new HashSet<TbDiarioFrequenciaGeral>();
            TbGradeSemanal = new HashSet<TbGradeSemanal>();
            TbModuloDisciplina = new HashSet<TbModuloDisciplina>();
        }

        [Key]
        [Column("id_modulo", TypeName = "int(11)")]
        public int IdModulo { get; set; }
        [Column("id_ano_letivo", TypeName = "int(11)")]
        public int IdAnoLetivo { get; set; }
        [Required]
        [Column("tp_modulo", TypeName = "varchar(50)")]
        public string TpModulo { get; set; }
        [Required]
        [Column("nm_modulo", TypeName = "varchar(50)")]
        public string NmModulo { get; set; }
        [Column("nr_modulo", TypeName = "int(11)")]
        public int NrModulo { get; set; }
        [Column("dt_inicio", TypeName = "date")]
        public DateTime DtInicio { get; set; }
        [Column("dt_final", TypeName = "date")]
        public DateTime DtFinal { get; set; }
        [Column("bt_aberto", TypeName = "bit(1)")]
        public ulong BtAberto { get; set; }

        [ForeignKey(nameof(IdAnoLetivo))]
        [InverseProperty(nameof(TbAnoLetivo.TbModulo))]
        public virtual TbAnoLetivo IdAnoLetivoNavigation { get; set; }
        [InverseProperty("IdModuloNavigation")]
        public virtual ICollection<TbDiarioAvaliacaoGeral> TbDiarioAvaliacaoGeral { get; set; }
        [InverseProperty("IdModuloNavigation")]
        public virtual ICollection<TbDiarioConteudoGeral> TbDiarioConteudoGeral { get; set; }
        [InverseProperty("IdModuloNavigation")]
        public virtual ICollection<TbDiarioFrequenciaGeral> TbDiarioFrequenciaGeral { get; set; }
        [InverseProperty("IdModuloNavigation")]
        public virtual ICollection<TbGradeSemanal> TbGradeSemanal { get; set; }
        [InverseProperty("IdModuloNavigation")]
        public virtual ICollection<TbModuloDisciplina> TbModuloDisciplina { get; set; }
    }
}

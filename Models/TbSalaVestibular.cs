using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_sala_vestibular")]
    public partial class TbSalaVestibular
    {
        public TbSalaVestibular()
        {
            TbInscricao = new HashSet<TbInscricao>();
        }

        [Key]
        [Column("id_sala_vestibular", TypeName = "int(11)")]
        public int IdSalaVestibular { get; set; }
        [Column("id_sala", TypeName = "int(11)")]
        public int IdSala { get; set; }
        [Required]
        [Column("ds_periodo", TypeName = "varchar(50)")]
        public string DsPeriodo { get; set; }
        [Column("nr_ordem", TypeName = "int(11)")]
        public int NrOrdem { get; set; }
        [Column("qt_inscritos", TypeName = "int(11)")]
        public int QtInscritos { get; set; }

        [ForeignKey(nameof(IdSala))]
        [InverseProperty(nameof(TbSala.TbSalaVestibular))]
        public virtual TbSala IdSalaNavigation { get; set; }
        [InverseProperty("IdSalaVestibularNavigation")]
        public virtual ICollection<TbInscricao> TbInscricao { get; set; }
    }
}

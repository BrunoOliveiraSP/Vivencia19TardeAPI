using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_inscrito_aprovado")]
    public partial class TbInscritoAprovado
    {
        [Key]
        [Column("id_inscrito_aprovado", TypeName = "int(11)")]
        public int IdInscritoAprovado { get; set; }
        [Column("id_inscricao", TypeName = "int(11)")]
        public int IdInscricao { get; set; }

        [ForeignKey(nameof(IdInscricao))]
        [InverseProperty(nameof(TbInscricao.TbInscritoAprovado))]
        public virtual TbInscricao IdInscricaoNavigation { get; set; }
    }
}

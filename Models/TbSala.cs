using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_sala")]
    public partial class TbSala
    {
        public TbSala()
        {
            TbSalaVestibular = new HashSet<TbSalaVestibular>();
        }

        [Key]
        [Column("id_sala", TypeName = "int(11)")]
        public int IdSala { get; set; }
        [Required]
        [Column("nm_local", TypeName = "varchar(100)")]
        public string NmLocal { get; set; }
        [Required]
        [Column("nm_sala", TypeName = "varchar(50)")]
        public string NmSala { get; set; }
        [Column("nr_capacidade_maxima", TypeName = "int(11)")]
        public int NrCapacidadeMaxima { get; set; }
        [Column("bt_ativo", TypeName = "bit(1)")]
        public ulong BtAtivo { get; set; }
        [Column("dt_inclusao", TypeName = "datetime")]
        public DateTime DtInclusao { get; set; }
        [Column("dt_alteracao", TypeName = "datetime")]
        public DateTime DtAlteracao { get; set; }
        [Column("id_funcionario_alteracao", TypeName = "int(11)")]
        public int IdFuncionarioAlteracao { get; set; }

        [InverseProperty("IdSalaNavigation")]
        public virtual ICollection<TbSalaVestibular> TbSalaVestibular { get; set; }
    }
}

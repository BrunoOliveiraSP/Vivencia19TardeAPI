using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_login")]
    public partial class TbLogin
    {
        public TbLogin()
        {
            TbDiarioFrequenciaAuto = new HashSet<TbDiarioFrequenciaAuto>();
            TbFuncionario = new HashSet<TbFuncionario>();
            TbProfessor = new HashSet<TbProfessor>();
        }

        [Key]
        [Column("id_login", TypeName = "int(11)")]
        public int IdLogin { get; set; }
        [Column("id_role", TypeName = "int(11)")]
        public int IdRole { get; set; }
        [Required]
        [Column("ds_login", TypeName = "varchar(50)")]
        public string DsLogin { get; set; }
        [Required]
        [Column("ds_senha", TypeName = "varchar(50)")]
        public string DsSenha { get; set; }
        [Column("bt_trocar", TypeName = "bit(1)")]
        public bool BtTrocar { get; set; }
        [Column("dt_inclusao", TypeName = "datetime")]
        public DateTime DtInclusao { get; set; }
        [Column("dt_ultimo_login", TypeName = "datetime")]
        public DateTime DtUltimoLogin { get; set; }
        [Column("bt_ativo", TypeName = "bit(1)")]
        public ulong BtAtivo { get; set; }

        [ForeignKey(nameof(IdRole))]
        [InverseProperty(nameof(TbRole.TbLogin))]
        public virtual TbRole IdRoleNavigation { get; set; }
        [InverseProperty("IdLoginNavigation")]
        public virtual ICollection<TbDiarioFrequenciaAuto> TbDiarioFrequenciaAuto { get; set; }
        [InverseProperty("IdLoginNavigation")]
        public virtual ICollection<TbFuncionario> TbFuncionario { get; set; }
        [InverseProperty("IdLoginNavigation")]
        public virtual ICollection<TbProfessor> TbProfessor { get; set; }
    }
}

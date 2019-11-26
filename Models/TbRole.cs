using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_role")]
    public partial class TbRole
    {
        public TbRole()
        {
            TbLogin = new HashSet<TbLogin>();
        }

        [Key]
        [Column("id_role", TypeName = "int(11)")]
        public int IdRole { get; set; }
        [Required]
        [Column("nm_role", TypeName = "varchar(50)")]
        public string NmRole { get; set; }

        [InverseProperty("IdRoleNavigation")]
        public virtual ICollection<TbLogin> TbLogin { get; set; }
    }
}

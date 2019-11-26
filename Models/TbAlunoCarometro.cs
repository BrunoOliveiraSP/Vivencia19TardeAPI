using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_aluno_carometro")]
    public partial class TbAlunoCarometro
    {
        [Key]
        [Column("id_aluno_carometro", TypeName = "int(11)")]
        public int IdAlunoCarometro { get; set; }
        [Column("id_aluno", TypeName = "int(11)")]
        public int IdAluno { get; set; }
        [Required]
        [Column("ds_imagem", TypeName = "varchar(200)")]
        public string DsImagem { get; set; }

        [ForeignKey(nameof(IdAluno))]
        [InverseProperty(nameof(TbAluno.TbAlunoCarometro))]
        public virtual TbAluno IdAlunoNavigation { get; set; }
    }
}

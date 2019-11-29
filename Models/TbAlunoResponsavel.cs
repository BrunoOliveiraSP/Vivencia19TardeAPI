using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_aluno_responsavel")]
    public partial class TbAlunoResponsavel
    {
        [Key]
        [Column("id_aluno_responsavel", TypeName = "int(11)")]
        public int IdAlunoResponsavel { get; set; }
        [Column("id_aluno", TypeName = "int(11)")]
        public int? IdAluno { get; set; }
        [Required]
        [Column("nm_responsavel", TypeName = "varchar(200)")]
        public string NmResponsavel { get; set; }
        [Column("ds_email", TypeName = "varchar(200)")]
        public string DsEmail { get; set; }
        [Column("ds_rg", TypeName = "varchar(200)")]
        public string DsRg { get; set; }
        [Required]
        [Column("ds_telefone1", TypeName = "varchar(50)")]
        public string DsTelefone1 { get; set; }
        [Column("ds_telefone2", TypeName = "varchar(50)")]
        public string DsTelefone2 { get; set; }
        [Required]
        [Column("ds_parentesco", TypeName = "varchar(100)")]
        public string DsParentesco { get; set; }
        [Column("dt_inclusao", TypeName = "datetime")]
        public DateTime DtInclusao { get; set; }
        [Column("dt_ultima_alteracao", TypeName = "datetime")]
        public DateTime DtUltimaAlteracao { get; set; }
        [Column("id_funcionario_alteracao", TypeName = "int(11)")]
        public int IdFuncionarioAlteracao { get; set; }

        [ForeignKey(nameof(IdAluno))]
        [InverseProperty(nameof(TbAluno.TbAlunoResponsavel))]
        public virtual TbAluno IdAlunoNavigation { get; set; }
    }
}

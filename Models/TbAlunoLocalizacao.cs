using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_aluno_localizacao")]
    public partial class TbAlunoLocalizacao
    {
        [Key]
        [Column("id_aluno_localizacao", TypeName = "int(11)")]
        public int IdAlunoLocalizacao { get; set; }
        [Column("id_aluno", TypeName = "int(11)")]
        public int IdAluno { get; set; }
        [Required]
        [Column("ds_residencia_cep", TypeName = "varchar(50)")]
        public string DsResidenciaCep { get; set; }
        [Required]
        [Column("ds_residencia_bairro", TypeName = "varchar(50)")]
        public string DsResidenciaBairro { get; set; }
        [Required]
        [Column("ds_residencia_cidade", TypeName = "varchar(100)")]
        public string DsResidenciaCidade { get; set; }
        [Required]
        [Column("ds_residencia_estado", TypeName = "varchar(100)")]
        public string DsResidenciaEstado { get; set; }
        [Required]
        [Column("ds_residencia_endereco", TypeName = "varchar(500)")]
        public string DsResidenciaEndereco { get; set; }
        [Required]
        [Column("ds_residencia_complelemento", TypeName = "varchar(100)")]
        public string DsResidenciaComplelemento { get; set; }
        [Column("nr_residencia_endereco", TypeName = "int(11)")]
        public int NrResidenciaEndereco { get; set; }
        [Required]
        [Column("ds_nascimento_cidade", TypeName = "varchar(50)")]
        public string DsNascimentoCidade { get; set; }
        [Required]
        [Column("ds_nascimento_estado", TypeName = "varchar(50)")]
        public string DsNascimentoEstado { get; set; }
        [Required]
        [Column("ds_nascimento_pais", TypeName = "varchar(50)")]
        public string DsNascimentoPais { get; set; }
        [Column("dt_inclusao", TypeName = "datetime")]
        public DateTime DtInclusao { get; set; }
        [Column("dt_ultima_alteracao", TypeName = "datetime")]
        public DateTime DtUltimaAlteracao { get; set; }
        [Column("id_funcionario_alteracao", TypeName = "int(11)")]
        public int IdFuncionarioAlteracao { get; set; }

        [ForeignKey(nameof(IdAluno))]
        [InverseProperty(nameof(TbAluno.TbAlunoLocalizacao))]
        public virtual TbAluno IdAlunoNavigation { get; set; }
    }
}

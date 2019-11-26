using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_aluno_mensalidade")]
    public partial class TbAlunoMensalidade
    {
        [Key]
        [Column("id_aluno_mensalidade", TypeName = "int(11)")]
        public int IdAlunoMensalidade { get; set; }
        [Column("id_aluno", TypeName = "int(11)")]
        public int IdAluno { get; set; }
        [Column("id_ano_letivo", TypeName = "int(11)")]
        public int IdAnoLetivo { get; set; }
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
        [InverseProperty(nameof(TbAluno.TbAlunoMensalidade))]
        public virtual TbAluno IdAlunoNavigation { get; set; }
        [ForeignKey(nameof(IdAnoLetivo))]
        [InverseProperty(nameof(TbAnoLetivo.TbAlunoMensalidade))]
        public virtual TbAnoLetivo IdAnoLetivoNavigation { get; set; }
    }
}

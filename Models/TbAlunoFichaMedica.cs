using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_aluno_ficha_medica")]
    public partial class TbAlunoFichaMedica
    {
        [Key]
        [Column("id_aluno_ficha_medica", TypeName = "int(11)")]
        public int IdAlunoFichaMedica { get; set; }
        [Column("id_aluno", TypeName = "int(11)")]
        public int IdAluno { get; set; }
        [Column("ds_alergias", TypeName = "varchar(2000)")]
        public string DsAlergias { get; set; }
        [Column("ds_congenitas", TypeName = "varchar(2000)")]
        public string DsCongenitas { get; set; }
        [Column("ds_tratamento", TypeName = "varchar(2000)")]
        public string DsTratamento { get; set; }
        [Column("ds_acompanhamento", TypeName = "varchar(2000)")]
        public string DsAcompanhamento { get; set; }
        [Column("ds_medicacao", TypeName = "varchar(2000)")]
        public string DsMedicacao { get; set; }
        [Column("ds_observacao", TypeName = "varchar(2000)")]
        public string DsObservacao { get; set; }
        [Column("dt_inclusao", TypeName = "datetime")]
        public DateTime DtInclusao { get; set; }
        [Column("dt_ultima_alteracao", TypeName = "datetime")]
        public DateTime DtUltimaAlteracao { get; set; }
        [Column("id_funcionario_alteracao", TypeName = "int(11)")]
        public int IdFuncionarioAlteracao { get; set; }

        [ForeignKey(nameof(IdAluno))]
        [InverseProperty(nameof(TbAluno.TbAlunoFichaMedica))]
        public virtual TbAluno IdAlunoNavigation { get; set; }
    }
}

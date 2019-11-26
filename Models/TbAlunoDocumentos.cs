using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_aluno_documentos")]
    public partial class TbAlunoDocumentos
    {
        [Key]
        [Column("id_aluno_documentos", TypeName = "int(11)")]
        public int IdAlunoDocumentos { get; set; }
        [Column("id_aluno", TypeName = "int(11)")]
        public int IdAluno { get; set; }
        [Required]
        [Column("nm_documento", TypeName = "varchar(2000)")]
        public string NmDocumento { get; set; }
        [Column("bt_entregue", TypeName = "bit(1)")]
        public ulong BtEntregue { get; set; }
        [Column("dt_inclusao", TypeName = "datetime")]
        public DateTime DtInclusao { get; set; }
        [Column("dt_ultima_alteracao", TypeName = "datetime")]
        public DateTime DtUltimaAlteracao { get; set; }
        [Column("id_funcionario_alteracao", TypeName = "int(11)")]
        public int IdFuncionarioAlteracao { get; set; }

        [ForeignKey(nameof(IdAluno))]
        [InverseProperty(nameof(TbAluno.TbAlunoDocumentos))]
        public virtual TbAluno IdAlunoNavigation { get; set; }
    }
}

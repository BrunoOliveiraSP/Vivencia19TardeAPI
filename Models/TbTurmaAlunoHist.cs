using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_turma_aluno_hist")]
    public partial class TbTurmaAlunoHist
    {
        [Key]
        [Column("id_turma_aluno_hist", TypeName = "int(11)")]
        public int IdTurmaAlunoHist { get; set; }
        [Column("id_turma_aluno", TypeName = "int(11)")]
        public int IdTurmaAluno { get; set; }
        [Column("id_turma", TypeName = "int(11)")]
        public int IdTurma { get; set; }
        [Column("id_aluno", TypeName = "int(11)")]
        public int IdAluno { get; set; }
        [Column("nr_chamada", TypeName = "int(11)")]
        public int NrChamada { get; set; }
        [Column("bt_ativo", TypeName = "bit(1)")]
        public ulong BtAtivo { get; set; }
        [Required]
        [Column("tp_status", TypeName = "varchar(55)")]
        public string TpStatus { get; set; }
        [Required]
        [Column("ds_obserrvacao", TypeName = "varchar(400)")]
        public string DsObserrvacao { get; set; }
        [Column("dt_inclusao", TypeName = "datetime")]
        public DateTime DtInclusao { get; set; }

        [ForeignKey(nameof(IdAluno))]
        [InverseProperty(nameof(TbAluno.TbTurmaAlunoHist))]
        public virtual TbAluno IdAlunoNavigation { get; set; }
        [ForeignKey(nameof(IdTurmaAluno))]
        [InverseProperty(nameof(TbTurmaAluno.TbTurmaAlunoHist))]
        public virtual TbTurmaAluno IdTurmaAlunoNavigation { get; set; }
        [ForeignKey(nameof(IdTurma))]
        [InverseProperty(nameof(TbTurma.TbTurmaAlunoHist))]
        public virtual TbTurma IdTurmaNavigation { get; set; }
    }
}

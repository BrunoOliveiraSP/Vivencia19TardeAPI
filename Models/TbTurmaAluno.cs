using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_turma_aluno")]
    public partial class TbTurmaAluno
    {
        public TbTurmaAluno()
        {
            TbDiarioAvaliacaoAlunoMedia = new HashSet<TbDiarioAvaliacaoAlunoMedia>();
            TbDiarioFrequencia = new HashSet<TbDiarioFrequencia>();
            TbDiarioFrequenciaAuto = new HashSet<TbDiarioFrequenciaAuto>();
            TbTurmaAlunoHist = new HashSet<TbTurmaAlunoHist>();
        }

        [Key]
        [Column("id_turma_aluno", TypeName = "int(11)")]
        public int IdTurmaAluno { get; set; }
        [Column("id_turma", TypeName = "int(11)")]
        public int IdTurma { get; set; }
        [Column("id_aluno", TypeName = "int(11)")]
        public int IdAluno { get; set; }
        [Column("nr_chamada", TypeName = "int(11)")]
        public int NrChamada { get; set; }
        [Required]
        [Column("cd_ra", TypeName = "varchar(55)")]
        public string CdRa { get; set; }
        [Required]
        [Column("tp_status", TypeName = "varchar(55)")]
        public string TpStatus { get; set; }
        [Column("bt_ativo", TypeName = "bit(1)")]
        public ulong BtAtivo { get; set; }
        [Column("bt_permissao_atraso", TypeName = "bit(1)")]
        public ulong BtPermissaoAtraso { get; set; }
        [Required]
        [Column("ds_observacao", TypeName = "varchar(400)")]
        public string DsObservacao { get; set; }

        [ForeignKey(nameof(IdAluno))]
        [InverseProperty(nameof(TbAluno.TbTurmaAluno))]
        public virtual TbAluno IdAlunoNavigation { get; set; }
        [ForeignKey(nameof(IdTurma))]
        [InverseProperty(nameof(TbTurma.TbTurmaAluno))]
        public virtual TbTurma IdTurmaNavigation { get; set; }
        [InverseProperty("IdTurmaAlunoNavigation")]
        public virtual ICollection<TbDiarioAvaliacaoAlunoMedia> TbDiarioAvaliacaoAlunoMedia { get; set; }
        [InverseProperty("IdTurmaAlunoNavigation")]
        public virtual ICollection<TbDiarioFrequencia> TbDiarioFrequencia { get; set; }
        [InverseProperty("IdTurmaAlunoNavigation")]
        public virtual ICollection<TbDiarioFrequenciaAuto> TbDiarioFrequenciaAuto { get; set; }
        [InverseProperty("IdTurmaAlunoNavigation")]
        public virtual ICollection<TbTurmaAlunoHist> TbTurmaAlunoHist { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_diario_frequencia_auto")]
    public partial class TbDiarioFrequenciaAuto
    {
        [Key]
        [Column("id_diario_frequencia_auto", TypeName = "int(11)")]
        public int IdDiarioFrequenciaAuto { get; set; }
        [Column("id_turma_aluno", TypeName = "int(11)")]
        public int IdTurmaAluno { get; set; }
        [Column("dt_frequencia", TypeName = "date")]
        public DateTime DtFrequencia { get; set; }
        [Required]
        [Column("tp_frequencia", TypeName = "varchar(45)")]
        public string TpFrequencia { get; set; }
        [Column("bt_atraso", TypeName = "bit(1)")]
        public ulong? BtAtraso { get; set; }
        [Column("ds_observacao", TypeName = "varchar(200)")]
        public string DsObservacao { get; set; }
        [Column("dt_inclusao", TypeName = "date")]
        public DateTime DtInclusao { get; set; }
        [Column("dt_ultimaalteracao", TypeName = "date")]
        public DateTime DtUltimaalteracao { get; set; }
        [Column("id_login", TypeName = "int(11)")]
        public int IdLogin { get; set; }

        [ForeignKey(nameof(IdLogin))]
        [InverseProperty(nameof(TbLogin.TbDiarioFrequenciaAuto))]
        public virtual TbLogin IdLoginNavigation { get; set; }
        [ForeignKey(nameof(IdTurmaAluno))]
        [InverseProperty(nameof(TbTurmaAluno.TbDiarioFrequenciaAuto))]
        public virtual TbTurmaAluno IdTurmaAlunoNavigation { get; set; }
    }
}

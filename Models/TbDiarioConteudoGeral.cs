using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_diario_conteudo_geral")]
    public partial class TbDiarioConteudoGeral
    {
        [Key]
        [Column("id_diario_conteudo_geral", TypeName = "int(11)")]
        public int IdDiarioConteudoGeral { get; set; }
        [Column("id_turma", TypeName = "int(11)")]
        public int? IdTurma { get; set; }
        [Column("id_modulo", TypeName = "int(11)")]
        public int? IdModulo { get; set; }
        [Column("tb_disciplina_id_disciplina", TypeName = "int(11)")]
        public int? TbDisciplinaIdDisciplina { get; set; }
        [Column("dt_conteudo", TypeName = "date")]
        public DateTime DtConteudo { get; set; }
        [Column("ds_conteudo", TypeName = "varchar(4000)")]
        public string DsConteudo { get; set; }

        [ForeignKey(nameof(IdModulo))]
        [InverseProperty(nameof(TbModulo.TbDiarioConteudoGeral))]
        public virtual TbModulo IdModuloNavigation { get; set; }
        [ForeignKey(nameof(IdTurma))]
        [InverseProperty(nameof(TbTurma.TbDiarioConteudoGeral))]
        public virtual TbTurma IdTurmaNavigation { get; set; }
        [ForeignKey(nameof(TbDisciplinaIdDisciplina))]
        [InverseProperty(nameof(TbDisciplina.TbDiarioConteudoGeral))]
        public virtual TbDisciplina TbDisciplinaIdDisciplinaNavigation { get; set; }
    }
}

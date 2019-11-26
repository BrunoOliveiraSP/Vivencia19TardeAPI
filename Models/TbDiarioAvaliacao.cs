using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_diario_avaliacao")]
    public partial class TbDiarioAvaliacao
    {
        public TbDiarioAvaliacao()
        {
            TbDiarioAvaliacaoAluno = new HashSet<TbDiarioAvaliacaoAluno>();
        }

        [Key]
        [Column("id_diario_avaliacao", TypeName = "int(11)")]
        public int IdDiarioAvaliacao { get; set; }
        [Required]
        [Column("nm_avaliacao", TypeName = "varchar(55)")]
        public string NmAvaliacao { get; set; }
        [Required]
        [Column("ds_sigla", TypeName = "varchar(55)")]
        public string DsSigla { get; set; }
        [Required]
        [Column("ds_grupo", TypeName = "varchar(50)")]
        public string DsGrupo { get; set; }
        [Column("vl_peso", TypeName = "decimal(15,2)")]
        public decimal VlPeso { get; set; }
        [Column("dt_inclusao", TypeName = "datetime")]
        public DateTime DtInclusao { get; set; }
        [Column("dt_utima_alteracao", TypeName = "datetime")]
        public DateTime DtUtimaAlteracao { get; set; }
        [Column("id_funcionario_alteracao", TypeName = "int(11)")]
        public int IdFuncionarioAlteracao { get; set; }
        [Column("id_modulo_disciplina", TypeName = "int(11)")]
        public int IdModuloDisciplina { get; set; }

        [ForeignKey(nameof(IdModuloDisciplina))]
        [InverseProperty(nameof(TbModuloDisciplina.TbDiarioAvaliacao))]
        public virtual TbModuloDisciplina IdModuloDisciplinaNavigation { get; set; }
        [InverseProperty("IdDiarioAvaliacaoNavigation")]
        public virtual ICollection<TbDiarioAvaliacaoAluno> TbDiarioAvaliacaoAluno { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_curso")]
    public partial class TbCurso
    {
        public TbCurso()
        {
            TbCursoDisciplina = new HashSet<TbCursoDisciplina>();
            TbInscricaoIdCurso2Navigation = new HashSet<TbInscricao>();
            TbInscricaoIdCursoNavigation = new HashSet<TbInscricao>();
            TbModuloDisciplina = new HashSet<TbModuloDisciplina>();
            TbTurma = new HashSet<TbTurma>();
        }

        [Key]
        [Column("id_curso", TypeName = "int(11)")]
        public int IdCurso { get; set; }
        [Required]
        [Column("nm_curso", TypeName = "varchar(50)")]
        public string NmCurso { get; set; }
        [Required]
        [Column("ds_sigla", TypeName = "varchar(50)")]
        public string DsSigla { get; set; }
        [Column("nr_capacidade_maxima", TypeName = "int(11)")]
        public int NrCapacidadeMaxima { get; set; }
        [Column("bt_ativo", TypeName = "bit(1)")]
        public bool BtAtivo { get; set; }
        [Column("dt_criacao", TypeName = "datetime")]
        public DateTime DtCriacao { get; set; }
        [Column("dt_ultima_alteracao", TypeName = "datetime")]
        public DateTime DtUltimaAlteracao { get; set; }
        [Column("id_funcionario_alteracao", TypeName = "int(11)")]
        public int IdFuncionarioAlteracao { get; set; }
        [Required]
        [Column("ds_categoria", TypeName = "varchar(50)")]
        public string DsCategoria { get; set; }

        [InverseProperty("IdCursoNavigation")]
        public virtual ICollection<TbCursoDisciplina> TbCursoDisciplina { get; set; }
        [InverseProperty(nameof(TbInscricao.IdCurso2Navigation))]
        public virtual ICollection<TbInscricao> TbInscricaoIdCurso2Navigation { get; set; }
        [InverseProperty(nameof(TbInscricao.IdCursoNavigation))]
        public virtual ICollection<TbInscricao> TbInscricaoIdCursoNavigation { get; set; }
        [InverseProperty("IdCursoNavigation")]
        public virtual ICollection<TbModuloDisciplina> TbModuloDisciplina { get; set; }
        [InverseProperty("IdCursoNavigation")]
        public virtual ICollection<TbTurma> TbTurma { get; set; }
    }
}

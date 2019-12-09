using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_disciplina")]
    public partial class TbDisciplina
    {
        public TbDisciplina()
        {
            TbCursoDisciplina = new HashSet<TbCursoDisciplina>();
            TbDiarioAvaliacaoGeral = new HashSet<TbDiarioAvaliacaoGeral>();
            TbDiarioConteudoGeral = new HashSet<TbDiarioConteudoGeral>();
            TbDiarioFrequenciaGeral = new HashSet<TbDiarioFrequenciaGeral>();
            TbGradeSemanal = new HashSet<TbGradeSemanal>();
            TbModuloDisciplina = new HashSet<TbModuloDisciplina>();
            TbProfessorDisciplina = new HashSet<TbProfessorDisciplina>();
        }

        [Key]
        [Column("id_disciplina", TypeName = "int(11)")]
        public int IdDisciplina { get; set; }
        //[Required]
        [Column("nm_disciplina", TypeName = "varchar(50)")]
        public string NmDisciplina { get; set; }
        //[Required]
        [Column("ds_sigla", TypeName = "varchar(50)")]
        public string DsSigla { get; set; }
        [Column("bt_ativo", TypeName = "bit(1)")]
        public bool BtAtivo { get; set; }
        [Column("dt_ultima_alteracao", TypeName = "datetime")]
        public DateTime DtUltimaAlteracao { get; set; }
        [Column("dt_inclusao", TypeName = "datetime")]
        public DateTime DtInclusao { get; set; }
        [Column("id_funcionario_alteracao", TypeName = "int(11)")]
        public int IdFuncionarioAlteracao { get; set; }

        [InverseProperty("IdDisciplinaNavigation")]
        public virtual ICollection<TbCursoDisciplina> TbCursoDisciplina { get; set; }
        [InverseProperty("TbDisciplinaIdDisciplinaNavigation")]
        public virtual ICollection<TbDiarioAvaliacaoGeral> TbDiarioAvaliacaoGeral { get; set; }
        [InverseProperty("TbDisciplinaIdDisciplinaNavigation")]
        public virtual ICollection<TbDiarioConteudoGeral> TbDiarioConteudoGeral { get; set; }
        [InverseProperty("IdDisciplinaNavigation")]
        public virtual ICollection<TbDiarioFrequenciaGeral> TbDiarioFrequenciaGeral { get; set; }
        [InverseProperty("TbDisciplinaIdDisciplinaNavigation")]
        public virtual ICollection<TbGradeSemanal> TbGradeSemanal { get; set; }
        [InverseProperty("IdDisciplinaNavigation")]
        public virtual ICollection<TbModuloDisciplina> TbModuloDisciplina { get; set; }
        [InverseProperty("IdDisciplinaNavigation")]
        public virtual ICollection<TbProfessorDisciplina> TbProfessorDisciplina { get; set; }
    }
}

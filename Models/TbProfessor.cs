using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_professor")]
    public partial class TbProfessor
    {
        public TbProfessor()
        {
            TbModuloDisciplinaProfessor = new HashSet<TbModuloDisciplinaProfessor>();
            TbProfessorDisciplina = new HashSet<TbProfessorDisciplina>();
        }

        [Key]
        [Column("id_professor", TypeName = "int(11)")]
        public int IdProfessor { get; set; }
        [Column("id_login", TypeName = "int(11)")]
        public int IdLogin { get; set; }
        [Required]
        [Column("nm_professor", TypeName = "varchar(100)")]
        public string NmProfessor { get; set; }
        [Required]
        [Column("ds_celular", TypeName = "varchar(100)")]
        public string DsCelular { get; set; }
        [Required]
        [Column("ds_telefone", TypeName = "varchar(50)")]
        public string DsTelefone { get; set; }
        [Column("dt_nascimento", TypeName = "date")]
        public DateTime DtNascimento { get; set; }
        [Required]
        [Column("ds_estado", TypeName = "varchar(50)")]
        public string DsEstado { get; set; }
        [Required]
        [Column("ds_email", TypeName = "varchar(100)")]
        public string DsEmail { get; set; }
        [Required]
        [Column("ds_cv_lattes", TypeName = "varchar(200)")]
        public string DsCvLattes { get; set; }
        [Column("nr_ano_primeiro_emprego", TypeName = "int(11)")]
        public int NrAnoPrimeiroEmprego { get; set; }
        [Required]
        [Column("ds_cpf", TypeName = "varchar(50)")]
        public string DsCpf { get; set; }
        [Required]
        [Column("ds_rg", TypeName = "varchar(50)")]
        public string DsRg { get; set; }
        [Required]
        [Column("ds_rg_orgao", TypeName = "varchar(50)")]
        public string DsRgOrgao { get; set; }
        [Required]
        [Column("ds_rg_emissor", TypeName = "varchar(50)")]
        public string DsRgEmissor { get; set; }
        [Required]
        [Column("nm_mae", TypeName = "varchar(50)")]
        public string NmMae { get; set; }
        [Required]
        [Column("nm_pai", TypeName = "varchar(50)")]
        public string NmPai { get; set; }
        [Required]
        [Column("tp_contratacao", TypeName = "varchar(50)")]
        public string TpContratacao { get; set; }
        [Column("bt_ativo", TypeName = "bit(1)")]
        public ulong BtAtivo { get; set; }
        [Required]
        [Column("ds_faculdade", TypeName = "varchar(50)")]
        public string DsFaculdade { get; set; }
        [Required]
        [Column("ds_curso", TypeName = "varchar(50)")]
        public string DsCurso { get; set; }
        [Column("dt_faculdade_inicio", TypeName = "date")]
        public DateTime DtFaculdadeInicio { get; set; }
        [Column("dt_faculdade_fim", TypeName = "date")]
        public DateTime DtFaculdadeFim { get; set; }

        [ForeignKey(nameof(IdLogin))]
        [InverseProperty(nameof(TbLogin.TbProfessor))]
        public virtual TbLogin IdLoginNavigation { get; set; }
        [InverseProperty("IdProfessorNavigation")]
        public virtual ICollection<TbModuloDisciplinaProfessor> TbModuloDisciplinaProfessor { get; set; }
        [InverseProperty("IdProfessorNavigation")]
        public virtual ICollection<TbProfessorDisciplina> TbProfessorDisciplina { get; set; }
    }
}

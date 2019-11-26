using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_aluno")]
    public partial class TbAluno
    {
        public TbAluno()
        {
            TbAlunoCarometro = new HashSet<TbAlunoCarometro>();
            TbAlunoDocumentos = new HashSet<TbAlunoDocumentos>();
            TbAlunoFichaMedica = new HashSet<TbAlunoFichaMedica>();
            TbAlunoLocalizacao = new HashSet<TbAlunoLocalizacao>();
            TbAlunoMensalidade = new HashSet<TbAlunoMensalidade>();
            TbDiarioAvaliacaoGeral = new HashSet<TbDiarioAvaliacaoGeral>();
            TbDiarioFrequenciaGeral = new HashSet<TbDiarioFrequenciaGeral>();
            TbTurmaAluno = new HashSet<TbTurmaAluno>();
            TbTurmaAlunoHist = new HashSet<TbTurmaAlunoHist>();
        }

        [Key]
        [Column("id_aluno", TypeName = "int(11)")]
        public int IdAluno { get; set; }
        [Required]
        [Column("nm_aluno", TypeName = "varchar(200)")]
        public string NmAluno { get; set; }
        [Column("dt_nascimento", TypeName = "date")]
        public DateTime DtNascimento { get; set; }
        [Required]
        [Column("ds_rg", TypeName = "varchar(50)")]
        public string DsRg { get; set; }
        [Column("dt_emissao", TypeName = "date")]
        public DateTime DtEmissao { get; set; }
        [Required]
        [Column("ds_orgao", TypeName = "varchar(50)")]
        public string DsOrgao { get; set; }
        [Required]
        [Column("ds_sexo", TypeName = "varchar(50)")]
        public string DsSexo { get; set; }
        [Required]
        [Column("ds_cpf", TypeName = "varchar(50)")]
        public string DsCpf { get; set; }
        [Required]
        [Column("ds_etinia", TypeName = "varchar(50)")]
        public string DsEtinia { get; set; }
        [Required]
        [Column("ds_email", TypeName = "varchar(200)")]
        public string DsEmail { get; set; }
        [Required]
        [Column("ds_celular", TypeName = "varchar(50)")]
        public string DsCelular { get; set; }
        [Required]
        [Column("ds_escolaridade", TypeName = "varchar(50)")]
        public string DsEscolaridade { get; set; }
        [Required]
        [Column("nm_escola", TypeName = "varchar(50)")]
        public string NmEscola { get; set; }
        [Required]
        [Column("tp_escola", TypeName = "varchar(50)")]
        public string TpEscola { get; set; }
        [Required]
        [Column("ds_como_conheceu", TypeName = "varchar(100)")]
        public string DsComoConheceu { get; set; }
        [Column("qt_moram_casa", TypeName = "int(11)")]
        public int QtMoramCasa { get; set; }
        [Column("qt_trabalham_casa", TypeName = "int(11)")]
        public int QtTrabalhamCasa { get; set; }
        [Column("vl_renda", TypeName = "decimal(15,2)")]
        public decimal VlRenda { get; set; }
        [Required]
        [Column("ds_observacao", TypeName = "varchar(2000)")]
        public string DsObservacao { get; set; }
        [Column("dt_inclusao", TypeName = "datetime")]
        public DateTime DtInclusao { get; set; }
        [Column("dt_ultima_alteracao", TypeName = "datetime")]
        public DateTime DtUltimaAlteracao { get; set; }
        [Column("id_funcionario_alteracao", TypeName = "int(11)")]
        public int IdFuncionarioAlteracao { get; set; }

        [InverseProperty("IdAlunoNavigation")]
        public virtual ICollection<TbAlunoCarometro> TbAlunoCarometro { get; set; }
        [InverseProperty("IdAlunoNavigation")]
        public virtual ICollection<TbAlunoDocumentos> TbAlunoDocumentos { get; set; }
        [InverseProperty("IdAlunoNavigation")]
        public virtual ICollection<TbAlunoFichaMedica> TbAlunoFichaMedica { get; set; }
        [InverseProperty("IdAlunoNavigation")]
        public virtual ICollection<TbAlunoLocalizacao> TbAlunoLocalizacao { get; set; }
        [InverseProperty("IdAlunoNavigation")]
        public virtual ICollection<TbAlunoMensalidade> TbAlunoMensalidade { get; set; }
        [InverseProperty("IdAlunoNavigation")]
        public virtual ICollection<TbDiarioAvaliacaoGeral> TbDiarioAvaliacaoGeral { get; set; }
        [InverseProperty("IdAlunoNavigation")]
        public virtual ICollection<TbDiarioFrequenciaGeral> TbDiarioFrequenciaGeral { get; set; }
        [InverseProperty("IdAlunoNavigation")]
        public virtual ICollection<TbTurmaAluno> TbTurmaAluno { get; set; }
        [InverseProperty("IdAlunoNavigation")]
        public virtual ICollection<TbTurmaAlunoHist> TbTurmaAlunoHist { get; set; }
    }
}

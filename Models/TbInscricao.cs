using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_inscricao")]
    public partial class TbInscricao
    {
        public TbInscricao()
        {
            TbInscritoAprovado = new HashSet<TbInscritoAprovado>();
            TbTurmaInscricaoTransicao = new HashSet<TbTurmaInscricaoTransicao>();
        }

        [Key]
        [Column("id_inscricao", TypeName = "int(11)")]
        public int IdInscricao { get; set; }
        [Column("id_ano_letivo", TypeName = "int(11)")]
        public int IdAnoLetivo { get; set; }
        [Required]
        [Column("nm_inscrito", TypeName = "varchar(200)")]
        public string NmInscrito { get; set; }
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
        [Column("ds_nascimento_cidade", TypeName = "varchar(50)")]
        public string DsNascimentoCidade { get; set; }
        [Required]
        [Column("ds_nascimento_estado", TypeName = "varchar(50)")]
        public string DsNascimentoEstado { get; set; }
        [Required]
        [Column("ds_nascimento_pais", TypeName = "varchar(50)")]
        public string DsNascimentoPais { get; set; }
        [Required]
        [Column("ds_residencia_endereco", TypeName = "varchar(500)")]
        public string DsResidenciaEndereco { get; set; }
        [Column("nr_residencia_endereco", TypeName = "int(11)")]
        public int NrResidenciaEndereco { get; set; }
        [Required]
        [Column("ds_residencia_complelemento", TypeName = "varchar(100)")]
        public string DsResidenciaComplelemento { get; set; }
        [Required]
        [Column("ds_residencia_bairro", TypeName = "varchar(300)")]
        public string DsResidenciaBairro { get; set; }
        [Required]
        [Column("ds_residencia_cidade", TypeName = "varchar(100)")]
        public string DsResidenciaCidade { get; set; }
        [Required]
        [Column("ds_residencia_estado", TypeName = "varchar(100)")]
        public string DsResidenciaEstado { get; set; }
        [Required]
        [Column("ds_residencia_cep", TypeName = "varchar(50)")]
        public string DsResidenciaCep { get; set; }
        [Required]
        [Column("ds_email", TypeName = "varchar(200)")]
        public string DsEmail { get; set; }
        [Required]
        [Column("ds_telefone", TypeName = "varchar(50)")]
        public string DsTelefone { get; set; }
        [Required]
        [Column("ds_telefone2", TypeName = "varchar(50)")]
        public string DsTelefone2 { get; set; }
        [Column("nm_contato", TypeName = "varchar(100)")]
        public string NmContato { get; set; }
        [Required]
        [Column("ds_responsavel_nome", TypeName = "varchar(200)")]
        public string DsResponsavelNome { get; set; }
        [Required]
        [Column("ds_responsavel_email", TypeName = "varchar(200)")]
        public string DsResponsavelEmail { get; set; }
        [Required]
        [Column("ds_responsavel_telefone", TypeName = "varchar(50)")]
        public string DsResponsavelTelefone { get; set; }
        [Required]
        [Column("ds_responsavel_telefone2", TypeName = "varchar(50)")]
        public string DsResponsavelTelefone2 { get; set; }
        [Required]
        [Column("ds_responsavel_parentesco", TypeName = "varchar(100)")]
        public string DsResponsavelParentesco { get; set; }
        [Column("id_curso", TypeName = "int(11)")]
        public int IdCurso { get; set; }
        [Required]
        [Column("ds_curso_periodo", TypeName = "varchar(55)")]
        public string DsCursoPeriodo { get; set; }
        [Column("id_curso2", TypeName = "int(11)")]
        public int IdCurso2 { get; set; }
        [Required]
        [Column("ds_curso2_periodo", TypeName = "varchar(50)")]
        public string DsCurso2Periodo { get; set; }
        [Required]
        [Column("ds_escolaridade", TypeName = "varchar(50)")]
        public string DsEscolaridade { get; set; }
        [Required]
        [Column("nm_escola", TypeName = "varchar(50)")]
        public string NmEscola { get; set; }
        [Required]
        [Column("tp_escola", TypeName = "varchar(50)")]
        public string TpEscola { get; set; }
        [Column("vl_renda", TypeName = "decimal(15,2)")]
        public decimal VlRenda { get; set; }
        [Required]
        [Column("ds_como_conheceu", TypeName = "varchar(100)")]
        public string DsComoConheceu { get; set; }
        [Column("qt_moram_casa", TypeName = "int(11)")]
        public int QtMoramCasa { get; set; }
        [Column("qt_trabalham_casa", TypeName = "int(11)")]
        public int QtTrabalhamCasa { get; set; }
        [Required]
        [Column("ds_cor_pele", TypeName = "varchar(50)")]
        public string DsCorPele { get; set; }
        [Column("bt_pendente_rg", TypeName = "bit(1)")]
        public ulong BtPendenteRg { get; set; }
        [Column("bt_pendente_cpf", TypeName = "bit(1)")]
        public ulong BtPendenteCpf { get; set; }
        [Column("bt_pendente_escolaridade", TypeName = "bit(1)")]
        public ulong BtPendenteEscolaridade { get; set; }
        [Column("bt_pendente_pagamento", TypeName = "bit(1)")]
        public ulong BtPendentePagamento { get; set; }
        [Required]
        [Column("ds_observacao", TypeName = "varchar(300)")]
        public string DsObservacao { get; set; }
        [Column("dt_inclusao", TypeName = "datetime")]
        public DateTime DtInclusao { get; set; }
        [Column("dt_ultima_alteracao", TypeName = "datetime")]
        public DateTime DtUltimaAlteracao { get; set; }
        [Column("id_funcionario_alteracao", TypeName = "int(11)")]
        public int IdFuncionarioAlteracao { get; set; }
        [Column("vl_nota", TypeName = "decimal(15,2)")]
        public decimal VlNota { get; set; }
        [Column("_id_sala_vestibular", TypeName = "int(11)")]
        public int IdSalaVestibular { get; set; }
        [Required]
        [Column("ds_situacao", TypeName = "varchar(50)")]
        public string DsSituacao { get; set; }
        [Column("bt_matriculado", TypeName = "bit(1)")]
        public ulong BtMatriculado { get; set; }
        [Column("bt_pendente_comprovresid", TypeName = "bit(1)")]
        public ulong BtPendenteComprovresid { get; set; }
        [Required]
        [Column("ds_responsavel_cpf", TypeName = "varchar(50)")]
        public string DsResponsavelCpf { get; set; }
        [Required]
        [Column("ds_responsavel_rg", TypeName = "varchar(50)")]
        public string DsResponsavelRg { get; set; }
        [Column("cd_inscricao", TypeName = "int(11)")]
        public int CdInscricao { get; set; }
        [Required]
        [Column("ds_email_inscrito", TypeName = "varchar(50)")]
        public string DsEmailInscrito { get; set; }

        [ForeignKey(nameof(IdAnoLetivo))]
        [InverseProperty(nameof(TbAnoLetivo.TbInscricao))]
        public virtual TbAnoLetivo IdAnoLetivoNavigation { get; set; }
        [ForeignKey(nameof(IdCurso2))]
        [InverseProperty(nameof(TbCurso.TbInscricaoIdCurso2Navigation))]
        public virtual TbCurso IdCurso2Navigation { get; set; }
        [ForeignKey(nameof(IdCurso))]
        [InverseProperty(nameof(TbCurso.TbInscricaoIdCursoNavigation))]
        public virtual TbCurso IdCursoNavigation { get; set; }
        [ForeignKey(nameof(IdSalaVestibular))]
        [InverseProperty(nameof(TbSalaVestibular.TbInscricao))]
        public virtual TbSalaVestibular IdSalaVestibularNavigation { get; set; }
        [InverseProperty("IdInscricaoNavigation")]
        public virtual ICollection<TbInscritoAprovado> TbInscritoAprovado { get; set; }
        [InverseProperty("IdInscricaoNavigation")]
        public virtual ICollection<TbTurmaInscricaoTransicao> TbTurmaInscricaoTransicao { get; set; }
    }
}

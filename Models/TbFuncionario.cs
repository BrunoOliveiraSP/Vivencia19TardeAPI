using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_funcionario")]
    public partial class TbFuncionario
    {
        [Key]
        [Column("id_funcionario", TypeName = "int(11)")]
        public int IdFuncionario { get; set; }
        [Column("nm_funcionario", TypeName = "varchar(50)")]
        public string NmFuncionario { get; set; }
        [Column("dt_nascimento", TypeName = "date")]
        public DateTime? DtNascimento { get; set; }
        [Column("ds_endereco", TypeName = "varchar(500)")]
        public string DsEndereco { get; set; }
        [Column("ds_celular", TypeName = "varchar(55)")]
        public string DsCelular { get; set; }
        [Column("ds_telefone", TypeName = "varchar(55)")]
        public string DsTelefone { get; set; }
        [Column("dt_inclusao", TypeName = "datetime")]
        public DateTime? DtInclusao { get; set; }
        [Column("dt_ultima_alteracao", TypeName = "datetime")]
        public DateTime? DtUltimaAlteracao { get; set; }
        [Column("id_funcionario_alteracao", TypeName = "int(11)")]
        public int? IdFuncionarioAlteracao { get; set; }
        [Column("ds_cep", TypeName = "varchar(55)")]
        public string DsCep { get; set; }
        [Column("ds_numero_residencia", TypeName = "int(11)")]
        public int? DsNumeroResidencia { get; set; }
        [Column("ds_email", TypeName = "varchar(55)")]
        public string DsEmail { get; set; }
        [Column("bt_ativo", TypeName = "bit(1)")]
        public ulong? BtAtivo { get; set; }
        [Column("id_login", TypeName = "int(11)")]
        public int? IdLogin { get; set; }

        [ForeignKey(nameof(IdLogin))]
        [InverseProperty(nameof(TbLogin.TbFuncionario))]
        public virtual TbLogin IdLoginNavigation { get; set; }
    }
}

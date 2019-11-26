using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivencia19TardeAPI.Models
{
    [Table("tb_versao_sistema")]
    public partial class TbVersaoSistema
    {
        [Key]
        [Column("id_versao_sistema", TypeName = "int(11)")]
        public int IdVersaoSistema { get; set; }
        [Column("ds_versao", TypeName = "varchar(100)")]
        public string DsVersao { get; set; }
        [Column("ds_caminho", TypeName = "varchar(4000)")]
        public string DsCaminho { get; set; }
        [Column("bt_precisa_atualizar", TypeName = "bit(1)")]
        public ulong? BtPrecisaAtualizar { get; set; }
    }
}

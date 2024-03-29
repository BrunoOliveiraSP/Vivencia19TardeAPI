using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using Vivencia19TardeAPI.Models;

namespace Vivencia19TardeAPI.Database
{
    public class AlunoLocalizacaoDatabase
    {
        Models.db_a5064d_freiContext db = new Models.db_a5064d_freiContext();
        public void Inserir(Models.TbAlunoLocalizacao ModelAlunoLocalizacao)
        {
            db.Add(ModelAlunoLocalizacao);
            db.SaveChanges();
        }

        public List<Models.TbAlunoLocalizacao> Consultar()
        {
            List<Models.TbAlunoLocalizacao> Lista = db.TbAlunoLocalizacao.ToList();

            return Lista;
        } 

        public void Alterar(TbAlunoLocalizacao local)
        {
            Models.TbAlunoLocalizacao alterar = db.TbAlunoLocalizacao.FirstOrDefault(t => t.IdAluno == local.IdAluno);

            alterar.DsNascimentoEstado = local.DsNascimentoEstado;
            alterar.DsNascimentoPais = local.DsNascimentoPais;
            alterar.DsNascimentoCidade = local.DsNascimentoCidade;
            alterar.DsResidenciaBairro = local.DsResidenciaBairro;
            alterar.DsResidenciaCep = local.DsResidenciaCep;
            alterar.DsResidenciaCidade = local.DsResidenciaCidade;
            alterar.DsResidenciaComplelemento = local.DsResidenciaComplelemento;
            alterar.DsResidenciaEndereco = local.DsResidenciaEndereco;
            alterar.DsResidenciaEstado = local.DsResidenciaEstado;
            alterar.DtInclusao = local.DtInclusao;
            alterar.DtUltimaAlteracao= local.DtUltimaAlteracao;
            alterar.NrResidenciaEndereco= local.NrResidenciaEndereco;

            db.SaveChanges();
        }

        public void Deletar(int id)
        {
            Models.TbAlunoLocalizacao remover = db.TbAlunoLocalizacao.FirstOrDefault(a => a.IdAluno == id);

             if(remover != null)
            {
                db.Remove(remover);
                db.SaveChanges();
            }
        }
    }
}
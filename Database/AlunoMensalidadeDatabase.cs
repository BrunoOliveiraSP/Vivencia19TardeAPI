using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using Vivencia19TardeAPI.Models;

namespace Vivencia19TardeAPI.Database
{
    public class AlunoMensalidadeDatabase
    {
        Models.db_a5064d_freiContext db = new Models.db_a5064d_freiContext();
        public void Inserir(Models.TbAlunoMensalidade ModelAlunoMensalidade)
        {
            db.Add(ModelAlunoMensalidade);
        }

        public List<Models.TbAlunoMensalidade> Consultar()
        {
            List<Models.TbAlunoMensalidade> Lista = db.TbAlunoMensalidade.ToList();

            return Lista;
        } 

        public void Alterar(int id,TbAlunoMensalidade mensalidade)
        {
            Models.TbAlunoMensalidade alterar = db.TbAlunoMensalidade.FirstOrDefault(t => t.IdAluno == id);

            alterar.DsEmail = mensalidade.DsEmail;
            alterar.DsParentesco = mensalidade.DsParentesco;
            alterar.DsRg = mensalidade.DsRg;
            alterar.DsTelefone1 = mensalidade.DsTelefone1;
            alterar.DsTelefone2 = mensalidade.DsTelefone2;
            alterar.DtInclusao = mensalidade.DtInclusao;
            alterar.DtUltimaAlteracao = mensalidade.DtUltimaAlteracao;
            alterar.NmResponsavel = mensalidade.NmResponsavel;

            db.SaveChanges();
        }

        public void Deletar(int id)
        {
            Models.TbAlunoMensalidade remover = db.TbAlunoMensalidade.FirstOrDefault(a => a.IdAluno == id);

            db.Remove(remover);
        }
    }
}
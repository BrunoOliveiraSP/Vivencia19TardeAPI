using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
namespace Vivencia19TardeAPI.Database
{
    public class AlunoTurmaDatabase
    {
        Models.db_a5064d_freiContext DB = new Models.db_a5064d_freiContext();
        public void Inserir(Models.TbTurmaAluno turmaAluno)
        {
            DB.TbTurmaAluno.Add(turmaAluno);
            DB.SaveChanges();
        }

        public void alterar(Models.TbTurmaAluno turmaAluno)
        {
            Models.TbTurmaAluno novo = DB.TbTurmaAluno.FirstOrDefault(x=> x.IdAluno == turmaAluno.IdAluno);

            novo.NrChamada = turmaAluno.NrChamada;
            novo.BtAtivo = turmaAluno.BtAtivo;
            novo.BtPermissaoAtraso = turmaAluno.BtPermissaoAtraso;
            novo.CdRa = turmaAluno.CdRa;
            novo.DsObservacao = turmaAluno.DsObservacao;

            DB.SaveChanges();
        } 
    }
}
using System;
using System.Collections.Generic;
using System.Collections;
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

        public void Alterar(Models.TbTurmaAluno turmaAluno)
        {
            Models.TbTurmaAluno novo = DB.TbTurmaAluno.FirstOrDefault(x=> x.IdAluno == turmaAluno.IdAluno);

            novo.NrChamada = turmaAluno.NrChamada;
            novo.BtAtivo = turmaAluno.BtAtivo;
            novo.BtPermissaoAtraso = turmaAluno.BtPermissaoAtraso;
            novo.CdRa = turmaAluno.CdRa;
            novo.DsObservacao = turmaAluno.DsObservacao;

            DB.SaveChanges();
        } 

        public List<Models.TbTurmaAluno> Listar ()
        {
            List<Models.TbTurmaAluno> lista = DB.TbTurmaAluno.ToList();
            return lista;
        }

        public Models.TbTurmaAluno Consultar(Models.TbTurmaAluno turmaAluno)
        {
            Models.TbTurmaAluno Model = DB.TbTurmaAluno.FirstOrDefault(x=> x.IdAluno == turmaAluno.IdAluno);
            return Model;
        }

        public void Deletar (int id)
        {
            Models.TbTurmaAluno Deletar = DB.TbTurmaAluno.FirstOrDefault(x=> x.IdAluno == id);

            DB.Remove(Deletar);
            DB.SaveChanges();
        }

        
    
    }
}
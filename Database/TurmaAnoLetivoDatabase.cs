using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;

namespace Vivencia19TardeAPI.Database
{
    public class TurmaAnoLetivoDatabase
    {
        Vivencia19TardeAPI.Models.db_a5064d_freiContext db = new Models.db_a5064d_freiContext();

        public void CadastrarTurma(Vivencia19TardeAPI.Models.TbTurma turma)
        {
            db.TbTurma.Add(turma);
            db.SaveChanges();
        }

        public List<Vivencia19TardeAPI.Models.TbTurma> ListarTodos()
        {
            List<Models.TbTurma> ano = db.TbTurma.ToList();
            return ano;
        }

        public void Remover(int id)
        {
            Models.TbTurma ano = db.TbTurma.FirstOrDefault(x=>x.IdTurma ==id);

            db.Remove(ano);
            db.SaveChanges();
        }

        public void Alterar(Models.TbTurma  turma)
        {
            Models.TbTurma turmas = db.TbTurma.FirstOrDefault(x=>x.IdTurma == turma.IdTurma);

            turmas.NmTurma = turma.NmTurma;
            turmas.TpPeriodo = turma.TpPeriodo;
            turmas.NrCapacidadeMax = turma.NrCapacidadeMax;
            
            db.SaveChanges();
        }

        // Pessoal Matricula 

        public Models.TbTurma ConsultarPorID (int id)
        {
            Models.TbTurma Turma = db.TbTurma.FirstOrDefault(x=> x.IdTurma == id);
            return Turma;
        }
    }
}
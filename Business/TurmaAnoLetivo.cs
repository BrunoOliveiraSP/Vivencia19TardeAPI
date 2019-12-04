using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Vivencia19TardeAPI.Business
{ 
       
    public class TurmaAnoLetivo
    {
        Database.TurmaAnoLetivoDatabase db = new Database.TurmaAnoLetivoDatabase();
        public void Inserir (Models.TbTurma turma)
        {
            if(turma.NmTurma == string.Empty)
            throw new ArgumentException("Nome da Turma invalido");

            if(turma.TpPeriodo == string.Empty)
            throw new ArgumentException("unidade de tempo invalido");

           db.CadastrarTurma(turma);
        }

        public List<Models.TbTurma> ListarTodos()
        {
           List<Models.TbTurma> lista = db.ListarTodos();
           return lista;
        }

        public void Alterar(Models.TbTurma turma)
        {
            if(turma.IdTurma == 0)
            throw new ArgumentException("Id invalido");

            if(turma.NmTurma == string.Empty)
            throw new ArgumentException("Nome da Turma invalido");

            if(turma.TpPeriodo == string.Empty)
            throw new ArgumentException("unidade de tempo invalido");

            if(turma.NrCapacidadeMax == 0)
            throw new ArgumentException("Id invalido");

            db.Alterar(turma);
        }
        public void Remover(int id)
        {
            if(id == 0)
            throw new ArgumentException("Id invalido");
            
            db.Remover(id);
        }
    }
}
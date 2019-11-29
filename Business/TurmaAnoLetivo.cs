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
           db.CadastrarTurma(turma);
        }

        public List<Models.TbTurma> ListarTodos()
        {
           List<Models.TbTurma> lista = db.ListarTodos();
           return lista;
        }

        public void Alterar(Models.TbTurma turma)
        {
            db.Alterar(turma);
        }
        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
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
            throw new ArgumentException("Nome da Turma invalido.");

            if(turma.TpPeriodo == string.Empty)
            throw new ArgumentException("unidade de tempo invalido.");

            if(turma.IdAnoLetivo == 0)
            throw new ArgumentException("Id inválido.");

            if(turma.NrCapacidadeMax == 0)
            throw new ArgumentException("Cpacidade máxima não pode ser zero.");

            if(turma.IdAnoLetivo == 0)
            throw new ArgumentException("Id inválido.");

           db.Cadastrar(turma);
        }

        public List<Models.TbTurma> ListarTodos()
        {
           List<Models.TbTurma> lista = db.ListarTodos();
           return lista;
        }

        public void Alterar(Models.TbTurma turma)
        {
             if(turma.NmTurma == string.Empty)
            throw new ArgumentException("Nome da Turma invalido.");

            if(turma.TpPeriodo == string.Empty)
            throw new ArgumentException("Unidade de tempo invalido.");

            if(turma.IdAnoLetivo == 0)
            throw new ArgumentException("Id inválido.");

            if(turma.NrCapacidadeMax == 0)
            throw new ArgumentException("Cpacidade máxima não pode ser zero.");

            if(turma.IdAnoLetivo == 0)
            throw new ArgumentException("Id inválido.");
            db.Alterar(turma);
        }
        public void Remover(int id)
        {
            if(id == 0)
            throw new ArgumentException("Id invalido");
            
            db.Remover(id);
        }

        // Pessoal Matricula 

        public Models.TbTurma ConsultarPorID (int id)
        {
            return db.ConsultarPorID(id);
        }
    }
}
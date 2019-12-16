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
        Database.CursoDatabase Curso = new Database.CursoDatabase();
        public void Inserir (Models.TbTurma turma)
        {
            if(turma.TpPeriodo == "Selecione")
            throw new ArgumentException("Período inválido.");

            if(turma.NmTurma == string.Empty)
            throw new ArgumentException("Nome da Turma invalido.");

            if(turma.TpPeriodo == string.Empty)
            throw new ArgumentException("Período invalido.");

            if(turma.IdAnoLetivo == 0)
            throw new ArgumentException("Id inválido.");

            if(turma.NrCapacidadeMax == 0)
            throw new ArgumentException("Capacidade máxima não pode ser zero.");

          
           

            db.Cadastrar(turma);

          
        }
        public void ValidarCurso(Models.TbCurso curso)
        {
            if(curso.NmCurso.Length <3)
            throw new ArgumentException("Curso é obrigatorio.");
        }
         public void ValidarTurma(Models.TbTurma turma)
        {

            if(turma.TpPeriodo == "Selecione")
            throw new ArgumentException("Período inválido.");

            if(turma.NmTurma == string.Empty)
            throw new ArgumentException("Nome da Turma invalido.");

            if(turma.TpPeriodo == string.Empty)
            throw new ArgumentException("Período invalido.");

            if(turma.IdAnoLetivo == 0)
            throw new ArgumentException("Id inválido.");

            if(turma.NrCapacidadeMax == 0)
            throw new ArgumentException("Capacidade máxima não pode ser zero.");

        }

        public List<Models.TurmaResponse> ListarTodos()
        {
           List<Models.TbTurma> lista = db.ListarTodos();

           List<Models.TurmaResponse> response = new List<Models.TurmaResponse>();

           foreach(Models.TbTurma turma in lista)
           {
               Models.TurmaResponse resp = this.CriarResponse(turma);
               response.Add(resp);
           }

           return response;
        }

        private Models.TurmaResponse CriarResponse(Models.TbTurma turma)
        {
            Models.TurmaResponse response = new Models.TurmaResponse();
            
            response.NmCurso = turma.IdCursoNavigation.NmCurso;
            response.NrCapacidadeMax = turma.NrCapacidadeMax;
            response.TpPeriodo = turma.TpPeriodo;
            response.IdTurma = turma.IdTurma;
            response.NmTurma = turma.NmTurma;

            return response;

                
           
        }

        public void Alterar(Models.TbTurma turma)
        {
           this.ValidarTurma(turma);
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
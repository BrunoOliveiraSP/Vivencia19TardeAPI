using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Vivencia19TardeAPI.Business
{
    public class AlunoBusiness
    {
        Database.AlunoDatabase db = new Database.AlunoDatabase();
        public void inserir(Models.TbAluno aluno)
        {
           db.inserir(aluno);
        }

        public List<Models.TbAluno> ListarTodos()
        {
            List<Models.TbAluno> Lista = db.ListarTodos();
            return Lista;
        }
        public List<Models.TbAluno> ConsultarPorNome(string nome, string ra, string curso, string turma, int idanoletivo)
        {
            if (nome == null) nome = string.Empty;
            if (ra == null) ra = string.Empty;
            if (curso == null) curso = string.Empty;
            if (turma == null) turma = string.Empty;

           List<Models.TbAluno> lista = db.ConsultarPorNome(nome, ra, curso, turma, idanoletivo);
           return lista;
        }
        public Models.TbAluno Carregar(Models.TbAluno aluno)
        {
            Models.TbAluno Model = db.Carregar(aluno);
            return Model;
        }
        public void Alterar(Models.TbAluno nova)
        {
           db.Alterar(nova);
        }

        public void Deletar(int id)
        {
            db.Deletar(id);
        }

        public Models.TbAluno consular (Models.TbAluno aluno)
        {
            return db.consultar(aluno);
        }

        
    }
}
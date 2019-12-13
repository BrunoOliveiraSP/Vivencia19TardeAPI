using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Vivencia19TardeAPI.Business
{
    public class AlunoBusiness
    {
        Database.AlunoDatabase DB = new Database.AlunoDatabase();
        public void inserir(Models.TbAluno aluno)
        {
           DB.inserir(aluno);
        }

        public List<Models.TbAluno> ListarTodos()
        {
            List<Models.TbAluno> Lista = DB.ListarTodos();
            return Lista;
        }
        public List<Models.TbAluno> ConsultarPorNome(string nome, string ra, string curso, string turma, int idanoletivo)
        {
           List<Models.TbAluno> lista = DB.ConsultarPorNome(nome, ra, curso, turma, idanoletivo);

           return lista;
        }
        public Models.TbAluno Carregar(Models.TbAluno aluno)
        {
            Models.TbAluno Model = DB.Carregar(aluno);
            return Model;
        }
        public void Alterar(Models.TbAluno nova)
        {
           DB.Alterar(nova);
        }

        public void Deletar(int id)
        {
            DB.Deletar(id);
        }

        public Models.TbAluno consular (Models.TbAluno aluno)
        {
            return DB.consultar(aluno);
        }

        
    }
}
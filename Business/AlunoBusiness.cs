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
           this.validacao(aluno);
           DB.inserir(aluno);
        }
        public List<Models.TbAluno> ListarTodos()
        {
           List<Models.TbAluno> lista = DB.ListarTodos();

           return lista;
        }
        public Models.TbAluno Carregar(Models.TbAluno aluno)
        {
            Models.TbAluno Model = DB.Carregar(aluno);
            return Model;
        }
        public void Alterar(Models.TbAluno nova)
        {
           this.validacao(nova);
           DB.Alterar(nova);
        }

        public void Deletar(Models.TbAluno Aluno)
        {
            DB.Deletar(Aluno);
        }

        private void validacao (Models.TbAluno aluno)
        {
            Models.TbAluno Individuo = DB.Carregar(aluno);

            // if (aluno.DsCpf ==Individuo.DsCpf && )
            // throw new ArgumentException("Este")
        }
    }
}
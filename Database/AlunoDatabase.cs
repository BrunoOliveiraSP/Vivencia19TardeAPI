using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
namespace Vivencia19TardeAPI.Database
{
    public class AlunoDatabase
    {
        Models.db_a5064d_freiContext DB = new Models.db_a5064d_freiContext();
        public void inserir(Models.TbAluno aluno)
        {
            DB.Add(aluno);
            DB.SaveChanges();
        }
        public List<Models.TbAluno> ListarTodos()
        {
            List<Models.TbAluno> alunos = DB.TbAluno.ToList();
            return alunos;
        }
        public Models.TbAluno Carregar(Models.TbAluno aluno)
        {
            Models.TbAluno carregamento =  DB.TbAluno.FirstOrDefault(t=>t.IdAluno == aluno.IdAluno);
            return carregamento;
        }

        public void Alterar(Models.TbAluno nova)
        {
            Models.TbAluno alunos = DB.TbAluno.FirstOrDefault(t=> t.IdAluno == nova.IdAluno);
            alunos.NmAluno = nova.NmAluno;
            alunos.DsCelular = nova.DsCelular;
            alunos.DsComoConheceu = nova.DsComoConheceu;
            alunos.DsCpf = nova.DsCpf;
            alunos.DsEmail = nova.DsEmail;
            alunos.DsEscolaridade = nova.DsEscolaridade;
            alunos.DsEtinia = nova.DsEtinia;
            alunos.DsObservacao = nova.DsObservacao;
            alunos.DsOrgao = nova.DsOrgao;
            alunos.DsRg = nova.DsRg;
            alunos.DsSexo = nova.DsSexo;
            alunos.DtEmissao = nova.DtEmissao;
            alunos.DtInclusao = nova.DtInclusao;
            alunos.DtNascimento = nova.DtNascimento;
            alunos.DtUltimaAlteracao = nova.DtUltimaAlteracao;
            alunos.NmEscola = nova.NmEscola;
            alunos.QtMoramCasa = nova.QtMoramCasa;
            alunos.QtTrabalhamCasa = nova.QtTrabalhamCasa;
            alunos.VlRenda = nova.VlRenda;      
            alunos.TpEscola = nova.TpEscola;
            DB.SaveChanges();
        }

        public void Deletar(int id)
        {
            Models.TbAluno Deletado = DB.TbAluno.FirstOrDefault(t=> t.IdAluno == id);

            DB.Remove(Deletado);
            DB.SaveChanges();
        }
    
        public Models.TbAluno consultar (Models.TbAluno aluno)
        {
            Models.TbAluno consulta = DB.TbAluno.FirstOrDefault(x=> x.NmAluno == aluno.NmAluno);


            return consulta;
        }
    }
}
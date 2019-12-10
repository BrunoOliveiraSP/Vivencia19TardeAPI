using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Vivencia19TardeAPI.Database
{
    public class AlunoDatabase
    {
        Models.db_a5064d_freiContext db = new Models.db_a5064d_freiContext();
        public void inserir(Models.TbAluno aluno)
        {
            db.Add(aluno);
            db.SaveChanges();
        }

        public List<Models.TbAluno> ListarTodos ()
        {
            List<Models.TbAluno> Lista = db.TbAluno.Include(x=> x.TbTurmaAluno)
                                                .ThenInclude(x=> x.IdTurmaNavigation)
                                                .ThenInclude(x=> x.IdCursoNavigation)
                                                .ToList();
            return Lista;
        }
        public List<Models.TbAluno> ConsultarPorNome(string nome, string ra, string curso, string turma)
        {
            List<Models.TbAluno> alunos = db.TbAluno
                                            .Include(x=> x.TbTurmaAluno)
                                                .ThenInclude(x=> x.IdTurmaNavigation)
                                                .ThenInclude(x=> x.IdCursoNavigation)
                                            .Where(x=> x.NmAluno.Contains(nome)
                                            && x.TbTurmaAluno.Any(ta => ta.CdRa.Contains(ra))
                                            && x.TbTurmaAluno.Any(ta => ta.IdTurmaNavigation.IdCursoNavigation.NmCurso.Contains(curso))
                                            && x.TbTurmaAluno.Any(ta => ta.IdTurmaNavigation.NmTurma.Contains(turma)))
                                            .ToList();
            return alunos;
        }

        public List<Models.TbAluno> ListarTodos(string nome, string ra, string curso, string turma)
        {
            List<Models.TbAluno> alunos = db.TbAluno
                                            .Include(x=> x.TbTurmaAluno)
                                                .ThenInclude(x=> x.IdTurmaNavigation)
                                                .ThenInclude(x=> x.IdCursoNavigation)
                                                 .ToList();
            return alunos;
        }
        public Models.TbAluno Carregar(Models.TbAluno aluno)
        {
            Models.TbAluno carregamento =  db.TbAluno.FirstOrDefault(t=>t.IdAluno == aluno.IdAluno);
            return carregamento;
        }

        public void Alterar(Models.TbAluno nova)
        {
            Models.TbAluno alunos = db.TbAluno.FirstOrDefault(t=> t.IdAluno == nova.IdAluno);
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
            db.SaveChanges();
        }

        public void Deletar(int id)
        {
            Models.TbAluno remover = db.TbAluno.FirstOrDefault(t=> t.IdAluno == id);

             if(remover != null)
            {
                db.Remove(remover);
                db.SaveChanges();
            }
        }
    
        public Models.TbAluno consultar (Models.TbAluno aluno)
        {
            Models.TbAluno consulta = db.TbAluno.FirstOrDefault(x=> x.NmAluno == aluno.NmAluno);


            return consulta;
        }
    }
}
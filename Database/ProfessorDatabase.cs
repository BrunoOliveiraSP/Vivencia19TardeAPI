using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Vivencia19TardeAPI.Database
{
    public class ProfessorDatabase
    {
        Models.db_a5064d_freiContext db = new Models.db_a5064d_freiContext();

        public void Inserir(Models.TbProfessor prof)
        {
             db.TbProfessor.Add(prof);
             db.SaveChanges();
        }

        public void Inserir(Models.TbLogin login)
        {
             db.TbLogin.Add(login);
             db.SaveChanges();
        }

        public List<Models.TbProfessor> ListarTodos()
        {
            List<Models.TbProfessor> professores = db.TbProfessor.OrderBy(c => c.NmProfessor)
                                                                .ToList();
            return professores;
        }
        public List<Models.TbProfessor> ConsultarPorNome(string nome)
        {
            List<Models.TbProfessor> professor = db.TbProfessor.Where(t => t.NmProfessor.Contains(nome)).ToList();
            return professor;
        }

        public void RemoverProfessor(int id)
        {
            Models.TbProfessor delete = db.TbProfessor.FirstOrDefault(x => x.IdProfessor == id);
            db.TbProfessor.Remove(delete);
            db.SaveChanges();
        }
 
        public void RemoverLogin(int id)
        {
            Models.TbLogin delete = db.TbLogin.FirstOrDefault(x => x.IdLogin == id);
            db.TbLogin.Remove(delete);
            db.SaveChanges();
        }
        
        public void AlterarProfessor(Models.TbProfessor prof)
        {
            Models.TbProfessor alterado = db.TbProfessor.FirstOrDefault(t => t.IdProfessor == prof.IdProfessor);
           
            alterado.NrAnoPrimeiroEmprego = prof.NrAnoPrimeiroEmprego;
            alterado.DtFaculdadeInicio = prof.DtFaculdadeInicio;
            alterado.DtFaculdadeFim = prof.DtFaculdadeFim;
            alterado.TpContratacao = prof.TpContratacao;
            alterado.DtNascimento = prof.DtNascimento;
            alterado.NmProfessor = prof.NmProfessor;
            alterado.DsRgEmissor = prof.DsRgEmissor;
            alterado.DsFaculdade = prof.DsFaculdade;
            alterado.DsTelefone = prof.DsTelefone;
            alterado.DsCvLattes = prof.DsCvLattes;
            alterado.DsRgOrgao = prof.DsRgOrgao;
            alterado.DsCelular = prof.DsCelular;
            alterado.DsEstado = prof.DsEstado;
            alterado.BtAtivo = prof.BtAtivo;
            alterado.DsCurso = prof.DsCurso;
            alterado.DsEmail = prof.DsEmail;
            alterado.DsCpf = prof.DsCpf;
            alterado.NmMae = prof.NmMae;
            alterado.NmPai = prof.NmPai;
            alterado.DsRg = prof.DsRg;
            
            db.SaveChanges();
        }

        public void AlterarLogin(Models.TbLogin login)
        {
            Models.TbLogin alterado = db.TbLogin.FirstOrDefault(t => t.IdLogin == login.IdLogin);
            
            alterado.DsSenha = login.DsSenha;
            alterado.DsLogin = login.DsLogin;
            alterado.BtAtivo = login.BtAtivo;
            alterado.DsLogin = login.DsLogin;

            db.SaveChanges();
        }

        
    }
}
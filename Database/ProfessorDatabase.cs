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

        public void InserirProfessor(Models.TbProfessor prof)
        {
             db.TbProfessor.Add(prof);
             db.SaveChanges();
        }

        public void InserirLogin(Models.TbLogin login)
        {
             db.TbLogin.Add(login);
             db.SaveChanges();
        }

        public List<Models.TbProfessor> ListarTodos()
        {
            List<Models.TbProfessor> professor = db.TbProfessor.ToList();

            return professor;
        }
        public List<Models.TbProfessor> ConsultarPorNome(string nome)
        {
            List<Models.TbProfessor> professor = db.TbProfessor.Where(t => t.NmProfessor.Contains(nome)).ToList();

            return professor;
        }

        public void Remover(int id)
        {
             db.Remove(id);
             db.SaveChanges();
        }

        public void Alterar(Models.TbProfessor prof)
        {
            Models.TbProfessor alterado = db.TbProfessor.FirstOrDefault(t => t.IdProfessor == prof.IdProfessor);
            
           
            alterado.NmProfessor = prof.NmProfessor;
            alterado.DsCelular = prof.DsCelular;
            alterado.DsTelefone = prof.DsTelefone;
            alterado.DtNascimento = prof.DtNascimento;
            alterado.DsEstado = prof.DsEstado;
            alterado.DsEmail = prof.DsEmail;
            alterado.DsCvLattes = prof.DsCvLattes ;
            alterado.NrAnoPrimeiroEmprego = prof.NrAnoPrimeiroEmprego;
            alterado.DsCpf = prof.DsCpf;
            alterado.DsRg = prof.DsRg;
            alterado.DsRgOrgao = prof.DsRgOrgao;
            alterado.DsRgEmissor = prof.DsRgEmissor;
            alterado.NmMae = prof.NmMae;
            alterado.NmPai = prof.NmPai;
            alterado.TpContratacao = prof.TpContratacao;
            alterado.BtAtivo = prof.BtAtivo;
            alterado.DsFaculdade = prof.DsFaculdade;
            alterado.DsCurso = prof.DsCurso;
            alterado.DtFaculdadeInicio = prof.DtFaculdadeInicio;
            alterado.DtFaculdadeFim = prof.DtFaculdadeFim;

            db.SaveChanges();
        }







        

        
        
    }
}
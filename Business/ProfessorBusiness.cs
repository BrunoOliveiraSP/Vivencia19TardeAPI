using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Vivencia19TardeAPI.Business
{
    public class ProfessorBusiness
    {
        Database.ProfessorDatabase db = new Database.ProfessorDatabase();
        public void Inserir(Models.ProfessorRequest prof)
        {
            if(string.IsNullOrEmpty(prof.Professor.NmProfessor))
                throw new Exception("O Campo 'NOME' esta Invalido!");
            
            prof.Login.DsSenha = "1234";
            prof.Login.BtTrocar = true;
            prof.Login.DtInclusao = DateTime.Now;
            prof.Login.DtUltimoLogin = DateTime.Now;
            prof.Login.IdRole = 1;

            db.InserirLogin(prof.Login);

            prof.Professor.IdLogin = prof.Login.IdLogin;
            db.InserirProfessor(prof.Professor);
        }

        public List<Models.TbProfessor> ListarTodos()
        {
            List<Models.TbProfessor>lista = db.ListarTodos();
            return lista;
        }
        public List<Models.TbProfessor> ConsultarPorNome(string nome)
        {
            List<Models.TbProfessor>lista = db.ConsultarPorNome(nome);
            return lista;
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }

        public void Alterar(Models.TbProfessor prof)
        {
           db.Alterar(prof);
        }
    }
}
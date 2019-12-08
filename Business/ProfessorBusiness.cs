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
            if (string.IsNullOrEmpty(prof.Professor.NmProfessor))
                throw new Exception("O Campo 'NOME' esta Invalido!");

            prof.Login.IdRole = 1;
            prof.Login.BtTrocar = true;
            prof.Login.DsSenha = "1234";
            prof.Login.DtInclusao = DateTime.Now;
            prof.Login.DtUltimoLogin = DateTime.Now;
            
            db.Inserir(prof.Login);

            prof.Professor.IdLogin = prof.Login.IdLogin;
            db.Inserir(prof.Professor);
        }

        public List<Models.TbProfessor> ListarTodos()
        {
            List<Models.TbProfessor> lista = db.ListarTodos();
            return lista;
        }

        public List<Models.TbProfessor> ConsultarPorNome(string nome)
        {
            List<Models.TbProfessor> lista = db.ConsultarPorNome(nome);
            return lista;
        }

        public void Remover(int idProfessor,int idLogin )
        {
            db.RemoverProfessor(idProfessor);
            db.RemoverLogin(idLogin);
        }

        public void Alterar(Models.ProfessorRequest prof)
        {
            db.AlterarProfessor(prof.Professor);
            
            prof.Login.BtTrocar = true;
            prof.Login.DtInclusao = DateTime.Now;
            prof.Login.DtUltimoLogin = DateTime.Now;
            prof.Login.IdRole = 1;

            db.AlterarLogin(prof.Login);
        }  
    }
}
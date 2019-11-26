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
        public void Inserir(Models.TbProfessor prof)
        {
            #region |NmProfessor|
            if(string.IsNullOrWhiteSpace(prof.NmProfessor))
            throw new Exception("O Campo 'NOME' esta Invalido!");
            
            Utils.Validador.CaracteresEspeciais(prof.NmProfessor);
            #endregion

            #region |DsCelular, DsTelefone|
            if(string.IsNullOrEmpty(prof.DsCelular))
            throw new Exception("O Campo 'CELULAR' esta Invalido!");

            if(string.IsNullOrEmpty(prof.DsTelefone))
            throw new Exception("O Campo 'TELEFONE' esta Invalido!");

            #endregion

            #region |DtNascimento|
            if(prof.DtNascimento < DateTime.Now)

            #endregion



            

         
            db.Inserir(prof);
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
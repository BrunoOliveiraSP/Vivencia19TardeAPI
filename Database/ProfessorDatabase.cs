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
             db.Add(prof);
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



        }







        

        
        
    }
}
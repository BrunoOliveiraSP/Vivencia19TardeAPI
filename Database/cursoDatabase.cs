using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;

namespace Vivencia19TardeAPI.Database
{
    public class cursoDatabase
    {
       Models.db_a5064d_freiContext db = new Models.db_a5064d_freiContext();
       public void Inserir(Models.TbCurso curso)
       {
           db.TbCurso.Add(curso);
           db.SaveChanges();
       } 

        public void Alterar(Models.TbCurso curso)
        {
            Models.TbCurso alt = db.TbCurso.FirstOrDefault(x => x.NmCurso == curso.NmCurso
                                                          || x.DsSigla == curso.DsSigla);
            
            alt.NmCurso = curso.NmCurso;
            alt.DsSigla = curso.DsSigla;
            alt.NrCapacidadeMaxima = curso.NrCapacidadeMaxima;
            alt.BtAtivo = curso.BtAtivo;

            db.SaveChanges();
        }

        public void Remover(int id)
        {
            Models.TbCurso remover = db.TbCurso.FirstOrDefault(x => x.IdCurso == id);
            db.Remove(remover);
            
            db.SaveChanges();
    
        }

        public List<Models.TbCurso> ListarTodos()
        {
            List<Models.TbCurso> cursos = db.TbCurso.ToList();

            return cursos;
        }

        public List<Models.TbCurso> ConsultarPorNome(String NomeCurso)
        {
            List<Models.TbCurso> cursos = db.TbCurso.Where(t => t.NmCurso.Contains(NomeCurso)).ToList();
            return cursos;
        }

        public List<Models.TbCurso> ConsultarPorSigla(String Sigla)
        {
            List<Models.TbCurso> cursos = db.TbCurso.Where(t => t.DsSigla.Contains(Sigla)).ToList();
            return cursos;
        }

    }
}
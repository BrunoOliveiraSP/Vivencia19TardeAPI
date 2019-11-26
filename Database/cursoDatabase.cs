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
    }
}
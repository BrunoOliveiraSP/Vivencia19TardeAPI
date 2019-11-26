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
    }
}